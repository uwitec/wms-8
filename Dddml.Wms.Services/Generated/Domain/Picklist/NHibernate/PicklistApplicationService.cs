﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Picklist.NHibernate
{

	public partial class PicklistApplicationService : PicklistApplicationServiceBase
	{

		private IEventStore _eventStore;

		protected override IEventStore EventStore
		{
			get
			{
				return _eventStore;
			}
		}

		private IPicklistStateRepository _stateRepository;

		protected override IPicklistStateRepository StateRepository
		{
			get
			{
				return _stateRepository;
			}
		}

		private IPicklistStateQueryRepository _stateQueryRepository;

		protected override IPicklistStateQueryRepository StateQueryRepository
		{
			get
			{
				return _stateQueryRepository;
			}
		}

		public PicklistApplicationService(IEventStore eventStore, IPicklistStateRepository stateRepository, IPicklistStateQueryRepository stateQueryRepository)
		{
			this._eventStore = eventStore;
			this._stateRepository = stateRepository;
			this._stateQueryRepository = stateQueryRepository;
		}

		public override IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId)
		{
			return new EventStoreAggregateId(aggregateId);
		}

		public override IPicklistAggregate GetPicklistAggregate(IPicklistState state)
		{
			return new PicklistAggregate(state);
		}

	}

}

