﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{
	public interface IInventoryItemRequirementStateEvent : IEvent, IStateEventDto, IGlobalIdentity<InventoryItemRequirementEventId>, ICreated<string>
	{
		InventoryItemRequirementEventId InventoryItemRequirementEventId { get; }

        bool ReadOnly { get; set; }

		decimal? Quantity { get; set; }

	}

	public interface IInventoryItemRequirementStateCreated : IInventoryItemRequirementStateEvent//, IInventoryItemRequirementStateProperties
	{
		IEnumerable<IInventoryItemRequirementEntryStateCreated> InventoryItemRequirementEntryEvents { get; }
		
		void AddInventoryItemRequirementEntryEvent(IInventoryItemRequirementEntryStateCreated e);

		IInventoryItemRequirementEntryStateCreated NewInventoryItemRequirementEntryStateCreated(long entrySeqId);

	
	}


	public interface IInventoryItemRequirementStateMergePatched : IInventoryItemRequirementStateEvent//, IInventoryItemRequirementStateProperties
	{
		bool IsPropertyQuantityRemoved { get; set; }

		IEnumerable<IInventoryItemRequirementEntryStateEvent> InventoryItemRequirementEntryEvents { get; }
		
		void AddInventoryItemRequirementEntryEvent(IInventoryItemRequirementEntryStateEvent e);

		IInventoryItemRequirementEntryStateCreated NewInventoryItemRequirementEntryStateCreated(long entrySeqId);


	}


}

