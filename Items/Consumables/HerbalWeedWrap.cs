using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Microsoft.Xna.Framework;

namespace PrimitiveStart.Items.Consumables
{
	public class HerbalWeedWrap : ModItem
	{
        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("A fine wrap of lightweight nutrients.");
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;
			Item.scale = 1f;
			Item.useStyle = 2;
            Item.useAnimation = 15;
            Item.useTime = 15;
            Item.useTurn = true;
            Item.UseSound = SoundID.Item2;
            Item.maxStack = 30;
            Item.consumable = true;
            Item.rare = 0;
            Item.value = 50;
			Item.buffType = BuffID.HeartyMeal;
			Item.buffTime = PrimitiveStartConfig.Instance.consumablesHerbalWeedWrapHealDuration; //Grant the Hearty Meal buff. 3600 is 1 minute. 600 is 10 seconds.
			Item.healLife = PrimitiveStartConfig.Instance.consumablesHerbalWeedWrapHealAmount;
        }
		
        //public override bool CanUseItem(Item Item, Player Player)
		//public virtual bool ConsumeItem(Player Player)
		/*public bool ConsumeItem(int type, bool reverseOrder = false)
        {
			Player.AddBuff(2, 240);
			Player.AddBuff(3, 1200);
			return true;
		}*/
		
		public override void AddRecipes()
		{
			CreateRecipe(1)
			.AddIngredient(ItemID.Hay, PrimitiveStartConfig.Instance.consumablesHerbalWeedWrapCraftCost)
			.AddRecipeGroup("PrimitiveStart:Herbs", 1)
            .Register();
		}
    }
}