using System;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace Necessories.Accessories
{
	public class RestorationBand : ModItem
	{
		public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Band of Restoration");
            Tooltip.SetDefault("Increases maximum mana by 20 \nIncreases mana and life regeneration rate");
        }
        public override void SetDefaults()
        {
            item.width = 28;
            item.height = 20;
            item.value = 200000;
            item.rare = 3;
            item.accessory = true;
            item.lifeRegen = 1;
            item.defense = 1;

        }

	public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statManaMax2 += 20;
            player.manaRegenDelayBonus++;
            player.manaRegenBonus += 25;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.BandofRegeneration, 1);
			recipe.AddIngredient(ItemID.ManaRegenerationBand, 1);
			recipe.AddIngredient(ItemID.Shackle, 1);
            recipe.AddTile(TileID.Anvils);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
	}
}