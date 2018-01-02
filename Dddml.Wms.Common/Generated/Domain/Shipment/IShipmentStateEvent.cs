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
	public interface IShipmentStateEvent : IEvent, IStateEventDto, IGlobalIdentity<ShipmentStateEventId>, ICreated<string>
	{
		ShipmentStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string ShipmentTypeId { get; set; }

		string StatusId { get; set; }

		string PrimaryOrderId { get; set; }

		string PrimaryReturnId { get; set; }

		string PicklistBinId { get; set; }

		DateTime? EstimatedReadyDate { get; set; }

		DateTime? EstimatedShipDate { get; set; }

		string EstimatedShipWorkEffId { get; set; }

		DateTime? EstimatedArrivalDate { get; set; }

		string EstimatedArrivalWorkEffId { get; set; }

		DateTime? LatestCancelDate { get; set; }

		decimal? EstimatedShipCost { get; set; }

		string CurrencyUomId { get; set; }

		string HandlingInstructions { get; set; }

		string OriginFacilityId { get; set; }

		string DestinationFacilityId { get; set; }

		string OriginContactMechId { get; set; }

		string OriginTelecomNumberId { get; set; }

		string DestinationContactMechId { get; set; }

		string DestinationTelecomNumberId { get; set; }

		string PartyIdTo { get; set; }

		string PartyIdFrom { get; set; }

		decimal? AdditionalShippingCharge { get; set; }

		string AddtlShippingChargeDesc { get; set; }

		bool? Active { get; set; }

	}

	public interface IShipmentStateCreated : IShipmentStateEvent//, IShipmentStateProperties
	{
		IEnumerable<IShipmentItemStateCreated> ShipmentItemEvents { get; }
		
		void AddShipmentItemEvent(IShipmentItemStateCreated e);

		IShipmentItemStateCreated NewShipmentItemStateCreated(string shipmentItemSeqId);

		IEnumerable<IShipmentReceiptStateCreated> ShipmentReceiptEvents { get; }
		
		void AddShipmentReceiptEvent(IShipmentReceiptStateCreated e);

		IShipmentReceiptStateCreated NewShipmentReceiptStateCreated(string receiptSeqId);

	
	}


	public interface IShipmentStateMergePatched : IShipmentStateEvent//, IShipmentStateProperties
	{
		bool IsPropertyShipmentTypeIdRemoved { get; set; }

		bool IsPropertyStatusIdRemoved { get; set; }

		bool IsPropertyPrimaryOrderIdRemoved { get; set; }

		bool IsPropertyPrimaryReturnIdRemoved { get; set; }

		bool IsPropertyPicklistBinIdRemoved { get; set; }

		bool IsPropertyEstimatedReadyDateRemoved { get; set; }

		bool IsPropertyEstimatedShipDateRemoved { get; set; }

		bool IsPropertyEstimatedShipWorkEffIdRemoved { get; set; }

		bool IsPropertyEstimatedArrivalDateRemoved { get; set; }

		bool IsPropertyEstimatedArrivalWorkEffIdRemoved { get; set; }

		bool IsPropertyLatestCancelDateRemoved { get; set; }

		bool IsPropertyEstimatedShipCostRemoved { get; set; }

		bool IsPropertyCurrencyUomIdRemoved { get; set; }

		bool IsPropertyHandlingInstructionsRemoved { get; set; }

		bool IsPropertyOriginFacilityIdRemoved { get; set; }

		bool IsPropertyDestinationFacilityIdRemoved { get; set; }

		bool IsPropertyOriginContactMechIdRemoved { get; set; }

		bool IsPropertyOriginTelecomNumberIdRemoved { get; set; }

		bool IsPropertyDestinationContactMechIdRemoved { get; set; }

		bool IsPropertyDestinationTelecomNumberIdRemoved { get; set; }

		bool IsPropertyPartyIdToRemoved { get; set; }

		bool IsPropertyPartyIdFromRemoved { get; set; }

		bool IsPropertyAdditionalShippingChargeRemoved { get; set; }

		bool IsPropertyAddtlShippingChargeDescRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		IEnumerable<IShipmentItemStateEvent> ShipmentItemEvents { get; }
		
		void AddShipmentItemEvent(IShipmentItemStateEvent e);

		IShipmentItemStateCreated NewShipmentItemStateCreated(string shipmentItemSeqId);

		IShipmentItemStateMergePatched NewShipmentItemStateMergePatched(string shipmentItemSeqId);

		IEnumerable<IShipmentReceiptStateEvent> ShipmentReceiptEvents { get; }
		
		void AddShipmentReceiptEvent(IShipmentReceiptStateEvent e);

		IShipmentReceiptStateCreated NewShipmentReceiptStateCreated(string receiptSeqId);

		IShipmentReceiptStateMergePatched NewShipmentReceiptStateMergePatched(string receiptSeqId);


	}


}

