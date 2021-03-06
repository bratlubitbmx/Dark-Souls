using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace DarkSouls.Projectiles
{
	public class IcestormIcicle1 : ModProjectile
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Ice shard");

        }
		public override void SetDefaults()
		{
			projectile.width = 42;
			projectile.height = 84;
			projectile.penetrate = 16;
			projectile.knockBack = 9;
			projectile.timeLeft = 400;
			projectile.alpha = 100;
			projectile.light = 1f;
			projectile.friendly = false;
			projectile.hostile = true;
			projectile.magic = true;
			projectile.ignoreWater = true;
			projectile.tileCollide = false;
		}
	}
}