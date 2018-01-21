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

	public interface IShipmentReceiptStateProperties
	{
		string ReceiptSeqId { get; set; }

		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		string ShipmentItemSeqId { get; set; }

		string RejectionReasonId { get; set; }

		string DamageStatusId { get; set; }

		string DamageReasonId { get; set; }

		string ReceivedBy { get; set; }

		DateTime? DatetimeReceived { get; set; }

		string ItemDescription { get; set; }

		decimal? AcceptedQuantity { get; set; }

		decimal? RejectedQuantity { get; set; }

		decimal? DamagedQuantity { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		// Outer Id:

		string ShipmentId { get; set; }

	}

}
