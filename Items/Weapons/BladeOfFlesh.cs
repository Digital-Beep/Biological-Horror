using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.Items.Weapons
{
	public class BladeOfFlesh : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("BladeOfFlesh"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("The Flesh of the underworld Shoots Stationary Enchanted Beam ");
		}

		public override void SetDefaults() 
		{
			item.damage = 65;
			item.melee = true;
			item.width = 200;
			item.height = 200;
			item.useTime = 20;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 3;
			item.value = 100000;
			item.rare = 3;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;
			item.melee = true;
			item.shoot = ProjectileID.EnchantedBeam;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.WarAxeoftheNight, 1);
			recipe.AddIngredient(ItemID.EnchantedSword, 1);
			recipe.AddIngredient(ItemID.Swordfish, 1);
			recipe.AddIngredient(ItemID.BoneSword, 1);
			recipe.AddIngredient(ItemID.HellstoneBar, 10);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}