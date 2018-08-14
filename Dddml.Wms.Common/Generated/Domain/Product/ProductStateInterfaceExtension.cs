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

	public static partial class ProductStateInterfaceExtension
	{

        public static IProductCommand ToCreateOrMergePatchProduct<TCreateProduct, TMergePatchProduct, TCreateGoodIdentification, TMergePatchGoodIdentification>(this IProductState state)
            where TCreateProduct : ICreateProduct, new()
            where TMergePatchProduct : IMergePatchProduct, new()
            where TCreateGoodIdentification : ICreateGoodIdentification, new()
            where TMergePatchGoodIdentification : IMergePatchGoodIdentification, new()
        {
            bool bUnsaved = ((IProductState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateProduct<TCreateProduct, TCreateGoodIdentification>();
            }
            else 
            {
                return state.ToMergePatchProduct<TMergePatchProduct, TCreateGoodIdentification, TMergePatchGoodIdentification>();
            }
        }

        public static TDeleteProduct ToDeleteProduct<TDeleteProduct>(this IProductState state)
            where TDeleteProduct : IDeleteProduct, new()
        {
            var cmd = new TDeleteProduct();
            cmd.ProductId = state.ProductId;
            cmd.Version = ((IProductStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchProduct ToMergePatchProduct<TMergePatchProduct, TCreateGoodIdentification, TMergePatchGoodIdentification>(this IProductState state)
            where TMergePatchProduct : IMergePatchProduct, new()
            where TCreateGoodIdentification : ICreateGoodIdentification, new()
            where TMergePatchGoodIdentification : IMergePatchGoodIdentification, new()
        {
            var cmd = new TMergePatchProduct();

            cmd.Version = ((IProductStateProperties)state).Version;

            cmd.ProductId = state.ProductId;
            cmd.ProductTypeId = state.ProductTypeId;
            cmd.PrimaryProductCategoryId = state.PrimaryProductCategoryId;
            cmd.ManufacturerPartyId = state.ManufacturerPartyId;
            cmd.FacilityId = state.FacilityId;
            cmd.IntroductionDate = state.IntroductionDate;
            cmd.ReleaseDate = state.ReleaseDate;
            cmd.SupportDiscontinuationDate = state.SupportDiscontinuationDate;
            cmd.SalesDiscontinuationDate = state.SalesDiscontinuationDate;
            cmd.SalesDiscWhenNotAvail = state.SalesDiscWhenNotAvail;
            cmd.InternalName = state.InternalName;
            cmd.BrandName = state.BrandName;
            cmd.Comments = state.Comments;
            cmd.ProductName = state.ProductName;
            cmd.Description = state.Description;
            cmd.PriceDetailText = state.PriceDetailText;
            cmd.SmallImageUrl = state.SmallImageUrl;
            cmd.MediumImageUrl = state.MediumImageUrl;
            cmd.LargeImageUrl = state.LargeImageUrl;
            cmd.DetailImageUrl = state.DetailImageUrl;
            cmd.OriginalImageUrl = state.OriginalImageUrl;
            cmd.DetailScreen = state.DetailScreen;
            cmd.InventoryMessage = state.InventoryMessage;
            cmd.InventoryItemTypeId = state.InventoryItemTypeId;
            cmd.RequireInventory = state.RequireInventory;
            cmd.QuantityUomId = state.QuantityUomId;
            cmd.QuantityIncluded = state.QuantityIncluded;
            cmd.PiecesIncluded = state.PiecesIncluded;
            cmd.RequireAmount = state.RequireAmount;
            cmd.FixedAmount = state.FixedAmount;
            cmd.AmountUomTypeId = state.AmountUomTypeId;
            cmd.WeightUomId = state.WeightUomId;
            cmd.ShippingWeight = state.ShippingWeight;
            cmd.ProductWeight = state.ProductWeight;
            cmd.HeightUomId = state.HeightUomId;
            cmd.ProductHeight = state.ProductHeight;
            cmd.ShippingHeight = state.ShippingHeight;
            cmd.WidthUomId = state.WidthUomId;
            cmd.ProductWidth = state.ProductWidth;
            cmd.ShippingWidth = state.ShippingWidth;
            cmd.DepthUomId = state.DepthUomId;
            cmd.ProductDepth = state.ProductDepth;
            cmd.ShippingDepth = state.ShippingDepth;
            cmd.DiameterUomId = state.DiameterUomId;
            cmd.ProductDiameter = state.ProductDiameter;
            cmd.ProductRating = state.ProductRating;
            cmd.RatingTypeEnum = state.RatingTypeEnum;
            cmd.Returnable = state.Returnable;
            cmd.Taxable = state.Taxable;
            cmd.ChargeShipping = state.ChargeShipping;
            cmd.AutoCreateKeywords = state.AutoCreateKeywords;
            cmd.IncludeInPromotions = state.IncludeInPromotions;
            cmd.IsVirtual = state.IsVirtual;
            cmd.IsVariant = state.IsVariant;
            cmd.VirtualVariantMethodEnum = state.VirtualVariantMethodEnum;
            cmd.InShippingBox = state.InShippingBox;
            cmd.DefaultShipmentBoxTypeId = state.DefaultShipmentBoxTypeId;
            cmd.IsSerialNumbered = state.IsSerialNumbered;
            cmd.IsManagedByLot = state.IsManagedByLot;
            cmd.AttributeSetId = state.AttributeSetId;
            cmd.AttributeSetInstanceId = state.AttributeSetInstanceId;
            cmd.Grade = state.Grade;
            cmd.Gsm = state.Gsm;
            cmd.CoreDiameter = state.CoreDiameter;
            cmd.OutsideDiameter = state.OutsideDiameter;
            cmd.MoisturePct = state.MoisturePct;
            cmd.RollCnt = state.RollCnt;
            cmd.Active = ((IProductStateProperties)state).Active;
            
            if (state.ProductTypeId == null) { cmd.IsPropertyProductTypeIdRemoved = true; }
            if (state.PrimaryProductCategoryId == null) { cmd.IsPropertyPrimaryProductCategoryIdRemoved = true; }
            if (state.ManufacturerPartyId == null) { cmd.IsPropertyManufacturerPartyIdRemoved = true; }
            if (state.FacilityId == null) { cmd.IsPropertyFacilityIdRemoved = true; }
            if (state.IntroductionDate == null) { cmd.IsPropertyIntroductionDateRemoved = true; }
            if (state.ReleaseDate == null) { cmd.IsPropertyReleaseDateRemoved = true; }
            if (state.SupportDiscontinuationDate == null) { cmd.IsPropertySupportDiscontinuationDateRemoved = true; }
            if (state.SalesDiscontinuationDate == null) { cmd.IsPropertySalesDiscontinuationDateRemoved = true; }
            if (state.SalesDiscWhenNotAvail == null) { cmd.IsPropertySalesDiscWhenNotAvailRemoved = true; }
            if (state.InternalName == null) { cmd.IsPropertyInternalNameRemoved = true; }
            if (state.BrandName == null) { cmd.IsPropertyBrandNameRemoved = true; }
            if (state.Comments == null) { cmd.IsPropertyCommentsRemoved = true; }
            if (state.ProductName == null) { cmd.IsPropertyProductNameRemoved = true; }
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            if (state.PriceDetailText == null) { cmd.IsPropertyPriceDetailTextRemoved = true; }
            if (state.SmallImageUrl == null) { cmd.IsPropertySmallImageUrlRemoved = true; }
            if (state.MediumImageUrl == null) { cmd.IsPropertyMediumImageUrlRemoved = true; }
            if (state.LargeImageUrl == null) { cmd.IsPropertyLargeImageUrlRemoved = true; }
            if (state.DetailImageUrl == null) { cmd.IsPropertyDetailImageUrlRemoved = true; }
            if (state.OriginalImageUrl == null) { cmd.IsPropertyOriginalImageUrlRemoved = true; }
            if (state.DetailScreen == null) { cmd.IsPropertyDetailScreenRemoved = true; }
            if (state.InventoryMessage == null) { cmd.IsPropertyInventoryMessageRemoved = true; }
            if (state.InventoryItemTypeId == null) { cmd.IsPropertyInventoryItemTypeIdRemoved = true; }
            if (state.RequireInventory == null) { cmd.IsPropertyRequireInventoryRemoved = true; }
            if (state.QuantityUomId == null) { cmd.IsPropertyQuantityUomIdRemoved = true; }
            if (state.QuantityIncluded == null) { cmd.IsPropertyQuantityIncludedRemoved = true; }
            if (state.PiecesIncluded == null) { cmd.IsPropertyPiecesIncludedRemoved = true; }
            if (state.RequireAmount == null) { cmd.IsPropertyRequireAmountRemoved = true; }
            if (state.FixedAmount == null) { cmd.IsPropertyFixedAmountRemoved = true; }
            if (state.AmountUomTypeId == null) { cmd.IsPropertyAmountUomTypeIdRemoved = true; }
            if (state.WeightUomId == null) { cmd.IsPropertyWeightUomIdRemoved = true; }
            if (state.ShippingWeight == null) { cmd.IsPropertyShippingWeightRemoved = true; }
            if (state.ProductWeight == null) { cmd.IsPropertyProductWeightRemoved = true; }
            if (state.HeightUomId == null) { cmd.IsPropertyHeightUomIdRemoved = true; }
            if (state.ProductHeight == null) { cmd.IsPropertyProductHeightRemoved = true; }
            if (state.ShippingHeight == null) { cmd.IsPropertyShippingHeightRemoved = true; }
            if (state.WidthUomId == null) { cmd.IsPropertyWidthUomIdRemoved = true; }
            if (state.ProductWidth == null) { cmd.IsPropertyProductWidthRemoved = true; }
            if (state.ShippingWidth == null) { cmd.IsPropertyShippingWidthRemoved = true; }
            if (state.DepthUomId == null) { cmd.IsPropertyDepthUomIdRemoved = true; }
            if (state.ProductDepth == null) { cmd.IsPropertyProductDepthRemoved = true; }
            if (state.ShippingDepth == null) { cmd.IsPropertyShippingDepthRemoved = true; }
            if (state.DiameterUomId == null) { cmd.IsPropertyDiameterUomIdRemoved = true; }
            if (state.ProductDiameter == null) { cmd.IsPropertyProductDiameterRemoved = true; }
            if (state.ProductRating == null) { cmd.IsPropertyProductRatingRemoved = true; }
            if (state.RatingTypeEnum == null) { cmd.IsPropertyRatingTypeEnumRemoved = true; }
            if (state.Returnable == null) { cmd.IsPropertyReturnableRemoved = true; }
            if (state.Taxable == null) { cmd.IsPropertyTaxableRemoved = true; }
            if (state.ChargeShipping == null) { cmd.IsPropertyChargeShippingRemoved = true; }
            if (state.AutoCreateKeywords == null) { cmd.IsPropertyAutoCreateKeywordsRemoved = true; }
            if (state.IncludeInPromotions == null) { cmd.IsPropertyIncludeInPromotionsRemoved = true; }
            if (state.IsVirtual == null) { cmd.IsPropertyIsVirtualRemoved = true; }
            if (state.IsVariant == null) { cmd.IsPropertyIsVariantRemoved = true; }
            if (state.VirtualVariantMethodEnum == null) { cmd.IsPropertyVirtualVariantMethodEnumRemoved = true; }
            if (state.InShippingBox == null) { cmd.IsPropertyInShippingBoxRemoved = true; }
            if (state.DefaultShipmentBoxTypeId == null) { cmd.IsPropertyDefaultShipmentBoxTypeIdRemoved = true; }
            if (state.AttributeSetId == null) { cmd.IsPropertyAttributeSetIdRemoved = true; }
            if (state.AttributeSetInstanceId == null) { cmd.IsPropertyAttributeSetInstanceIdRemoved = true; }
            if (state.Grade == null) { cmd.IsPropertyGradeRemoved = true; }
            if (state.Gsm == null) { cmd.IsPropertyGsmRemoved = true; }
            if (state.CoreDiameter == null) { cmd.IsPropertyCoreDiameterRemoved = true; }
            if (state.OutsideDiameter == null) { cmd.IsPropertyOutsideDiameterRemoved = true; }
            if (state.MoisturePct == null) { cmd.IsPropertyMoisturePctRemoved = true; }
            if (state.RollCnt == null) { cmd.IsPropertyRollCntRemoved = true; }
            foreach (var d in state.GoodIdentifications)
            {
                var c = d.ToCreateOrMergePatchGoodIdentification<TCreateGoodIdentification, TMergePatchGoodIdentification>();
                cmd.GoodIdentificationCommands.Add(c);
            }
            return cmd;
        }

        public static TCreateProduct ToCreateProduct<TCreateProduct, TCreateGoodIdentification>(this IProductState state)
            where TCreateProduct : ICreateProduct, new()
            where TCreateGoodIdentification : ICreateGoodIdentification, new()
        {
            var cmd = new TCreateProduct();

            cmd.Version = ((IProductStateProperties)state).Version;

            cmd.ProductId = state.ProductId;
            cmd.ProductTypeId = state.ProductTypeId;
            cmd.PrimaryProductCategoryId = state.PrimaryProductCategoryId;
            cmd.ManufacturerPartyId = state.ManufacturerPartyId;
            cmd.FacilityId = state.FacilityId;
            cmd.IntroductionDate = state.IntroductionDate;
            cmd.ReleaseDate = state.ReleaseDate;
            cmd.SupportDiscontinuationDate = state.SupportDiscontinuationDate;
            cmd.SalesDiscontinuationDate = state.SalesDiscontinuationDate;
            cmd.SalesDiscWhenNotAvail = state.SalesDiscWhenNotAvail;
            cmd.InternalName = state.InternalName;
            cmd.BrandName = state.BrandName;
            cmd.Comments = state.Comments;
            cmd.ProductName = state.ProductName;
            cmd.Description = state.Description;
            cmd.PriceDetailText = state.PriceDetailText;
            cmd.SmallImageUrl = state.SmallImageUrl;
            cmd.MediumImageUrl = state.MediumImageUrl;
            cmd.LargeImageUrl = state.LargeImageUrl;
            cmd.DetailImageUrl = state.DetailImageUrl;
            cmd.OriginalImageUrl = state.OriginalImageUrl;
            cmd.DetailScreen = state.DetailScreen;
            cmd.InventoryMessage = state.InventoryMessage;
            cmd.InventoryItemTypeId = state.InventoryItemTypeId;
            cmd.RequireInventory = state.RequireInventory;
            cmd.QuantityUomId = state.QuantityUomId;
            cmd.QuantityIncluded = state.QuantityIncluded;
            cmd.PiecesIncluded = state.PiecesIncluded;
            cmd.RequireAmount = state.RequireAmount;
            cmd.FixedAmount = state.FixedAmount;
            cmd.AmountUomTypeId = state.AmountUomTypeId;
            cmd.WeightUomId = state.WeightUomId;
            cmd.ShippingWeight = state.ShippingWeight;
            cmd.ProductWeight = state.ProductWeight;
            cmd.HeightUomId = state.HeightUomId;
            cmd.ProductHeight = state.ProductHeight;
            cmd.ShippingHeight = state.ShippingHeight;
            cmd.WidthUomId = state.WidthUomId;
            cmd.ProductWidth = state.ProductWidth;
            cmd.ShippingWidth = state.ShippingWidth;
            cmd.DepthUomId = state.DepthUomId;
            cmd.ProductDepth = state.ProductDepth;
            cmd.ShippingDepth = state.ShippingDepth;
            cmd.DiameterUomId = state.DiameterUomId;
            cmd.ProductDiameter = state.ProductDiameter;
            cmd.ProductRating = state.ProductRating;
            cmd.RatingTypeEnum = state.RatingTypeEnum;
            cmd.Returnable = state.Returnable;
            cmd.Taxable = state.Taxable;
            cmd.ChargeShipping = state.ChargeShipping;
            cmd.AutoCreateKeywords = state.AutoCreateKeywords;
            cmd.IncludeInPromotions = state.IncludeInPromotions;
            cmd.IsVirtual = state.IsVirtual;
            cmd.IsVariant = state.IsVariant;
            cmd.VirtualVariantMethodEnum = state.VirtualVariantMethodEnum;
            cmd.InShippingBox = state.InShippingBox;
            cmd.DefaultShipmentBoxTypeId = state.DefaultShipmentBoxTypeId;
            cmd.IsSerialNumbered = state.IsSerialNumbered;
            cmd.IsManagedByLot = state.IsManagedByLot;
            cmd.AttributeSetId = state.AttributeSetId;
            cmd.AttributeSetInstanceId = state.AttributeSetInstanceId;
            cmd.Grade = state.Grade;
            cmd.Gsm = state.Gsm;
            cmd.CoreDiameter = state.CoreDiameter;
            cmd.OutsideDiameter = state.OutsideDiameter;
            cmd.MoisturePct = state.MoisturePct;
            cmd.RollCnt = state.RollCnt;
            cmd.Active = ((IProductStateProperties)state).Active;
            foreach (var d in state.GoodIdentifications)
            {
                var c = d.ToCreateGoodIdentification<TCreateGoodIdentification>();
                cmd.GoodIdentifications.Add(c);
            }
            return cmd;
        }
		

	}

}

