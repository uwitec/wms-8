﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.PicklistRoleMvo.NHibernate
{

	public class NHibernatePicklistRoleMvoEventStore : NHibernateEventStoreBase
	{
		public override object GetEventId(IEventStoreAggregateId eventStoreAggregateId, long version)
		{
			return new PicklistRoleMvoEventId((PicklistRoleId)(eventStoreAggregateId as EventStoreAggregateId).Id, (long)version);
		}

		public override Type GetSupportedStateEventType()
		{
			return typeof(PicklistRoleMvoStateEventBase);
		}

        [Transaction(ReadOnly = true)]
        public override EventStream LoadEventStream(Type eventType, IEventStoreAggregateId eventStoreAggregateId, long version)
        {
            Type supportedEventType = typeof(PicklistRoleMvoStateEventBase);
            if (!eventType.IsAssignableFrom(supportedEventType))
            {
                throw new NotSupportedException();
            }
            PicklistRoleId idObj = (PicklistRoleId)(eventStoreAggregateId as EventStoreAggregateId).Id;
            var criteria = CurrentSession.CreateCriteria<PicklistRoleMvoStateEventBase>();
            criteria.Add(Restrictions.Eq("PicklistRoleMvoEventId.PicklistRoleIdPicklistId", idObj.PicklistId));
            criteria.Add(Restrictions.Eq("PicklistRoleMvoEventId.PicklistRoleIdPartyRoleIdPartyId", idObj.PartyRoleId.PartyId));
            criteria.Add(Restrictions.Eq("PicklistRoleMvoEventId.PicklistRoleIdPartyRoleIdRoleTypeId", idObj.PartyRoleId.RoleTypeId));
            criteria.Add(Restrictions.Le("PicklistRoleMvoEventId.PicklistVersion", version));
            criteria.AddOrder(global::NHibernate.Criterion.Order.Asc("PicklistRoleMvoEventId.PicklistVersion"));
            var es = criteria.List<IEvent>();
            foreach (PicklistRoleMvoStateEventBase e in es)
            {
                e.StateEventReadOnly = true;
            }
            return new EventStream()
            {
                SteamVersion = es.Count > 0 ? ((PicklistRoleMvoStateEventBase)es.Last()).PicklistRoleMvoEventId.PicklistVersion : default(long),
                Events = es
            };
        }

	}

}

