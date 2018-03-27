﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderRoleMvo;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.OrderRoleMvo
{

	public abstract class OrderRoleMvoCommandDtoBase : ICommandDto, ICreateOrderRoleMvo, IMergePatchOrderRoleMvo, IDeleteOrderRoleMvo
	{

		OrderRoleId IAggregateCommand<OrderRoleId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteOrderRoleMvo)this).OrderRoleId;
			}
		}


		long IAggregateCommand<OrderRoleId, long>.AggregateVersion
		{
			get
			{
				return this.OrderVersion;
			}
		}

		public virtual long OrderVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual OrderRoleId OrderRoleId { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string OrderOrderTypeId { get; set; }

		public virtual string OrderOrderName { get; set; }

		public virtual string OrderExternalId { get; set; }

		public virtual string OrderSalesChannelEnumId { get; set; }

		public virtual DateTime? OrderOrderDate { get; set; }

		public virtual string OrderPriority { get; set; }

		public virtual DateTime? OrderEntryDate { get; set; }

		public virtual DateTime? OrderPickSheetPrintedDate { get; set; }

		public virtual string OrderStatusId { get; set; }

		public virtual string OrderCurrencyUom { get; set; }

		public virtual string OrderSyncStatusId { get; set; }

		public virtual string OrderBillingAccountId { get; set; }

		public virtual string OrderOriginFacilityId { get; set; }

		public virtual string OrderWebSiteId { get; set; }

		public virtual string OrderProductStoreId { get; set; }

		public virtual string OrderTerminalId { get; set; }

		public virtual string OrderTransactionId { get; set; }

		public virtual string OrderAutoOrderShoppingListId { get; set; }

		public virtual string OrderNeedsInventoryIssuance { get; set; }

		public virtual string OrderIsRushOrder { get; set; }

		public virtual string OrderInternalCode { get; set; }

		public virtual decimal? OrderRemainingSubTotal { get; set; }

		public virtual decimal? OrderGrandTotal { get; set; }

		public virtual string OrderInvoicePerShipment { get; set; }

		public virtual string OrderCreatedBy { get; set; }

		public virtual DateTime? OrderCreatedAt { get; set; }

		public virtual string OrderUpdatedBy { get; set; }

		public virtual DateTime? OrderUpdatedAt { get; set; }

		public virtual bool? OrderActive { get; set; }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyVersionRemoved
        {
            get
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderOrderTypeIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderOrderTypeIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderOrderTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderOrderTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderOrderNameRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderOrderNameRemoved
        {
            get
            {
                var b = this.IsPropertyOrderOrderNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderOrderNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderExternalIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderExternalIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderExternalIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderExternalIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderSalesChannelEnumIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderSalesChannelEnumIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderSalesChannelEnumIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderSalesChannelEnumIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderOrderDateRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderOrderDateRemoved
        {
            get
            {
                var b = this.IsPropertyOrderOrderDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderOrderDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderPriorityRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderPriorityRemoved
        {
            get
            {
                var b = this.IsPropertyOrderPriorityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderPriorityRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderEntryDateRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderEntryDateRemoved
        {
            get
            {
                var b = this.IsPropertyOrderEntryDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderEntryDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderPickSheetPrintedDateRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderPickSheetPrintedDateRemoved
        {
            get
            {
                var b = this.IsPropertyOrderPickSheetPrintedDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderPickSheetPrintedDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderStatusIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderCurrencyUomRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderCurrencyUomRemoved
        {
            get
            {
                var b = this.IsPropertyOrderCurrencyUomRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderCurrencyUomRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderSyncStatusIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderSyncStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderSyncStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderSyncStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderBillingAccountIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderBillingAccountIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderBillingAccountIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderBillingAccountIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderOriginFacilityIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderOriginFacilityIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderOriginFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderOriginFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderWebSiteIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderWebSiteIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderWebSiteIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderWebSiteIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderProductStoreIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderProductStoreIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderProductStoreIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderProductStoreIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderTerminalIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderTerminalIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderTerminalIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderTerminalIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderTransactionIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderTransactionIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderTransactionIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderTransactionIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderAutoOrderShoppingListIdRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderAutoOrderShoppingListIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderAutoOrderShoppingListIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderAutoOrderShoppingListIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderNeedsInventoryIssuanceRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderNeedsInventoryIssuanceRemoved
        {
            get
            {
                var b = this.IsPropertyOrderNeedsInventoryIssuanceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderNeedsInventoryIssuanceRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderIsRushOrderRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderIsRushOrderRemoved
        {
            get
            {
                var b = this.IsPropertyOrderIsRushOrderRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderIsRushOrderRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderInternalCodeRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderInternalCodeRemoved
        {
            get
            {
                var b = this.IsPropertyOrderInternalCodeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderInternalCodeRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderRemainingSubTotalRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderRemainingSubTotalRemoved
        {
            get
            {
                var b = this.IsPropertyOrderRemainingSubTotalRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderRemainingSubTotalRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderGrandTotalRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderGrandTotalRemoved
        {
            get
            {
                var b = this.IsPropertyOrderGrandTotalRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderGrandTotalRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderInvoicePerShipmentRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderInvoicePerShipmentRemoved
        {
            get
            {
                var b = this.IsPropertyOrderInvoicePerShipmentRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderInvoicePerShipmentRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderCreatedByRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyOrderCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderCreatedAtRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyOrderCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderUpdatedByRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyOrderUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderUpdatedAtRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyOrderUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderActiveRemoved { get; set; }

        bool IMergePatchOrderRoleMvo.IsPropertyOrderActiveRemoved
        {
            get
            {
                var b = this.IsPropertyOrderActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderActiveRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteOrderRoleMvoDto : OrderRoleMvoCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateOrderRoleMvoDto : CreateOrMergePatchOrDeleteOrderRoleMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchOrderRoleMvoDto : CreateOrMergePatchOrDeleteOrderRoleMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteOrderRoleMvoDto : CreateOrMergePatchOrDeleteOrderRoleMvoDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class OrderRoleMvoCommandDtos
    {

    }

}

