package org.dddml.wms.domain.shipment;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractEvent;

public class ItemIssuanceStateEventDto extends AbstractEvent
{

    private ItemIssuanceEventId itemIssuanceEventId;

    ItemIssuanceEventId getItemIssuanceEventId() {
        if (itemIssuanceEventId == null) { itemIssuanceEventId = new ItemIssuanceEventId(); }
        return itemIssuanceEventId;
    }

    void setItemIssuanceEventId(ItemIssuanceEventId eventId) {
        this.itemIssuanceEventId = eventId;
    }

    public String getItemIssuanceSeqId() {
        return getItemIssuanceEventId().getItemIssuanceSeqId();
    }

    public void setItemIssuanceSeqId(String itemIssuanceSeqId) {
        getItemIssuanceEventId().setItemIssuanceSeqId(itemIssuanceSeqId);
    }

    private String orderId;

    public String getOrderId() {
        return this.orderId;
    }

    public void setOrderId(String orderId) {
        this.orderId = orderId;
    }

    private String orderItemSeqId;

    public String getOrderItemSeqId() {
        return this.orderItemSeqId;
    }

    public void setOrderItemSeqId(String orderItemSeqId) {
        this.orderItemSeqId = orderItemSeqId;
    }

    private String shipGroupSeqId;

    public String getShipGroupSeqId() {
        return this.shipGroupSeqId;
    }

    public void setShipGroupSeqId(String shipGroupSeqId) {
        this.shipGroupSeqId = shipGroupSeqId;
    }

    private String productId;

    public String getProductId() {
        return this.productId;
    }

    public void setProductId(String productId) {
        this.productId = productId;
    }

    private String locatorId;

    public String getLocatorId() {
        return this.locatorId;
    }

    public void setLocatorId(String locatorId) {
        this.locatorId = locatorId;
    }

    private String attributeSetInstanceId;

    public String getAttributeSetInstanceId() {
        return this.attributeSetInstanceId;
    }

    public void setAttributeSetInstanceId(String attributeSetInstanceId) {
        this.attributeSetInstanceId = attributeSetInstanceId;
    }

    private String shipmentItemSeqId;

    public String getShipmentItemSeqId() {
        return this.shipmentItemSeqId;
    }

    public void setShipmentItemSeqId(String shipmentItemSeqId) {
        this.shipmentItemSeqId = shipmentItemSeqId;
    }

    private String fixedAssetId;

    public String getFixedAssetId() {
        return this.fixedAssetId;
    }

    public void setFixedAssetId(String fixedAssetId) {
        this.fixedAssetId = fixedAssetId;
    }

    private String maintHistSeqId;

    public String getMaintHistSeqId() {
        return this.maintHistSeqId;
    }

    public void setMaintHistSeqId(String maintHistSeqId) {
        this.maintHistSeqId = maintHistSeqId;
    }

    private java.sql.Timestamp issuedDateTime;

    public java.sql.Timestamp getIssuedDateTime() {
        return this.issuedDateTime;
    }

    public void setIssuedDateTime(java.sql.Timestamp issuedDateTime) {
        this.issuedDateTime = issuedDateTime;
    }

    private String issuedByUserLoginId;

    public String getIssuedByUserLoginId() {
        return this.issuedByUserLoginId;
    }

    public void setIssuedByUserLoginId(String issuedByUserLoginId) {
        this.issuedByUserLoginId = issuedByUserLoginId;
    }

    private java.math.BigDecimal quantity;

    public java.math.BigDecimal getQuantity() {
        return this.quantity;
    }

    public void setQuantity(java.math.BigDecimal quantity) {
        this.quantity = quantity;
    }

    private java.math.BigDecimal cancelQuantity;

    public java.math.BigDecimal getCancelQuantity() {
        return this.cancelQuantity;
    }

    public void setCancelQuantity(java.math.BigDecimal cancelQuantity) {
        this.cancelQuantity = cancelQuantity;
    }

    private Boolean active;

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    private String createdBy;

    public String getCreatedBy() {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy) {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt() {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    private Long version;

    public Long getVersion() {
        return this.version;
    }

    public void setVersion(Long version) {
        this.version = version;
    }

    private Boolean isPropertyOrderIdRemoved;

    public Boolean getIsPropertyOrderIdRemoved() {
        return this.isPropertyOrderIdRemoved;
    }

    public void setIsPropertyOrderIdRemoved(Boolean removed) {
        this.isPropertyOrderIdRemoved = removed;
    }

    private Boolean isPropertyOrderItemSeqIdRemoved;

    public Boolean getIsPropertyOrderItemSeqIdRemoved() {
        return this.isPropertyOrderItemSeqIdRemoved;
    }

    public void setIsPropertyOrderItemSeqIdRemoved(Boolean removed) {
        this.isPropertyOrderItemSeqIdRemoved = removed;
    }

    private Boolean isPropertyShipGroupSeqIdRemoved;

    public Boolean getIsPropertyShipGroupSeqIdRemoved() {
        return this.isPropertyShipGroupSeqIdRemoved;
    }

    public void setIsPropertyShipGroupSeqIdRemoved(Boolean removed) {
        this.isPropertyShipGroupSeqIdRemoved = removed;
    }

    private Boolean isPropertyProductIdRemoved;

    public Boolean getIsPropertyProductIdRemoved() {
        return this.isPropertyProductIdRemoved;
    }

    public void setIsPropertyProductIdRemoved(Boolean removed) {
        this.isPropertyProductIdRemoved = removed;
    }

    private Boolean isPropertyLocatorIdRemoved;

    public Boolean getIsPropertyLocatorIdRemoved() {
        return this.isPropertyLocatorIdRemoved;
    }

    public void setIsPropertyLocatorIdRemoved(Boolean removed) {
        this.isPropertyLocatorIdRemoved = removed;
    }

    private Boolean isPropertyAttributeSetInstanceIdRemoved;

    public Boolean getIsPropertyAttributeSetInstanceIdRemoved() {
        return this.isPropertyAttributeSetInstanceIdRemoved;
    }

    public void setIsPropertyAttributeSetInstanceIdRemoved(Boolean removed) {
        this.isPropertyAttributeSetInstanceIdRemoved = removed;
    }

    private Boolean isPropertyShipmentItemSeqIdRemoved;

    public Boolean getIsPropertyShipmentItemSeqIdRemoved() {
        return this.isPropertyShipmentItemSeqIdRemoved;
    }

    public void setIsPropertyShipmentItemSeqIdRemoved(Boolean removed) {
        this.isPropertyShipmentItemSeqIdRemoved = removed;
    }

    private Boolean isPropertyFixedAssetIdRemoved;

    public Boolean getIsPropertyFixedAssetIdRemoved() {
        return this.isPropertyFixedAssetIdRemoved;
    }

    public void setIsPropertyFixedAssetIdRemoved(Boolean removed) {
        this.isPropertyFixedAssetIdRemoved = removed;
    }

    private Boolean isPropertyMaintHistSeqIdRemoved;

    public Boolean getIsPropertyMaintHistSeqIdRemoved() {
        return this.isPropertyMaintHistSeqIdRemoved;
    }

    public void setIsPropertyMaintHistSeqIdRemoved(Boolean removed) {
        this.isPropertyMaintHistSeqIdRemoved = removed;
    }

    private Boolean isPropertyIssuedDateTimeRemoved;

    public Boolean getIsPropertyIssuedDateTimeRemoved() {
        return this.isPropertyIssuedDateTimeRemoved;
    }

    public void setIsPropertyIssuedDateTimeRemoved(Boolean removed) {
        this.isPropertyIssuedDateTimeRemoved = removed;
    }

    private Boolean isPropertyIssuedByUserLoginIdRemoved;

    public Boolean getIsPropertyIssuedByUserLoginIdRemoved() {
        return this.isPropertyIssuedByUserLoginIdRemoved;
    }

    public void setIsPropertyIssuedByUserLoginIdRemoved(Boolean removed) {
        this.isPropertyIssuedByUserLoginIdRemoved = removed;
    }

    private Boolean isPropertyQuantityRemoved;

    public Boolean getIsPropertyQuantityRemoved() {
        return this.isPropertyQuantityRemoved;
    }

    public void setIsPropertyQuantityRemoved(Boolean removed) {
        this.isPropertyQuantityRemoved = removed;
    }

    private Boolean isPropertyCancelQuantityRemoved;

    public Boolean getIsPropertyCancelQuantityRemoved() {
        return this.isPropertyCancelQuantityRemoved;
    }

    public void setIsPropertyCancelQuantityRemoved(Boolean removed) {
        this.isPropertyCancelQuantityRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }


	public static class ItemIssuanceStateCreatedDto extends ItemIssuanceStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class ItemIssuanceStateMergePatchedDto extends ItemIssuanceStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class ItemIssuanceStateRemovedDto extends ItemIssuanceStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_REMOVED;
        }

	}


}

