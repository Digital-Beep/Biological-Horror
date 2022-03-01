using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.OreSets.WindSeal
{
    public class WindSealBar : ModItem
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
            recipe.AddIngredient(ItemID.SunplateBlock, 3);
            recipe.AddIngredient(ItemID.Cloud, 2);
            recipe.AddIngredient(ItemID.RainCloud, 1);
            recipe.AddTile(TileID.SkyMill);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
