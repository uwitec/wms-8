﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateGoodIdentificationTypeDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.GoodIdentificationType;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.GoodIdentificationType.NHibernate
{

	public partial class GoodIdentificationTypeApplicationService : GoodIdentificationTypeApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IGoodIdentificationTypeStateRepository _stateRepository;

		protected override IGoodIdentificationTypeStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IGoodIdentificationTypeStateQueryRepository _stateQueryRepository;

		protected override IGoodIdentificationTypeStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public GoodIdentificationTypeApplicationService(IEventStore eventStore, IGoodIdentificationTypeStateRepository stateRepository, IGoodIdentificationTypeStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IGoodIdentificationTypeAggregate GetGoodIdentificationTypeAggregate(IGoodIdentificationTypeState state)
		{
			return new GoodIdentificationTypeAggregate(state);
		}

	}

}

