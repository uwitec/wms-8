﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public class AttributeAliasStateEventIdDto
	{

		public AttributeAliasStateEventIdDto()
		{
		}

        public virtual AttributeAliasStateEventId ToAttributeAliasStateEventId()
        {
            AttributeAliasStateEventId v = new AttributeAliasStateEventId();
            v.AttributeId = this.AttributeId;
            v.Code = this.Code;
            v.AttributeVersion = this.AttributeVersion;
            return v;
        }

		public virtual string AttributeId { 
			get;
			set;
		}

		public virtual string Code { 
			get;
			set;
		}

		public virtual long AttributeVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeAliasStateEventIdDto other = obj as AttributeAliasStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.AttributeId, other.AttributeId)
				&& Object.Equals (this.Code, other.Code)
				&& Object.Equals (this.AttributeVersion, other.AttributeVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.AttributeId != null) {
				hash += 13 * this.AttributeId.GetHashCode ();
			}
			if (this.Code != null) {
				hash += 13 * this.Code.GetHashCode ();
			}
			if (this.AttributeVersion != null) {
				hash += 13 * this.AttributeVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

