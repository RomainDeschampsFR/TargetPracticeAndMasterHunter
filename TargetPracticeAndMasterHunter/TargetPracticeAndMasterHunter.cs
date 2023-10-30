using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace TargetPracticeAndMasterHunter
{
    public class TargetPracticeAndMasterHunter : MelonMod
    {
        public static GearItem GetGearItemPrefab(string name) => GearItem.LoadGearItemPrefab(name).GetComponent<GearItem>();

        public static void ChangePrefabCraftingSkillPoints(string name)
        {
            GearItem gearItem = GetGearItemPrefab(name);

            if (gearItem == null)
            {
                MelonLogger.Msg(name + " GearItem Prefab is NULL!");
                return;
            }
            ArrowItem arrowItem = gearItem.GetComponent<ArrowItem>();
            if (arrowItem == null)
            {
                MelonLogger.Msg(name + " ArrowItem Prefab is NULL!");
                return;
            }
            arrowItem.m_CraftingSkillPoints = 0;
        }

        public static void ChangePrefabResearchItems(string name, int points, int time)
        {
            GearItem gearItem = GetGearItemPrefab(name);
            if (gearItem == null)
            {
                MelonLogger.Msg(name + " GearItem Prefab is NULL!");
                return;
            }
            ResearchItem researchItem = gearItem.GetComponent<ResearchItem>();
            if (researchItem == null)
            {
                MelonLogger.Msg(name + " ResearchItem Prefab is NULL!");
                return;
            }
            researchItem.m_SkillPoints = points;
            researchItem.m_TimeRequirementHours = time;
        }
        public override void OnInitializeMelon()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            Settings.OnLoad();
        }

        public static string[,] referencesBow = new string[,]
        {
            {"BullseyeTarget","1",Settings.settings.distanceBullseyeBow1.ToString()},
            {"BullseyeTarget","2",Settings.settings.distanceBullseyeBow2.ToString()},
            {"BullseyeTarget","3",Settings.settings.distanceBullseyeBow3.ToString()},
            {"BullseyeTarget","4",Settings.settings.distanceBullseyeBow4.ToString()},
            {"Rabbit","1",Settings.settings.distanceSmallPreyBow1.ToString()},
            {"Rabbit","2",Settings.settings.distanceSmallPreyBow2.ToString()},
            {"Rabbit","3",Settings.settings.distanceSmallPreyBow3.ToString()},
            {"Rabbit","4",Settings.settings.distanceSmallPreyBow4.ToString()},
            {"Ptarmigan","1",Settings.settings.distanceSmallPreyBow1.ToString()},
            {"Ptarmigan","2",Settings.settings.distanceSmallPreyBow2.ToString()},
            {"Ptarmigan","3",Settings.settings.distanceSmallPreyBow3.ToString()},
            {"Ptarmigan","4",Settings.settings.distanceSmallPreyBow4.ToString()},
            {"Stag","1",Settings.settings.distanceMediumPreyBow1.ToString()},
            {"Stag","2",Settings.settings.distanceMediumPreyBow2.ToString()},
            {"Stag","3",Settings.settings.distanceMediumPreyBow3.ToString()},
            {"Stag","4",Settings.settings.distanceMediumPreyBow4.ToString()},
            {"Doe","1",Settings.settings.distanceMediumPreyBow1.ToString()},
            {"Doe","2",Settings.settings.distanceMediumPreyBow2.ToString()},
            {"Doe","3",Settings.settings.distanceMediumPreyBow3.ToString()},
            {"Doe","4",Settings.settings.distanceMediumPreyBow4.ToString()},
            {"Wolf","1",Settings.settings.distanceMediumPreyBow1.ToString()},
            {"Wolf","2",Settings.settings.distanceMediumPreyBow2.ToString()},
            {"Wolf","3",Settings.settings.distanceMediumPreyBow3.ToString()},
            {"Wolf","4",Settings.settings.distanceMediumPreyBow4.ToString()},
            {"Cougar","1",Settings.settings.distanceMediumPreyBow1.ToString()},
            {"Cougar","2",Settings.settings.distanceMediumPreyBow2.ToString()},
            {"Cougar","3",Settings.settings.distanceMediumPreyBow3.ToString()},
            {"Cougar","4",Settings.settings.distanceMediumPreyBow4.ToString()},
            {"Moose","1",Settings.settings.distanceBigPreyBow1.ToString()},
            {"Moose","2",Settings.settings.distanceBigPreyBow2.ToString()},
            {"Moose","3",Settings.settings.distanceBigPreyBow3.ToString()},
            {"Moose","4",Settings.settings.distanceBigPreyBow4.ToString()},
            {"Bear","1",Settings.settings.distanceBigPreyBow1.ToString()},
            {"Bear","2",Settings.settings.distanceBigPreyBow2.ToString()},
            {"Bear","3",Settings.settings.distanceBigPreyBow3.ToString()},
            {"Bear","4",Settings.settings.distanceBigPreyBow4.ToString()}
        };

        public static string[,] referencesFirearms = new string[,]
        {

            {"RecycledCan","1",Settings.settings.distanceCanFirearms1.ToString()},
            {"RecycledCan","2",Settings.settings.distanceCanFirearms2.ToString()},
            {"RecycledCan","3",Settings.settings.distanceCanFirearms3.ToString()},
            {"RecycledCan","4",Settings.settings.distanceCanFirearms4.ToString()},
            {"SprayPaintCan","1",Settings.settings.distanceCanFirearms1.ToString()},
            {"SprayPaintCan","2",Settings.settings.distanceCanFirearms2.ToString()},
            {"SprayPaintCan","3",Settings.settings.distanceCanFirearms3.ToString()},
            {"SprayPaintCan","4",Settings.settings.distanceCanFirearms4.ToString()},
            {"BullseyeTarget","1",Settings.settings.distanceBullseyeFirearms1.ToString()},
            {"BullseyeTarget","2",Settings.settings.distanceBullseyeFirearms2.ToString()},
            {"BullseyeTarget","3",Settings.settings.distanceBullseyeFirearms3.ToString()},
            {"BullseyeTarget","4",Settings.settings.distanceBullseyeFirearms4.ToString()},
            {"Rabbit","1",Settings.settings.distanceSmallPreyFirearms1.ToString()},
            {"Rabbit","2",Settings.settings.distanceSmallPreyFirearms2.ToString()},
            {"Rabbit","3",Settings.settings.distanceSmallPreyFirearms3.ToString()},
            {"Rabbit","4",Settings.settings.distanceSmallPreyFirearms4.ToString()},
            {"Ptarmigan","1",Settings.settings.distanceSmallPreyFirearms1.ToString()},
            {"Ptarmigan","2",Settings.settings.distanceSmallPreyFirearms2.ToString()},
            {"Ptarmigan","3",Settings.settings.distanceSmallPreyFirearms3.ToString()},
            {"Ptarmigan","4",Settings.settings.distanceSmallPreyFirearms4.ToString()},
            {"Stag","1",Settings.settings.distanceMediumPreyFirearms1.ToString()},
            {"Stag","2",Settings.settings.distanceMediumPreyFirearms2.ToString()},
            {"Stag","3",Settings.settings.distanceMediumPreyFirearms3.ToString()},
            {"Stag","4",Settings.settings.distanceMediumPreyFirearms4.ToString()},
            {"Doe","1",Settings.settings.distanceMediumPreyFirearms1.ToString()},
            {"Doe","2",Settings.settings.distanceMediumPreyFirearms2.ToString()},
            {"Doe","3",Settings.settings.distanceMediumPreyFirearms3.ToString()},
            {"Doe","4",Settings.settings.distanceMediumPreyFirearms4.ToString()},
            {"Wolf","1",Settings.settings.distanceMediumPreyFirearms1.ToString()},
            {"Wolf","2",Settings.settings.distanceMediumPreyFirearms2.ToString()},
            {"Wolf","3",Settings.settings.distanceMediumPreyFirearms3.ToString()},
            {"Wolf","4",Settings.settings.distanceMediumPreyFirearms4.ToString()},
            {"Cougar","1",Settings.settings.distanceMediumPreyFirearms1.ToString()},
            {"Cougar","2",Settings.settings.distanceMediumPreyFirearms2.ToString()},
            {"Cougar","3",Settings.settings.distanceMediumPreyFirearms3.ToString()},
            {"Cougar","4",Settings.settings.distanceMediumPreyFirearms4.ToString()},
            {"Moose","1",Settings.settings.distanceBigPreyFirearms1.ToString()},
            {"Moose","2",Settings.settings.distanceBigPreyFirearms2.ToString()},
            {"Moose","3",Settings.settings.distanceBigPreyFirearms3.ToString()},
            {"Moose","4",Settings.settings.distanceBigPreyFirearms4.ToString()},
            {"Bear","1",Settings.settings.distanceBigPreyFirearms1.ToString()},
            {"Bear","2",Settings.settings.distanceBigPreyFirearms2.ToString()},
            {"Bear","3",Settings.settings.distanceBigPreyFirearms3.ToString()},
            {"Bear","4",Settings.settings.distanceBigPreyFirearms4.ToString()}
        };
    }
}
