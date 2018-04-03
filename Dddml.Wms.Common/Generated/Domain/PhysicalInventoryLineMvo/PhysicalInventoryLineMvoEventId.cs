﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;

namespace Dddml.Wms.Domain.PhysicalInventoryLineMvo
{

	public class PhysicalInventoryLineMvoEventId
	{

		private PhysicalInventoryLineId _physicalInventoryLineId = new PhysicalInventoryLineId();

		public virtual PhysicalInventoryLineId PhysicalInventoryLineId { 
			get { return this._physicalInventoryLineId; } 
			set { _physicalInventoryLineId = value; } 
		}

		private long _physicalInventoryVersion;

		public virtual long PhysicalInventoryVersion { 
			get { return this._physicalInventoryVersion; } 
			set { _physicalInventoryVersion = value; } 
		}


        #region  Flattened Properties


		protected internal virtual string PhysicalInventoryLineIdPhysicalInventoryDocumentNumber {
			get { return PhysicalInventoryLineId.PhysicalInventoryDocumentNumber; }
			set { PhysicalInventoryLineId.PhysicalInventoryDocumentNumber = value; }
		}

		protected internal virtual string PhysicalInventoryLineIdInventoryItemIdProductId {
			get { return PhysicalInventoryLineId.InventoryItemId.ProductId; }
			set { PhysicalInventoryLineId.InventoryItemId.ProductId = value; }
		}

		protected internal virtual string PhysicalInventoryLineIdInventoryItemIdLocatorId {
			get { return PhysicalInventoryLineId.InventoryItemId.LocatorId; }
			set { PhysicalInventoryLineId.InventoryItemId.LocatorId = value; }
		}

		protected internal virtual string PhysicalInventoryLineIdInventoryItemIdAttributeSetInstanceId {
			get { return PhysicalInventoryLineId.InventoryItemId.AttributeSetInstanceId; }
			set { PhysicalInventoryLineId.InventoryItemId.AttributeSetInstanceId = value; }
		}

        #endregion

		public PhysicalInventoryLineMvoEventId ()
		{
		}

		public PhysicalInventoryLineMvoEventId (PhysicalInventoryLineId physicalInventoryLineId, long physicalInventoryVersion)
		{
			this._physicalInventoryLineId = physicalInventoryLineId;
			this._physicalInventoryVersion = physicalInventoryVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			PhysicalInventoryLineMvoEventId other = obj as PhysicalInventoryLineMvoEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.PhysicalInventoryLineId, other.PhysicalInventoryLineId)
				&& Object.Equals (this.PhysicalInventoryVersion, other.PhysicalInventoryVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.PhysicalInventoryLineId != null) {
				hash += 13 * this.PhysicalInventoryLineId.GetHashCode ();
			}
			if (this.PhysicalInventoryVersion != null) {
				hash += 13 * this.PhysicalInventoryVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(PhysicalInventoryLineMvoEventId obj1, PhysicalInventoryLineMvoEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(PhysicalInventoryLineMvoEventId obj1, PhysicalInventoryLineMvoEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "PhysicalInventoryLineId: " + this.PhysicalInventoryLineId + ", "
                + "PhysicalInventoryVersion: " + this.PhysicalInventoryVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "PhysicalInventoryLineIdPhysicalInventoryDocumentNumber", "PhysicalInventoryLineIdInventoryItemIdProductId", "PhysicalInventoryLineIdInventoryItemIdLocatorId", "PhysicalInventoryLineIdInventoryItemIdAttributeSetInstanceId", "PhysicalInventoryVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static PhysicalInventoryLineMvoEventId()
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

