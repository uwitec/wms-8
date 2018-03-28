﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGroupAssociationMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo
{

	public abstract class OrderItemShipGroupAssociationMvoStateEventBase : IOrderItemShipGroupAssociationMvoStateEvent
	{

		public virtual OrderItemShipGroupAssociationMvoEventId OrderItemShipGroupAssociationMvoEventId { get; set; }

        public virtual OrderItemShipGroupAssociationId OrderItemShipGroupAssociationId
        {
            get { return OrderItemShipGroupAssociationMvoEventId.OrderItemShipGroupAssociationId; }
            set { OrderItemShipGroupAssociationMvoEventId.OrderItemShipGroupAssociationId = value; }
        }

		public virtual decimal? Quantity { get; set; }

		public virtual decimal? CancelQuantity { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string OrderShipGroupShipmentMethodTypeId { get; set; }

		public virtual string OrderShipGroupSupplierPartyId { get; set; }

		public virtual string OrderShipGroupVendorPartyId { get; set; }

		public virtual string OrderShipGroupCarrierPartyId { get; set; }

		public virtual string OrderShipGroupCarrierRoleTypeId { get; set; }

		public virtual string OrderShipGroupFacilityId { get; set; }

		public virtual string OrderShipGroupContactMechId { get; set; }

		public virtual string OrderShipGroupTelecomContactMechId { get; set; }

		public virtual string OrderShipGroupTrackingNumber { get; set; }

		public virtual string OrderShipGroupShippingInstructions { get; set; }

		public virtual string OrderShipGroupMaySplit { get; set; }

		public virtual string OrderShipGroupGiftMessage { get; set; }

		public virtual string OrderShipGroupIsGift { get; set; }

		public virtual DateTime? OrderShipGroupShipAfterDate { get; set; }

		public virtual DateTime? OrderShipGroupShipByDate { get; set; }

		public virtual DateTime? OrderShipGroupEstimatedShipDate { get; set; }

		public virtual DateTime? OrderShipGroupEstimatedDeliveryDate { get; set; }

		public virtual long? OrderShipGroupPickwaveId { get; set; }

		public virtual long? OrderShipGroupVersion { get; set; }

		public virtual string OrderShipGroupCreatedBy { get; set; }

		public virtual DateTime? OrderShipGroupCreatedAt { get; set; }

		public virtual string OrderShipGroupUpdatedBy { get; set; }

		public virtual DateTime? OrderShipGroupUpdatedAt { get; set; }

		public virtual bool? OrderShipGroupActive { get; set; }

		public virtual bool? OrderShipGroupDeleted { get; set; }

		public virtual string OrderOrderTypeId { get; set; }

		public virtual string OrderOrderName { get; set; }

		public virtual string OrderExternalId { get; set; }

		public virtual string OrderSalesChannelEnumId { get; set; }

		public virtual DateTime? OrderOrderDate { get; set; }

		public virtual string OrderPriority { get; set; }

		public virtual DateTime? OrderEntryDate { get; set; }

		public virtual DateTime? OrderPickSheetPrintedDate { get; set; }

		public virtual string OrderStatusId { get; set; }

		public virtual string OrderCurrencyUom { get; set; }

		public virtual string OrderSyncStatusId { get; set; }

		public virtual string OrderBillingAccountId { get; set; }

		public virtual string OrderOriginFacilityId { get; set; }

		public virtual string OrderWebSiteId { get; set; }

		public virtual string OrderProductStoreId { get; set; }

		public virtual string OrderTerminalId { get; set; }

		public virtual string OrderTransactionId { get; set; }

		public virtual string OrderAutoOrderShoppingListId { get; set; }

		public virtual string OrderNeedsInventoryIssuance { get; set; }

		public virtual string OrderIsRushOrder { get; set; }

		public virtual string OrderInternalCode { get; set; }

		public virtual decimal? OrderRemainingSubTotal { get; set; }

		public virtual decimal? OrderGrandTotal { get; set; }

		public virtual string OrderInvoicePerShipment { get; set; }

		public virtual string OrderCreatedBy { get; set; }

		public virtual DateTime? OrderCreatedAt { get; set; }

		public virtual string OrderUpdatedBy { get; set; }

		public virtual DateTime? OrderUpdatedAt { get; set; }

		public virtual bool? OrderActive { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrderItemShipGroupAssociationMvoEventId IGlobalIdentity<OrderItemShipGroupAssociationMvoEventId>.GlobalId {
			get
			{
				return this.OrderItemShipGroupAssociationMvoEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IOrderItemShipGroupAssociationMvoStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected OrderItemShipGroupAssociationMvoStateEventBase()
        {
        }

        protected OrderItemShipGroupAssociationMvoStateEventBase(OrderItemShipGroupAssociationMvoEventId stateEventId)
        {
            this.OrderItemShipGroupAssociationMvoEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class OrderItemShipGroupAssociationMvoStateCreated : OrderItemShipGroupAssociationMvoStateEventBase, IOrderItemShipGroupAssociationMvoStateCreated
	{
		public OrderItemShipGroupAssociationMvoStateCreated () : this(new OrderItemShipGroupAssociationMvoEventId())
		{
		}

		public OrderItemShipGroupAssociationMvoStateCreated (OrderItemShipGroupAssociationMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class OrderItemShipGroupAssociationMvoStateMergePatched : OrderItemShipGroupAssociationMvoStateEventBase, IOrderItemShipGroupAssociationMvoStateMergePatched
	{
		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyCancelQuantityRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupShipmentMethodTypeIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupSupplierPartyIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupVendorPartyIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupCarrierPartyIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupCarrierRoleTypeIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupTelecomContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupTrackingNumberRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupShippingInstructionsRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupMaySplitRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupGiftMessageRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupIsGiftRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupShipAfterDateRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupShipByDateRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupEstimatedShipDateRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupEstimatedDeliveryDateRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupPickwaveIdRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupVersionRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupCreatedByRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupActiveRemoved { get; set; }

		public virtual bool IsPropertyOrderShipGroupDeletedRemoved { get; set; }

		public virtual bool IsPropertyOrderOrderTypeIdRemoved { get; set; }

		public virtual bool IsPropertyOrderOrderNameRemoved { get; set; }

		public virtual bool IsPropertyOrderExternalIdRemoved { get; set; }

		public virtual bool IsPropertyOrderSalesChannelEnumIdRemoved { get; set; }

		public virtual bool IsPropertyOrderOrderDateRemoved { get; set; }

		public virtual bool IsPropertyOrderPriorityRemoved { get; set; }

		public virtual bool IsPropertyOrderEntryDateRemoved { get; set; }

		public virtual bool IsPropertyOrderPickSheetPrintedDateRemoved { get; set; }

		public virtual bool IsPropertyOrderStatusIdRemoved { get; set; }

		public virtual bool IsPropertyOrderCurrencyUomRemoved { get; set; }

		public virtual bool IsPropertyOrderSyncStatusIdRemoved { get; set; }

		public virtual bool IsPropertyOrderBillingAccountIdRemoved { get; set; }

		public virtual bool IsPropertyOrderOriginFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyOrderWebSiteIdRemoved { get; set; }

		public virtual bool IsPropertyOrderProductStoreIdRemoved { get; set; }

		public virtual bool IsPropertyOrderTerminalIdRemoved { get; set; }

		public virtual bool IsPropertyOrderTransactionIdRemoved { get; set; }

		public virtual bool IsPropertyOrderAutoOrderShoppingListIdRemoved { get; set; }

		public virtual bool IsPropertyOrderNeedsInventoryIssuanceRemoved { get; set; }

		public virtual bool IsPropertyOrderIsRushOrderRemoved { get; set; }

		public virtual bool IsPropertyOrderInternalCodeRemoved { get; set; }

		public virtual bool IsPropertyOrderRemainingSubTotalRemoved { get; set; }

		public virtual bool IsPropertyOrderGrandTotalRemoved { get; set; }

		public virtual bool IsPropertyOrderInvoicePerShipmentRemoved { get; set; }

		public virtual bool IsPropertyOrderCreatedByRemoved { get; set; }

		public virtual bool IsPropertyOrderCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyOrderUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyOrderUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyOrderActiveRemoved { get; set; }


		public OrderItemShipGroupAssociationMvoStateMergePatched ()
		{
		}

		public OrderItemShipGroupAssociationMvoStateMergePatched (OrderItemShipGroupAssociationMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class OrderItemShipGroupAssociationMvoStateDeleted : OrderItemShipGroupAssociationMvoStateEventBase, IOrderItemShipGroupAssociationMvoStateDeleted
	{
		public OrderItemShipGroupAssociationMvoStateDeleted ()
		{
		}

		public OrderItemShipGroupAssociationMvoStateDeleted (OrderItemShipGroupAssociationMvoEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

