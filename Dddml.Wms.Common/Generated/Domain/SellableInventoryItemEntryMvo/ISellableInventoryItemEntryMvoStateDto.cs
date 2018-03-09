﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{

    public interface ISellableInventoryItemEntryMvoStateDto
    {
        SellableInventoryItemEntryId SellableInventoryItemEntryId
        {
            get;
            set;
        }

        decimal? SellableQuantity
        {
            get;
            set;
        }

        InventoryPRTriggeredId SourceEventId
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        decimal? SellableInventoryItemSellableQuantity
        {
            get;
            set;
        }

        string SellableInventoryItemCreatedBy
        {
            get;
            set;
        }

        DateTime? SellableInventoryItemCreatedAt
        {
            get;
            set;
        }

        string SellableInventoryItemUpdatedBy
        {
            get;
            set;
        }

        DateTime? SellableInventoryItemUpdatedAt
        {
            get;
            set;
        }

        long? SellableInventoryItemVersion
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

        ISellableInventoryItemEntryMvoState ToSellableInventoryItemEntryMvoState();

    }

}

