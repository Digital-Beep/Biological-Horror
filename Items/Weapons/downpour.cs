using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.Items.Weapons
{
	public class Downpour : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("DownPour"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is Forged with rotting corruption.");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.magic = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 50;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item42;
            item.autoReuse = true;
            item.shoot = ProjectileID.SapphireBolt;
            item.shootSpeed = 1f;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.DemoniteBar, 15);
			recipe.AddIngredient(ItemID.Book, 5);
			recipe.AddTile(TileID.Bookcases);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}