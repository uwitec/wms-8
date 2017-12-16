﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateStatusItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.StatusItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.StatusItem
{
	public abstract partial class StatusItemApplicationServiceBase : IStatusItemApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IStatusItemStateRepository StateRepository { get; }

		protected abstract IStatusItemStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IStatusItemAggregate, IStatusItemState> _aggregateEventListener;

        public virtual IAggregateEventListener<IStatusItemAggregate, IStatusItemState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected StatusItemApplicationServiceBase()
		{
		}

		protected virtual void Update(IStatusItemCommand c, Action<IStatusItemAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetStatusItemAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IStatusItemAggregate aggregate, IStatusItemState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IStatusItemStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IStatusItemAggregate, IStatusItemState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IStatusItemStateCreated stateCreated)
        {
            var aggregateId = stateCreated.StateEventId.StatusId;
            var state = new StatusItemState();
            state.StatusId = aggregateId;
            var aggregate = (StatusItemAggregate)GetStatusItemAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IStatusItemCommand command, IEventStoreAggregateId eventStoreAggregateId, IStatusItemState state)
		{
			bool repeated = false;
			if (((IStatusItemStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IStatusItemStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateStatusItem c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchStatusItem c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

        public virtual IStatusItemState Get(string statusId)
        {
            var state = StateRepository.Get(statusId, true);
            return state;
        }

        public virtual IEnumerable<IStatusItemState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IStatusItemState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IStatusItemState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IStatusItemState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IStatusItemStateEvent GetStateEvent(string statusId, long version)
        {
            var e = (IStatusItemStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(statusId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(statusId, 0);
            }
            return e;
        }

        public virtual IStatusItemState GetHistoryState(string statusId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IStatusItemStateEvent), ToEventStoreAggregateId(statusId), version - 1);
            return new StatusItemState(eventStream.Events);
        }


		public abstract IStatusItemAggregate GetStatusItemAggregate(IStatusItemState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

