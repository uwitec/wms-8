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
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.NHibernate
{

	public partial class NHibernateUserLoginMvoStateRepository : IUserLoginMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateUserLoginMvoStateRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IUserLoginMvoState Get (UserLoginId id)
		{
			return Get(id, false);
		}

		[Transaction (ReadOnly = true)]
		public IUserLoginMvoState Get (UserLoginId id, bool nullAllowed)
		{
			IUserLoginMvoState state = CurrentSession.Get<UserLoginMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new UserLoginMvoState ();
				(state as UserLoginMvoState).UserLoginId = id;
			}
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserLoginMvoState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<UserLoginMvoState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserLoginMvoState>();
        }

		[Transaction]
		public void Save (IUserLoginMvoState state)
		{
			CurrentSession.SaveOrUpdate (state);

			var saveable = state as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserLoginMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<UserLoginMvoState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserLoginMvoState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserLoginMvoState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<UserLoginMvoState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserLoginMvoState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IUserLoginMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<UserLoginMvoState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserLoginMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserLoginMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<UserLoginMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<UserLoginMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            if (filter != null)
            {
                NHibernateICriterion hc = CriterionUtils.ToNHibernateCriterion(filter);
                criteria.Add(hc);
            }
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }


        protected static void AddNotDeletedRestriction(ICriteria criteria)
        {
            criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        }

	}
}

