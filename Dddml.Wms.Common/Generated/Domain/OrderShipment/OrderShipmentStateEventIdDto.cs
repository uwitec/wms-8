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

	public class OrderShipmentStateEventIdDto
	{

		public OrderShipmentStateEventIdDto()
		{
		}

        public virtual OrderShipmentStateEventId ToOrderShipmentStateEventId()
        {
            OrderShipmentStateEventId v = new OrderShipmentStateEventId();
            v.OrderShipmentId = this.OrderShipmentId.ToOrderShipmentId();
            v.Version = this.Version;
            return v;
        }

		private OrderShipmentIdDto _orderShipmentId = new OrderShipmentIdDto();

		public virtual OrderShipmentIdDto OrderShipmentId { 
			get { return this._orderShipmentId; } 
			set { this._orderShipmentId = value; } 
		}

		public virtual long Version { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrderShipmentStateEventIdDto other = obj as OrderShipmentStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.OrderShipmentId, other.OrderShipmentId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.OrderShipmentId != null) {
				hash += 13 * this.OrderShipmentId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

	}

}

