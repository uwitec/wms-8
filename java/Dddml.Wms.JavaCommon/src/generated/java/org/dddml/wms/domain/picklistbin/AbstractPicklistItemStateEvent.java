package org.dddml.wms.domain.picklistbin;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractPicklistItemStateEvent extends AbstractStateEvent implements PicklistItemStateEvent 
{
    private PicklistItemEventId picklistItemEventId;

    public PicklistItemEventId getPicklistItemEventId() {
        return this.picklistItemEventId;
    }

    public void setPicklistItemEventId(PicklistItemEventId eventId) {
        this.picklistItemEventId = eventId;
    }
    
    public PicklistItemOrderShipGrpInvId getPicklistItemOrderShipGrpInvId() {
        return getPicklistItemEventId().getPicklistItemOrderShipGrpInvId();
    }

    public void setPicklistItemOrderShipGrpInvId(PicklistItemOrderShipGrpInvId picklistItemOrderShipGrpInvId) {
        getPicklistItemEventId().setPicklistItemOrderShipGrpInvId(picklistItemOrderShipGrpInvId);
    }

    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private String itemStatusId;

    public String getItemStatusId()
    {
        return this.itemStatusId;
    }

    public void setItemStatusId(String itemStatusId)
    {
        this.itemStatusId = itemStatusId;
    }

    private java.math.BigDecimal quantity;

    public java.math.BigDecimal getQuantity()
    {
        return this.quantity;
    }

    public void setQuantity(java.math.BigDecimal quantity)
    {
        this.quantity = quantity;
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


    private String commandId;

    public String getCommandId() {
        return commandId;
    }

    public void setCommandId(String commandId) {
        this.commandId = commandId;
    }

    protected AbstractPicklistItemStateEvent() {
    }

    protected AbstractPicklistItemStateEvent(PicklistItemEventId eventId) {
        this.picklistItemEventId = eventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractPicklistItemStateCreated extends AbstractPicklistItemStateEvent implements PicklistItemStateEvent.PicklistItemStateCreated
    {
        public AbstractPicklistItemStateCreated() {
            this(new PicklistItemEventId());
        }

        public AbstractPicklistItemStateCreated(PicklistItemEventId eventId) {
            super(eventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractPicklistItemStateMergePatched extends AbstractPicklistItemStateEvent implements PicklistItemStateEvent.PicklistItemStateMergePatched
    {
        public AbstractPicklistItemStateMergePatched() {
            this(new PicklistItemEventId());
        }

        public AbstractPicklistItemStateMergePatched(PicklistItemEventId eventId) {
            super(eventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyItemStatusIdRemoved;

        public Boolean getIsPropertyItemStatusIdRemoved() {
            return this.isPropertyItemStatusIdRemoved;
        }

        public void setIsPropertyItemStatusIdRemoved(Boolean removed) {
            this.isPropertyItemStatusIdRemoved = removed;
        }

        private Boolean isPropertyQuantityRemoved;

        public Boolean getIsPropertyQuantityRemoved() {
            return this.isPropertyQuantityRemoved;
        }

        public void setIsPropertyQuantityRemoved(Boolean removed) {
            this.isPropertyQuantityRemoved = removed;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

    }


    public static abstract class AbstractPicklistItemStateRemoved extends AbstractPicklistItemStateEvent implements PicklistItemStateEvent.PicklistItemStateRemoved
    {
        public AbstractPicklistItemStateRemoved() {
            this(new PicklistItemEventId());
        }

        public AbstractPicklistItemStateRemoved(PicklistItemEventId eventId) {
            super(eventId);
        }

        public String getStateEventType() {
            return StateEventType.REMOVED;
        }

    }
    public static class SimplePicklistItemStateCreated extends AbstractPicklistItemStateCreated
    {
        public SimplePicklistItemStateCreated() {
        }

        public SimplePicklistItemStateCreated(PicklistItemEventId eventId) {
            super(eventId);
        }
    }

    public static class SimplePicklistItemStateMergePatched extends AbstractPicklistItemStateMergePatched
    {
        public SimplePicklistItemStateMergePatched() {
        }

        public SimplePicklistItemStateMergePatched(PicklistItemEventId eventId) {
            super(eventId);
        }
    }

    public static class SimplePicklistItemStateRemoved extends AbstractPicklistItemStateRemoved
    {
        public SimplePicklistItemStateRemoved() {
        }

        public SimplePicklistItemStateRemoved(PicklistItemEventId eventId) {
            super(eventId);
        }
    }

}

