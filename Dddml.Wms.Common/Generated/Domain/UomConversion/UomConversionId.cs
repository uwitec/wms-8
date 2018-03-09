﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomConversionDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomConversion;

namespace Dddml.Wms.Domain.UomConversion
{

	public class UomConversionId
	{

		private string _uomId;

		public virtual string UomId { 
			get { return this._uomId; } 
			set { _uomId = value; } 
		}

		private string _uomIdTo;

		public virtual string UomIdTo { 
			get { return this._uomIdTo; } 
			set { _uomIdTo = value; } 
		}


        #region  Flattened Properties


        #endregion

		public UomConversionId ()
		{
		}

		public UomConversionId (string uomId, string uomIdTo)
		{
			this._uomId = uomId;
			this._uomIdTo = uomIdTo;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UomConversionId other = obj as UomConversionId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UomId, other.UomId)
				&& Object.Equals (this.UomIdTo, other.UomIdTo)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UomId != null) {
				hash += 13 * this.UomId.GetHashCode ();
			}
			if (this.UomIdTo != null) {
				hash += 13 * this.UomIdTo.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(UomConversionId obj1, UomConversionId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(UomConversionId obj1, UomConversionId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "UomId: " + this.UomId + ", "
                + "UomIdTo: " + this.UomIdTo + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "UomId", "UomIdTo" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static UomConversionId()
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


