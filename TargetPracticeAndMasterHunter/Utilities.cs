using Il2Cpp;
using UnityEngine;
using Random = UnityEngine.Random;

namespace TargetPracticeAndMasterHunter
{
    public class Utilities
    {
        public static void MakePerpendicularSideStep(Vector3 collisionPoint, Vector3 playerPosition)
        {
            Vector3 toTarget = collisionPoint - playerPosition;
            toTarget.y = 0;
            toTarget.Normalize();
            Vector3 perpendicular = new Vector3(-toTarget.z, 0, toTarget.x).normalized;
            float randomNumber = Random.Range(0, 2) == 0 ? Random.Range(-0.30f, -0.10f) : Random.Range(0.10f, 0.30f);
            Vector3 randomMovement = perpendicular * randomNumber;
            GameManager.GetVpFPSPlayer().Controller.AddForce(randomMovement);
        }

        public static void NotifySkillIconWithoutPointIncrease(SkillType skillType)
        {
            Skill skill = GameManager.GetSkillsManager().GetSkill(skillType);
            GameManager.GetSkillNotify().MaybeShowPointIncrease(skill.m_SkillIcon);
        }

        public static int CalculatePointsAndMore(string targetName, SkillType skillType, int currentLevel, float distance, Vector3 collisionPoint, Vector3 playerPosition, string capsuleName)
        {
            string messageTarget = "";
            string messageScore = "";
            int numPoints = 0;

            string[,]? references = skillType switch
            {
                SkillType.Archery => TargetPracticeAndMasterHunter.referencesBow,
                SkillType.Rifle => TargetPracticeAndMasterHunter.referencesRifle,
                SkillType.Revolver => TargetPracticeAndMasterHunter.referencesRevolver,
                _ => null
            };

            int recordIndex = skillType switch
            {
                SkillType.Archery => 3,
                SkillType.Rifle => 1,
                SkillType.Revolver => 2,
                _ => -1
            };

            if (references == null) return numPoints;

            for (int i = 0; i < references.GetLength(0); i++)
            {
                if (targetName.Contains(references[i, 0]) && (references[i, 1] == (currentLevel + 1).ToString() || currentLevel == 4))
                {
                    //MelonLogger.Msg("targetNameInLoop");
                    if (targetName == "OBJ_BullseyeTarget_Prefab")
                    {
                        // Must hit the paper bullseye (not the outer rim)
                        if (!(collisionPoint.x > 1646.7 && collisionPoint.x < 1647.2 && collisionPoint.y > 43.9 && collisionPoint.y < 44.7 && collisionPoint.z > 1827.9 && collisionPoint.z < 1828.6)) break;
                    }
                    messageTarget += Utilities.UpdateRecords(targetName, distance, recordIndex);
                    messageTarget += "Target : " + references[i, 0];
                    if (targetName.Contains("WILDLIFE")) messageTarget += "\nBody part : " + capsuleName.Substring(8);
                    messageTarget += "\nDistance : " + Math.Round(distance, 1);

                    //If your skill is maxed out
                    if (currentLevel == 4)
                    {
                        if (Settings.settings.updateSkillIcon)
                        {
                            NotifySkillIconWithoutPointIncrease(skillType);
                        }
                        if (Settings.settings.updateSideStep && !targetName.Contains("WILDLIFE"))
                        {
                            MakePerpendicularSideStep(collisionPoint, playerPosition);
                        }
                    }
                    else if (distance >= int.Parse(references[i, 2]))
                    {
                        numPoints = 1;
                        if (Settings.settings.updateHeadshotBonus)
                        {
                            if (capsuleName.Contains("head")) numPoints += 1;
                        }

                        if (Settings.settings.updateIncrementalBonus)
                        {
                            numPoints -= 1;
                            for (int j = i; j < (i + (4 - currentLevel)); j++)
                            {
                                if (distance >= int.Parse(references[j, 2]))
                                {
                                    numPoints += 1;
                                }
                                else
                                {
                                    break;
                                }
                            }
                        }
                        //MelonLogger.Msg("points : " + numPoints);
                    }
                    if (Settings.settings.updateSideStep && !targetName.Contains("WILDLIFE"))
                    {
                        MakePerpendicularSideStep(collisionPoint, playerPosition);
                    }
                    break;
                }
            }
            // By Disabling Master Hunter you "enable" vanilla point from hitting animals and you earn therefore 1 more point, this solve the issue.
            if (targetName.Contains("WILDLIFE") && !Settings.settings.updateMasterHunter) numPoints -= 1;
            //MelonLogger.Msg("points : " + numPoints);
            Patches.nbPoints = numPoints;

            if (Settings.settings.updateHUD)
            {
                if (numPoints > 0)
                {
                    messageScore += "\nPoint(s) earned : " + numPoints;
                }
                HUDMessage.AddMessage(messageTarget, 4);
                HUDMessage.AddMessage(messageScore);
            }

            return numPoints;
        }

        public static string UpdateRecords(string targetName, float distance, int weaponIndex)
        {
            string messageRecord = "";
            float currentRecord = 0f;
            int numRows = Patches.recordDistance.GetLength(0);
            int numCols = Patches.recordDistance.GetLength(1);

            int rowIndex = -1;
            for (int i = 1; i < numRows; i++)
            {
                if (targetName.Contains(Patches.recordDistance[i, 0]))
                {
                    rowIndex = i;
                    break;
                }
            }

            if (rowIndex >= 1)
            {
                if (weaponIndex >= 1 && weaponIndex < numCols)
                {
                    if (float.TryParse(Patches.recordDistance[rowIndex, weaponIndex], out currentRecord))
                    {
                        if (distance > currentRecord)
                        {
                            Patches.recordDistance[rowIndex, weaponIndex] = Math.Round(distance, 1).ToString();
                            messageRecord += "New record!!!\n";
                        }
                    }
                }
            }

            TargetPracticeAndMasterHunter.sdm.SerializeAndSaveArray(Patches.recordDistance);

            return messageRecord;
        }

    }
}
