﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackage;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.ShipmentPackage.NHibernate
{

	public partial class ShipmentPackageApplicationService : ShipmentPackageApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IShipmentPackageStateRepository _stateRepository;

		protected override IShipmentPackageStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IShipmentPackageStateQueryRepository _stateQueryRepository;

		protected override IShipmentPackageStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public ShipmentPackageApplicationService(IEventStore eventStore, IShipmentPackageStateRepository stateRepository, IShipmentPackageStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(ShipmentPackageId aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IShipmentPackageAggregate GetShipmentPackageAggregate(IShipmentPackageState state)
		{
			return new ShipmentPackageAggregate(state);
		}

	}

}

