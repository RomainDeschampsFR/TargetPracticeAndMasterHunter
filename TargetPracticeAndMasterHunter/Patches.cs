using HarmonyLib;
using Il2Cpp;
using UnityEngine;

namespace TargetPracticeAndMasterHunter
{
    public static class GlobalVariable
    {
        public static int nbPoints = 0;
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

            nbPoints = Utilities.CalculatePointsAndMore(colliderName, SkillType.Archery, archerylevel, distance, collisionPoint, playerPosition);

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
                nbPoints = Utilities.CalculatePointsAndMore(colliderName, SkillType.Rifle, riflelevel, distance, collisionPoint, playerPosition);

                if (nbPoints > 0)
                {
                    GameManager.GetSkillsManager().IncrementPointsAndNotify(SkillType.Rifle, nbPoints, SkillsManager.PointAssignmentMode.AssignOnlyInSandbox);
                }
            }
            else if (__instance.name.StartsWith("RevolverBullet"))
            {
                nbPoints = Utilities.CalculatePointsAndMore(colliderName, SkillType.Revolver, revolverlevel, distance, collisionPoint, playerPosition);

                if (nbPoints > 0)
                {
                    GameManager.GetSkillsManager().IncrementPointsAndNotify(SkillType.Revolver, nbPoints, SkillsManager.PointAssignmentMode.AssignOnlyInSandbox);
                }
            }
            return true;
        }
    }

    [HarmonyPatch(typeof(SkillsManager), nameof(SkillsManager.IncrementPointsAndNotify))]
    class SkillsManager_IncrementPointsAndNotify_Patch
    {
        static bool Prefix(SkillsManager __instance, SkillType skillType, int numPoints, SkillsManager.PointAssignmentMode mode)
        {
            // Disable prefix if Master Hunter is disabled
            if (!Settings.settings.updateMasterHunter) return true;

            // UNTOUCHED : Other skills won't be skipped by this prefix
            // UNTOUCHED : Points earned through knowledge books won't be skipped by this prefix (Meaning books have to provide at least 2 points...)
            // BLOCKED : Points earn when hitting an animal no matter the distance will be skipped by this prefix
            // BLOCKED : Points from crafting arrows will be skipped by this prefix (even if not disabled in mod settings)
            if (numPoints == 1 && (skillType == SkillType.Rifle || skillType == SkillType.Revolver || skillType == SkillType.Archery)) return false;

            return true;
        }

        static void Postfix(SkillsManager __instance, SkillType skillType, int numPoints, SkillsManager.PointAssignmentMode mode)
        {
            // Disable postfix if Master Hunter is disabled
            if (!Settings.settings.updateMasterHunter) return;

            // UNTOUCHED : Other skills won't be postfixed
            if (skillType != SkillType.Rifle || skillType != SkillType.Revolver || skillType != SkillType.Archery) return;

            // UNTOUCHED : Points earned through knowledge
            // UNTOUCHED : Points > 1 from incremental bonus
            if (numPoints > 1)
            {
                // Variable is reset for incremental bonus
                GlobalVariable.nbPoints = 0;
                return;
            }
            //(GlobalVariable.nbPoints == 0 && !Settings.settings.updateCraftingSkillPoints) >>> Allow point from crafted arrows
            //((GlobalVariable.nbPoints == 0 && numPoints == 1)) >>> Allow points that effectively pass the conditions
            else if ((GlobalVariable.nbPoints == 0 && !Settings.settings.updateCraftingSkillPoints) || ((GlobalVariable.nbPoints == 1 && numPoints == 1)))
            {
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
                GlobalVariable.nbPoints = 0;
            }
        }
    }
}
