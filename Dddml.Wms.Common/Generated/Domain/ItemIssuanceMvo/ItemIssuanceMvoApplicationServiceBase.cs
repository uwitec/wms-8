﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateItemIssuanceMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ItemIssuanceMvo;
using Dddml.Wms.Domain.Shipment;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.ItemIssuanceMvo
{
	public abstract partial class ItemIssuanceMvoApplicationServiceBase : IItemIssuanceMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IItemIssuanceMvoStateRepository StateRepository { get; }

		protected abstract IItemIssuanceMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IItemIssuanceMvoAggregate, IItemIssuanceMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IItemIssuanceMvoAggregate, IItemIssuanceMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected ItemIssuanceMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IItemIssuanceMvoCommand c, Action<IItemIssuanceMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetItemIssuanceMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IItemIssuanceMvoAggregate aggregate, IItemIssuanceMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IItemIssuanceMvoStateProperties)state).ShipmentVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IItemIssuanceMvoAggregate, IItemIssuanceMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IItemIssuanceMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.ItemIssuanceMvoEventId.ShipmentItemIssuanceId;
            var state = new ItemIssuanceMvoState();
            state.ShipmentItemIssuanceId = aggregateId;
            var aggregate = (ItemIssuanceMvoAggregate)GetItemIssuanceMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IItemIssuanceMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IItemIssuanceMvoState state)
		{
			bool repeated = false;
			if (((IItemIssuanceMvoStateProperties)state).ShipmentVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IItemIssuanceMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateItemIssuanceMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchItemIssuanceMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteItemIssuanceMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IItemIssuanceMvoState Get(ShipmentItemIssuanceId shipmentItemIssuanceId)
        {
            var state = StateRepository.Get(shipmentItemIssuanceId, true);
            return state;
        }

        public virtual IEnumerable<IItemIssuanceMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IItemIssuanceMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IItemIssuanceMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IItemIssuanceMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IItemIssuanceMvoStateEvent GetStateEvent(ShipmentItemIssuanceId shipmentItemIssuanceId, long version)
        {
            var e = (IItemIssuanceMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(shipmentItemIssuanceId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(shipmentItemIssuanceId, 0);
            }
            return e;
        }

        public virtual IItemIssuanceMvoState GetHistoryState(ShipmentItemIssuanceId shipmentItemIssuanceId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IItemIssuanceMvoStateEvent), ToEventStoreAggregateId(shipmentItemIssuanceId), version - 1);
            return new ItemIssuanceMvoState(eventStream.Events);
        }


		public abstract IItemIssuanceMvoAggregate GetItemIssuanceMvoAggregate(IItemIssuanceMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(ShipmentItemIssuanceId aggregateId);


	}

}

