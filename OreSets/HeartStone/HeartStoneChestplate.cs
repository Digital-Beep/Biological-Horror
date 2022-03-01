
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

namespace Heartpoint.OreSets.HeartStone
{
    [AutoloadEquip(EquipType.Body)]
    public class HeartStoneChestplate : ModItem
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
            Tooltip.SetDefault("Boosts melee damage by 10%");
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeDamage += 0.1f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("HeartStoneBar"), 20);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}