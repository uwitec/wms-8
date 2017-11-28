﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{
	public interface IInventoryItemState : IInventoryItemStateProperties, 
		IGlobalIdentity<InventoryItemId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IInventoryItemStateCreated e);

		void When(IInventoryItemStateMergePatched e);

		void Mutate(IEvent e);


		IInventoryItemEntryStates Entries { get; set; }


        bool IsUnsaved { get; }

	}
}

