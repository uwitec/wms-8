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

	public static partial class OrderStateDtoExtension
	{

        public static IOrderCommand ToCreateOrMergePatchOrder(this OrderStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchOrder<CreateOrderDto, MergePatchOrderDto, CreateOrderRoleDto, MergePatchOrderRoleDto, CreateOrderItemDto, MergePatchOrderItemDto, CreateOrderShipGroupDto, MergePatchOrderShipGroupDto>();
        }

        public static DeleteOrderDto ToDeleteOrder(this OrderStateDtoWrapper state)
        {
            return state.ToDeleteOrder<DeleteOrderDto>();
        }

        public static MergePatchOrderDto ToMergePatchOrder(this OrderStateDtoWrapper state)
        {
            return state.ToMergePatchOrder<MergePatchOrderDto, CreateOrderRoleDto, MergePatchOrderRoleDto, CreateOrderItemDto, MergePatchOrderItemDto, CreateOrderShipGroupDto, MergePatchOrderShipGroupDto>();
        }

        public static CreateOrderDto ToCreateOrder(this OrderStateDtoWrapper state)
        {
            return state.ToCreateOrder<CreateOrderDto, CreateOrderRoleDto, CreateOrderItemDto, CreateOrderShipGroupDto>();
        }
		

	}

}

