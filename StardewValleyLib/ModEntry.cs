using System;
using Microsoft.Xna.Framework;
using StardewModdingAPI;
using StardewModdingAPI.Events;
using StardewModdingAPI.Utilities;
using StardewValleyLib.Items;
using StardewValley;

namespace StardewValleyLib
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            helper.Events.Input.ButtonPressed += this.OnButtonPressed;
        }

        private void OnButtonPressed(object sender, ButtonPressedEventArgs e)
        {
            // ignore if player hasn't loaded a save yet
            if (!Context.IsWorldReady)
                return;
            this.Monitor.Log($"{e.Button}");
            Vector2 tile = Game1.currentCursorTile;
            tile = Utility.tileWithinRadiusOfPlayer((int)tile.X, (int)tile.Y, 1, Game1.player)
                ? tile
                : Game1.player.GetGrabTile();
            this.Monitor.Log(tile.ToString());
            Game1.getLocationFromName("Farm").dropObject(new TestItem(), tile, Game1.viewport, true, (Farmer)null);
        }
 
    }
}
