﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGroupAssociationMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo
{

	public partial class OrderItemShipGroupAssociationMvoState : OrderItemShipGroupAssociationMvoStateProperties, IOrderItemShipGroupAssociationMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		OrderItemShipGroupAssociationId IGlobalIdentity<OrderItemShipGroupAssociationId>.GlobalId
		{
			get
			{
				return this.OrderItemShipGroupAssociationId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.OrderVersion;
			}
		}


		#endregion

        bool IOrderItemShipGroupAssociationMvoState.IsUnsaved
        {
            get { return this.OrderVersion == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public OrderItemShipGroupAssociationMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.OrderItemShipGroupAssociationId = ((IOrderItemShipGroupAssociationMvoStateEvent)events.First()).OrderItemShipGroupAssociationMvoEventId.OrderItemShipGroupAssociationId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.OrderVersion += 1;
                }
            }
        }

        public OrderItemShipGroupAssociationMvoState() : this(false)
        {
        }

        public OrderItemShipGroupAssociationMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IOrderItemShipGroupAssociationMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Quantity = e.Quantity;

			this.CancelQuantity = e.CancelQuantity;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.OrderShipGroupShipmentMethodTypeId = e.OrderShipGroupShipmentMethodTypeId;

			this.OrderShipGroupSupplierPartyId = e.OrderShipGroupSupplierPartyId;

			this.OrderShipGroupVendorPartyId = e.OrderShipGroupVendorPartyId;

			this.OrderShipGroupCarrierPartyId = e.OrderShipGroupCarrierPartyId;

			this.OrderShipGroupCarrierRoleTypeId = e.OrderShipGroupCarrierRoleTypeId;

			this.OrderShipGroupFacilityId = e.OrderShipGroupFacilityId;

			this.OrderShipGroupContactMechId = e.OrderShipGroupContactMechId;

			this.OrderShipGroupTelecomContactMechId = e.OrderShipGroupTelecomContactMechId;

			this.OrderShipGroupTrackingNumber = e.OrderShipGroupTrackingNumber;

			this.OrderShipGroupShippingInstructions = e.OrderShipGroupShippingInstructions;

			this.OrderShipGroupMaySplit = e.OrderShipGroupMaySplit;

			this.OrderShipGroupGiftMessage = e.OrderShipGroupGiftMessage;

			this.OrderShipGroupIsGift = e.OrderShipGroupIsGift;

			this.OrderShipGroupShipAfterDate = e.OrderShipGroupShipAfterDate;

			this.OrderShipGroupShipByDate = e.OrderShipGroupShipByDate;

			this.OrderShipGroupEstimatedShipDate = e.OrderShipGroupEstimatedShipDate;

			this.OrderShipGroupEstimatedDeliveryDate = e.OrderShipGroupEstimatedDeliveryDate;

			this.OrderShipGroupPickwaveId = e.OrderShipGroupPickwaveId;

            this.OrderShipGroupVersion = (e.OrderShipGroupVersion != null && e.OrderShipGroupVersion.HasValue) ? e.OrderShipGroupVersion.Value : default(long);

			this.OrderShipGroupCreatedBy = e.OrderShipGroupCreatedBy;

            this.OrderShipGroupCreatedAt = (e.OrderShipGroupCreatedAt != null && e.OrderShipGroupCreatedAt.HasValue) ? e.OrderShipGroupCreatedAt.Value : default(DateTime);

			this.OrderShipGroupUpdatedBy = e.OrderShipGroupUpdatedBy;

            this.OrderShipGroupUpdatedAt = (e.OrderShipGroupUpdatedAt != null && e.OrderShipGroupUpdatedAt.HasValue) ? e.OrderShipGroupUpdatedAt.Value : default(DateTime);

            this.OrderShipGroupActive = (e.OrderShipGroupActive != null && e.OrderShipGroupActive.HasValue) ? e.OrderShipGroupActive.Value : default(bool);

            this.OrderShipGroupDeleted = (e.OrderShipGroupDeleted != null && e.OrderShipGroupDeleted.HasValue) ? e.OrderShipGroupDeleted.Value : default(bool);

			this.OrderOrderTypeId = e.OrderOrderTypeId;

			this.OrderOrderName = e.OrderOrderName;

			this.OrderExternalId = e.OrderExternalId;

			this.OrderSalesChannelEnumId = e.OrderSalesChannelEnumId;

			this.OrderOrderDate = e.OrderOrderDate;

			this.OrderPriority = e.OrderPriority;

			this.OrderEntryDate = e.OrderEntryDate;

			this.OrderPickSheetPrintedDate = e.OrderPickSheetPrintedDate;

			this.OrderStatusId = e.OrderStatusId;

			this.OrderCurrencyUom = e.OrderCurrencyUom;

			this.OrderSyncStatusId = e.OrderSyncStatusId;

			this.OrderBillingAccountId = e.OrderBillingAccountId;

			this.OrderOriginFacilityId = e.OrderOriginFacilityId;

			this.OrderWebSiteId = e.OrderWebSiteId;

			this.OrderProductStoreId = e.OrderProductStoreId;

			this.OrderTerminalId = e.OrderTerminalId;

			this.OrderTransactionId = e.OrderTransactionId;

			this.OrderAutoOrderShoppingListId = e.OrderAutoOrderShoppingListId;

			this.OrderNeedsInventoryIssuance = e.OrderNeedsInventoryIssuance;

			this.OrderIsRushOrder = e.OrderIsRushOrder;

			this.OrderInternalCode = e.OrderInternalCode;

			this.OrderRemainingSubTotal = e.OrderRemainingSubTotal;

			this.OrderGrandTotal = e.OrderGrandTotal;

			this.OrderInvoicePerShipment = e.OrderInvoicePerShipment;

			this.OrderCreatedBy = e.OrderCreatedBy;

            this.OrderCreatedAt = (e.OrderCreatedAt != null && e.OrderCreatedAt.HasValue) ? e.OrderCreatedAt.Value : default(DateTime);

			this.OrderUpdatedBy = e.OrderUpdatedBy;

            this.OrderUpdatedAt = (e.OrderUpdatedAt != null && e.OrderUpdatedAt.HasValue) ? e.OrderUpdatedAt.Value : default(DateTime);

            this.OrderActive = (e.OrderActive != null && e.OrderActive.HasValue) ? e.OrderActive.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IOrderItemShipGroupAssociationMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Quantity == null)
			{
				if (e.IsPropertyQuantityRemoved)
				{
					this.Quantity = default(decimal?);
				}
			}
			else
			{
				this.Quantity = e.Quantity;
			}

			if (e.CancelQuantity == null)
			{
				if (e.IsPropertyCancelQuantityRemoved)
				{
					this.CancelQuantity = default(decimal?);
				}
			}
			else
			{
				this.CancelQuantity = e.CancelQuantity;
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}

			if (e.OrderShipGroupShipmentMethodTypeId == null)
			{
				if (e.IsPropertyOrderShipGroupShipmentMethodTypeIdRemoved)
				{
					this.OrderShipGroupShipmentMethodTypeId = default(string);
				}
			}
			else
			{
				this.OrderShipGroupShipmentMethodTypeId = e.OrderShipGroupShipmentMethodTypeId;
			}

			if (e.OrderShipGroupSupplierPartyId == null)
			{
				if (e.IsPropertyOrderShipGroupSupplierPartyIdRemoved)
				{
					this.OrderShipGroupSupplierPartyId = default(string);
				}
			}
			else
			{
				this.OrderShipGroupSupplierPartyId = e.OrderShipGroupSupplierPartyId;
			}

			if (e.OrderShipGroupVendorPartyId == null)
			{
				if (e.IsPropertyOrderShipGroupVendorPartyIdRemoved)
				{
					this.OrderShipGroupVendorPartyId = default(string);
				}
			}
			else
			{
				this.OrderShipGroupVendorPartyId = e.OrderShipGroupVendorPartyId;
			}

			if (e.OrderShipGroupCarrierPartyId == null)
			{
				if (e.IsPropertyOrderShipGroupCarrierPartyIdRemoved)
				{
					this.OrderShipGroupCarrierPartyId = default(string);
				}
			}
			else
			{
				this.OrderShipGroupCarrierPartyId = e.OrderShipGroupCarrierPartyId;
			}

			if (e.OrderShipGroupCarrierRoleTypeId == null)
			{
				if (e.IsPropertyOrderShipGroupCarrierRoleTypeIdRemoved)
				{
					this.OrderShipGroupCarrierRoleTypeId = default(string);
				}
			}
			else
			{
				this.OrderShipGroupCarrierRoleTypeId = e.OrderShipGroupCarrierRoleTypeId;
			}

			if (e.OrderShipGroupFacilityId == null)
			{
				if (e.IsPropertyOrderShipGroupFacilityIdRemoved)
				{
					this.OrderShipGroupFacilityId = default(string);
				}
			}
			else
			{
				this.OrderShipGroupFacilityId = e.OrderShipGroupFacilityId;
			}

			if (e.OrderShipGroupContactMechId == null)
			{
				if (e.IsPropertyOrderShipGroupContactMechIdRemoved)
				{
					this.OrderShipGroupContactMechId = default(string);
				}
			}
			else
			{
				this.OrderShipGroupContactMechId = e.OrderShipGroupContactMechId;
			}

			if (e.OrderShipGroupTelecomContactMechId == null)
			{
				if (e.IsPropertyOrderShipGroupTelecomContactMechIdRemoved)
				{
					this.OrderShipGroupTelecomContactMechId = default(string);
				}
			}
			else
			{
				this.OrderShipGroupTelecomContactMechId = e.OrderShipGroupTelecomContactMechId;
			}

			if (e.OrderShipGroupTrackingNumber == null)
			{
				if (e.IsPropertyOrderShipGroupTrackingNumberRemoved)
				{
					this.OrderShipGroupTrackingNumber = default(string);
				}
			}
			else
			{
				this.OrderShipGroupTrackingNumber = e.OrderShipGroupTrackingNumber;
			}

			if (e.OrderShipGroupShippingInstructions == null)
			{
				if (e.IsPropertyOrderShipGroupShippingInstructionsRemoved)
				{
					this.OrderShipGroupShippingInstructions = default(string);
				}
			}
			else
			{
				this.OrderShipGroupShippingInstructions = e.OrderShipGroupShippingInstructions;
			}

			if (e.OrderShipGroupMaySplit == null)
			{
				if (e.IsPropertyOrderShipGroupMaySplitRemoved)
				{
					this.OrderShipGroupMaySplit = default(string);
				}
			}
			else
			{
				this.OrderShipGroupMaySplit = e.OrderShipGroupMaySplit;
			}

			if (e.OrderShipGroupGiftMessage == null)
			{
				if (e.IsPropertyOrderShipGroupGiftMessageRemoved)
				{
					this.OrderShipGroupGiftMessage = default(string);
				}
			}
			else
			{
				this.OrderShipGroupGiftMessage = e.OrderShipGroupGiftMessage;
			}

			if (e.OrderShipGroupIsGift == null)
			{
				if (e.IsPropertyOrderShipGroupIsGiftRemoved)
				{
					this.OrderShipGroupIsGift = default(string);
				}
			}
			else
			{
				this.OrderShipGroupIsGift = e.OrderShipGroupIsGift;
			}

			if (e.OrderShipGroupShipAfterDate == null)
			{
				if (e.IsPropertyOrderShipGroupShipAfterDateRemoved)
				{
					this.OrderShipGroupShipAfterDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderShipGroupShipAfterDate = e.OrderShipGroupShipAfterDate;
			}

			if (e.OrderShipGroupShipByDate == null)
			{
				if (e.IsPropertyOrderShipGroupShipByDateRemoved)
				{
					this.OrderShipGroupShipByDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderShipGroupShipByDate = e.OrderShipGroupShipByDate;
			}

			if (e.OrderShipGroupEstimatedShipDate == null)
			{
				if (e.IsPropertyOrderShipGroupEstimatedShipDateRemoved)
				{
					this.OrderShipGroupEstimatedShipDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderShipGroupEstimatedShipDate = e.OrderShipGroupEstimatedShipDate;
			}

			if (e.OrderShipGroupEstimatedDeliveryDate == null)
			{
				if (e.IsPropertyOrderShipGroupEstimatedDeliveryDateRemoved)
				{
					this.OrderShipGroupEstimatedDeliveryDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderShipGroupEstimatedDeliveryDate = e.OrderShipGroupEstimatedDeliveryDate;
			}

			if (e.OrderShipGroupPickwaveId == null)
			{
				if (e.IsPropertyOrderShipGroupPickwaveIdRemoved)
				{
					this.OrderShipGroupPickwaveId = default(long?);
				}
			}
			else
			{
				this.OrderShipGroupPickwaveId = e.OrderShipGroupPickwaveId;
			}

			if (e.OrderShipGroupVersion == null)
			{
				if (e.IsPropertyOrderShipGroupVersionRemoved)
				{
					this.OrderShipGroupVersion = default(long);
				}
			}
			else
			{
				this.OrderShipGroupVersion = (e.OrderShipGroupVersion != null && e.OrderShipGroupVersion.HasValue) ? e.OrderShipGroupVersion.Value : default(long);
			}

			if (e.OrderShipGroupCreatedBy == null)
			{
				if (e.IsPropertyOrderShipGroupCreatedByRemoved)
				{
					this.OrderShipGroupCreatedBy = default(string);
				}
			}
			else
			{
				this.OrderShipGroupCreatedBy = e.OrderShipGroupCreatedBy;
			}

			if (e.OrderShipGroupCreatedAt == null)
			{
				if (e.IsPropertyOrderShipGroupCreatedAtRemoved)
				{
					this.OrderShipGroupCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.OrderShipGroupCreatedAt = (e.OrderShipGroupCreatedAt != null && e.OrderShipGroupCreatedAt.HasValue) ? e.OrderShipGroupCreatedAt.Value : default(DateTime);
			}

			if (e.OrderShipGroupUpdatedBy == null)
			{
				if (e.IsPropertyOrderShipGroupUpdatedByRemoved)
				{
					this.OrderShipGroupUpdatedBy = default(string);
				}
			}
			else
			{
				this.OrderShipGroupUpdatedBy = e.OrderShipGroupUpdatedBy;
			}

			if (e.OrderShipGroupUpdatedAt == null)
			{
				if (e.IsPropertyOrderShipGroupUpdatedAtRemoved)
				{
					this.OrderShipGroupUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.OrderShipGroupUpdatedAt = (e.OrderShipGroupUpdatedAt != null && e.OrderShipGroupUpdatedAt.HasValue) ? e.OrderShipGroupUpdatedAt.Value : default(DateTime);
			}

			if (e.OrderShipGroupActive == null)
			{
				if (e.IsPropertyOrderShipGroupActiveRemoved)
				{
					this.OrderShipGroupActive = default(bool);
				}
			}
			else
			{
				this.OrderShipGroupActive = (e.OrderShipGroupActive != null && e.OrderShipGroupActive.HasValue) ? e.OrderShipGroupActive.Value : default(bool);
			}

			if (e.OrderShipGroupDeleted == null)
			{
				if (e.IsPropertyOrderShipGroupDeletedRemoved)
				{
					this.OrderShipGroupDeleted = default(bool);
				}
			}
			else
			{
				this.OrderShipGroupDeleted = (e.OrderShipGroupDeleted != null && e.OrderShipGroupDeleted.HasValue) ? e.OrderShipGroupDeleted.Value : default(bool);
			}

			if (e.OrderOrderTypeId == null)
			{
				if (e.IsPropertyOrderOrderTypeIdRemoved)
				{
					this.OrderOrderTypeId = default(string);
				}
			}
			else
			{
				this.OrderOrderTypeId = e.OrderOrderTypeId;
			}

			if (e.OrderOrderName == null)
			{
				if (e.IsPropertyOrderOrderNameRemoved)
				{
					this.OrderOrderName = default(string);
				}
			}
			else
			{
				this.OrderOrderName = e.OrderOrderName;
			}

			if (e.OrderExternalId == null)
			{
				if (e.IsPropertyOrderExternalIdRemoved)
				{
					this.OrderExternalId = default(string);
				}
			}
			else
			{
				this.OrderExternalId = e.OrderExternalId;
			}

			if (e.OrderSalesChannelEnumId == null)
			{
				if (e.IsPropertyOrderSalesChannelEnumIdRemoved)
				{
					this.OrderSalesChannelEnumId = default(string);
				}
			}
			else
			{
				this.OrderSalesChannelEnumId = e.OrderSalesChannelEnumId;
			}

			if (e.OrderOrderDate == null)
			{
				if (e.IsPropertyOrderOrderDateRemoved)
				{
					this.OrderOrderDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderOrderDate = e.OrderOrderDate;
			}

			if (e.OrderPriority == null)
			{
				if (e.IsPropertyOrderPriorityRemoved)
				{
					this.OrderPriority = default(string);
				}
			}
			else
			{
				this.OrderPriority = e.OrderPriority;
			}

			if (e.OrderEntryDate == null)
			{
				if (e.IsPropertyOrderEntryDateRemoved)
				{
					this.OrderEntryDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderEntryDate = e.OrderEntryDate;
			}

			if (e.OrderPickSheetPrintedDate == null)
			{
				if (e.IsPropertyOrderPickSheetPrintedDateRemoved)
				{
					this.OrderPickSheetPrintedDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderPickSheetPrintedDate = e.OrderPickSheetPrintedDate;
			}

			if (e.OrderStatusId == null)
			{
				if (e.IsPropertyOrderStatusIdRemoved)
				{
					this.OrderStatusId = default(string);
				}
			}
			else
			{
				this.OrderStatusId = e.OrderStatusId;
			}

			if (e.OrderCurrencyUom == null)
			{
				if (e.IsPropertyOrderCurrencyUomRemoved)
				{
					this.OrderCurrencyUom = default(string);
				}
			}
			else
			{
				this.OrderCurrencyUom = e.OrderCurrencyUom;
			}

			if (e.OrderSyncStatusId == null)
			{
				if (e.IsPropertyOrderSyncStatusIdRemoved)
				{
					this.OrderSyncStatusId = default(string);
				}
			}
			else
			{
				this.OrderSyncStatusId = e.OrderSyncStatusId;
			}

			if (e.OrderBillingAccountId == null)
			{
				if (e.IsPropertyOrderBillingAccountIdRemoved)
				{
					this.OrderBillingAccountId = default(string);
				}
			}
			else
			{
				this.OrderBillingAccountId = e.OrderBillingAccountId;
			}

			if (e.OrderOriginFacilityId == null)
			{
				if (e.IsPropertyOrderOriginFacilityIdRemoved)
				{
					this.OrderOriginFacilityId = default(string);
				}
			}
			else
			{
				this.OrderOriginFacilityId = e.OrderOriginFacilityId;
			}

			if (e.OrderWebSiteId == null)
			{
				if (e.IsPropertyOrderWebSiteIdRemoved)
				{
					this.OrderWebSiteId = default(string);
				}
			}
			else
			{
				this.OrderWebSiteId = e.OrderWebSiteId;
			}

			if (e.OrderProductStoreId == null)
			{
				if (e.IsPropertyOrderProductStoreIdRemoved)
				{
					this.OrderProductStoreId = default(string);
				}
			}
			else
			{
				this.OrderProductStoreId = e.OrderProductStoreId;
			}

			if (e.OrderTerminalId == null)
			{
				if (e.IsPropertyOrderTerminalIdRemoved)
				{
					this.OrderTerminalId = default(string);
				}
			}
			else
			{
				this.OrderTerminalId = e.OrderTerminalId;
			}

			if (e.OrderTransactionId == null)
			{
				if (e.IsPropertyOrderTransactionIdRemoved)
				{
					this.OrderTransactionId = default(string);
				}
			}
			else
			{
				this.OrderTransactionId = e.OrderTransactionId;
			}

			if (e.OrderAutoOrderShoppingListId == null)
			{
				if (e.IsPropertyOrderAutoOrderShoppingListIdRemoved)
				{
					this.OrderAutoOrderShoppingListId = default(string);
				}
			}
			else
			{
				this.OrderAutoOrderShoppingListId = e.OrderAutoOrderShoppingListId;
			}

			if (e.OrderNeedsInventoryIssuance == null)
			{
				if (e.IsPropertyOrderNeedsInventoryIssuanceRemoved)
				{
					this.OrderNeedsInventoryIssuance = default(string);
				}
			}
			else
			{
				this.OrderNeedsInventoryIssuance = e.OrderNeedsInventoryIssuance;
			}

			if (e.OrderIsRushOrder == null)
			{
				if (e.IsPropertyOrderIsRushOrderRemoved)
				{
					this.OrderIsRushOrder = default(string);
				}
			}
			else
			{
				this.OrderIsRushOrder = e.OrderIsRushOrder;
			}

			if (e.OrderInternalCode == null)
			{
				if (e.IsPropertyOrderInternalCodeRemoved)
				{
					this.OrderInternalCode = default(string);
				}
			}
			else
			{
				this.OrderInternalCode = e.OrderInternalCode;
			}

			if (e.OrderRemainingSubTotal == null)
			{
				if (e.IsPropertyOrderRemainingSubTotalRemoved)
				{
					this.OrderRemainingSubTotal = default(decimal?);
				}
			}
			else
			{
				this.OrderRemainingSubTotal = e.OrderRemainingSubTotal;
			}

			if (e.OrderGrandTotal == null)
			{
				if (e.IsPropertyOrderGrandTotalRemoved)
				{
					this.OrderGrandTotal = default(decimal?);
				}
			}
			else
			{
				this.OrderGrandTotal = e.OrderGrandTotal;
			}

			if (e.OrderInvoicePerShipment == null)
			{
				if (e.IsPropertyOrderInvoicePerShipmentRemoved)
				{
					this.OrderInvoicePerShipment = default(string);
				}
			}
			else
			{
				this.OrderInvoicePerShipment = e.OrderInvoicePerShipment;
			}

			if (e.OrderCreatedBy == null)
			{
				if (e.IsPropertyOrderCreatedByRemoved)
				{
					this.OrderCreatedBy = default(string);
				}
			}
			else
			{
				this.OrderCreatedBy = e.OrderCreatedBy;
			}

			if (e.OrderCreatedAt == null)
			{
				if (e.IsPropertyOrderCreatedAtRemoved)
				{
					this.OrderCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.OrderCreatedAt = (e.OrderCreatedAt != null && e.OrderCreatedAt.HasValue) ? e.OrderCreatedAt.Value : default(DateTime);
			}

			if (e.OrderUpdatedBy == null)
			{
				if (e.IsPropertyOrderUpdatedByRemoved)
				{
					this.OrderUpdatedBy = default(string);
				}
			}
			else
			{
				this.OrderUpdatedBy = e.OrderUpdatedBy;
			}

			if (e.OrderUpdatedAt == null)
			{
				if (e.IsPropertyOrderUpdatedAtRemoved)
				{
					this.OrderUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.OrderUpdatedAt = (e.OrderUpdatedAt != null && e.OrderUpdatedAt.HasValue) ? e.OrderUpdatedAt.Value : default(DateTime);
			}

			if (e.OrderActive == null)
			{
				if (e.IsPropertyOrderActiveRemoved)
				{
					this.OrderActive = default(bool);
				}
			}
			else
			{
				this.OrderActive = (e.OrderActive != null && e.OrderActive.HasValue) ? e.OrderActive.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IOrderItemShipGroupAssociationMvoStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IOrderItemShipGroupAssociationMvoStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("OrderItemShipGroupAssociationMvo|");

            var stateEntityId = this.OrderItemShipGroupAssociationId; // Aggregate Id
            var eventEntityId = stateEvent.OrderItemShipGroupAssociationMvoEventId.OrderItemShipGroupAssociationId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.OrderVersion;
            var eventVersion = stateEvent.OrderItemShipGroupAssociationMvoEventId.OrderVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

