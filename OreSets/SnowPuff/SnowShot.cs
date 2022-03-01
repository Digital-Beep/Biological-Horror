using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.OreSets.SnowPuff
{
	public class SnowShot : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("AquaBolt"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Snowing rain of snowballs");
		}

		public override void SetDefaults() 
		{
			item.damage = 10;
			item.magic = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = -12;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.shoot = ProjectileID.SnowBallFriendly;
            item.shootSpeed = 10f;
			item.mana = 0;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(mod.GetItem("SnowPuffBar"), 20);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}