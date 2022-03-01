using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.OreSets.SnowPuff
{
    public class SnowPuffBar : ModItem
    {
        public override void SetStaticDefaults()
        {
        Tooltip.SetDefault("You feel a large breeze passing by");
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
            recipe.AddIngredient(ItemID.SnowBlock, 5);
            recipe.AddIngredient(ItemID.BorealWood, 3);
            recipe.AddIngredient(ItemID.IceBlock, 3);
            recipe.AddTile(TileID.IceMachine);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
