﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstance;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.AttributeSetInstance.NHibernate
{

	public partial class NHibernateAttributeSetInstanceStateQueryRepository : IAttributeSetInstanceStateQueryRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "AttributeSetInstanceId", "AttributeSetId", "OrganizationId", "ReferenceId", "SerialNumber", "LotId", "StatusIds", "ImageUrl", "Description", "Hash", "WidthInch", "DiameterInch", "WeightLbs", "WeightKg", "AirDryWeightLbs", "AirDryWeightKg", "AirDryMetricTon", "RollCnt", "AirDryPct", "_F_B_0_", "_F_I_0_", "_F_L_0_", "_F_DT_0_", "_F_N_0_", "_F_C5_0_", "_F_C10_0_", "_F_C20_0_", "_F_C50_0_", "_F_C100_0_", "_F_C200_0_", "_F_C500_0_", "_F_C1000_0_", "_F_B_1_", "_F_I_1_", "_F_L_1_", "_F_DT_1_", "_F_N_1_", "_F_C5_1_", "_F_C10_1_", "_F_C20_1_", "_F_C50_1_", "_F_C100_1_", "_F_C200_1_", "_F_B_2_", "_F_I_2_", "_F_L_2_", "_F_DT_2_", "_F_N_2_", "_F_C5_2_", "_F_C10_2_", "_F_C20_2_", "_F_C50_2_", "_F_B_3_", "_F_I_3_", "_F_L_3_", "_F_DT_3_", "_F_N_3_", "_F_C5_3_", "_F_C10_3_", "_F_C20_3_", "_F_C50_3_", "_F_B_4_", "_F_I_4_", "_F_L_4_", "_F_DT_4_", "_F_N_4_", "_F_C5_4_", "_F_C10_4_", "_F_C20_4_", "_F_C50_4_", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateAttributeSetInstanceStateQueryRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IAttributeSetInstanceState Get(string id)
		{
			IAttributeSetInstanceState state = CurrentSession.Get<AttributeSetInstanceState>(id);
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IAttributeSetInstanceState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IAttributeSetInstanceState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<AttributeSetInstanceState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IAttributeSetInstanceState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<AttributeSetInstanceState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IAttributeSetInstanceState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<AttributeSetInstanceState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IAttributeSetInstanceState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<AttributeSetInstanceState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IAttributeSetInstanceState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IAttributeSetInstanceState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<AttributeSetInstanceState>();
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
        }

	}
}

