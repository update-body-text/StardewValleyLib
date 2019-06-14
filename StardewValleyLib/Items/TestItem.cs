using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using StardewValley;
using StardewValley.Tools;
using StardewValleyLib.Crops;
using StardewValleyLib.Abstracts;

namespace StardewValleyLib.Items
{
    public class TestItem : CustomSeed
    {
        public TestItem()
        {
        
        }

        public override int sellToStorePrice()
        {
            return 0;
        }


        public override bool performToolAction(Tool t, GameLocation location)
        {
            PlantSeed(new TestCrop());
            return true;
        }

      
    }
}
