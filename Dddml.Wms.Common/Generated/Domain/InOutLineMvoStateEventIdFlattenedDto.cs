﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

	public class InOutLineMvoStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "InOutLineIdInOutDocumentNumber", "InOutLineIdSkuIdProductId", "InOutLineIdSkuIdAttributeSetInstanceId", "InOutVersion" };

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
            if (fieldName.Equals("InOutLineIdInOutDocumentNumber", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("InOutLineIdSkuIdProductId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("InOutLineIdSkuIdAttributeSetInstanceId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("InOutVersion", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private InOutLineMvoStateEventId _value = new InOutLineMvoStateEventId();

		public InOutLineMvoStateEventIdFlattenedDto()
		{
		}

		public InOutLineMvoStateEventIdFlattenedDto(InOutLineMvoStateEventId val)
		{
			this._value = val;
		}

        public InOutLineMvoStateEventId ToInOutLineMvoStateEventId()
        {
            return this._value;
        }


		public virtual string InOutLineIdInOutDocumentNumber {
			get { return _value.InOutLineId.InOutDocumentNumber; }
			set { _value.InOutLineId.InOutDocumentNumber = value; }
		}

		public virtual string InOutLineIdSkuIdProductId {
			get { return _value.InOutLineId.SkuId.ProductId; }
			set { _value.InOutLineId.SkuId.ProductId = value; }
		}

		public virtual string InOutLineIdSkuIdAttributeSetInstanceId {
			get { return _value.InOutLineId.SkuId.AttributeSetInstanceId; }
			set { _value.InOutLineId.SkuId.AttributeSetInstanceId = value; }
		}

		public virtual long InOutVersion { 
			get { return _value.InOutVersion; } 
			set { _value.InOutVersion = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InOutLineMvoStateEventIdFlattenedDto other = obj as InOutLineMvoStateEventIdFlattenedDto;
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


