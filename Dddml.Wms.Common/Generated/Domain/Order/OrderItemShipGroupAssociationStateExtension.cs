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

	public static partial class OrderItemShipGroupAssociationStateExtension
	{

        public static IOrderItemShipGroupAssociationCommand ToCreateOrMergePatchOrderItemShipGroupAssociation(this OrderItemShipGroupAssociationState state)
        {
            return state.ToCreateOrMergePatchOrderItemShipGroupAssociation<CreateOrderItemShipGroupAssociation, MergePatchOrderItemShipGroupAssociation>();
        }

        public static RemoveOrderItemShipGroupAssociation ToRemoveOrderItemShipGroupAssociation(this OrderItemShipGroupAssociationState state)
        {
            return state.ToRemoveOrderItemShipGroupAssociation<RemoveOrderItemShipGroupAssociation>();
        }

        public static MergePatchOrderItemShipGroupAssociation ToMergePatchOrderItemShipGroupAssociation(this OrderItemShipGroupAssociationState state)
        {
            return state.ToMergePatchOrderItemShipGroupAssociation<MergePatchOrderItemShipGroupAssociation>();
        }

        public static CreateOrderItemShipGroupAssociation ToCreateOrderItemShipGroupAssociation(this OrderItemShipGroupAssociationState state)
        {
            return state.ToCreateOrderItemShipGroupAssociation<CreateOrderItemShipGroupAssociation>();
        }
		

	}

}

