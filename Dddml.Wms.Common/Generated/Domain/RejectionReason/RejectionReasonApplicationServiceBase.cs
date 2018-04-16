﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRejectionReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RejectionReason;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.RejectionReason
{
	public abstract partial class RejectionReasonApplicationServiceBase : IRejectionReasonApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IRejectionReasonStateRepository StateRepository { get; }

		protected abstract IRejectionReasonStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IRejectionReasonAggregate, IRejectionReasonState> _aggregateEventListener;

        public virtual IAggregateEventListener<IRejectionReasonAggregate, IRejectionReasonState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected RejectionReasonApplicationServiceBase()
		{
		}

		protected virtual void Update(IRejectionReasonCommand c, Action<IRejectionReasonAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetRejectionReasonAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IRejectionReasonAggregate aggregate, IRejectionReasonState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IRejectionReasonStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IRejectionReasonAggregate, IRejectionReasonState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IRejectionReasonStateCreated stateCreated)
        {
            var aggregateId = stateCreated.RejectionReasonEventId.RejectionReasonId;
            var state = new RejectionReasonState();
            state.RejectionReasonId = aggregateId;
            var aggregate = (RejectionReasonAggregate)GetRejectionReasonAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IRejectionReasonCommand command, IEventStoreAggregateId eventStoreAggregateId, IRejectionReasonState state)
		{
			bool repeated = false;
			if (((IRejectionReasonStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IRejectionReasonEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateRejectionReason c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchRejectionReason c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteRejectionReason c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IRejectionReasonState Get(string rejectionReasonId)
        {
            var state = StateRepository.Get(rejectionReasonId, true);
            return state;
        }

        public virtual IEnumerable<IRejectionReasonState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IRejectionReasonState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IRejectionReasonState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IRejectionReasonState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IRejectionReasonEvent GetEvent(string rejectionReasonId, long version)
        {
            var e = (IRejectionReasonEvent)EventStore.GetEvent(ToEventStoreAggregateId(rejectionReasonId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(rejectionReasonId, 0);
            }
            return e;
        }

        public virtual IRejectionReasonState GetHistoryState(string rejectionReasonId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IRejectionReasonEvent), ToEventStoreAggregateId(rejectionReasonId), version - 1);
            return new RejectionReasonState(eventStream.Events);
        }


		public abstract IRejectionReasonAggregate GetRejectionReasonAggregate(IRejectionReasonState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

