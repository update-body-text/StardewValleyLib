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

        public new void draw(SpriteBatch b, Vector2 tileLocation, Color toTint, float rotation)
        {
            if ((bool)forageCrop)
            {
                b.Draw(Game1.mouseCursors, Game1.GlobalToLocal(Game1.viewport, new Vector2(tileLocation.X * 64f + ((tileLocation.X * 11f + tileLocation.Y * 7f) % 10f - 5f) + 32f, tileLocation.Y * 64f + ((tileLocation.Y * 11f + tileLocation.X * 7f) % 10f - 5f) + 32f)), new Rectangle((int)(tileLocation.X * 51f + tileLocation.Y * 77f) % 3 * 16, 128 + (int)whichForageCrop * 16, 16, 16), Color.White, 0f, new Vector2(8f, 8f), 4f, SpriteEffects.None, (tileLocation.Y * 64f + 32f + ((tileLocation.Y * 11f + tileLocation.X * 7f) % 10f - 5f)) / 10000f);
            }
            else
            {
                b.Draw(this.Texture, Game1.GlobalToLocal(Game1.viewport, new Vector2(tileLocation.X * 64f + (((bool)raisedSeeds || (int)currentPhase >= phaseDays.Count - 1) ? 0f : ((tileLocation.X * 11f + tileLocation.Y * 7f) % 10f - 5f)) + 32f, tileLocation.Y * 64f + (((bool)raisedSeeds || (int)currentPhase >= phaseDays.Count - 1) ? 0f : ((tileLocation.Y * 11f + tileLocation.X * 7f) % 10f - 5f)) + 32f)), getSourceRect((int)tileLocation.X * 7 + (int)tileLocation.Y * 11), toTint, rotation, new Vector2(8f, 24f), 4f, ((bool)flip) ? SpriteEffects.FlipHorizontally : SpriteEffects.None, (tileLocation.Y * 64f + 32f + (((bool)raisedSeeds || (int)currentPhase >= phaseDays.Count - 1) ? 0f : ((tileLocation.Y * 11f + tileLocation.X * 7f) % 10f - 5f))) / 10000f / (((int)currentPhase == 0 && !(bool)raisedSeeds) ? 2f : 1f));
                if (!tintColor.Equals(Color.White) && (int)currentPhase == phaseDays.Count - 1 && !(bool)dead)
                {
                    b.Draw(this.Texture, Game1.GlobalToLocal(Game1.viewport, new Vector2(tileLocation.X * 64f + (((bool)raisedSeeds || (int)currentPhase >= phaseDays.Count - 1) ? 0f : ((tileLocation.X * 11f + tileLocation.Y * 7f) % 10f - 5f)) + 32f, tileLocation.Y * 64f + (((bool)raisedSeeds || (int)currentPhase >= phaseDays.Count - 1) ? 0f : ((tileLocation.Y * 11f + tileLocation.X * 7f) % 10f - 5f)) + 32f)), new Rectangle(((!(bool)fullyGrown) ? ((int)currentPhase + 1 + 1) : (((int)dayOfCurrentPhase <= 0) ? 6 : 7)) * 16 + (((int)rowInSpriteSheet % 2 != 0) ? 128 : 0), (int)rowInSpriteSheet / 2 * 16 * 2, 16, 32), tintColor, rotation, new Vector2(8f, 24f), 4f, ((bool)flip) ? SpriteEffects.FlipHorizontally : SpriteEffects.None, (tileLocation.Y * 64f + 32f + ((tileLocation.Y * 11f + tileLocation.X * 7f) % 10f - 5f)) / 10000f / (float)(((int)currentPhase != 0 || (bool)raisedSeeds) ? 1 : 2));
                }
            }
        }

        public new void drawInMenu(SpriteBatch b, Vector2 screenPosition, Color toTint, float rotation, float scale, float layerDepth)
        {
            b.Draw(this.Texture, screenPosition, getSourceRect(0), toTint, rotation, new Vector2(32f, 96f), scale, ((bool)flip) ? SpriteEffects.FlipHorizontally : SpriteEffects.None, layerDepth);
        }

        public new void drawWithOffset(SpriteBatch b, Vector2 tileLocation, Color toTint, float rotation, Vector2 offset)
        {
            if ((bool)forageCrop)
            {
                b.Draw(Game1.mouseCursors, Game1.GlobalToLocal(Game1.viewport, offset + new Vector2(tileLocation.X * 64f, tileLocation.Y * 64f)), new Rectangle((int)(tileLocation.X * 51f + tileLocation.Y * 77f) % 3 * 16, 128 + (int)whichForageCrop * 16, 16, 16), Color.White, 0f, new Vector2(8f, 8f), 4f, SpriteEffects.None, (tileLocation.Y + 0.66f) * 64f / 10000f + tileLocation.X * 1E-05f);
            }
            else
            {
                b.Draw(this.Texture, Game1.GlobalToLocal(Game1.viewport, offset + new Vector2(tileLocation.X * 64f, tileLocation.Y * 64f)), getSourceRect((int)tileLocation.X * 7 + (int)tileLocation.Y * 11), toTint, rotation, new Vector2(8f, 24f), 4f, ((bool)flip) ? SpriteEffects.FlipHorizontally : SpriteEffects.None, (tileLocation.Y + 0.66f) * 64f / 10000f + tileLocation.X * 1E-05f);
                if (!tintColor.Equals(Color.White) && (int)currentPhase == phaseDays.Count - 1 && !(bool)dead)
                {
                    b.Draw(this.Texture, Game1.GlobalToLocal(Game1.viewport, offset + new Vector2(tileLocation.X * 64f, tileLocation.Y * 64f)), new Rectangle(((!(bool)fullyGrown) ? ((int)currentPhase + 1 + 1) : (((int)dayOfCurrentPhase <= 0) ? 6 : 7)) * 16 + (((int)rowInSpriteSheet % 2 != 0) ? 128 : 0), (int)rowInSpriteSheet / 2 * 16 * 2, 16, 32), tintColor, rotation, new Vector2(8f, 24f), 4f, ((bool)flip) ? SpriteEffects.FlipHorizontally : SpriteEffects.None, (tileLocation.Y + 0.67f) * 64f / 10000f + tileLocation.X * 1E-05f);
                }
            }
        }

        private Rectangle getSourceRect(int number)
        {
            if ((bool)dead)
            {
                return new Rectangle(192 + number % 4 * 16, 384, 16, 32);
            }
            return new Rectangle(Math.Min(240, ((!(bool)fullyGrown) ? ((int)(((int)phaseToShow != -1) ? phaseToShow : currentPhase) + (((int)(((int)phaseToShow != -1) ? phaseToShow : currentPhase) == 0 && number % 2 == 0) ? (-1) : 0) + 1) : (((int)dayOfCurrentPhase <= 0) ? 6 : 7)) * 16 + (((int)rowInSpriteSheet % 2 != 0) ? 128 : 0)), (int)rowInSpriteSheet / 2 * 16 * 2, 16, 32);
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
