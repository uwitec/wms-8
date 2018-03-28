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
	public interface IOrderShipGroupStateEvent : IEvent, IStateEventDto, IGlobalIdentity<OrderShipGroupEventId>, ICreated<string>
	{
		OrderShipGroupEventId OrderShipGroupEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		string ShipmentMethodTypeId { get; set; }

		string SupplierPartyId { get; set; }

		string VendorPartyId { get; set; }

		string CarrierPartyId { get; set; }

		string CarrierRoleTypeId { get; set; }

		string FacilityId { get; set; }

		string ContactMechId { get; set; }

		string TelecomContactMechId { get; set; }

		string TrackingNumber { get; set; }

		string ShippingInstructions { get; set; }

		string MaySplit { get; set; }

		string GiftMessage { get; set; }

		string IsGift { get; set; }

		DateTime? ShipAfterDate { get; set; }

		DateTime? ShipByDate { get; set; }

		DateTime? EstimatedShipDate { get; set; }

		DateTime? EstimatedDeliveryDate { get; set; }

		long? PickwaveId { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string OrderId { get; set; }

	}

	public interface IOrderShipGroupStateCreated : IOrderShipGroupStateEvent//, IOrderShipGroupStateProperties
	{
		IEnumerable<IOrderItemShipGroupAssociationStateCreated> OrderItemShipGroupAssociationEvents { get; }
		
		void AddOrderItemShipGroupAssociationEvent(IOrderItemShipGroupAssociationStateCreated e);

		IOrderItemShipGroupAssociationStateCreated NewOrderItemShipGroupAssociationStateCreated(string orderItemSeqId);

	
	}


	public interface IOrderShipGroupStateMergePatched : IOrderShipGroupStateEvent//, IOrderShipGroupStateProperties
	{
		bool IsPropertyShipmentMethodTypeIdRemoved { get; set; }

		bool IsPropertySupplierPartyIdRemoved { get; set; }

		bool IsPropertyVendorPartyIdRemoved { get; set; }

		bool IsPropertyCarrierPartyIdRemoved { get; set; }

		bool IsPropertyCarrierRoleTypeIdRemoved { get; set; }

		bool IsPropertyFacilityIdRemoved { get; set; }

		bool IsPropertyContactMechIdRemoved { get; set; }

		bool IsPropertyTelecomContactMechIdRemoved { get; set; }

		bool IsPropertyTrackingNumberRemoved { get; set; }

		bool IsPropertyShippingInstructionsRemoved { get; set; }

		bool IsPropertyMaySplitRemoved { get; set; }

		bool IsPropertyGiftMessageRemoved { get; set; }

		bool IsPropertyIsGiftRemoved { get; set; }

		bool IsPropertyShipAfterDateRemoved { get; set; }

		bool IsPropertyShipByDateRemoved { get; set; }

		bool IsPropertyEstimatedShipDateRemoved { get; set; }

		bool IsPropertyEstimatedDeliveryDateRemoved { get; set; }

		bool IsPropertyPickwaveIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		IEnumerable<IOrderItemShipGroupAssociationStateEvent> OrderItemShipGroupAssociationEvents { get; }
		
		void AddOrderItemShipGroupAssociationEvent(IOrderItemShipGroupAssociationStateEvent e);

		IOrderItemShipGroupAssociationStateCreated NewOrderItemShipGroupAssociationStateCreated(string orderItemSeqId);

		IOrderItemShipGroupAssociationStateMergePatched NewOrderItemShipGroupAssociationStateMergePatched(string orderItemSeqId);

		IOrderItemShipGroupAssociationStateRemoved NewOrderItemShipGroupAssociationStateRemoved(string orderItemSeqId);


	}

	public interface IOrderShipGroupStateRemoved : IOrderShipGroupStateEvent
	{
		IEnumerable<IOrderItemShipGroupAssociationStateRemoved> OrderItemShipGroupAssociationEvents { get; }
		
		void AddOrderItemShipGroupAssociationEvent(IOrderItemShipGroupAssociationStateRemoved e);
		
		IOrderItemShipGroupAssociationStateRemoved NewOrderItemShipGroupAssociationStateRemoved(string orderItemSeqId);

	}


}

