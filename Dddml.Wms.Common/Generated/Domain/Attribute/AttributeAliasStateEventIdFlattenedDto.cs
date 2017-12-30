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

	public class AttributeAliasStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "AttributeId", "Code", "AttributeVersion" };

        string[] IIdFlattenedDto.FieldNames
        {
            get { return _flattenedPropertyNames; }
        }

        object IIdFlattenedDto.GetFieldValue(string fieldName)
        {
            return ReflectUtils.GetPropertyValue(fieldName, this._value);
        }

        void IIdFlattenedDto.SetFieldValue(string fieldName, object fieldValue)
        {
            ReflectUtils.SetPropertyValue(fieldName, this._value, fieldValue);
        }

        Type IIdFlattenedDto.GetFieldType(string fieldName)
        {
            if (fieldName.Equals("AttributeId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("Code", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("AttributeVersion", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private AttributeAliasStateEventIdDto _value = new AttributeAliasStateEventIdDto();

		public AttributeAliasStateEventIdFlattenedDto()
		{
		}

		public AttributeAliasStateEventIdFlattenedDto(AttributeAliasStateEventIdDto val)
		{
			this._value = val;
		}

        public AttributeAliasStateEventIdDto ToAttributeAliasStateEventIdDto()
        {
            return this._value;
        }

		public AttributeAliasStateEventIdFlattenedDto(AttributeAliasStateEventId val)
		{
			this._value = new AttributeAliasStateEventIdDtoWrapper(val);
		}

        public AttributeAliasStateEventId ToAttributeAliasStateEventId()
        {
            return this._value.ToAttributeAliasStateEventId();
        }

		public virtual string AttributeId { 
			get { return _value.AttributeId; } 
			set { _value.AttributeId = value; } 
		}

		public virtual string Code { 
			get { return _value.Code; } 
			set { _value.Code = value; } 
		}

		public virtual long AttributeVersion { 
			get { return _value.AttributeVersion; } 
			set { _value.AttributeVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			AttributeAliasStateEventIdFlattenedDto other = obj as AttributeAliasStateEventIdFlattenedDto;
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

    public class AttributeAliasStateEventIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<AttributeAliasStateEventIdFlattenedDto>
    {

    }

}

