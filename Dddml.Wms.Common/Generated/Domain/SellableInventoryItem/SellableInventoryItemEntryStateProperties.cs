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

	public abstract class SellableInventoryItemEntryStateProperties : ISellableInventoryItemEntryStateProperties
	{
		public virtual long EntrySeqId { get; set; }

		public virtual decimal SellableQuantity { get; set; }

		public virtual InventoryPRTriggeredId SourceEventId { get; set; }

		public virtual long Version { get; set; }

		// Outer Id:

		public virtual InventoryItemId SellableInventoryItemId { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
