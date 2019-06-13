using System;
using StardewValley;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValleyLib.Abstracts
{

    public class CustomCrop : Crop
    {
        private String Name 
        {
            get; set;
        }
        private int Price
        {
            get { return CropPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException( $"{nameof(value)} cannot be negative.");
                }
                CropPrice = value;
            }
        }
        private String SeedName
        {
            get; set;
        }
        private CropType Type
        {
            get; set;
        }
        private Season GrowthSeason
        {
            get; set;
        }
        private int Phases
        {
            get { return AmountOfGrowthCycles; }
            set
            {
                if (value < 1) {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be above 0.");
                }
                AmountOfGrowthCycles = value;

            }
        }
        private int RegrowthPhase
        {
            get; set;
        }
        private bool CanHarvestWithScythe
        {
            get; set;
        }
        private bool IsTrellisCrop
        {
            get; set;
        }
        private int Bonus
        {
            get; set;
        }
        private int MinHarvest
        {
            get { return MinAmountOfCropsOnHarvest; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be above 0.");
                }
                MinAmountOfCropsOnHarvest = value;

            }
        }
        private int MaxHarvest
        {
            get; set;
        }
        private int FarmSkillExp
        {
            get; set;
        }
        private float ExtraChance
        {
            get { return extraChance; }
            set
            {
                if (value < 0 || value > 1)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be between 0 or 1 inclusive.");
                }
                extraChance = value;
            }
        }
        private int SeedPurchasePrice
        {
            get { return SeedPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} cannot be negative.");
                }
                SeedPrice = value;
            }

        }
        private Texture2D Texture
        {
            get; set;
        }

        private int CropPrice;
        private int AmountOfGrowthCycles;
        private int MinAmountOfCropsOnHarvest;
        private float extraChance;
        private int SeedPrice;

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
