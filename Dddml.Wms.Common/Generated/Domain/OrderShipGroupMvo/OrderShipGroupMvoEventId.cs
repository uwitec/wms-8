﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipGroupMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipGroupMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderShipGroupMvo
{

	public class OrderShipGroupMvoEventId
	{

		private OrderShipGroupId _orderShipGroupId = new OrderShipGroupId();

		public virtual OrderShipGroupId OrderShipGroupId { 
			get { return this._orderShipGroupId; } 
			set { _orderShipGroupId = value; } 
		}

		private long _orderVersion;

		public virtual long OrderVersion { 
			get { return this._orderVersion; } 
			set { _orderVersion = value; } 
		}


        #region  Flattened Properties


		protected internal virtual string OrderShipGroupIdOrderId {
			get { return OrderShipGroupId.OrderId; }
			set { OrderShipGroupId.OrderId = value; }
		}

		protected internal virtual long? OrderShipGroupIdShipGroupSeqId {
			get { return OrderShipGroupId.ShipGroupSeqId; }
			set { OrderShipGroupId.ShipGroupSeqId = value; }
		}

        #endregion

		public OrderShipGroupMvoEventId ()
		{
		}

		public OrderShipGroupMvoEventId (OrderShipGroupId orderShipGroupId, long orderVersion)
		{
			this._orderShipGroupId = orderShipGroupId;
			this._orderVersion = orderVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			OrderShipGroupMvoEventId other = obj as OrderShipGroupMvoEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.OrderShipGroupId, other.OrderShipGroupId)
				&& Object.Equals (this.OrderVersion, other.OrderVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.OrderShipGroupId != null) {
				hash += 13 * this.OrderShipGroupId.GetHashCode ();
			}
			if (this.OrderVersion != null) {
				hash += 13 * this.OrderVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(OrderShipGroupMvoEventId obj1, OrderShipGroupMvoEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(OrderShipGroupMvoEventId obj1, OrderShipGroupMvoEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "OrderShipGroupId: " + this.OrderShipGroupId + ", "
                + "OrderVersion: " + this.OrderVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "OrderShipGroupIdOrderId", "OrderShipGroupIdShipGroupSeqId", "OrderVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(long?), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static OrderShipGroupMvoEventId()
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


