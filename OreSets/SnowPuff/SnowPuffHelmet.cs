
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

namespace Heartpoint.OreSets.SnowPuff
{
    [AutoloadEquip(EquipType.Head)]
    public class SnowPuffHelmet : ModItem
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
            Tooltip.SetDefault("Boosts ranged damage multiplyer by 5%");
        }
        public override void UpdateEquip(Player player)
        {
            player.magicDamageMult += 0.05f;
        }
        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(mod.GetItem("SnowPuffBar"), 10);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
        
        public override bool IsArmorSet(Item head, Item body, Item legs)
        {
            return body.type == ItemType<SnowPuffChestplate>() && legs.type == ItemType<SnowPuffGreaves>();
        }

        public override void UpdateArmorSet(Player player)
        {
            player.runAcceleration += 1;
            player.maxRunSpeed += 2f;
            player.magicDamage += 0.1f;
            player.setBonus = "Because of your cold armor your legs are burning up trying not to freeze and make you run 2X FASTER and your magic damage is increased by 10%";
        }
    }
}