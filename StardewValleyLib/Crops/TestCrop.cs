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
        private new int Phases = 2;
        private new int RegrowthPhase = 2;
        private new bool CanHarvestWithScythe = true;
        private new bool IsTrellisCrop = true;
        private new int MinHarvest = 1;
        private new int MaxHarvest = 3;
        private new int FarmSkillExp = 5;
        private new double ExtraChance = 0.5;
        private new int SeedPurchasePrice = 20;
        private new Texture2D Texture = Game1.content.Load<Texture2D>("Resources/SDVLib/CreepFlower.png");


        public TestCrop()
        {
        }
    }
}
