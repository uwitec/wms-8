package org.dddml.wms.domain.inventoryitementrymvo;

import org.dddml.wms.domain.inventoryitem.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractEvent;

public class InventoryItemEntryMvoStateEventDto extends AbstractEvent
{

    private InventoryItemEntryMvoEventId inventoryItemEntryMvoEventId;

    InventoryItemEntryMvoEventId getInventoryItemEntryMvoEventId() {
        if (inventoryItemEntryMvoEventId == null) { inventoryItemEntryMvoEventId = new InventoryItemEntryMvoEventId(); }
        return inventoryItemEntryMvoEventId;
    }

    void setInventoryItemEntryMvoEventId(InventoryItemEntryMvoEventId eventId) {
        this.inventoryItemEntryMvoEventId = eventId;
    }

    public InventoryItemEntryId getInventoryItemEntryId() {
        return getInventoryItemEntryMvoEventId().getInventoryItemEntryId();
    }

    public void setInventoryItemEntryId(InventoryItemEntryId inventoryItemEntryId) {
        getInventoryItemEntryMvoEventId().setInventoryItemEntryId(inventoryItemEntryId);
    }

    public Long getInventoryItemVersion() {
        return getInventoryItemEntryMvoEventId().getInventoryItemVersion();
    }
    
    public void getInventoryItemVersion(Long inventoryItemVersion) {
        getInventoryItemEntryMvoEventId().setInventoryItemVersion(inventoryItemVersion);
    }

    private BigDecimal onHandQuantity;

    public BigDecimal getOnHandQuantity() {
        return this.onHandQuantity;
    }

    public void setOnHandQuantity(BigDecimal onHandQuantity) {
        this.onHandQuantity = onHandQuantity;
    }

    private BigDecimal inTransitQuantity;

    public BigDecimal getInTransitQuantity() {
        return this.inTransitQuantity;
    }

    public void setInTransitQuantity(BigDecimal inTransitQuantity) {
        this.inTransitQuantity = inTransitQuantity;
    }

    private BigDecimal reservedQuantity;

    public BigDecimal getReservedQuantity() {
        return this.reservedQuantity;
    }

    public void setReservedQuantity(BigDecimal reservedQuantity) {
        this.reservedQuantity = reservedQuantity;
    }

    private BigDecimal occupiedQuantity;

    public BigDecimal getOccupiedQuantity() {
        return this.occupiedQuantity;
    }

    public void setOccupiedQuantity(BigDecimal occupiedQuantity) {
        this.occupiedQuantity = occupiedQuantity;
    }

    private BigDecimal virtualQuantity;

    public BigDecimal getVirtualQuantity() {
        return this.virtualQuantity;
    }

    public void setVirtualQuantity(BigDecimal virtualQuantity) {
        this.virtualQuantity = virtualQuantity;
    }

    private InventoryItemSourceInfo source;

    public InventoryItemSourceInfo getSource() {
        return this.source;
    }

    public void setSource(InventoryItemSourceInfo source) {
        this.source = source;
    }

    private Long version;

    public Long getVersion() {
        return this.version;
    }

    public void setVersion(Long version) {
        this.version = version;
    }

    private BigDecimal inventoryItemOnHandQuantity;

    public BigDecimal getInventoryItemOnHandQuantity() {
        return this.inventoryItemOnHandQuantity;
    }

    public void setInventoryItemOnHandQuantity(BigDecimal inventoryItemOnHandQuantity) {
        this.inventoryItemOnHandQuantity = inventoryItemOnHandQuantity;
    }

    private BigDecimal inventoryItemInTransitQuantity;

    public BigDecimal getInventoryItemInTransitQuantity() {
        return this.inventoryItemInTransitQuantity;
    }

    public void setInventoryItemInTransitQuantity(BigDecimal inventoryItemInTransitQuantity) {
        this.inventoryItemInTransitQuantity = inventoryItemInTransitQuantity;
    }

    private BigDecimal inventoryItemReservedQuantity;

    public BigDecimal getInventoryItemReservedQuantity() {
        return this.inventoryItemReservedQuantity;
    }

    public void setInventoryItemReservedQuantity(BigDecimal inventoryItemReservedQuantity) {
        this.inventoryItemReservedQuantity = inventoryItemReservedQuantity;
    }

    private BigDecimal inventoryItemOccupiedQuantity;

    public BigDecimal getInventoryItemOccupiedQuantity() {
        return this.inventoryItemOccupiedQuantity;
    }

    public void setInventoryItemOccupiedQuantity(BigDecimal inventoryItemOccupiedQuantity) {
        this.inventoryItemOccupiedQuantity = inventoryItemOccupiedQuantity;
    }

    private BigDecimal inventoryItemVirtualQuantity;

    public BigDecimal getInventoryItemVirtualQuantity() {
        return this.inventoryItemVirtualQuantity;
    }

    public void setInventoryItemVirtualQuantity(BigDecimal inventoryItemVirtualQuantity) {
        this.inventoryItemVirtualQuantity = inventoryItemVirtualQuantity;
    }

    private String inventoryItemCreatedBy;

    public String getInventoryItemCreatedBy() {
        return this.inventoryItemCreatedBy;
    }

    public void setInventoryItemCreatedBy(String inventoryItemCreatedBy) {
        this.inventoryItemCreatedBy = inventoryItemCreatedBy;
    }

    private Date inventoryItemCreatedAt;

    public Date getInventoryItemCreatedAt() {
        return this.inventoryItemCreatedAt;
    }

    public void setInventoryItemCreatedAt(Date inventoryItemCreatedAt) {
        this.inventoryItemCreatedAt = inventoryItemCreatedAt;
    }

    private String inventoryItemUpdatedBy;

    public String getInventoryItemUpdatedBy() {
        return this.inventoryItemUpdatedBy;
    }

    public void setInventoryItemUpdatedBy(String inventoryItemUpdatedBy) {
        this.inventoryItemUpdatedBy = inventoryItemUpdatedBy;
    }

    private Date inventoryItemUpdatedAt;

    public Date getInventoryItemUpdatedAt() {
        return this.inventoryItemUpdatedAt;
    }

    public void setInventoryItemUpdatedAt(Date inventoryItemUpdatedAt) {
        this.inventoryItemUpdatedAt = inventoryItemUpdatedAt;
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

    private Boolean isPropertyOnHandQuantityRemoved;

    public Boolean getIsPropertyOnHandQuantityRemoved() {
        return this.isPropertyOnHandQuantityRemoved;
    }

    public void setIsPropertyOnHandQuantityRemoved(Boolean removed) {
        this.isPropertyOnHandQuantityRemoved = removed;
    }

    private Boolean isPropertyInTransitQuantityRemoved;

    public Boolean getIsPropertyInTransitQuantityRemoved() {
        return this.isPropertyInTransitQuantityRemoved;
    }

    public void setIsPropertyInTransitQuantityRemoved(Boolean removed) {
        this.isPropertyInTransitQuantityRemoved = removed;
    }

    private Boolean isPropertyReservedQuantityRemoved;

    public Boolean getIsPropertyReservedQuantityRemoved() {
        return this.isPropertyReservedQuantityRemoved;
    }

    public void setIsPropertyReservedQuantityRemoved(Boolean removed) {
        this.isPropertyReservedQuantityRemoved = removed;
    }

    private Boolean isPropertyOccupiedQuantityRemoved;

    public Boolean getIsPropertyOccupiedQuantityRemoved() {
        return this.isPropertyOccupiedQuantityRemoved;
    }

    public void setIsPropertyOccupiedQuantityRemoved(Boolean removed) {
        this.isPropertyOccupiedQuantityRemoved = removed;
    }

    private Boolean isPropertyVirtualQuantityRemoved;

    public Boolean getIsPropertyVirtualQuantityRemoved() {
        return this.isPropertyVirtualQuantityRemoved;
    }

    public void setIsPropertyVirtualQuantityRemoved(Boolean removed) {
        this.isPropertyVirtualQuantityRemoved = removed;
    }

    private Boolean isPropertySourceRemoved;

    public Boolean getIsPropertySourceRemoved() {
        return this.isPropertySourceRemoved;
    }

    public void setIsPropertySourceRemoved(Boolean removed) {
        this.isPropertySourceRemoved = removed;
    }

    private Boolean isPropertyVersionRemoved;

    public Boolean getIsPropertyVersionRemoved() {
        return this.isPropertyVersionRemoved;
    }

    public void setIsPropertyVersionRemoved(Boolean removed) {
        this.isPropertyVersionRemoved = removed;
    }

    private Boolean isPropertyInventoryItemOnHandQuantityRemoved;

    public Boolean getIsPropertyInventoryItemOnHandQuantityRemoved() {
        return this.isPropertyInventoryItemOnHandQuantityRemoved;
    }

    public void setIsPropertyInventoryItemOnHandQuantityRemoved(Boolean removed) {
        this.isPropertyInventoryItemOnHandQuantityRemoved = removed;
    }

    private Boolean isPropertyInventoryItemInTransitQuantityRemoved;

    public Boolean getIsPropertyInventoryItemInTransitQuantityRemoved() {
        return this.isPropertyInventoryItemInTransitQuantityRemoved;
    }

    public void setIsPropertyInventoryItemInTransitQuantityRemoved(Boolean removed) {
        this.isPropertyInventoryItemInTransitQuantityRemoved = removed;
    }

    private Boolean isPropertyInventoryItemReservedQuantityRemoved;

    public Boolean getIsPropertyInventoryItemReservedQuantityRemoved() {
        return this.isPropertyInventoryItemReservedQuantityRemoved;
    }

    public void setIsPropertyInventoryItemReservedQuantityRemoved(Boolean removed) {
        this.isPropertyInventoryItemReservedQuantityRemoved = removed;
    }

    private Boolean isPropertyInventoryItemOccupiedQuantityRemoved;

    public Boolean getIsPropertyInventoryItemOccupiedQuantityRemoved() {
        return this.isPropertyInventoryItemOccupiedQuantityRemoved;
    }

    public void setIsPropertyInventoryItemOccupiedQuantityRemoved(Boolean removed) {
        this.isPropertyInventoryItemOccupiedQuantityRemoved = removed;
    }

    private Boolean isPropertyInventoryItemVirtualQuantityRemoved;

    public Boolean getIsPropertyInventoryItemVirtualQuantityRemoved() {
        return this.isPropertyInventoryItemVirtualQuantityRemoved;
    }

    public void setIsPropertyInventoryItemVirtualQuantityRemoved(Boolean removed) {
        this.isPropertyInventoryItemVirtualQuantityRemoved = removed;
    }

    private Boolean isPropertyInventoryItemCreatedByRemoved;

    public Boolean getIsPropertyInventoryItemCreatedByRemoved() {
        return this.isPropertyInventoryItemCreatedByRemoved;
    }

    public void setIsPropertyInventoryItemCreatedByRemoved(Boolean removed) {
        this.isPropertyInventoryItemCreatedByRemoved = removed;
    }

    private Boolean isPropertyInventoryItemCreatedAtRemoved;

    public Boolean getIsPropertyInventoryItemCreatedAtRemoved() {
        return this.isPropertyInventoryItemCreatedAtRemoved;
    }

    public void setIsPropertyInventoryItemCreatedAtRemoved(Boolean removed) {
        this.isPropertyInventoryItemCreatedAtRemoved = removed;
    }

    private Boolean isPropertyInventoryItemUpdatedByRemoved;

    public Boolean getIsPropertyInventoryItemUpdatedByRemoved() {
        return this.isPropertyInventoryItemUpdatedByRemoved;
    }

    public void setIsPropertyInventoryItemUpdatedByRemoved(Boolean removed) {
        this.isPropertyInventoryItemUpdatedByRemoved = removed;
    }

    private Boolean isPropertyInventoryItemUpdatedAtRemoved;

    public Boolean getIsPropertyInventoryItemUpdatedAtRemoved() {
        return this.isPropertyInventoryItemUpdatedAtRemoved;
    }

    public void setIsPropertyInventoryItemUpdatedAtRemoved(Boolean removed) {
        this.isPropertyInventoryItemUpdatedAtRemoved = removed;
    }


	public static class InventoryItemEntryMvoStateCreatedDto extends InventoryItemEntryMvoStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class InventoryItemEntryMvoStateMergePatchedDto extends InventoryItemEntryMvoStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class InventoryItemEntryMvoStateDeletedDto extends InventoryItemEntryMvoStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

