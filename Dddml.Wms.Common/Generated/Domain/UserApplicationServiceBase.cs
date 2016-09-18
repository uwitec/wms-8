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
	public abstract partial class UserApplicationServiceBase : IUserApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IUserStateRepository StateRepository { get; }

		protected UserApplicationServiceBase()
		{
		}

		protected virtual void Update(IUserCommand c, Action<IUserAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetUserAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(eventStoreAggregateId, ((IUserStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IUserCommand command, IEventStoreAggregateId eventStoreAggregateId, IUserState state)
		{
			bool repeated = false;
			if (((IUserStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IUserStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateUser c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchUser c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteUser c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IUserState Get(string userId)
        {

            var state = StateRepository.Get(userId, true);
            return state;
        }

        public virtual IEnumerable<IUserState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IUserState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IUserStateEvent GetStateEvent(string userId, long version)
        {
            var e = (IUserStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(userId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(userId, 0);
            }
            return e;
        }

        public virtual IUserState GetHistoryState(string userId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IUserStateEvent), ToEventStoreAggregateId(userId), version - 1);
            return new UserState(eventStream.Events);
        }

        public virtual IUserRoleState GetUserRole(string userId, string roleId)
        {
            return StateRepository.GetUserRole(userId, roleId);
        }

        public virtual IUserClaimState GetUserClaim(string userId, int claimId)
        {
            return StateRepository.GetUserClaim(userId, claimId);
        }

        public virtual IUserPermissionState GetUserPermission(string userId, string permissionId)
        {
            return StateRepository.GetUserPermission(userId, permissionId);
        }

        public virtual IUserLoginState GetUserLogin(string userId, LoginKey loginKey)
        {
            return StateRepository.GetUserLogin(userId, loginKey);
        }


		public abstract IUserAggregate GetUserAggregate(IUserState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

