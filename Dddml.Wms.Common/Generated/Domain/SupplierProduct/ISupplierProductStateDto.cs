﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;

namespace Dddml.Wms.Domain.SupplierProduct
{

    public interface ISupplierProductStateDto
    {
        SupplierProductId SupplierProductId
        {
            get;
            set;
        }

        DateTime? AvailableThruDate
        {
            get;
            set;
        }

        string SupplierPrefOrderId
        {
            get;
            set;
        }

        string SupplierRatingTypeId
        {
            get;
            set;
        }

        decimal? StandardLeadTimeDays
        {
            get;
            set;
        }

        decimal? ManufacturingLeadTimeDays
        {
            get;
            set;
        }

        decimal? DeliveryLeadTimeDays
        {
            get;
            set;
        }

        string QuantityUomId
        {
            get;
            set;
        }

        decimal? LastPrice
        {
            get;
            set;
        }

        decimal? ShippingPrice
        {
            get;
            set;
        }

        string ExternalProductName
        {
            get;
            set;
        }

        string ExternalProductId
        {
            get;
            set;
        }

        bool? CanDropShip
        {
            get;
            set;
        }

        string Comments
        {
            get;
            set;
        }

        bool? Active
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        string CreatedBy
        {
            get;
            set;
        }

        DateTime? CreatedAt
        {
            get;
            set;
        }

        string UpdatedBy
        {
            get;
            set;
        }

        DateTime? UpdatedAt
        {
            get;
            set;
        }

        ISupplierProductState ToSupplierProductState();

    }

}

