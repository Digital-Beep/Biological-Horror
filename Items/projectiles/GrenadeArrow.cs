using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.ModLoader.UI.ModBrowser;
using static Terraria.ModLoader.ModContent;

namespace heartpoint.Items.projectiles
{
    public class GrenadeArrow : ModItem
    {
        public override void SetDefaults()
        {
            item.Size = new Vector2(8);
            item.value = Item.buyPrice(silver: 50);
            item.rare = ItemRarityID.Blue;

            item.consumable = true;
            item.maxStack = 999;

            item.ranged = true;
            item.damage = 10;
            item.knockBack = 15f;
            item.UseSound = SoundID.Item13;
            item.shoot = ProjectileType<Heartpoint.Items.projectiles.GrenadeArrow>();
            item.shootSpeed = 6f;
            item.ammo = AmmoID.Arrow;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Grenade, 1);
            recipe.AddIngredient(ItemID.WoodenArrow, 5);
            recipe.AddTile(TileID.WorkBenches);
            recipe.SetResult(this, 5);
            recipe.AddRecipe();
        }
    }
}