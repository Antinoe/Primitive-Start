using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimitiveStart.Items.Tools
{
	public class StoneAxe : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Stone Axe");
			//Tooltip.SetDefault("Bare Hands: Break Blocks.");
		}

		public override void SetDefaults() 
		{
			Item.damage = PrimitiveStartConfig.Instance.toolsStoneAxeDamage;
			Item.width = 32;
			Item.height = 32;
			Item.useTime = PrimitiveStartConfig.Instance.toolsStoneAxeUseTime;
			Item.useAnimation = PrimitiveStartConfig.Instance.toolsStoneAxeUseTime;
			Item.useStyle = 1;
			Item.knockBack = 5;
			Item.value = 100;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.axe = PrimitiveStartConfig.Instance.toolsStoneAxeMineSpeed;
			Item.DamageType = DamageClass.Melee; //This is what allows Reforging to work on this item.
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 3)
            .AddIngredient(3,9) //Stone
            .Register();
		}
	}
}