package org.dddml.wms.domain.order;

import java.util.*;
import org.dddml.wms.domain.partyrole.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractOrderRoleStateEvent extends AbstractStateEvent implements OrderRoleStateEvent 
{
    private OrderRoleEventId orderRoleEventId;

    public OrderRoleEventId getOrderRoleEventId() {
        return this.orderRoleEventId;
    }

    public void setOrderRoleEventId(OrderRoleEventId eventId) {
        this.orderRoleEventId = eventId;
    }
    
    public PartyRoleId getPartyRoleId() {
        return getOrderRoleEventId().getPartyRoleId();
    }

    public void setPartyRoleId(PartyRoleId partyRoleId) {
        getOrderRoleEventId().setPartyRoleId(partyRoleId);
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

    protected AbstractOrderRoleStateEvent() {
    }

    protected AbstractOrderRoleStateEvent(OrderRoleEventId eventId) {
        this.orderRoleEventId = eventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractOrderRoleStateCreated extends AbstractOrderRoleStateEvent implements OrderRoleStateEvent.OrderRoleStateCreated
    {
        public AbstractOrderRoleStateCreated() {
            this(new OrderRoleEventId());
        }

        public AbstractOrderRoleStateCreated(OrderRoleEventId eventId) {
            super(eventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractOrderRoleStateMergePatched extends AbstractOrderRoleStateEvent implements OrderRoleStateEvent.OrderRoleStateMergePatched
    {
        public AbstractOrderRoleStateMergePatched() {
            this(new OrderRoleEventId());
        }

        public AbstractOrderRoleStateMergePatched(OrderRoleEventId eventId) {
            super(eventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
        }

        private Boolean isPropertyActiveRemoved;

        public Boolean getIsPropertyActiveRemoved() {
            return this.isPropertyActiveRemoved;
        }

        public void setIsPropertyActiveRemoved(Boolean removed) {
            this.isPropertyActiveRemoved = removed;
        }

    }


    public static abstract class AbstractOrderRoleStateRemoved extends AbstractOrderRoleStateEvent implements OrderRoleStateEvent.OrderRoleStateRemoved
    {
        public AbstractOrderRoleStateRemoved() {
            this(new OrderRoleEventId());
        }

        public AbstractOrderRoleStateRemoved(OrderRoleEventId eventId) {
            super(eventId);
        }

        public String getStateEventType() {
            return StateEventType.REMOVED;
        }

    }
    public static class SimpleOrderRoleStateCreated extends AbstractOrderRoleStateCreated
    {
        public SimpleOrderRoleStateCreated() {
        }

        public SimpleOrderRoleStateCreated(OrderRoleEventId eventId) {
            super(eventId);
        }
    }

    public static class SimpleOrderRoleStateMergePatched extends AbstractOrderRoleStateMergePatched
    {
        public SimpleOrderRoleStateMergePatched() {
        }

        public SimpleOrderRoleStateMergePatched(OrderRoleEventId eventId) {
            super(eventId);
        }
    }

    public static class SimpleOrderRoleStateRemoved extends AbstractOrderRoleStateRemoved
    {
        public SimpleOrderRoleStateRemoved() {
        }

        public SimpleOrderRoleStateRemoved(OrderRoleEventId eventId) {
            super(eventId);
        }
    }

}

