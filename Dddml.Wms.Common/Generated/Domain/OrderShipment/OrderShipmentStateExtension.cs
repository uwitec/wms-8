﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipment;

namespace Dddml.Wms.Domain.OrderShipment
{

	public static partial class OrderShipmentStateExtension
	{

        public static IOrderShipmentCommand ToCreateOrMergePatchOrderShipment(this OrderShipmentState state)
        {
            return state.ToCreateOrMergePatchOrderShipment<CreateOrderShipment, MergePatchOrderShipment>();
        }

        public static DeleteOrderShipment ToDeleteOrderShipment(this OrderShipmentState state)
        {
            return state.ToDeleteOrderShipment<DeleteOrderShipment>();
        }

        public static MergePatchOrderShipment ToMergePatchOrderShipment(this OrderShipmentState state)
        {
            return state.ToMergePatchOrderShipment<MergePatchOrderShipment>();
        }

        public static CreateOrderShipment ToCreateOrderShipment(this OrderShipmentState state)
        {
            return state.ToCreateOrderShipment<CreateOrderShipment>();
        }
		

	}

}

