using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimitiveStart.Items.Tools
{
	public class StonePickaxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Stone Pickaxe");
			//Tooltip.SetDefault("A rudimentary Pickaxe.");
		}

		public override void SetDefaults() 
		{
			Item.damage = PrimitiveStartConfig.Instance.toolsStonePickaxeDamage;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = PrimitiveStartConfig.Instance.toolsStonePickaxeUseTime;
			Item.useAnimation = PrimitiveStartConfig.Instance.toolsStonePickaxeUseTime;
			Item.useStyle = 1;
			Item.knockBack = 3;
			Item.value = 100;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.pick = PrimitiveStartConfig.Instance.toolsStonePickaxeMineSpeed;
			Item.DamageType = DamageClass.Melee; //This is what allows Reforging to work on this item.
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 3)
            .AddIngredient(3,12) //Stone
            .Register();
		}
	}
}