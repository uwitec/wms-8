﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

	public class InventoryItemEventId
	{

		private InventoryItemId _inventoryItemId = new InventoryItemId();

		public virtual InventoryItemId InventoryItemId { 
			get { return this._inventoryItemId; } 
			set { _inventoryItemId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			set { _version = value; } 
		}


        #region  Flattened Properties


		protected internal virtual string InventoryItemIdProductId {
			get { return InventoryItemId.ProductId; }
			set { InventoryItemId.ProductId = value; }
		}

		protected internal virtual string InventoryItemIdLocatorId {
			get { return InventoryItemId.LocatorId; }
			set { InventoryItemId.LocatorId = value; }
		}

		protected internal virtual string InventoryItemIdAttributeSetInstanceId {
			get { return InventoryItemId.AttributeSetInstanceId; }
			set { InventoryItemId.AttributeSetInstanceId = value; }
		}

        #endregion

		public InventoryItemEventId ()
		{
		}

		public InventoryItemEventId (InventoryItemId inventoryItemId, long version)
		{
			this._inventoryItemId = inventoryItemId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemEventId other = obj as InventoryItemEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryItemId, other.InventoryItemId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryItemId != null) {
				hash += 13 * this.InventoryItemId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InventoryItemEventId obj1, InventoryItemEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryItemEventId obj1, InventoryItemEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "InventoryItemId: " + this.InventoryItemId + ", "
                + "Version: " + this.Version + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "InventoryItemIdProductId", "InventoryItemIdLocatorId", "InventoryItemIdAttributeSetInstanceId", "Version" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static InventoryItemEventId()
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


