﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{

	public class InOutLineMvoEventId
	{

		private InOutLineId _inOutLineId = new InOutLineId();

		public virtual InOutLineId InOutLineId { 
			get { return this._inOutLineId; } 
			set { _inOutLineId = value; } 
		}

		private long _inOutVersion;

		public virtual long InOutVersion { 
			get { return this._inOutVersion; } 
			set { _inOutVersion = value; } 
		}


        #region  Flattened Properties


		protected internal virtual string InOutLineIdInOutDocumentNumber {
			get { return InOutLineId.InOutDocumentNumber; }
			set { InOutLineId.InOutDocumentNumber = value; }
		}

		protected internal virtual string InOutLineIdLineNumber {
			get { return InOutLineId.LineNumber; }
			set { InOutLineId.LineNumber = value; }
		}

        #endregion

		public InOutLineMvoEventId ()
		{
		}

		public InOutLineMvoEventId (InOutLineId inOutLineId, long inOutVersion)
		{
			this._inOutLineId = inOutLineId;
			this._inOutVersion = inOutVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InOutLineMvoEventId other = obj as InOutLineMvoEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InOutLineId, other.InOutLineId)
				&& Object.Equals (this.InOutVersion, other.InOutVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InOutLineId != null) {
				hash += 13 * this.InOutLineId.GetHashCode ();
			}
			if (this.InOutVersion != null) {
				hash += 13 * this.InOutVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InOutLineMvoEventId obj1, InOutLineMvoEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InOutLineMvoEventId obj1, InOutLineMvoEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "InOutLineId: " + this.InOutLineId + ", "
                + "InOutVersion: " + this.InOutVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "InOutLineIdInOutDocumentNumber", "InOutLineIdLineNumber", "InOutVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static InOutLineMvoEventId()
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


