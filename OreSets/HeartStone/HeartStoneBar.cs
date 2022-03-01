using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.OreSets.HeartStone
{
    public class HeartStoneBar : ModItem
    {
        public override void SetStaticDefaults()
        {
        Tooltip.SetDefault("You can hear it pulsing");
        }

        public override void SetDefaults()
        {
            item.material = true;
            item.width = 30;
            item.height = 24;
            item.maxStack = 999;
            item.value = Item.sellPrice(silver: 50);
        }
                public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.IronBar, 30);
            recipe.AddIngredient(ItemID.LifeCrystal, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this ,30);
            recipe.AddRecipe();
        }
    }
}
