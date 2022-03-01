using Terraria.ID;
using Terraria.ModLoader;
using Terraria;

namespace natureMod.Items.Weapons
{
	public class TinLongsword : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("TinLongsword"); // By default, capitalizati on in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("When below 50% HP You get +4 Dmg");
			DisplayName.SetDefault("Tin Longsword");
		}

		public override void SetDefaults() 
		{
			item.width = 40;
			item.height = 40;

			item.useStyle = ItemUseStyleID.SwingThrow;
			item.useTime = 20;
		    item.useAnimation = 20;
			item.UseSound = SoundID.Item1;

			item.melee = true;

				item.damage = 7;
			item.knockBack = 4.5f;
		}
		public override void ModifyWeaponDamage(Player player, ref float add, ref float mult, ref float flat)
		{
			if (player.statLife < player.statLifeMax2 * 0.5f)
            {
				item.damage = 11;
            }
			if (player.statLife > player.statLifeMax2 * 0.5f)
			{
				item.damage = 7;
			}
		}
		public override void AddRecipes() 
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.TinBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}