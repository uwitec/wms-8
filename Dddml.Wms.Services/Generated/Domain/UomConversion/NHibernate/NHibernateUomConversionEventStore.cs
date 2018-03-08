﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomConversionDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomConversion;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.UomConversion.NHibernate
{

	public class NHibernateUomConversionEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new UomConversionEventId((UomConversionId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(UomConversionStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(UomConversionStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            UomConversionId idObj = (UomConversionId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<UomConversionStateEventBase>();
            criteria.Add(Restrictions.Eq("UomConversionEventId.UomConversionIdUomId", idObj.UomId));
            criteria.Add(Restrictions.Eq("UomConversionEventId.UomConversionIdUomIdTo", idObj.UomIdTo));
            criteria.Add(Restrictions.Le("UomConversionEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("UomConversionEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (UomConversionStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((UomConversionStateEventBase)es.Last()).UomConversionEventId.Version : default(long),
                Events = es
            };
        }

	}

}

