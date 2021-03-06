﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Picklist
{
	public abstract partial class PicklistApplicationServiceBase : IPicklistApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IPicklistStateRepository StateRepository { get; }

		protected abstract IPicklistStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IPicklistAggregate, IPicklistState> _aggregateEventListener;

        public virtual IAggregateEventListener<IPicklistAggregate, IPicklistState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected PicklistApplicationServiceBase()
		{
		}

		protected virtual void Update(IPicklistCommand c, Action<IPicklistAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetPicklistAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IPicklistAggregate aggregate, IPicklistState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IPicklistStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IPicklistAggregate, IPicklistState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IPicklistStateCreated stateCreated)
        {
            var aggregateId = stateCreated.PicklistEventId.PicklistId;
            var state = new PicklistState();
            state.PicklistId = aggregateId;
            var aggregate = (PicklistAggregate)GetPicklistAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IPicklistCommand command, IEventStoreAggregateId eventStoreAggregateId, IPicklistState state)
		{
			bool repeated = false;
			if (((IPicklistStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IPicklistEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreatePicklist c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchPicklist c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeletePicklist c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IPicklistState Get(string picklistId)
        {
            var state = StateRepository.Get(picklistId, true);
            return state;
        }

        public virtual IEnumerable<IPicklistState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPicklistState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPicklistState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPicklistState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IPicklistEvent GetEvent(string picklistId, long version)
        {
            var e = (IPicklistEvent)EventStore.GetEvent(ToEventStoreAggregateId(picklistId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(picklistId, 0);
            }
            return e;
        }

        public virtual IPicklistState GetHistoryState(string picklistId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IPicklistEvent), ToEventStoreAggregateId(picklistId), version - 1);
            return new PicklistState(eventStream.Events);
        }

        public virtual IPicklistRoleState GetPicklistRole(string picklistId, PartyRoleId partyRoleId)
        {
            return StateQueryRepository.GetPicklistRole(picklistId, partyRoleId);
        }

        public IEnumerable<IPicklistRoleState> GetPicklistRoles(string picklistId)
        {
            return StateQueryRepository.GetPicklistRoles(picklistId);
        }


		public abstract IPicklistAggregate GetPicklistAggregate(IPicklistState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

