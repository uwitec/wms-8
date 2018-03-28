﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGroupAssociationMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo
{

	public class OrderItemShipGroupAssociationMvoEventId
	{

		private OrderItemShipGroupAssociationId _orderItemShipGroupAssociationId = new OrderItemShipGroupAssociationId();

		public virtual OrderItemShipGroupAssociationId OrderItemShipGroupAssociationId { 
			get { return this._orderItemShipGroupAssociationId; } 
			set { _orderItemShipGroupAssociationId = value; } 
		}

		private long _orderVersion;

		public virtual long OrderVersion { 
			get { return this._orderVersion; } 
			set { _orderVersion = value; } 
		}


        #region  Flattened Properties


		protected internal virtual string OrderItemShipGroupAssociationIdOrderId {
			get { return OrderItemShipGroupAssociationId.OrderId; }
			set { OrderItemShipGroupAssociationId.OrderId = value; }
		}

		protected internal virtual long? OrderItemShipGroupAssociationIdOrderShipGroupShipGroupSeqId {
			get { return OrderItemShipGroupAssociationId.OrderShipGroupShipGroupSeqId; }
			set { OrderItemShipGroupAssociationId.OrderShipGroupShipGroupSeqId = value; }
		}

		protected internal virtual string OrderItemShipGroupAssociationIdOrderItemSeqId {
			get { return OrderItemShipGroupAssociationId.OrderItemSeqId; }
			set { OrderItemShipGroupAssociationId.OrderItemSeqId = value; }
		}

        #endregion

		public OrderItemShipGroupAssociationMvoEventId ()
		{
		}

		public OrderItemShipGroupAssociationMvoEventId (OrderItemShipGroupAssociationId orderItemShipGroupAssociationId, long orderVersion)
		{
			this._orderItemShipGroupAssociationId = orderItemShipGroupAssociationId;
			this._orderVersion = orderVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrderItemShipGroupAssociationMvoEventId other = obj as OrderItemShipGroupAssociationMvoEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.OrderItemShipGroupAssociationId, other.OrderItemShipGroupAssociationId)
				&& Object.Equals (this.OrderVersion, other.OrderVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.OrderItemShipGroupAssociationId != null) {
				hash += 13 * this.OrderItemShipGroupAssociationId.GetHashCode ();
			}
			if (this.OrderVersion != null) {
				hash += 13 * this.OrderVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(OrderItemShipGroupAssociationMvoEventId obj1, OrderItemShipGroupAssociationMvoEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(OrderItemShipGroupAssociationMvoEventId obj1, OrderItemShipGroupAssociationMvoEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "OrderItemShipGroupAssociationId: " + this.OrderItemShipGroupAssociationId + ", "
                + "OrderVersion: " + this.OrderVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "OrderItemShipGroupAssociationIdOrderId", "OrderItemShipGroupAssociationIdOrderShipGroupShipGroupSeqId", "OrderItemShipGroupAssociationIdOrderItemSeqId", "OrderVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(long?), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static OrderItemShipGroupAssociationMvoEventId()
        {
            var dict = new Dictionary<string, Type>();
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                dict.Add(FlattenedPropertyNames[i], FlattenedPropertyTypes[i]);
            }
            FlattenedPropertyTypeDictionary = dict;
        }

        protected internal void ForEachFlattenedProperty(Action<string, object> act)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                object pv = m.GetValue(this);
                act(pn, pv);
            }
        }

        protected internal void SetFlattenedPropertyValues(params object[] values)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var v = values[i];
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                m.SetValue(this, v);
            }
        }
	}

}


