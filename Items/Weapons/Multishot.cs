using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.Items.Weapons
{
	public class  MultiShot : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("MultiShot"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("bow to take down armys");
		}

		public override void SetDefaults() 
		{
			item.damage = 35;
			item.ranged = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 3;
			item.UseSound = SoundID.Item5;
            item.autoReuse = true;
			item.useAmmo = AmmoID.Arrow;
			item.shoot = ProjectileID.JestersArrow;
            item.shootSpeed = 9f;

		}

        public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BeesKnees, 1);
			recipe.AddIngredient(ItemID.MoltenFury, 1);
			recipe.AddIngredient(ItemID.CopperBow, 1);
			recipe.AddIngredient(ItemID.MeteoriteBar, 20);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}