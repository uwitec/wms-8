﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLocatorDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Locator;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Locator.NHibernate
{

	public class NHibernateLocatorEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new LocatorEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedEventType()
		{
			return typeof(LocatorEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(LocatorEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<LocatorEventBase>();
            criteria.Add(Restrictions.Eq("LocatorEventId.LocatorId", idObj));
            criteria.Add(Restrictions.Le("LocatorEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("LocatorEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (LocatorEventBase e in es)
            {
                e.EventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((LocatorEventBase)es.Last()).LocatorEventId.Version : default(long),
                Events = es
            };
        }

	}

}

