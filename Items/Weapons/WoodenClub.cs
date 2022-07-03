using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimitiveStart.Items.Weapons
{
	public class WoodenClub : ModItem
	{
		public override void SetStaticDefaults() 
		{
			DisplayName.SetDefault("Wooden Club");
		}

		public override void SetDefaults() 
		{
			Item.damage = PrimitiveStartConfig.Instance.weaponsWoodenClubDamage;
			Item.width = 36;
			Item.height = 34;
			Item.scale = 1f;
			Item.useTime = PrimitiveStartConfig.Instance.weaponsWoodenClubUseTime;
			Item.useAnimation = PrimitiveStartConfig.Instance.weaponsWoodenClubUseTime;
			Item.useStyle = 1;
			Item.knockBack = PrimitiveStartConfig.Instance.weaponsWoodenClubKnockback;
			Item.value = 200;
			Item.rare = 0;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = false;
			Item.DamageType = DamageClass.Melee; //This is what allows Reforging to work on this item.
		}

		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddRecipeGroup(RecipeGroupID.Wood, 11)
            .Register();
		}
	}
}