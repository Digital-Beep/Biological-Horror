using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace heartpoint.Items.projectiles.minions
{
    public class CactiSpy : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 1;
            Main.projPet[projectile.type] = true;
            ProjectileID.Sets.MinionSacrificable[projectile.type] = true;
            ProjectileID.Sets.Homing[projectile.type] = true;
            ProjectileID.Sets.MinionTargettingFeature[projectile.type] = true;
        }

        public override void SetDefaults()
        {
            projectile.damage = 10;
            projectile.width = 80;
            projectile.height = 76;
            projectile.penetrate = -1;
            projectile.minionSlots = 1f;
            projectile.minion = true;
            projectile.tileCollide = true;
            projectile.friendly = true;
            projectile.aiStyle = 9;
            projectile.knockBack = 0;
        }

    }
}
