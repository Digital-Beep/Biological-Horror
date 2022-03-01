using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.OreSets.HeartStone
{
	public class HeartStoneSword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("HeartStoneSword"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("Weilding This Shows That You Have a big Heart");
		}

		public override void SetDefaults() 
		{
			item.damage = 30;
			item.melee = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 9;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 2;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;
			item.melee = true;
			item.lifeRegen = 9;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.IronBar, 10);
			recipe.AddIngredient(ItemID.LifeCrystal, 1);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}