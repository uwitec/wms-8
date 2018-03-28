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

	public partial class OrderItemShipGroupAssociationStateDtoWrapper : StateDtoWrapperBase, IOrderItemShipGroupAssociationStateDto, IOrderItemShipGroupAssociationState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IOrderItemShipGroupAssociationState _state;

        public OrderItemShipGroupAssociationStateDtoWrapper()
        {
            this._state = new OrderItemShipGroupAssociationState();
        }

		public OrderItemShipGroupAssociationStateDtoWrapper(IOrderItemShipGroupAssociationState state)
		{
            this._state = state;
		}

		public IOrderItemShipGroupAssociationState ToOrderItemShipGroupAssociationState()
		{
			return this._state;
		}

		public virtual string OrderItemSeqId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderItemSeqId"))
                {
                    return _state.OrderItemSeqId;
                }
                return null;
            }
            set
            {
                _state.OrderItemSeqId = value;
            }
        }

        string IOrderItemShipGroupAssociationStateProperties.OrderItemSeqId
        {
            get 
            {
                return (this._state as IOrderItemShipGroupAssociationStateProperties).OrderItemSeqId;
            }
            set 
            {
                (this._state as IOrderItemShipGroupAssociationStateProperties).OrderItemSeqId = value;
            }
        }

		public virtual decimal? Quantity
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Quantity"))
                {
                    return _state.Quantity;
                }
                return null;
            }
            set
            {
                _state.Quantity = value;
            }
        }

        decimal? IOrderItemShipGroupAssociationStateProperties.Quantity
        {
            get 
            {
                return (this._state as IOrderItemShipGroupAssociationStateProperties).Quantity;
            }
            set 
            {
                (this._state as IOrderItemShipGroupAssociationStateProperties).Quantity = value;
            }
        }

		public virtual decimal? CancelQuantity
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CancelQuantity"))
                {
                    return _state.CancelQuantity;
                }
                return null;
            }
            set
            {
                _state.CancelQuantity = value;
            }
        }

        decimal? IOrderItemShipGroupAssociationStateProperties.CancelQuantity
        {
            get 
            {
                return (this._state as IOrderItemShipGroupAssociationStateProperties).CancelQuantity;
            }
            set 
            {
                (this._state as IOrderItemShipGroupAssociationStateProperties).CancelQuantity = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IOrderItemShipGroupAssociationStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrderItemShipGroupAssociationStateProperties).Active = value.Value;
                }
            }
        }

        bool IOrderItemShipGroupAssociationStateProperties.Active
        {
            get 
            {
                return (this._state as IOrderItemShipGroupAssociationStateProperties).Active;
            }
            set 
            {
                (this._state as IOrderItemShipGroupAssociationStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IOrderItemShipGroupAssociationStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IOrderItemShipGroupAssociationStateProperties).Version = value.Value;
                }
            }
        }

        long IOrderItemShipGroupAssociationStateProperties.Version
        {
            get 
            {
                return (this._state as IOrderItemShipGroupAssociationStateProperties).Version;
            }
            set 
            {
                (this._state as IOrderItemShipGroupAssociationStateProperties).Version = value;
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

        string IOrderItemShipGroupAssociationStateProperties.OrderId
        {
            get 
            {
                return (this._state as IOrderItemShipGroupAssociationStateProperties).OrderId;
            }
            set 
            {
                (this._state as IOrderItemShipGroupAssociationStateProperties).OrderId = value;
            }
        }

		public virtual long? OrderShipGroupShipGroupSeqId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("OrderShipGroupShipGroupSeqId"))
                {
                    return _state.OrderShipGroupShipGroupSeqId;
                }
                return null;
            }
            set
            {
                _state.OrderShipGroupShipGroupSeqId = value;
            }
        }

        long? IOrderItemShipGroupAssociationStateProperties.OrderShipGroupShipGroupSeqId
        {
            get 
            {
                return (this._state as IOrderItemShipGroupAssociationStateProperties).OrderShipGroupShipGroupSeqId;
            }
            set 
            {
                (this._state as IOrderItemShipGroupAssociationStateProperties).OrderShipGroupShipGroupSeqId = value;
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


		OrderItemShipGroupAssociationId IGlobalIdentity<OrderItemShipGroupAssociationId>.GlobalId {
			get { return (_state as IOrderItemShipGroupAssociationState).GlobalId; }
		}

        string ILocalIdentity<string>.LocalId
        {
			get { return (_state as IOrderItemShipGroupAssociationState).LocalId; }
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
            get { return (_state as IOrderItemShipGroupAssociationState).CreatedBy; }
            set { (_state as IOrderItemShipGroupAssociationState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IOrderItemShipGroupAssociationState).CreatedAt; }
            set { (_state as IOrderItemShipGroupAssociationState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IOrderItemShipGroupAssociationState).UpdatedBy; }
            set { (_state as IOrderItemShipGroupAssociationState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IOrderItemShipGroupAssociationState).UpdatedAt; }
            set { (_state as IOrderItemShipGroupAssociationState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IOrderItemShipGroupAssociationStateProperties).Version; }
		}

		#endregion

        bool IOrderItemShipGroupAssociationState.IsUnsaved
        {
            get { return this.Version == OrderItemShipGroupAssociationState.VersionZero; }
        }

		void IOrderItemShipGroupAssociationState.When(IOrderItemShipGroupAssociationStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IOrderItemShipGroupAssociationState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IOrderItemShipGroupAssociationState.When(IOrderItemShipGroupAssociationStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IOrderItemShipGroupAssociationState.When(IOrderItemShipGroupAssociationStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IOrderItemShipGroupAssociationState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class OrderItemShipGroupAssociationStateDtoWrapperCollection : StateDtoWrapperCollectionBase<OrderItemShipGroupAssociationStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(OrderItemShipGroupAssociationStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

