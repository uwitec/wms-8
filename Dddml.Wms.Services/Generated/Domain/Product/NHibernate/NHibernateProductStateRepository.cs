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

	public partial class NHibernateProductStateRepository : IProductStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "ProductId", "ProductTypeId", "PrimaryProductCategoryId", "ManufacturerPartyId", "FacilityId", "IntroductionDate", "ReleaseDate", "SupportDiscontinuationDate", "SalesDiscontinuationDate", "SalesDiscWhenNotAvail", "InternalName", "BrandName", "Comments", "ProductName", "Description", "PriceDetailText", "SmallImageUrl", "MediumImageUrl", "LargeImageUrl", "DetailImageUrl", "OriginalImageUrl", "DetailScreen", "InventoryMessage", "InventoryItemTypeId", "RequireInventory", "QuantityUomId", "QuantityIncluded", "PiecesIncluded", "RequireAmount", "FixedAmount", "AmountUomTypeId", "WeightUomId", "ShippingWeight", "ProductWeight", "HeightUomId", "ProductHeight", "ShippingHeight", "WidthUomId", "ProductWidth", "ShippingWidth", "DepthUomId", "ProductDepth", "ShippingDepth", "DiameterUomId", "ProductDiameter", "ProductRating", "RatingTypeEnum", "Returnable", "Taxable", "ChargeShipping", "AutoCreateKeywords", "IncludeInPromotions", "IsVirtual", "IsVariant", "VirtualVariantMethodEnum", "InShippingBox", "DefaultShipmentBoxTypeId", "IsSerialNumbered", "IsManagedByLot", "AttributeSetId", "AttributeSetInstanceId", "Grade", "Gsm", "CoreDiameter", "OutsideDiameter", "MoisturePct", "RollCnt", "GoodIdentifications", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateProductStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IProductState Get(string id, bool nullAllowed)
		{
			IProductState state = CurrentSession.Get<ProductState> (id);
			if (!nullAllowed && state == null) {
				state = new ProductState ();
				(state as ProductState).ProductId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IProductState>(state, new Type[] { typeof(ISaveable) }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IProductState state)
		{
            IProductState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IProductState>(state);
            }
			CurrentSession.SaveOrUpdate (s);

			var saveable = s as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
            CurrentSession.Flush();
		}

        //protected static void AddNotDeletedRestriction(ICriteria criteria)
        //{
        //    criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        //}

	}
}

