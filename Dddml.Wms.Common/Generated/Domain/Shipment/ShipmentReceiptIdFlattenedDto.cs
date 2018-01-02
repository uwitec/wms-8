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

	public class ShipmentReceiptIdFlattenedDto : IIdFlattenedDto
	{

        private static string[] _flattenedPropertyNames = new string[] { "ShipmentId", "ReceiptSeqId" };

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
            if (fieldName.Equals("ShipmentId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            if (fieldName.Equals("ReceiptSeqId", StringComparison.InvariantCultureIgnoreCase))
            {
                return typeof(string);
            }

            throw new ArgumentException(String.Format("Unknown fileName: {0}", fieldName));
        }


        private ShipmentReceiptIdDto _value = new ShipmentReceiptIdDto();

		public ShipmentReceiptIdFlattenedDto()
		{
		}

		public ShipmentReceiptIdFlattenedDto(ShipmentReceiptIdDto val)
		{
			this._value = val;
		}

        public ShipmentReceiptIdDto ToShipmentReceiptIdDto()
        {
            return this._value;
        }

		public ShipmentReceiptIdFlattenedDto(ShipmentReceiptId val)
		{
			this._value = new ShipmentReceiptIdDtoWrapper(val);
		}

        public ShipmentReceiptId ToShipmentReceiptId()
        {
            return this._value.ToShipmentReceiptId();
        }

		public virtual string ShipmentId { 
			get { return _value.ShipmentId; } 
			set { _value.ShipmentId = value; } 
		}

		public virtual string ReceiptSeqId { 
			get { return _value.ReceiptSeqId; } 
			set { _value.ReceiptSeqId = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ShipmentReceiptIdFlattenedDto other = obj as ShipmentReceiptIdFlattenedDto;
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

    public class ShipmentReceiptIdFlattenedDtoFormatter : IdFlattenedDtoFormatterBase<ShipmentReceiptIdFlattenedDto>
    {

    }

}


