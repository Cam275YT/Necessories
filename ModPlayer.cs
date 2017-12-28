using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Necessories
{
    public class SpeedChangePlayer : ModPlayer
    {
        public bool increaseSpeed = false;
        public bool increaseSpeed2 = false;

        public override void ResetEffects()
        {
            increaseSpeed = false;
            increaseSpeed2 = false;
        }

        public override void UpdateDead()
        {
            increaseSpeed = false;
            increaseSpeed2 = false;
        }

        public override void PostUpdateMiscEffects()
        {
            if (increaseSpeed)
                player.maxRunSpeed += 1f;
            
            if (increaseSpeed2)
                player.maxRunSpeed += 3f;
        }
    }
}