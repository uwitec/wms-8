﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public interface IOrderShipGroupStateProperties
	{
		long? ShipGroupSeqId { get; set; }

		string ShipmentMethodTypeId { get; set; }

		string SupplierPartyId { get; set; }

		string VendorPartyId { get; set; }

		string CarrierPartyId { get; set; }

		string CarrierRoleTypeId { get; set; }

		string FacilityId { get; set; }

		string ContactMechId { get; set; }

		string TelecomContactMechId { get; set; }

		string TrackingNumber { get; set; }

		string ContactPartyId { get; set; }

		string VehiclePlateNumber { get; set; }

		string ShippingInstructions { get; set; }

		string MaySplit { get; set; }

		string GiftMessage { get; set; }

		string IsGift { get; set; }

		DateTime? ShipAfterDate { get; set; }

		DateTime? ShipByDate { get; set; }

		DateTime? EstimatedShipDate { get; set; }

		DateTime? EstimatedDeliveryDate { get; set; }

		long? PickwaveId { get; set; }

		int NumberOfPackages { get; set; }

		int NumberOfContainers { get; set; }

		int NumberOfPakagesPerContainer { get; set; }

		string OrderShipGroupStatusId { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		// Outer Id:

		string OrderId { get; set; }

	}

}
