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

	public static partial class OrderItemStateDtoExtension
	{

        public static IOrderItemCommand ToCreateOrMergePatchOrderItem(this OrderItemStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchOrderItem<CreateOrderItemDto, MergePatchOrderItemDto>();
        }

        public static RemoveOrderItemDto ToRemoveOrderItem(this OrderItemStateDtoWrapper state)
        {
            return state.ToRemoveOrderItem<RemoveOrderItemDto>();
        }

        public static MergePatchOrderItemDto ToMergePatchOrderItem(this OrderItemStateDtoWrapper state)
        {
            return state.ToMergePatchOrderItem<MergePatchOrderItemDto>();
        }

        public static CreateOrderItemDto ToCreateOrderItem(this OrderItemStateDtoWrapper state)
        {
            return state.ToCreateOrderItem<CreateOrderItemDto>();
        }
		

	}

}

