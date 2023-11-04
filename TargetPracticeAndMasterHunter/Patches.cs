using HarmonyLib;
using Il2Cpp;
using MelonLoader;
using System.Collections;
using UnityEngine;

namespace TargetPracticeAndMasterHunter
{
    internal class Patches
    {
        public static int nbPoints = 0;
        public static float executionTime = Time.time;
        public static float executionTimeStone = Time.time;
        public static string[,] recordDistance = new string[13, 6];
        public static string? serializedData = null;


        [HarmonyPatch(typeof(SaveGameSystem), nameof(SaveGameSystem.LoadSceneData))]
        public class LoadRecords
        {
            public static void Postfix(ref string name)
            {
                MelonCoroutines.Start(LoadRecordsDistances());
            }

            private static IEnumerator LoadRecordsDistances()
            {
                SaveDataManager sdm = TargetPracticeAndMasterHunter.sdm;

                string? serializedData = sdm.Load("records");
                int numRows = 13;
                int numCols = 6;

                if (string.IsNullOrEmpty(serializedData))
                {
                    float waitSeconds = 1.5f;
                    for (float t = 0f; t < waitSeconds; t += Time.deltaTime) yield return null;
                    serializedData = sdm.Load("records");
                }

                //MelonLogger.Msg(serializedData);

                if (!string.IsNullOrEmpty(serializedData))
                {
                    string[] dataArray = serializedData.Split(';');

                    if (dataArray.Length == numRows * numCols)
                    {
                        string[,] resultArray = new string[numRows, numCols];

                        for (int i = 0; i < numRows; i++)
                        {
                            for (int j = 0; j < numCols; j++)
                            {
                                resultArray[i, j] = dataArray[i * numCols + j];
                            }
                        }

                        //MelonLogger.Msg("LoadAndDeserializeArray: Data loaded successfully.");
                        recordDistance = resultArray;
                    }
                    else
                    {
                        //MelonLogger.Error("LoadAndDeserializeArray: Data length does not match the expected dimensions.");
                    }
                }
                else
                {
                    recordDistance = recordDistanceTemplate;
                    //MelonLogger.Error("LoadAndDeserializeArray: No data loaded.");
                }
            }

            private static readonly string[,] recordDistanceTemplate = new string[,]
            {
                { "Target","Rif.", "Rev.", "Bow", "Fla.", "Sto." },
                { "RecycledCan", "0,0", "0,0", "N/A", "N/A", "N/A" },
                { "SprayPaint", "0,0", "0,0", "N/A", "N/A", "N/A" },
                { "Bullseye", "0,0", "0,0", "0,0", "0,0", "0,0" },
                { "HayBale", "N/A", "N/A", "0,0", "N/A", "N/A" },
                { "Rabbit", "0,0", "0,0", "0,0", "0,0", "0,0" },
                { "Ptarmigan", "0,0", "0,0", "0,0", "0,0", "0,0" },
                { "Stag", "0,0", "0,0", "0,0", "0,0", "0,0" },
                { "Doe", "0,0", "0,0", "0,0", "0,0", "0,0" },
                { "Wolf", "0,0", "0,0", "0,0", "0,0", "0,0" },
                { "Cougar", "0,0", "0,0", "0,0", "0,0", "0,0" },
                { "Bear", "0,0", "0,0", "0,0", "0,0", "0,0" },
                { "Moose", "0,0", "0,0", "0,0", "0,0", "0,0" }
            };

        }


        [HarmonyPatch(typeof(ArrowItem), nameof(ArrowItem.HandleCollisionWithObject))]
        internal class ArrowItem_HandleCollisionWithObject_Patch
        {
            private static bool Prefix(ArrowItem __instance, GameObject collider, Vector3 collisionPoint)
            {
                int nbPoints;

                int archerylevel = GameManager.GetSkillArchery().GetCurrentTierNumber();
                Vector3 playerPosition = GameManager.GetVpFPSPlayer().transform.position;
                float distance = Vector3.Distance(playerPosition, collisionPoint);
                string colliderName = collider.name.StartsWith("capsule") ? collider.transform.parent.transform.parent.name : collider.name;

                // MelonLogger.Msg("HandleCollision");
                nbPoints = Utilities.CalculatePointsAndMore(colliderName, SkillType.Archery, archerylevel, distance, collisionPoint, playerPosition, collider.name);

                if (nbPoints > 0)
                {
                    GameManager.GetSkillsManager().IncrementPointsAndNotify(SkillType.Archery, nbPoints, SkillsManager.PointAssignmentMode.AssignOnlyInSandbox);
                }

                return true;
            }
        }

        [HarmonyPatch(typeof(vp_Bullet), nameof(vp_Bullet.SpawnImpactEffects))]
        class vp_Bullet_SpawnImpactEffects_Patch
        {
            private static bool Prefix(vp_Bullet __instance, RaycastHit hit)
            {
                int nbPoints;
                int riflelevel = GameManager.GetSkillRifle().GetCurrentTierNumber();
                int revolverlevel = GameManager.GetSkillRevolver().GetCurrentTierNumber();
                Vector3 playerPosition = GameManager.GetVpFPSPlayer().transform.position;
                Vector3 collisionPoint = hit.point;
                float distance = Vector3.Distance(playerPosition, collisionPoint);
                string colliderName = hit.collider.name.StartsWith("capsule") ? hit.collider.transform.parent.transform.parent.name : hit.collider.name;

                if (__instance.name.StartsWith("PistolBullet"))
                {
                    //MelonLogger.Msg(__instance.name);
                    nbPoints = Utilities.CalculatePointsAndMore(colliderName, SkillType.Rifle, riflelevel, distance, collisionPoint, playerPosition, hit.collider.name);

                    if (nbPoints > 0)
                    {
                        GameManager.GetSkillsManager().IncrementPointsAndNotify(SkillType.Rifle, nbPoints, SkillsManager.PointAssignmentMode.AssignOnlyInSandbox);
                    }
                }
                else if (__instance.name.StartsWith("RevolverBullet"))
                {
                    //MelonLogger.Msg(__instance.name);
                    nbPoints = Utilities.CalculatePointsAndMore(colliderName, SkillType.Revolver, revolverlevel, distance, collisionPoint, playerPosition, hit.collider.name);

                    if (nbPoints > 0)
                    {
                        GameManager.GetSkillsManager().IncrementPointsAndNotify(SkillType.Revolver, nbPoints, SkillsManager.PointAssignmentMode.AssignOnlyInSandbox);
                    }
                }
                return true;
            }
        }


        [HarmonyPatch(typeof(StoneItem), nameof(StoneItem.OnCollisionEnter))]
        class StoneItem_OnCollisionEnter_Patch
        {
            private static bool Prefix(StoneItem __instance, Collision collisionInfo)
            {
                //MelonLogger.Msg(collisionInfo.collider.name);
                //Optimisation attempt... 
                if (collisionInfo.collider.name.Contains("errain") || Time.time - executionTimeStone < 1f) return true;

                Vector3 playerPosition = GameManager.GetVpFPSPlayer().transform.position;
                Vector3 collisionPoint = __instance.transform.position;
                float distance = Vector3.Distance(playerPosition, collisionPoint);
                string colliderName = collisionInfo.collider.name.StartsWith("capsule") ? collisionInfo.collider.transform.parent.transform.parent.name : collisionInfo.collider.name;

                string messageTarget = "";


                if (colliderName.Contains("WILDLIFE"))
                {
                    executionTimeStone = Time.time;
                    messageTarget += Utilities.UpdateRecords(colliderName, distance, 5);
                    messageTarget += "Target : " + colliderName.Substring(9);
                    messageTarget += "\nBody part : " + collisionInfo.collider.name.Substring(8);
                    messageTarget += "\nDistance : " + Math.Round(distance, 1);
                }
                else if (colliderName.Contains("Bullseye"))
                {
                    if (!(collisionPoint.x > 1646.7 && collisionPoint.x < 1647.2 && collisionPoint.y > 43.9 && collisionPoint.y < 44.7 && collisionPoint.z > 1827.9 && collisionPoint.z < 1828.6)) return true;

                    executionTimeStone = Time.time;
                    messageTarget += Utilities.UpdateRecords(colliderName, distance, 5);
                    messageTarget += "Target : Bullseye";
                    messageTarget += "\nDistance : " + Math.Round(distance, 1);
                }

                if (Settings.settings.updateHUD)
                {
                    HUDMessage.AddMessage(messageTarget, 4);
                }

                return true;
            }
        }

        [HarmonyPatch(typeof(FlareGunRoundItem), nameof(FlareGunRoundItem.HandleCollisionWithObject))]
        internal class FlareGunRoundItem_HandleCollisionWithObject_Patch
        {
            private static bool Prefix(FlareGunRoundItem __instance, GameObject colliderGO, Vector3 collisionPoint, Vector3 collisionNormal, Vector3 relativeVelocity)
            {

                Vector3 playerPosition = GameManager.GetVpFPSPlayer().transform.position;
                float distance = Vector3.Distance(playerPosition, collisionPoint);
                string colliderName = colliderGO.name.StartsWith("capsule") ? colliderGO.transform.parent.transform.parent.name : colliderGO.name;
                string messageTarget = "";


                if (colliderName.Contains("WILDLIFE"))
                {
                    messageTarget += Utilities.UpdateRecords(colliderName, distance, 4);
                    messageTarget += "Target : " + colliderName.Substring(9);
                    messageTarget += "\nBody part : " + colliderGO.name.Substring(8);
                    messageTarget += "\nDistance : " + Math.Round(distance, 1);
                }
                else if (colliderName.Contains("Bullseye"))
                {
                    if (!(collisionPoint.x > 1646.7 && collisionPoint.x < 1647.2 && collisionPoint.y > 43.9 && collisionPoint.y < 44.7 && collisionPoint.z > 1827.9 && collisionPoint.z < 1828.6)) return true;

                    messageTarget += Utilities.UpdateRecords(colliderName, distance, 4);
                    messageTarget += "Target : Bullseye";
                    messageTarget += "\nDistance : " + Math.Round(distance, 1);
                }

                if (Settings.settings.updateHUD)
                {
                    HUDMessage.AddMessage(messageTarget, 4);
                }
                return true;
            }
        }

        [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.IncrementPointsAndNotify))]
        class SkillsManager_IncrementPointsAndNotify_Patch
        {
            static bool Prefix(SkillsManager __instance, SkillType skillType, int numPoints, SkillsManager.PointAssignmentMode mode)
            {
                //MelonLogger.Msg("Prefix");
                // Disable prefix if Master Hunter is disabled
                if (!Settings.settings.updateMasterHunter) return true;
                //MelonLogger.Msg("MasterHunter Enabled");
                // UNTOUCHED : Other skills won't be skipped by this prefix
                // UNTOUCHED : Points earned through knowledge books won't be skipped by this prefix (Meaning books have to provide at least 2 points...)
                // BLOCKED : Points earn when hitting an animal no matter the distance will be skipped by this prefix
                // BLOCKED : Points from crafting arrows will be skipped by this prefix (even if not disabled in mod settings)
                if (numPoints == 1 && (skillType == SkillType.Rifle || skillType == SkillType.Revolver || skillType == SkillType.Archery)) return false;

                return true;
            }

            static void Postfix(SkillsManager __instance, SkillType skillType, int numPoints, SkillsManager.PointAssignmentMode mode)
            {
                //MelonLogger.Msg("PostFix");
                //Prevent the second post fix to "happen" in order to deal with arrow crafting skill points.
                //MelonLogger.Msg(Time.time);
                //MelonLogger.Msg(executionTime);
                if (Time.time - executionTime < 0.1f) return;

                // Disable postfix if Master Hunter is disabled
                if (!Settings.settings.updateMasterHunter) return;
                //MelonLogger.Msg("MH option");
                // UNTOUCHED : Other skills won't be postfixed
                if (skillType != SkillType.Rifle && skillType != SkillType.Revolver && skillType != SkillType.Archery) return;
                //MelonLogger.Msg("Skill check");
                //MelonLogger.Msg("Global points" + nbPoints);
                //MelonLogger.Msg("Param points" + numPoints);
                // UNTOUCHED : Points earned through knowledge
                // UNTOUCHED : Points > 1 from incremental bonus
                if (numPoints > 1)
                {
                    // Variable is reset for incremental bonus
                    nbPoints = 0;
                    return;
                }
                //(nbPoints == 0 && !Settings.settings.updateCraftingSkillPoints) >>> Allow point from crafted arrows
                //((nbPoints == 0 && numPoints == 1)) >>> Allow points that effectively pass the conditions
                else if ((nbPoints == 0 && !Settings.settings.updateCraftingSkillPoints) || ((nbPoints == 1 && numPoints == 1)))
                {
                    //MelonLogger.Msg("CalculPoints");
                    Skill skill = GameManager.GetSkillsManager().GetSkill(skillType);
                    if ((bool)skill && skill.GetPoints() != skill.GetMaxPoints())
                    {
                        int currentTierNumber = skill.GetCurrentTierNumber();
                        skill.IncrementPoints(1, mode);
                        int currentTierNumber2 = skill.GetCurrentTierNumber();
                        GameManager.GetSkillNotify().MaybeShowPointIncrease(skill.m_SkillIcon);
                        if (currentTierNumber2 > currentTierNumber)
                        {
                            GameManager.GetAchievementManagerComponent().UpdateAchievements();
                            GameManager.GetSkillNotify().MaybeShowLevelUp(skill.m_SkillIconBackground, skill.m_DisplayName, __instance.GetTierName(currentTierNumber2), currentTierNumber2 + 1);
                        }
                    }
                    nbPoints = 0;
                }
                executionTime = Time.time;
            }
        }
    }
}
