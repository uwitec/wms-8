﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipment;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderShipment
{
	public abstract partial class OrderShipmentApplicationServiceBase : IOrderShipmentApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IOrderShipmentStateRepository StateRepository { get; }

		protected abstract IOrderShipmentStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IOrderShipmentAggregate, IOrderShipmentState> _aggregateEventListener;

        public virtual IAggregateEventListener<IOrderShipmentAggregate, IOrderShipmentState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected OrderShipmentApplicationServiceBase()
		{
		}

		protected virtual void Update(IOrderShipmentCommand c, Action<IOrderShipmentAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetOrderShipmentAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IOrderShipmentAggregate aggregate, IOrderShipmentState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IOrderShipmentStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IOrderShipmentAggregate, IOrderShipmentState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IOrderShipmentStateCreated stateCreated)
        {
            var aggregateId = stateCreated.OrderShipmentEventId.OrderShipmentId;
            var state = new OrderShipmentState();
            state.OrderShipmentId = aggregateId;
            var aggregate = (OrderShipmentAggregate)GetOrderShipmentAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IOrderShipmentCommand command, IEventStoreAggregateId eventStoreAggregateId, IOrderShipmentState state)
		{
			bool repeated = false;
			if (((IOrderShipmentStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IOrderShipmentEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateOrderShipment c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchOrderShipment c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

        public virtual IOrderShipmentState Get(OrderShipmentId orderShipmentId)
        {
            var state = StateRepository.Get(orderShipmentId, true);
            return state;
        }

        public virtual IEnumerable<IOrderShipmentState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderShipmentState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderShipmentState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderShipmentState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IOrderShipmentEvent GetEvent(OrderShipmentId orderShipmentId, long version)
        {
            var e = (IOrderShipmentEvent)EventStore.GetEvent(ToEventStoreAggregateId(orderShipmentId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(orderShipmentId, 0);
            }
            return e;
        }

        public virtual IOrderShipmentState GetHistoryState(OrderShipmentId orderShipmentId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IOrderShipmentEvent), ToEventStoreAggregateId(orderShipmentId), version - 1);
            return new OrderShipmentState(eventStream.Events);
        }


		public abstract IOrderShipmentAggregate GetOrderShipmentAggregate(IOrderShipmentState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(OrderShipmentId aggregateId);


	}

}

