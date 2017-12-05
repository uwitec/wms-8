﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeValueMvo
{
	public abstract partial class AttributeValueMvoApplicationServiceBase : IAttributeValueMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IAttributeValueMvoStateRepository StateRepository { get; }

		protected abstract IAttributeValueMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IAttributeValueMvoAggregate, IAttributeValueMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IAttributeValueMvoAggregate, IAttributeValueMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected AttributeValueMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IAttributeValueMvoCommand c, Action<IAttributeValueMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetAttributeValueMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IAttributeValueMvoAggregate aggregate, IAttributeValueMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IAttributeValueMvoStateProperties)state).AttributeVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IAttributeValueMvoAggregate, IAttributeValueMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IAttributeValueMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.StateEventId.AttributeValueId;
            var state = new AttributeValueMvoState();
            state.AttributeValueId = aggregateId;
            var aggregate = (AttributeValueMvoAggregate)GetAttributeValueMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IAttributeValueMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IAttributeValueMvoState state)
		{
			bool repeated = false;
			if (((IAttributeValueMvoStateProperties)state).AttributeVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IAttributeValueMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateAttributeValueMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchAttributeValueMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteAttributeValueMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IAttributeValueMvoState Get(AttributeValueId attributeValueId)
        {
            var state = StateRepository.Get(attributeValueId, true);
            return state;
        }

        public virtual IEnumerable<IAttributeValueMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeValueMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeValueMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeValueMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IAttributeValueMvoStateEvent GetStateEvent(AttributeValueId attributeValueId, long version)
        {
            var e = (IAttributeValueMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(attributeValueId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(attributeValueId, 0);
            }
            return e;
        }

        public virtual IAttributeValueMvoState GetHistoryState(AttributeValueId attributeValueId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IAttributeValueMvoStateEvent), ToEventStoreAggregateId(attributeValueId), version - 1);
            return new AttributeValueMvoState(eventStream.Events);
        }


		public abstract IAttributeValueMvoAggregate GetAttributeValueMvoAggregate(IAttributeValueMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(AttributeValueId aggregateId);


	}

}

