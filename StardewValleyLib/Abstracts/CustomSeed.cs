using System;
using StardewValley;
using StardewValley.Tools;
using StardewValley.TerrainFeatures;
using Microsoft.Xna.Framework;

namespace StardewValleyLib.Abstracts
{
    public abstract class CustomSeed : StardewValley.Object
    {
        public CustomSeed()
        {
        }

        public virtual void PlantSeed(Crop crop)
        {
            Vector2 tile = Game1.currentCursorTile;
            tile = Utility.tileWithinRadiusOfPlayer((int)tile.X, (int)tile.Y, 1, Game1.player)
                ? tile
                : Game1.player.GetGrabTile();
            if (!Game1.currentLocation.terrainFeatures.TryGetValue(tile, out TerrainFeature tf) || tf is HoeDirt)
            {
                HoeDirt dirt = (HoeDirt)tf;
                dirt.crop = crop;
            }
        }
    }
}
