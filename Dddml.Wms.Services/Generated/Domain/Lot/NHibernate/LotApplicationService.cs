﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLotDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Lot;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Lot.NHibernate
{

	public class LotApplicationService : LotApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private ILotStateRepository _stateRepository;

		protected override ILotStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private ILotStateQueryRepository _stateQueryRepository;

		protected override ILotStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public LotApplicationService(IEventStore eventStore, ILotStateRepository stateRepository, ILotStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override ILotAggregate GetLotAggregate(ILotState state)
		{
			return new LotAggregate(state);
		}

	}

}

