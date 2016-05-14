﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public abstract partial class AttributeApplicationServiceBase : IAttributeApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IAttributeStateRepository StateRepository { get; }

		protected AttributeApplicationServiceBase()
		{
		}

		protected virtual void Update(IAttributeCommand c, Action<IAttributeAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetAttributeAggregate(state);

			var eventStoreAaggregateId = ToEventStoreAaggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAaggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(ToEventStoreAaggregateId(aggregateId), state.Version, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IAttributeCommand command, IEventStoreAggregateId eventStoreAaggregateId, IAttributeState state)
		{
			bool repeated = false;
			if (state.Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IAttributeStateEvent), eventStoreAaggregateId, command.AggregateVersion);
				if (lastEvent != null && lastEvent.CommandId == command.CommandId)////TODO CommandId 太特殊了！！！
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


		public virtual void When(ICreateAttribute c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchAttribute c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteAttribute c)
		{
			Update(c, ar => ar.Delete(c));
		}

 		public virtual IAttributeState Get(string attributeId)
		{
            var state = StateRepository.Get(attributeId);
			return state;
		}

        public virtual IEnumerable<IAttributeState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

		public abstract IAttributeAggregate GetAttributeAggregate(IAttributeState state);

		public abstract IEventStoreAggregateId ToEventStoreAaggregateId(string aggregateId);


	}

}
