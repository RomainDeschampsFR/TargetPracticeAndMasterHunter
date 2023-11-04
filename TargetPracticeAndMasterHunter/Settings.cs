using ModSettings;
using System.Reflection;
using UnityEngine;

namespace TargetPracticeAndMasterHunter
{
    internal class TargetPracticeAndMasterHunterSettings : JsonModSettings
    {
        // RECORDS KEY

        [Section("GLOBAL SETTINGS")]
        [Name("Display Records")]
        [Description("Displays distance records table for each target and weapon type")]
        public KeyCode recordKeyCode = KeyCode.Comma;

        // DISABLE POINTS FROM ARROW CRAFTING

        [Name("Disable arrow crafting points")]
        [Description("NO: Default \nYES: Arrow crafting no longer provides skill points\n Need to change scene for the change to be applied")]
        public bool updateCraftingSkillPoints = true;

        // ENABLE INCRELENTAL BONUS

        [Name("Enable incremental bonus")]
        [Description("NO: Disabled for Target Pratice & Master Hunter \nYES: Each distance threshold provide 1 more point.\ne.g. If you are level 2 and hit a target by shooting beyond the distance for level 4, you earn 3 points instead of 1.")]
        public bool updateIncrementalBonus = false;

        //HEADSHOT BONUS

        [Name("Headshot bonus")]
        [Description("NO: No bonus \nYES: You earn one more skill points if you hit an animal in its head. (Distance requirement must be met as well)")]
        public bool updateHeadshotBonus = false;

        // ENABLE SIDE-STEP

        [Name("Enable side-step while training")]
        [Description("NO: Disabled \nYES: Auto side-step when successfully hiting a training target")]
        public bool updateSideStep = true;

        // ENABLE HUD MESSAGE

        [Name("Enable HUD Message")]
        [Description("NO: Disabled \nYES: Display on screen useful information like, among other things, the distance beetween you and the target")]
        public bool updateHUD = true;

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
        public int distanceCanRifle1 = 20;

        [Name("Recycled Cans & Spray Paint Cans : Level 2")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceCanRifle2 = 24;

        [Name("Recycled Cans & Spray Paint Cans : Level 3")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceCanRifle3 = 28;

        [Name("Recycled Cans & Spray Paint Cans : Level 4")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceCanRifle4 = 32;

        [Name("Bullseye : Level 1")]
        [Description("Min distance required to earn a skill point with rifle.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRifle1 = 70;

        [Name("Bullseye : Level 2")]
        [Description("Min distance required to earn a skill point with rifle.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRifle2 = 90;

        [Name("Bullseye : Level 3")]
        [Description("Min distance required to earn a skill point with rifle.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRifle3 = 110;

        [Name("Bullseye : Level 4")]
        [Description("Min distance required to earn a skill point with rifle.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRifle4 = 130;

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
        public int distanceMediumPreyRifle1 = 110;

        [Name("Stag, Doe, Wolf & Cougar : Level 2")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceMediumPreyRifle2 = 140;

        [Name("Stag, Doe, Wolf & Cougar : Level 3")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceMediumPreyRifle3 = 170;

        [Name("Stag, Doe, Wolf & Cougar : Level 4")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceMediumPreyRifle4 = 200;

        [Name("Moose & Bear : Level 1")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceBigPreyRifle1 = 140;

        [Name("Moose & Bear : Level 2")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceBigPreyRifle2 = 170;

        [Name("Moose & Bear : Level 3")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceBigPreyRifle3 = 200;

        [Name("Moose & Bear : Level 4")]
        [Description("Min distance required to earn a skill point with rifle")]
        [Slider(0, 300)]
        public int distanceBigPreyRifle4 = 230;

        // SECTION REVOLVER

        [Section("Revolver : Target Practice")]
        [Name("Recycled Cans & Spray Paint Cans : Level 1")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceCanRevolver1 = 12;

        [Name("Recycled Cans & Spray Paint Cans : Level 2")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceCanRevolver2 = 14;

        [Name("Recycled Cans & Spray Paint Cans : Level 3")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceCanRevolver3 = 16;

        [Name("Recycled Cans & Spray Paint Cans : Level 4")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceCanRevolver4 = 18;

        [Name("Bullseye : Level 1")]
        [Description("Min distance required to earn a skill point with revolver. FOV max 130 \nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRevolver1 = 40;

        [Name("Bullseye : Level 2")]
        [Description("Min distance required to earn a skill point with revolver. FOV max 130 \nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRevolver2 = 50;

        [Name("Bullseye : Level 3")]
        [Description("Min distance required to earn a skill point with revolver. FOV max 130 \nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRevolver3 = 60;

        [Name("Bullseye : Level 4")]
        [Description("Min distance required to earn a skill point with revolver. FOV max 130 \nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeRevolver4 = 70;

        [Section("Revolver : Master Hunter")]
        [Name("Rabbit & Ptarmigan : Level 1")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceSmallPreyRevolver1 = 22;

        [Name("Rabbit & Ptarmigan : Level 2")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceSmallPreyRevolver2 = 26;

        [Name("Rabbit & Ptarmigan : Level 3")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceSmallPreyRevolver3 = 30;

        [Name("Rabbit & Ptarmigan : Level 4")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceSmallPreyRevolver4 = 34;

        [Name("Stag, Doe, Wolf & Cougar : Level 1")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceMediumPreyRevolver1 = 36;

        [Name("Stag, Doe, Wolf & Cougar : Level 2")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceMediumPreyRevolver2 = 44;

        [Name("Stag, Doe, Wolf & Cougar : Level 3")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceMediumPreyRevolver3 = 52;

        [Name("Stag, Doe, Wolf & Cougar : Level 4")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceMediumPreyRevolver4 = 60;

        [Name("Moose & Bear : Level 1")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceBigPreyRevolver1 = 88;

        [Name("Moose & Bear : Level 2")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceBigPreyRevolver2 = 100;

        [Name("Moose & Bear : Level 3")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceBigPreyRevolver3 = 112;

        [Name("Moose & Bear : Level 4")]
        [Description("Min distance required to earn a skill point with revolver")]
        [Slider(0, 300)]
        public int distanceBigPreyRevolver4 = 124;


        // SECTION BOW

        [Section("Bow : Target Practice")]
        [Name("Bullseye : Level 1")]
        [Description("Min distance required to earn a skill point with Bow.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeBow1 = 70;

        [Name("Bullseye : Level 2")]
        [Description("Min distance required to earn a skill point with Bow.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeBow2 = 90;

        [Name("Bullseye : Level 3")]
        [Description("Min distance required to earn a skill point with Bow.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeBow3 = 110;

        [Name("Bullseye : Level 4")]
        [Description("Min distance required to earn a skill point with Bow.\nMust hit the paper bullseye(not the outer rim)")]
        [Slider(0, 300)]
        public int distanceBullseyeBow4 = 130;

        [Name("Haybale : Level 1")]
        [Description("Min distance required to earn a skill point with Bow.")]
        [Slider(0, 300)]
        public int distanceHaybaleBow1 = 90;

        [Name("Haybale : Level 2")]
        [Description("Min distance required to earn a skill point with Bow.")]
        [Slider(0, 300)]
        public int distanceHaybaleBow2 = 110;

        [Name("Haybale : Level 3")]
        [Description("Min distance required to earn a skill point with Bow.")]
        [Slider(0, 300)]
        public int distanceHaybaleBow3 = 130;

        [Name("Haybale : Level 4")]
        [Description("Min distance required to earn a skill point with Bow.")]
        [Slider(0, 300)]
        public int distanceHaybaleBow4 = 150;

        [Section("Bow : Master Hunter")]
        [Name("Rabbit & Ptarmigan : Level 1")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceSmallPreyBow1 = 22;

        [Name("Rabbit & Ptarmigan : Level 2")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceSmallPreyBow2 = 28;

        [Name("Rabbit & Ptarmigan : Level 3")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceSmallPreyBow3 = 34;

        [Name("Rabbit & Ptarmigan : Level 4")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceSmallPreyBow4 = 40;

        [Name("Stag, Doe, Wolf & Cougar : Level 1")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceMediumPreyBow1 = 40;

        [Name("Stag, Doe, Wolf & Cougar : Level 2")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceMediumPreyBow2 = 50;

        [Name("Stag, Doe, Wolf & Cougar : Level 3")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceMediumPreyBow3 = 60;

        [Name("Stag, Doe, Wolf & Cougar : Level 4")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceMediumPreyBow4 = 70;

        [Name("Moose & Bear : Level 1")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBigPreyBow1 = 70;

        [Name("Moose & Bear : Level 2")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBigPreyBow2 = 80;

        [Name("Moose & Bear : Level 3")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBigPreyBow3 = 90;

        [Name("Moose & Bear : Level 4")]
        [Description("Min distance required to earn a skill point with Bow")]
        [Slider(0, 300)]
        public int distanceBigPreyBow4 = 100;

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
        [Description("Default Game Value: 10\nMaster Hunter Recommended Value : 6")]
        [Slider(2, 20)]
        public int pointsRifleFirearmAdvanced = 10;

        // OTHER BOOKS

        [Section("Other books")]
        [Name("Fire Starting book : reading time")]
        [Description("Default Game Value: 5")]
        [Slider(1, 30)]
        public int timeFireStarting = 5;

        [Name("Fire Starting book : points earned")]
        [Description("Default Game Value: 10")]
        [Slider(2, 20)]
        public int pointsFireStarting = 10;

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
                    distanceCanRifle1 = 12;
                    distanceCanRifle2 = 16;
                    distanceCanRifle3 = 20;
                    distanceCanRifle4 = 24;
                    distanceBullseyeRifle1 = 30;
                    distanceBullseyeRifle2 = 50;
                    distanceBullseyeRifle3 = 70;
                    distanceBullseyeRifle4 = 90;
                    distanceSmallPreyRifle1 = 30;
                    distanceSmallPreyRifle2 = 40;
                    distanceSmallPreyRifle3 = 50;
                    distanceSmallPreyRifle4 = 60;
                    distanceMediumPreyRifle1 = 50;
                    distanceMediumPreyRifle2 = 80;
                    distanceMediumPreyRifle3 = 110;
                    distanceMediumPreyRifle4 = 140;
                    distanceBigPreyRifle1 = 80;
                    distanceBigPreyRifle2 = 110;
                    distanceBigPreyRifle3 = 140;
                    distanceBigPreyRifle4 = 170;

                    distanceCanRevolver1 = 8;
                    distanceCanRevolver2 = 10;
                    distanceCanRevolver3 = 12;
                    distanceCanRevolver4 = 14;
                    distanceBullseyeRevolver1 = 20;
                    distanceBullseyeRevolver2 = 30;
                    distanceBullseyeRevolver3 = 40;
                    distanceBullseyeRevolver4 = 50;
                    distanceSmallPreyRevolver1 = 14;
                    distanceSmallPreyRevolver2 = 18;
                    distanceSmallPreyRevolver3 = 22;
                    distanceSmallPreyRevolver4 = 26;
                    distanceMediumPreyRevolver1 = 20;
                    distanceMediumPreyRevolver2 = 28;
                    distanceMediumPreyRevolver3 = 36;
                    distanceMediumPreyRevolver4 = 44;
                    distanceBigPreyRevolver1 = 64;
                    distanceBigPreyRevolver2 = 76;
                    distanceBigPreyRevolver3 = 88;
                    distanceBigPreyRevolver4 = 100;

                    distanceBullseyeBow1 = 30;
                    distanceBullseyeBow2 = 50;
                    distanceBullseyeBow3 = 70;
                    distanceBullseyeBow4 = 90;
                    distanceHaybaleBow1 = 50;
                    distanceHaybaleBow2 = 70;
                    distanceHaybaleBow3 = 90;
                    distanceHaybaleBow4 = 110;
                    distanceSmallPreyBow1 = 10;
                    distanceSmallPreyBow2 = 16;
                    distanceSmallPreyBow3 = 22;
                    distanceSmallPreyBow4 = 28;
                    distanceMediumPreyBow1 = 20;
                    distanceMediumPreyBow2 = 30;
                    distanceMediumPreyBow3 = 40;
                    distanceMediumPreyBow4 = 50;
                    distanceBigPreyBow1 = 50;
                    distanceBigPreyBow2 = 60;
                    distanceBigPreyBow3 = 70;
                    distanceBigPreyBow4 = 80;
                    break;

                case 1:
                    // Apply Intermediate distances
                    distanceCanRifle1 = 16;
                    distanceCanRifle2 = 20;
                    distanceCanRifle3 = 24;
                    distanceCanRifle4 = 28;
                    distanceBullseyeRifle1 = 50;
                    distanceBullseyeRifle2 = 70;
                    distanceBullseyeRifle3 = 90;
                    distanceBullseyeRifle4 = 110;
                    distanceSmallPreyRifle1 = 40;
                    distanceSmallPreyRifle2 = 50;
                    distanceSmallPreyRifle3 = 60;
                    distanceSmallPreyRifle4 = 70;
                    distanceMediumPreyRifle1 = 80;
                    distanceMediumPreyRifle2 = 110;
                    distanceMediumPreyRifle3 = 140;
                    distanceMediumPreyRifle4 = 170;
                    distanceBigPreyRifle1 = 110;
                    distanceBigPreyRifle2 = 140;
                    distanceBigPreyRifle3 = 170;
                    distanceBigPreyRifle4 = 200;

                    distanceCanRevolver1 = 10;
                    distanceCanRevolver2 = 12;
                    distanceCanRevolver3 = 14;
                    distanceCanRevolver4 = 16;
                    distanceBullseyeRevolver1 = 30;
                    distanceBullseyeRevolver2 = 40;
                    distanceBullseyeRevolver3 = 50;
                    distanceBullseyeRevolver4 = 60;
                    distanceSmallPreyRevolver1 = 18;
                    distanceSmallPreyRevolver2 = 22;
                    distanceSmallPreyRevolver3 = 26;
                    distanceSmallPreyRevolver4 = 30;
                    distanceMediumPreyRevolver1 = 28;
                    distanceMediumPreyRevolver2 = 36;
                    distanceMediumPreyRevolver3 = 44;
                    distanceMediumPreyRevolver4 = 52;
                    distanceBigPreyRevolver1 = 76;
                    distanceBigPreyRevolver2 = 88;
                    distanceBigPreyRevolver3 = 100;
                    distanceBigPreyRevolver4 = 112;

                    distanceBullseyeBow1 = 50;
                    distanceBullseyeBow2 = 70;
                    distanceBullseyeBow3 = 90;
                    distanceBullseyeBow4 = 110;
                    distanceHaybaleBow1 = 70;
                    distanceHaybaleBow2 = 90;
                    distanceHaybaleBow3 = 110;
                    distanceHaybaleBow4 = 130;
                    distanceSmallPreyBow1 = 16;
                    distanceSmallPreyBow2 = 22;
                    distanceSmallPreyBow3 = 28;
                    distanceSmallPreyBow4 = 34;
                    distanceMediumPreyBow1 = 30;
                    distanceMediumPreyBow2 = 40;
                    distanceMediumPreyBow3 = 50;
                    distanceMediumPreyBow4 = 60;
                    distanceBigPreyBow1 = 60;
                    distanceBigPreyBow2 = 70;
                    distanceBigPreyBow3 = 80;
                    distanceBigPreyBow4 = 90;
                    break;

                case 2:
                    // Apply Master distances
                    distanceCanRifle1 = 20;
                    distanceCanRifle2 = 24;
                    distanceCanRifle3 = 28;
                    distanceCanRifle4 = 32;
                    distanceBullseyeRifle1 = 70;
                    distanceBullseyeRifle2 = 90;
                    distanceBullseyeRifle3 = 110;
                    distanceBullseyeRifle4 = 130;
                    distanceSmallPreyRifle1 = 50;
                    distanceSmallPreyRifle2 = 60;
                    distanceSmallPreyRifle3 = 70;
                    distanceSmallPreyRifle4 = 80;
                    distanceMediumPreyRifle1 = 110;
                    distanceMediumPreyRifle2 = 140;
                    distanceMediumPreyRifle3 = 170;
                    distanceMediumPreyRifle4 = 200;
                    distanceBigPreyRifle1 = 140;
                    distanceBigPreyRifle2 = 170;
                    distanceBigPreyRifle3 = 200;
                    distanceBigPreyRifle4 = 230;

                    distanceCanRevolver1 = 12;
                    distanceCanRevolver2 = 14;
                    distanceCanRevolver3 = 16;
                    distanceCanRevolver4 = 18;
                    distanceBullseyeRevolver1 = 40;
                    distanceBullseyeRevolver2 = 50;
                    distanceBullseyeRevolver3 = 60;
                    distanceBullseyeRevolver4 = 70;
                    distanceSmallPreyRevolver1 = 22;
                    distanceSmallPreyRevolver2 = 26;
                    distanceSmallPreyRevolver3 = 30;
                    distanceSmallPreyRevolver4 = 34;
                    distanceMediumPreyRevolver1 = 36;
                    distanceMediumPreyRevolver2 = 44;
                    distanceMediumPreyRevolver3 = 52;
                    distanceMediumPreyRevolver4 = 60;
                    distanceBigPreyRevolver1 = 88;
                    distanceBigPreyRevolver2 = 100;
                    distanceBigPreyRevolver3 = 112;
                    distanceBigPreyRevolver4 = 124;

                    distanceBullseyeBow1 = 70;
                    distanceBullseyeBow2 = 90;
                    distanceBullseyeBow3 = 110;
                    distanceBullseyeBow4 = 130;
                    distanceHaybaleBow1 = 90;
                    distanceHaybaleBow2 = 110;
                    distanceHaybaleBow3 = 130;
                    distanceHaybaleBow4 = 150;
                    distanceSmallPreyBow1 = 22;
                    distanceSmallPreyBow2 = 28;
                    distanceSmallPreyBow3 = 34;
                    distanceSmallPreyBow4 = 40;
                    distanceMediumPreyBow1 = 40;
                    distanceMediumPreyBow2 = 50;
                    distanceMediumPreyBow3 = 60;
                    distanceMediumPreyBow4 = 70;
                    distanceBigPreyBow1 = 70;
                    distanceBigPreyBow2 = 80;
                    distanceBigPreyBow3 = 90;
                    distanceBigPreyBow4 = 100;
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
