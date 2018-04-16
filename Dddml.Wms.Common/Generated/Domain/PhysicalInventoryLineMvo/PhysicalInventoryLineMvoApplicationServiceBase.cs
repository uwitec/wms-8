﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.PhysicalInventoryLineMvo
{
	public abstract partial class PhysicalInventoryLineMvoApplicationServiceBase : IPhysicalInventoryLineMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IPhysicalInventoryLineMvoStateRepository StateRepository { get; }

		protected abstract IPhysicalInventoryLineMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IPhysicalInventoryLineMvoAggregate, IPhysicalInventoryLineMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IPhysicalInventoryLineMvoAggregate, IPhysicalInventoryLineMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected PhysicalInventoryLineMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IPhysicalInventoryLineMvoCommand c, Action<IPhysicalInventoryLineMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetPhysicalInventoryLineMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IPhysicalInventoryLineMvoAggregate aggregate, IPhysicalInventoryLineMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IPhysicalInventoryLineMvoStateProperties)state).PhysicalInventoryVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IPhysicalInventoryLineMvoAggregate, IPhysicalInventoryLineMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IPhysicalInventoryLineMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.PhysicalInventoryLineMvoEventId.PhysicalInventoryLineId;
            var state = new PhysicalInventoryLineMvoState();
            state.PhysicalInventoryLineId = aggregateId;
            var aggregate = (PhysicalInventoryLineMvoAggregate)GetPhysicalInventoryLineMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IPhysicalInventoryLineMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IPhysicalInventoryLineMvoState state)
		{
			bool repeated = false;
			if (((IPhysicalInventoryLineMvoStateProperties)state).PhysicalInventoryVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IPhysicalInventoryLineMvoEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreatePhysicalInventoryLineMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchPhysicalInventoryLineMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeletePhysicalInventoryLineMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IPhysicalInventoryLineMvoState Get(PhysicalInventoryLineId physicalInventoryLineId)
        {
            var state = StateRepository.Get(physicalInventoryLineId, true);
            return state;
        }

        public virtual IEnumerable<IPhysicalInventoryLineMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPhysicalInventoryLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPhysicalInventoryLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IPhysicalInventoryLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IPhysicalInventoryLineMvoEvent GetEvent(PhysicalInventoryLineId physicalInventoryLineId, long version)
        {
            var e = (IPhysicalInventoryLineMvoEvent)EventStore.GetEvent(ToEventStoreAggregateId(physicalInventoryLineId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(physicalInventoryLineId, 0);
            }
            return e;
        }

        public virtual IPhysicalInventoryLineMvoState GetHistoryState(PhysicalInventoryLineId physicalInventoryLineId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IPhysicalInventoryLineMvoEvent), ToEventStoreAggregateId(physicalInventoryLineId), version - 1);
            return new PhysicalInventoryLineMvoState(eventStream.Events);
        }


		public abstract IPhysicalInventoryLineMvoAggregate GetPhysicalInventoryLineMvoAggregate(IPhysicalInventoryLineMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(PhysicalInventoryLineId aggregateId);


	}

}

