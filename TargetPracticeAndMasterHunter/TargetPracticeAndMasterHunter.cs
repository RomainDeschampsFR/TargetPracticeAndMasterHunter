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

        public static string[,] referencesRifle = new string[,]
        {

            { "RecycledCan", "1", Settings.settings.distanceCanRifle1.ToString() },
            { "RecycledCan", "2", Settings.settings.distanceCanRifle2.ToString() },
            { "RecycledCan", "3", Settings.settings.distanceCanRifle3.ToString() },
            { "RecycledCan", "4", Settings.settings.distanceCanRifle4.ToString() },
            { "SprayPaintCan", "1", Settings.settings.distanceCanRifle1.ToString() },
            { "SprayPaintCan", "2", Settings.settings.distanceCanRifle2.ToString() },
            { "SprayPaintCan", "3", Settings.settings.distanceCanRifle3.ToString() },
            { "SprayPaintCan", "4", Settings.settings.distanceCanRifle4.ToString() },
            { "BullseyeTarget", "1", Settings.settings.distanceBullseyeRifle1.ToString() },
            { "BullseyeTarget", "2", Settings.settings.distanceBullseyeRifle2.ToString() },
            { "BullseyeTarget", "3", Settings.settings.distanceBullseyeRifle3.ToString() },
            { "BullseyeTarget", "4", Settings.settings.distanceBullseyeRifle4.ToString() },
            { "Rabbit", "1", Settings.settings.distanceSmallPreyRifle1.ToString() },
            { "Rabbit", "2", Settings.settings.distanceSmallPreyRifle2.ToString() },
            { "Rabbit", "3", Settings.settings.distanceSmallPreyRifle3.ToString() },
            { "Rabbit", "4", Settings.settings.distanceSmallPreyRifle4.ToString() },
            { "Ptarmigan", "1", Settings.settings.distanceSmallPreyRifle1.ToString() },
            { "Ptarmigan", "2", Settings.settings.distanceSmallPreyRifle2.ToString() },
            { "Ptarmigan", "3", Settings.settings.distanceSmallPreyRifle3.ToString() },
            { "Ptarmigan", "4", Settings.settings.distanceSmallPreyRifle4.ToString() },
            { "Stag", "1", Settings.settings.distanceMediumPreyRifle1.ToString() },
            { "Stag", "2", Settings.settings.distanceMediumPreyRifle2.ToString() },
            { "Stag", "3", Settings.settings.distanceMediumPreyRifle3.ToString() },
            { "Stag", "4", Settings.settings.distanceMediumPreyRifle4.ToString() },
            { "Doe", "1", Settings.settings.distanceMediumPreyRifle1.ToString() },
            { "Doe", "2", Settings.settings.distanceMediumPreyRifle2.ToString() },
            { "Doe", "3", Settings.settings.distanceMediumPreyRifle3.ToString() },
            { "Doe", "4", Settings.settings.distanceMediumPreyRifle4.ToString() },
            { "Wolf", "1", Settings.settings.distanceMediumPreyRifle1.ToString() },
            { "Wolf", "2", Settings.settings.distanceMediumPreyRifle2.ToString() },
            { "Wolf", "3", Settings.settings.distanceMediumPreyRifle3.ToString() },
            { "Wolf", "4", Settings.settings.distanceMediumPreyRifle4.ToString() },
            { "Cougar", "1", Settings.settings.distanceMediumPreyRifle1.ToString() },
            { "Cougar", "2", Settings.settings.distanceMediumPreyRifle2.ToString() },
            { "Cougar", "3", Settings.settings.distanceMediumPreyRifle3.ToString() },
            { "Cougar", "4", Settings.settings.distanceMediumPreyRifle4.ToString() },
            { "Moose", "1", Settings.settings.distanceBigPreyRifle1.ToString() },
            { "Moose", "2", Settings.settings.distanceBigPreyRifle2.ToString() },
            { "Moose", "3", Settings.settings.distanceBigPreyRifle3.ToString() },
            { "Moose", "4", Settings.settings.distanceBigPreyRifle4.ToString() },
            { "Bear", "1", Settings.settings.distanceBigPreyRifle1.ToString() },
            { "Bear", "2", Settings.settings.distanceBigPreyRifle2.ToString() },
            { "Bear", "3", Settings.settings.distanceBigPreyRifle3.ToString() },
            { "Bear", "4", Settings.settings.distanceBigPreyRifle4.ToString() }
        };

        public static string[,] referencesRevolver = new string[,]
        {

            { "RecycledCan", "1", Settings.settings.distanceCanRevolver1.ToString() },
            { "RecycledCan", "2", Settings.settings.distanceCanRevolver2.ToString() },
            { "RecycledCan", "3", Settings.settings.distanceCanRevolver3.ToString() },
            { "RecycledCan", "4", Settings.settings.distanceCanRevolver4.ToString() },
            { "SprayPaintCan", "1", Settings.settings.distanceCanRevolver1.ToString() },
            { "SprayPaintCan", "2", Settings.settings.distanceCanRevolver2.ToString() },
            { "SprayPaintCan", "3", Settings.settings.distanceCanRevolver3.ToString() },
            { "SprayPaintCan", "4", Settings.settings.distanceCanRevolver4.ToString() },
            { "BullseyeTarget", "1", Settings.settings.distanceBullseyeRevolver1.ToString() },
            { "BullseyeTarget", "2", Settings.settings.distanceBullseyeRevolver2.ToString() },
            { "BullseyeTarget", "3", Settings.settings.distanceBullseyeRevolver3.ToString() },
            { "BullseyeTarget", "4", Settings.settings.distanceBullseyeRevolver4.ToString() },
            { "Rabbit", "1", Settings.settings.distanceSmallPreyRevolver1.ToString() },
            { "Rabbit", "2", Settings.settings.distanceSmallPreyRevolver2.ToString() },
            { "Rabbit", "3", Settings.settings.distanceSmallPreyRevolver3.ToString() },
            { "Rabbit", "4", Settings.settings.distanceSmallPreyRevolver4.ToString() },
            { "Ptarmigan", "1", Settings.settings.distanceSmallPreyRevolver1.ToString() },
            { "Ptarmigan", "2", Settings.settings.distanceSmallPreyRevolver2.ToString() },
            { "Ptarmigan", "3", Settings.settings.distanceSmallPreyRevolver3.ToString() },
            { "Ptarmigan", "4", Settings.settings.distanceSmallPreyRevolver4.ToString() },
            { "Stag", "1", Settings.settings.distanceMediumPreyRevolver1.ToString() },
            { "Stag", "2", Settings.settings.distanceMediumPreyRevolver2.ToString() },
            { "Stag", "3", Settings.settings.distanceMediumPreyRevolver3.ToString() },
            { "Stag", "4", Settings.settings.distanceMediumPreyRevolver4.ToString() },
            { "Doe", "1", Settings.settings.distanceMediumPreyRevolver1.ToString() },
            { "Doe", "2", Settings.settings.distanceMediumPreyRevolver2.ToString() },
            { "Doe", "3", Settings.settings.distanceMediumPreyRevolver3.ToString() },
            { "Doe", "4", Settings.settings.distanceMediumPreyRevolver4.ToString() },
            { "Wolf", "1", Settings.settings.distanceMediumPreyRevolver1.ToString() },
            { "Wolf", "2", Settings.settings.distanceMediumPreyRevolver2.ToString() },
            { "Wolf", "3", Settings.settings.distanceMediumPreyRevolver3.ToString() },
            { "Wolf", "4", Settings.settings.distanceMediumPreyRevolver4.ToString() },
            { "Cougar", "1", Settings.settings.distanceMediumPreyRevolver1.ToString() },
            { "Cougar", "2", Settings.settings.distanceMediumPreyRevolver2.ToString() },
            { "Cougar", "3", Settings.settings.distanceMediumPreyRevolver3.ToString() },
            { "Cougar", "4", Settings.settings.distanceMediumPreyRevolver4.ToString() },
            { "Moose", "1", Settings.settings.distanceBigPreyRevolver1.ToString() },
            { "Moose", "2", Settings.settings.distanceBigPreyRevolver2.ToString() },
            { "Moose", "3", Settings.settings.distanceBigPreyRevolver3.ToString() },
            { "Moose", "4", Settings.settings.distanceBigPreyRevolver4.ToString() },
            { "Bear", "1", Settings.settings.distanceBigPreyRevolver1.ToString() },
            { "Bear", "2", Settings.settings.distanceBigPreyRevolver2.ToString() },
            { "Bear", "3", Settings.settings.distanceBigPreyRevolver3.ToString() },
            { "Bear", "4", Settings.settings.distanceBigPreyRevolver4.ToString() }
        };
    }
}
