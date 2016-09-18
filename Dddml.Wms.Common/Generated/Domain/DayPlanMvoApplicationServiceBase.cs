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
	public abstract partial class DayPlanMvoApplicationServiceBase : IDayPlanMvoApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IDayPlanMvoStateRepository StateRepository { get; }

		protected DayPlanMvoApplicationServiceBase()
		{
		}

		protected virtual void Update(IDayPlanMvoCommand c, Action<IDayPlanMvoAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId);
			var aggregate = GetDayPlanMvoAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			EventStore.AppendEvents(eventStoreAggregateId, ((IDayPlanMvoStateProperties)state).PersonVersion, aggregate.Changes, () => { StateRepository.Save(state); });
		}


		protected bool IsRepeatedCommand(IDayPlanMvoCommand command, IEventStoreAggregateId eventStoreAggregateId, IDayPlanMvoState state)
		{
			bool repeated = false;
			if (((IDayPlanMvoStateProperties)state).PersonVersion > command.AggregateVersion)
			{
				var lastEvent = EventStore.FindLastEvent(typeof(IDayPlanMvoStateEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateDayPlanMvo c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchDayPlanMvo c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteDayPlanMvo c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IDayPlanMvoState Get(DayPlanId dayPlanId)
        {

            var state = StateRepository.Get(dayPlanId, true);
            return state;
        }

        public virtual IEnumerable<IDayPlanMvoState> GetAll(int firstResult, int maxResults)
		{
            var states = StateRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IDayPlanMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IDayPlanMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IDayPlanMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IDayPlanMvoStateEvent GetStateEvent(DayPlanId dayPlanId, long version)
        {
            var e = (IDayPlanMvoStateEvent)EventStore.GetStateEvent(ToEventStoreAggregateId(dayPlanId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetStateEvent(dayPlanId, 0);
            }
            return e;
        }

        public virtual IDayPlanMvoState GetHistoryState(DayPlanId dayPlanId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IDayPlanMvoStateEvent), ToEventStoreAggregateId(dayPlanId), version - 1);
            return new DayPlanMvoState(eventStream.Events);
        }


		public abstract IDayPlanMvoAggregate GetDayPlanMvoAggregate(IDayPlanMvoState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(DayPlanId aggregateId);


	}

}

