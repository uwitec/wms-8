﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public class SkuIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "ProductId", "AttributeSetInstanceId" };

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
            if (fieldName.Equals("ProductId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("AttributeSetInstanceId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private SkuId _value = new SkuId();

		public SkuIdFlattenedDto()
		{
		}

		public SkuIdFlattenedDto(SkuId val)
		{
			this._value = val;
		}

        public SkuId ToSkuId()
        {
            return this._value;
        }


		public virtual string ProductId { 
			get { return _value.ProductId; } 
			set { _value.ProductId = value; } 
		}

		public virtual string AttributeSetInstanceId { 
			get { return _value.AttributeSetInstanceId; } 
			set { _value.AttributeSetInstanceId = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			SkuIdFlattenedDto other = obj as SkuIdFlattenedDto;
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

