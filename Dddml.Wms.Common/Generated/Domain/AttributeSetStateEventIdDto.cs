﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization;


namespace Dddml.Wms.Domain
{

	public class AttributeSetStateEventIdDto
	{

        private AttributeSetStateEventId _value = new AttributeSetStateEventId();

		public AttributeSetStateEventIdDto()
		{
		}

		public AttributeSetStateEventIdDto(AttributeSetStateEventId val)
		{
			this._value = val;
		}

        public AttributeSetStateEventId ToAttributeSetStateEventId()
        {
            return this._value;
        }

		public virtual string AttributeSetId { 
			get { return _value.AttributeSetId; } 
			set { _value.AttributeSetId = value; } 
		}

		public virtual long AttributeSetVersion { 
			get { return _value.AttributeSetVersion; } 
			set { _value.AttributeSetVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeSetStateEventIdDto other = obj as AttributeSetStateEventIdDto;
			if (other == null) {
				return false;
			}

            return _value.Equals(other._value);

		}

		public override int GetHashCode ()
		{
			return _value.GetHashCode();
		}

	}

}

