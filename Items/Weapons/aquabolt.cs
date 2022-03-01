using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.Items.Weapons
{
	public class Aquabolt : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("AquaBolt"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("This is the waterbolts older sister.");
		}

		public override void SetDefaults() 
		{
			item.damage = 60;
			item.magic = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 10;
			item.useAnimation = 20;
			item.useStyle = 5;
			item.knockBack = 6;
			item.value = 100000;
			item.rare = 2;
			item.UseSound = SoundID.Item20;
            item.autoReuse = true;
            item.shoot = ProjectileID.WaterBolt;
            item.shootSpeed = 10f;
			item.mana = 0;
		}

		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.WaterBolt, 1);
            recipe.AddIngredient(ItemID.SpaceGun, 1);
			recipe.AddIngredient(ItemID.DemonScythe, 1);
			recipe.AddIngredient(ItemID.BeeGun, 1);
			recipe.AddIngredient(ItemID.AquaScepter, 1);
			recipe.AddTile(TileID.DemonAltar);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}