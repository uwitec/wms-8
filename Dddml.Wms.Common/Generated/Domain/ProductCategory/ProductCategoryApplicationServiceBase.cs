﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.ProductCategory
{
	public abstract partial class ProductCategoryApplicationServiceBase : IProductCategoryApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IProductCategoryStateRepository StateRepository { get; }

		protected abstract IProductCategoryStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IProductCategoryAggregate, IProductCategoryState> _aggregateEventListener;

        public virtual IAggregateEventListener<IProductCategoryAggregate, IProductCategoryState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected ProductCategoryApplicationServiceBase()
		{
		}

		protected virtual void Update(IProductCategoryCommand c, Action<IProductCategoryAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetProductCategoryAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IProductCategoryAggregate aggregate, IProductCategoryState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IProductCategoryStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IProductCategoryAggregate, IProductCategoryState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IProductCategoryStateCreated stateCreated)
        {
            var aggregateId = stateCreated.ProductCategoryEventId.ProductCategoryId;
            var state = new ProductCategoryState();
            state.ProductCategoryId = aggregateId;
            var aggregate = (ProductCategoryAggregate)GetProductCategoryAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IProductCategoryCommand command, IEventStoreAggregateId eventStoreAggregateId, IProductCategoryState state)
		{
			bool repeated = false;
			if (((IProductCategoryStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IProductCategoryEvent), eventStoreAggregateId, command.AggregateVersion);
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


		public virtual void When(ICreateProductCategory c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchProductCategory c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(IDeleteProductCategory c)
		{
			Update(c, ar => ar.Delete(c));
		}

        public virtual IProductCategoryState Get(string productCategoryId)
        {
            var state = StateRepository.Get(productCategoryId, true);
            return state;
        }

        public virtual IEnumerable<IProductCategoryState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IProductCategoryState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IProductCategoryState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IProductCategoryState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
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

	    public virtual IProductCategoryEvent GetEvent(string productCategoryId, long version)
        {
            var e = (IProductCategoryEvent)EventStore.GetEvent(ToEventStoreAggregateId(productCategoryId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(productCategoryId, 0);
            }
            return e;
        }

        public virtual IProductCategoryState GetHistoryState(string productCategoryId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IProductCategoryEvent), ToEventStoreAggregateId(productCategoryId), version - 1);
            return new ProductCategoryState(eventStream.Events);
        }

        public virtual IEnumerable<IProductCategoryState> GetChildProductCategories(string productCategoryId)
        {
            var states = StateQueryRepository.GetChildProductCategories(productCategoryId);
			return states;
        }


		public abstract IProductCategoryAggregate GetProductCategoryAggregate(IProductCategoryState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

