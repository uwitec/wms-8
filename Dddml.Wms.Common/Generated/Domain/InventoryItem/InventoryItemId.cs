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

	public class InventoryItemId
	{

		private string _productId;

		public virtual string ProductId { 
			get { return this._productId; } 
			set { _productId = value; } 
		}

		private string _locatorId;

		public virtual string LocatorId { 
			get { return this._locatorId; } 
			set { _locatorId = value; } 
		}

		private string _attributeSetInstanceId;

		public virtual string AttributeSetInstanceId { 
			get { return this._attributeSetInstanceId; } 
			set { _attributeSetInstanceId = value; } 
		}


        #region  Flattened Properties


        #endregion

		public InventoryItemId ()
		{
		}

		public InventoryItemId (string productId, string locatorId, string attributeSetInstanceId)
		{
			this._productId = productId;
			this._locatorId = locatorId;
			this._attributeSetInstanceId = attributeSetInstanceId;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemId other = obj as InventoryItemId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ProductId, other.ProductId)
				&& Object.Equals (this.LocatorId, other.LocatorId)
				&& Object.Equals (this.AttributeSetInstanceId, other.AttributeSetInstanceId)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ProductId != null) {
				hash += 13 * this.ProductId.GetHashCode ();
			}
			if (this.LocatorId != null) {
				hash += 13 * this.LocatorId.GetHashCode ();
			}
			if (this.AttributeSetInstanceId != null) {
				hash += 13 * this.AttributeSetInstanceId.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InventoryItemId obj1, InventoryItemId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryItemId obj1, InventoryItemId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "ProductId: " + this.ProductId + ", "
                + "LocatorId: " + this.LocatorId + ", "
                + "AttributeSetInstanceId: " + this.AttributeSetInstanceId + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "ProductId", "LocatorId", "AttributeSetInstanceId" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(string) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static InventoryItemId()
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


