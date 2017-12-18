﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.Order
{

	public class OrderStateEventIdDtoWrapper : OrderStateEventIdDto
	{

        private OrderStateEventId _value = new OrderStateEventId();

		public OrderStateEventIdDtoWrapper()
		{
		}

		public OrderStateEventIdDtoWrapper(OrderStateEventId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override OrderStateEventId ToOrderStateEventId()
        {
            return this._value;
        }

		public override string OrderId { 
			get { return _value.OrderId; } 
			set { _value.OrderId = value; } 
		}

		public override long Version { 
			get { return _value.Version; } 
			set { _value.Version = value; } 
		}


	}

}

