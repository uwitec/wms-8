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
	public interface IInventoryItemRequirementState : IInventoryItemRequirementStateProperties, 
		IGlobalIdentity<InventoryItemId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		string CommandId { get; set; }

		void When(IInventoryItemRequirementStateCreated e);

		void When(IInventoryItemRequirementStateMergePatched e);

		void Mutate(IEvent e);


		IInventoryItemRequirementEntryStates Entries { get; set; }


        bool IsUnsaved { get; }

	}
}
