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

    public class OrderItemShipGroupAssociationMvoStateEventDtoConverter
    {
        public virtual OrderItemShipGroupAssociationMvoStateCreatedOrMergePatchedOrDeletedDto ToOrderItemShipGroupAssociationMvoStateEventDto(IOrderItemShipGroupAssociationMvoEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IOrderItemShipGroupAssociationMvoStateCreated)stateEvent;
                return ToOrderItemShipGroupAssociationMvoStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IOrderItemShipGroupAssociationMvoStateMergePatched)stateEvent;
                return ToOrderItemShipGroupAssociationMvoStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Deleted)
            {
                var e = (IOrderItemShipGroupAssociationMvoStateDeleted)stateEvent;
                return ToOrderItemShipGroupAssociationMvoStateDeletedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual OrderItemShipGroupAssociationMvoStateCreatedDto ToOrderItemShipGroupAssociationMvoStateCreatedDto(IOrderItemShipGroupAssociationMvoStateCreated e)
        {
            var dto = new OrderItemShipGroupAssociationMvoStateCreatedDto();
            dto.OrderItemShipGroupAssociationMvoEventId = e.OrderItemShipGroupAssociationMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Quantity = e.Quantity;
            dto.CancelQuantity = e.CancelQuantity;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.OrderShipGroupShipmentMethodTypeId = e.OrderShipGroupShipmentMethodTypeId;
            dto.OrderShipGroupSupplierPartyId = e.OrderShipGroupSupplierPartyId;
            dto.OrderShipGroupVendorPartyId = e.OrderShipGroupVendorPartyId;
            dto.OrderShipGroupCarrierPartyId = e.OrderShipGroupCarrierPartyId;
            dto.OrderShipGroupCarrierRoleTypeId = e.OrderShipGroupCarrierRoleTypeId;
            dto.OrderShipGroupFacilityId = e.OrderShipGroupFacilityId;
            dto.OrderShipGroupContactMechId = e.OrderShipGroupContactMechId;
            dto.OrderShipGroupTelecomContactMechId = e.OrderShipGroupTelecomContactMechId;
            dto.OrderShipGroupTrackingNumber = e.OrderShipGroupTrackingNumber;
            dto.OrderShipGroupShippingInstructions = e.OrderShipGroupShippingInstructions;
            dto.OrderShipGroupMaySplit = e.OrderShipGroupMaySplit;
            dto.OrderShipGroupGiftMessage = e.OrderShipGroupGiftMessage;
            dto.OrderShipGroupIsGift = e.OrderShipGroupIsGift;
            dto.OrderShipGroupShipAfterDate = e.OrderShipGroupShipAfterDate;
            dto.OrderShipGroupShipByDate = e.OrderShipGroupShipByDate;
            dto.OrderShipGroupEstimatedShipDate = e.OrderShipGroupEstimatedShipDate;
            dto.OrderShipGroupEstimatedDeliveryDate = e.OrderShipGroupEstimatedDeliveryDate;
            dto.OrderShipGroupPickwaveId = e.OrderShipGroupPickwaveId;
            dto.OrderShipGroupVersion = e.OrderShipGroupVersion;
            dto.OrderShipGroupCreatedBy = e.OrderShipGroupCreatedBy;
            dto.OrderShipGroupCreatedAt = e.OrderShipGroupCreatedAt;
            dto.OrderShipGroupUpdatedBy = e.OrderShipGroupUpdatedBy;
            dto.OrderShipGroupUpdatedAt = e.OrderShipGroupUpdatedAt;
            dto.OrderShipGroupActive = e.OrderShipGroupActive;
            dto.OrderShipGroupDeleted = e.OrderShipGroupDeleted;
            dto.OrderOrderTypeId = e.OrderOrderTypeId;
            dto.OrderOrderName = e.OrderOrderName;
            dto.OrderExternalId = e.OrderExternalId;
            dto.OrderSalesChannelEnumId = e.OrderSalesChannelEnumId;
            dto.OrderOrderDate = e.OrderOrderDate;
            dto.OrderPriority = e.OrderPriority;
            dto.OrderEntryDate = e.OrderEntryDate;
            dto.OrderPickSheetPrintedDate = e.OrderPickSheetPrintedDate;
            dto.OrderStatusId = e.OrderStatusId;
            dto.OrderCurrencyUom = e.OrderCurrencyUom;
            dto.OrderSyncStatusId = e.OrderSyncStatusId;
            dto.OrderBillingAccountId = e.OrderBillingAccountId;
            dto.OrderOriginFacilityId = e.OrderOriginFacilityId;
            dto.OrderWebSiteId = e.OrderWebSiteId;
            dto.OrderProductStoreId = e.OrderProductStoreId;
            dto.OrderTerminalId = e.OrderTerminalId;
            dto.OrderTransactionId = e.OrderTransactionId;
            dto.OrderAutoOrderShoppingListId = e.OrderAutoOrderShoppingListId;
            dto.OrderNeedsInventoryIssuance = e.OrderNeedsInventoryIssuance;
            dto.OrderIsRushOrder = e.OrderIsRushOrder;
            dto.OrderInternalCode = e.OrderInternalCode;
            dto.OrderRemainingSubTotal = e.OrderRemainingSubTotal;
            dto.OrderGrandTotal = e.OrderGrandTotal;
            dto.OrderInvoicePerShipment = e.OrderInvoicePerShipment;
            dto.OrderCreatedBy = e.OrderCreatedBy;
            dto.OrderCreatedAt = e.OrderCreatedAt;
            dto.OrderUpdatedBy = e.OrderUpdatedBy;
            dto.OrderUpdatedAt = e.OrderUpdatedAt;
            dto.OrderActive = e.OrderActive;
            return dto;
        }

        public virtual OrderItemShipGroupAssociationMvoStateMergePatchedDto ToOrderItemShipGroupAssociationMvoStateMergePatchedDto(IOrderItemShipGroupAssociationMvoStateMergePatched e)
        {
            var dto = new OrderItemShipGroupAssociationMvoStateMergePatchedDto();
            dto.OrderItemShipGroupAssociationMvoEventId = e.OrderItemShipGroupAssociationMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.Quantity = e.Quantity;
            dto.CancelQuantity = e.CancelQuantity;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.OrderShipGroupShipmentMethodTypeId = e.OrderShipGroupShipmentMethodTypeId;
            dto.OrderShipGroupSupplierPartyId = e.OrderShipGroupSupplierPartyId;
            dto.OrderShipGroupVendorPartyId = e.OrderShipGroupVendorPartyId;
            dto.OrderShipGroupCarrierPartyId = e.OrderShipGroupCarrierPartyId;
            dto.OrderShipGroupCarrierRoleTypeId = e.OrderShipGroupCarrierRoleTypeId;
            dto.OrderShipGroupFacilityId = e.OrderShipGroupFacilityId;
            dto.OrderShipGroupContactMechId = e.OrderShipGroupContactMechId;
            dto.OrderShipGroupTelecomContactMechId = e.OrderShipGroupTelecomContactMechId;
            dto.OrderShipGroupTrackingNumber = e.OrderShipGroupTrackingNumber;
            dto.OrderShipGroupShippingInstructions = e.OrderShipGroupShippingInstructions;
            dto.OrderShipGroupMaySplit = e.OrderShipGroupMaySplit;
            dto.OrderShipGroupGiftMessage = e.OrderShipGroupGiftMessage;
            dto.OrderShipGroupIsGift = e.OrderShipGroupIsGift;
            dto.OrderShipGroupShipAfterDate = e.OrderShipGroupShipAfterDate;
            dto.OrderShipGroupShipByDate = e.OrderShipGroupShipByDate;
            dto.OrderShipGroupEstimatedShipDate = e.OrderShipGroupEstimatedShipDate;
            dto.OrderShipGroupEstimatedDeliveryDate = e.OrderShipGroupEstimatedDeliveryDate;
            dto.OrderShipGroupPickwaveId = e.OrderShipGroupPickwaveId;
            dto.OrderShipGroupVersion = e.OrderShipGroupVersion;
            dto.OrderShipGroupCreatedBy = e.OrderShipGroupCreatedBy;
            dto.OrderShipGroupCreatedAt = e.OrderShipGroupCreatedAt;
            dto.OrderShipGroupUpdatedBy = e.OrderShipGroupUpdatedBy;
            dto.OrderShipGroupUpdatedAt = e.OrderShipGroupUpdatedAt;
            dto.OrderShipGroupActive = e.OrderShipGroupActive;
            dto.OrderShipGroupDeleted = e.OrderShipGroupDeleted;
            dto.OrderOrderTypeId = e.OrderOrderTypeId;
            dto.OrderOrderName = e.OrderOrderName;
            dto.OrderExternalId = e.OrderExternalId;
            dto.OrderSalesChannelEnumId = e.OrderSalesChannelEnumId;
            dto.OrderOrderDate = e.OrderOrderDate;
            dto.OrderPriority = e.OrderPriority;
            dto.OrderEntryDate = e.OrderEntryDate;
            dto.OrderPickSheetPrintedDate = e.OrderPickSheetPrintedDate;
            dto.OrderStatusId = e.OrderStatusId;
            dto.OrderCurrencyUom = e.OrderCurrencyUom;
            dto.OrderSyncStatusId = e.OrderSyncStatusId;
            dto.OrderBillingAccountId = e.OrderBillingAccountId;
            dto.OrderOriginFacilityId = e.OrderOriginFacilityId;
            dto.OrderWebSiteId = e.OrderWebSiteId;
            dto.OrderProductStoreId = e.OrderProductStoreId;
            dto.OrderTerminalId = e.OrderTerminalId;
            dto.OrderTransactionId = e.OrderTransactionId;
            dto.OrderAutoOrderShoppingListId = e.OrderAutoOrderShoppingListId;
            dto.OrderNeedsInventoryIssuance = e.OrderNeedsInventoryIssuance;
            dto.OrderIsRushOrder = e.OrderIsRushOrder;
            dto.OrderInternalCode = e.OrderInternalCode;
            dto.OrderRemainingSubTotal = e.OrderRemainingSubTotal;
            dto.OrderGrandTotal = e.OrderGrandTotal;
            dto.OrderInvoicePerShipment = e.OrderInvoicePerShipment;
            dto.OrderCreatedBy = e.OrderCreatedBy;
            dto.OrderCreatedAt = e.OrderCreatedAt;
            dto.OrderUpdatedBy = e.OrderUpdatedBy;
            dto.OrderUpdatedAt = e.OrderUpdatedAt;
            dto.OrderActive = e.OrderActive;
            dto.IsPropertyQuantityRemoved = e.IsPropertyQuantityRemoved;
            dto.IsPropertyCancelQuantityRemoved = e.IsPropertyCancelQuantityRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            dto.IsPropertyOrderShipGroupShipmentMethodTypeIdRemoved = e.IsPropertyOrderShipGroupShipmentMethodTypeIdRemoved;
            dto.IsPropertyOrderShipGroupSupplierPartyIdRemoved = e.IsPropertyOrderShipGroupSupplierPartyIdRemoved;
            dto.IsPropertyOrderShipGroupVendorPartyIdRemoved = e.IsPropertyOrderShipGroupVendorPartyIdRemoved;
            dto.IsPropertyOrderShipGroupCarrierPartyIdRemoved = e.IsPropertyOrderShipGroupCarrierPartyIdRemoved;
            dto.IsPropertyOrderShipGroupCarrierRoleTypeIdRemoved = e.IsPropertyOrderShipGroupCarrierRoleTypeIdRemoved;
            dto.IsPropertyOrderShipGroupFacilityIdRemoved = e.IsPropertyOrderShipGroupFacilityIdRemoved;
            dto.IsPropertyOrderShipGroupContactMechIdRemoved = e.IsPropertyOrderShipGroupContactMechIdRemoved;
            dto.IsPropertyOrderShipGroupTelecomContactMechIdRemoved = e.IsPropertyOrderShipGroupTelecomContactMechIdRemoved;
            dto.IsPropertyOrderShipGroupTrackingNumberRemoved = e.IsPropertyOrderShipGroupTrackingNumberRemoved;
            dto.IsPropertyOrderShipGroupShippingInstructionsRemoved = e.IsPropertyOrderShipGroupShippingInstructionsRemoved;
            dto.IsPropertyOrderShipGroupMaySplitRemoved = e.IsPropertyOrderShipGroupMaySplitRemoved;
            dto.IsPropertyOrderShipGroupGiftMessageRemoved = e.IsPropertyOrderShipGroupGiftMessageRemoved;
            dto.IsPropertyOrderShipGroupIsGiftRemoved = e.IsPropertyOrderShipGroupIsGiftRemoved;
            dto.IsPropertyOrderShipGroupShipAfterDateRemoved = e.IsPropertyOrderShipGroupShipAfterDateRemoved;
            dto.IsPropertyOrderShipGroupShipByDateRemoved = e.IsPropertyOrderShipGroupShipByDateRemoved;
            dto.IsPropertyOrderShipGroupEstimatedShipDateRemoved = e.IsPropertyOrderShipGroupEstimatedShipDateRemoved;
            dto.IsPropertyOrderShipGroupEstimatedDeliveryDateRemoved = e.IsPropertyOrderShipGroupEstimatedDeliveryDateRemoved;
            dto.IsPropertyOrderShipGroupPickwaveIdRemoved = e.IsPropertyOrderShipGroupPickwaveIdRemoved;
            dto.IsPropertyOrderShipGroupVersionRemoved = e.IsPropertyOrderShipGroupVersionRemoved;
            dto.IsPropertyOrderShipGroupCreatedByRemoved = e.IsPropertyOrderShipGroupCreatedByRemoved;
            dto.IsPropertyOrderShipGroupCreatedAtRemoved = e.IsPropertyOrderShipGroupCreatedAtRemoved;
            dto.IsPropertyOrderShipGroupUpdatedByRemoved = e.IsPropertyOrderShipGroupUpdatedByRemoved;
            dto.IsPropertyOrderShipGroupUpdatedAtRemoved = e.IsPropertyOrderShipGroupUpdatedAtRemoved;
            dto.IsPropertyOrderShipGroupActiveRemoved = e.IsPropertyOrderShipGroupActiveRemoved;
            dto.IsPropertyOrderShipGroupDeletedRemoved = e.IsPropertyOrderShipGroupDeletedRemoved;
            dto.IsPropertyOrderOrderTypeIdRemoved = e.IsPropertyOrderOrderTypeIdRemoved;
            dto.IsPropertyOrderOrderNameRemoved = e.IsPropertyOrderOrderNameRemoved;
            dto.IsPropertyOrderExternalIdRemoved = e.IsPropertyOrderExternalIdRemoved;
            dto.IsPropertyOrderSalesChannelEnumIdRemoved = e.IsPropertyOrderSalesChannelEnumIdRemoved;
            dto.IsPropertyOrderOrderDateRemoved = e.IsPropertyOrderOrderDateRemoved;
            dto.IsPropertyOrderPriorityRemoved = e.IsPropertyOrderPriorityRemoved;
            dto.IsPropertyOrderEntryDateRemoved = e.IsPropertyOrderEntryDateRemoved;
            dto.IsPropertyOrderPickSheetPrintedDateRemoved = e.IsPropertyOrderPickSheetPrintedDateRemoved;
            dto.IsPropertyOrderStatusIdRemoved = e.IsPropertyOrderStatusIdRemoved;
            dto.IsPropertyOrderCurrencyUomRemoved = e.IsPropertyOrderCurrencyUomRemoved;
            dto.IsPropertyOrderSyncStatusIdRemoved = e.IsPropertyOrderSyncStatusIdRemoved;
            dto.IsPropertyOrderBillingAccountIdRemoved = e.IsPropertyOrderBillingAccountIdRemoved;
            dto.IsPropertyOrderOriginFacilityIdRemoved = e.IsPropertyOrderOriginFacilityIdRemoved;
            dto.IsPropertyOrderWebSiteIdRemoved = e.IsPropertyOrderWebSiteIdRemoved;
            dto.IsPropertyOrderProductStoreIdRemoved = e.IsPropertyOrderProductStoreIdRemoved;
            dto.IsPropertyOrderTerminalIdRemoved = e.IsPropertyOrderTerminalIdRemoved;
            dto.IsPropertyOrderTransactionIdRemoved = e.IsPropertyOrderTransactionIdRemoved;
            dto.IsPropertyOrderAutoOrderShoppingListIdRemoved = e.IsPropertyOrderAutoOrderShoppingListIdRemoved;
            dto.IsPropertyOrderNeedsInventoryIssuanceRemoved = e.IsPropertyOrderNeedsInventoryIssuanceRemoved;
            dto.IsPropertyOrderIsRushOrderRemoved = e.IsPropertyOrderIsRushOrderRemoved;
            dto.IsPropertyOrderInternalCodeRemoved = e.IsPropertyOrderInternalCodeRemoved;
            dto.IsPropertyOrderRemainingSubTotalRemoved = e.IsPropertyOrderRemainingSubTotalRemoved;
            dto.IsPropertyOrderGrandTotalRemoved = e.IsPropertyOrderGrandTotalRemoved;
            dto.IsPropertyOrderInvoicePerShipmentRemoved = e.IsPropertyOrderInvoicePerShipmentRemoved;
            dto.IsPropertyOrderCreatedByRemoved = e.IsPropertyOrderCreatedByRemoved;
            dto.IsPropertyOrderCreatedAtRemoved = e.IsPropertyOrderCreatedAtRemoved;
            dto.IsPropertyOrderUpdatedByRemoved = e.IsPropertyOrderUpdatedByRemoved;
            dto.IsPropertyOrderUpdatedAtRemoved = e.IsPropertyOrderUpdatedAtRemoved;
            dto.IsPropertyOrderActiveRemoved = e.IsPropertyOrderActiveRemoved;

            return dto;
        }


        public virtual OrderItemShipGroupAssociationMvoStateDeletedDto ToOrderItemShipGroupAssociationMvoStateDeletedDto(IOrderItemShipGroupAssociationMvoStateDeleted e)
        {
            var dto = new OrderItemShipGroupAssociationMvoStateDeletedDto();
            dto.OrderItemShipGroupAssociationMvoEventId = e.OrderItemShipGroupAssociationMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

