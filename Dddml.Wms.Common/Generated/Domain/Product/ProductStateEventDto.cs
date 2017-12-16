﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.Product
{

	public abstract class ProductStateEventDtoBase : IStateEventDto, IProductStateCreated, IProductStateMergePatched
	{

        private ProductStateEventIdDto _stateEventId;

		protected internal virtual ProductStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new ProductStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual string ProductId
        {
            get { return StateEventId.ProductId; }
            set { StateEventId.ProductId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual string ProductTypeId { get; set; }

		public virtual string PrimaryProductCategoryId { get; set; }

		public virtual string ManufacturerPartyId { get; set; }

		public virtual string FacilityId { get; set; }

		public virtual DateTime? IntroductionDate { get; set; }

		public virtual DateTime? ReleaseDate { get; set; }

		public virtual DateTime? SupportDiscontinuationDate { get; set; }

		public virtual DateTime? SalesDiscontinuationDate { get; set; }

		public virtual string SalesDiscWhenNotAvail { get; set; }

		public virtual string InternalName { get; set; }

		public virtual string BrandName { get; set; }

		public virtual string Comments { get; set; }

		public virtual string ProductName { get; set; }

		public virtual string Description { get; set; }

		public virtual string PriceDetailText { get; set; }

		public virtual string SmallImageUrl { get; set; }

		public virtual string MediumImageUrl { get; set; }

		public virtual string LargeImageUrl { get; set; }

		public virtual string DetailImageUrl { get; set; }

		public virtual string OriginalImageUrl { get; set; }

		public virtual string DetailScreen { get; set; }

		public virtual string InventoryMessage { get; set; }

		public virtual string InventoryItemTypeId { get; set; }

		public virtual string RequireInventory { get; set; }

		public virtual string QuantityUomId { get; set; }

		public virtual decimal? QuantityIncluded { get; set; }

		public virtual long? PiecesIncluded { get; set; }

		public virtual string RequireAmount { get; set; }

		public virtual decimal? FixedAmount { get; set; }

		public virtual string AmountUomTypeId { get; set; }

		public virtual string WeightUomId { get; set; }

		public virtual decimal? ShippingWeight { get; set; }

		public virtual decimal? ProductWeight { get; set; }

		public virtual string HeightUomId { get; set; }

		public virtual decimal? ProductHeight { get; set; }

		public virtual decimal? ShippingHeight { get; set; }

		public virtual string WidthUomId { get; set; }

		public virtual decimal? ProductWidth { get; set; }

		public virtual decimal? ShippingWidth { get; set; }

		public virtual string DepthUomId { get; set; }

		public virtual decimal? ProductDepth { get; set; }

		public virtual decimal? ShippingDepth { get; set; }

		public virtual string DiameterUomId { get; set; }

		public virtual decimal? ProductDiameter { get; set; }

		public virtual string Returnable { get; set; }

		public virtual string Taxable { get; set; }

		public virtual string ChargeShipping { get; set; }

		public virtual string AutoCreateKeywords { get; set; }

		public virtual string IncludeInPromotions { get; set; }

		public virtual string IsVirtual { get; set; }

		public virtual string IsVariant { get; set; }

		public virtual string VirtualVariantMethodEnum { get; set; }

		public virtual string InShippingBox { get; set; }

		public virtual string DefaultShipmentBoxTypeId { get; set; }

		public virtual string LotIdFilledIn { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ProductStateEventId IGlobalIdentity<ProductStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToProductStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IProductStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyProductTypeIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyProductTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyProductTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryProductCategoryIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyPrimaryProductCategoryIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPrimaryProductCategoryIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPrimaryProductCategoryIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyManufacturerPartyIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyManufacturerPartyIdRemoved
        {
            get 
            {
                var b = this.IsPropertyManufacturerPartyIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyManufacturerPartyIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyFacilityIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyFacilityIdRemoved
        {
            get 
            {
                var b = this.IsPropertyFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyIntroductionDateRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyIntroductionDateRemoved
        {
            get 
            {
                var b = this.IsPropertyIntroductionDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIntroductionDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyReleaseDateRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyReleaseDateRemoved
        {
            get 
            {
                var b = this.IsPropertyReleaseDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReleaseDateRemoved = value;
            }
        }

		public virtual bool? IsPropertySupportDiscontinuationDateRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertySupportDiscontinuationDateRemoved
        {
            get 
            {
                var b = this.IsPropertySupportDiscontinuationDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySupportDiscontinuationDateRemoved = value;
            }
        }

		public virtual bool? IsPropertySalesDiscontinuationDateRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertySalesDiscontinuationDateRemoved
        {
            get 
            {
                var b = this.IsPropertySalesDiscontinuationDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySalesDiscontinuationDateRemoved = value;
            }
        }

		public virtual bool? IsPropertySalesDiscWhenNotAvailRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertySalesDiscWhenNotAvailRemoved
        {
            get 
            {
                var b = this.IsPropertySalesDiscWhenNotAvailRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySalesDiscWhenNotAvailRemoved = value;
            }
        }

		public virtual bool? IsPropertyInternalNameRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyInternalNameRemoved
        {
            get 
            {
                var b = this.IsPropertyInternalNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInternalNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyBrandNameRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyBrandNameRemoved
        {
            get 
            {
                var b = this.IsPropertyBrandNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyBrandNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyCommentsRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyCommentsRemoved
        {
            get 
            {
                var b = this.IsPropertyCommentsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCommentsRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductNameRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyProductNameRemoved
        {
            get 
            {
                var b = this.IsPropertyProductNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyPriceDetailTextRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyPriceDetailTextRemoved
        {
            get 
            {
                var b = this.IsPropertyPriceDetailTextRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPriceDetailTextRemoved = value;
            }
        }

		public virtual bool? IsPropertySmallImageUrlRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertySmallImageUrlRemoved
        {
            get 
            {
                var b = this.IsPropertySmallImageUrlRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySmallImageUrlRemoved = value;
            }
        }

		public virtual bool? IsPropertyMediumImageUrlRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyMediumImageUrlRemoved
        {
            get 
            {
                var b = this.IsPropertyMediumImageUrlRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMediumImageUrlRemoved = value;
            }
        }

		public virtual bool? IsPropertyLargeImageUrlRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyLargeImageUrlRemoved
        {
            get 
            {
                var b = this.IsPropertyLargeImageUrlRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLargeImageUrlRemoved = value;
            }
        }

		public virtual bool? IsPropertyDetailImageUrlRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyDetailImageUrlRemoved
        {
            get 
            {
                var b = this.IsPropertyDetailImageUrlRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDetailImageUrlRemoved = value;
            }
        }

		public virtual bool? IsPropertyOriginalImageUrlRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyOriginalImageUrlRemoved
        {
            get 
            {
                var b = this.IsPropertyOriginalImageUrlRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOriginalImageUrlRemoved = value;
            }
        }

		public virtual bool? IsPropertyDetailScreenRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyDetailScreenRemoved
        {
            get 
            {
                var b = this.IsPropertyDetailScreenRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDetailScreenRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryMessageRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyInventoryMessageRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryMessageRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryMessageRemoved = value;
            }
        }

		public virtual bool? IsPropertyInventoryItemTypeIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyInventoryItemTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyInventoryItemTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInventoryItemTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyRequireInventoryRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyRequireInventoryRemoved
        {
            get 
            {
                var b = this.IsPropertyRequireInventoryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyRequireInventoryRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityUomIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyQuantityUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityIncludedRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyQuantityIncludedRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityIncludedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityIncludedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPiecesIncludedRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyPiecesIncludedRemoved
        {
            get 
            {
                var b = this.IsPropertyPiecesIncludedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPiecesIncludedRemoved = value;
            }
        }

		public virtual bool? IsPropertyRequireAmountRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyRequireAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyRequireAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyRequireAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyFixedAmountRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyFixedAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyFixedAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFixedAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyAmountUomTypeIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyAmountUomTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAmountUomTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAmountUomTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyWeightUomIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyWeightUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyWeightUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWeightUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShippingWeightRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyShippingWeightRemoved
        {
            get 
            {
                var b = this.IsPropertyShippingWeightRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShippingWeightRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductWeightRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyProductWeightRemoved
        {
            get 
            {
                var b = this.IsPropertyProductWeightRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductWeightRemoved = value;
            }
        }

		public virtual bool? IsPropertyHeightUomIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyHeightUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyHeightUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyHeightUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductHeightRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyProductHeightRemoved
        {
            get 
            {
                var b = this.IsPropertyProductHeightRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductHeightRemoved = value;
            }
        }

		public virtual bool? IsPropertyShippingHeightRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyShippingHeightRemoved
        {
            get 
            {
                var b = this.IsPropertyShippingHeightRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShippingHeightRemoved = value;
            }
        }

		public virtual bool? IsPropertyWidthUomIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyWidthUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyWidthUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyWidthUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductWidthRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyProductWidthRemoved
        {
            get 
            {
                var b = this.IsPropertyProductWidthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductWidthRemoved = value;
            }
        }

		public virtual bool? IsPropertyShippingWidthRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyShippingWidthRemoved
        {
            get 
            {
                var b = this.IsPropertyShippingWidthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShippingWidthRemoved = value;
            }
        }

		public virtual bool? IsPropertyDepthUomIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyDepthUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDepthUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDepthUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductDepthRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyProductDepthRemoved
        {
            get 
            {
                var b = this.IsPropertyProductDepthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductDepthRemoved = value;
            }
        }

		public virtual bool? IsPropertyShippingDepthRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyShippingDepthRemoved
        {
            get 
            {
                var b = this.IsPropertyShippingDepthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShippingDepthRemoved = value;
            }
        }

		public virtual bool? IsPropertyDiameterUomIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyDiameterUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDiameterUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDiameterUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductDiameterRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyProductDiameterRemoved
        {
            get 
            {
                var b = this.IsPropertyProductDiameterRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductDiameterRemoved = value;
            }
        }

		public virtual bool? IsPropertyReturnableRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyReturnableRemoved
        {
            get 
            {
                var b = this.IsPropertyReturnableRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReturnableRemoved = value;
            }
        }

		public virtual bool? IsPropertyTaxableRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyTaxableRemoved
        {
            get 
            {
                var b = this.IsPropertyTaxableRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTaxableRemoved = value;
            }
        }

		public virtual bool? IsPropertyChargeShippingRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyChargeShippingRemoved
        {
            get 
            {
                var b = this.IsPropertyChargeShippingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyChargeShippingRemoved = value;
            }
        }

		public virtual bool? IsPropertyAutoCreateKeywordsRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyAutoCreateKeywordsRemoved
        {
            get 
            {
                var b = this.IsPropertyAutoCreateKeywordsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAutoCreateKeywordsRemoved = value;
            }
        }

		public virtual bool? IsPropertyIncludeInPromotionsRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyIncludeInPromotionsRemoved
        {
            get 
            {
                var b = this.IsPropertyIncludeInPromotionsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIncludeInPromotionsRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsVirtualRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyIsVirtualRemoved
        {
            get 
            {
                var b = this.IsPropertyIsVirtualRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsVirtualRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsVariantRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyIsVariantRemoved
        {
            get 
            {
                var b = this.IsPropertyIsVariantRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsVariantRemoved = value;
            }
        }

		public virtual bool? IsPropertyVirtualVariantMethodEnumRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyVirtualVariantMethodEnumRemoved
        {
            get 
            {
                var b = this.IsPropertyVirtualVariantMethodEnumRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVirtualVariantMethodEnumRemoved = value;
            }
        }

		public virtual bool? IsPropertyInShippingBoxRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyInShippingBoxRemoved
        {
            get 
            {
                var b = this.IsPropertyInShippingBoxRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInShippingBoxRemoved = value;
            }
        }

		public virtual bool? IsPropertyDefaultShipmentBoxTypeIdRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyDefaultShipmentBoxTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDefaultShipmentBoxTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDefaultShipmentBoxTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLotIdFilledInRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyLotIdFilledInRemoved
        {
            get 
            {
                var b = this.IsPropertyLotIdFilledInRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLotIdFilledInRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IProductStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        ProductStateEventId IProductStateEvent.StateEventId
        {
            get { return this.StateEventId.ToProductStateEventId(); }
        }

        protected ProductStateEventDtoBase()
        {
        }

        protected ProductStateEventDtoBase(ProductStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class ProductStateCreatedOrMergePatchedOrDeletedDto : ProductStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class ProductStateCreatedDto : ProductStateCreatedOrMergePatchedOrDeletedDto
	{
		public ProductStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ProductStateMergePatchedDto : ProductStateCreatedOrMergePatchedOrDeletedDto
	{
		public ProductStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ProductStateDeletedDto : ProductStateCreatedOrMergePatchedOrDeletedDto
	{
		public ProductStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class ProductStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IProductStateCreated>, IEnumerable<IProductStateMergePatched>
    {
        private List<ProductStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<ProductStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual ProductStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<ProductStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IProductStateCreated> IEnumerable<IProductStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IProductStateMergePatched> IEnumerable<IProductStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddProductEvent(IProductStateCreated e)
        {
            _innerStateEvents.Add((ProductStateCreatedDto)e);
        }

        public void AddProductEvent(IProductStateEvent e)
        {
            _innerStateEvents.Add((ProductStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}
