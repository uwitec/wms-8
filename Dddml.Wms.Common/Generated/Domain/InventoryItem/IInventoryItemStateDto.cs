﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

    public interface IInventoryItemStateDto
    {
        InventoryItemId InventoryItemId
        {
            get;
            set;
        }

        decimal? OnHandQuantity
        {
            get;
            set;
        }

        decimal? InTransitQuantity
        {
            get;
            set;
        }

        decimal? ReservedQuantity
        {
            get;
            set;
        }

        decimal? OccupiedQuantity
        {
            get;
            set;
        }

        decimal? VirtualQuantity
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

        IInventoryItemEntryStateDto[] Entries
        {
            get;
            set;
        }

        IInventoryItemState ToInventoryItemState();

    }

}

