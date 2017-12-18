package org.dddml.wms.domain.order;

import java.util.*;
import java.util.function.Consumer;
import org.dddml.support.criterion.Criterion;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;

public abstract class AbstractOrderApplicationService implements OrderApplicationService
{

    private EventStore eventStore;

    protected EventStore getEventStore()
    {
        return eventStore;
    }

    private OrderStateRepository stateRepository;

    protected OrderStateRepository getStateRepository() {
        return stateRepository;
    }

    private OrderStateQueryRepository stateQueryRepository;

    protected OrderStateQueryRepository getStateQueryRepository() {
        return stateQueryRepository;
    }

    private AggregateEventListener<OrderAggregate, OrderState> aggregateEventListener;

    public AggregateEventListener<OrderAggregate, OrderState> getAggregateEventListener() {
        return aggregateEventListener;
    }

    public void setAggregateEventListener(AggregateEventListener<OrderAggregate, OrderState> eventListener) {
        this.aggregateEventListener = eventListener;
    }

    public AbstractOrderApplicationService(EventStore eventStore, OrderStateRepository stateRepository, OrderStateQueryRepository stateQueryRepository) {
        this.eventStore = eventStore;
        this.stateRepository = stateRepository;
        this.stateQueryRepository = stateQueryRepository;
    }

    public void when(OrderCommand.CreateOrder c) {
        update(c, ar -> ar.create(c));
    }

    public void when(OrderCommand.MergePatchOrder c) {
        update(c, ar -> ar.mergePatch(c));
    }

    public OrderState get(String id) {
        OrderState state = getStateRepository().get(id, true);
        return state;
    }

    public Iterable<OrderState> getAll(Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().getAll(firstResult, maxResults);
    }

    public Iterable<OrderState> get(Iterable<Map.Entry<String, Object>> filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<OrderState> get(Criterion filter, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().get(filter, orders, firstResult, maxResults);
    }

    public Iterable<OrderState> getByProperty(String propertyName, Object propertyValue, List<String> orders, Integer firstResult, Integer maxResults) {
        return getStateQueryRepository().getByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
    }

    public long getCount(Iterable<Map.Entry<String, Object>> filter) {
        return getStateQueryRepository().getCount(filter);
    }

    public long getCount(Criterion filter) {
        return getStateQueryRepository().getCount(filter);
    }

    public OrderStateEvent getStateEvent(String orderId, long version) {
        OrderStateEvent e = (OrderStateEvent)getEventStore().getStateEvent(toEventStoreAggregateId(orderId), version);
        if (e != null)
        { e.setStateEventReadOnly(true); }
        else if (version == -1)
        {
            return getStateEvent(orderId, 0);
        }
        return e;
    }

    public OrderState getHistoryState(String orderId, long version) {
        EventStream eventStream = getEventStore().loadEventStream(AbstractOrderStateEvent.class, toEventStoreAggregateId(orderId), version - 1);
        return new AbstractOrderState.SimpleOrderState(eventStream.getEvents());
    }

    public OrderItemState getOrderItem(String orderId, String orderItemSeqId) {
        return getStateQueryRepository().getOrderItem(orderId, orderItemSeqId);
    }


    public OrderAggregate getOrderAggregate(OrderState state)
    {
        return new AbstractOrderAggregate.SimpleOrderAggregate(state);
    }

    public EventStoreAggregateId toEventStoreAggregateId(String aggregateId)
    {
        return new EventStoreAggregateId.SimpleEventStoreAggregateId(aggregateId);
    }

    protected void update(OrderCommand c, Consumer<OrderAggregate> action)
    {
        String aggregateId = c.getOrderId();
        OrderState state = getStateRepository().get(aggregateId, false);
        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);

        boolean repeated = isRepeatedCommand(c, eventStoreAggregateId, state);
        if (repeated) { return; }

        OrderAggregate aggregate = getOrderAggregate(state);
        aggregate.throwOnInvalidStateTransition(c);
        action.accept(aggregate);
        persist(eventStoreAggregateId, c.getVersion(), aggregate, state); // State version may be null!

    }

    private void persist(EventStoreAggregateId eventStoreAggregateId, long version, OrderAggregate aggregate, OrderState state) {
        getEventStore().appendEvents(eventStoreAggregateId, version, 
            aggregate.getChanges(), (events) -> { getStateRepository().save(state); });
        if (aggregateEventListener != null) {
            aggregateEventListener.eventAppended(new AggregateEvent<>(aggregate, state, aggregate.getChanges()));
        }
    }

    public void initialize(OrderStateEvent.OrderStateCreated stateCreated) {
        String aggregateId = stateCreated.getStateEventId().getOrderId();
        OrderState state = new AbstractOrderState.SimpleOrderState();
        state.setOrderId(aggregateId);

        OrderAggregate aggregate = getOrderAggregate(state);
        ((AbstractOrderAggregate) aggregate).apply(stateCreated);

        EventStoreAggregateId eventStoreAggregateId = toEventStoreAggregateId(aggregateId);
        persist(eventStoreAggregateId, stateCreated.getStateEventId().getVersion(), aggregate, state);
    }

    protected boolean isRepeatedCommand(OrderCommand command, EventStoreAggregateId eventStoreAggregateId, OrderState state)
    {
        boolean repeated = false;
        if (command.getVersion() == null) { command.setVersion(OrderState.VERSION_NULL); }
        if (state.getVersion() != null && state.getVersion() > command.getVersion())
        {
            Event lastEvent = getEventStore().findLastEvent(AbstractOrderStateEvent.class, eventStoreAggregateId, command.getVersion());
            if (lastEvent != null && lastEvent instanceof AbstractStateEvent
               && command.getCommandId() != null && command.getCommandId().equals(((AbstractStateEvent) lastEvent).getCommandId()))
            {
                repeated = true;
            }
        }
        return repeated;
    }

    public static class SimpleOrderApplicationService extends AbstractOrderApplicationService 
    {
        public SimpleOrderApplicationService(EventStore eventStore, OrderStateRepository stateRepository, OrderStateQueryRepository stateQueryRepository)
        {
            super(eventStore, stateRepository, stateQueryRepository);
        }
    }

}
