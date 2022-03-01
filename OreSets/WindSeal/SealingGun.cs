using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.OreSets.WindSeal
{
	public class SealingGun : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("GunOfGods"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The power of wind is on your side");
		}

		public override void SetDefaults() 
		{
			item.damage = 20;
			item.ranged = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 25;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item10;
            item.autoReuse = true;
			item.useAmmo = AmmoID.Bullet;
			item.shoot = ProjectileID.Bullet;
			item.shootSpeed = 5f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("WindSealBar"), 20);
			recipe.AddTile(TileID.SkyMill);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}