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
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public partial class OrderState : OrderStateProperties, IOrderState, ISaveable
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.OrderId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion


		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IOrderState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        private IOrderRoleStates _orderRoles;
      
        public virtual IOrderRoleStates OrderRoles
        {
            get
            {
                return this._orderRoles;
            }
            set
            {
                this._orderRoles = value;
            }
        }


        private IOrderItemStates _orderItems;
      
        public virtual IOrderItemStates OrderItems
        {
            get
            {
                return this._orderItems;
            }
            set
            {
                this._orderItems = value;
            }
        }


        private IOrderShipGroupStates _orderShipGroups;
      
        public virtual IOrderShipGroupStates OrderShipGroups
        {
            get
            {
                return this._orderShipGroups;
            }
            set
            {
                this._orderShipGroups = value;
            }
        }


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public OrderState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.OrderId = ((IOrderStateEvent)events.First()).OrderEventId.OrderId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public OrderState() : this(false)
        {
        }

        public OrderState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            _orderRoles = new OrderRoleStates(this);

            _orderItems = new OrderItemStates(this);

            _orderShipGroups = new OrderShipGroupStates(this);

            InitializeProperties();
        }


		#region Saveable Implements

        public virtual void Save()
        {
            _orderRoles.Save();

            _orderItems.Save();

            _orderShipGroups.Save();

        }


		#endregion


		public virtual void When(IOrderStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.OrderTypeId = e.OrderTypeId;

			this.OrderName = e.OrderName;

			this.ExternalId = e.ExternalId;

			this.SalesChannelEnumId = e.SalesChannelEnumId;

			this.OrderDate = e.OrderDate;

			this.Priority = e.Priority;

			this.EntryDate = e.EntryDate;

			this.PickSheetPrintedDate = e.PickSheetPrintedDate;

			this.StatusId = e.StatusId;

			this.CurrencyUom = e.CurrencyUom;

			this.SyncStatusId = e.SyncStatusId;

			this.BillingAccountId = e.BillingAccountId;

			this.OriginFacilityId = e.OriginFacilityId;

			this.WebSiteId = e.WebSiteId;

			this.ProductStoreId = e.ProductStoreId;

			this.TerminalId = e.TerminalId;

			this.TransactionId = e.TransactionId;

			this.AutoOrderShoppingListId = e.AutoOrderShoppingListId;

			this.NeedsInventoryIssuance = e.NeedsInventoryIssuance;

			this.IsRushOrder = e.IsRushOrder;

			this.InternalCode = e.InternalCode;

			this.RemainingSubTotal = e.RemainingSubTotal;

			this.GrandTotal = e.GrandTotal;

			this.InvoicePerShipment = e.InvoicePerShipment;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;

			foreach (IOrderRoleStateCreated innerEvent in e.OrderRoleEvents) {
				IOrderRoleState innerState = this.OrderRoles.Get(innerEvent.GlobalId.PartyRoleId, true);
				innerState.Mutate (innerEvent);
			}
			foreach (IOrderItemStateCreated innerEvent in e.OrderItemEvents) {
				IOrderItemState innerState = this.OrderItems.Get(innerEvent.GlobalId.OrderItemSeqId, true);
				innerState.Mutate (innerEvent);
			}
			foreach (IOrderShipGroupStateCreated innerEvent in e.OrderShipGroupEvents) {
				IOrderShipGroupState innerState = this.OrderShipGroups.Get(innerEvent.GlobalId.ShipGroupSeqId, true);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IOrderStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.OrderTypeId == null)
			{
				if (e.IsPropertyOrderTypeIdRemoved)
				{
					this.OrderTypeId = default(string);
				}
			}
			else
			{
				this.OrderTypeId = e.OrderTypeId;
			}

			if (e.OrderName == null)
			{
				if (e.IsPropertyOrderNameRemoved)
				{
					this.OrderName = default(string);
				}
			}
			else
			{
				this.OrderName = e.OrderName;
			}

			if (e.ExternalId == null)
			{
				if (e.IsPropertyExternalIdRemoved)
				{
					this.ExternalId = default(string);
				}
			}
			else
			{
				this.ExternalId = e.ExternalId;
			}

			if (e.SalesChannelEnumId == null)
			{
				if (e.IsPropertySalesChannelEnumIdRemoved)
				{
					this.SalesChannelEnumId = default(string);
				}
			}
			else
			{
				this.SalesChannelEnumId = e.SalesChannelEnumId;
			}

			if (e.OrderDate == null)
			{
				if (e.IsPropertyOrderDateRemoved)
				{
					this.OrderDate = default(DateTime?);
				}
			}
			else
			{
				this.OrderDate = e.OrderDate;
			}

			if (e.Priority == null)
			{
				if (e.IsPropertyPriorityRemoved)
				{
					this.Priority = default(string);
				}
			}
			else
			{
				this.Priority = e.Priority;
			}

			if (e.EntryDate == null)
			{
				if (e.IsPropertyEntryDateRemoved)
				{
					this.EntryDate = default(DateTime?);
				}
			}
			else
			{
				this.EntryDate = e.EntryDate;
			}

			if (e.PickSheetPrintedDate == null)
			{
				if (e.IsPropertyPickSheetPrintedDateRemoved)
				{
					this.PickSheetPrintedDate = default(DateTime?);
				}
			}
			else
			{
				this.PickSheetPrintedDate = e.PickSheetPrintedDate;
			}

			if (e.StatusId == null)
			{
				if (e.IsPropertyStatusIdRemoved)
				{
					this.StatusId = default(string);
				}
			}
			else
			{
				this.StatusId = e.StatusId;
			}

			if (e.CurrencyUom == null)
			{
				if (e.IsPropertyCurrencyUomRemoved)
				{
					this.CurrencyUom = default(string);
				}
			}
			else
			{
				this.CurrencyUom = e.CurrencyUom;
			}

			if (e.SyncStatusId == null)
			{
				if (e.IsPropertySyncStatusIdRemoved)
				{
					this.SyncStatusId = default(string);
				}
			}
			else
			{
				this.SyncStatusId = e.SyncStatusId;
			}

			if (e.BillingAccountId == null)
			{
				if (e.IsPropertyBillingAccountIdRemoved)
				{
					this.BillingAccountId = default(string);
				}
			}
			else
			{
				this.BillingAccountId = e.BillingAccountId;
			}

			if (e.OriginFacilityId == null)
			{
				if (e.IsPropertyOriginFacilityIdRemoved)
				{
					this.OriginFacilityId = default(string);
				}
			}
			else
			{
				this.OriginFacilityId = e.OriginFacilityId;
			}

			if (e.WebSiteId == null)
			{
				if (e.IsPropertyWebSiteIdRemoved)
				{
					this.WebSiteId = default(string);
				}
			}
			else
			{
				this.WebSiteId = e.WebSiteId;
			}

			if (e.ProductStoreId == null)
			{
				if (e.IsPropertyProductStoreIdRemoved)
				{
					this.ProductStoreId = default(string);
				}
			}
			else
			{
				this.ProductStoreId = e.ProductStoreId;
			}

			if (e.TerminalId == null)
			{
				if (e.IsPropertyTerminalIdRemoved)
				{
					this.TerminalId = default(string);
				}
			}
			else
			{
				this.TerminalId = e.TerminalId;
			}

			if (e.TransactionId == null)
			{
				if (e.IsPropertyTransactionIdRemoved)
				{
					this.TransactionId = default(string);
				}
			}
			else
			{
				this.TransactionId = e.TransactionId;
			}

			if (e.AutoOrderShoppingListId == null)
			{
				if (e.IsPropertyAutoOrderShoppingListIdRemoved)
				{
					this.AutoOrderShoppingListId = default(string);
				}
			}
			else
			{
				this.AutoOrderShoppingListId = e.AutoOrderShoppingListId;
			}

			if (e.NeedsInventoryIssuance == null)
			{
				if (e.IsPropertyNeedsInventoryIssuanceRemoved)
				{
					this.NeedsInventoryIssuance = default(string);
				}
			}
			else
			{
				this.NeedsInventoryIssuance = e.NeedsInventoryIssuance;
			}

			if (e.IsRushOrder == null)
			{
				if (e.IsPropertyIsRushOrderRemoved)
				{
					this.IsRushOrder = default(string);
				}
			}
			else
			{
				this.IsRushOrder = e.IsRushOrder;
			}

			if (e.InternalCode == null)
			{
				if (e.IsPropertyInternalCodeRemoved)
				{
					this.InternalCode = default(string);
				}
			}
			else
			{
				this.InternalCode = e.InternalCode;
			}

			if (e.RemainingSubTotal == null)
			{
				if (e.IsPropertyRemainingSubTotalRemoved)
				{
					this.RemainingSubTotal = default(decimal?);
				}
			}
			else
			{
				this.RemainingSubTotal = e.RemainingSubTotal;
			}

			if (e.GrandTotal == null)
			{
				if (e.IsPropertyGrandTotalRemoved)
				{
					this.GrandTotal = default(decimal?);
				}
			}
			else
			{
				this.GrandTotal = e.GrandTotal;
			}

			if (e.InvoicePerShipment == null)
			{
				if (e.IsPropertyInvoicePerShipmentRemoved)
				{
					this.InvoicePerShipment = default(string);
				}
			}
			else
			{
				this.InvoicePerShipment = e.InvoicePerShipment;
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


			foreach (IOrderRoleStateEvent innerEvent in e.OrderRoleEvents)
            {
                IOrderRoleState innerState = this.OrderRoles.Get(innerEvent.GlobalId.PartyRoleId);

                innerState.Mutate(innerEvent);
                var removed = innerEvent as IOrderRoleStateRemoved;
                if (removed != null)
                {
                    this.OrderRoles.Remove(innerState);
                }
          
            }

			foreach (IOrderItemStateEvent innerEvent in e.OrderItemEvents)
            {
                IOrderItemState innerState = this.OrderItems.Get(innerEvent.GlobalId.OrderItemSeqId);

                innerState.Mutate(innerEvent);
          
            }

			foreach (IOrderShipGroupStateEvent innerEvent in e.OrderShipGroupEvents)
            {
                IOrderShipGroupState innerState = this.OrderShipGroups.Get(innerEvent.GlobalId.ShipGroupSeqId);

                innerState.Mutate(innerEvent);
                var removed = innerEvent as IOrderShipGroupStateRemoved;
                if (removed != null)
                {
                    this.OrderShipGroups.Remove(innerState);
                }
          
            }

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IOrderStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("Order|");

            var stateEntityId = this.OrderId; // Aggregate Id
            var eventEntityId = stateEvent.OrderEventId.OrderId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = stateEvent.OrderEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

