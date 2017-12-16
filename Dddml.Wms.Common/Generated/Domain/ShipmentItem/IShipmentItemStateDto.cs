﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItem;

namespace Dddml.Wms.Domain.ShipmentItem
{

    public interface IShipmentItemStateDto
    {

        ShipmentItemIdDto ShipmentItemId
        {
            get;
            set;
        }

        string ProductId
        {
            get;
            set;
        }

        decimal? Quantity
        {
            get;
            set;
        }

        string ShipmentContentDescription
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

        IShipmentItemState ToShipmentItemState();

    }

}
