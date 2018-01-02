﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentReceiptMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentReceiptMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentReceiptMvo
{

	public class ShipmentReceiptMvoStateEventIdDtoWrapper : ShipmentReceiptMvoStateEventIdDto
	{

        private ShipmentReceiptMvoStateEventId _value = new ShipmentReceiptMvoStateEventId();

		public ShipmentReceiptMvoStateEventIdDtoWrapper()
		{
		}

		public ShipmentReceiptMvoStateEventIdDtoWrapper(ShipmentReceiptMvoStateEventId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override ShipmentReceiptMvoStateEventId ToShipmentReceiptMvoStateEventId()
        {
            return this._value;
        }

		public override ShipmentReceiptIdDto ShipmentReceiptId { 
			get { return new ShipmentReceiptIdDtoWrapper(_value.ShipmentReceiptId); } 
			set { _value.ShipmentReceiptId = value.ToShipmentReceiptId(); } 
		}

		public override long ShipmentVersion { 
			get { return _value.ShipmentVersion; } 
			set { _value.ShipmentVersion = value; } 
		}


	}

}


