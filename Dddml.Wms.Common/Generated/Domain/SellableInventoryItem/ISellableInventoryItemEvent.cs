﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItem
{
	public interface ISellableInventoryItemEvent : IEvent, IEventDto, IGlobalIdentity<SellableInventoryItemEventId>, ICreated<string>
	{
		SellableInventoryItemEventId SellableInventoryItemEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface ISellableInventoryItemStateEvent : ISellableInventoryItemEvent
    {
		decimal? SellableQuantity { get; set; }

    }
   
	public interface ISellableInventoryItemStateCreated : ISellableInventoryItemStateEvent
	{
		IEnumerable<ISellableInventoryItemEntryStateCreated> SellableInventoryItemEntryEvents { get; }
		
		void AddSellableInventoryItemEntryEvent(ISellableInventoryItemEntryStateCreated e);

		ISellableInventoryItemEntryStateCreated NewSellableInventoryItemEntryStateCreated(long entrySeqId);

	
	}


	public interface ISellableInventoryItemStateMergePatched : ISellableInventoryItemStateEvent
	{
		bool IsPropertySellableQuantityRemoved { get; set; }

		IEnumerable<ISellableInventoryItemEntryEvent> SellableInventoryItemEntryEvents { get; }
		
		void AddSellableInventoryItemEntryEvent(ISellableInventoryItemEntryEvent e);

		ISellableInventoryItemEntryStateCreated NewSellableInventoryItemEntryStateCreated(long entrySeqId);


	}


}
