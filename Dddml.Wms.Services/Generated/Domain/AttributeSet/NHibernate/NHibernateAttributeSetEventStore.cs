﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.AttributeSet.NHibernate
{

	public class NHibernateAttributeSetEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new AttributeSetEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(AttributeSetStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(AttributeSetStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<AttributeSetStateEventBase>();
            criteria.Add(Restrictions.Eq("AttributeSetEventId.AttributeSetId", idObj));
            criteria.Add(Restrictions.Le("AttributeSetEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("AttributeSetEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (AttributeSetStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((AttributeSetStateEventBase)es.Last()).AttributeSetEventId.Version : default(long),
                Events = es
            };
        }

	}

}

