using System;
using StardewValley;
using StardewValleyLib.Abstracts;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValleyLib.Crops
{
    public class TestCrop : CustomCrop
    {
        private const string NAME = "Test Flower";
        private const int PRICE = 2;
        private const string SEED_NAME = "Test Flower Seeds";
        private const CropType TYPE = CropType.FLOWER;
        private const Season GROWTH_SEASON = Season.SPRING;
        private const int PHASES = 2;
        private const int REGROWTH_PHASES = 2;
        private const bool CAN_HARVEST_WITH_SCYTHE = true;
        private const bool IS_TRELLIS_CROP = true;
        private const int MIN_HARVEST = 1;
        private const int MAX_HARVEST = 3;
        private const int FARM_SKILL_EXP = 5;
        private const double EXTRA_CHANCE = 0.5;
        private const int SEED_PRICE = 20;
        private static Texture2D TEXTURE = Game1.content.Load<Texture2D>("Resources/SDVLib/CreepFlower.png");


        public TestCrop() :
        base(NAME, PRICE, SEED_NAME, TYPE, GROWTH_SEASON, PHASES, REGROWTH_PHASES,
             CAN_HARVEST_WITH_SCYTHE, IS_TRELLIS_CROP,MIN_HARVEST,MAX_HARVEST,
             FARM_SKILL_EXP, EXTRA_CHANCE, SEED_PRICE, TEXTURE)
        {

        }
    }
}
