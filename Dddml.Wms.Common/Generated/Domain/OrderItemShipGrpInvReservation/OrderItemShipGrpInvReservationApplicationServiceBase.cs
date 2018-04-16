﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGrpInvReservationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGrpInvReservation;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderItemShipGrpInvReservation
{
	public abstract partial class OrderItemShipGrpInvReservationApplicationServiceBase : IOrderItemShipGrpInvReservationApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IOrderItemShipGrpInvReservationStateRepository StateRepository { get; }

		protected abstract IOrderItemShipGrpInvReservationStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IOrderItemShipGrpInvReservationAggregate, IOrderItemShipGrpInvReservationState> _aggregateEventListener;

        public virtual IAggregateEventListener<IOrderItemShipGrpInvReservationAggregate, IOrderItemShipGrpInvReservationState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected OrderItemShipGrpInvReservationApplicationServiceBase()
		{
		}

		protected virtual void Update(IOrderItemShipGrpInvReservationCommand c, Action<IOrderItemShipGrpInvReservationAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetOrderItemShipGrpInvReservationAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IOrderItemShipGrpInvReservationAggregate aggregate, IOrderItemShipGrpInvReservationState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IOrderItemShipGrpInvReservationStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IOrderItemShipGrpInvReservationAggregate, IOrderItemShipGrpInvReservationState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IOrderItemShipGrpInvReservationStateCreated stateCreated)
        {
            var aggregateId = stateCreated.OrderItemShipGrpInvReservationEventId.OrderItemShipGrpInvResId;
            var state = new OrderItemShipGrpInvReservationState();
            state.OrderItemShipGrpInvResId = aggregateId;
            var aggregate = (OrderItemShipGrpInvReservationAggregate)GetOrderItemShipGrpInvReservationAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IOrderItemShipGrpInvReservationCommand command, IEventStoreAggregateId eventStoreAggregateId, IOrderItemShipGrpInvReservationState state)
		{
			bool repeated = false;
			if (((IOrderItemShipGrpInvReservationStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IOrderItemShipGrpInvReservationEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateOrderItemShipGrpInvReservation c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchOrderItemShipGrpInvReservation c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteOrderItemShipGrpInvReservation c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IOrderItemShipGrpInvReservationState Get(OrderItemShipGrpInvResId orderItemShipGrpInvResId)
        {
            var state = StateRepository.Get(orderItemShipGrpInvResId, true);
            return state;
        }

        public virtual IEnumerable<IOrderItemShipGrpInvReservationState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemShipGrpInvReservationState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemShipGrpInvReservationState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IOrderItemShipGrpInvReservationState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IOrderItemShipGrpInvReservationEvent GetEvent(OrderItemShipGrpInvResId orderItemShipGrpInvResId, long version)
        {
            var e = (IOrderItemShipGrpInvReservationEvent)EventStore.GetEvent(ToEventStoreAggregateId(orderItemShipGrpInvResId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(orderItemShipGrpInvResId, 0);
            }
            return e;
        }

        public virtual IOrderItemShipGrpInvReservationState GetHistoryState(OrderItemShipGrpInvResId orderItemShipGrpInvResId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IOrderItemShipGrpInvReservationEvent), ToEventStoreAggregateId(orderItemShipGrpInvResId), version - 1);
            return new OrderItemShipGrpInvReservationState(eventStream.Events);
        }


		public abstract IOrderItemShipGrpInvReservationAggregate GetOrderItemShipGrpInvReservationAggregate(IOrderItemShipGrpInvReservationState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(OrderItemShipGrpInvResId aggregateId);


	}

}

