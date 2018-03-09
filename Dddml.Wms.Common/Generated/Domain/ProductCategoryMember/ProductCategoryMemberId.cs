﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryMemberDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategoryMember;

namespace Dddml.Wms.Domain.ProductCategoryMember
{

	public class ProductCategoryMemberId
	{

		private string _productCategoryId;

		public virtual string ProductCategoryId { 
			get { return this._productCategoryId; } 
			set { _productCategoryId = value; } 
		}

		private string _productId;

		public virtual string ProductId { 
			get { return this._productId; } 
			set { _productId = value; } 
		}


        #region  Flattened Properties


        #endregion

		public ProductCategoryMemberId ()
		{
		}

		public ProductCategoryMemberId (string productCategoryId, string productId)
		{
			this._productCategoryId = productCategoryId;
			this._productId = productId;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ProductCategoryMemberId other = obj as ProductCategoryMemberId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ProductCategoryId, other.ProductCategoryId)
				&& Object.Equals (this.ProductId, other.ProductId)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ProductCategoryId != null) {
				hash += 13 * this.ProductCategoryId.GetHashCode ();
			}
			if (this.ProductId != null) {
				hash += 13 * this.ProductId.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(ProductCategoryMemberId obj1, ProductCategoryMemberId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(ProductCategoryMemberId obj1, ProductCategoryMemberId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "ProductCategoryId: " + this.ProductCategoryId + ", "
                + "ProductId: " + this.ProductId + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "ProductCategoryId", "ProductId" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static ProductCategoryMemberId()
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


