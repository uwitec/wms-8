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

	public abstract class OrderEventBase : IOrderEvent
	{

		public virtual OrderEventId OrderEventId { get; set; }

        public virtual string OrderId
        {
            get { return OrderEventId.OrderId; }
            set { OrderEventId.OrderId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrderEventId IGlobalIdentity<OrderEventId>.GlobalId {
			get
			{
				return this.OrderEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IOrderEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected OrderEventBase()
        {
        }

        protected OrderEventBase(OrderEventId stateEventId)
        {
            this.OrderEventId = stateEventId;
        }

		protected IOrderRoleEventDao OrderRoleEventDao
		{
			get { return ApplicationContext.Current["OrderRoleEventDao"] as IOrderRoleEventDao; }
		}

        protected OrderRoleEventId NewOrderRoleEventId(PartyRoleId partyRoleId)
        {
            var stateEventId = new OrderRoleEventId(this.OrderEventId.OrderId, partyRoleId, this.OrderEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IOrderRoleEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IOrderEvent oe, IOrderRoleEvent e)
		{
			if (!oe.OrderEventId.OrderId.Equals(e.OrderRoleEventId.OrderId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id OrderId {0} but inner id OrderId {1}", 
					oe.OrderEventId.OrderId, e.OrderRoleEventId.OrderId);
			}
		}


		protected IOrderItemEventDao OrderItemEventDao
		{
			get { return ApplicationContext.Current["OrderItemEventDao"] as IOrderItemEventDao; }
		}

        protected OrderItemEventId NewOrderItemEventId(string orderItemSeqId)
        {
            var stateEventId = new OrderItemEventId(this.OrderEventId.OrderId, orderItemSeqId, this.OrderEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IOrderItemEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IOrderEvent oe, IOrderItemEvent e)
		{
			if (!oe.OrderEventId.OrderId.Equals(e.OrderItemEventId.OrderId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id OrderId {0} but inner id OrderId {1}", 
					oe.OrderEventId.OrderId, e.OrderItemEventId.OrderId);
			}
		}


		protected IOrderShipGroupEventDao OrderShipGroupEventDao
		{
			get { return ApplicationContext.Current["OrderShipGroupEventDao"] as IOrderShipGroupEventDao; }
		}

        protected OrderShipGroupEventId NewOrderShipGroupEventId(long? shipGroupSeqId)
        {
            var stateEventId = new OrderShipGroupEventId(this.OrderEventId.OrderId, shipGroupSeqId, this.OrderEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IOrderShipGroupEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IOrderEvent oe, IOrderShipGroupEvent e)
		{
			if (!oe.OrderEventId.OrderId.Equals(e.OrderShipGroupEventId.OrderId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id OrderId {0} but inner id OrderId {1}", 
					oe.OrderEventId.OrderId, e.OrderShipGroupEventId.OrderId);
			}
		}



        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class OrderStateEventBase : OrderEventBase, IOrderStateEvent
    {

		public virtual string OrderTypeId { get; set; }

		public virtual string OrderName { get; set; }

		public virtual string ExternalId { get; set; }

		public virtual string SalesChannelEnumId { get; set; }

		public virtual DateTime? OrderDate { get; set; }

		public virtual string Priority { get; set; }

		public virtual DateTime? EntryDate { get; set; }

		public virtual DateTime? PickSheetPrintedDate { get; set; }

		public virtual string StatusId { get; set; }

		public virtual string CurrencyUomId { get; set; }

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

        protected OrderStateEventBase() : base()
        {
        }

        protected OrderStateEventBase(OrderEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class OrderStateCreated : OrderStateEventBase, IOrderStateCreated, ISaveable
	{
		public OrderStateCreated () : this(new OrderEventId())
		{
		}

		public OrderStateCreated (OrderEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<OrderRoleEventId, IOrderRoleStateCreated> _orderRoleEvents = new Dictionary<OrderRoleEventId, IOrderRoleStateCreated>();
        
        private IEnumerable<IOrderRoleStateCreated> _readOnlyOrderRoleEvents;

        public virtual IEnumerable<IOrderRoleStateCreated> OrderRoleEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderRoleEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderRoleEvents != null) { return _readOnlyOrderRoleEvents; }
                    var eventDao = OrderRoleEventDao;
                    var eL = new List<IOrderRoleStateCreated>();
                    foreach (var e in eventDao.FindByOrderEventId(this.OrderEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderRoleStateCreated)e);
                    }
                    return (_readOnlyOrderRoleEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderRoleEvent(e);
                    }
                }
                else { this._orderRoleEvents.Clear(); }
            }
        }
    
		public virtual void AddOrderRoleEvent(IOrderRoleStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderRoleEvents[e.OrderRoleEventId] = e;
		}

        public virtual IOrderRoleStateCreated NewOrderRoleStateCreated(PartyRoleId partyRoleId)
        {
            var stateEvent = new OrderRoleStateCreated(NewOrderRoleEventId(partyRoleId));
            return stateEvent;
        }

		private Dictionary<OrderItemEventId, IOrderItemStateCreated> _orderItemEvents = new Dictionary<OrderItemEventId, IOrderItemStateCreated>();
        
        private IEnumerable<IOrderItemStateCreated> _readOnlyOrderItemEvents;

        public virtual IEnumerable<IOrderItemStateCreated> OrderItemEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderItemEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderItemEvents != null) { return _readOnlyOrderItemEvents; }
                    var eventDao = OrderItemEventDao;
                    var eL = new List<IOrderItemStateCreated>();
                    foreach (var e in eventDao.FindByOrderEventId(this.OrderEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderItemStateCreated)e);
                    }
                    return (_readOnlyOrderItemEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderItemEvent(e);
                    }
                }
                else { this._orderItemEvents.Clear(); }
            }
        }
    
		public virtual void AddOrderItemEvent(IOrderItemStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderItemEvents[e.OrderItemEventId] = e;
		}

        public virtual IOrderItemStateCreated NewOrderItemStateCreated(string orderItemSeqId)
        {
            var stateEvent = new OrderItemStateCreated(NewOrderItemEventId(orderItemSeqId));
            return stateEvent;
        }

		private Dictionary<OrderShipGroupEventId, IOrderShipGroupStateCreated> _orderShipGroupEvents = new Dictionary<OrderShipGroupEventId, IOrderShipGroupStateCreated>();
        
        private IEnumerable<IOrderShipGroupStateCreated> _readOnlyOrderShipGroupEvents;

        public virtual IEnumerable<IOrderShipGroupStateCreated> OrderShipGroupEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderShipGroupEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderShipGroupEvents != null) { return _readOnlyOrderShipGroupEvents; }
                    var eventDao = OrderShipGroupEventDao;
                    var eL = new List<IOrderShipGroupStateCreated>();
                    foreach (var e in eventDao.FindByOrderEventId(this.OrderEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderShipGroupStateCreated)e);
                    }
                    return (_readOnlyOrderShipGroupEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderShipGroupEvent(e);
                    }
                }
                else { this._orderShipGroupEvents.Clear(); }
            }
        }
    
		public virtual void AddOrderShipGroupEvent(IOrderShipGroupStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderShipGroupEvents[e.OrderShipGroupEventId] = e;
		}

        public virtual IOrderShipGroupStateCreated NewOrderShipGroupStateCreated(long? shipGroupSeqId)
        {
            var stateEvent = new OrderShipGroupStateCreated(NewOrderShipGroupEventId(shipGroupSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IOrderRoleStateCreated e in this.OrderRoleEvents) {
				OrderRoleEventDao.Save(e);
			}
			foreach (IOrderItemStateCreated e in this.OrderItemEvents) {
				OrderItemEventDao.Save(e);
			}
			foreach (IOrderShipGroupStateCreated e in this.OrderShipGroupEvents) {
				OrderShipGroupEventDao.Save(e);
			}
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class OrderStateMergePatched : OrderStateEventBase, IOrderStateMergePatched, ISaveable
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

		public virtual bool IsPropertyCurrencyUomIdRemoved { get; set; }

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


		public OrderStateMergePatched ()
		{
		}

		public OrderStateMergePatched (OrderEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<OrderRoleEventId, IOrderRoleEvent> _orderRoleEvents = new Dictionary<OrderRoleEventId, IOrderRoleEvent>();

        private IEnumerable<IOrderRoleEvent> _readOnlyOrderRoleEvents;
        
        public virtual IEnumerable<IOrderRoleEvent> OrderRoleEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderRoleEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderRoleEvents != null) { return _readOnlyOrderRoleEvents; }
                    var eventDao = OrderRoleEventDao;
                    var eL = new List<IOrderRoleEvent>();
                    foreach (var e in eventDao.FindByOrderEventId(this.OrderEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderRoleEvent)e);
                    }
                    return (_readOnlyOrderRoleEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderRoleEvent(e);
                    }
                }
                else { this._orderRoleEvents.Clear(); }
            }
        }

		public virtual void AddOrderRoleEvent(IOrderRoleEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderRoleEvents[e.OrderRoleEventId] = e;
		}

        public virtual IOrderRoleStateCreated NewOrderRoleStateCreated(PartyRoleId partyRoleId)
        {
            var stateEvent = new OrderRoleStateCreated(NewOrderRoleEventId(partyRoleId));
            return stateEvent;
        }

        public virtual IOrderRoleStateMergePatched NewOrderRoleStateMergePatched(PartyRoleId partyRoleId)
        {
            var stateEvent = new OrderRoleStateMergePatched(NewOrderRoleEventId(partyRoleId));
            return stateEvent;
        }

        public virtual IOrderRoleStateRemoved NewOrderRoleStateRemoved(PartyRoleId partyRoleId)
        {
            var stateEvent = new OrderRoleStateRemoved(NewOrderRoleEventId(partyRoleId));
            return stateEvent;
        }

		private Dictionary<OrderItemEventId, IOrderItemEvent> _orderItemEvents = new Dictionary<OrderItemEventId, IOrderItemEvent>();

        private IEnumerable<IOrderItemEvent> _readOnlyOrderItemEvents;
        
        public virtual IEnumerable<IOrderItemEvent> OrderItemEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderItemEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderItemEvents != null) { return _readOnlyOrderItemEvents; }
                    var eventDao = OrderItemEventDao;
                    var eL = new List<IOrderItemEvent>();
                    foreach (var e in eventDao.FindByOrderEventId(this.OrderEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderItemEvent)e);
                    }
                    return (_readOnlyOrderItemEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderItemEvent(e);
                    }
                }
                else { this._orderItemEvents.Clear(); }
            }
        }

		public virtual void AddOrderItemEvent(IOrderItemEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderItemEvents[e.OrderItemEventId] = e;
		}

        public virtual IOrderItemStateCreated NewOrderItemStateCreated(string orderItemSeqId)
        {
            var stateEvent = new OrderItemStateCreated(NewOrderItemEventId(orderItemSeqId));
            return stateEvent;
        }

        public virtual IOrderItemStateMergePatched NewOrderItemStateMergePatched(string orderItemSeqId)
        {
            var stateEvent = new OrderItemStateMergePatched(NewOrderItemEventId(orderItemSeqId));
            return stateEvent;
        }

		private Dictionary<OrderShipGroupEventId, IOrderShipGroupEvent> _orderShipGroupEvents = new Dictionary<OrderShipGroupEventId, IOrderShipGroupEvent>();

        private IEnumerable<IOrderShipGroupEvent> _readOnlyOrderShipGroupEvents;
        
        public virtual IEnumerable<IOrderShipGroupEvent> OrderShipGroupEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._orderShipGroupEvents.Values;
                }
                else
                {
                    if (_readOnlyOrderShipGroupEvents != null) { return _readOnlyOrderShipGroupEvents; }
                    var eventDao = OrderShipGroupEventDao;
                    var eL = new List<IOrderShipGroupEvent>();
                    foreach (var e in eventDao.FindByOrderEventId(this.OrderEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IOrderShipGroupEvent)e);
                    }
                    return (_readOnlyOrderShipGroupEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddOrderShipGroupEvent(e);
                    }
                }
                else { this._orderShipGroupEvents.Clear(); }
            }
        }

		public virtual void AddOrderShipGroupEvent(IOrderShipGroupEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._orderShipGroupEvents[e.OrderShipGroupEventId] = e;
		}

        public virtual IOrderShipGroupStateCreated NewOrderShipGroupStateCreated(long? shipGroupSeqId)
        {
            var stateEvent = new OrderShipGroupStateCreated(NewOrderShipGroupEventId(shipGroupSeqId));
            return stateEvent;
        }

        public virtual IOrderShipGroupStateMergePatched NewOrderShipGroupStateMergePatched(long? shipGroupSeqId)
        {
            var stateEvent = new OrderShipGroupStateMergePatched(NewOrderShipGroupEventId(shipGroupSeqId));
            return stateEvent;
        }

        public virtual IOrderShipGroupStateRemoved NewOrderShipGroupStateRemoved(long? shipGroupSeqId)
        {
            var stateEvent = new OrderShipGroupStateRemoved(NewOrderShipGroupEventId(shipGroupSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IOrderRoleEvent e in this.OrderRoleEvents) {
				OrderRoleEventDao.Save(e);
			}
			foreach (IOrderItemEvent e in this.OrderItemEvents) {
				OrderItemEventDao.Save(e);
			}
			foreach (IOrderShipGroupEvent e in this.OrderShipGroupEvents) {
				OrderShipGroupEventDao.Save(e);
			}
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

