using ModSettings;
using System.Reflection;

namespace TargetPracticeAndMasterHunter
{
    internal class TargetPracticeAndMasterHunterSettings : JsonModSettings
    {
        //public enum Choice {Default, Realistic, Custom}
        //public enum ChoiceYN {Default, Custom}

        // DISABLE POINTS FROM ARROW CRAFTING SECTION

        [Section("GLOBAL SETTINGS")]
        [Name("Disable arrow crafting points")]
        [Description("NO: Default \nYES: Arrow crafting no longer provides skill points")]
        public bool updateCraftingSkillPoints = true;

        // ENABLE INCRELENTAL BONUS

        [Name("Enable incremental bonus")]
        [Description("NO: Disabled for Target Pratice & Master Hunter \nYES: Each distance threshold provide 1 more point.\ne.g. If you are level 2 and hit a target by shooting beyond the distance for level 4, you earn 3 points instead of 1.")]
        public bool updateIncrementalBonus = false;

        // ENABLE SIDE-STEP

        [Name("Enable side-step while training")]
        [Description("NO: Disabled \nYES: Auto side-step when successfully hiting a training target")]
        public bool updateSideStep = true;

        // ENABLE LOG

        [Name("Enable logs in the console")]
        [Description("NO: Disabled \nYES: Display useful information especially the distance beetween you and what was hit")]
        public bool updateLog = true;

        // DISPLAY SKILL ICON

        [Name("Display skill icon after lvl 5")]
        [Description("NO: Vanilla \nYES: Once lvl 5, it displays skill icon when hitting a valid target (training or animal)")]
        public bool updateSkillIcon = true;

        // PRESETS

        [Name("Preset for Target Practice & Master Hunter")]
        [Choice("Beginner", "Intermediate", "Master")]
        public int preset = 2;

        // ENABLE MASTER HUNTER FEATURE

        [Section("Master Hunter")]
        [Name("Enable Master Hunter")]
        [Description("NO: Target Pratice only \nYES: Target Pratice & Master Hunter")]
        public bool updateMasterHunter = true;

        // SECTION FIREARM

        [Section("Rifle & Revolver : Target Practice")]
        [Name("Recycled Cans & Spray Paint Cans : Level 1")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceCanFirearms1 = 45;

        [Name("Recycled Cans & Spray Paint Cans : Level 2")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceCanFirearms2 = 50;

        [Name("Recycled Cans & Spray Paint Cans : Level 3")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceCanFirearms3 = 55;

        [Name("Recycled Cans & Spray Paint Cans : Level 4")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceCanFirearms4 = 60;

        [Name("Bullseye : Level 1")]
        [Description("Min distance required to earn a skill point with firearms. FOV max 130 . Do not really fit with firearm training")]
        [Slider(0, 300)]
        public int distanceBullseyeFirearms1 = 115;

        [Name("Bullseye : Level 2")]
        [Description("Min distance required to earn a skill point with firearms. FOV max 130 . Do not really fit with firearm training")]
        [Slider(0, 300)]
        public int distanceBullseyeFirearms2 = 130;

        [Name("Bullseye : Level 3")]
        [Description("Min distance required to earn a skill point with firearms. FOV max 130 . Do not really fit with firearm training")]
        [Slider(0, 300)]
        public int distanceBullseyeFirearms3 = 300;

        [Name("Bullseye : Level 4")]
        [Description("Min distance required to earn a skill point with firearms. FOV max 130 . Do not really fit with firearm training")]
        [Slider(0, 300)]
        public int distanceBullseyeFirearms4 = 300;

        [Section("Rifle & Revolver : Master Hunter")]
        [Name("Rabbit & Ptarmigan : Level 1")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceSmallPreyFirearms1 = 50;

        [Name("Rabbit & Ptarmigan : Level 2")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceSmallPreyFirearms2 = 60;

        [Name("Rabbit & Ptarmigan : Level 3")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceSmallPreyFirearms3 = 70;

        [Name("Rabbit & Ptarmigan : Level 4")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceSmallPreyFirearms4 = 80;

        [Name("Stag, Doe, Wolf & Cougar : Level 1")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceMediumPreyFirearms1 = 155;

        [Name("Stag, Doe, Wolf & Cougar : Level 2")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceMediumPreyFirearms2 = 170;

        [Name("Stag, Doe, Wolf & Cougar : Level 3")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceMediumPreyFirearms3 = 185;

        [Name("Stag, Doe, Wolf & Cougar : Level 4")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceMediumPreyFirearms4 = 200;

        [Name("Moose & Bear : Level 1")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceBigPreyFirearms1 = 185;

        [Name("Moose & Bear : Level 2")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceBigPreyFirearms2 = 200;

        [Name("Moose & Bear : Level 3")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceBigPreyFirearms3 = 215;

        [Name("Moose & Bear : Level 4")]
        [Description("Min distance required to earn a skill point with firearms")]
        [Slider(0, 300)]
        public int distanceBigPreyFirearms4 = 230;

        // SECTION BOW

        [Section("Bow : Target Practice")]
        [Name("Bullseye : Level 1")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBullseyeBow1 = 80;

        [Name("Bullseye : Level 2")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBullseyeBow2 = 100;

        [Name("Bullseye : Level 3")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBullseyeBow3 = 115;

        [Name("Bullseye : Level 4")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBullseyeBow4 = 130;

        [Section("Bow : Master Hunter")]
        [Name("Rabbit & Ptarmigan : Level 1")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceSmallPreyBow1 = 30;

        [Name("Rabbit & Ptarmigan : Level 2")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceSmallPreyBow2 = 40;

        [Name("Rabbit & Ptarmigan : Level 3")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceSmallPreyBow3 = 50;

        [Name("Rabbit & Ptarmigan : Level 4")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceSmallPreyBow4 = 60;

        [Name("Stag, Doe, Wolf & Cougar : Level 1")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceMediumPreyBow1 = 55;

        [Name("Stag, Doe, Wolf & Cougar : Level 2")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceMediumPreyBow2 = 70;

        [Name("Stag, Doe, Wolf & Cougar : Level 3")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceMediumPreyBow3 = 85;

        [Name("Stag, Doe, Wolf & Cougar : Level 4")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceMediumPreyBow4 = 100;

        [Name("Moose & Bear : Level 1")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBigPreyBow1 = 80;

        [Name("Moose & Bear : Level 2")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBigPreyBow2 = 100;

        [Name("Moose & Bear : Level 3")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBigPreyBow3 = 115;

        [Name("Moose & Bear : Level 4")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBigPreyBow4 = 130;

        // RESEARCH BOOK SECTION

        [Section("Research Books")]
        [Name("Enable books customization")]
        [Description("NO: Vanilla values \nYES: Custom values (see descriptions for more details)")]
        public bool updateResearchBooks = true;

        // MASTER HUNTER BOOKS

        [Section("Master Hunter related books")]
        [Name("Archery book : reading time")]
        [Description("Default Game Value: 5")]
        [Slider(1, 30)]
        public int timeArchery = 5;

        [Name("Archery book : points earned")]
        [Description("Default Game Value: 10\nMaster Hunter Recommended Value : 4")]
        [Slider(2, 20)]
        public int pointsArchery = 10;

        [Name("Revolver book : reading time")]
        [Description("Default Game Value: 5")]
        [Slider(1, 30)]
        public int timeRevolverFirearm = 5;

        [Name("Revolver book : points earned")]
        [Description("Default Game Value: 10\nMaster Hunter Recommended Value : 4")]
        [Slider(2, 20)]
        public int pointsRevolverFirearm = 10;

        [Name("Rifle book : reading time")]
        [Description("Default Game Value: 4")]
        [Slider(1, 30)]
        public int timeRifleFirearm = 4;

        [Name("Rifle book : points earned")]
        [Description("Default Game Value: 5\nMaster Hunter Recommended Value : 4")]
        [Slider(2, 20)]
        public int pointsRifleFirearm = 5;

        [Name("Advanced rifle book : reading time")]
        [Description("Default Game Value: 25")]
        [Slider(1, 30)]
        public int timeRifleFirearmAdvanced = 25;

        [Name("Advanced rifle book : points earned")]
        [Description("Default Game Value: 10\nMaster Hunter Recommended Value : 8")]
        [Slider(2, 20)]
        public int pointsRifleFirearmAdvanced = 10;

        [Name("Fire Starting book : reading time")]
        [Description("Default Game Value: 5")]
        [Slider(1, 30)]
        public int timeFireStarting = 5;

        [Name("Fire Starting book : points earned")]
        [Description("Default Game Value: 10")]
        [Slider(2, 20)]
        public int pointsFireStarting = 10;

        // OTHER BOOKS

        [Section("Other books")]
        [Name("Gunsmithing book : reading time")]
        [Description("Default Game Value: 5")]
        [Slider(1, 30)]
        public int timeGunsmithing = 5;

        [Name("Gunsmithing book : points earned")]
        [Description("Default Game Value: 10")]
        [Slider(2, 20)]
        public int pointsGunsmithing = 10;

        [Name("Cooking book : reading time")]
        [Description("Default Game Value: 5")]
        [Slider(1, 30)]
        public int timeCooking = 5;

        [Name("Cooking book : points earned")]
        [Description("Default Game Value: 10")]
        [Slider(2, 20)]
        public int pointsCooking = 10;

        [Name("Mending book : reading time")]
        [Description("Default Game Value: 5")]
        [Slider(1, 30)]
        public int timeMending = 5;

        [Name("Mending book : points earned")]
        [Description("Default Game Value: 10")]
        [Slider(2, 20)]
        public int pointsMending = 10;

        [Name("Ice Fishing book : reading time")]
        [Description("Default Game Value: 5")]
        [Slider(1, 30)]
        public int timeIceFishing = 5;

        [Name("Ice Fishing book : points earned")]
        [Description("Default Game Value: 10")]
        [Slider(2, 20)]
        public int pointsIceFishing = 10;

        [Name("Carcass Harvesting book : reading time")]
        [Description("Default Game Value: 10")]
        [Slider(1, 30)]
        public int timeCarcassHarvesting = 10;

        [Name("Carcass Harvesting book : points earned")]
        [Description("Default Game Value: 10")]
        [Slider(2, 20)]
        public int pointsCarcassHarvesting = 10;


        protected override void OnChange(FieldInfo field, object? oldValue, object? newValue)
        {
            if (field.Name == nameof(updateMasterHunter) ||
                field.Name == nameof(updateResearchBooks))
            {
                RefreshFields();
            }

            if (field.Name == nameof(preset) && newValue != null)
            {
                UsePreset((int)newValue);
                RefreshGUI();
            }

        }

        private void UsePreset(int preset)
        {
            switch (preset)
            {
                case 0:
                    // Apply Beginner distances
                    distanceCanFirearms1 = 25;
                    distanceCanFirearms2 = 30;
                    distanceCanFirearms3 = 35;
                    distanceCanFirearms4 = 40;
                    distanceBullseyeFirearms1 = 65;
                    distanceBullseyeFirearms2 = 80;
                    distanceBullseyeFirearms3 = 95;
                    distanceBullseyeFirearms4 = 110;
                    distanceBullseyeBow1 = 35;
                    distanceBullseyeBow2 = 50;
                    distanceBullseyeBow3 = 65;
                    distanceBullseyeBow4 = 80;
                    distanceSmallPreyFirearms1 = 20;
                    distanceSmallPreyFirearms2 = 30;
                    distanceSmallPreyFirearms3 = 40;
                    distanceSmallPreyFirearms4 = 50;
                    distanceSmallPreyBow1 = 15;
                    distanceSmallPreyBow2 = 25;
                    distanceSmallPreyBow3 = 35;
                    distanceSmallPreyBow4 = 45;
                    distanceMediumPreyFirearms1 = 95;
                    distanceMediumPreyFirearms2 = 110;
                    distanceMediumPreyFirearms3 = 125;
                    distanceMediumPreyFirearms4 = 140;
                    distanceMediumPreyBow1 = 15;
                    distanceMediumPreyBow2 = 30;
                    distanceMediumPreyBow3 = 45;
                    distanceMediumPreyBow4 = 60;
                    distanceBigPreyFirearms1 = 125;
                    distanceBigPreyFirearms2 = 140;
                    distanceBigPreyFirearms3 = 155;
                    distanceBigPreyFirearms4 = 170;
                    distanceBigPreyBow1 = 35;
                    distanceBigPreyBow2 = 50;
                    distanceBigPreyBow3 = 65;
                    distanceBigPreyBow4 = 80;
                    break;

                case 1:
                    // Apply Intermediate distances
                    distanceCanFirearms1 = 35;
                    distanceCanFirearms2 = 40;
                    distanceCanFirearms3 = 45;
                    distanceCanFirearms4 = 50;
                    distanceBullseyeFirearms1 = 95;
                    distanceBullseyeFirearms2 = 110;
                    distanceBullseyeFirearms3 = 125;
                    distanceBullseyeFirearms4 = 300;
                    distanceBullseyeBow1 = 65;
                    distanceBullseyeBow2 = 80;
                    distanceBullseyeBow3 = 95;
                    distanceBullseyeBow4 = 110;
                    distanceSmallPreyFirearms1 = 35;
                    distanceSmallPreyFirearms2 = 45;
                    distanceSmallPreyFirearms3 = 55;
                    distanceSmallPreyFirearms4 = 65;
                    distanceSmallPreyBow1 = 25;
                    distanceSmallPreyBow2 = 35;
                    distanceSmallPreyBow3 = 45;
                    distanceSmallPreyBow4 = 55;
                    distanceMediumPreyFirearms1 = 125;
                    distanceMediumPreyFirearms2 = 140;
                    distanceMediumPreyFirearms3 = 155;
                    distanceMediumPreyFirearms4 = 170;
                    distanceMediumPreyBow1 = 35;
                    distanceMediumPreyBow2 = 50;
                    distanceMediumPreyBow3 = 65;
                    distanceMediumPreyBow4 = 80;
                    distanceBigPreyFirearms1 = 155;
                    distanceBigPreyFirearms2 = 170;
                    distanceBigPreyFirearms3 = 185;
                    distanceBigPreyFirearms4 = 200;
                    distanceBigPreyBow1 = 65;
                    distanceBigPreyBow2 = 80;
                    distanceBigPreyBow3 = 95;
                    distanceBigPreyBow4 = 110;
                    break;

                case 2:
                    // Apply Master distances
                    distanceCanFirearms1 = 45;
                    distanceCanFirearms2 = 50;
                    distanceCanFirearms3 = 55;
                    distanceCanFirearms4 = 60;
                    distanceBullseyeFirearms1 = 115;
                    distanceBullseyeFirearms2 = 130;
                    distanceBullseyeFirearms3 = 300;
                    distanceBullseyeFirearms4 = 300;
                    distanceBullseyeBow1 = 80;
                    distanceBullseyeBow2 = 100;
                    distanceBullseyeBow3 = 115;
                    distanceBullseyeBow4 = 130;
                    distanceSmallPreyFirearms1 = 50;
                    distanceSmallPreyFirearms2 = 60;
                    distanceSmallPreyFirearms3 = 70;
                    distanceSmallPreyFirearms4 = 80;
                    distanceSmallPreyBow1 = 30;
                    distanceSmallPreyBow2 = 40;
                    distanceSmallPreyBow3 = 50;
                    distanceSmallPreyBow4 = 60;
                    distanceMediumPreyFirearms1 = 155;
                    distanceMediumPreyFirearms2 = 170;
                    distanceMediumPreyFirearms3 = 185;
                    distanceMediumPreyFirearms4 = 200;
                    distanceMediumPreyBow1 = 55;
                    distanceMediumPreyBow2 = 70;
                    distanceMediumPreyBow3 = 85;
                    distanceMediumPreyBow4 = 100;
                    distanceBigPreyFirearms1 = 185;
                    distanceBigPreyFirearms2 = 200;
                    distanceBigPreyFirearms3 = 215;
                    distanceBigPreyFirearms4 = 230;
                    distanceBigPreyBow1 = 80;
                    distanceBigPreyBow2 = 100;
                    distanceBigPreyBow3 = 115;
                    distanceBigPreyBow4 = 130;
                    break;
            }
        }

        internal void RefreshFields()
        {

            SetFieldVisible(nameof(distanceSmallPreyFirearms1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyFirearms2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyFirearms3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyFirearms4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyFirearms1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyFirearms2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyFirearms3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyFirearms4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyFirearms1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyFirearms2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyFirearms3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyFirearms4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyBow1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyBow2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyBow3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyBow4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyBow1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyBow2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyBow3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyBow4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyBow1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyBow2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyBow3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyBow4), Settings.settings.updateMasterHunter == true);

            SetFieldVisible(nameof(timeArchery), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsArchery), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeRevolverFirearm), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsRevolverFirearm), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeRifleFirearm), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsRifleFirearm), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeRifleFirearmAdvanced), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsRifleFirearmAdvanced), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeFireStarting), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsFireStarting), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeGunsmithing), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsGunsmithing), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeCooking), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsCooking), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeMending), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsMending), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeIceFishing), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsIceFishing), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(timeCarcassHarvesting), Settings.settings.updateResearchBooks == true);
            SetFieldVisible(nameof(pointsCarcassHarvesting), Settings.settings.updateResearchBooks == true);

        }
        protected override void OnConfirm()
        {
            base.OnConfirm();
            ChangePrefabs();
        }

        internal void ChangePrefabs()
        {
            if (Settings.settings.updateCraftingSkillPoints)
            {
                TargetPracticeAndMasterHunter.ChangePrefabCraftingSkillPoints("GEAR_Arrow");
            }
            if (Settings.settings.updateResearchBooks)
            {
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookFireStarting", pointsFireStarting, timeFireStarting);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookRevolverFirearm", pointsRevolverFirearm, timeRevolverFirearm);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookArchery", pointsArchery, timeArchery);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookRifleFirearm", pointsRifleFirearm, timeRifleFirearm);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookRifleFirearmAdvanced", pointsRifleFirearmAdvanced, timeRifleFirearmAdvanced);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookGunsmithing", pointsGunsmithing, timeGunsmithing);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookCooking", pointsCooking, timeCooking);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookMending", pointsMending, timeMending);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookIceFishing", pointsIceFishing, timeIceFishing);
                TargetPracticeAndMasterHunter.ChangePrefabResearchItems("GEAR_BookCarcassHarvesting", pointsCarcassHarvesting, timeCarcassHarvesting);
            }
        }
    }

    internal static class Settings
    {
        public static TargetPracticeAndMasterHunterSettings settings = new();

        public static void OnLoad()
        {
            settings.AddToModSettings("Target Practice & Master Hunter Settings");
            //settings.RefreshFields();
        }
    }
}
