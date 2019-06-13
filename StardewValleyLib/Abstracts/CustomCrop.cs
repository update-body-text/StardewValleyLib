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
            get { return Price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException( $"{nameof(value)} cannot be negative.");
                }
                Price = value;
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
            get { return Price; }
            set
            {
                if (value < 1) {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be above 0.");
                }
                Phases = value;

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
            get { return minHarvest; }
            set
            {
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be above 0.");
                }
                Phases = value;

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
        private int ExtraChance
        {
            get { return ExtraChance; }
            set
            {
                if (value != 0 || value != 1)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be 0 or 1.");
                }
                ExtraChance = value;
            }
        }
        private int SeedPurchasePrice
        {
            get { return SeedPurchasePrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} cannot be negative.");
                }
                SeedPurchasePrice = value;
            }

        }
        private Texture2D Texture
        {
            get; set;
        }

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
