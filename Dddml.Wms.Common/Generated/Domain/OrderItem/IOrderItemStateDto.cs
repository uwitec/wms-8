﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItem;

namespace Dddml.Wms.Domain.OrderItem
{

    public interface IOrderItemStateDto
    {

        OrderItemIdDto OrderItemId
        {
            get;
            set;
        }

        string ProductId
        {
            get;
            set;
        }

        string ExternalProductId
        {
            get;
            set;
        }

        decimal? Quantity
        {
            get;
            set;
        }

        decimal? CancelQuantity
        {
            get;
            set;
        }

        decimal? SelectedAmount
        {
            get;
            set;
        }

        string ExternalId
        {
            get;
            set;
        }

        string OrderItemTypeId
        {
            get;
            set;
        }

        string OrderItemGroupSeqId
        {
            get;
            set;
        }

        string IsItemGroupPrimary
        {
            get;
            set;
        }

        string FromInventoryItemId
        {
            get;
            set;
        }

        string IsPromo
        {
            get;
            set;
        }

        string QuoteId
        {
            get;
            set;
        }

        string QuoteItemSeqId
        {
            get;
            set;
        }

        string ShoppingListId
        {
            get;
            set;
        }

        string ShoppingListItemSeqId
        {
            get;
            set;
        }

        decimal? UnitPrice
        {
            get;
            set;
        }

        decimal? UnitListPrice
        {
            get;
            set;
        }

        decimal? UnitAverageCost
        {
            get;
            set;
        }

        decimal? UnitRecurringPrice
        {
            get;
            set;
        }

        string IsModifiedPrice
        {
            get;
            set;
        }

        string RecurringFreqUomId
        {
            get;
            set;
        }

        string ItemDescription
        {
            get;
            set;
        }

        string Comments
        {
            get;
            set;
        }

        string CorrespondingPoId
        {
            get;
            set;
        }

        string StatusId
        {
            get;
            set;
        }

        string SyncStatusId
        {
            get;
            set;
        }

        DateTime? EstimatedShipDate
        {
            get;
            set;
        }

        DateTime? EstimatedDeliveryDate
        {
            get;
            set;
        }

        DateTime? AutoCancelDate
        {
            get;
            set;
        }

        DateTime? DontCancelSetDate
        {
            get;
            set;
        }

        string DontCancelSetBy
        {
            get;
            set;
        }

        DateTime? ShipBeforeDate
        {
            get;
            set;
        }

        DateTime? ShipAfterDate
        {
            get;
            set;
        }

        DateTime? CancelBackOrderDate
        {
            get;
            set;
        }

        string OverrideGlAccountId
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

        IOrderItemState ToOrderItemState();

    }

}
