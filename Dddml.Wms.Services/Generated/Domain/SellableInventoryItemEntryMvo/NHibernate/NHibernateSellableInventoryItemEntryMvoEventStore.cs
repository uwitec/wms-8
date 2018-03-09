﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo.NHibernate
{

	public class NHibernateSellableInventoryItemEntryMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new SellableInventoryItemEntryMvoEventId((SellableInventoryItemEntryId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(SellableInventoryItemEntryMvoStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(SellableInventoryItemEntryMvoStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            SellableInventoryItemEntryId idObj = (SellableInventoryItemEntryId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<SellableInventoryItemEntryMvoStateEventBase>();
            criteria.Add(Restrictions.Eq("SellableInventoryItemEntryMvoEventId.SellableInventoryItemEntryIdSellableInventoryItemIdProductId", idObj.SellableInventoryItemId.ProductId));
            criteria.Add(Restrictions.Eq("SellableInventoryItemEntryMvoEventId.SellableInventoryItemEntryIdSellableInventoryItemIdLocatorId", idObj.SellableInventoryItemId.LocatorId));
            criteria.Add(Restrictions.Eq("SellableInventoryItemEntryMvoEventId.SellableInventoryItemEntryIdSellableInventoryItemIdAttributeSetInstanceId", idObj.SellableInventoryItemId.AttributeSetInstanceId));
            criteria.Add(Restrictions.Eq("SellableInventoryItemEntryMvoEventId.SellableInventoryItemEntryIdEntrySeqId", idObj.EntrySeqId));
            criteria.Add(Restrictions.Le("SellableInventoryItemEntryMvoEventId.SellableInventoryItemVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("SellableInventoryItemEntryMvoEventId.SellableInventoryItemVersion"));
            var es = criteria.List<IEvent>();
            foreach (SellableInventoryItemEntryMvoStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((SellableInventoryItemEntryMvoStateEventBase)es.Last()).SellableInventoryItemEntryMvoEventId.SellableInventoryItemVersion : default(long),
                Events = es
            };
        }

	}

}

