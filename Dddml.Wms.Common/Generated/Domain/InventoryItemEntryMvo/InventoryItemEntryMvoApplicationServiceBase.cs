﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.InventoryItemEntryMvo
{
	public abstract partial class InventoryItemEntryMvoApplicationServiceBase : IInventoryItemEntryMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IInventoryItemEntryMvoStateRepository StateRepository { get; }

		protected abstract IInventoryItemEntryMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IInventoryItemEntryMvoAggregate, IInventoryItemEntryMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IInventoryItemEntryMvoAggregate, IInventoryItemEntryMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected InventoryItemEntryMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IInventoryItemEntryMvoCommand c, Action<IInventoryItemEntryMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetInventoryItemEntryMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IInventoryItemEntryMvoAggregate aggregate, IInventoryItemEntryMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IInventoryItemEntryMvoStateProperties)state).InventoryItemVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IInventoryItemEntryMvoAggregate, IInventoryItemEntryMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IInventoryItemEntryMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.InventoryItemEntryMvoEventId.InventoryItemEntryId;
            var state = new InventoryItemEntryMvoState();
            state.InventoryItemEntryId = aggregateId;
            var aggregate = (InventoryItemEntryMvoAggregate)GetInventoryItemEntryMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IInventoryItemEntryMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IInventoryItemEntryMvoState state)
		{
			bool repeated = false;
			if (((IInventoryItemEntryMvoStateProperties)state).InventoryItemVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IInventoryItemEntryMvoEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateInventoryItemEntryMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchInventoryItemEntryMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

        public virtual IInventoryItemEntryMvoState Get(InventoryItemEntryId inventoryItemEntryId)
        {
            var state = StateRepository.Get(inventoryItemEntryId, true);
            return state;
        }

        public virtual IEnumerable<IInventoryItemEntryMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInventoryItemEntryMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInventoryItemEntryMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInventoryItemEntryMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IInventoryItemEntryMvoEvent GetEvent(InventoryItemEntryId inventoryItemEntryId, long version)
        {
            var e = (IInventoryItemEntryMvoEvent)EventStore.GetEvent(ToEventStoreAggregateId(inventoryItemEntryId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(inventoryItemEntryId, 0);
            }
            return e;
        }

        public virtual IInventoryItemEntryMvoState GetHistoryState(InventoryItemEntryId inventoryItemEntryId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IInventoryItemEntryMvoEvent), ToEventStoreAggregateId(inventoryItemEntryId), version - 1);
            return new InventoryItemEntryMvoState(eventStream.Events);
        }


		public abstract IInventoryItemEntryMvoAggregate GetInventoryItemEntryMvoAggregate(IInventoryItemEntryMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(InventoryItemEntryId aggregateId);


	}

}

