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

	public partial class OrderStateDtoWrapper : StateDtoWrapperBase, IOrderStateDto, IOrderState
	{

        internal static IList<string> _collectionFieldNames = new string[] { "OrderRoles", "OrderItems", "OrderShipGroups" };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IOrderState _state;

        public OrderStateDtoWrapper()
        {
            this._state = new OrderState();
        }

		public OrderStateDtoWrapper(IOrderState state)
		{
            this._state = state;
		}

		public IOrderState ToOrderState()
		{
			return this._state;
		}

		public virtual string OrderId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderId"))
                {
                    return _state.OrderId;
                }
                return null;
            }
            set
            {
                _state.OrderId = value;
            }
        }

        string IOrderStateProperties.OrderId
        {
            get 
            {
                return (this._state as IOrderStateProperties).OrderId;
            }
            set 
            {
                (this._state as IOrderStateProperties).OrderId = value;
            }
        }

		public virtual string OrderTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderTypeId"))
                {
                    return _state.OrderTypeId;
                }
                return null;
            }
            set
            {
                _state.OrderTypeId = value;
            }
        }

        string IOrderStateProperties.OrderTypeId
        {
            get 
            {
                return (this._state as IOrderStateProperties).OrderTypeId;
            }
            set 
            {
                (this._state as IOrderStateProperties).OrderTypeId = value;
            }
        }

		public virtual string OrderName
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderName"))
                {
                    return _state.OrderName;
                }
                return null;
            }
            set
            {
                _state.OrderName = value;
            }
        }

        string IOrderStateProperties.OrderName
        {
            get 
            {
                return (this._state as IOrderStateProperties).OrderName;
            }
            set 
            {
                (this._state as IOrderStateProperties).OrderName = value;
            }
        }

		public virtual string ExternalId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ExternalId"))
                {
                    return _state.ExternalId;
                }
                return null;
            }
            set
            {
                _state.ExternalId = value;
            }
        }

        string IOrderStateProperties.ExternalId
        {
            get 
            {
                return (this._state as IOrderStateProperties).ExternalId;
            }
            set 
            {
                (this._state as IOrderStateProperties).ExternalId = value;
            }
        }

		public virtual string SalesChannelEnumId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SalesChannelEnumId"))
                {
                    return _state.SalesChannelEnumId;
                }
                return null;
            }
            set
            {
                _state.SalesChannelEnumId = value;
            }
        }

        string IOrderStateProperties.SalesChannelEnumId
        {
            get 
            {
                return (this._state as IOrderStateProperties).SalesChannelEnumId;
            }
            set 
            {
                (this._state as IOrderStateProperties).SalesChannelEnumId = value;
            }
        }

		public virtual DateTime? OrderDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderDate"))
                {
                    return _state.OrderDate;
                }
                return null;
            }
            set
            {
                _state.OrderDate = value;
            }
        }

        DateTime? IOrderStateProperties.OrderDate
        {
            get 
            {
                return (this._state as IOrderStateProperties).OrderDate;
            }
            set 
            {
                (this._state as IOrderStateProperties).OrderDate = value;
            }
        }

		public virtual string Priority
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Priority"))
                {
                    return _state.Priority;
                }
                return null;
            }
            set
            {
                _state.Priority = value;
            }
        }

        string IOrderStateProperties.Priority
        {
            get 
            {
                return (this._state as IOrderStateProperties).Priority;
            }
            set 
            {
                (this._state as IOrderStateProperties).Priority = value;
            }
        }

		public virtual DateTime? EntryDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("EntryDate"))
                {
                    return _state.EntryDate;
                }
                return null;
            }
            set
            {
                _state.EntryDate = value;
            }
        }

        DateTime? IOrderStateProperties.EntryDate
        {
            get 
            {
                return (this._state as IOrderStateProperties).EntryDate;
            }
            set 
            {
                (this._state as IOrderStateProperties).EntryDate = value;
            }
        }

		public virtual DateTime? PickSheetPrintedDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PickSheetPrintedDate"))
                {
                    return _state.PickSheetPrintedDate;
                }
                return null;
            }
            set
            {
                _state.PickSheetPrintedDate = value;
            }
        }

        DateTime? IOrderStateProperties.PickSheetPrintedDate
        {
            get 
            {
                return (this._state as IOrderStateProperties).PickSheetPrintedDate;
            }
            set 
            {
                (this._state as IOrderStateProperties).PickSheetPrintedDate = value;
            }
        }

		public virtual string StatusId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("StatusId"))
                {
                    return _state.StatusId;
                }
                return null;
            }
            set
            {
                _state.StatusId = value;
            }
        }

        string IOrderStateProperties.StatusId
        {
            get 
            {
                return (this._state as IOrderStateProperties).StatusId;
            }
            set 
            {
                (this._state as IOrderStateProperties).StatusId = value;
            }
        }

		public virtual string CurrencyUom
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CurrencyUom"))
                {
                    return _state.CurrencyUom;
                }
                return null;
            }
            set
            {
                _state.CurrencyUom = value;
            }
        }

        string IOrderStateProperties.CurrencyUom
        {
            get 
            {
                return (this._state as IOrderStateProperties).CurrencyUom;
            }
            set 
            {
                (this._state as IOrderStateProperties).CurrencyUom = value;
            }
        }

		public virtual string SyncStatusId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SyncStatusId"))
                {
                    return _state.SyncStatusId;
                }
                return null;
            }
            set
            {
                _state.SyncStatusId = value;
            }
        }

        string IOrderStateProperties.SyncStatusId
        {
            get 
            {
                return (this._state as IOrderStateProperties).SyncStatusId;
            }
            set 
            {
                (this._state as IOrderStateProperties).SyncStatusId = value;
            }
        }

		public virtual string BillingAccountId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("BillingAccountId"))
                {
                    return _state.BillingAccountId;
                }
                return null;
            }
            set
            {
                _state.BillingAccountId = value;
            }
        }

        string IOrderStateProperties.BillingAccountId
        {
            get 
            {
                return (this._state as IOrderStateProperties).BillingAccountId;
            }
            set 
            {
                (this._state as IOrderStateProperties).BillingAccountId = value;
            }
        }

		public virtual string OriginFacilityId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OriginFacilityId"))
                {
                    return _state.OriginFacilityId;
                }
                return null;
            }
            set
            {
                _state.OriginFacilityId = value;
            }
        }

        string IOrderStateProperties.OriginFacilityId
        {
            get 
            {
                return (this._state as IOrderStateProperties).OriginFacilityId;
            }
            set 
            {
                (this._state as IOrderStateProperties).OriginFacilityId = value;
            }
        }

		public virtual string WebSiteId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("WebSiteId"))
                {
                    return _state.WebSiteId;
                }
                return null;
            }
            set
            {
                _state.WebSiteId = value;
            }
        }

        string IOrderStateProperties.WebSiteId
        {
            get 
            {
                return (this._state as IOrderStateProperties).WebSiteId;
            }
            set 
            {
                (this._state as IOrderStateProperties).WebSiteId = value;
            }
        }

		public virtual string ProductStoreId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ProductStoreId"))
                {
                    return _state.ProductStoreId;
                }
                return null;
            }
            set
            {
                _state.ProductStoreId = value;
            }
        }

        string IOrderStateProperties.ProductStoreId
        {
            get 
            {
                return (this._state as IOrderStateProperties).ProductStoreId;
            }
            set 
            {
                (this._state as IOrderStateProperties).ProductStoreId = value;
            }
        }

		public virtual string TerminalId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TerminalId"))
                {
                    return _state.TerminalId;
                }
                return null;
            }
            set
            {
                _state.TerminalId = value;
            }
        }

        string IOrderStateProperties.TerminalId
        {
            get 
            {
                return (this._state as IOrderStateProperties).TerminalId;
            }
            set 
            {
                (this._state as IOrderStateProperties).TerminalId = value;
            }
        }

		public virtual string TransactionId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TransactionId"))
                {
                    return _state.TransactionId;
                }
                return null;
            }
            set
            {
                _state.TransactionId = value;
            }
        }

        string IOrderStateProperties.TransactionId
        {
            get 
            {
                return (this._state as IOrderStateProperties).TransactionId;
            }
            set 
            {
                (this._state as IOrderStateProperties).TransactionId = value;
            }
        }

		public virtual string AutoOrderShoppingListId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AutoOrderShoppingListId"))
                {
                    return _state.AutoOrderShoppingListId;
                }
                return null;
            }
            set
            {
                _state.AutoOrderShoppingListId = value;
            }
        }

        string IOrderStateProperties.AutoOrderShoppingListId
        {
            get 
            {
                return (this._state as IOrderStateProperties).AutoOrderShoppingListId;
            }
            set 
            {
                (this._state as IOrderStateProperties).AutoOrderShoppingListId = value;
            }
        }

		public virtual string NeedsInventoryIssuance
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("NeedsInventoryIssuance"))
                {
                    return _state.NeedsInventoryIssuance;
                }
                return null;
            }
            set
            {
                _state.NeedsInventoryIssuance = value;
            }
        }

        string IOrderStateProperties.NeedsInventoryIssuance
        {
            get 
            {
                return (this._state as IOrderStateProperties).NeedsInventoryIssuance;
            }
            set 
            {
                (this._state as IOrderStateProperties).NeedsInventoryIssuance = value;
            }
        }

		public virtual string IsRushOrder
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsRushOrder"))
                {
                    return _state.IsRushOrder;
                }
                return null;
            }
            set
            {
                _state.IsRushOrder = value;
            }
        }

        string IOrderStateProperties.IsRushOrder
        {
            get 
            {
                return (this._state as IOrderStateProperties).IsRushOrder;
            }
            set 
            {
                (this._state as IOrderStateProperties).IsRushOrder = value;
            }
        }

		public virtual string InternalCode
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InternalCode"))
                {
                    return _state.InternalCode;
                }
                return null;
            }
            set
            {
                _state.InternalCode = value;
            }
        }

        string IOrderStateProperties.InternalCode
        {
            get 
            {
                return (this._state as IOrderStateProperties).InternalCode;
            }
            set 
            {
                (this._state as IOrderStateProperties).InternalCode = value;
            }
        }

		public virtual decimal? RemainingSubTotal
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("RemainingSubTotal"))
                {
                    return _state.RemainingSubTotal;
                }
                return null;
            }
            set
            {
                _state.RemainingSubTotal = value;
            }
        }

        decimal? IOrderStateProperties.RemainingSubTotal
        {
            get 
            {
                return (this._state as IOrderStateProperties).RemainingSubTotal;
            }
            set 
            {
                (this._state as IOrderStateProperties).RemainingSubTotal = value;
            }
        }

		public virtual decimal? GrandTotal
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("GrandTotal"))
                {
                    return _state.GrandTotal;
                }
                return null;
            }
            set
            {
                _state.GrandTotal = value;
            }
        }

        decimal? IOrderStateProperties.GrandTotal
        {
            get 
            {
                return (this._state as IOrderStateProperties).GrandTotal;
            }
            set 
            {
                (this._state as IOrderStateProperties).GrandTotal = value;
            }
        }

		public virtual string InvoicePerShipment
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InvoicePerShipment"))
                {
                    return _state.InvoicePerShipment;
                }
                return null;
            }
            set
            {
                _state.InvoicePerShipment = value;
            }
        }

        string IOrderStateProperties.InvoicePerShipment
        {
            get 
            {
                return (this._state as IOrderStateProperties).InvoicePerShipment;
            }
            set 
            {
                (this._state as IOrderStateProperties).InvoicePerShipment = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IOrderStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrderStateProperties).Active = value.Value;
                }
            }
        }

        bool IOrderStateProperties.Active
        {
            get 
            {
                return (this._state as IOrderStateProperties).Active;
            }
            set 
            {
                (this._state as IOrderStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IOrderStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrderStateProperties).Version = value.Value;
                }
            }
        }

        long IOrderStateProperties.Version
        {
            get 
            {
                return (this._state as IOrderStateProperties).Version;
            }
            set 
            {
                (this._state as IOrderStateProperties).Version = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedBy"))
                {
                    return _state.CreatedBy;
                }
                return null;
            }
            set
            {
                _state.CreatedBy = value;
            }
        }

		public virtual DateTime? CreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedAt"))
                {
                    return _state.CreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.CreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.CreatedAt = value.Value;
                }
            }
        }

		public virtual string UpdatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedBy"))
                {
                    return _state.UpdatedBy;
                }
                return null;
            }
            set
            {
                _state.UpdatedBy = value;
            }
        }

		public virtual DateTime? UpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedAt"))
                {
                    return _state.UpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.UpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UpdatedAt = value.Value;
                }
            }
        }

		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get { return (_state as IOrderState).GlobalId; }
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
            return (_state as IActive).IsActive();
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IOrderState).CreatedBy; }
            set { (_state as IOrderState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IOrderState).CreatedAt; }
            set { (_state as IOrderState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IOrderState).UpdatedBy; }
            set { (_state as IOrderState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IOrderState).UpdatedAt; }
            set { (_state as IOrderState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IOrderStateProperties).Version; }
		}

		#endregion

        bool IOrderState.IsUnsaved
        {
            get { return this.Version == OrderState.VersionZero; }
        }

        public virtual IOrderRoleStateDto[] OrderRoles
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("OrderRoles"))
                {
                    return null;
                }
                var dtos = new List<IOrderRoleStateDto>();
                if (this._state.OrderRoles != null)
                {
                    foreach (var s in this._state.OrderRoles)
                    {
                        var dto = new OrderRoleStateDtoWrapper((OrderRoleState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "OrderRoles");
                        if (!String.IsNullOrWhiteSpace(returnFS))
                        {
                            (dto as IStateDtoWrapper).ReturnedFieldsString = returnFS;
                        }
                        else
                        {
                            (dto as IStateDtoWrapper).AllFieldsReturned = this.AllFieldsReturned;
                        }
                        dtos.Add(dto);
                    }
                }
                return dtos.ToArray();
            }
            set 
            {
                if (value == null) { value = new OrderRoleStateDtoWrapper[0]; }
                var states = new List<IOrderRoleState>();
                foreach (var s in value)
                {
                    states.Add(s.ToOrderRoleState());
                }
                this._state.OrderRoles = new DtoOrderRoleStates(this._state, states);
            }
        }

        IOrderRoleStates IOrderState.OrderRoles
        {
            get { return _state.OrderRoles; }
            set { _state.OrderRoles = value; }
        }

        public virtual IOrderItemStateDto[] OrderItems
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("OrderItems"))
                {
                    return null;
                }
                var dtos = new List<IOrderItemStateDto>();
                if (this._state.OrderItems != null)
                {
                    foreach (var s in this._state.OrderItems)
                    {
                        var dto = new OrderItemStateDtoWrapper((OrderItemState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "OrderItems");
                        if (!String.IsNullOrWhiteSpace(returnFS))
                        {
                            (dto as IStateDtoWrapper).ReturnedFieldsString = returnFS;
                        }
                        else
                        {
                            (dto as IStateDtoWrapper).AllFieldsReturned = this.AllFieldsReturned;
                        }
                        dtos.Add(dto);
                    }
                }
                return dtos.ToArray();
            }
            set 
            {
                if (value == null) { value = new OrderItemStateDtoWrapper[0]; }
                var states = new List<IOrderItemState>();
                foreach (var s in value)
                {
                    states.Add(s.ToOrderItemState());
                }
                this._state.OrderItems = new DtoOrderItemStates(this._state, states);
            }
        }

        IOrderItemStates IOrderState.OrderItems
        {
            get { return _state.OrderItems; }
            set { _state.OrderItems = value; }
        }

        public virtual IOrderShipGroupStateDto[] OrderShipGroups
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("OrderShipGroups"))
                {
                    return null;
                }
                var dtos = new List<IOrderShipGroupStateDto>();
                if (this._state.OrderShipGroups != null)
                {
                    foreach (var s in this._state.OrderShipGroups)
                    {
                        var dto = new OrderShipGroupStateDtoWrapper((OrderShipGroupState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "OrderShipGroups");
                        if (!String.IsNullOrWhiteSpace(returnFS))
                        {
                            (dto as IStateDtoWrapper).ReturnedFieldsString = returnFS;
                        }
                        else
                        {
                            (dto as IStateDtoWrapper).AllFieldsReturned = this.AllFieldsReturned;
                        }
                        dtos.Add(dto);
                    }
                }
                return dtos.ToArray();
            }
            set 
            {
                if (value == null) { value = new OrderShipGroupStateDtoWrapper[0]; }
                var states = new List<IOrderShipGroupState>();
                foreach (var s in value)
                {
                    states.Add(s.ToOrderShipGroupState());
                }
                this._state.OrderShipGroups = new DtoOrderShipGroupStates(this._state, states);
            }
        }

        IOrderShipGroupStates IOrderState.OrderShipGroups
        {
            get { return _state.OrderShipGroups; }
            set { _state.OrderShipGroups = value; }
        }

		void IOrderState.When(IOrderStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IOrderState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IOrderState.When(IOrderStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IOrderState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

        public class DtoOrderRoleStates : IOrderRoleStates
        {

            private IOrderState _outerState;

            private IEnumerable<IOrderRoleState> _innerStates;

            public DtoOrderRoleStates(IOrderState outerState, IEnumerable<IOrderRoleState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IOrderRoleState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IOrderRoleState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IOrderRoleState Get(PartyRoleId partyRoleId)
            {
                throw new NotSupportedException();
            }

            public IOrderRoleState Get(PartyRoleId partyRoleId, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public IOrderRoleState Get(PartyRoleId partyRoleId, bool forCreation, bool nullAllowed)
            {
                throw new NotSupportedException();
            }

            public void Remove(IOrderRoleState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IOrderRoleState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

        public class DtoOrderItemStates : IOrderItemStates
        {

            private IOrderState _outerState;

            private IEnumerable<IOrderItemState> _innerStates;

            public DtoOrderItemStates(IOrderState outerState, IEnumerable<IOrderItemState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IOrderItemState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IOrderItemState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IOrderItemState Get(string orderItemSeqId)
            {
                throw new NotSupportedException();
            }

            public IOrderItemState Get(string orderItemSeqId, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public IOrderItemState Get(string orderItemSeqId, bool forCreation, bool nullAllowed)
            {
                throw new NotSupportedException();
            }

            public void Remove(IOrderItemState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IOrderItemState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

        public class DtoOrderShipGroupStates : IOrderShipGroupStates
        {

            private IOrderState _outerState;

            private IEnumerable<IOrderShipGroupState> _innerStates;

            public DtoOrderShipGroupStates(IOrderState outerState, IEnumerable<IOrderShipGroupState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IOrderShipGroupState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IOrderShipGroupState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IOrderShipGroupState Get(long? shipGroupSeqId)
            {
                throw new NotSupportedException();
            }

            public IOrderShipGroupState Get(long? shipGroupSeqId, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public IOrderShipGroupState Get(long? shipGroupSeqId, bool forCreation, bool nullAllowed)
            {
                throw new NotSupportedException();
            }

            public void Remove(IOrderShipGroupState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IOrderShipGroupState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

	}

    partial class OrderStateDtoWrapperCollection : StateDtoWrapperCollectionBase<OrderStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(OrderStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

