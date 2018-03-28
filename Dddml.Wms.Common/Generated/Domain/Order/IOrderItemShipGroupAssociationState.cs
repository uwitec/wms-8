﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{
	public interface IOrderItemShipGroupAssociationState : IOrderItemShipGroupAssociationStateProperties, 
		IGlobalIdentity<OrderItemShipGroupAssociationId>, 
		ILocalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IEntityVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IOrderItemShipGroupAssociationStateCreated e);

		void When(IOrderItemShipGroupAssociationStateMergePatched e);

		void When(IOrderItemShipGroupAssociationStateRemoved e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}

}

