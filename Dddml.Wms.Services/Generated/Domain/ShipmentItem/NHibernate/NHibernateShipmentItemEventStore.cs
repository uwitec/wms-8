﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItem;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.ShipmentItem.NHibernate
{

	public class NHibernateShipmentItemEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new ShipmentItemStateEventId((ShipmentItemId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(ShipmentItemStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(ShipmentItemStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            ShipmentItemId idObj = (ShipmentItemId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<ShipmentItemStateEventBase>();
            criteria.Add(Restrictions.Eq("StateEventId.ShipmentItemIdShipmentId", idObj.ShipmentId));
            criteria.Add(Restrictions.Eq("StateEventId.ShipmentItemIdShipmentItemSeqId", idObj.ShipmentItemSeqId));
            criteria.Add(Restrictions.Le("StateEventId.Version", version));
            criteria.AddOrder(Order.Asc("StateEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (ShipmentItemStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((ShipmentItemStateEventBase)es.Last()).StateEventId.Version : default(long),
                Events = es
            };
        }

	}

}
