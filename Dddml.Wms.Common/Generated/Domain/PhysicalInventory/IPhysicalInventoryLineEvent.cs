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
	public interface IPhysicalInventoryLineEvent : IEvent, IEventDto, IGlobalIdentity<PhysicalInventoryLineEventId>, ICreated<string>
	{
		PhysicalInventoryLineEventId PhysicalInventoryLineEventId { get; }

        bool ReadOnly { get; set; }

		// Outer Id:
		//string PhysicalInventoryDocumentNumber { get; set; }

	}

    public interface IPhysicalInventoryLineStateEvent : IPhysicalInventoryLineEvent
    {
		long Version { get; set; }

		decimal? BookQuantity { get; set; }

		decimal? CountedQuantity { get; set; }

		bool? Processed { get; set; }

		string LineNumber { get; set; }

		long? ReversalLineNumber { get; set; }

		string Description { get; set; }

    }
   
	public interface IPhysicalInventoryLineStateCreated : IPhysicalInventoryLineStateEvent
	{
	
	}


	public interface IPhysicalInventoryLineStateMergePatched : IPhysicalInventoryLineStateEvent
	{
		bool IsPropertyBookQuantityRemoved { get; set; }

		bool IsPropertyCountedQuantityRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyLineNumberRemoved { get; set; }

		bool IsPropertyReversalLineNumberRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }


	}

	public interface IPhysicalInventoryLineStateRemoved : IPhysicalInventoryLineStateEvent
	{
	}


}

