
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
using Heartpoint.OreSets.HeartStone;

namespace Heartpoint.OreSets.Cactor
{
    [AutoloadEquip(EquipType.Head)]
    public class CactorMask : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(18);
            item.value = Item.sellPrice(silver: 26);
            item.rare = ItemRarityID.Blue;
            item.defense = 6;
        }
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("Boosts minion damage by 10%");
        }
        public override void UpdateEquip(Player player)
        {
            player.minionDamage += 0.1f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("CactorBar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<CactorChainmail>() && legs.type == ItemType<CactorGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.maxMinions += 1;
            player.minionKB += 0.05f;
            player.meleeSpeed += 0.25f;
            player.setBonus = "Increased minion knockback by 5% and max minions by 1";
        }
    }
}