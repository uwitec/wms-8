﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderItemMvo
{
	public abstract partial class OrderItemMvoApplicationServiceBase : IOrderItemMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IOrderItemMvoStateRepository StateRepository { get; }

		protected abstract IOrderItemMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IOrderItemMvoAggregate, IOrderItemMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IOrderItemMvoAggregate, IOrderItemMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected OrderItemMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IOrderItemMvoCommand c, Action<IOrderItemMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetOrderItemMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IOrderItemMvoAggregate aggregate, IOrderItemMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IOrderItemMvoStateProperties)state).OrderVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IOrderItemMvoAggregate, IOrderItemMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IOrderItemMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.OrderItemMvoEventId.OrderItemId;
            var state = new OrderItemMvoState();
            state.OrderItemId = aggregateId;
            var aggregate = (OrderItemMvoAggregate)GetOrderItemMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IOrderItemMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IOrderItemMvoState state)
		{
			bool repeated = false;
			if (((IOrderItemMvoStateProperties)state).OrderVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IOrderItemMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
				if (lastEvent != null && lastEvent.CommandId == command.CommandId)
				{
					repeated = true;
				}
			}
			return repeated;
		}


		public virtual void Execute(object command)
		{
			((dynamic)this).When((dynamic)command);
		}


		public virtual void When(ICreateOrderItemMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchOrderItemMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

        public virtual IOrderItemMvoState Get(OrderItemId orderItemId)
        {
            var state = StateRepository.Get(orderItemId, true);
            return state;
        }

        public virtual IEnumerable<IOrderItemMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = StateQueryRepository.GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

        public virtual long GetCount(ICriterion filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

	    public virtual IOrderItemMvoStateEvent GetStateEvent(OrderItemId orderItemId, long version)
        {
            var e = (IOrderItemMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(orderItemId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(orderItemId, 0);
            }
            return e;
        }

        public virtual IOrderItemMvoState GetHistoryState(OrderItemId orderItemId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IOrderItemMvoStateEvent), ToEventStoreAggregateId(orderItemId), version - 1);
            return new OrderItemMvoState(eventStream.Events);
        }


		public abstract IOrderItemMvoAggregate GetOrderItemMvoAggregate(IOrderItemMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(OrderItemId aggregateId);


	}

}

