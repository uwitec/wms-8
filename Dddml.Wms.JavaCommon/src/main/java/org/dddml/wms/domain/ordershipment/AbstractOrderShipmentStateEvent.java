package org.dddml.wms.domain.ordershipment;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.AbstractStateEvent;

public abstract class AbstractOrderShipmentStateEvent extends AbstractStateEvent implements OrderShipmentStateEvent 
{
    private OrderShipmentStateEventId stateEventId;

    public OrderShipmentStateEventId getStateEventId() {
        return this.stateEventId;
    }

    public void setStateEventId(OrderShipmentStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }
    
    public OrderShipmentId getOrderShipmentId() {
        return getStateEventId().getOrderShipmentId();
    }

    public void setOrderShipmentId(OrderShipmentId orderShipmentId) {
        getStateEventId().setOrderShipmentId(orderShipmentId);
    }

    private boolean stateEventReadOnly;

    public boolean getStateEventReadOnly() { return this.stateEventReadOnly; }

    public void setStateEventReadOnly(boolean readOnly) { this.stateEventReadOnly = readOnly; }

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

    protected AbstractOrderShipmentStateEvent() {
    }

    protected AbstractOrderShipmentStateEvent(OrderShipmentStateEventId stateEventId) {
        this.stateEventId = stateEventId;
    }


    public abstract String getStateEventType();


    public static abstract class AbstractOrderShipmentStateCreated extends AbstractOrderShipmentStateEvent implements OrderShipmentStateEvent.OrderShipmentStateCreated
    {
        public AbstractOrderShipmentStateCreated() {
            this(new OrderShipmentStateEventId());
        }

        public AbstractOrderShipmentStateCreated(OrderShipmentStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.CREATED;
        }

    }


    public static abstract class AbstractOrderShipmentStateMergePatched extends AbstractOrderShipmentStateEvent implements OrderShipmentStateEvent.OrderShipmentStateMergePatched
    {
        public AbstractOrderShipmentStateMergePatched() {
            this(new OrderShipmentStateEventId());
        }

        public AbstractOrderShipmentStateMergePatched(OrderShipmentStateEventId stateEventId) {
            super(stateEventId);
        }

        public String getStateEventType() {
            return StateEventType.MERGE_PATCHED;
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


    public static class SimpleOrderShipmentStateCreated extends AbstractOrderShipmentStateCreated
    {
        public SimpleOrderShipmentStateCreated() {
        }

        public SimpleOrderShipmentStateCreated(OrderShipmentStateEventId stateEventId) {
            super(stateEventId);
        }
    }

    public static class SimpleOrderShipmentStateMergePatched extends AbstractOrderShipmentStateMergePatched
    {
        public SimpleOrderShipmentStateMergePatched() {
        }

        public SimpleOrderShipmentStateMergePatched(OrderShipmentStateEventId stateEventId) {
            super(stateEventId);
        }
    }

}
