package org.dddml.wms.domain.partyrole;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractPartyRoleApplicationService implements PartyRoleApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private PartyRoleStateRepository stateRepository;

    protected PartyRoleStateRepository getStateRepository() {
        return stateRepository;
    }

    private PartyRoleStateQueryRepository stateQueryRepository;

    protected PartyRoleStateQueryRepository getStateQueryRepository() {
        return stateQueryRepository;
    }

    private AggregateEventListener<PartyRoleAggregate, PartyRoleState> aggregateEventListener;

    public AggregateEventListener<PartyRoleAggregate, PartyRoleState> getAggregateEventListener() {
        return aggregateEventListener;
    }

    public void setAggregateEventListener(AggregateEventListener<PartyRoleAggregate, PartyRoleState> eventListener) {
        this.aggregateEventListener = eventListener;
    }

    public AbstractPartyRoleApplicationService(EventStore eventStore, PartyRoleStateRepository stateRepository, PartyRoleStateQueryRepository stateQueryRepository) {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
        this.stateQueryRepository = stateQueryRepository;
    }

    public void when(PartyRoleCommand.CreatePartyRole c) {
        update(c, ar -> ar.create(c));
    }

    public void when(PartyRoleCommand.MergePatchPartyRole c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public void when(PartyRoleCommand.DeletePartyRole c) {
        update(c, ar -> ar.delete(c));
    }

    public PartyRoleState get(PartyRoleId id) {
        PartyRoleState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<PartyRoleState> getAll(Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().getAll(firstResult, maxResults);
    }

    public Iterable<PartyRoleState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<PartyRoleState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<PartyRoleState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateQueryRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateQueryRepository().getCount(filter);
    }

    public PartyRoleStateEvent getStateEvent(PartyRoleId partyRoleId, long version) {
        PartyRoleStateEvent e = (PartyRoleStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(partyRoleId), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        else if (version == -1)
        {
            return getStateEvent(partyRoleId, 0);
        }
        return e;
    }

    public PartyRoleState getHistoryState(PartyRoleId partyRoleId, long version) {
        EventStream eventStream = getEventStore().loadEventStream(AbstractPartyRoleStateEvent.class, toEventStoreAggregateId(partyRoleId), version - 1);
        return new AbstractPartyRoleState.SimplePartyRoleState(eventStream.getEvents());
    }


    public PartyRoleAggregate getPartyRoleAggregate(PartyRoleState state)
    {
        return new AbstractPartyRoleAggregate.SimplePartyRoleAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(PartyRoleId aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(PartyRoleCommand c, Consumer<PartyRoleAggregate> action)
    {
        PartyRoleId aggregateId = c.getPartyRoleId();
        PartyRoleState state = getStateRepository().get(aggregateId, false);
        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        PartyRoleAggregate aggregate = getPartyRoleAggregate(state);
        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        persist(eventStoreAggregateId, c.getVersion(), aggregate, state); // State version may be null!

    }

    private void persist(EventStoreAggregateId eventStoreAggregateId, long version, PartyRoleAggregate aggregate, PartyRoleState state) {
        getEventStore().appendEvents(eventStoreAggregateId, version, 
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });
        if (aggregateEventListener != null) {
            aggregateEventListener.eventAppended(new AggregateEvent<>(aggregate, state, aggregate.getChanges()));
        }
    }

    public void initialize(PartyRoleStateEvent.PartyRoleStateCreated stateCreated) {
        PartyRoleId aggregateId = stateCreated.getPartyRoleEventId().getPartyRoleId();
        PartyRoleState state = new AbstractPartyRoleState.SimplePartyRoleState();
        state.setPartyRoleId(aggregateId);

        PartyRoleAggregate aggregate = getPartyRoleAggregate(state);
        ((AbstractPartyRoleAggregate) aggregate).apply(stateCreated);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);
        persist(eventStoreAggregateId, stateCreated.getPartyRoleEventId().getVersion(), aggregate, state);
    }

    protected boolean isRepeatedCommand(PartyRoleCommand command, EventStoreAggregateId eventStoreAggregateId, PartyRoleState state)
    {
        boolean repeated = false;
        if (command.getVersion() == null) { command.setVersion(PartyRoleState.VERSION_NULL); }
        if (state.getVersion() != null && state.getVersion() > command.getVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractPartyRoleStateEvent.class, eventStoreAggregateId, command.getVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimplePartyRoleApplicationService extends AbstractPartyRoleApplicationService 
    {
        public SimplePartyRoleApplicationService(EventStore eventStore, PartyRoleStateRepository stateRepository, PartyRoleStateQueryRepository stateQueryRepository)
        {
            super(eventStore, stateRepository, stateQueryRepository);
        }
    }

}

