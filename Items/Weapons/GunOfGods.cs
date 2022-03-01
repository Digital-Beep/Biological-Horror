using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.Items.Weapons
{
	public class GunOfGods: ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("GunOfGods"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is a gods true weapon");
		}

		public override void SetDefaults() 
		{
			item.damage = 5;
			item.ranged = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 1;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 3;
			item.UseSound = SoundID.Item10;
            item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = ProjectileID.Bullet;

			item.shootSpeed = 10f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.Minishark, 1);
			recipe.AddIngredient(ItemID.Musket, 1);
            recipe.AddIngredient(ItemID.Boomstick, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 15);

			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}