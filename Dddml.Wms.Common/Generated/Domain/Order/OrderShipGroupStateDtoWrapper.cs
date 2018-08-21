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

	public partial class OrderShipGroupStateDtoWrapper : StateDtoWrapperBase, IOrderShipGroupStateDto, IOrderShipGroupState
	{

        internal static IList<string> _collectionFieldNames = new string[] { "OrderItemShipGroupAssociations" };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IOrderShipGroupState _state;

        public OrderShipGroupStateDtoWrapper()
        {
            this._state = new OrderShipGroupState();
        }

		public OrderShipGroupStateDtoWrapper(IOrderShipGroupState state)
		{
            this._state = state;
		}

		public IOrderShipGroupState ToOrderShipGroupState()
		{
			return this._state;
		}

		public virtual long? ShipGroupSeqId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipGroupSeqId"))
                {
                    return _state.ShipGroupSeqId;
                }
                return null;
            }
            set
            {
                _state.ShipGroupSeqId = value;
            }
        }

        long? IOrderShipGroupStateProperties.ShipGroupSeqId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).ShipGroupSeqId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).ShipGroupSeqId = value;
            }
        }

		public virtual string ShipmentMethodTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipmentMethodTypeId"))
                {
                    return _state.ShipmentMethodTypeId;
                }
                return null;
            }
            set
            {
                _state.ShipmentMethodTypeId = value;
            }
        }

        string IOrderShipGroupStateProperties.ShipmentMethodTypeId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).ShipmentMethodTypeId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).ShipmentMethodTypeId = value;
            }
        }

		public virtual string SupplierPartyId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SupplierPartyId"))
                {
                    return _state.SupplierPartyId;
                }
                return null;
            }
            set
            {
                _state.SupplierPartyId = value;
            }
        }

        string IOrderShipGroupStateProperties.SupplierPartyId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).SupplierPartyId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).SupplierPartyId = value;
            }
        }

		public virtual string VendorPartyId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("VendorPartyId"))
                {
                    return _state.VendorPartyId;
                }
                return null;
            }
            set
            {
                _state.VendorPartyId = value;
            }
        }

        string IOrderShipGroupStateProperties.VendorPartyId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).VendorPartyId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).VendorPartyId = value;
            }
        }

		public virtual string CarrierPartyId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CarrierPartyId"))
                {
                    return _state.CarrierPartyId;
                }
                return null;
            }
            set
            {
                _state.CarrierPartyId = value;
            }
        }

        string IOrderShipGroupStateProperties.CarrierPartyId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).CarrierPartyId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).CarrierPartyId = value;
            }
        }

		public virtual string CarrierRoleTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CarrierRoleTypeId"))
                {
                    return _state.CarrierRoleTypeId;
                }
                return null;
            }
            set
            {
                _state.CarrierRoleTypeId = value;
            }
        }

        string IOrderShipGroupStateProperties.CarrierRoleTypeId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).CarrierRoleTypeId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).CarrierRoleTypeId = value;
            }
        }

		public virtual string FacilityId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("FacilityId"))
                {
                    return _state.FacilityId;
                }
                return null;
            }
            set
            {
                _state.FacilityId = value;
            }
        }

        string IOrderShipGroupStateProperties.FacilityId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).FacilityId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).FacilityId = value;
            }
        }

		public virtual string ContactMechId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ContactMechId"))
                {
                    return _state.ContactMechId;
                }
                return null;
            }
            set
            {
                _state.ContactMechId = value;
            }
        }

        string IOrderShipGroupStateProperties.ContactMechId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).ContactMechId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).ContactMechId = value;
            }
        }

		public virtual string TelecomContactMechId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TelecomContactMechId"))
                {
                    return _state.TelecomContactMechId;
                }
                return null;
            }
            set
            {
                _state.TelecomContactMechId = value;
            }
        }

        string IOrderShipGroupStateProperties.TelecomContactMechId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).TelecomContactMechId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).TelecomContactMechId = value;
            }
        }

		public virtual string TrackingNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("TrackingNumber"))
                {
                    return _state.TrackingNumber;
                }
                return null;
            }
            set
            {
                _state.TrackingNumber = value;
            }
        }

        string IOrderShipGroupStateProperties.TrackingNumber
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).TrackingNumber;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).TrackingNumber = value;
            }
        }

		public virtual string ContactPartyId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ContactPartyId"))
                {
                    return _state.ContactPartyId;
                }
                return null;
            }
            set
            {
                _state.ContactPartyId = value;
            }
        }

        string IOrderShipGroupStateProperties.ContactPartyId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).ContactPartyId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).ContactPartyId = value;
            }
        }

		public virtual string VehiclePlateNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("VehiclePlateNumber"))
                {
                    return _state.VehiclePlateNumber;
                }
                return null;
            }
            set
            {
                _state.VehiclePlateNumber = value;
            }
        }

        string IOrderShipGroupStateProperties.VehiclePlateNumber
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).VehiclePlateNumber;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).VehiclePlateNumber = value;
            }
        }

		public virtual string ShippingInstructions
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShippingInstructions"))
                {
                    return _state.ShippingInstructions;
                }
                return null;
            }
            set
            {
                _state.ShippingInstructions = value;
            }
        }

        string IOrderShipGroupStateProperties.ShippingInstructions
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).ShippingInstructions;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).ShippingInstructions = value;
            }
        }

		public virtual string MaySplit
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("MaySplit"))
                {
                    return _state.MaySplit;
                }
                return null;
            }
            set
            {
                _state.MaySplit = value;
            }
        }

        string IOrderShipGroupStateProperties.MaySplit
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).MaySplit;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).MaySplit = value;
            }
        }

		public virtual string GiftMessage
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("GiftMessage"))
                {
                    return _state.GiftMessage;
                }
                return null;
            }
            set
            {
                _state.GiftMessage = value;
            }
        }

        string IOrderShipGroupStateProperties.GiftMessage
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).GiftMessage;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).GiftMessage = value;
            }
        }

		public virtual string IsGift
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("IsGift"))
                {
                    return _state.IsGift;
                }
                return null;
            }
            set
            {
                _state.IsGift = value;
            }
        }

        string IOrderShipGroupStateProperties.IsGift
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).IsGift;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).IsGift = value;
            }
        }

		public virtual DateTime? ShipAfterDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipAfterDate"))
                {
                    return _state.ShipAfterDate;
                }
                return null;
            }
            set
            {
                _state.ShipAfterDate = value;
            }
        }

        DateTime? IOrderShipGroupStateProperties.ShipAfterDate
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).ShipAfterDate;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).ShipAfterDate = value;
            }
        }

		public virtual DateTime? ShipByDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipByDate"))
                {
                    return _state.ShipByDate;
                }
                return null;
            }
            set
            {
                _state.ShipByDate = value;
            }
        }

        DateTime? IOrderShipGroupStateProperties.ShipByDate
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).ShipByDate;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).ShipByDate = value;
            }
        }

		public virtual DateTime? EstimatedShipDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("EstimatedShipDate"))
                {
                    return _state.EstimatedShipDate;
                }
                return null;
            }
            set
            {
                _state.EstimatedShipDate = value;
            }
        }

        DateTime? IOrderShipGroupStateProperties.EstimatedShipDate
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).EstimatedShipDate;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).EstimatedShipDate = value;
            }
        }

		public virtual DateTime? EstimatedDeliveryDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("EstimatedDeliveryDate"))
                {
                    return _state.EstimatedDeliveryDate;
                }
                return null;
            }
            set
            {
                _state.EstimatedDeliveryDate = value;
            }
        }

        DateTime? IOrderShipGroupStateProperties.EstimatedDeliveryDate
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).EstimatedDeliveryDate;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).EstimatedDeliveryDate = value;
            }
        }

		public virtual long? PickwaveId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PickwaveId"))
                {
                    return _state.PickwaveId;
                }
                return null;
            }
            set
            {
                _state.PickwaveId = value;
            }
        }

        long? IOrderShipGroupStateProperties.PickwaveId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).PickwaveId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).PickwaveId = value;
            }
        }

		public virtual int? NumberOfPackages
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("NumberOfPackages"))
                {
                    return _state.NumberOfPackages;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.NumberOfPackages = value.Value;
                }
            }
        }

        int IOrderShipGroupStateProperties.NumberOfPackages
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).NumberOfPackages;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).NumberOfPackages = value;
            }
        }

		public virtual int? NumberOfContainers
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("NumberOfContainers"))
                {
                    return _state.NumberOfContainers;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.NumberOfContainers = value.Value;
                }
            }
        }

        int IOrderShipGroupStateProperties.NumberOfContainers
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).NumberOfContainers;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).NumberOfContainers = value;
            }
        }

		public virtual int? NumberOfPakagesPerContainer
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("NumberOfPakagesPerContainer"))
                {
                    return _state.NumberOfPakagesPerContainer;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.NumberOfPakagesPerContainer = value.Value;
                }
            }
        }

        int IOrderShipGroupStateProperties.NumberOfPakagesPerContainer
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).NumberOfPakagesPerContainer;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).NumberOfPakagesPerContainer = value;
            }
        }

		public virtual string OrderShipGroupStatusId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderShipGroupStatusId"))
                {
                    return _state.OrderShipGroupStatusId;
                }
                return null;
            }
            set
            {
                _state.OrderShipGroupStatusId = value;
            }
        }

        string IOrderShipGroupStateProperties.OrderShipGroupStatusId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).OrderShipGroupStatusId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).OrderShipGroupStatusId = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IOrderShipGroupStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrderShipGroupStateProperties).Active = value.Value;
                }
            }
        }

        bool IOrderShipGroupStateProperties.Active
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).Active;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IOrderShipGroupStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrderShipGroupStateProperties).Version = value.Value;
                }
            }
        }

        long IOrderShipGroupStateProperties.Version
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).Version;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).Version = value;
            }
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

        string IOrderShipGroupStateProperties.OrderId
        {
            get 
            {
                return (this._state as IOrderShipGroupStateProperties).OrderId;
            }
            set 
            {
                (this._state as IOrderShipGroupStateProperties).OrderId = value;
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


		OrderShipGroupId IGlobalIdentity<OrderShipGroupId>.GlobalId {
			get { return (_state as IOrderShipGroupState).GlobalId; }
		}

        long? ILocalIdentity<long?>.LocalId
        {
			get { return (_state as IOrderShipGroupState).LocalId; }
        }

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
            return (_state as IActive).IsActive();
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
            get { return (_state as IDeleted).Deleted; }
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IOrderShipGroupState).CreatedBy; }
            set { (_state as IOrderShipGroupState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IOrderShipGroupState).CreatedAt; }
            set { (_state as IOrderShipGroupState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IOrderShipGroupState).UpdatedBy; }
            set { (_state as IOrderShipGroupState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IOrderShipGroupState).UpdatedAt; }
            set { (_state as IOrderShipGroupState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IOrderShipGroupStateProperties).Version; }
		}

		#endregion

        bool IOrderShipGroupState.IsUnsaved
        {
            get { return this.Version == OrderShipGroupState.VersionZero; }
        }

        public virtual IOrderItemShipGroupAssociationStateDto[] OrderItemShipGroupAssociations
        {
            get 
            {
                if (!(this as IStateDtoWrapper).ReturnedFieldsContains("OrderItemShipGroupAssociations"))
                {
                    return null;
                }
                var dtos = new List<IOrderItemShipGroupAssociationStateDto>();
                if (this._state.OrderItemShipGroupAssociations != null)
                {
                    foreach (var s in this._state.OrderItemShipGroupAssociations)
                    {
                        var dto = new OrderItemShipGroupAssociationStateDtoWrapper((OrderItemShipGroupAssociationState)s);
                        var returnFS = CollectionUtils.DictionaryGetValueIgnoringCase(ReturnedFields, "OrderItemShipGroupAssociations");
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
                if (value == null) { value = new OrderItemShipGroupAssociationStateDtoWrapper[0]; }
                var states = new List<IOrderItemShipGroupAssociationState>();
                foreach (var s in value)
                {
                    states.Add(s.ToOrderItemShipGroupAssociationState());
                }
                this._state.OrderItemShipGroupAssociations = new DtoOrderItemShipGroupAssociationStates(this._state, states);
            }
        }

        IOrderItemShipGroupAssociationStates IOrderShipGroupState.OrderItemShipGroupAssociations
        {
            get { return _state.OrderItemShipGroupAssociations; }
            set { _state.OrderItemShipGroupAssociations = value; }
        }

		void IOrderShipGroupState.When(IOrderShipGroupStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IOrderShipGroupState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IOrderShipGroupState.When(IOrderShipGroupStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IOrderShipGroupState.When(IOrderShipGroupStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IOrderShipGroupState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

        public class DtoOrderItemShipGroupAssociationStates : IOrderItemShipGroupAssociationStates
        {

            private IOrderShipGroupState _outerState;

            private IEnumerable<IOrderItemShipGroupAssociationState> _innerStates;

            public DtoOrderItemShipGroupAssociationStates(IOrderShipGroupState outerState, IEnumerable<IOrderItemShipGroupAssociationState> innerStates)
            {
                this._outerState = outerState;
                if (innerStates == null)
                {
                    this._innerStates = new IOrderItemShipGroupAssociationState[] { };
                }
                else
                {
                    this._innerStates = innerStates;
                }
            }

            public IEnumerator<IOrderItemShipGroupAssociationState> GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
            {
                return _innerStates.GetEnumerator();
            }

            public IOrderItemShipGroupAssociationState Get(string orderItemSeqId)
            {
                throw new NotSupportedException();
            }

            public IOrderItemShipGroupAssociationState Get(string orderItemSeqId, bool forCreation)
            {
                throw new NotSupportedException();
            }

            public IOrderItemShipGroupAssociationState Get(string orderItemSeqId, bool forCreation, bool nullAllowed)
            {
                throw new NotSupportedException();
            }

            public void Remove(IOrderItemShipGroupAssociationState state)
            {
                throw new NotSupportedException();
            }

            public void AddToSave(IOrderItemShipGroupAssociationState state)
            {
                throw new NotSupportedException();
            }

            public void Save()
            {
                throw new NotSupportedException();
            }
        }

	}

    partial class OrderShipGroupStateDtoWrapperCollection : StateDtoWrapperCollectionBase<OrderShipGroupStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(OrderShipGroupStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

