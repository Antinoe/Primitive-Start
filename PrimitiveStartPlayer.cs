using System;
using System.Collections.Generic;
using PrimitiveStart.Items;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace PrimitiveStart
{
	public class PrimitiveStartPlayer : ModPlayer
	{
		//Remove Vanilla's starting Items.
		public override void ModifyStartingInventory(IReadOnlyDictionary<string, List<Item>> ItemsByMod, bool mediumCoreDeath)
		{
			if (!PrimitiveStartConfig.Instance.giveCopperSet)
			{
				ItemsByMod["Terraria"].RemoveAll((Item Item) => Item.type == 3506);
				ItemsByMod["Terraria"].RemoveAll((Item Item) => Item.type == 3509);
				ItemsByMod["Terraria"].RemoveAll((Item Item) => Item.type == 3507);
			}
		}
		//Add Crude Bag.
		public override IEnumerable<Item> AddStartingItems(bool mediumCoreDeath)
		{
			return new Item[]
			{
				new Item(ModContent.ItemType<CrudeBag>(), 1, 0)
			};
		}
	}
}