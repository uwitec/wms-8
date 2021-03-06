﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.Order.NHibernate
{

	public class NHibernateOrderRoleStateDao : IOrderRoleStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "PartyRoleId", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "OrderId" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateOrderRoleStateDao()
		{
		}

        [Transaction(ReadOnly = true)]
        public IOrderRoleState Get(OrderRoleId id, bool nullAllowed)
        {
            IOrderRoleState state = CurrentSession.Get<OrderRoleState>(id);
            if (!nullAllowed && state == null)
            {
                state = new OrderRoleState();
                (state as OrderRoleState).OrderRoleId = id;
            }
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IOrderRoleState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
            return state;
        }

       
        public void Save(IOrderRoleState state)
        {
            IOrderRoleState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IOrderRoleState>(state);
            }
            CurrentSession.SaveOrUpdate(s);
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IOrderRoleState state)
        {
            IOrderRoleState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IOrderRoleState>(state);
            }
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(s);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IOrderRoleState> FindByOrderId(string orderId)
        {
            var criteria = CurrentSession.CreateCriteria<OrderRoleState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("OrderRoleId.OrderId", orderId))
                ;

            return criteria.Add(partIdCondition).List<OrderRoleState>();
        }

    }

	
}

