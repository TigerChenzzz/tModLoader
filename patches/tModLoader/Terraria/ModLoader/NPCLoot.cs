﻿using System.Collections.Generic;
using Terraria.GameContent.ItemDropRules;

namespace Terraria.ModLoader
{
	/// <summary> This readonly struct is a simple shortcut to <see cref="ItemDropDatabase"/>'s methods. </summary>
	public readonly struct NPCLoot
	{
		private readonly int npcType;
		private readonly ItemDropDatabase itemDropDatabase;

		public NPCLoot(int npcType, ItemDropDatabase itemDropDatabase) {
			this.npcType = npcType;
			this.itemDropDatabase = itemDropDatabase;
		}

		public IItemDropRule Add(IItemDropRule entry) => itemDropDatabase.RegisterToNPC(npcType, entry);
		public IItemDropRule Remove(IItemDropRule entry) => itemDropDatabase.RemoveFromNPC(npcType, entry);
		public List<IItemDropRule> Get(bool includeGlobalDrops = true) => itemDropDatabase.GetRulesForNPCID(npcType, includeGlobalDrops);
	}
}
