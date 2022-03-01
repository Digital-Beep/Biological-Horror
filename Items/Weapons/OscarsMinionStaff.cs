using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.Items.Weapons
{
	public class OscarsMinionStaff : ModItem
	{
		public override void SetStaticDefaults() 
		{
			// DisplayName.SetDefault("VoidsEdge"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
			Tooltip.SetDefault("It pulses With Anger towards you");
		}

		public override void SetDefaults() 
		{
			item.damage = 45;
			item.summon = true;
			item.width = 70;
			item.height = 70;
			item.useTime = 9;
			item.useAnimation = 20;
			item.useStyle = 1;
			item.knockBack = 6;
			item.value = 10000;
			item.rare = 12;
			item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.mana = 5;
			item.shoot = mod.ProjectileType("OscarsMinionproj");
            item.shootSpeed = 10f;
		}

		public override void AddRecipes() 
		{
		}
	}
}