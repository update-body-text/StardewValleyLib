using System;
using StardewValley;
using StardewValleyLib.Abstracts;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValleyLib.Crops
{
    public class TestCrop : CustomCrop
    {
        private new const string Name = "Test Flower";
        private new const int Price = 2;
        private new const string SeedName = "Test Flower Seeds";
        private new const CropType Type = CropType.FLOWER;
        private new const Season GrowthSeason = Season.SPRING;
        private new const int Phases = 2;
        private new const int RegrowthPhase = 2;
        private new const bool CanHarvestWithScythe = true;
        private new const bool IsTrellisCrop = true;
        private new const int MinHarvest = 1;
        private new const int MaxHarvest = 3;
        private new const int FarmSkillExp = 5;
        private new const double ExtraChance = 0.5;
        private new const int SeedPurchasePrice = 20;
        private new static Texture2D Texture = Game1.content.Load<Texture2D>("Resources/SDVLib/CreepFlower.png");


        public TestCrop() :
        base(Name, Price, SeedName, Type, GrowthSeason, Phases, RegrowthPhase,
             CanHarvestWithScythe, IsTrellisCrop, MinHarvest, MaxHarvest, FarmSkillExp,
            ExtraChance, SeedPurchasePrice, Texture)
        {

        }
    }
}
