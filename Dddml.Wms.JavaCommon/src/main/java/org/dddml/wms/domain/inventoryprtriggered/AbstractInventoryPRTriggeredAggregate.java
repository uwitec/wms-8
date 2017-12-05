package org.dddml.wms.domain.inventoryprtriggered;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractInventoryPRTriggeredAggregate extends AbstractAggregate implements InventoryPRTriggeredAggregate
{
    private InventoryPRTriggeredState state;

    private List<Event> changes = new ArrayList<Event>();

    public AbstractInventoryPRTriggeredAggregate(InventoryPRTriggeredState state)
    {
        this.state = state;
    }

    public InventoryPRTriggeredState getState() {
        return this.state;
    }

    public List<Event> getChanges() {
        return this.changes;
    }

    public void create(InventoryPRTriggeredCommand.CreateInventoryPRTriggered c)
    {
        if (c.getVersion() == null) { c.setVersion(InventoryPRTriggeredState.VERSION_NULL); }
        InventoryPRTriggeredStateEvent e = map(c);
        apply(e);
    }

    public void mergePatch(InventoryPRTriggeredCommand.MergePatchInventoryPRTriggered c)
    {
        InventoryPRTriggeredStateEvent e = map(c);
        apply(e);
    }

    public void throwOnInvalidStateTransition(Command c)
    {
        if (this.state.getVersion() == null)
        {
            if (isCommandCreate((InventoryPRTriggeredCommand)c))
            {
                return;
            }
            throw DomainError.named("premature", "Can't do anything to unexistent aggregate");
        }
        if (isCommandCreate((InventoryPRTriggeredCommand)c))
            throw DomainError.named("rebirth", "Can't create aggregate that already exists");
    }

    protected void apply(Event e)
    {
        onApplying(e);
        state.mutate(e);
        changes.add(e);
    }

    protected InventoryPRTriggeredStateEvent map(InventoryPRTriggeredCommand.CreateInventoryPRTriggered c) {
        InventoryPRTriggeredStateEventId stateEventId = new InventoryPRTriggeredStateEventId(c.getInventoryPRTriggeredId(), c.getVersion());
        InventoryPRTriggeredStateEvent.InventoryPRTriggeredStateCreated e = newInventoryPRTriggeredStateCreated(stateEventId);
        e.setIsProcessed(c.getIsProcessed());
        ((AbstractInventoryPRTriggeredStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected InventoryPRTriggeredStateEvent map(InventoryPRTriggeredCommand.MergePatchInventoryPRTriggered c) {
        InventoryPRTriggeredStateEventId stateEventId = new InventoryPRTriggeredStateEventId(c.getInventoryPRTriggeredId(), c.getVersion());
        InventoryPRTriggeredStateEvent.InventoryPRTriggeredStateMergePatched e = newInventoryPRTriggeredStateMergePatched(stateEventId);
        e.setIsProcessed(c.getIsProcessed());
        e.setIsPropertyIsProcessedRemoved(c.getIsPropertyIsProcessedRemoved());
        ((AbstractInventoryPRTriggeredStateEvent)e).setCommandId(c.getCommandId());
        e.setCreatedBy(c.getRequesterId());
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }


    private static boolean isCommandCreate(InventoryPRTriggeredCommand c)
    {
        return ((c instanceof InventoryPRTriggeredCommand.CreateInventoryPRTriggered) 
            && c.getVersion().equals(InventoryPRTriggeredState.VERSION_NULL));
    }


    ////////////////////////

    protected InventoryPRTriggeredStateEvent.InventoryPRTriggeredStateCreated newInventoryPRTriggeredStateCreated(String commandId, String requesterId) {
        InventoryPRTriggeredStateEventId stateEventId = new InventoryPRTriggeredStateEventId(this.state.getInventoryPRTriggeredId(), this.state.getVersion());
        InventoryPRTriggeredStateEvent.InventoryPRTriggeredStateCreated e = newInventoryPRTriggeredStateCreated(stateEventId);
        ((AbstractInventoryPRTriggeredStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected InventoryPRTriggeredStateEvent.InventoryPRTriggeredStateMergePatched newInventoryPRTriggeredStateMergePatched(String commandId, String requesterId) {
        InventoryPRTriggeredStateEventId stateEventId = new InventoryPRTriggeredStateEventId(this.state.getInventoryPRTriggeredId(), this.state.getVersion());
        InventoryPRTriggeredStateEvent.InventoryPRTriggeredStateMergePatched e = newInventoryPRTriggeredStateMergePatched(stateEventId);
        ((AbstractInventoryPRTriggeredStateEvent)e).setCommandId(commandId);
        e.setCreatedBy(requesterId);
        e.setCreatedAt((java.util.Date)ApplicationContext.current.getTimestampService().now(java.util.Date.class));
        return e;
    }

    protected InventoryPRTriggeredStateEvent.InventoryPRTriggeredStateCreated newInventoryPRTriggeredStateCreated(InventoryPRTriggeredStateEventId stateEventId) {
        return new AbstractInventoryPRTriggeredStateEvent.SimpleInventoryPRTriggeredStateCreated(stateEventId);
    }

    protected InventoryPRTriggeredStateEvent.InventoryPRTriggeredStateMergePatched newInventoryPRTriggeredStateMergePatched(InventoryPRTriggeredStateEventId stateEventId) {
        return new AbstractInventoryPRTriggeredStateEvent.SimpleInventoryPRTriggeredStateMergePatched(stateEventId);
    }


    public static class SimpleInventoryPRTriggeredAggregate extends AbstractInventoryPRTriggeredAggregate
    {
        public SimpleInventoryPRTriggeredAggregate(InventoryPRTriggeredState state) {
            super(state);
        }

    }

}
