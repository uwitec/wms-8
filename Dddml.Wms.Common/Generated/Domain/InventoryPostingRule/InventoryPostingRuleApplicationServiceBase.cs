﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryPostingRuleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPostingRule;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.InventoryPostingRule
{
	public abstract partial class InventoryPostingRuleApplicationServiceBase : IInventoryPostingRuleApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IInventoryPostingRuleStateRepository StateRepository { get; }

		protected abstract IInventoryPostingRuleStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IInventoryPostingRuleAggregate, IInventoryPostingRuleState> _aggregateEventListener;

        public virtual IAggregateEventListener<IInventoryPostingRuleAggregate, IInventoryPostingRuleState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected InventoryPostingRuleApplicationServiceBase()
		{
		}

		protected virtual void Update(IInventoryPostingRuleCommand c, Action<IInventoryPostingRuleAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetInventoryPostingRuleAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IInventoryPostingRuleAggregate aggregate, IInventoryPostingRuleState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IInventoryPostingRuleStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IInventoryPostingRuleAggregate, IInventoryPostingRuleState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IInventoryPostingRuleStateCreated stateCreated)
        {
            var aggregateId = stateCreated.InventoryPostingRuleEventId.InventoryPostingRuleId;
            var state = new InventoryPostingRuleState();
            state.InventoryPostingRuleId = aggregateId;
            var aggregate = (InventoryPostingRuleAggregate)GetInventoryPostingRuleAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IInventoryPostingRuleCommand command, IEventStoreAggregateId eventStoreAggregateId, IInventoryPostingRuleState state)
		{
			bool repeated = false;
			if (((IInventoryPostingRuleStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IInventoryPostingRuleStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateInventoryPostingRule c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchInventoryPostingRule c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteInventoryPostingRule c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IInventoryPostingRuleState Get(string inventoryPostingRuleId)
        {
            var state = StateRepository.Get(inventoryPostingRuleId, true);
            return state;
        }

        public virtual IEnumerable<IInventoryPostingRuleState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInventoryPostingRuleState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInventoryPostingRuleState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IInventoryPostingRuleState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IInventoryPostingRuleStateEvent GetStateEvent(string inventoryPostingRuleId, long version)
        {
            var e = (IInventoryPostingRuleStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(inventoryPostingRuleId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(inventoryPostingRuleId, 0);
            }
            return e;
        }

        public virtual IInventoryPostingRuleState GetHistoryState(string inventoryPostingRuleId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IInventoryPostingRuleStateEvent), ToEventStoreAggregateId(inventoryPostingRuleId), version - 1);
            return new InventoryPostingRuleState(eventStream.Events);
        }


		public abstract IInventoryPostingRuleAggregate GetInventoryPostingRuleAggregate(IInventoryPostingRuleState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

