﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItem;

namespace Dddml.Wms.Domain.ShipmentItem
{

	public class ShipmentItemStateEventIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "ShipmentItemIdShipmentId", "ShipmentItemIdShipmentItemSeqId", "Version" };

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
            if (fieldName.Equals("ShipmentItemIdShipmentId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("ShipmentItemIdShipmentItemSeqId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("Version", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(long);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private ShipmentItemStateEventIdDto _value = new ShipmentItemStateEventIdDto();

		public ShipmentItemStateEventIdFlattenedDto()
		{
		}

		public ShipmentItemStateEventIdFlattenedDto(ShipmentItemStateEventIdDto val)
		{
			this._value = val;
		}

        public ShipmentItemStateEventIdDto ToShipmentItemStateEventIdDto()
        {
            return this._value;
        }

		public ShipmentItemStateEventIdFlattenedDto(ShipmentItemStateEventId val)
		{
			this._value = new ShipmentItemStateEventIdDtoWrapper(val);
		}

        public ShipmentItemStateEventId ToShipmentItemStateEventId()
        {
            return this._value.ToShipmentItemStateEventId();
        }

		public virtual string ShipmentItemIdShipmentId {
			get { return _value.ShipmentItemId.ShipmentId; }
			set { _value.ShipmentItemId.ShipmentId = value; }
		}

		public virtual string ShipmentItemIdShipmentItemSeqId {
			get { return _value.ShipmentItemId.ShipmentItemSeqId; }
			set { _value.ShipmentItemId.ShipmentItemSeqId = value; }
		}

		public virtual long Version { 
			get { return _value.Version; } 
			set { _value.Version = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ShipmentItemStateEventIdFlattenedDto other = obj as ShipmentItemStateEventIdFlattenedDto;
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

    public class ShipmentItemStateEventIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<ShipmentItemStateEventIdFlattenedDto>
    {

    }

}


