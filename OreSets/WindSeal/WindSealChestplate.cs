
using Terraria;
using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria.ModLoader;
using Terraria.ID;
using static Terraria.ModLoader.ModContent;

namespace Heartpoint.OreSets.WindSeal
{
    [AutoloadEquip(EquipType.Body)]
    public class WindSealChestplate : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 24);
            item.rare = ItemRarityID.Blue;
            item.defense = 7;
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Boosts ranged damage by 10%");
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamage += 0.10f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("WindSealBar"), 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}