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

	public static partial class OrderItemStateExtension
	{

        public static IOrderItemCommand ToCreateOrMergePatchOrderItem(this OrderItemState state)
        {
            return state.ToCreateOrMergePatchOrderItem<CreateOrderItem, MergePatchOrderItem>();
        }

        public static RemoveOrderItem ToRemoveOrderItem(this OrderItemState state)
        {
            return state.ToRemoveOrderItem<RemoveOrderItem>();
        }

        public static MergePatchOrderItem ToMergePatchOrderItem(this OrderItemState state)
        {
            return state.ToMergePatchOrderItem<MergePatchOrderItem>();
        }

        public static CreateOrderItem ToCreateOrderItem(this OrderItemState state)
        {
            return state.ToCreateOrderItem<CreateOrderItem>();
        }
		

	}

}

