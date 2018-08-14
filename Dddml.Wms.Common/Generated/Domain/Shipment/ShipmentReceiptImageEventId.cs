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

	public class ShipmentReceiptImageEventId
	{

		private string _shipmentId;

		public virtual string ShipmentId { 
			get { return this._shipmentId; } 
			set { _shipmentId = value; } 
		}

		private string _shipmentReceiptReceiptSeqId;

		public virtual string ShipmentReceiptReceiptSeqId { 
			get { return this._shipmentReceiptReceiptSeqId; } 
			set { _shipmentReceiptReceiptSeqId = value; } 
		}

		private string _sequenceId;

		public virtual string SequenceId { 
			get { return this._sequenceId; } 
			set { _sequenceId = value; } 
		}

		private long _shipmentVersion;

		public virtual long ShipmentVersion { 
			get { return this._shipmentVersion; } 
			set { _shipmentVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		public ShipmentReceiptImageEventId ()
		{
		}

		public ShipmentReceiptImageEventId (string shipmentId, string shipmentReceiptReceiptSeqId, string sequenceId, long shipmentVersion)
		{
			this._shipmentId = shipmentId;
			this._shipmentReceiptReceiptSeqId = shipmentReceiptReceiptSeqId;
			this._sequenceId = sequenceId;
			this._shipmentVersion = shipmentVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ShipmentReceiptImageEventId other = obj as ShipmentReceiptImageEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ShipmentId, other.ShipmentId)
				&& Object.Equals (this.ShipmentReceiptReceiptSeqId, other.ShipmentReceiptReceiptSeqId)
				&& Object.Equals (this.SequenceId, other.SequenceId)
				&& Object.Equals (this.ShipmentVersion, other.ShipmentVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ShipmentId != null) {
				hash += 13 * this.ShipmentId.GetHashCode ();
			}
			if (this.ShipmentReceiptReceiptSeqId != null) {
				hash += 13 * this.ShipmentReceiptReceiptSeqId.GetHashCode ();
			}
			if (this.SequenceId != null) {
				hash += 13 * this.SequenceId.GetHashCode ();
			}
			if (this.ShipmentVersion != null) {
				hash += 13 * this.ShipmentVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(ShipmentReceiptImageEventId obj1, ShipmentReceiptImageEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(ShipmentReceiptImageEventId obj1, ShipmentReceiptImageEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "ShipmentId: " + this.ShipmentId + ", "
                + "ShipmentReceiptReceiptSeqId: " + this.ShipmentReceiptReceiptSeqId + ", "
                + "SequenceId: " + this.SequenceId + ", "
                + "ShipmentVersion: " + this.ShipmentVersion + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "ShipmentId", "ShipmentReceiptReceiptSeqId", "SequenceId", "ShipmentVersion" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string), typeof(string), typeof(long) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static ShipmentReceiptImageEventId()
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


