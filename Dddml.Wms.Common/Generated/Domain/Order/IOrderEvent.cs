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
	public interface IOrderEvent : IEvent, IEventDto, IGlobalIdentity<OrderEventId>, ICreated<string>
	{
		OrderEventId OrderEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IOrderStateEvent : IOrderEvent
    {
		string OrderTypeId { get; set; }

		string OrderName { get; set; }

		string ExternalId { get; set; }

		string SalesChannelEnumId { get; set; }

		DateTime? OrderDate { get; set; }

		string Priority { get; set; }

		DateTime? EntryDate { get; set; }

		DateTime? PickSheetPrintedDate { get; set; }

		string StatusId { get; set; }

		string CurrencyUom { get; set; }

		string SyncStatusId { get; set; }

		string BillingAccountId { get; set; }

		string OriginFacilityId { get; set; }

		string WebSiteId { get; set; }

		string ProductStoreId { get; set; }

		string TerminalId { get; set; }

		string TransactionId { get; set; }

		string AutoOrderShoppingListId { get; set; }

		string NeedsInventoryIssuance { get; set; }

		string IsRushOrder { get; set; }

		string InternalCode { get; set; }

		decimal? RemainingSubTotal { get; set; }

		decimal? GrandTotal { get; set; }

		string InvoicePerShipment { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IOrderStateCreated : IOrderStateEvent
	{
		IEnumerable<IOrderRoleStateCreated> OrderRoleEvents { get; }
		
		void AddOrderRoleEvent(IOrderRoleStateCreated e);

		IOrderRoleStateCreated NewOrderRoleStateCreated(PartyRoleId partyRoleId);

		IEnumerable<IOrderItemStateCreated> OrderItemEvents { get; }
		
		void AddOrderItemEvent(IOrderItemStateCreated e);

		IOrderItemStateCreated NewOrderItemStateCreated(string orderItemSeqId);

		IEnumerable<IOrderShipGroupStateCreated> OrderShipGroupEvents { get; }
		
		void AddOrderShipGroupEvent(IOrderShipGroupStateCreated e);

		IOrderShipGroupStateCreated NewOrderShipGroupStateCreated(long? shipGroupSeqId);

	
	}


	public interface IOrderStateMergePatched : IOrderStateEvent
	{
		bool IsPropertyOrderTypeIdRemoved { get; set; }

		bool IsPropertyOrderNameRemoved { get; set; }

		bool IsPropertyExternalIdRemoved { get; set; }

		bool IsPropertySalesChannelEnumIdRemoved { get; set; }

		bool IsPropertyOrderDateRemoved { get; set; }

		bool IsPropertyPriorityRemoved { get; set; }

		bool IsPropertyEntryDateRemoved { get; set; }

		bool IsPropertyPickSheetPrintedDateRemoved { get; set; }

		bool IsPropertyStatusIdRemoved { get; set; }

		bool IsPropertyCurrencyUomRemoved { get; set; }

		bool IsPropertySyncStatusIdRemoved { get; set; }

		bool IsPropertyBillingAccountIdRemoved { get; set; }

		bool IsPropertyOriginFacilityIdRemoved { get; set; }

		bool IsPropertyWebSiteIdRemoved { get; set; }

		bool IsPropertyProductStoreIdRemoved { get; set; }

		bool IsPropertyTerminalIdRemoved { get; set; }

		bool IsPropertyTransactionIdRemoved { get; set; }

		bool IsPropertyAutoOrderShoppingListIdRemoved { get; set; }

		bool IsPropertyNeedsInventoryIssuanceRemoved { get; set; }

		bool IsPropertyIsRushOrderRemoved { get; set; }

		bool IsPropertyInternalCodeRemoved { get; set; }

		bool IsPropertyRemainingSubTotalRemoved { get; set; }

		bool IsPropertyGrandTotalRemoved { get; set; }

		bool IsPropertyInvoicePerShipmentRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		IEnumerable<IOrderRoleEvent> OrderRoleEvents { get; }
		
		void AddOrderRoleEvent(IOrderRoleEvent e);

		IOrderRoleStateCreated NewOrderRoleStateCreated(PartyRoleId partyRoleId);

		IOrderRoleStateMergePatched NewOrderRoleStateMergePatched(PartyRoleId partyRoleId);

		IOrderRoleStateRemoved NewOrderRoleStateRemoved(PartyRoleId partyRoleId);

		IEnumerable<IOrderItemEvent> OrderItemEvents { get; }
		
		void AddOrderItemEvent(IOrderItemEvent e);

		IOrderItemStateCreated NewOrderItemStateCreated(string orderItemSeqId);

		IOrderItemStateMergePatched NewOrderItemStateMergePatched(string orderItemSeqId);

		IEnumerable<IOrderShipGroupEvent> OrderShipGroupEvents { get; }
		
		void AddOrderShipGroupEvent(IOrderShipGroupEvent e);

		IOrderShipGroupStateCreated NewOrderShipGroupStateCreated(long? shipGroupSeqId);

		IOrderShipGroupStateMergePatched NewOrderShipGroupStateMergePatched(long? shipGroupSeqId);

		IOrderShipGroupStateRemoved NewOrderShipGroupStateRemoved(long? shipGroupSeqId);


	}


}

