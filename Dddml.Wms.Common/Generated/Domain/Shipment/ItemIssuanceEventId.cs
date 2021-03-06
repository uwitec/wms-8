﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public class ItemIssuanceEventId
	{

		private string _shipmentId;

		public virtual string ShipmentId { 
			get { return this._shipmentId; } 
			set { _shipmentId = value; } 
		}

		private string _itemIssuanceSeqId;

		public virtual string ItemIssuanceSeqId { 
			get { return this._itemIssuanceSeqId; } 
			set { _itemIssuanceSeqId = value; } 
		}

		private long _shipmentVersion;

		public virtual long ShipmentVersion { 
			get { return this._shipmentVersion; } 
			set { _shipmentVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		public ItemIssuanceEventId ()
		{
		}

		public ItemIssuanceEventId (string shipmentId, string itemIssuanceSeqId, long shipmentVersion)
		{
			this._shipmentId = shipmentId;
			this._itemIssuanceSeqId = itemIssuanceSeqId;
			this._shipmentVersion = shipmentVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ItemIssuanceEventId other = obj as ItemIssuanceEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ShipmentId, other.ShipmentId)
				&& Object.Equals (this.ItemIssuanceSeqId, other.ItemIssuanceSeqId)
				&& Object.Equals (this.ShipmentVersion, other.ShipmentVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ShipmentId != null) {
				hash += 13 * this.ShipmentId.GetHashCode ();
			}
			if (this.ItemIssuanceSeqId != null) {
				hash += 13 * this.ItemIssuanceSeqId.GetHashCode ();
			}
			if (this.ShipmentVersion != null) {
				hash += 13 * this.ShipmentVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(ItemIssuanceEventId obj1, ItemIssuanceEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(ItemIssuanceEventId obj1, ItemIssuanceEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "ShipmentId: " + this.ShipmentId + ", "
                + "ItemIssuanceSeqId: " + this.ItemIssuanceSeqId + ", "
                + "ShipmentVersion: " + this.ShipmentVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "ShipmentId", "ItemIssuanceSeqId", "ShipmentVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static ItemIssuanceEventId()
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


