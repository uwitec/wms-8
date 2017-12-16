﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderHeaderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderHeader;

namespace Dddml.Wms.Domain.OrderHeader
{
    public partial class OrderHeaderAggregate : AggregateBase, IOrderHeaderAggregate
    {

        readonly IOrderHeaderState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IOrderHeaderState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public OrderHeaderAggregate(IOrderHeaderState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IOrderHeaderStateProperties)_state).Version == OrderHeaderState.VersionZero)
            {
                if (IsCommandCreate((IOrderHeaderCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (IsCommandCreate((IOrderHeaderCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IOrderHeaderCommand c)
        {
            return c.Version == OrderHeaderState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateOrderHeader c)
        {
            IOrderHeaderStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchOrderHeader c)
        {
            IOrderHeaderStateMergePatched e = Map(c);
            Apply(e);
        }


        protected virtual IOrderHeaderStateCreated Map(ICreateOrderHeader c)
        {
			var stateEventId = new OrderHeaderStateEventId(c.OrderId, c.Version);
            IOrderHeaderStateCreated e = NewOrderHeaderStateCreated(stateEventId);
		
            e.OrderTypeId = c.OrderTypeId;
            e.OrderName = c.OrderName;
            e.ExternalId = c.ExternalId;
            e.SalesChannelEnumId = c.SalesChannelEnumId;
            e.OrderDate = c.OrderDate;
            e.Priority = c.Priority;
            e.EntryDate = c.EntryDate;
            e.PickSheetPrintedDate = c.PickSheetPrintedDate;
            e.StatusId = c.StatusId;
            e.CurrencyUom = c.CurrencyUom;
            e.SyncStatusId = c.SyncStatusId;
            e.BillingAccountId = c.BillingAccountId;
            e.OriginFacilityId = c.OriginFacilityId;
            e.WebSiteId = c.WebSiteId;
            e.ProductStoreId = c.ProductStoreId;
            e.TerminalId = c.TerminalId;
            e.TransactionId = c.TransactionId;
            e.AutoOrderShoppingListId = c.AutoOrderShoppingListId;
            e.NeedsInventoryIssuance = c.NeedsInventoryIssuance;
            e.IsRushOrder = c.IsRushOrder;
            e.InternalCode = c.InternalCode;
            e.RemainingSubTotal = c.RemainingSubTotal;
            e.GrandTotal = c.GrandTotal;
            e.InvoicePerShipment = c.InvoicePerShipment;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;


            return e;
        }

        protected virtual IOrderHeaderStateMergePatched Map(IMergePatchOrderHeader c)
        {
			var stateEventId = new OrderHeaderStateEventId(c.OrderId, c.Version);
            IOrderHeaderStateMergePatched e = NewOrderHeaderStateMergePatched(stateEventId);

            e.OrderTypeId = c.OrderTypeId;
            e.OrderName = c.OrderName;
            e.ExternalId = c.ExternalId;
            e.SalesChannelEnumId = c.SalesChannelEnumId;
            e.OrderDate = c.OrderDate;
            e.Priority = c.Priority;
            e.EntryDate = c.EntryDate;
            e.PickSheetPrintedDate = c.PickSheetPrintedDate;
            e.StatusId = c.StatusId;
            e.CurrencyUom = c.CurrencyUom;
            e.SyncStatusId = c.SyncStatusId;
            e.BillingAccountId = c.BillingAccountId;
            e.OriginFacilityId = c.OriginFacilityId;
            e.WebSiteId = c.WebSiteId;
            e.ProductStoreId = c.ProductStoreId;
            e.TerminalId = c.TerminalId;
            e.TransactionId = c.TransactionId;
            e.AutoOrderShoppingListId = c.AutoOrderShoppingListId;
            e.NeedsInventoryIssuance = c.NeedsInventoryIssuance;
            e.IsRushOrder = c.IsRushOrder;
            e.InternalCode = c.InternalCode;
            e.RemainingSubTotal = c.RemainingSubTotal;
            e.GrandTotal = c.GrandTotal;
            e.InvoicePerShipment = c.InvoicePerShipment;
            e.Active = c.Active;
            e.IsPropertyOrderTypeIdRemoved = c.IsPropertyOrderTypeIdRemoved;
            e.IsPropertyOrderNameRemoved = c.IsPropertyOrderNameRemoved;
            e.IsPropertyExternalIdRemoved = c.IsPropertyExternalIdRemoved;
            e.IsPropertySalesChannelEnumIdRemoved = c.IsPropertySalesChannelEnumIdRemoved;
            e.IsPropertyOrderDateRemoved = c.IsPropertyOrderDateRemoved;
            e.IsPropertyPriorityRemoved = c.IsPropertyPriorityRemoved;
            e.IsPropertyEntryDateRemoved = c.IsPropertyEntryDateRemoved;
            e.IsPropertyPickSheetPrintedDateRemoved = c.IsPropertyPickSheetPrintedDateRemoved;
            e.IsPropertyStatusIdRemoved = c.IsPropertyStatusIdRemoved;
            e.IsPropertyCurrencyUomRemoved = c.IsPropertyCurrencyUomRemoved;
            e.IsPropertySyncStatusIdRemoved = c.IsPropertySyncStatusIdRemoved;
            e.IsPropertyBillingAccountIdRemoved = c.IsPropertyBillingAccountIdRemoved;
            e.IsPropertyOriginFacilityIdRemoved = c.IsPropertyOriginFacilityIdRemoved;
            e.IsPropertyWebSiteIdRemoved = c.IsPropertyWebSiteIdRemoved;
            e.IsPropertyProductStoreIdRemoved = c.IsPropertyProductStoreIdRemoved;
            e.IsPropertyTerminalIdRemoved = c.IsPropertyTerminalIdRemoved;
            e.IsPropertyTransactionIdRemoved = c.IsPropertyTransactionIdRemoved;
            e.IsPropertyAutoOrderShoppingListIdRemoved = c.IsPropertyAutoOrderShoppingListIdRemoved;
            e.IsPropertyNeedsInventoryIssuanceRemoved = c.IsPropertyNeedsInventoryIssuanceRemoved;
            e.IsPropertyIsRushOrderRemoved = c.IsPropertyIsRushOrderRemoved;
            e.IsPropertyInternalCodeRemoved = c.IsPropertyInternalCodeRemoved;
            e.IsPropertyRemainingSubTotalRemoved = c.IsPropertyRemainingSubTotalRemoved;
            e.IsPropertyGrandTotalRemoved = c.IsPropertyGrandTotalRemoved;
            e.IsPropertyInvoicePerShipmentRemoved = c.IsPropertyInvoicePerShipmentRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected OrderHeaderStateCreated NewOrderHeaderStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new OrderHeaderStateEventId(_state.OrderId, ((IOrderHeaderStateProperties)_state).Version);
            var e = NewOrderHeaderStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected OrderHeaderStateMergePatched NewOrderHeaderStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new OrderHeaderStateEventId(_state.OrderId, ((IOrderHeaderStateProperties)_state).Version);
            var e = NewOrderHeaderStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


////////////////////////

		private OrderHeaderStateCreated NewOrderHeaderStateCreated(OrderHeaderStateEventId stateEventId)
		{
			return new OrderHeaderStateCreated(stateEventId);			
		}

        private OrderHeaderStateMergePatched NewOrderHeaderStateMergePatched(OrderHeaderStateEventId stateEventId)
		{
			return new OrderHeaderStateMergePatched(stateEventId);
		}


    }

}

