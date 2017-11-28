package org.dddml.wms.domain.inventoryitementrymvo;

import java.util.*;
import org.dddml.wms.domain.inventoryitem.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractInventoryItemEntryMvoStateEvent extends AbstractStateEvent implements InventoryItemEntryMvoStateEvent 
{
    private InventoryItemEntryMvoStateEventId stateEventId;

    public InventoryItemEntryMvoStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(InventoryItemEntryMvoStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    public InventoryItemEntryId getInventoryItemEntryId() {
        return getStateEventId().getInventoryItemEntryId();
    }

    public void setInventoryItemEntryId(InventoryItemEntryId inventoryItemEntryId) {
        getStateEventId().setInventoryItemEntryId(inventoryItemEntryId);
    }

    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private BigDecimal quantityOnHandVar;

    public BigDecimal getQuantityOnHandVar()
    {
        return this.quantityOnHandVar;
    }

    public void setQuantityOnHandVar(BigDecimal quantityOnHandVar)
    {
        this.quantityOnHandVar = quantityOnHandVar;
    }

    private BigDecimal quantityReservedVar;

    public BigDecimal getQuantityReservedVar()
    {
        return this.quantityReservedVar;
    }

    public void setQuantityReservedVar(BigDecimal quantityReservedVar)
    {
        this.quantityReservedVar = quantityReservedVar;
    }

    private BigDecimal quantityOccupiedVar;

    public BigDecimal getQuantityOccupiedVar()
    {
        return this.quantityOccupiedVar;
    }

    public void setQuantityOccupiedVar(BigDecimal quantityOccupiedVar)
    {
        this.quantityOccupiedVar = quantityOccupiedVar;
    }

    private BigDecimal quantityVirtualVar;

    public BigDecimal getQuantityVirtualVar()
    {
        return this.quantityVirtualVar;
    }

    public void setQuantityVirtualVar(BigDecimal quantityVirtualVar)
    {
        this.quantityVirtualVar = quantityVirtualVar;
    }

    private InventoryItemEventVO eventVO;

    public InventoryItemEventVO getEventVO()
    {
        return this.eventVO;
    }

    public void setEventVO(InventoryItemEventVO eventVO)
    {
        this.eventVO = eventVO;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private BigDecimal inventoryItemQuantityOnHand;

    public BigDecimal getInventoryItemQuantityOnHand()
    {
        return this.inventoryItemQuantityOnHand;
    }

    public void setInventoryItemQuantityOnHand(BigDecimal inventoryItemQuantityOnHand)
    {
        this.inventoryItemQuantityOnHand = inventoryItemQuantityOnHand;
    }

    private BigDecimal inventoryItemQuantityReserved;

    public BigDecimal getInventoryItemQuantityReserved()
    {
        return this.inventoryItemQuantityReserved;
    }

    public void setInventoryItemQuantityReserved(BigDecimal inventoryItemQuantityReserved)
    {
        this.inventoryItemQuantityReserved = inventoryItemQuantityReserved;
    }

    private BigDecimal inventoryItemQuantityOccupied;

    public BigDecimal getInventoryItemQuantityOccupied()
    {
        return this.inventoryItemQuantityOccupied;
    }

    public void setInventoryItemQuantityOccupied(BigDecimal inventoryItemQuantityOccupied)
    {
        this.inventoryItemQuantityOccupied = inventoryItemQuantityOccupied;
    }

    private BigDecimal inventoryItemQuantityVirtual;

    public BigDecimal getInventoryItemQuantityVirtual()
    {
        return this.inventoryItemQuantityVirtual;
    }

    public void setInventoryItemQuantityVirtual(BigDecimal inventoryItemQuantityVirtual)
    {
        this.inventoryItemQuantityVirtual = inventoryItemQuantityVirtual;
    }

    private String inventoryItemCreatedBy;

    public String getInventoryItemCreatedBy()
    {
        return this.inventoryItemCreatedBy;
    }

    public void setInventoryItemCreatedBy(String inventoryItemCreatedBy)
    {
        this.inventoryItemCreatedBy = inventoryItemCreatedBy;
    }

    private Date inventoryItemCreatedAt;

    public Date getInventoryItemCreatedAt()
    {
        return this.inventoryItemCreatedAt;
    }

    public void setInventoryItemCreatedAt(Date inventoryItemCreatedAt)
    {
        this.inventoryItemCreatedAt = inventoryItemCreatedAt;
    }

    private String inventoryItemUpdatedBy;

    public String getInventoryItemUpdatedBy()
    {
        return this.inventoryItemUpdatedBy;
    }

    public void setInventoryItemUpdatedBy(String inventoryItemUpdatedBy)
    {
        this.inventoryItemUpdatedBy = inventoryItemUpdatedBy;
    }

    private Date inventoryItemUpdatedAt;

    public Date getInventoryItemUpdatedAt()
    {
        return this.inventoryItemUpdatedAt;
    }

    public void setInventoryItemUpdatedAt(Date inventoryItemUpdatedAt)
    {
        this.inventoryItemUpdatedAt = inventoryItemUpdatedAt;
    }


    private String commandId;

    public String getCommandId() {
        return commandId;
    }

    public void setCommandId(String commandId) {
        this.commandId = commandId;
    }

    protected AbstractInventoryItemEntryMvoStateEvent() {
    }

    protected AbstractInventoryItemEntryMvoStateEvent(InventoryItemEntryMvoStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractInventoryItemEntryMvoStateCreated extends AbstractInventoryItemEntryMvoStateEvent implements InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateCreated
    {
        public AbstractInventoryItemEntryMvoStateCreated() {
            this(new InventoryItemEntryMvoStateEventId());
        }

        public AbstractInventoryItemEntryMvoStateCreated(InventoryItemEntryMvoStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractInventoryItemEntryMvoStateMergePatched extends AbstractInventoryItemEntryMvoStateEvent implements InventoryItemEntryMvoStateEvent.InventoryItemEntryMvoStateMergePatched
    {
        public AbstractInventoryItemEntryMvoStateMergePatched() {
            this(new InventoryItemEntryMvoStateEventId());
        }

        public AbstractInventoryItemEntryMvoStateMergePatched(InventoryItemEntryMvoStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyQuantityOnHandVarRemoved;

        public Boolean getIsPropertyQuantityOnHandVarRemoved() {
            return this.isPropertyQuantityOnHandVarRemoved;
        }

        public void setIsPropertyQuantityOnHandVarRemoved(Boolean removed) {
            this.isPropertyQuantityOnHandVarRemoved = removed;
        }

        private Boolean isPropertyQuantityReservedVarRemoved;

        public Boolean getIsPropertyQuantityReservedVarRemoved() {
            return this.isPropertyQuantityReservedVarRemoved;
        }

        public void setIsPropertyQuantityReservedVarRemoved(Boolean removed) {
            this.isPropertyQuantityReservedVarRemoved = removed;
        }

        private Boolean isPropertyQuantityOccupiedVarRemoved;

        public Boolean getIsPropertyQuantityOccupiedVarRemoved() {
            return this.isPropertyQuantityOccupiedVarRemoved;
        }

        public void setIsPropertyQuantityOccupiedVarRemoved(Boolean removed) {
            this.isPropertyQuantityOccupiedVarRemoved = removed;
        }

        private Boolean isPropertyQuantityVirtualVarRemoved;

        public Boolean getIsPropertyQuantityVirtualVarRemoved() {
            return this.isPropertyQuantityVirtualVarRemoved;
        }

        public void setIsPropertyQuantityVirtualVarRemoved(Boolean removed) {
            this.isPropertyQuantityVirtualVarRemoved = removed;
        }

        private Boolean isPropertyEventVORemoved;

        public Boolean getIsPropertyEventVORemoved() {
            return this.isPropertyEventVORemoved;
        }

        public void setIsPropertyEventVORemoved(Boolean removed) {
            this.isPropertyEventVORemoved = removed;
        }

        private Boolean isPropertyVersionRemoved;

        public Boolean getIsPropertyVersionRemoved() {
            return this.isPropertyVersionRemoved;
        }

        public void setIsPropertyVersionRemoved(Boolean removed) {
            this.isPropertyVersionRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

        private Boolean isPropertyInventoryItemQuantityOnHandRemoved;

        public Boolean getIsPropertyInventoryItemQuantityOnHandRemoved() {
            return this.isPropertyInventoryItemQuantityOnHandRemoved;
        }

        public void setIsPropertyInventoryItemQuantityOnHandRemoved(Boolean removed) {
            this.isPropertyInventoryItemQuantityOnHandRemoved = removed;
        }

        private Boolean isPropertyInventoryItemQuantityReservedRemoved;

        public Boolean getIsPropertyInventoryItemQuantityReservedRemoved() {
            return this.isPropertyInventoryItemQuantityReservedRemoved;
        }

        public void setIsPropertyInventoryItemQuantityReservedRemoved(Boolean removed) {
            this.isPropertyInventoryItemQuantityReservedRemoved = removed;
        }

        private Boolean isPropertyInventoryItemQuantityOccupiedRemoved;

        public Boolean getIsPropertyInventoryItemQuantityOccupiedRemoved() {
            return this.isPropertyInventoryItemQuantityOccupiedRemoved;
        }

        public void setIsPropertyInventoryItemQuantityOccupiedRemoved(Boolean removed) {
            this.isPropertyInventoryItemQuantityOccupiedRemoved = removed;
        }

        private Boolean isPropertyInventoryItemQuantityVirtualRemoved;

        public Boolean getIsPropertyInventoryItemQuantityVirtualRemoved() {
            return this.isPropertyInventoryItemQuantityVirtualRemoved;
        }

        public void setIsPropertyInventoryItemQuantityVirtualRemoved(Boolean removed) {
            this.isPropertyInventoryItemQuantityVirtualRemoved = removed;
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

    }


    public static class SimpleInventoryItemEntryMvoStateCreated extends AbstractInventoryItemEntryMvoStateCreated
    {
        public SimpleInventoryItemEntryMvoStateCreated() {
        }

        public SimpleInventoryItemEntryMvoStateCreated(InventoryItemEntryMvoStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleInventoryItemEntryMvoStateMergePatched extends AbstractInventoryItemEntryMvoStateMergePatched
    {
        public SimpleInventoryItemEntryMvoStateMergePatched() {
        }

        public SimpleInventoryItemEntryMvoStateMergePatched(InventoryItemEntryMvoStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}

