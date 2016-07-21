﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain
{
	public abstract partial class AttributeSetApplicationServiceBase : IAttributeSetApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IAttributeSetStateRepository StateRepository { get; }

		protected AttributeSetApplicationServiceBase()
		{
		}

		protected virtual void Update(IAttributeSetCommand c, Action<IAttributeSetAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetAttributeSetAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(ToEventStoreAggregateId(aggregateId), ((IAttributeSetStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IAttributeSetCommand command, IEventStoreAggregateId eventStoreAggregateId, IAttributeSetState state)
		{
			bool repeated = false;
			if (((IAttributeSetStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IAttributeSetStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateAttributeSet c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchAttributeSet c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteAttributeSet c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IAttributeSetState Get(string attributeSetId)
        {
            var state = StateRepository.Get(attributeSetId);

            if (state != null && state.IsUnsaved) { state = null; }

            return state;
        }

        public virtual IEnumerable<IAttributeSetState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeSetState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeSetState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IAttributeSetState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = StateRepository.GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
            return StateRepository.GetCount(filter);
		}

        public virtual long GetCount(ICriterion filter)
		{
            return StateRepository.GetCount(filter);
		}

	    public virtual IAttributeSetStateEvent GetStateEvent(string attributeSetId, long version)
        {
            var e = (IAttributeSetStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(attributeSetId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            return e;
        }


		public abstract IAttributeSetAggregate GetAttributeSetAggregate(IAttributeSetState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

