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

	public class AttributeAliasIdDtoWrapper : AttributeAliasIdDto
	{

        private AttributeAliasId _value = new AttributeAliasId();

		public AttributeAliasIdDtoWrapper()
		{
		}

		public AttributeAliasIdDtoWrapper(AttributeAliasId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override AttributeAliasId ToAttributeAliasId()
        {
            return this._value;
        }

		public override string AttributeId { 
			get { return _value.AttributeId; } 
			set { _value.AttributeId = value; } 
		}

		public override string Code { 
			get { return _value.Code; } 
			set { _value.Code = value; } 
		}


	}

}

