﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.Product.NHibernate
{

	public partial class NHibernateProductStateQueryRepository : IProductStateQueryRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "ProductId", "ProductTypeId", "PrimaryProductCategoryId", "ManufacturerPartyId", "FacilityId", "IntroductionDate", "ReleaseDate", "SupportDiscontinuationDate", "SalesDiscontinuationDate", "SalesDiscWhenNotAvail", "InternalName", "BrandName", "Comments", "ProductName", "Description", "PriceDetailText", "SmallImageUrl", "MediumImageUrl", "LargeImageUrl", "DetailImageUrl", "OriginalImageUrl", "DetailScreen", "InventoryMessage", "InventoryItemTypeId", "RequireInventory", "QuantityUomId", "QuantityIncluded", "PiecesIncluded", "RequireAmount", "FixedAmount", "AmountUomTypeId", "WeightUomId", "ShippingWeight", "ProductWeight", "HeightUomId", "ProductHeight", "ShippingHeight", "WidthUomId", "ProductWidth", "ShippingWidth", "DepthUomId", "ProductDepth", "ShippingDepth", "DiameterUomId", "ProductDiameter", "ProductRating", "RatingTypeEnum", "Returnable", "Taxable", "ChargeShipping", "AutoCreateKeywords", "IncludeInPromotions", "IsVirtual", "IsVariant", "VirtualVariantMethodEnum", "InShippingBox", "DefaultShipmentBoxTypeId", "IsSerialNumbered", "IsManagedByLot", "AttributeSetId", "AttributeSetInstanceId", "Grade", "Gsm", "CoreDiameter", "OutsideDiameter", "MoisturePct", "RollCnt", "GoodIdentifications", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateProductStateQueryRepository ()
		{
		}

		[Transaction (ReadOnly = true)]
		public IProductState Get(string id)
		{
			IProductState state = CurrentSession.Get<ProductState>(id);
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IProductState>(state, new Type[] { typeof(ISaveable) }, _readOnlyPropertyNames);
            }
			return state;
		}

        [Transaction(ReadOnly = true)]
        public IEnumerable<IProductState> GetAll(int firstResult, int maxResults)
        {
            var criteria = CurrentSession.CreateCriteria<ProductState>();
            criteria.SetFirstResult(firstResult);
            criteria.SetMaxResults(maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<ProductState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IProductState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<ProductState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<ProductState>();
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IProductState> Get(Dddml.Support.Criterion.ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var criteria = CurrentSession.CreateCriteria<ProductState>();

            NHibernateUtils.CriteriaAddFilterAndOrdersAndSetFirstResultAndMaxResults(criteria, filter, orders, firstResult, maxResults);
            AddNotDeletedRestriction(criteria);
            return criteria.List<ProductState>();
        }


        [Transaction(ReadOnly = true)]
        public virtual IProductState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null)
        {
            var list = (IList<ProductState>)Get(filter, orders, 0, 1);
            if (list == null || list.Count <= 0)
            {
                return null;
            }
            return list[0];
        }

        [Transaction(ReadOnly = true)]
        public virtual IProductState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null)
        {
            return GetFirst(new KeyValuePair<string, object>[] { keyValue }, orders);
        }

        [Transaction(ReadOnly = true)]
        public virtual IEnumerable<IProductState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var filter = new KeyValuePair<string, object>[] { new KeyValuePair<string, object>(propertyName, propertyValue) };
            return Get(filter, orders, firstResult, maxResults);
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
        {
            var criteria = CurrentSession.CreateCriteria<ProductState>();
            criteria.SetProjection(Projections.RowCountInt64());
            NHibernateUtils.CriteriaAddFilter(criteria, filter);
            AddNotDeletedRestriction(criteria);
            return criteria.UniqueResult<long>();
        }

        [Transaction(ReadOnly = true)]
        public virtual long GetCount(Dddml.Support.Criterion.ICriterion filter)
        {
            var criteria = CurrentSession.CreateCriteria<ProductState>();
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
        public virtual IGoodIdentificationState GetGoodIdentification(string productId, string goodIdentificationTypeId)
        {
            var entityId = new ProductGoodIdentificationId(productId, goodIdentificationTypeId);
            return CurrentSession.Get<GoodIdentificationState>(entityId);
        }

        [Transaction(ReadOnly = true)]
        public IEnumerable<IGoodIdentificationState> GetGoodIdentifications(string productId)
        {
            var criteria = CurrentSession.CreateCriteria<GoodIdentificationState>();
            var partIdCondition = global::NHibernate.Criterion.Restrictions.Conjunction()
                .Add(global::NHibernate.Criterion.Restrictions.Eq("ProductGoodIdentificationId.ProductId", productId))
                ;

            return criteria.Add(partIdCondition).List<GoodIdentificationState>();
        }


        protected static void AddNotDeletedRestriction(ICriteria criteria)
        {
        }

	}
}

