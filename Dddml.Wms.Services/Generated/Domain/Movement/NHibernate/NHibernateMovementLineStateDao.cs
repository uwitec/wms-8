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

	public class NHibernateMovementLineStateDao : IMovementLineStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "LineNumber", "MovementQuantity", "ProductId", "LocatorIdFrom", "LocatorIdTo", "AttributeSetInstanceId", "Processed", "ReversalLineNumber", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "MovementDocumentNumber" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateMovementLineStateDao()
		{
		}

        [Transaction(ReadOnly = true)]
        public IMovementLineState Get(MovementLineId id, bool nullAllowed)
        {
            IMovementLineState state = CurrentSession.Get<MovementLineState>(id);
            if (!nullAllowed && state == null)
            {
                state = new MovementLineState();
                (state as MovementLineState).MovementLineId = id;
            }
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IMovementLineState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
            return state;
        }

       
        public void Save(IMovementLineState state)
        {
            IMovementLineState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IMovementLineState>(state);
            }
            CurrentSession.SaveOrUpdate(s);
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IMovementLineState state)
        {
            IMovementLineState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IMovementLineState>(state);
            }
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(s);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IMovementLineState> FindByMovementDocumentNumber(string movementDocumentNumber)
        {
            var criteria = CurrentSession.CreateCriteria<MovementLineState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("MovementLineId.MovementDocumentNumber", movementDocumentNumber))
                ;

            return criteria.Add(partIdCondition).List<MovementLineState>();
        }

    }

	
}

