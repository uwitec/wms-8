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

	public partial class NHibernateUserStateRepository : IUserStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

		public NHibernateUserStateRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IUserState Get (string id)
		{
			return Get(id, false);
		}

		[Transaction (ReadOnly = true)]
		public IUserState Get (string id, bool nullAllowed)
		{
			IUserState state = CurrentSession.Get<UserState> (id);
			if (!nullAllowed && state == null) {
				state = new UserState ();
				(state as UserState).UserId = id;
			}
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IUserState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserState>();
        }

		[Transaction]
		public void Save (IUserState state)
		{
			CurrentSession.SaveOrUpdate (state);

			var saveable = state as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<UserState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IUserState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<UserState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IUserState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<UserState>();
            criteria.SetProjection(Projections.RowCountInt64());
            if (filter != null)
            {
                NHibernateICriterion hc = CriterionUtils.ToNHibernateCriterion(filter);
                criteria.Add(hc);
            }
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserRoleState GetUserRole(string userId, string roleId)
        {
            var entityId = new UserRoleId(userId, roleId);
            return CurrentSession.Get<UserRoleState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserClaimState GetUserClaim(string userId, int claimId)
        {
            var entityId = new UserClaimId(userId, claimId);
            return CurrentSession.Get<UserClaimState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserPermissionState GetUserPermission(string userId, string permissionId)
        {
            var entityId = new UserPermissionId(userId, permissionId);
            return CurrentSession.Get<UserPermissionState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public virtual IUserLoginState GetUserLogin(string userId, LoginKey loginKey)
        {
            var entityId = new UserLoginId(userId, loginKey);
            return CurrentSession.Get<UserLoginState>(entityId);
        }


        protected static void AddNotDeletedRestriction(ICriteria criteria)
        {
            criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        }

	}
}

