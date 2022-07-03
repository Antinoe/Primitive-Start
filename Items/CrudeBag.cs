using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using PrimitiveStart.Items;
using PrimitiveStart.Items.Weapons;
using PrimitiveStart.Items.Tools;
using PrimitiveStart.Items.Consumables;

namespace PrimitiveStart.Items
{
	public class CrudeBag : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Crude Bag");
			Tooltip.SetDefault("{$CommonItemTooltip.RightClickToOpen}");
		}

		public override void SetDefaults()
		{
			Item.maxStack = 999;
			Item.consumable = true;
			Item.width = 24;
			Item.height = 24;
		}

		public override bool CanRightClick()
		{
			return true;
		}

		public override void RightClick(Player Player)
		{
			var source = Player.GetSource_OpenItem(Type);
			
			if (PrimitiveStartConfig.Instance.giveWoodenStake)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<WoodenStake>(), 1);
			}
			if (PrimitiveStartConfig.Instance.giveWoodenClub)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<WoodenClub>(), 1);
			}
			if (PrimitiveStartConfig.Instance.giveStoneAxe)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<StoneAxe>(), 1);
			}
			if (PrimitiveStartConfig.Instance.giveStonePickaxe)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<StonePickaxe>(), 1);
			}
			if (PrimitiveStartConfig.Instance.giveWeedWrap > 0)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<WeedWrap>(), PrimitiveStartConfig.Instance.giveWeedWrap);
			}
			if (PrimitiveStartConfig.Instance.giveHerbalWeedWrap > 0)
			{
				Player.QuickSpawnItem(source, ModContent.ItemType<HerbalWeedWrap>(), PrimitiveStartConfig.Instance.giveHerbalWeedWrap);
			}
		}
	}
}