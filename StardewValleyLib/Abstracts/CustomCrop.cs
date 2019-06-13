using System;
using StardewValley;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace StardewValleyLib.Abstracts
{

    public class CustomCrop : Crop
    {
        public String Name 
        {
            get; set;
        }
        public int Price
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
        public String SeedName
        {
            get; set;
        }
        public CropType Type
        {
            get; set;
        }
        public Season GrowthSeason
        {
            get; set;
        }
        public int Phases
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
        public int RegrowthPhase
        {
            get; set;
        }
        public bool CanHarvestWithScythe
        {
            get; set;
        }
        public bool IsTrellisCrop
        {
            get; set;
        }
        public int Bonus
        {
            get; set;
        }
        public int MinHarvest
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
        public int MaxHarvest
        {
            get; set;
        }
        public int FarmSkillExp
        {
            get; set;
        }
        public double ExtraChance
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
        public int SeedPurchasePrice
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
        public Texture2D Texture
        {
            get; set;
        }

        private int CropPrice;
        private int AmountOfGrowthCycles;
        private int MinAmountOfCropsOnHarvest;
        private double extraChance;
        private int SeedPrice;

        public CustomCrop(string Name, int Price, string SeedName, CropType Type,
             Season GrowthSeason, int Phases, int RegrowthPhases, bool CanHarvestWithScythe, bool IsTrellisCrop,
             int MinHarvest, int MaxHarvest, int FarmSkillExp, double ExtraChance, int SeedPurchasePrice, Texture2D Texture)
            : base()
        {
            this.Name = Name;
            this.Price = Price;
            this.SeedName = SeedName;
            this.Type = Type;
            this.GrowthSeason = GrowthSeason;
            this.Phases = Phases;
            this.RegrowthPhase = RegrowthPhases;
            this.CanHarvestWithScythe = CanHarvestWithScythe;
            this.IsTrellisCrop = IsTrellisCrop;
            this.MinHarvest = MinHarvest;
            this.MaxHarvest = MaxHarvest;
            this.FarmSkillExp = FarmSkillExp;
            this.ExtraChance = ExtraChance;
            this.SeedPurchasePrice = SeedPurchasePrice;
            this.Texture = Texture;
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
