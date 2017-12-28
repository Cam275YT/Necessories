using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Necessories.Accessories
{
	public class GalacticSprinters : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Galactic Sprinters");
            Tooltip.SetDefault("Ultimate speed! \nEverything the Magma Treaders can do \nTotal immunity to lava");
        }
        public override void SetDefaults()
        {
            item.width = 32;
            item.height = 32;
            item.value = 200000;
            item.expert = true;
            item.accessory = true;
            item.defense = 8;
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
            player.rocketTimeMax = 16;
            player.lavaImmune = true;
            player.iceSkate = true;
            player.moveSpeed += 3f;
            player.GetModPlayer<SpeedChangePlayer>().increaseSpeed2 = true;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(null, "MagmaTreaders", 1);
			recipe.AddIngredient(ItemID.FragmentNebula, 5);
			recipe.AddIngredient(ItemID.FragmentVortex, 5);
			recipe.AddIngredient(ItemID.FragmentStardust, 5);
			recipe.AddIngredient(ItemID.FragmentSolar, 5);
            recipe.AddTile(TileID.LunarCraftingStation);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}