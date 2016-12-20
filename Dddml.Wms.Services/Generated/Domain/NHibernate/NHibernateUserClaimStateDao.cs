﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainNHibernateAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;

namespace Dddml.Wms.Domain.NHibernate
{

	public class NHibernateUserClaimStateDao : IUserClaimStateDao
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "ClaimId", "ClaimType", "ClaimValue", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "UserId" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateUserClaimStateDao()
		{
		}
 

        [Transaction(ReadOnly = true)]
        public IUserClaimState Get(UserClaimId id)
        {
            IUserClaimState state = CurrentSession.Get<UserClaimState>(id);
            if (state == null)
            {
                state = new UserClaimState();
                (state as UserClaimState).UserClaimId = id;
            }
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IUserClaimState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
            return state;
        }

       
        public void Save(IUserClaimState state)
        {
            IUserClaimState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IUserClaimState>(state);
            }
            CurrentSession.SaveOrUpdate(s);
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
        }


        public void Delete(IUserClaimState state)
        {
            IUserClaimState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IUserClaimState>(state);
            }
            var saveable = s as ISaveable;
            if (saveable != null)
            {
                saveable.Save();
            }
            CurrentSession.Delete(s);
        }


        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserClaimState> FindByUserId(string userId)
        {
            var criteria = CurrentSession.CreateCriteria<UserClaimState>();
            var partIdCondition = Restrictions.Conjunction()
                .Add(Restrictions.Eq("UserClaimId.UserId", userId))
                ;

            return criteria.Add(partIdCondition).List<UserClaimState>();
        }

    }

	
}

