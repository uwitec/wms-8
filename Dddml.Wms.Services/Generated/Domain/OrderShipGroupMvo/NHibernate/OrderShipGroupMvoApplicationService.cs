﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipGroupMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipGroupMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.OrderShipGroupMvo.NHibernate
{

	public partial class OrderShipGroupMvoApplicationService : OrderShipGroupMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IOrderShipGroupMvoStateRepository _stateRepository;

		protected override IOrderShipGroupMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IOrderShipGroupMvoStateQueryRepository _stateQueryRepository;

		protected override IOrderShipGroupMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public OrderShipGroupMvoApplicationService(IEventStore eventStore, IOrderShipGroupMvoStateRepository stateRepository, IOrderShipGroupMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(OrderShipGroupId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IOrderShipGroupMvoAggregate GetOrderShipGroupMvoAggregate(IOrderShipGroupMvoState state)
		{
			return new OrderShipGroupMvoAggregate(state);
		}

	}

}

