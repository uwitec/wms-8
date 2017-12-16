﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Shipment.NHibernate
{

	public class ShipmentApplicationService : ShipmentApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IShipmentStateRepository _stateRepository;

		protected override IShipmentStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IShipmentStateQueryRepository _stateQueryRepository;

		protected override IShipmentStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public ShipmentApplicationService(IEventStore eventStore, IShipmentStateRepository stateRepository, IShipmentStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IShipmentAggregate GetShipmentAggregate(IShipmentState state)
		{
			return new ShipmentAggregate(state);
		}

	}

}

