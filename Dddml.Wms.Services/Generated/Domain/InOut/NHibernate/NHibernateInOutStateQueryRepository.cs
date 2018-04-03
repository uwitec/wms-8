﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.InOut.NHibernate
{

	public partial class NHibernateInOutStateQueryRepository : IInOutStateQueryRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "DocumentNumber", "DocumentStatusId", "Posted", "Processed", "Processing", "DocumentTypeId", "Description", "OrderId", "DateOrdered", "IsPrinted", "MovementTypeId", "MovementDate", "BusinessPartnerId", "WarehouseId", "POReference", "FreightAmount", "ShipperId", "ChargeAmount", "DatePrinted", "CreatedFrom", "SalesRepresentativeId", "NumberOfPackages", "PickDate", "ShipDate", "TrackingNumber", "DateReceived", "IsInTransit", "IsApproved", "IsInDispute", "RmaDocumentNumber", "ReversalDocumentNumber", "InOutLines", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateInOutStateQueryRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IInOutState Get(string id)
		{
			IInOutState state = CurrentSession.Get<InOutState>(id);
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IInOutState>(state, new Type[] { typeof(ISaveable) }, _readOnlyPropertyNames);
            }
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IInOutState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<InOutState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<InOutState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IInOutState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<InOutState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<InOutState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IInOutState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<InOutState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<InOutState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IInOutState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<InOutState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IInOutState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IInOutState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<InOutState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<InOutState>();
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
        public virtual IInOutLineState GetInOutLine(string inOutDocumentNumber, string lineNumber)
        {
            var entityId = new InOutLineId(inOutDocumentNumber, lineNumber);
            return CurrentSession.Get<InOutLineState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IInOutLineState> GetInOutLines(string inOutDocumentNumber)
        {
            var criteria = CurrentSession.CreateCriteria<InOutLineState>();
            var partIdCondition = global::NHibernate.Criterion.Restrictions.Conjunction()
                .Add(global::NHibernate.Criterion.Restrictions.Eq("InOutLineId.InOutDocumentNumber", inOutDocumentNumber))
                ;

            return criteria.Add(partIdCondition).List<InOutLineState>();
        }


        protected static void AddNotDeletedRestriction(ICriteria criteria)
        {
        }

	}
}

