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
	public interface ISellableInventoryItemEntryEvent : IEvent, IEventDto, IGlobalIdentity<SellableInventoryItemEntryEventId>, ICreated<string>
	{
		SellableInventoryItemEntryEventId SellableInventoryItemEntryEventId { get; }

        bool ReadOnly { get; set; }

		// Outer Id:
		//InventoryItemId SellableInventoryItemId { get; set; }

	}

    public interface ISellableInventoryItemEntryStateEvent : ISellableInventoryItemEntryEvent
    {
		long Version { get; set; }

		decimal? SellableQuantity { get; set; }

		InventoryPRTriggeredId SourceEventId { get; set; }

    }
   
	public interface ISellableInventoryItemEntryStateCreated : ISellableInventoryItemEntryStateEvent
	{
	
	}

}

