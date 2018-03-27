﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderRoleMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderRoleMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.OrderRoleMvo.NHibernate
{

	public partial class OrderRoleMvoApplicationService : OrderRoleMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IOrderRoleMvoStateRepository _stateRepository;

		protected override IOrderRoleMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IOrderRoleMvoStateQueryRepository _stateQueryRepository;

		protected override IOrderRoleMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public OrderRoleMvoApplicationService(IEventStore eventStore, IOrderRoleMvoStateRepository stateRepository, IOrderRoleMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(OrderRoleId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IOrderRoleMvoAggregate GetOrderRoleMvoAggregate(IOrderRoleMvoState state)
		{
			return new OrderRoleMvoAggregate(state);
		}

	}

}

