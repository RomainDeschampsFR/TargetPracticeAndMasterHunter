using ModSettings;
using MelonLoader;
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
        [Description("NO: Default \nYES: Arrow crafting no longer provides skill points\n Need to change scene for the change to be applied")]
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

        // SECTION RIFLE

        [Section("Rifle : Target Practice")]
        [Name("Recycled Cans & Spray Paint Cans : Level 1")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceCanRifle1 = 45;

        [Name("Recycled Cans & Spray Paint Cans : Level 2")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceCanRifle2 = 50;

        [Name("Recycled Cans & Spray Paint Cans : Level 3")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceCanRifle3 = 55;

        [Name("Recycled Cans & Spray Paint Cans : Level 4")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceCanRifle4 = 60;

        [Name("Bullseye : Level 1")]
        [Description("Min distance required to earn a skill point with rifle. FOV max 130 . Do not really fit with rifle training\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRifle1 = 115;

        [Name("Bullseye : Level 2")]
        [Description("Min distance required to earn a skill point with rifle. FOV max 130 . Do not really fit with rifle training\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRifle2 = 130;

        [Name("Bullseye : Level 3")]
        [Description("Min distance required to earn a skill point with rifle. FOV max 130 . Do not really fit with rifle training\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRifle3 = 300;

        [Name("Bullseye : Level 4")]
        [Description("Min distance required to earn a skill point with rifle. FOV max 130 . Do not really fit with rifle training\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRifle4 = 300;

        [Section("Rifle : Master Hunter")]
        [Name("Rabbit & Ptarmigan : Level 1")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceSmallPreyRifle1 = 50;

        [Name("Rabbit & Ptarmigan : Level 2")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceSmallPreyRifle2 = 60;

        [Name("Rabbit & Ptarmigan : Level 3")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceSmallPreyRifle3 = 70;

        [Name("Rabbit & Ptarmigan : Level 4")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceSmallPreyRifle4 = 80;

        [Name("Stag, Doe, Wolf & Cougar : Level 1")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceMediumPreyRifle1 = 155;

        [Name("Stag, Doe, Wolf & Cougar : Level 2")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceMediumPreyRifle2 = 170;

        [Name("Stag, Doe, Wolf & Cougar : Level 3")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceMediumPreyRifle3 = 185;

        [Name("Stag, Doe, Wolf & Cougar : Level 4")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceMediumPreyRifle4 = 200;

        [Name("Moose & Bear : Level 1")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceBigPreyRifle1 = 185;

        [Name("Moose & Bear : Level 2")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceBigPreyRifle2 = 200;

        [Name("Moose & Bear : Level 3")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceBigPreyRifle3 = 215;

        [Name("Moose & Bear : Level 4")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceBigPreyRifle4 = 230;

        // SECTION REVOLVER

        [Section("Revolver : Target Practice")]
        [Name("Recycled Cans & Spray Paint Cans : Level 1")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceCanRevolver1 = 36;

        [Name("Recycled Cans & Spray Paint Cans : Level 2")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceCanRevolver2 = 40;

        [Name("Recycled Cans & Spray Paint Cans : Level 3")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceCanRevolver3 = 44;

        [Name("Recycled Cans & Spray Paint Cans : Level 4")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceCanRevolver4 = 48;

        [Name("Bullseye : Level 1")]
        [Description("Min distance required to earn a skill point with revolver. FOV max 130 . Do not really fit with revolver training\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRevolver1 = 92;

        [Name("Bullseye : Level 2")]
        [Description("Min distance required to earn a skill point with revolver. FOV max 130 . Do not really fit with revolver training\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRevolver2 = 104;

        [Name("Bullseye : Level 3")]
        [Description("Min distance required to earn a skill point with revolver. FOV max 130 . Do not really fit with revolver training\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRevolver3 = 120;

        [Name("Bullseye : Level 4")]
        [Description("Min distance required to earn a skill point with revolver. FOV max 130 . Do not really fit with revolver training\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRevolver4 = 300;

        [Section("Revolver : Master Hunter")]
        [Name("Rabbit & Ptarmigan : Level 1")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceSmallPreyRevolver1 = 40;

        [Name("Rabbit & Ptarmigan : Level 2")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceSmallPreyRevolver2 = 48;

        [Name("Rabbit & Ptarmigan : Level 3")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceSmallPreyRevolver3 = 56;

        [Name("Rabbit & Ptarmigan : Level 4")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceSmallPreyRevolver4 = 64;

        [Name("Stag, Doe, Wolf & Cougar : Level 1")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceMediumPreyRevolver1 = 124;

        [Name("Stag, Doe, Wolf & Cougar : Level 2")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceMediumPreyRevolver2 = 136;

        [Name("Stag, Doe, Wolf & Cougar : Level 3")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceMediumPreyRevolver3 = 148;

        [Name("Stag, Doe, Wolf & Cougar : Level 4")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceMediumPreyRevolver4 = 160;

        [Name("Moose & Bear : Level 1")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceBigPreyRevolver1 = 148;

        [Name("Moose & Bear : Level 2")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceBigPreyRevolver2 = 160;

        [Name("Moose & Bear : Level 3")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceBigPreyRevolver3 = 172;

        [Name("Moose & Bear : Level 4")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceBigPreyRevolver4 = 184;


        // SECTION BOW

        [Section("Bow : Target Practice")]
        [Name("Bullseye : Level 1")]
        [Description("Min distance required to earn a skill point with Bow.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeBow1 = 80;

        [Name("Bullseye : Level 2")]
        [Description("Min distance required to earn a skill point with Bow.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeBow2 = 100;

        [Name("Bullseye : Level 3")]
        [Description("Min distance required to earn a skill point with Bow.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeBow3 = 115;

        [Name("Bullseye : Level 4")]
        [Description("Min distance required to earn a skill point with Bow.\nMust hit the paper bullseye(not the outer rim)")]
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
        [Description("NO: Vanilla values \nYES: Custom values (see descriptions for more details)\n Need to change scene for the change to be applied")]
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
                    distanceCanRifle1 = 25;
                    distanceCanRifle2 = 30;
                    distanceCanRifle3 = 35;
                    distanceCanRifle4 = 40;
                    distanceBullseyeRifle1 = 65;
                    distanceBullseyeRifle2 = 80;
                    distanceBullseyeRifle3 = 95;
                    distanceBullseyeRifle4 = 110;
                    distanceSmallPreyRifle1 = 20;
                    distanceSmallPreyRifle2 = 30;
                    distanceSmallPreyRifle3 = 40;
                    distanceSmallPreyRifle4 = 50;
                    distanceMediumPreyRifle1 = 95;
                    distanceMediumPreyRifle2 = 110;
                    distanceMediumPreyRifle3 = 125;
                    distanceMediumPreyRifle4 = 140;
                    distanceBigPreyRifle1 = 125;
                    distanceBigPreyRifle2 = 140;
                    distanceBigPreyRifle3 = 155;
                    distanceBigPreyRifle4 = 170;

                    distanceCanRevolver1 = 20;
                    distanceCanRevolver2 = 24;
                    distanceCanRevolver3 = 28;
                    distanceCanRevolver4 = 32;
                    distanceBullseyeRevolver1 = 52;
                    distanceBullseyeRevolver2 = 64;
                    distanceBullseyeRevolver3 = 76;
                    distanceBullseyeRevolver4 = 88;
                    distanceSmallPreyRevolver1 = 16;
                    distanceSmallPreyRevolver2 = 24;
                    distanceSmallPreyRevolver3 = 32;
                    distanceSmallPreyRevolver4 = 40;
                    distanceMediumPreyRevolver1 = 76;
                    distanceMediumPreyRevolver2 = 88;
                    distanceMediumPreyRevolver3 = 100;
                    distanceMediumPreyRevolver4 = 112;
                    distanceBigPreyRevolver1 = 100;
                    distanceBigPreyRevolver2 = 112;
                    distanceBigPreyRevolver3 = 124;
                    distanceBigPreyRevolver4 = 136;

                    distanceBullseyeBow1 = 35;
                    distanceBullseyeBow2 = 50;
                    distanceBullseyeBow3 = 65;
                    distanceBullseyeBow4 = 80;
                    distanceSmallPreyBow1 = 15;
                    distanceSmallPreyBow2 = 25;
                    distanceSmallPreyBow3 = 35;
                    distanceSmallPreyBow4 = 45;
                    distanceMediumPreyBow1 = 15;
                    distanceMediumPreyBow2 = 30;
                    distanceMediumPreyBow3 = 45;
                    distanceMediumPreyBow4 = 60;
                    distanceBigPreyBow1 = 35;
                    distanceBigPreyBow2 = 50;
                    distanceBigPreyBow3 = 65;
                    distanceBigPreyBow4 = 80;
                    break;

                case 1:
                    // Apply Intermediate distances
                    distanceCanRifle1 = 35;
                    distanceCanRifle2 = 40;
                    distanceCanRifle3 = 45;
                    distanceCanRifle4 = 50;
                    distanceBullseyeRifle1 = 95;
                    distanceBullseyeRifle2 = 110;
                    distanceBullseyeRifle3 = 125;
                    distanceBullseyeRifle4 = 300;
                    distanceSmallPreyRifle1 = 35;
                    distanceSmallPreyRifle2 = 45;
                    distanceSmallPreyRifle3 = 55;
                    distanceSmallPreyRifle4 = 65;
                    distanceMediumPreyRifle1 = 125;
                    distanceMediumPreyRifle2 = 140;
                    distanceMediumPreyRifle3 = 155;
                    distanceMediumPreyRifle4 = 170;
                    distanceBigPreyRifle1 = 155;
                    distanceBigPreyRifle2 = 170;
                    distanceBigPreyRifle3 = 185;
                    distanceBigPreyRifle4 = 200;

                    distanceCanRevolver1 = 28;
                    distanceCanRevolver2 = 32;
                    distanceCanRevolver3 = 36;
                    distanceCanRevolver4 = 40;
                    distanceBullseyeRevolver1 = 76;
                    distanceBullseyeRevolver2 = 88;
                    distanceBullseyeRevolver3 = 100;
                    distanceBullseyeRevolver4 = 240;
                    distanceSmallPreyRevolver1 = 28;
                    distanceSmallPreyRevolver2 = 36;
                    distanceSmallPreyRevolver3 = 44;
                    distanceSmallPreyRevolver4 = 52;
                    distanceMediumPreyRevolver1 = 100;
                    distanceMediumPreyRevolver2 = 112;
                    distanceMediumPreyRevolver3 = 124;
                    distanceMediumPreyRevolver4 = 136;
                    distanceBigPreyRevolver1 = 124;
                    distanceBigPreyRevolver2 = 136;
                    distanceBigPreyRevolver3 = 148;
                    distanceBigPreyRevolver4 = 160;

                    distanceBullseyeBow1 = 65;
                    distanceBullseyeBow2 = 80;
                    distanceBullseyeBow3 = 95;
                    distanceBullseyeBow4 = 110;
                    distanceSmallPreyBow1 = 25;
                    distanceSmallPreyBow2 = 35;
                    distanceSmallPreyBow3 = 45;
                    distanceSmallPreyBow4 = 55;
                    distanceMediumPreyBow1 = 35;
                    distanceMediumPreyBow2 = 50;
                    distanceMediumPreyBow3 = 65;
                    distanceMediumPreyBow4 = 80;
                    distanceBigPreyBow1 = 65;
                    distanceBigPreyBow2 = 80;
                    distanceBigPreyBow3 = 95;
                    distanceBigPreyBow4 = 110;
                    break;

                case 2:
                    // Apply Master distances
                    distanceCanRifle1 = 45;
                    distanceCanRifle2 = 50;
                    distanceCanRifle3 = 55;
                    distanceCanRifle4 = 60;
                    distanceBullseyeRifle1 = 115;
                    distanceBullseyeRifle2 = 130;
                    distanceBullseyeRifle3 = 300;
                    distanceBullseyeRifle4 = 300;
                    distanceSmallPreyRifle1 = 50;
                    distanceSmallPreyRifle2 = 60;
                    distanceSmallPreyRifle3 = 70;
                    distanceSmallPreyRifle4 = 80;
                    distanceMediumPreyRifle1 = 155;
                    distanceMediumPreyRifle2 = 170;
                    distanceMediumPreyRifle3 = 185;
                    distanceMediumPreyRifle4 = 200;
                    distanceBigPreyRifle1 = 185;
                    distanceBigPreyRifle2 = 200;
                    distanceBigPreyRifle3 = 215;
                    distanceBigPreyRifle4 = 230;

                    distanceCanRevolver1 = 36;
                    distanceCanRevolver2 = 40;
                    distanceCanRevolver3 = 44;
                    distanceCanRevolver4 = 48;
                    distanceBullseyeRevolver1 = 92;
                    distanceBullseyeRevolver2 = 104;
                    distanceBullseyeRevolver3 = 120;
                    distanceBullseyeRevolver4 = 300;
                    distanceSmallPreyRevolver1 = 40;
                    distanceSmallPreyRevolver2 = 48;
                    distanceSmallPreyRevolver3 = 56;
                    distanceSmallPreyRevolver4 = 64;
                    distanceMediumPreyRevolver1 = 124;
                    distanceMediumPreyRevolver2 = 136;
                    distanceMediumPreyRevolver3 = 148;
                    distanceMediumPreyRevolver4 = 160;
                    distanceBigPreyRevolver1 = 148;
                    distanceBigPreyRevolver2 = 160;
                    distanceBigPreyRevolver3 = 172;
                    distanceBigPreyRevolver4 = 184;

                    distanceBullseyeBow1 = 80;
                    distanceBullseyeBow2 = 100;
                    distanceBullseyeBow3 = 115;
                    distanceBullseyeBow4 = 130;
                    distanceSmallPreyBow1 = 30;
                    distanceSmallPreyBow2 = 40;
                    distanceSmallPreyBow3 = 50;
                    distanceSmallPreyBow4 = 60;
                    distanceMediumPreyBow1 = 55;
                    distanceMediumPreyBow2 = 70;
                    distanceMediumPreyBow3 = 85;
                    distanceMediumPreyBow4 = 100;
                    distanceBigPreyBow1 = 80;
                    distanceBigPreyBow2 = 100;
                    distanceBigPreyBow3 = 115;
                    distanceBigPreyBow4 = 130;
                    break;
            }
        }

        internal void RefreshFields()
        {

            SetFieldVisible(nameof(distanceSmallPreyRifle1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyRifle2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyRifle3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyRifle4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyRifle1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyRifle2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyRifle3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyRifle4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyRifle1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyRifle2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyRifle3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyRifle4), Settings.settings.updateMasterHunter == true);

            SetFieldVisible(nameof(distanceSmallPreyRevolver1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyRevolver2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyRevolver3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceSmallPreyRevolver4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyRevolver1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyRevolver2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyRevolver3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceMediumPreyRevolver4), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyRevolver1), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyRevolver2), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyRevolver3), Settings.settings.updateMasterHunter == true);
            SetFieldVisible(nameof(distanceBigPreyRevolver4), Settings.settings.updateMasterHunter == true);

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
            UpdateReferences();
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

        internal static void UpdateReferences()
        {
            TargetPracticeAndMasterHunter.referencesBow = new string[,]
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

            TargetPracticeAndMasterHunter.referencesRifle = new string[,]
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

            TargetPracticeAndMasterHunter.referencesRevolver = new string[,]
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

    internal static class Settings
    {
        public static TargetPracticeAndMasterHunterSettings settings = new();

        public static void OnLoad()
        {
            settings.AddToModSettings("Target Practice & Master Hunter Settings");
            settings.RefreshFields();

        }
    }
    
}
