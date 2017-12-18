﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;

namespace Dddml.Wms.Domain.Order
{

	public abstract class OrderCommandDtoBase : ICommandDto, ICreateOrder, IMergePatchOrder, IDeleteOrder
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteOrder)this).OrderId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

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

		public virtual string OrderId { get; set; }

		public virtual string OrderTypeId { get; set; }

		public virtual string OrderName { get; set; }

		public virtual string ExternalId { get; set; }

		public virtual string SalesChannelEnumId { get; set; }

		public virtual DateTime? OrderDate { get; set; }

		public virtual string Priority { get; set; }

		public virtual DateTime? EntryDate { get; set; }

		public virtual DateTime? PickSheetPrintedDate { get; set; }

		public virtual string StatusId { get; set; }

		public virtual string CurrencyUom { get; set; }

		public virtual string SyncStatusId { get; set; }

		public virtual string BillingAccountId { get; set; }

		public virtual string OriginFacilityId { get; set; }

		public virtual string WebSiteId { get; set; }

		public virtual string ProductStoreId { get; set; }

		public virtual string TerminalId { get; set; }

		public virtual string TransactionId { get; set; }

		public virtual string AutoOrderShoppingListId { get; set; }

		public virtual string NeedsInventoryIssuance { get; set; }

		public virtual string IsRushOrder { get; set; }

		public virtual string InternalCode { get; set; }

		public virtual decimal? RemainingSubTotal { get; set; }

		public virtual decimal? GrandTotal { get; set; }

		public virtual string InvoicePerShipment { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? IsPropertyOrderTypeIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyOrderTypeIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderNameRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyOrderNameRemoved
        {
            get
            {
                var b = this.IsPropertyOrderNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyExternalIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyExternalIdRemoved
        {
            get
            {
                var b = this.IsPropertyExternalIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyExternalIdRemoved = value;
            }
        }

		public virtual bool? IsPropertySalesChannelEnumIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertySalesChannelEnumIdRemoved
        {
            get
            {
                var b = this.IsPropertySalesChannelEnumIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertySalesChannelEnumIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderDateRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyOrderDateRemoved
        {
            get
            {
                var b = this.IsPropertyOrderDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyPriorityRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyPriorityRemoved
        {
            get
            {
                var b = this.IsPropertyPriorityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPriorityRemoved = value;
            }
        }

		public virtual bool? IsPropertyEntryDateRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyEntryDateRemoved
        {
            get
            {
                var b = this.IsPropertyEntryDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEntryDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyPickSheetPrintedDateRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyPickSheetPrintedDateRemoved
        {
            get
            {
                var b = this.IsPropertyPickSheetPrintedDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPickSheetPrintedDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyStatusIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertyStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyCurrencyUomRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyCurrencyUomRemoved
        {
            get
            {
                var b = this.IsPropertyCurrencyUomRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCurrencyUomRemoved = value;
            }
        }

		public virtual bool? IsPropertySyncStatusIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertySyncStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertySyncStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertySyncStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyBillingAccountIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyBillingAccountIdRemoved
        {
            get
            {
                var b = this.IsPropertyBillingAccountIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyBillingAccountIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOriginFacilityIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyOriginFacilityIdRemoved
        {
            get
            {
                var b = this.IsPropertyOriginFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOriginFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyWebSiteIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyWebSiteIdRemoved
        {
            get
            {
                var b = this.IsPropertyWebSiteIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyWebSiteIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductStoreIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyProductStoreIdRemoved
        {
            get
            {
                var b = this.IsPropertyProductStoreIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProductStoreIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyTerminalIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyTerminalIdRemoved
        {
            get
            {
                var b = this.IsPropertyTerminalIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyTerminalIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyTransactionIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyTransactionIdRemoved
        {
            get
            {
                var b = this.IsPropertyTransactionIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyTransactionIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAutoOrderShoppingListIdRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyAutoOrderShoppingListIdRemoved
        {
            get
            {
                var b = this.IsPropertyAutoOrderShoppingListIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAutoOrderShoppingListIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyNeedsInventoryIssuanceRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyNeedsInventoryIssuanceRemoved
        {
            get
            {
                var b = this.IsPropertyNeedsInventoryIssuanceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyNeedsInventoryIssuanceRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsRushOrderRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyIsRushOrderRemoved
        {
            get
            {
                var b = this.IsPropertyIsRushOrderRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsRushOrderRemoved = value;
            }
        }

		public virtual bool? IsPropertyInternalCodeRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyInternalCodeRemoved
        {
            get
            {
                var b = this.IsPropertyInternalCodeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInternalCodeRemoved = value;
            }
        }

		public virtual bool? IsPropertyRemainingSubTotalRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyRemainingSubTotalRemoved
        {
            get
            {
                var b = this.IsPropertyRemainingSubTotalRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyRemainingSubTotalRemoved = value;
            }
        }

		public virtual bool? IsPropertyGrandTotalRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyGrandTotalRemoved
        {
            get
            {
                var b = this.IsPropertyGrandTotalRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyGrandTotalRemoved = value;
            }
        }

		public virtual bool? IsPropertyInvoicePerShipmentRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyInvoicePerShipmentRemoved
        {
            get
            {
                var b = this.IsPropertyInvoicePerShipmentRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInvoicePerShipmentRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchOrder.IsPropertyActiveRemoved
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

        ICreateOrderItemCommands ICreateOrder.OrderItems
        {
            get
            {
                return this._orderItems;
            }
        }

        IOrderItemCommands IMergePatchOrder.OrderItemCommands
        {
            get
            {
                return this._orderItems;
            }
        }

        public virtual CreateOrderItemDto NewCreateOrderItem()
        {
            var c = new CreateOrderItemDto();
            c.OrderId = this.OrderId;

            return c;
        }

        ICreateOrderItem ICreateOrder.NewCreateOrderItem()
        {
            return this.NewCreateOrderItem();
        }

        ICreateOrderItem IMergePatchOrder.NewCreateOrderItem()
        {
            return this.NewCreateOrderItem();
        }

        public virtual MergePatchOrderItemDto NewMergePatchOrderItem()
        {
            var c = new MergePatchOrderItemDto();
            c.OrderId = this.OrderId;

            return c;
        }

        IMergePatchOrderItem IMergePatchOrder.NewMergePatchOrderItem()
        {
            return this.NewMergePatchOrderItem();
        }

        public virtual RemoveOrderItemDto NewRemoveOrderItem()
        {
            var c = new RemoveOrderItemDto();
            c.OrderId = this.OrderId;

            return c;
        }

        IRemoveOrderItem IMergePatchOrder.NewRemoveOrderItem()
        {
            return this.NewRemoveOrderItem();
        }

        private CreateOrMergePatchOrRemoveOrderItemDtos _orderItems = new CreateOrMergePatchOrRemoveOrderItemDtos();

        public virtual CreateOrMergePatchOrRemoveOrderItemDto[] OrderItems
        {
            get
            {
                return _orderItems.ToArray();
            }
            set
            {
                _orderItems.Clear();
                _orderItems.AddRange(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteOrderDto : OrderCommandDtoBase
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



	public class CreateOrderDto : CreateOrMergePatchOrDeleteOrderDto
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


	public class MergePatchOrderDto : CreateOrMergePatchOrDeleteOrderDto
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

	public class DeleteOrderDto : CreateOrMergePatchOrDeleteOrderDto
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

    public static partial class OrderCommandDtos
    {

    }

}
