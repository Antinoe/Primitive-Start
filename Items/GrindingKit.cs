using System;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.ID;

namespace PrimitiveStart.Items
{
	public class GrindingKit : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Grinding Kit");
			Tooltip.SetDefault("Right Click to strike these rocks together for Stone Shards.");
		}

		public override void SetDefaults()
		{
			Item.width = 28;
			Item.height = 18;
			Item.maxStack = 30;
			Item.rare = 0;
			Item.value = 10;
		}

		/*public override void AddRecipes()
        {
			CreateRecipe(1)
            .AddIngredient(ItemID.StoneBlock, 3)
            .Register();
        }*/
	}
}
