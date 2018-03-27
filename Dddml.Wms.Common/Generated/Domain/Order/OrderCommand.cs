﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public abstract class OrderCommandBase : IOrderCommand
	{
		public virtual string OrderId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.OrderId;
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


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateOrder : OrderCommandBase, ICreateOrder
	{
		
		public CreateOrder ()
		{
		}


        private CreateOrderRoleCommands _orderRoles = new CreateOrderRoleCommands();

        public ICreateOrderRoleCommands OrderRoles
        {
            get
            {
                return this._orderRoles;
            }
        }

        public CreateOrderRole NewCreateOrderRole()
        {
            var c = new CreateOrderRole();
            c.OrderId = this.OrderId;

            return c;
        }

        ICreateOrderRole ICreateOrder.NewCreateOrderRole()
        {
            return this.NewCreateOrderRole();
        }



        private CreateOrderItemCommands _orderItems = new CreateOrderItemCommands();

        public ICreateOrderItemCommands OrderItems
        {
            get
            {
                return this._orderItems;
            }
        }

        public CreateOrderItem NewCreateOrderItem()
        {
            var c = new CreateOrderItem();
            c.OrderId = this.OrderId;

            return c;
        }

        ICreateOrderItem ICreateOrder.NewCreateOrderItem()
        {
            return this.NewCreateOrderItem();
        }



        private CreateOrderShipGroupCommands _orderShipGroups = new CreateOrderShipGroupCommands();

        public ICreateOrderShipGroupCommands OrderShipGroups
        {
            get
            {
                return this._orderShipGroups;
            }
        }

        public CreateOrderShipGroup NewCreateOrderShipGroup()
        {
            var c = new CreateOrderShipGroup();
            c.OrderId = this.OrderId;

            return c;
        }

        ICreateOrderShipGroup ICreateOrder.NewCreateOrderShipGroup()
        {
            return this.NewCreateOrderShipGroup();
        }



        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchOrder :OrderCommandBase, IMergePatchOrder
	{

		public virtual bool IsPropertyOrderTypeIdRemoved { get; set; }

		public virtual bool IsPropertyOrderNameRemoved { get; set; }

		public virtual bool IsPropertyExternalIdRemoved { get; set; }

		public virtual bool IsPropertySalesChannelEnumIdRemoved { get; set; }

		public virtual bool IsPropertyOrderDateRemoved { get; set; }

		public virtual bool IsPropertyPriorityRemoved { get; set; }

		public virtual bool IsPropertyEntryDateRemoved { get; set; }

		public virtual bool IsPropertyPickSheetPrintedDateRemoved { get; set; }

		public virtual bool IsPropertyStatusIdRemoved { get; set; }

		public virtual bool IsPropertyCurrencyUomRemoved { get; set; }

		public virtual bool IsPropertySyncStatusIdRemoved { get; set; }

		public virtual bool IsPropertyBillingAccountIdRemoved { get; set; }

		public virtual bool IsPropertyOriginFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyWebSiteIdRemoved { get; set; }

		public virtual bool IsPropertyProductStoreIdRemoved { get; set; }

		public virtual bool IsPropertyTerminalIdRemoved { get; set; }

		public virtual bool IsPropertyTransactionIdRemoved { get; set; }

		public virtual bool IsPropertyAutoOrderShoppingListIdRemoved { get; set; }

		public virtual bool IsPropertyNeedsInventoryIssuanceRemoved { get; set; }

		public virtual bool IsPropertyIsRushOrderRemoved { get; set; }

		public virtual bool IsPropertyInternalCodeRemoved { get; set; }

		public virtual bool IsPropertyRemainingSubTotalRemoved { get; set; }

		public virtual bool IsPropertyGrandTotalRemoved { get; set; }

		public virtual bool IsPropertyInvoicePerShipmentRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchOrder ()
		{
		}

        private OrderRoleCommands _orderRoleCommands = new OrderRoleCommands();

        public IOrderRoleCommands OrderRoleCommands
        {
            get
            {
                return this._orderRoleCommands;
            }
        }


        public CreateOrderRole NewCreateOrderRole()
        {
            var c = new CreateOrderRole();
            c.OrderId = this.OrderId;

            return c;
        }

        ICreateOrderRole IMergePatchOrder.NewCreateOrderRole()
        {
            return this.NewCreateOrderRole();
        }

        public MergePatchOrderRole NewMergePatchOrderRole()
        {
            var c = new MergePatchOrderRole();
            c.OrderId = this.OrderId;

            return c;
        }

        IMergePatchOrderRole IMergePatchOrder.NewMergePatchOrderRole()
        {
            return this.NewMergePatchOrderRole();
        }


        public RemoveOrderRole NewRemoveOrderRole()
        {
            var c = new RemoveOrderRole();
            c.OrderId = this.OrderId;

            return c;
        }

        IRemoveOrderRole IMergePatchOrder.NewRemoveOrderRole()
        {
            return this.NewRemoveOrderRole();
        }


        private OrderItemCommands _orderItemCommands = new OrderItemCommands();

        public IOrderItemCommands OrderItemCommands
        {
            get
            {
                return this._orderItemCommands;
            }
        }


        public CreateOrderItem NewCreateOrderItem()
        {
            var c = new CreateOrderItem();
            c.OrderId = this.OrderId;

            return c;
        }

        ICreateOrderItem IMergePatchOrder.NewCreateOrderItem()
        {
            return this.NewCreateOrderItem();
        }

        public MergePatchOrderItem NewMergePatchOrderItem()
        {
            var c = new MergePatchOrderItem();
            c.OrderId = this.OrderId;

            return c;
        }

        IMergePatchOrderItem IMergePatchOrder.NewMergePatchOrderItem()
        {
            return this.NewMergePatchOrderItem();
        }


        public RemoveOrderItem NewRemoveOrderItem()
        {
            var c = new RemoveOrderItem();
            c.OrderId = this.OrderId;

            return c;
        }

        IRemoveOrderItem IMergePatchOrder.NewRemoveOrderItem()
        {
            return this.NewRemoveOrderItem();
        }


        private OrderShipGroupCommands _orderShipGroupCommands = new OrderShipGroupCommands();

        public IOrderShipGroupCommands OrderShipGroupCommands
        {
            get
            {
                return this._orderShipGroupCommands;
            }
        }


        public CreateOrderShipGroup NewCreateOrderShipGroup()
        {
            var c = new CreateOrderShipGroup();
            c.OrderId = this.OrderId;

            return c;
        }

        ICreateOrderShipGroup IMergePatchOrder.NewCreateOrderShipGroup()
        {
            return this.NewCreateOrderShipGroup();
        }

        public MergePatchOrderShipGroup NewMergePatchOrderShipGroup()
        {
            var c = new MergePatchOrderShipGroup();
            c.OrderId = this.OrderId;

            return c;
        }

        IMergePatchOrderShipGroup IMergePatchOrder.NewMergePatchOrderShipGroup()
        {
            return this.NewMergePatchOrderShipGroup();
        }


        public RemoveOrderShipGroup NewRemoveOrderShipGroup()
        {
            var c = new RemoveOrderShipGroup();
            c.OrderId = this.OrderId;

            return c;
        }

        IRemoveOrderShipGroup IMergePatchOrder.NewRemoveOrderShipGroup()
        {
            return this.NewRemoveOrderShipGroup();
        }


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteOrder : OrderCommandBase, IDeleteOrder
	{
		public DeleteOrder ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}


    public class CreateOrderRoleCommands : ICreateOrderRoleCommands
    {
        private List<ICreateOrderRole> _innerCommands = new List<ICreateOrderRole>();

        public void Add(ICreateOrderRole c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateOrderRole c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateOrderRole> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class OrderRoleCommands : IOrderRoleCommands
    {
        private List<IOrderRoleCommand> _innerCommands = new List<IOrderRoleCommand>();

        public void Add(IOrderRoleCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IOrderRoleCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IOrderRoleCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }


    public class CreateOrderItemCommands : ICreateOrderItemCommands
    {
        private List<ICreateOrderItem> _innerCommands = new List<ICreateOrderItem>();

        public void Add(ICreateOrderItem c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateOrderItem c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateOrderItem> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class OrderItemCommands : IOrderItemCommands
    {
        private List<IOrderItemCommand> _innerCommands = new List<IOrderItemCommand>();

        public void Add(IOrderItemCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IOrderItemCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IOrderItemCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }


    public class CreateOrderShipGroupCommands : ICreateOrderShipGroupCommands
    {
        private List<ICreateOrderShipGroup> _innerCommands = new List<ICreateOrderShipGroup>();

        public void Add(ICreateOrderShipGroup c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateOrderShipGroup c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateOrderShipGroup> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class OrderShipGroupCommands : IOrderShipGroupCommands
    {
        private List<IOrderShipGroupCommand> _innerCommands = new List<IOrderShipGroupCommand>();

        public void Add(IOrderShipGroupCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IOrderShipGroupCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IOrderShipGroupCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public static partial class OrderCommands
    {
    }

}
