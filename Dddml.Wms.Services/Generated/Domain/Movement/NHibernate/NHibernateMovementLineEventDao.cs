﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Movement.NHibernate
{

	public class NHibernateMovementLineEventDao : IMovementLineEventDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateMovementLineEventDao ()
		{
		}

		public void Save(IMovementLineEvent stateEvent)
		{
			CurrentSession.Save(stateEvent);
            var saveable = stateEvent as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IMovementLineEvent> FindByMovementEventId(MovementEventId movementEventId)
        {
            var criteria = CurrentSession.CreateCriteria<MovementLineEventBase>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("MovementLineEventId.MovementDocumentNumber", movementEventId.DocumentNumber))
                .Add(Restrictions.Eq("MovementLineEventId.MovementVersion", movementEventId.Version))
                ;

            return criteria.Add(partIdCondition).List<MovementLineEventBase>();
        }

	}
}

