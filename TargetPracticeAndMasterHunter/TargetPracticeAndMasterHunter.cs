using Il2Cpp;
using MelonLoader;
using UnityEngine;

namespace TargetPracticeAndMasterHunter
{
    public class TargetPracticeAndMasterHunter : MelonMod
    {
        internal static SaveDataManager sdm = new SaveDataManager();

        public override void OnInitializeMelon()
        {
            Debug.Log($"[{Info.Name}] Version {Info.Version} loaded!");
            Settings.OnLoad();
        }

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
            arrowItem.m_CraftingSkillPoints = Settings.settings.updateCraftingSkillPoints ? 0 : 1;

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

        public static string[,] referencesBow = new string[,]
        {
            {"Bullseye","1",Settings.settings.distanceBullseyeBow1.ToString()},
            {"Bullseye","2",Settings.settings.distanceBullseyeBow2.ToString()},
            {"Bullseye","3",Settings.settings.distanceBullseyeBow3.ToString()},
            {"Bullseye","4",Settings.settings.distanceBullseyeBow4.ToString()},
            {"HayBale","1",Settings.settings.distanceHaybaleBow1.ToString()},
            {"HayBale","2",Settings.settings.distanceHaybaleBow2.ToString()},
            {"HayBale","3",Settings.settings.distanceHaybaleBow3.ToString()},
            {"HayBale","4",Settings.settings.distanceHaybaleBow4.ToString()},
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
            { "SprayPaint", "1", Settings.settings.distanceCanRifle1.ToString() },
            { "SprayPaint", "2", Settings.settings.distanceCanRifle2.ToString() },
            { "SprayPaint", "3", Settings.settings.distanceCanRifle3.ToString() },
            { "SprayPaint", "4", Settings.settings.distanceCanRifle4.ToString() },
            { "Bullseye", "1", Settings.settings.distanceBullseyeRifle1.ToString() },
            { "Bullseye", "2", Settings.settings.distanceBullseyeRifle2.ToString() },
            { "Bullseye", "3", Settings.settings.distanceBullseyeRifle3.ToString() },
            { "Bullseye", "4", Settings.settings.distanceBullseyeRifle4.ToString() },
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
            { "SprayPaint", "1", Settings.settings.distanceCanRevolver1.ToString() },
            { "SprayPaint", "2", Settings.settings.distanceCanRevolver2.ToString() },
            { "SprayPaint", "3", Settings.settings.distanceCanRevolver3.ToString() },
            { "SprayPaint", "4", Settings.settings.distanceCanRevolver4.ToString() },
            { "Bullseye", "1", Settings.settings.distanceBullseyeRevolver1.ToString() },
            { "Bullseye", "2", Settings.settings.distanceBullseyeRevolver2.ToString() },
            { "Bullseye", "3", Settings.settings.distanceBullseyeRevolver3.ToString() },
            { "Bullseye", "4", Settings.settings.distanceBullseyeRevolver4.ToString() },
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

        public override void OnUpdate()
        {
            if (InputManager.GetKeyDown(InputManager.m_CurrentContext, Settings.settings.recordKeyCode))
            {
                DisplayRecords();
            }
        }

        public static void DisplayRecords()
        {
            int numRows = Patches.recordDistance.GetLength(0);
            int numCols = Patches.recordDistance.GetLength(1);

            string recordTable1 = "";
            string recordTable2 = "";
            string recordTable3 = "";

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    if (i == 0)
                    {
                        recordTable1 += Patches.recordDistance[i, j];
                        recordTable2 += Patches.recordDistance[i, j];
                        recordTable3 += Patches.recordDistance[i, j];
                        recordTable1 += (j == 5) ? "\n" : " --- ";
                        recordTable2 += (j == 5) ? "\n" : " --- ";
                        recordTable3 += (j == 5) ? "\n" : " --- ";

                    }
                    if (i >= 1 && i <= 4)
                    {
                        recordTable1 += (j == 0) ? Patches.recordDistance[i, j].Substring(0, 3) + "." : Patches.recordDistance[i, j];
                        recordTable1 += (j == 5) ? "\n" : " --- ";
                    }
                    else if (i >= 5 && i <= 8)
                    {
                        recordTable2 += (j == 0) ? Patches.recordDistance[i, j].Substring(0, 3) + "." : Patches.recordDistance[i, j];
                        recordTable2 += (j == 5) ? "\n" : " --- ";
                    }
                    else if (i >= 9 && i <= 12)
                    {
                        recordTable3 += (j == 0) ? Patches.recordDistance[i, j].Substring(0, 3) + "." : Patches.recordDistance[i, j];
                        recordTable3 += (j == 5) ? "\n" : " --- ";
                    }
                }
            }
            recordTable1 = recordTable1.Substring(0, recordTable1.Length - 1);
            recordTable2 = recordTable2.Substring(0, recordTable2.Length - 1);
            recordTable3 = recordTable3.Substring(0, recordTable3.Length - 1);

            HUDMessage.AddMessage(recordTable1, 4);
            HUDMessage.AddMessage(recordTable2, 4);
            HUDMessage.AddMessage(recordTable3, 4);
        }
    }
}

