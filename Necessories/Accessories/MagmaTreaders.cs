using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Necessories.Accessories
{
	public class MagmaTreaders : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Magma Treaders");
            Tooltip.SetDefault("Everything the Frostspark Boots and Lava Waders can do");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 200000;
            item.rare = 7;
            item.accessory = true;
        }

    public override bool CanEquipAccessory(Player player, int slot)
    {
        for (int i = 3; i < 8 + player.extraAccessorySlots; i++)
        {
            if (player.armor[i].type == ItemID.FrostsparkBoots)
            {
               return false;
            }
        }

        for (int i = 13; i < 18 + player.extraAccessorySlots; i++)
        {
            if (player.armor[i].type == ItemID.FrostsparkBoots)
            {
                return false;
            }
        }
        return true;
        for (int i = 3; i < 8 + player.extraAccessorySlots; i++)
        {
            if (player.armor[i].type == ItemID.HermesBoots)
            {
               return false;
            }
        }

        for (int i = 13; i < 18 + player.extraAccessorySlots; i++)
        {
            if (player.armor[i].type == ItemID.HermesBoots)
            {
                return false;
            }
        }
        return true;
        for (int i = 3; i < 8 + player.extraAccessorySlots; i++)
        {
            if (player.armor[i].type == ItemID.SpectreBoots)
            {
               return false;
            }
        }

        for (int i = 13; i < 18 + player.extraAccessorySlots; i++)
        {
            if (player.armor[i].type == ItemID.SpectreBoots)
            {
                return false;
            }
        }
        return true;
    }

	public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.waterWalk = true;
            player.fireWalk = true;
            player.canRocket = true;
            player.rocketBoots = 2;
            player.rocketTimeMax = 10;
            player.lavaImmune = true;
            player.iceSkate = true;
            player.moveSpeed += 1f;
            player.GetModPlayer<SpeedChangePlayer>().increaseSpeed = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.FrostsparkBoots, 1);
			recipe.AddIngredient(ItemID.LavaWaders, 1);
			recipe.AddIngredient(ItemID.SoulofMight, 5);
			recipe.AddIngredient(ItemID.SoulofSight, 5);
			recipe.AddIngredient(ItemID.SoulofFright, 5);
            recipe.AddTile(TileID.MythrilAnvil);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}