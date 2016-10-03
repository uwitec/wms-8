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
	public abstract partial class UserClaimMvoApplicationServiceBase : IUserClaimMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IUserClaimMvoStateRepository StateRepository { get; }

		protected UserClaimMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IUserClaimMvoCommand c, Action<IUserClaimMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetUserClaimMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(eventStoreAggregateId, ((IUserClaimMvoStateProperties)state).UserVersion, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IUserClaimMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IUserClaimMvoState state)
		{
			bool repeated = false;
			if (((IUserClaimMvoStateProperties)state).UserVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IUserClaimMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateUserClaimMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchUserClaimMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteUserClaimMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IUserClaimMvoState Get(UserClaimId userClaimId)
        {
            var state = StateRepository.Get(userClaimId, true);
            return state;
        }

        public virtual IEnumerable<IUserClaimMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserClaimMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserClaimMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserClaimMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IUserClaimMvoStateEvent GetStateEvent(UserClaimId userClaimId, long version)
        {
            var e = (IUserClaimMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(userClaimId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(userClaimId, 0);
            }
            return e;
        }

        public virtual IUserClaimMvoState GetHistoryState(UserClaimId userClaimId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IUserClaimMvoStateEvent), ToEventStoreAggregateId(userClaimId), version - 1);
            return new UserClaimMvoState(eventStream.Events);
        }


		public abstract IUserClaimMvoAggregate GetUserClaimMvoAggregate(IUserClaimMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(UserClaimId aggregateId);


	}

}

