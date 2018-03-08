﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{
	public interface IPhysicalInventoryLineStateEvent : IEvent, IStateEventDto, IGlobalIdentity<PhysicalInventoryLineEventId>, ICreated<string>
	{
		PhysicalInventoryLineEventId PhysicalInventoryLineEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		decimal? BookQuantity { get; set; }

		decimal? CountedQuantity { get; set; }

		bool? Processed { get; set; }

		long? ReversalLineNumber { get; set; }

		string Description { get; set; }

		// Outer Id:
		//string PhysicalInventoryDocumentNumber { get; set; }

	}

	public interface IPhysicalInventoryLineStateCreated : IPhysicalInventoryLineStateEvent//, IPhysicalInventoryLineStateProperties
	{
	
	}


	public interface IPhysicalInventoryLineStateMergePatched : IPhysicalInventoryLineStateEvent//, IPhysicalInventoryLineStateProperties
	{
		bool IsPropertyBookQuantityRemoved { get; set; }

		bool IsPropertyCountedQuantityRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyReversalLineNumberRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }


	}

	public interface IPhysicalInventoryLineStateRemoved : IPhysicalInventoryLineStateEvent
	{
	}


}

