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

	public class OrderShipmentId
	{

		private string _orderId;

		public virtual string OrderId { 
			get { return this._orderId; } 
			internal set { _orderId = value; } 
		}

		private string _orderItemSeqId;

		public virtual string OrderItemSeqId { 
			get { return this._orderItemSeqId; } 
			internal set { _orderItemSeqId = value; } 
		}

		private string _shipmentId;

		public virtual string ShipmentId { 
			get { return this._shipmentId; } 
			internal set { _shipmentId = value; } 
		}

		private string _shipmentItemSeqId;

		public virtual string ShipmentItemSeqId { 
			get { return this._shipmentItemSeqId; } 
			internal set { _shipmentItemSeqId = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal OrderShipmentId ()
		{
		}

		public OrderShipmentId (string orderId, string orderItemSeqId, string shipmentId, string shipmentItemSeqId)
		{
			this._orderId = orderId;
			this._orderItemSeqId = orderItemSeqId;
			this._shipmentId = shipmentId;
			this._shipmentItemSeqId = shipmentItemSeqId;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrderShipmentId other = obj as OrderShipmentId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.OrderId, other.OrderId)
				&& Object.Equals (this.OrderItemSeqId, other.OrderItemSeqId)
				&& Object.Equals (this.ShipmentId, other.ShipmentId)
				&& Object.Equals (this.ShipmentItemSeqId, other.ShipmentItemSeqId)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.OrderId != null) {
				hash += 13 * this.OrderId.GetHashCode ();
			}
			if (this.OrderItemSeqId != null) {
				hash += 13 * this.OrderItemSeqId.GetHashCode ();
			}
			if (this.ShipmentId != null) {
				hash += 13 * this.ShipmentId.GetHashCode ();
			}
			if (this.ShipmentItemSeqId != null) {
				hash += 13 * this.ShipmentItemSeqId.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(OrderShipmentId obj1, OrderShipmentId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(OrderShipmentId obj1, OrderShipmentId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


