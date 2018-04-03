﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGroupAssociationMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.OrderItemShipGroupAssociationMvo.NHibernate
{

	public partial class NHibernateOrderItemShipGroupAssociationMvoStateQueryRepository : IOrderItemShipGroupAssociationMvoStateQueryRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "OrderItemShipGroupAssociationId", "Quantity", "CancelQuantity", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "OrderShipGroupShipmentMethodTypeId", "OrderShipGroupSupplierPartyId", "OrderShipGroupVendorPartyId", "OrderShipGroupCarrierPartyId", "OrderShipGroupCarrierRoleTypeId", "OrderShipGroupFacilityId", "OrderShipGroupContactMechId", "OrderShipGroupTelecomContactMechId", "OrderShipGroupTrackingNumber", "OrderShipGroupShippingInstructions", "OrderShipGroupMaySplit", "OrderShipGroupGiftMessage", "OrderShipGroupIsGift", "OrderShipGroupShipAfterDate", "OrderShipGroupShipByDate", "OrderShipGroupEstimatedShipDate", "OrderShipGroupEstimatedDeliveryDate", "OrderShipGroupPickwaveId", "OrderShipGroupOrderItemShipGroupAssociations", "OrderShipGroupVersion", "OrderShipGroupCreatedBy", "OrderShipGroupCreatedAt", "OrderShipGroupUpdatedBy", "OrderShipGroupUpdatedAt", "OrderShipGroupActive", "OrderShipGroupDeleted", "OrderOrderTypeId", "OrderOrderName", "OrderExternalId", "OrderSalesChannelEnumId", "OrderOrderDate", "OrderPriority", "OrderEntryDate", "OrderPickSheetPrintedDate", "OrderStatusId", "OrderCurrencyUom", "OrderSyncStatusId", "OrderBillingAccountId", "OrderOriginFacilityId", "OrderWebSiteId", "OrderProductStoreId", "OrderTerminalId", "OrderTransactionId", "OrderAutoOrderShoppingListId", "OrderNeedsInventoryIssuance", "OrderIsRushOrder", "OrderInternalCode", "OrderRemainingSubTotal", "OrderGrandTotal", "OrderInvoicePerShipment", "OrderOrderItems", "OrderOrderRoles", "OrderOrderShipGroups", "OrderVersion", "OrderCreatedBy", "OrderCreatedAt", "OrderUpdatedBy", "OrderUpdatedAt", "OrderActive" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateOrderItemShipGroupAssociationMvoStateQueryRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IOrderItemShipGroupAssociationMvoState Get(OrderItemShipGroupAssociationId id)
		{
			IOrderItemShipGroupAssociationMvoState state = CurrentSession.Get<OrderItemShipGroupAssociationMvoState>(id);
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IOrderItemShipGroupAssociationMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IOrderItemShipGroupAssociationMvoState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemShipGroupAssociationMvoState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<OrderItemShipGroupAssociationMvoState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrderItemShipGroupAssociationMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemShipGroupAssociationMvoState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<OrderItemShipGroupAssociationMvoState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrderItemShipGroupAssociationMvoState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemShipGroupAssociationMvoState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<OrderItemShipGroupAssociationMvoState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IOrderItemShipGroupAssociationMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<OrderItemShipGroupAssociationMvoState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IOrderItemShipGroupAssociationMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IOrderItemShipGroupAssociationMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemShipGroupAssociationMvoState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<OrderItemShipGroupAssociationMvoState>();
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
