﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderRoleMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderRoleMvo
{

    public interface IOrderRoleMvoStateDto
    {
        OrderRoleId OrderRoleId
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        bool? Active
        {
            get;
            set;
        }

        string OrderOrderTypeId
        {
            get;
            set;
        }

        string OrderOrderName
        {
            get;
            set;
        }

        string OrderExternalId
        {
            get;
            set;
        }

        string OrderSalesChannelEnumId
        {
            get;
            set;
        }

        DateTime? OrderOrderDate
        {
            get;
            set;
        }

        string OrderPriority
        {
            get;
            set;
        }

        DateTime? OrderEntryDate
        {
            get;
            set;
        }

        DateTime? OrderPickSheetPrintedDate
        {
            get;
            set;
        }

        string OrderStatusId
        {
            get;
            set;
        }

        string OrderCurrencyUom
        {
            get;
            set;
        }

        string OrderSyncStatusId
        {
            get;
            set;
        }

        string OrderBillingAccountId
        {
            get;
            set;
        }

        string OrderOriginFacilityId
        {
            get;
            set;
        }

        string OrderWebSiteId
        {
            get;
            set;
        }

        string OrderProductStoreId
        {
            get;
            set;
        }

        string OrderTerminalId
        {
            get;
            set;
        }

        string OrderTransactionId
        {
            get;
            set;
        }

        string OrderAutoOrderShoppingListId
        {
            get;
            set;
        }

        string OrderNeedsInventoryIssuance
        {
            get;
            set;
        }

        string OrderIsRushOrder
        {
            get;
            set;
        }

        string OrderInternalCode
        {
            get;
            set;
        }

        decimal? OrderRemainingSubTotal
        {
            get;
            set;
        }

        decimal? OrderGrandTotal
        {
            get;
            set;
        }

        string OrderInvoicePerShipment
        {
            get;
            set;
        }

        string OrderCreatedBy
        {
            get;
            set;
        }

        DateTime? OrderCreatedAt
        {
            get;
            set;
        }

        string OrderUpdatedBy
        {
            get;
            set;
        }

        DateTime? OrderUpdatedAt
        {
            get;
            set;
        }

        bool? OrderActive
        {
            get;
            set;
        }

        long? OrderVersion
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

        IOrderRoleMvoState ToOrderRoleMvoState();

    }

}

