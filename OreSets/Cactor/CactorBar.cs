using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.OreSets.Cactor
{
    public class CactorBar : ModItem
    {
        public override void SetStaticDefaults()
        {
        Tooltip.SetDefault("Its The Hardest Sand");
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
            recipe.AddIngredient(ItemID.SandBlock, 15);
            recipe.AddIngredient(ItemID.HardenedSand, 10);
            recipe.AddIngredient(ItemID.AntlionMandible, 1);
            recipe.AddIngredient(ItemID.Cactus, 5);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
