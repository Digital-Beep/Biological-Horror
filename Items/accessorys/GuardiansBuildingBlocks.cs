using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Heartpoint.Items.accessorys
{
    public class GuardiansBuildingBlocks : ModItem
    {
        public override void SetStaticDefaults()
        {
            // DisplayName.SetDefault("AquaBolt"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
            Tooltip.SetDefault("Get the point get it increaseses melee damage by 22% and melee speed by 15% but cuts your run speed by 25%");
        }

        public override void SetDefaults()
        {
            item.width = 10;
            item.height = 14;
            item.value = 10;
            item.rare = 12;
            item.accessory = true;
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            

            player.meleeDamage += 0.22f;
            player.meleeSpeed += 0.15f;
            player.accRunSpeed -= -0.25f;
            player.maxRunSpeed -= -0.25f;
        }
    }
}