﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{
	public interface ISellableInventoryItemEntryMvoStateEvent : IEvent, IStateEventDto, IGlobalIdentity<SellableInventoryItemEntryMvoEventId>, ICreated<string>
	{
		SellableInventoryItemEntryMvoEventId SellableInventoryItemEntryMvoEventId { get; }

        bool ReadOnly { get; set; }

		decimal? SellableQuantity { get; set; }

		InventoryPRTriggeredId SourceEventId { get; set; }

		long? Version { get; set; }

		decimal? SellableInventoryItemSellableQuantity { get; set; }

		string SellableInventoryItemCreatedBy { get; set; }

		DateTime? SellableInventoryItemCreatedAt { get; set; }

		string SellableInventoryItemUpdatedBy { get; set; }

		DateTime? SellableInventoryItemUpdatedAt { get; set; }

	}

	public interface ISellableInventoryItemEntryMvoStateCreated : ISellableInventoryItemEntryMvoStateEvent//, ISellableInventoryItemEntryMvoStateProperties
	{
	
	}


	public interface ISellableInventoryItemEntryMvoStateMergePatched : ISellableInventoryItemEntryMvoStateEvent//, ISellableInventoryItemEntryMvoStateProperties
	{
		bool IsPropertySellableQuantityRemoved { get; set; }

		bool IsPropertySourceEventIdRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertySellableInventoryItemSellableQuantityRemoved { get; set; }

		bool IsPropertySellableInventoryItemCreatedByRemoved { get; set; }

		bool IsPropertySellableInventoryItemCreatedAtRemoved { get; set; }

		bool IsPropertySellableInventoryItemUpdatedByRemoved { get; set; }

		bool IsPropertySellableInventoryItemUpdatedAtRemoved { get; set; }


	}


}

