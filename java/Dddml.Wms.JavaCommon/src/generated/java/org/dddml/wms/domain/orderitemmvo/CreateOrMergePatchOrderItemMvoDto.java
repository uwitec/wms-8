package org.dddml.wms.domain.orderitemmvo;

import org.dddml.wms.domain.order.*;
import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchOrderItemMvoDto extends AbstractOrderItemMvoCommandDto
{
    /**
     * Product Id
     */
    private String productId;

    public String getProductId()
    {
        return this.productId;
    }

    public void setProductId(String productId)
    {
        this.productId = productId;
    }

    /**
     * External Product Id
     */
    private String externalProductId;

    public String getExternalProductId()
    {
        return this.externalProductId;
    }

    public void setExternalProductId(String externalProductId)
    {
        this.externalProductId = externalProductId;
    }

    /**
     * Quantity
     */
    private java.math.BigDecimal quantity;

    public java.math.BigDecimal getQuantity()
    {
        return this.quantity;
    }

    public void setQuantity(java.math.BigDecimal quantity)
    {
        this.quantity = quantity;
    }

    /**
     * Cancel Quantity
     */
    private java.math.BigDecimal cancelQuantity;

    public java.math.BigDecimal getCancelQuantity()
    {
        return this.cancelQuantity;
    }

    public void setCancelQuantity(java.math.BigDecimal cancelQuantity)
    {
        this.cancelQuantity = cancelQuantity;
    }

    /**
     * Selected Amount
     */
    private java.math.BigDecimal selectedAmount;

    public java.math.BigDecimal getSelectedAmount()
    {
        return this.selectedAmount;
    }

    public void setSelectedAmount(java.math.BigDecimal selectedAmount)
    {
        this.selectedAmount = selectedAmount;
    }

    /**
     * External Id
     */
    private String externalId;

    public String getExternalId()
    {
        return this.externalId;
    }

    public void setExternalId(String externalId)
    {
        this.externalId = externalId;
    }

    /**
     * Order Item Type Id
     */
    private String orderItemTypeId;

    public String getOrderItemTypeId()
    {
        return this.orderItemTypeId;
    }

    public void setOrderItemTypeId(String orderItemTypeId)
    {
        this.orderItemTypeId = orderItemTypeId;
    }

    /**
     * Order Item Group Seq Id
     */
    private String orderItemGroupSeqId;

    public String getOrderItemGroupSeqId()
    {
        return this.orderItemGroupSeqId;
    }

    public void setOrderItemGroupSeqId(String orderItemGroupSeqId)
    {
        this.orderItemGroupSeqId = orderItemGroupSeqId;
    }

    /**
     * Is Item Group Primary
     */
    private String isItemGroupPrimary;

    public String getIsItemGroupPrimary()
    {
        return this.isItemGroupPrimary;
    }

    public void setIsItemGroupPrimary(String isItemGroupPrimary)
    {
        this.isItemGroupPrimary = isItemGroupPrimary;
    }

    /**
     * From Inventory Item Id
     */
    private String fromInventoryItemId;

    public String getFromInventoryItemId()
    {
        return this.fromInventoryItemId;
    }

    public void setFromInventoryItemId(String fromInventoryItemId)
    {
        this.fromInventoryItemId = fromInventoryItemId;
    }

    /**
     * Is Promo
     */
    private String isPromo;

    public String getIsPromo()
    {
        return this.isPromo;
    }

    public void setIsPromo(String isPromo)
    {
        this.isPromo = isPromo;
    }

    /**
     * Quote Id
     */
    private String quoteId;

    public String getQuoteId()
    {
        return this.quoteId;
    }

    public void setQuoteId(String quoteId)
    {
        this.quoteId = quoteId;
    }

    /**
     * Quote Item Seq Id
     */
    private String quoteItemSeqId;

    public String getQuoteItemSeqId()
    {
        return this.quoteItemSeqId;
    }

    public void setQuoteItemSeqId(String quoteItemSeqId)
    {
        this.quoteItemSeqId = quoteItemSeqId;
    }

    /**
     * Shopping List Id
     */
    private String shoppingListId;

    public String getShoppingListId()
    {
        return this.shoppingListId;
    }

    public void setShoppingListId(String shoppingListId)
    {
        this.shoppingListId = shoppingListId;
    }

    /**
     * Shopping List Item Seq Id
     */
    private String shoppingListItemSeqId;

    public String getShoppingListItemSeqId()
    {
        return this.shoppingListItemSeqId;
    }

    public void setShoppingListItemSeqId(String shoppingListItemSeqId)
    {
        this.shoppingListItemSeqId = shoppingListItemSeqId;
    }

    /**
     * Unit Price
     */
    private java.math.BigDecimal unitPrice;

    public java.math.BigDecimal getUnitPrice()
    {
        return this.unitPrice;
    }

    public void setUnitPrice(java.math.BigDecimal unitPrice)
    {
        this.unitPrice = unitPrice;
    }

    /**
     * Unit List Price
     */
    private java.math.BigDecimal unitListPrice;

    public java.math.BigDecimal getUnitListPrice()
    {
        return this.unitListPrice;
    }

    public void setUnitListPrice(java.math.BigDecimal unitListPrice)
    {
        this.unitListPrice = unitListPrice;
    }

    /**
     * Unit Average Cost
     */
    private java.math.BigDecimal unitAverageCost;

    public java.math.BigDecimal getUnitAverageCost()
    {
        return this.unitAverageCost;
    }

    public void setUnitAverageCost(java.math.BigDecimal unitAverageCost)
    {
        this.unitAverageCost = unitAverageCost;
    }

    /**
     * Unit Recurring Price
     */
    private java.math.BigDecimal unitRecurringPrice;

    public java.math.BigDecimal getUnitRecurringPrice()
    {
        return this.unitRecurringPrice;
    }

    public void setUnitRecurringPrice(java.math.BigDecimal unitRecurringPrice)
    {
        this.unitRecurringPrice = unitRecurringPrice;
    }

    /**
     * Is Modified Price
     */
    private String isModifiedPrice;

    public String getIsModifiedPrice()
    {
        return this.isModifiedPrice;
    }

    public void setIsModifiedPrice(String isModifiedPrice)
    {
        this.isModifiedPrice = isModifiedPrice;
    }

    /**
     * Recurring Freq Uom Id
     */
    private String recurringFreqUomId;

    public String getRecurringFreqUomId()
    {
        return this.recurringFreqUomId;
    }

    public void setRecurringFreqUomId(String recurringFreqUomId)
    {
        this.recurringFreqUomId = recurringFreqUomId;
    }

    /**
     * Item Description
     */
    private String itemDescription;

    public String getItemDescription()
    {
        return this.itemDescription;
    }

    public void setItemDescription(String itemDescription)
    {
        this.itemDescription = itemDescription;
    }

    /**
     * Comments
     */
    private String comments;

    public String getComments()
    {
        return this.comments;
    }

    public void setComments(String comments)
    {
        this.comments = comments;
    }

    /**
     * Corresponding Po Id
     */
    private String correspondingPoId;

    public String getCorrespondingPoId()
    {
        return this.correspondingPoId;
    }

    public void setCorrespondingPoId(String correspondingPoId)
    {
        this.correspondingPoId = correspondingPoId;
    }

    /**
     * Status Id
     */
    private String statusId;

    public String getStatusId()
    {
        return this.statusId;
    }

    public void setStatusId(String statusId)
    {
        this.statusId = statusId;
    }

    /**
     * Sync Status Id
     */
    private String syncStatusId;

    public String getSyncStatusId()
    {
        return this.syncStatusId;
    }

    public void setSyncStatusId(String syncStatusId)
    {
        this.syncStatusId = syncStatusId;
    }

    /**
     * Estimated Ship Date
     */
    private java.sql.Timestamp estimatedShipDate;

    public java.sql.Timestamp getEstimatedShipDate()
    {
        return this.estimatedShipDate;
    }

    public void setEstimatedShipDate(java.sql.Timestamp estimatedShipDate)
    {
        this.estimatedShipDate = estimatedShipDate;
    }

    /**
     * Estimated Delivery Date
     */
    private java.sql.Timestamp estimatedDeliveryDate;

    public java.sql.Timestamp getEstimatedDeliveryDate()
    {
        return this.estimatedDeliveryDate;
    }

    public void setEstimatedDeliveryDate(java.sql.Timestamp estimatedDeliveryDate)
    {
        this.estimatedDeliveryDate = estimatedDeliveryDate;
    }

    /**
     * Auto Cancel Date
     */
    private java.sql.Timestamp autoCancelDate;

    public java.sql.Timestamp getAutoCancelDate()
    {
        return this.autoCancelDate;
    }

    public void setAutoCancelDate(java.sql.Timestamp autoCancelDate)
    {
        this.autoCancelDate = autoCancelDate;
    }

    /**
     * Dont Cancel Set Date
     */
    private java.sql.Timestamp dontCancelSetDate;

    public java.sql.Timestamp getDontCancelSetDate()
    {
        return this.dontCancelSetDate;
    }

    public void setDontCancelSetDate(java.sql.Timestamp dontCancelSetDate)
    {
        this.dontCancelSetDate = dontCancelSetDate;
    }

    /**
     * Dont Cancel Set By
     */
    private String dontCancelSetBy;

    public String getDontCancelSetBy()
    {
        return this.dontCancelSetBy;
    }

    public void setDontCancelSetBy(String dontCancelSetBy)
    {
        this.dontCancelSetBy = dontCancelSetBy;
    }

    /**
     * Ship Before Date
     */
    private java.sql.Timestamp shipBeforeDate;

    public java.sql.Timestamp getShipBeforeDate()
    {
        return this.shipBeforeDate;
    }

    public void setShipBeforeDate(java.sql.Timestamp shipBeforeDate)
    {
        this.shipBeforeDate = shipBeforeDate;
    }

    /**
     * Ship After Date
     */
    private java.sql.Timestamp shipAfterDate;

    public java.sql.Timestamp getShipAfterDate()
    {
        return this.shipAfterDate;
    }

    public void setShipAfterDate(java.sql.Timestamp shipAfterDate)
    {
        this.shipAfterDate = shipAfterDate;
    }

    /**
     * Used to cancel all orders from suppliers when its in past
     */
    private java.sql.Timestamp cancelBackOrderDate;

    public java.sql.Timestamp getCancelBackOrderDate()
    {
        return this.cancelBackOrderDate;
    }

    public void setCancelBackOrderDate(java.sql.Timestamp cancelBackOrderDate)
    {
        this.cancelBackOrderDate = cancelBackOrderDate;
    }

    /**
     * Used to specify the override or actual glAccountId used for the adjustment, avoids problems if configuration changes after initial posting, etc.
     */
    private String overrideGlAccountId;

    public String getOverrideGlAccountId()
    {
        return this.overrideGlAccountId;
    }

    public void setOverrideGlAccountId(String overrideGlAccountId)
    {
        this.overrideGlAccountId = overrideGlAccountId;
    }

    /**
     * Version
     */
    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    /**
     * Active
     */
    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    /**
     * Order Order Type Id
     */
    private String orderOrderTypeId;

    public String getOrderOrderTypeId()
    {
        return this.orderOrderTypeId;
    }

    public void setOrderOrderTypeId(String orderOrderTypeId)
    {
        this.orderOrderTypeId = orderOrderTypeId;
    }

    /**
     * Order Order Name
     */
    private String orderOrderName;

    public String getOrderOrderName()
    {
        return this.orderOrderName;
    }

    public void setOrderOrderName(String orderOrderName)
    {
        this.orderOrderName = orderOrderName;
    }

    /**
     * Order External Id
     */
    private String orderExternalId;

    public String getOrderExternalId()
    {
        return this.orderExternalId;
    }

    public void setOrderExternalId(String orderExternalId)
    {
        this.orderExternalId = orderExternalId;
    }

    /**
     * Order Sales Channel Enum Id
     */
    private String orderSalesChannelEnumId;

    public String getOrderSalesChannelEnumId()
    {
        return this.orderSalesChannelEnumId;
    }

    public void setOrderSalesChannelEnumId(String orderSalesChannelEnumId)
    {
        this.orderSalesChannelEnumId = orderSalesChannelEnumId;
    }

    /**
     * Order Order Date
     */
    private java.sql.Timestamp orderOrderDate;

    public java.sql.Timestamp getOrderOrderDate()
    {
        return this.orderOrderDate;
    }

    public void setOrderOrderDate(java.sql.Timestamp orderOrderDate)
    {
        this.orderOrderDate = orderOrderDate;
    }

    /**
     * Order Priority
     */
    private String orderPriority;

    public String getOrderPriority()
    {
        return this.orderPriority;
    }

    public void setOrderPriority(String orderPriority)
    {
        this.orderPriority = orderPriority;
    }

    /**
     * Order Entry Date
     */
    private java.sql.Timestamp orderEntryDate;

    public java.sql.Timestamp getOrderEntryDate()
    {
        return this.orderEntryDate;
    }

    public void setOrderEntryDate(java.sql.Timestamp orderEntryDate)
    {
        this.orderEntryDate = orderEntryDate;
    }

    /**
     * This will be set to a date when pick sheet of the order is printed
     */
    private java.sql.Timestamp orderPickSheetPrintedDate;

    public java.sql.Timestamp getOrderPickSheetPrintedDate()
    {
        return this.orderPickSheetPrintedDate;
    }

    public void setOrderPickSheetPrintedDate(java.sql.Timestamp orderPickSheetPrintedDate)
    {
        this.orderPickSheetPrintedDate = orderPickSheetPrintedDate;
    }

    /**
     * Order Status Id
     */
    private String orderStatusId;

    public String getOrderStatusId()
    {
        return this.orderStatusId;
    }

    public void setOrderStatusId(String orderStatusId)
    {
        this.orderStatusId = orderStatusId;
    }

    /**
     * Order Currency Uom
     */
    private String orderCurrencyUom;

    public String getOrderCurrencyUom()
    {
        return this.orderCurrencyUom;
    }

    public void setOrderCurrencyUom(String orderCurrencyUom)
    {
        this.orderCurrencyUom = orderCurrencyUom;
    }

    /**
     * Order Sync Status Id
     */
    private String orderSyncStatusId;

    public String getOrderSyncStatusId()
    {
        return this.orderSyncStatusId;
    }

    public void setOrderSyncStatusId(String orderSyncStatusId)
    {
        this.orderSyncStatusId = orderSyncStatusId;
    }

    /**
     * Order Billing Account Id
     */
    private String orderBillingAccountId;

    public String getOrderBillingAccountId()
    {
        return this.orderBillingAccountId;
    }

    public void setOrderBillingAccountId(String orderBillingAccountId)
    {
        this.orderBillingAccountId = orderBillingAccountId;
    }

    /**
     * Order Origin Facility Id
     */
    private String orderOriginFacilityId;

    public String getOrderOriginFacilityId()
    {
        return this.orderOriginFacilityId;
    }

    public void setOrderOriginFacilityId(String orderOriginFacilityId)
    {
        this.orderOriginFacilityId = orderOriginFacilityId;
    }

    /**
     * Order Web Site Id
     */
    private String orderWebSiteId;

    public String getOrderWebSiteId()
    {
        return this.orderWebSiteId;
    }

    public void setOrderWebSiteId(String orderWebSiteId)
    {
        this.orderWebSiteId = orderWebSiteId;
    }

    /**
     * Order Product Store Id
     */
    private String orderProductStoreId;

    public String getOrderProductStoreId()
    {
        return this.orderProductStoreId;
    }

    public void setOrderProductStoreId(String orderProductStoreId)
    {
        this.orderProductStoreId = orderProductStoreId;
    }

    /**
     * Order Terminal Id
     */
    private String orderTerminalId;

    public String getOrderTerminalId()
    {
        return this.orderTerminalId;
    }

    public void setOrderTerminalId(String orderTerminalId)
    {
        this.orderTerminalId = orderTerminalId;
    }

    /**
     * Order Transaction Id
     */
    private String orderTransactionId;

    public String getOrderTransactionId()
    {
        return this.orderTransactionId;
    }

    public void setOrderTransactionId(String orderTransactionId)
    {
        this.orderTransactionId = orderTransactionId;
    }

    /**
     * Order Auto Order Shopping List Id
     */
    private String orderAutoOrderShoppingListId;

    public String getOrderAutoOrderShoppingListId()
    {
        return this.orderAutoOrderShoppingListId;
    }

    public void setOrderAutoOrderShoppingListId(String orderAutoOrderShoppingListId)
    {
        this.orderAutoOrderShoppingListId = orderAutoOrderShoppingListId;
    }

    /**
     * Order Needs Inventory Issuance
     */
    private String orderNeedsInventoryIssuance;

    public String getOrderNeedsInventoryIssuance()
    {
        return this.orderNeedsInventoryIssuance;
    }

    public void setOrderNeedsInventoryIssuance(String orderNeedsInventoryIssuance)
    {
        this.orderNeedsInventoryIssuance = orderNeedsInventoryIssuance;
    }

    /**
     * Order Is Rush Order
     */
    private String orderIsRushOrder;

    public String getOrderIsRushOrder()
    {
        return this.orderIsRushOrder;
    }

    public void setOrderIsRushOrder(String orderIsRushOrder)
    {
        this.orderIsRushOrder = orderIsRushOrder;
    }

    /**
     * Order Internal Code
     */
    private String orderInternalCode;

    public String getOrderInternalCode()
    {
        return this.orderInternalCode;
    }

    public void setOrderInternalCode(String orderInternalCode)
    {
        this.orderInternalCode = orderInternalCode;
    }

    /**
     * Order Remaining Sub Total
     */
    private java.math.BigDecimal orderRemainingSubTotal;

    public java.math.BigDecimal getOrderRemainingSubTotal()
    {
        return this.orderRemainingSubTotal;
    }

    public void setOrderRemainingSubTotal(java.math.BigDecimal orderRemainingSubTotal)
    {
        this.orderRemainingSubTotal = orderRemainingSubTotal;
    }

    /**
     * Order Grand Total
     */
    private java.math.BigDecimal orderGrandTotal;

    public java.math.BigDecimal getOrderGrandTotal()
    {
        return this.orderGrandTotal;
    }

    public void setOrderGrandTotal(java.math.BigDecimal orderGrandTotal)
    {
        this.orderGrandTotal = orderGrandTotal;
    }

    /**
     * Order Invoice Per Shipment
     */
    private String orderInvoicePerShipment;

    public String getOrderInvoicePerShipment()
    {
        return this.orderInvoicePerShipment;
    }

    public void setOrderInvoicePerShipment(String orderInvoicePerShipment)
    {
        this.orderInvoicePerShipment = orderInvoicePerShipment;
    }

    /**
     * Order Created By
     */
    private String orderCreatedBy;

    public String getOrderCreatedBy()
    {
        return this.orderCreatedBy;
    }

    public void setOrderCreatedBy(String orderCreatedBy)
    {
        this.orderCreatedBy = orderCreatedBy;
    }

    /**
     * Order Created At
     */
    private Date orderCreatedAt;

    public Date getOrderCreatedAt()
    {
        return this.orderCreatedAt;
    }

    public void setOrderCreatedAt(Date orderCreatedAt)
    {
        this.orderCreatedAt = orderCreatedAt;
    }

    /**
     * Order Updated By
     */
    private String orderUpdatedBy;

    public String getOrderUpdatedBy()
    {
        return this.orderUpdatedBy;
    }

    public void setOrderUpdatedBy(String orderUpdatedBy)
    {
        this.orderUpdatedBy = orderUpdatedBy;
    }

    /**
     * Order Updated At
     */
    private Date orderUpdatedAt;

    public Date getOrderUpdatedAt()
    {
        return this.orderUpdatedAt;
    }

    public void setOrderUpdatedAt(Date orderUpdatedAt)
    {
        this.orderUpdatedAt = orderUpdatedAt;
    }

    /**
     * Order Active
     */
    private Boolean orderActive;

    public Boolean getOrderActive()
    {
        return this.orderActive;
    }

    public void setOrderActive(Boolean orderActive)
    {
        this.orderActive = orderActive;
    }

    private Boolean isPropertyProductIdRemoved;

    public Boolean getIsPropertyProductIdRemoved()
    {
        return this.isPropertyProductIdRemoved;
    }

    public void setIsPropertyProductIdRemoved(Boolean removed)
    {
        this.isPropertyProductIdRemoved = removed;
    }

    private Boolean isPropertyExternalProductIdRemoved;

    public Boolean getIsPropertyExternalProductIdRemoved()
    {
        return this.isPropertyExternalProductIdRemoved;
    }

    public void setIsPropertyExternalProductIdRemoved(Boolean removed)
    {
        this.isPropertyExternalProductIdRemoved = removed;
    }

    private Boolean isPropertyQuantityRemoved;

    public Boolean getIsPropertyQuantityRemoved()
    {
        return this.isPropertyQuantityRemoved;
    }

    public void setIsPropertyQuantityRemoved(Boolean removed)
    {
        this.isPropertyQuantityRemoved = removed;
    }

    private Boolean isPropertyCancelQuantityRemoved;

    public Boolean getIsPropertyCancelQuantityRemoved()
    {
        return this.isPropertyCancelQuantityRemoved;
    }

    public void setIsPropertyCancelQuantityRemoved(Boolean removed)
    {
        this.isPropertyCancelQuantityRemoved = removed;
    }

    private Boolean isPropertySelectedAmountRemoved;

    public Boolean getIsPropertySelectedAmountRemoved()
    {
        return this.isPropertySelectedAmountRemoved;
    }

    public void setIsPropertySelectedAmountRemoved(Boolean removed)
    {
        this.isPropertySelectedAmountRemoved = removed;
    }

    private Boolean isPropertyExternalIdRemoved;

    public Boolean getIsPropertyExternalIdRemoved()
    {
        return this.isPropertyExternalIdRemoved;
    }

    public void setIsPropertyExternalIdRemoved(Boolean removed)
    {
        this.isPropertyExternalIdRemoved = removed;
    }

    private Boolean isPropertyOrderItemTypeIdRemoved;

    public Boolean getIsPropertyOrderItemTypeIdRemoved()
    {
        return this.isPropertyOrderItemTypeIdRemoved;
    }

    public void setIsPropertyOrderItemTypeIdRemoved(Boolean removed)
    {
        this.isPropertyOrderItemTypeIdRemoved = removed;
    }

    private Boolean isPropertyOrderItemGroupSeqIdRemoved;

    public Boolean getIsPropertyOrderItemGroupSeqIdRemoved()
    {
        return this.isPropertyOrderItemGroupSeqIdRemoved;
    }

    public void setIsPropertyOrderItemGroupSeqIdRemoved(Boolean removed)
    {
        this.isPropertyOrderItemGroupSeqIdRemoved = removed;
    }

    private Boolean isPropertyIsItemGroupPrimaryRemoved;

    public Boolean getIsPropertyIsItemGroupPrimaryRemoved()
    {
        return this.isPropertyIsItemGroupPrimaryRemoved;
    }

    public void setIsPropertyIsItemGroupPrimaryRemoved(Boolean removed)
    {
        this.isPropertyIsItemGroupPrimaryRemoved = removed;
    }

    private Boolean isPropertyFromInventoryItemIdRemoved;

    public Boolean getIsPropertyFromInventoryItemIdRemoved()
    {
        return this.isPropertyFromInventoryItemIdRemoved;
    }

    public void setIsPropertyFromInventoryItemIdRemoved(Boolean removed)
    {
        this.isPropertyFromInventoryItemIdRemoved = removed;
    }

    private Boolean isPropertyIsPromoRemoved;

    public Boolean getIsPropertyIsPromoRemoved()
    {
        return this.isPropertyIsPromoRemoved;
    }

    public void setIsPropertyIsPromoRemoved(Boolean removed)
    {
        this.isPropertyIsPromoRemoved = removed;
    }

    private Boolean isPropertyQuoteIdRemoved;

    public Boolean getIsPropertyQuoteIdRemoved()
    {
        return this.isPropertyQuoteIdRemoved;
    }

    public void setIsPropertyQuoteIdRemoved(Boolean removed)
    {
        this.isPropertyQuoteIdRemoved = removed;
    }

    private Boolean isPropertyQuoteItemSeqIdRemoved;

    public Boolean getIsPropertyQuoteItemSeqIdRemoved()
    {
        return this.isPropertyQuoteItemSeqIdRemoved;
    }

    public void setIsPropertyQuoteItemSeqIdRemoved(Boolean removed)
    {
        this.isPropertyQuoteItemSeqIdRemoved = removed;
    }

    private Boolean isPropertyShoppingListIdRemoved;

    public Boolean getIsPropertyShoppingListIdRemoved()
    {
        return this.isPropertyShoppingListIdRemoved;
    }

    public void setIsPropertyShoppingListIdRemoved(Boolean removed)
    {
        this.isPropertyShoppingListIdRemoved = removed;
    }

    private Boolean isPropertyShoppingListItemSeqIdRemoved;

    public Boolean getIsPropertyShoppingListItemSeqIdRemoved()
    {
        return this.isPropertyShoppingListItemSeqIdRemoved;
    }

    public void setIsPropertyShoppingListItemSeqIdRemoved(Boolean removed)
    {
        this.isPropertyShoppingListItemSeqIdRemoved = removed;
    }

    private Boolean isPropertyUnitPriceRemoved;

    public Boolean getIsPropertyUnitPriceRemoved()
    {
        return this.isPropertyUnitPriceRemoved;
    }

    public void setIsPropertyUnitPriceRemoved(Boolean removed)
    {
        this.isPropertyUnitPriceRemoved = removed;
    }

    private Boolean isPropertyUnitListPriceRemoved;

    public Boolean getIsPropertyUnitListPriceRemoved()
    {
        return this.isPropertyUnitListPriceRemoved;
    }

    public void setIsPropertyUnitListPriceRemoved(Boolean removed)
    {
        this.isPropertyUnitListPriceRemoved = removed;
    }

    private Boolean isPropertyUnitAverageCostRemoved;

    public Boolean getIsPropertyUnitAverageCostRemoved()
    {
        return this.isPropertyUnitAverageCostRemoved;
    }

    public void setIsPropertyUnitAverageCostRemoved(Boolean removed)
    {
        this.isPropertyUnitAverageCostRemoved = removed;
    }

    private Boolean isPropertyUnitRecurringPriceRemoved;

    public Boolean getIsPropertyUnitRecurringPriceRemoved()
    {
        return this.isPropertyUnitRecurringPriceRemoved;
    }

    public void setIsPropertyUnitRecurringPriceRemoved(Boolean removed)
    {
        this.isPropertyUnitRecurringPriceRemoved = removed;
    }

    private Boolean isPropertyIsModifiedPriceRemoved;

    public Boolean getIsPropertyIsModifiedPriceRemoved()
    {
        return this.isPropertyIsModifiedPriceRemoved;
    }

    public void setIsPropertyIsModifiedPriceRemoved(Boolean removed)
    {
        this.isPropertyIsModifiedPriceRemoved = removed;
    }

    private Boolean isPropertyRecurringFreqUomIdRemoved;

    public Boolean getIsPropertyRecurringFreqUomIdRemoved()
    {
        return this.isPropertyRecurringFreqUomIdRemoved;
    }

    public void setIsPropertyRecurringFreqUomIdRemoved(Boolean removed)
    {
        this.isPropertyRecurringFreqUomIdRemoved = removed;
    }

    private Boolean isPropertyItemDescriptionRemoved;

    public Boolean getIsPropertyItemDescriptionRemoved()
    {
        return this.isPropertyItemDescriptionRemoved;
    }

    public void setIsPropertyItemDescriptionRemoved(Boolean removed)
    {
        this.isPropertyItemDescriptionRemoved = removed;
    }

    private Boolean isPropertyCommentsRemoved;

    public Boolean getIsPropertyCommentsRemoved()
    {
        return this.isPropertyCommentsRemoved;
    }

    public void setIsPropertyCommentsRemoved(Boolean removed)
    {
        this.isPropertyCommentsRemoved = removed;
    }

    private Boolean isPropertyCorrespondingPoIdRemoved;

    public Boolean getIsPropertyCorrespondingPoIdRemoved()
    {
        return this.isPropertyCorrespondingPoIdRemoved;
    }

    public void setIsPropertyCorrespondingPoIdRemoved(Boolean removed)
    {
        this.isPropertyCorrespondingPoIdRemoved = removed;
    }

    private Boolean isPropertyStatusIdRemoved;

    public Boolean getIsPropertyStatusIdRemoved()
    {
        return this.isPropertyStatusIdRemoved;
    }

    public void setIsPropertyStatusIdRemoved(Boolean removed)
    {
        this.isPropertyStatusIdRemoved = removed;
    }

    private Boolean isPropertySyncStatusIdRemoved;

    public Boolean getIsPropertySyncStatusIdRemoved()
    {
        return this.isPropertySyncStatusIdRemoved;
    }

    public void setIsPropertySyncStatusIdRemoved(Boolean removed)
    {
        this.isPropertySyncStatusIdRemoved = removed;
    }

    private Boolean isPropertyEstimatedShipDateRemoved;

    public Boolean getIsPropertyEstimatedShipDateRemoved()
    {
        return this.isPropertyEstimatedShipDateRemoved;
    }

    public void setIsPropertyEstimatedShipDateRemoved(Boolean removed)
    {
        this.isPropertyEstimatedShipDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedDeliveryDateRemoved;

    public Boolean getIsPropertyEstimatedDeliveryDateRemoved()
    {
        return this.isPropertyEstimatedDeliveryDateRemoved;
    }

    public void setIsPropertyEstimatedDeliveryDateRemoved(Boolean removed)
    {
        this.isPropertyEstimatedDeliveryDateRemoved = removed;
    }

    private Boolean isPropertyAutoCancelDateRemoved;

    public Boolean getIsPropertyAutoCancelDateRemoved()
    {
        return this.isPropertyAutoCancelDateRemoved;
    }

    public void setIsPropertyAutoCancelDateRemoved(Boolean removed)
    {
        this.isPropertyAutoCancelDateRemoved = removed;
    }

    private Boolean isPropertyDontCancelSetDateRemoved;

    public Boolean getIsPropertyDontCancelSetDateRemoved()
    {
        return this.isPropertyDontCancelSetDateRemoved;
    }

    public void setIsPropertyDontCancelSetDateRemoved(Boolean removed)
    {
        this.isPropertyDontCancelSetDateRemoved = removed;
    }

    private Boolean isPropertyDontCancelSetByRemoved;

    public Boolean getIsPropertyDontCancelSetByRemoved()
    {
        return this.isPropertyDontCancelSetByRemoved;
    }

    public void setIsPropertyDontCancelSetByRemoved(Boolean removed)
    {
        this.isPropertyDontCancelSetByRemoved = removed;
    }

    private Boolean isPropertyShipBeforeDateRemoved;

    public Boolean getIsPropertyShipBeforeDateRemoved()
    {
        return this.isPropertyShipBeforeDateRemoved;
    }

    public void setIsPropertyShipBeforeDateRemoved(Boolean removed)
    {
        this.isPropertyShipBeforeDateRemoved = removed;
    }

    private Boolean isPropertyShipAfterDateRemoved;

    public Boolean getIsPropertyShipAfterDateRemoved()
    {
        return this.isPropertyShipAfterDateRemoved;
    }

    public void setIsPropertyShipAfterDateRemoved(Boolean removed)
    {
        this.isPropertyShipAfterDateRemoved = removed;
    }

    private Boolean isPropertyCancelBackOrderDateRemoved;

    public Boolean getIsPropertyCancelBackOrderDateRemoved()
    {
        return this.isPropertyCancelBackOrderDateRemoved;
    }

    public void setIsPropertyCancelBackOrderDateRemoved(Boolean removed)
    {
        this.isPropertyCancelBackOrderDateRemoved = removed;
    }

    private Boolean isPropertyOverrideGlAccountIdRemoved;

    public Boolean getIsPropertyOverrideGlAccountIdRemoved()
    {
        return this.isPropertyOverrideGlAccountIdRemoved;
    }

    public void setIsPropertyOverrideGlAccountIdRemoved(Boolean removed)
    {
        this.isPropertyOverrideGlAccountIdRemoved = removed;
    }

    private Boolean isPropertyVersionRemoved;

    public Boolean getIsPropertyVersionRemoved()
    {
        return this.isPropertyVersionRemoved;
    }

    public void setIsPropertyVersionRemoved(Boolean removed)
    {
        this.isPropertyVersionRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved()
    {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed)
    {
        this.isPropertyActiveRemoved = removed;
    }

    private Boolean isPropertyOrderOrderTypeIdRemoved;

    public Boolean getIsPropertyOrderOrderTypeIdRemoved()
    {
        return this.isPropertyOrderOrderTypeIdRemoved;
    }

    public void setIsPropertyOrderOrderTypeIdRemoved(Boolean removed)
    {
        this.isPropertyOrderOrderTypeIdRemoved = removed;
    }

    private Boolean isPropertyOrderOrderNameRemoved;

    public Boolean getIsPropertyOrderOrderNameRemoved()
    {
        return this.isPropertyOrderOrderNameRemoved;
    }

    public void setIsPropertyOrderOrderNameRemoved(Boolean removed)
    {
        this.isPropertyOrderOrderNameRemoved = removed;
    }

    private Boolean isPropertyOrderExternalIdRemoved;

    public Boolean getIsPropertyOrderExternalIdRemoved()
    {
        return this.isPropertyOrderExternalIdRemoved;
    }

    public void setIsPropertyOrderExternalIdRemoved(Boolean removed)
    {
        this.isPropertyOrderExternalIdRemoved = removed;
    }

    private Boolean isPropertyOrderSalesChannelEnumIdRemoved;

    public Boolean getIsPropertyOrderSalesChannelEnumIdRemoved()
    {
        return this.isPropertyOrderSalesChannelEnumIdRemoved;
    }

    public void setIsPropertyOrderSalesChannelEnumIdRemoved(Boolean removed)
    {
        this.isPropertyOrderSalesChannelEnumIdRemoved = removed;
    }

    private Boolean isPropertyOrderOrderDateRemoved;

    public Boolean getIsPropertyOrderOrderDateRemoved()
    {
        return this.isPropertyOrderOrderDateRemoved;
    }

    public void setIsPropertyOrderOrderDateRemoved(Boolean removed)
    {
        this.isPropertyOrderOrderDateRemoved = removed;
    }

    private Boolean isPropertyOrderPriorityRemoved;

    public Boolean getIsPropertyOrderPriorityRemoved()
    {
        return this.isPropertyOrderPriorityRemoved;
    }

    public void setIsPropertyOrderPriorityRemoved(Boolean removed)
    {
        this.isPropertyOrderPriorityRemoved = removed;
    }

    private Boolean isPropertyOrderEntryDateRemoved;

    public Boolean getIsPropertyOrderEntryDateRemoved()
    {
        return this.isPropertyOrderEntryDateRemoved;
    }

    public void setIsPropertyOrderEntryDateRemoved(Boolean removed)
    {
        this.isPropertyOrderEntryDateRemoved = removed;
    }

    private Boolean isPropertyOrderPickSheetPrintedDateRemoved;

    public Boolean getIsPropertyOrderPickSheetPrintedDateRemoved()
    {
        return this.isPropertyOrderPickSheetPrintedDateRemoved;
    }

    public void setIsPropertyOrderPickSheetPrintedDateRemoved(Boolean removed)
    {
        this.isPropertyOrderPickSheetPrintedDateRemoved = removed;
    }

    private Boolean isPropertyOrderStatusIdRemoved;

    public Boolean getIsPropertyOrderStatusIdRemoved()
    {
        return this.isPropertyOrderStatusIdRemoved;
    }

    public void setIsPropertyOrderStatusIdRemoved(Boolean removed)
    {
        this.isPropertyOrderStatusIdRemoved = removed;
    }

    private Boolean isPropertyOrderCurrencyUomRemoved;

    public Boolean getIsPropertyOrderCurrencyUomRemoved()
    {
        return this.isPropertyOrderCurrencyUomRemoved;
    }

    public void setIsPropertyOrderCurrencyUomRemoved(Boolean removed)
    {
        this.isPropertyOrderCurrencyUomRemoved = removed;
    }

    private Boolean isPropertyOrderSyncStatusIdRemoved;

    public Boolean getIsPropertyOrderSyncStatusIdRemoved()
    {
        return this.isPropertyOrderSyncStatusIdRemoved;
    }

    public void setIsPropertyOrderSyncStatusIdRemoved(Boolean removed)
    {
        this.isPropertyOrderSyncStatusIdRemoved = removed;
    }

    private Boolean isPropertyOrderBillingAccountIdRemoved;

    public Boolean getIsPropertyOrderBillingAccountIdRemoved()
    {
        return this.isPropertyOrderBillingAccountIdRemoved;
    }

    public void setIsPropertyOrderBillingAccountIdRemoved(Boolean removed)
    {
        this.isPropertyOrderBillingAccountIdRemoved = removed;
    }

    private Boolean isPropertyOrderOriginFacilityIdRemoved;

    public Boolean getIsPropertyOrderOriginFacilityIdRemoved()
    {
        return this.isPropertyOrderOriginFacilityIdRemoved;
    }

    public void setIsPropertyOrderOriginFacilityIdRemoved(Boolean removed)
    {
        this.isPropertyOrderOriginFacilityIdRemoved = removed;
    }

    private Boolean isPropertyOrderWebSiteIdRemoved;

    public Boolean getIsPropertyOrderWebSiteIdRemoved()
    {
        return this.isPropertyOrderWebSiteIdRemoved;
    }

    public void setIsPropertyOrderWebSiteIdRemoved(Boolean removed)
    {
        this.isPropertyOrderWebSiteIdRemoved = removed;
    }

    private Boolean isPropertyOrderProductStoreIdRemoved;

    public Boolean getIsPropertyOrderProductStoreIdRemoved()
    {
        return this.isPropertyOrderProductStoreIdRemoved;
    }

    public void setIsPropertyOrderProductStoreIdRemoved(Boolean removed)
    {
        this.isPropertyOrderProductStoreIdRemoved = removed;
    }

    private Boolean isPropertyOrderTerminalIdRemoved;

    public Boolean getIsPropertyOrderTerminalIdRemoved()
    {
        return this.isPropertyOrderTerminalIdRemoved;
    }

    public void setIsPropertyOrderTerminalIdRemoved(Boolean removed)
    {
        this.isPropertyOrderTerminalIdRemoved = removed;
    }

    private Boolean isPropertyOrderTransactionIdRemoved;

    public Boolean getIsPropertyOrderTransactionIdRemoved()
    {
        return this.isPropertyOrderTransactionIdRemoved;
    }

    public void setIsPropertyOrderTransactionIdRemoved(Boolean removed)
    {
        this.isPropertyOrderTransactionIdRemoved = removed;
    }

    private Boolean isPropertyOrderAutoOrderShoppingListIdRemoved;

    public Boolean getIsPropertyOrderAutoOrderShoppingListIdRemoved()
    {
        return this.isPropertyOrderAutoOrderShoppingListIdRemoved;
    }

    public void setIsPropertyOrderAutoOrderShoppingListIdRemoved(Boolean removed)
    {
        this.isPropertyOrderAutoOrderShoppingListIdRemoved = removed;
    }

    private Boolean isPropertyOrderNeedsInventoryIssuanceRemoved;

    public Boolean getIsPropertyOrderNeedsInventoryIssuanceRemoved()
    {
        return this.isPropertyOrderNeedsInventoryIssuanceRemoved;
    }

    public void setIsPropertyOrderNeedsInventoryIssuanceRemoved(Boolean removed)
    {
        this.isPropertyOrderNeedsInventoryIssuanceRemoved = removed;
    }

    private Boolean isPropertyOrderIsRushOrderRemoved;

    public Boolean getIsPropertyOrderIsRushOrderRemoved()
    {
        return this.isPropertyOrderIsRushOrderRemoved;
    }

    public void setIsPropertyOrderIsRushOrderRemoved(Boolean removed)
    {
        this.isPropertyOrderIsRushOrderRemoved = removed;
    }

    private Boolean isPropertyOrderInternalCodeRemoved;

    public Boolean getIsPropertyOrderInternalCodeRemoved()
    {
        return this.isPropertyOrderInternalCodeRemoved;
    }

    public void setIsPropertyOrderInternalCodeRemoved(Boolean removed)
    {
        this.isPropertyOrderInternalCodeRemoved = removed;
    }

    private Boolean isPropertyOrderRemainingSubTotalRemoved;

    public Boolean getIsPropertyOrderRemainingSubTotalRemoved()
    {
        return this.isPropertyOrderRemainingSubTotalRemoved;
    }

    public void setIsPropertyOrderRemainingSubTotalRemoved(Boolean removed)
    {
        this.isPropertyOrderRemainingSubTotalRemoved = removed;
    }

    private Boolean isPropertyOrderGrandTotalRemoved;

    public Boolean getIsPropertyOrderGrandTotalRemoved()
    {
        return this.isPropertyOrderGrandTotalRemoved;
    }

    public void setIsPropertyOrderGrandTotalRemoved(Boolean removed)
    {
        this.isPropertyOrderGrandTotalRemoved = removed;
    }

    private Boolean isPropertyOrderInvoicePerShipmentRemoved;

    public Boolean getIsPropertyOrderInvoicePerShipmentRemoved()
    {
        return this.isPropertyOrderInvoicePerShipmentRemoved;
    }

    public void setIsPropertyOrderInvoicePerShipmentRemoved(Boolean removed)
    {
        this.isPropertyOrderInvoicePerShipmentRemoved = removed;
    }

    private Boolean isPropertyOrderCreatedByRemoved;

    public Boolean getIsPropertyOrderCreatedByRemoved()
    {
        return this.isPropertyOrderCreatedByRemoved;
    }

    public void setIsPropertyOrderCreatedByRemoved(Boolean removed)
    {
        this.isPropertyOrderCreatedByRemoved = removed;
    }

    private Boolean isPropertyOrderCreatedAtRemoved;

    public Boolean getIsPropertyOrderCreatedAtRemoved()
    {
        return this.isPropertyOrderCreatedAtRemoved;
    }

    public void setIsPropertyOrderCreatedAtRemoved(Boolean removed)
    {
        this.isPropertyOrderCreatedAtRemoved = removed;
    }

    private Boolean isPropertyOrderUpdatedByRemoved;

    public Boolean getIsPropertyOrderUpdatedByRemoved()
    {
        return this.isPropertyOrderUpdatedByRemoved;
    }

    public void setIsPropertyOrderUpdatedByRemoved(Boolean removed)
    {
        this.isPropertyOrderUpdatedByRemoved = removed;
    }

    private Boolean isPropertyOrderUpdatedAtRemoved;

    public Boolean getIsPropertyOrderUpdatedAtRemoved()
    {
        return this.isPropertyOrderUpdatedAtRemoved;
    }

    public void setIsPropertyOrderUpdatedAtRemoved(Boolean removed)
    {
        this.isPropertyOrderUpdatedAtRemoved = removed;
    }

    private Boolean isPropertyOrderActiveRemoved;

    public Boolean getIsPropertyOrderActiveRemoved()
    {
        return this.isPropertyOrderActiveRemoved;
    }

    public void setIsPropertyOrderActiveRemoved(Boolean removed)
    {
        this.isPropertyOrderActiveRemoved = removed;
    }

    public void copyTo(AbstractOrderItemMvoCommand.AbstractCreateOrMergePatchOrderItemMvo command)
    {
        ((AbstractOrderItemMvoCommandDto) this).copyTo(command);
        command.setProductId(this.getProductId());
        command.setExternalProductId(this.getExternalProductId());
        command.setQuantity(this.getQuantity());
        command.setCancelQuantity(this.getCancelQuantity());
        command.setSelectedAmount(this.getSelectedAmount());
        command.setExternalId(this.getExternalId());
        command.setOrderItemTypeId(this.getOrderItemTypeId());
        command.setOrderItemGroupSeqId(this.getOrderItemGroupSeqId());
        command.setIsItemGroupPrimary(this.getIsItemGroupPrimary());
        command.setFromInventoryItemId(this.getFromInventoryItemId());
        command.setIsPromo(this.getIsPromo());
        command.setQuoteId(this.getQuoteId());
        command.setQuoteItemSeqId(this.getQuoteItemSeqId());
        command.setShoppingListId(this.getShoppingListId());
        command.setShoppingListItemSeqId(this.getShoppingListItemSeqId());
        command.setUnitPrice(this.getUnitPrice());
        command.setUnitListPrice(this.getUnitListPrice());
        command.setUnitAverageCost(this.getUnitAverageCost());
        command.setUnitRecurringPrice(this.getUnitRecurringPrice());
        command.setIsModifiedPrice(this.getIsModifiedPrice());
        command.setRecurringFreqUomId(this.getRecurringFreqUomId());
        command.setItemDescription(this.getItemDescription());
        command.setComments(this.getComments());
        command.setCorrespondingPoId(this.getCorrespondingPoId());
        command.setStatusId(this.getStatusId());
        command.setSyncStatusId(this.getSyncStatusId());
        command.setEstimatedShipDate(this.getEstimatedShipDate());
        command.setEstimatedDeliveryDate(this.getEstimatedDeliveryDate());
        command.setAutoCancelDate(this.getAutoCancelDate());
        command.setDontCancelSetDate(this.getDontCancelSetDate());
        command.setDontCancelSetBy(this.getDontCancelSetBy());
        command.setShipBeforeDate(this.getShipBeforeDate());
        command.setShipAfterDate(this.getShipAfterDate());
        command.setCancelBackOrderDate(this.getCancelBackOrderDate());
        command.setOverrideGlAccountId(this.getOverrideGlAccountId());
        command.setVersion(this.getVersion());
        command.setActive(this.getActive());
        command.setOrderOrderTypeId(this.getOrderOrderTypeId());
        command.setOrderOrderName(this.getOrderOrderName());
        command.setOrderExternalId(this.getOrderExternalId());
        command.setOrderSalesChannelEnumId(this.getOrderSalesChannelEnumId());
        command.setOrderOrderDate(this.getOrderOrderDate());
        command.setOrderPriority(this.getOrderPriority());
        command.setOrderEntryDate(this.getOrderEntryDate());
        command.setOrderPickSheetPrintedDate(this.getOrderPickSheetPrintedDate());
        command.setOrderStatusId(this.getOrderStatusId());
        command.setOrderCurrencyUom(this.getOrderCurrencyUom());
        command.setOrderSyncStatusId(this.getOrderSyncStatusId());
        command.setOrderBillingAccountId(this.getOrderBillingAccountId());
        command.setOrderOriginFacilityId(this.getOrderOriginFacilityId());
        command.setOrderWebSiteId(this.getOrderWebSiteId());
        command.setOrderProductStoreId(this.getOrderProductStoreId());
        command.setOrderTerminalId(this.getOrderTerminalId());
        command.setOrderTransactionId(this.getOrderTransactionId());
        command.setOrderAutoOrderShoppingListId(this.getOrderAutoOrderShoppingListId());
        command.setOrderNeedsInventoryIssuance(this.getOrderNeedsInventoryIssuance());
        command.setOrderIsRushOrder(this.getOrderIsRushOrder());
        command.setOrderInternalCode(this.getOrderInternalCode());
        command.setOrderRemainingSubTotal(this.getOrderRemainingSubTotal());
        command.setOrderGrandTotal(this.getOrderGrandTotal());
        command.setOrderInvoicePerShipment(this.getOrderInvoicePerShipment());
        command.setOrderCreatedBy(this.getOrderCreatedBy());
        command.setOrderCreatedAt(this.getOrderCreatedAt());
        command.setOrderUpdatedBy(this.getOrderUpdatedBy());
        command.setOrderUpdatedAt(this.getOrderUpdatedAt());
        command.setOrderActive(this.getOrderActive());
    }

    public OrderItemMvoCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractOrderItemMvoCommand.SimpleCreateOrderItemMvo command = new AbstractOrderItemMvoCommand.SimpleCreateOrderItemMvo();
            copyTo((AbstractOrderItemMvoCommand.AbstractCreateOrderItemMvo) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractOrderItemMvoCommand.SimpleMergePatchOrderItemMvo command = new AbstractOrderItemMvoCommand.SimpleMergePatchOrderItemMvo();
            copyTo((AbstractOrderItemMvoCommand.SimpleMergePatchOrderItemMvo) command);
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractOrderItemMvoCommand.AbstractCreateOrderItemMvo command)
    {
        copyTo((AbstractOrderItemMvoCommand.AbstractCreateOrMergePatchOrderItemMvo) command);
    }

    public void copyTo(AbstractOrderItemMvoCommand.AbstractMergePatchOrderItemMvo command)
    {
        copyTo((AbstractOrderItemMvoCommand.AbstractCreateOrMergePatchOrderItemMvo) command);
        command.setIsPropertyProductIdRemoved(this.getIsPropertyProductIdRemoved());
        command.setIsPropertyExternalProductIdRemoved(this.getIsPropertyExternalProductIdRemoved());
        command.setIsPropertyQuantityRemoved(this.getIsPropertyQuantityRemoved());
        command.setIsPropertyCancelQuantityRemoved(this.getIsPropertyCancelQuantityRemoved());
        command.setIsPropertySelectedAmountRemoved(this.getIsPropertySelectedAmountRemoved());
        command.setIsPropertyExternalIdRemoved(this.getIsPropertyExternalIdRemoved());
        command.setIsPropertyOrderItemTypeIdRemoved(this.getIsPropertyOrderItemTypeIdRemoved());
        command.setIsPropertyOrderItemGroupSeqIdRemoved(this.getIsPropertyOrderItemGroupSeqIdRemoved());
        command.setIsPropertyIsItemGroupPrimaryRemoved(this.getIsPropertyIsItemGroupPrimaryRemoved());
        command.setIsPropertyFromInventoryItemIdRemoved(this.getIsPropertyFromInventoryItemIdRemoved());
        command.setIsPropertyIsPromoRemoved(this.getIsPropertyIsPromoRemoved());
        command.setIsPropertyQuoteIdRemoved(this.getIsPropertyQuoteIdRemoved());
        command.setIsPropertyQuoteItemSeqIdRemoved(this.getIsPropertyQuoteItemSeqIdRemoved());
        command.setIsPropertyShoppingListIdRemoved(this.getIsPropertyShoppingListIdRemoved());
        command.setIsPropertyShoppingListItemSeqIdRemoved(this.getIsPropertyShoppingListItemSeqIdRemoved());
        command.setIsPropertyUnitPriceRemoved(this.getIsPropertyUnitPriceRemoved());
        command.setIsPropertyUnitListPriceRemoved(this.getIsPropertyUnitListPriceRemoved());
        command.setIsPropertyUnitAverageCostRemoved(this.getIsPropertyUnitAverageCostRemoved());
        command.setIsPropertyUnitRecurringPriceRemoved(this.getIsPropertyUnitRecurringPriceRemoved());
        command.setIsPropertyIsModifiedPriceRemoved(this.getIsPropertyIsModifiedPriceRemoved());
        command.setIsPropertyRecurringFreqUomIdRemoved(this.getIsPropertyRecurringFreqUomIdRemoved());
        command.setIsPropertyItemDescriptionRemoved(this.getIsPropertyItemDescriptionRemoved());
        command.setIsPropertyCommentsRemoved(this.getIsPropertyCommentsRemoved());
        command.setIsPropertyCorrespondingPoIdRemoved(this.getIsPropertyCorrespondingPoIdRemoved());
        command.setIsPropertyStatusIdRemoved(this.getIsPropertyStatusIdRemoved());
        command.setIsPropertySyncStatusIdRemoved(this.getIsPropertySyncStatusIdRemoved());
        command.setIsPropertyEstimatedShipDateRemoved(this.getIsPropertyEstimatedShipDateRemoved());
        command.setIsPropertyEstimatedDeliveryDateRemoved(this.getIsPropertyEstimatedDeliveryDateRemoved());
        command.setIsPropertyAutoCancelDateRemoved(this.getIsPropertyAutoCancelDateRemoved());
        command.setIsPropertyDontCancelSetDateRemoved(this.getIsPropertyDontCancelSetDateRemoved());
        command.setIsPropertyDontCancelSetByRemoved(this.getIsPropertyDontCancelSetByRemoved());
        command.setIsPropertyShipBeforeDateRemoved(this.getIsPropertyShipBeforeDateRemoved());
        command.setIsPropertyShipAfterDateRemoved(this.getIsPropertyShipAfterDateRemoved());
        command.setIsPropertyCancelBackOrderDateRemoved(this.getIsPropertyCancelBackOrderDateRemoved());
        command.setIsPropertyOverrideGlAccountIdRemoved(this.getIsPropertyOverrideGlAccountIdRemoved());
        command.setIsPropertyVersionRemoved(this.getIsPropertyVersionRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
        command.setIsPropertyOrderOrderTypeIdRemoved(this.getIsPropertyOrderOrderTypeIdRemoved());
        command.setIsPropertyOrderOrderNameRemoved(this.getIsPropertyOrderOrderNameRemoved());
        command.setIsPropertyOrderExternalIdRemoved(this.getIsPropertyOrderExternalIdRemoved());
        command.setIsPropertyOrderSalesChannelEnumIdRemoved(this.getIsPropertyOrderSalesChannelEnumIdRemoved());
        command.setIsPropertyOrderOrderDateRemoved(this.getIsPropertyOrderOrderDateRemoved());
        command.setIsPropertyOrderPriorityRemoved(this.getIsPropertyOrderPriorityRemoved());
        command.setIsPropertyOrderEntryDateRemoved(this.getIsPropertyOrderEntryDateRemoved());
        command.setIsPropertyOrderPickSheetPrintedDateRemoved(this.getIsPropertyOrderPickSheetPrintedDateRemoved());
        command.setIsPropertyOrderStatusIdRemoved(this.getIsPropertyOrderStatusIdRemoved());
        command.setIsPropertyOrderCurrencyUomRemoved(this.getIsPropertyOrderCurrencyUomRemoved());
        command.setIsPropertyOrderSyncStatusIdRemoved(this.getIsPropertyOrderSyncStatusIdRemoved());
        command.setIsPropertyOrderBillingAccountIdRemoved(this.getIsPropertyOrderBillingAccountIdRemoved());
        command.setIsPropertyOrderOriginFacilityIdRemoved(this.getIsPropertyOrderOriginFacilityIdRemoved());
        command.setIsPropertyOrderWebSiteIdRemoved(this.getIsPropertyOrderWebSiteIdRemoved());
        command.setIsPropertyOrderProductStoreIdRemoved(this.getIsPropertyOrderProductStoreIdRemoved());
        command.setIsPropertyOrderTerminalIdRemoved(this.getIsPropertyOrderTerminalIdRemoved());
        command.setIsPropertyOrderTransactionIdRemoved(this.getIsPropertyOrderTransactionIdRemoved());
        command.setIsPropertyOrderAutoOrderShoppingListIdRemoved(this.getIsPropertyOrderAutoOrderShoppingListIdRemoved());
        command.setIsPropertyOrderNeedsInventoryIssuanceRemoved(this.getIsPropertyOrderNeedsInventoryIssuanceRemoved());
        command.setIsPropertyOrderIsRushOrderRemoved(this.getIsPropertyOrderIsRushOrderRemoved());
        command.setIsPropertyOrderInternalCodeRemoved(this.getIsPropertyOrderInternalCodeRemoved());
        command.setIsPropertyOrderRemainingSubTotalRemoved(this.getIsPropertyOrderRemainingSubTotalRemoved());
        command.setIsPropertyOrderGrandTotalRemoved(this.getIsPropertyOrderGrandTotalRemoved());
        command.setIsPropertyOrderInvoicePerShipmentRemoved(this.getIsPropertyOrderInvoicePerShipmentRemoved());
        command.setIsPropertyOrderCreatedByRemoved(this.getIsPropertyOrderCreatedByRemoved());
        command.setIsPropertyOrderCreatedAtRemoved(this.getIsPropertyOrderCreatedAtRemoved());
        command.setIsPropertyOrderUpdatedByRemoved(this.getIsPropertyOrderUpdatedByRemoved());
        command.setIsPropertyOrderUpdatedAtRemoved(this.getIsPropertyOrderUpdatedAtRemoved());
        command.setIsPropertyOrderActiveRemoved(this.getIsPropertyOrderActiveRemoved());
    }

    public static class CreateOrderItemMvoDto extends CreateOrMergePatchOrderItemMvoDto
    {
        public CreateOrderItemMvoDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public OrderItemMvoCommand.CreateOrderItemMvo toCreateOrderItemMvo()
        {
            return (OrderItemMvoCommand.CreateOrderItemMvo) toCommand();
        }

    }

    public static class MergePatchOrderItemMvoDto extends CreateOrMergePatchOrderItemMvoDto
    {
        public MergePatchOrderItemMvoDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public OrderItemMvoCommand.MergePatchOrderItemMvo toMergePatchOrderItemMvo()
        {
            return (OrderItemMvoCommand.MergePatchOrderItemMvo) toCommand();
        }

    }

}

