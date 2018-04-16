﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateWarehouseDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Warehouse;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Warehouse
{
	public abstract partial class WarehouseApplicationServiceBase : IWarehouseApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IWarehouseStateRepository StateRepository { get; }

		protected abstract IWarehouseStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IWarehouseAggregate, IWarehouseState> _aggregateEventListener;

        public virtual IAggregateEventListener<IWarehouseAggregate, IWarehouseState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected WarehouseApplicationServiceBase()
		{
		}

		protected virtual void Update(IWarehouseCommand c, Action<IWarehouseAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetWarehouseAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IWarehouseAggregate aggregate, IWarehouseState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IWarehouseStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IWarehouseAggregate, IWarehouseState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IWarehouseStateCreated stateCreated)
        {
            var aggregateId = stateCreated.WarehouseEventId.WarehouseId;
            var state = new WarehouseState();
            state.WarehouseId = aggregateId;
            var aggregate = (WarehouseAggregate)GetWarehouseAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IWarehouseCommand command, IEventStoreAggregateId eventStoreAggregateId, IWarehouseState state)
		{
			bool repeated = false;
			if (((IWarehouseStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IWarehouseEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateWarehouse c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchWarehouse c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteWarehouse c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IWarehouseState Get(string warehouseId)
        {
            var state = StateRepository.Get(warehouseId, true);
            return state;
        }

        public virtual IEnumerable<IWarehouseState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IWarehouseState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IWarehouseState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IWarehouseState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IWarehouseEvent GetEvent(string warehouseId, long version)
        {
            var e = (IWarehouseEvent)EventStore.GetEvent(ToEventStoreAggregateId(warehouseId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(warehouseId, 0);
            }
            return e;
        }

        public virtual IWarehouseState GetHistoryState(string warehouseId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IWarehouseEvent), ToEventStoreAggregateId(warehouseId), version - 1);
            return new WarehouseState(eventStream.Events);
        }


		public abstract IWarehouseAggregate GetWarehouseAggregate(IWarehouseState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

