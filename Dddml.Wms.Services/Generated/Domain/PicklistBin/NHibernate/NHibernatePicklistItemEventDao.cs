﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistBinDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistBin;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.PicklistBin.NHibernate
{

	public class NHibernatePicklistItemEventDao : IPicklistItemEventDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernatePicklistItemEventDao ()
		{
		}

		public void Save(IPicklistItemEvent stateEvent)
		{
			CurrentSession.Save(stateEvent);
            var saveable = stateEvent as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IPicklistItemEvent> FindByPicklistBinEventId(PicklistBinEventId picklistBinEventId)
        {
            var criteria = CurrentSession.CreateCriteria<PicklistItemEventBase>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("PicklistItemEventId.PicklistBinId", picklistBinEventId.PicklistBinId))
                .Add(Restrictions.Eq("PicklistItemEventId.PicklistBinVersion", picklistBinEventId.Version))
                ;

            return criteria.Add(partIdCondition).List<PicklistItemEventBase>();
        }

	}
}

