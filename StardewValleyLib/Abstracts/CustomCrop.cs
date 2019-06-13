using System;
using StardewValley;

namespace StardewValleyLib.Abstracts
{

    public class CustomCrop : Crop
    {
        private readonly String name;
        private readonly int price;
        private readonly String seedName;
        private readonly CropType cropType;
        private readonly Season season;
        private readonly int phases;
        private readonly int regrowthPhase;
        private readonly bool canHarvestWithScythe;
        private readonly bool isTrellisCrop;
        private readonly int bonus;
        private readonly int minHarvest;
        private readonly int maxHarvest;
        private readonly int farmSkillExp;
        private readonly int extraChance;
        private readonly int seedPurchasePrice;

        public CustomCrop()
        {
        }

        public enum CropType
        {
            FLOWER,
            FRUIT,
            VEGETABLE,
            GEM,
            FISH,
            EGG,
            MILK,
            COOKING,
            CRAFTING,
            MINERAL,
            MEAT,
            METAL,
            JUNK,
            SYRUP,
            MONSTER_LOOT,
            ARTISAN_GOODS,
            SEEDS
        }

        public enum Season
        {
            SPRING,
            SUMMER,
            FALL,
            WINTER
        }

    }
}
