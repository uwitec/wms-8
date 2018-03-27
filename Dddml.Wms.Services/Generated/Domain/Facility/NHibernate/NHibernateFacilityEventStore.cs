﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateFacilityDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Facility;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Facility.NHibernate
{

	public class NHibernateFacilityEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new FacilityEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(FacilityStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(FacilityStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<FacilityStateEventBase>();
            criteria.Add(Restrictions.Eq("FacilityEventId.FacilityId", idObj));
            criteria.Add(Restrictions.Le("FacilityEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("FacilityEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (FacilityStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((FacilityStateEventBase)es.Last()).FacilityEventId.Version : default(long),
                Events = es
            };
        }

	}

}

