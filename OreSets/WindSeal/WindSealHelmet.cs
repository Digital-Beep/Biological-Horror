
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

namespace Heartpoint.OreSets.WindSeal
{
    [AutoloadEquip(EquipType.Head)]
    public class WindSealHelmet : ModItem
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
            Tooltip.SetDefault("Boosts ranged damage multiplyer by 2%");
        }
        public override void UpdateEquip(Player player)
        {
            player.rangedDamageMult += 0.02f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("WindSealBar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }

        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<WindSealChestplate>() && legs.type == ItemType<WindSealLeggings>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.noFallDmg = true;
            player.rangedDamage += 0.1f;
            player.setBonus = "Due To INSANE Wind power your shots strike 10% more damage and grant you the ability to not break your legs";
        }
    }
}