﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEventTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEventType;

namespace Dddml.Wms.Domain.InventoryItemEventType
{
	public interface IInventoryItemEventTypeStateEvent : IEvent, IStateEventDto, IGlobalIdentity<InventoryItemEventTypeStateEventId>, ICreated<string>
	{
		InventoryItemEventTypeStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

	}

	public interface IInventoryItemEventTypeStateCreated : IInventoryItemEventTypeStateEvent//, IInventoryItemEventTypeStateProperties
	{
	
	}


	public interface IInventoryItemEventTypeStateMergePatched : IInventoryItemEventTypeStateEvent//, IInventoryItemEventTypeStateProperties
	{
		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IInventoryItemEventTypeStateDeleted : IInventoryItemEventTypeStateEvent
	{
	}


}

