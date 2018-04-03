﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateContactMechDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ContactMech;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.ContactMech
{
	public abstract partial class ContactMechApplicationServiceBase : IContactMechApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IContactMechStateRepository StateRepository { get; }

		protected abstract IContactMechStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IContactMechAggregate, IContactMechState> _aggregateEventListener;

        public virtual IAggregateEventListener<IContactMechAggregate, IContactMechState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected ContactMechApplicationServiceBase()
		{
		}

		protected virtual void Update(IContactMechCommand c, Action<IContactMechAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetContactMechAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IContactMechAggregate aggregate, IContactMechState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IContactMechStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IContactMechAggregate, IContactMechState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IContactMechStateCreated stateCreated)
        {
            var aggregateId = stateCreated.ContactMechEventId.ContactMechId;
            var state = new ContactMechState();
            state.ContactMechId = aggregateId;
            var aggregate = (ContactMechAggregate)GetContactMechAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IContactMechCommand command, IEventStoreAggregateId eventStoreAggregateId, IContactMechState state)
		{
			bool repeated = false;
			if (((IContactMechStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IContactMechStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateContactMech c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchContactMech c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteContactMech c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IContactMechState Get(string contactMechId)
        {
            var state = StateRepository.Get(contactMechId, true);
            return state;
        }

        public virtual IEnumerable<IContactMechState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IContactMechState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IContactMechState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IContactMechState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IContactMechStateEvent GetStateEvent(string contactMechId, long version)
        {
            var e = (IContactMechStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(contactMechId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(contactMechId, 0);
            }
            return e;
        }

        public virtual IContactMechState GetHistoryState(string contactMechId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IContactMechStateEvent), ToEventStoreAggregateId(contactMechId), version - 1);
            return new ContactMechState(eventStream.Events);
        }


		public abstract IContactMechAggregate GetContactMechAggregate(IContactMechState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}
