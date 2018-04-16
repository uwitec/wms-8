﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserLoginMvo;
using Dddml.Wms.Domain.User;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.UserLoginMvo
{
	public abstract partial class UserLoginMvoApplicationServiceBase : IUserLoginMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IUserLoginMvoStateRepository StateRepository { get; }

		protected abstract IUserLoginMvoStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IUserLoginMvoAggregate, IUserLoginMvoState> _aggregateEventListener;

        public virtual IAggregateEventListener<IUserLoginMvoAggregate, IUserLoginMvoState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected UserLoginMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IUserLoginMvoCommand c, Action<IUserLoginMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetUserLoginMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IUserLoginMvoAggregate aggregate, IUserLoginMvoState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IUserLoginMvoStateProperties)state).UserVersion, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IUserLoginMvoAggregate, IUserLoginMvoState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IUserLoginMvoStateCreated stateCreated)
        {
            var aggregateId = stateCreated.UserLoginMvoEventId.UserLoginId;
            var state = new UserLoginMvoState();
            state.UserLoginId = aggregateId;
            var aggregate = (UserLoginMvoAggregate)GetUserLoginMvoAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IUserLoginMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IUserLoginMvoState state)
		{
			bool repeated = false;
			if (((IUserLoginMvoStateProperties)state).UserVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IUserLoginMvoEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateUserLoginMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchUserLoginMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteUserLoginMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IUserLoginMvoState Get(UserLoginId userLoginId)
        {
            var state = StateRepository.Get(userLoginId, true);
            return state;
        }

        public virtual IEnumerable<IUserLoginMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserLoginMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserLoginMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserLoginMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IUserLoginMvoEvent GetEvent(UserLoginId userLoginId, long version)
        {
            var e = (IUserLoginMvoEvent)EventStore.GetEvent(ToEventStoreAggregateId(userLoginId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(userLoginId, 0);
            }
            return e;
        }

        public virtual IUserLoginMvoState GetHistoryState(UserLoginId userLoginId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IUserLoginMvoEvent), ToEventStoreAggregateId(userLoginId), version - 1);
            return new UserLoginMvoState(eventStream.Events);
        }


		public abstract IUserLoginMvoAggregate GetUserLoginMvoAggregate(IUserLoginMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(UserLoginId aggregateId);


	}

}

