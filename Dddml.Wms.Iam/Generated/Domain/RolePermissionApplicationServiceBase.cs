﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RolePermission;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.RolePermission
{
	public abstract partial class RolePermissionApplicationServiceBase : IRolePermissionApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IRolePermissionStateRepository StateRepository { get; }

		protected abstract IRolePermissionStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IRolePermissionAggregate, IRolePermissionState> _aggregateEventListener;

        public virtual IAggregateEventListener<IRolePermissionAggregate, IRolePermissionState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected RolePermissionApplicationServiceBase()
		{
		}

		protected virtual void Update(IRolePermissionCommand c, Action<IRolePermissionAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetRolePermissionAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IRolePermissionAggregate aggregate, IRolePermissionState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IRolePermissionStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IRolePermissionAggregate, IRolePermissionState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IRolePermissionStateCreated stateCreated)
        {
            var aggregateId = stateCreated.RolePermissionEventId.Id;
            var state = new RolePermissionState();
            state.Id = aggregateId;
            var aggregate = (RolePermissionAggregate)GetRolePermissionAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IRolePermissionCommand command, IEventStoreAggregateId eventStoreAggregateId, IRolePermissionState state)
		{
			bool repeated = false;
			if (((IRolePermissionStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IRolePermissionStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateRolePermission c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchRolePermission c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteRolePermission c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IRolePermissionState Get(RolePermissionId id)
        {
            var state = StateRepository.Get(id, true);
            return state;
        }

        public virtual IEnumerable<IRolePermissionState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IRolePermissionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IRolePermissionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IRolePermissionState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IRolePermissionStateEvent GetStateEvent(RolePermissionId id, long version)
        {
            var e = (IRolePermissionStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(id), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(id, 0);
            }
            return e;
        }

        public virtual IRolePermissionState GetHistoryState(RolePermissionId id, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IRolePermissionStateEvent), ToEventStoreAggregateId(id), version - 1);
            return new RolePermissionState(eventStream.Events);
        }


		public abstract IRolePermissionAggregate GetRolePermissionAggregate(IRolePermissionState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(RolePermissionId aggregateId);


	}

}

