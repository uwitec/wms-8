﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionField;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionField.NHibernate
{

	public class NHibernateAttributeSetInstanceExtensionFieldEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new AttributeSetInstanceExtensionFieldEventId((string)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(AttributeSetInstanceExtensionFieldStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(AttributeSetInstanceExtensionFieldStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            string idObj = (string)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceExtensionFieldStateEventBase>();
            criteria.Add(Restrictions.Eq("AttributeSetInstanceExtensionFieldEventId.Name", idObj));
            criteria.Add(Restrictions.Le("AttributeSetInstanceExtensionFieldEventId.Version", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("AttributeSetInstanceExtensionFieldEventId.Version"));
            var es = criteria.List<IEvent>();
            foreach (AttributeSetInstanceExtensionFieldStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((AttributeSetInstanceExtensionFieldStateEventBase)es.Last()).AttributeSetInstanceExtensionFieldEventId.Version : default(long),
                Events = es
            };
        }

	}

}

