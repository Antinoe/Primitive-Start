using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace PrimitiveStart
{
	public class PrimitiveStartRecipeGroups : ModSystem
	{
		public override void AddRecipeGroups()
		{
		//Herbs
			RecipeGroup group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Herb", new int[]
			{
				ItemID.Blinkroot,
				ItemID.Daybloom,
				ItemID.Deathweed,
				ItemID.Fireblossom,
				ItemID.Moonglow,
				ItemID.Shiverthorn,
				ItemID.Waterleaf
			});
			RecipeGroup.RegisterGroup("PrimitiveStart:Herbs", group);
			
		//Potent Herbs
			group = new RecipeGroup(() => Language.GetTextValue("LegacyMisc.37") + " Potent Herbs", new int[]
			{
				ItemID.TealMushroom,
				ItemID.YellowMarigold,
				ItemID.PinkPricklyPear,
				ItemID.GreenMushroom,
				ItemID.BlueBerries,
				ItemID.OrangeBloodroot,
				ItemID.SkyBlueFlower,
				ItemID.LimeKelp
			});
			RecipeGroup.RegisterGroup("PrimitiveStart:HerbsPotent", group);
			
		}
	}
}