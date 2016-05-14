﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization;


namespace Dddml.Wms.Domain
{

	public class AttributeValueStateEventId
	{

		private string _attributeId;

		public virtual string AttributeId { 
			get { return this._attributeId; } 
			internal set { _attributeId = value; } 
		}

		private string _attributeValueValue;

		public virtual string AttributeValueValue { 
			get { return this._attributeValueValue; } 
			internal set { _attributeValueValue = value; } 
		}

		private long _attributeVersion;

		public virtual long AttributeVersion { 
			get { return this._attributeVersion; } 
			internal set { _attributeVersion = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal AttributeValueStateEventId ()
		{
		}

		public AttributeValueStateEventId (string attributeId, string attributeValueValue, long attributeVersion)
		{
			this._attributeId = attributeId;
			this._attributeValueValue = attributeValueValue;
			this._attributeVersion = attributeVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeValueStateEventId other = obj as AttributeValueStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeId, other.AttributeId)
				&& Object.Equals (this.AttributeValueValue, other.AttributeValueValue)
				&& Object.Equals (this.AttributeVersion, other.AttributeVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeId != null) {
				hash += 13 * this.AttributeId.GetHashCode ();
			}
			if (this.AttributeValueValue != null) {
				hash += 13 * this.AttributeValueValue.GetHashCode ();
			}
			if (this.AttributeVersion != null) {
				hash += 13 * this.AttributeVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

