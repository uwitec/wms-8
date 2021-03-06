﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentMethodTypeDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentMethodType;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.ShipmentMethodType.NHibernate
{

	public partial class ShipmentMethodTypeApplicationService : ShipmentMethodTypeApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IShipmentMethodTypeStateRepository _stateRepository;

		protected override IShipmentMethodTypeStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IShipmentMethodTypeStateQueryRepository _stateQueryRepository;

		protected override IShipmentMethodTypeStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public ShipmentMethodTypeApplicationService(IEventStore eventStore, IShipmentMethodTypeStateRepository stateRepository, IShipmentMethodTypeStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IShipmentMethodTypeAggregate GetShipmentMethodTypeAggregate(IShipmentMethodTypeState state)
		{
			return new ShipmentMethodTypeAggregate(state);
		}

	}

}

