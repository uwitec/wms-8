﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGroupAssociationMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo
{
	public abstract partial class OrderItemShipGroupAssociationMvoApplicationServiceBase : IOrderItemShipGroupAssociationMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IOrderItemShipGroupAssociationMvoStateRepository StateRepository { get; }

		protected abstract IOrderItemShipGroupAssociationMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IOrderItemShipGroupAssociationMvoAggregate, IOrderItemShipGroupAssociationMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IOrderItemShipGroupAssociationMvoAggregate, IOrderItemShipGroupAssociationMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected OrderItemShipGroupAssociationMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IOrderItemShipGroupAssociationMvoCommand c, Action<IOrderItemShipGroupAssociationMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetOrderItemShipGroupAssociationMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IOrderItemShipGroupAssociationMvoAggregate aggregate, IOrderItemShipGroupAssociationMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IOrderItemShipGroupAssociationMvoStateProperties)state).OrderVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IOrderItemShipGroupAssociationMvoAggregate, IOrderItemShipGroupAssociationMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IOrderItemShipGroupAssociationMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.OrderItemShipGroupAssociationMvoEventId.OrderItemShipGroupAssociationId;
            var state = new OrderItemShipGroupAssociationMvoState();
            state.OrderItemShipGroupAssociationId = aggregateId;
            var aggregate = (OrderItemShipGroupAssociationMvoAggregate)GetOrderItemShipGroupAssociationMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IOrderItemShipGroupAssociationMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IOrderItemShipGroupAssociationMvoState state)
		{
			bool repeated = false;
			if (((IOrderItemShipGroupAssociationMvoStateProperties)state).OrderVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IOrderItemShipGroupAssociationMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateOrderItemShipGroupAssociationMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchOrderItemShipGroupAssociationMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteOrderItemShipGroupAssociationMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IOrderItemShipGroupAssociationMvoState Get(OrderItemShipGroupAssociationId orderItemShipGroupAssociationId)
        {
            var state = StateRepository.Get(orderItemShipGroupAssociationId, true);
            return state;
        }

        public virtual IEnumerable<IOrderItemShipGroupAssociationMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemShipGroupAssociationMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemShipGroupAssociationMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemShipGroupAssociationMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IOrderItemShipGroupAssociationMvoStateEvent GetStateEvent(OrderItemShipGroupAssociationId orderItemShipGroupAssociationId, long version)
        {
            var e = (IOrderItemShipGroupAssociationMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(orderItemShipGroupAssociationId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(orderItemShipGroupAssociationId, 0);
            }
            return e;
        }

        public virtual IOrderItemShipGroupAssociationMvoState GetHistoryState(OrderItemShipGroupAssociationId orderItemShipGroupAssociationId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IOrderItemShipGroupAssociationMvoStateEvent), ToEventStoreAggregateId(orderItemShipGroupAssociationId), version - 1);
            return new OrderItemShipGroupAssociationMvoState(eventStream.Events);
        }


		public abstract IOrderItemShipGroupAssociationMvoAggregate GetOrderItemShipGroupAssociationMvoAggregate(IOrderItemShipGroupAssociationMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(OrderItemShipGroupAssociationId aggregateId);


	}

}

