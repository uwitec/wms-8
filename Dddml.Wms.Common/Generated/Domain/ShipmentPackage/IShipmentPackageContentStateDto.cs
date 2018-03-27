﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackage;

namespace Dddml.Wms.Domain.ShipmentPackage
{

    public interface IShipmentPackageContentStateDto
    {
        string ShipmentItemSeqId
        {
            get;
            set;
        }

        decimal? Quantity
        {
            get;
            set;
        }

        string SubProductId
        {
            get;
            set;
        }

        decimal? SubProductQuantity
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

        ShipmentPackageId ShipmentPackageId
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

        IShipmentPackageContentState ToShipmentPackageContentState();

    }

}

