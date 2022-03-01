
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

namespace Heartpoint.OreSets.HeartStone
{
    [AutoloadEquip(EquipType.Head)]
    public class HeartStoneHelmet : ModItem
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
            Tooltip.SetDefault("Boosts melee damage multiplyer by 2%");
        }
        public override void UpdateEquip(Player player)
        {
            player.meleeDamageMult += 0.02f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("HeartStoneBar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<HeartStoneChestplate>() && legs.type == ItemType<HeartStoneGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.statLifeMax2 += 80;
            player.meleeDamage += 0.18f;
            player.meleeSpeed += 0.25f;
            player.setBonus = "Increased melee damage by 18% and and 25% increased melee speed and max health is increased by 80";
        }
    }
}