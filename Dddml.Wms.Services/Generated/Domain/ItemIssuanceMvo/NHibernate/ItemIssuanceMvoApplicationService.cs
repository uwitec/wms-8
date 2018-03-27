﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateItemIssuanceMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ItemIssuanceMvo;
using Dddml.Wms.Domain.Shipment;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.ItemIssuanceMvo.NHibernate
{

	public partial class ItemIssuanceMvoApplicationService : ItemIssuanceMvoApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IItemIssuanceMvoStateRepository _stateRepository;

		protected override IItemIssuanceMvoStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IItemIssuanceMvoStateQueryRepository _stateQueryRepository;

		protected override IItemIssuanceMvoStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public ItemIssuanceMvoApplicationService(IEventStore eventStore, IItemIssuanceMvoStateRepository stateRepository, IItemIssuanceMvoStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(ShipmentItemIssuanceId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IItemIssuanceMvoAggregate GetItemIssuanceMvoAggregate(IItemIssuanceMvoState state)
		{
			return new ItemIssuanceMvoAggregate(state);
		}

	}

}

