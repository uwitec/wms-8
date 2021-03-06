﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackage;

namespace Dddml.Wms.Domain.ShipmentPackage
{

	public partial class ShipmentPackageContentStateDtoWrapper : StateDtoWrapperBase, IShipmentPackageContentStateDto, IShipmentPackageContentState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IShipmentPackageContentState _state;

        public ShipmentPackageContentStateDtoWrapper()
        {
            this._state = new ShipmentPackageContentState();
        }

		public ShipmentPackageContentStateDtoWrapper(IShipmentPackageContentState state)
		{
            this._state = state;
		}

		public IShipmentPackageContentState ToShipmentPackageContentState()
		{
			return this._state;
		}

		public virtual string ShipmentItemSeqId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipmentItemSeqId"))
                {
                    return _state.ShipmentItemSeqId;
                }
                return null;
            }
            set
            {
                _state.ShipmentItemSeqId = value;
            }
        }

        string IShipmentPackageContentStateProperties.ShipmentItemSeqId
        {
            get 
            {
                return (this._state as IShipmentPackageContentStateProperties).ShipmentItemSeqId;
            }
            set 
            {
                (this._state as IShipmentPackageContentStateProperties).ShipmentItemSeqId = value;
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

        decimal? IShipmentPackageContentStateProperties.Quantity
        {
            get 
            {
                return (this._state as IShipmentPackageContentStateProperties).Quantity;
            }
            set 
            {
                (this._state as IShipmentPackageContentStateProperties).Quantity = value;
            }
        }

		public virtual string SubProductId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SubProductId"))
                {
                    return _state.SubProductId;
                }
                return null;
            }
            set
            {
                _state.SubProductId = value;
            }
        }

        string IShipmentPackageContentStateProperties.SubProductId
        {
            get 
            {
                return (this._state as IShipmentPackageContentStateProperties).SubProductId;
            }
            set 
            {
                (this._state as IShipmentPackageContentStateProperties).SubProductId = value;
            }
        }

		public virtual decimal? SubProductQuantity
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SubProductQuantity"))
                {
                    return _state.SubProductQuantity;
                }
                return null;
            }
            set
            {
                _state.SubProductQuantity = value;
            }
        }

        decimal? IShipmentPackageContentStateProperties.SubProductQuantity
        {
            get 
            {
                return (this._state as IShipmentPackageContentStateProperties).SubProductQuantity;
            }
            set 
            {
                (this._state as IShipmentPackageContentStateProperties).SubProductQuantity = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IShipmentPackageContentStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IShipmentPackageContentStateProperties).Active = value.Value;
                }
            }
        }

        bool IShipmentPackageContentStateProperties.Active
        {
            get 
            {
                return (this._state as IShipmentPackageContentStateProperties).Active;
            }
            set 
            {
                (this._state as IShipmentPackageContentStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IShipmentPackageContentStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IShipmentPackageContentStateProperties).Version = value.Value;
                }
            }
        }

        long IShipmentPackageContentStateProperties.Version
        {
            get 
            {
                return (this._state as IShipmentPackageContentStateProperties).Version;
            }
            set 
            {
                (this._state as IShipmentPackageContentStateProperties).Version = value;
            }
        }

		public virtual ShipmentPackageId ShipmentPackageId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShipmentPackageId"))
                {
                    return _state.ShipmentPackageId;
                }
                return null;
            }
            set
            {
                _state.ShipmentPackageId = value;
            }
        }

        ShipmentPackageId IShipmentPackageContentStateProperties.ShipmentPackageId
        {
            get 
            {
                return (this._state as IShipmentPackageContentStateProperties).ShipmentPackageId;
            }
            set 
            {
                (this._state as IShipmentPackageContentStateProperties).ShipmentPackageId = value;
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


		ShipmentPackageContentId IGlobalIdentity<ShipmentPackageContentId>.GlobalId {
			get { return (_state as IShipmentPackageContentState).GlobalId; }
		}

        string ILocalIdentity<string>.LocalId
        {
			get { return (_state as IShipmentPackageContentState).LocalId; }
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
            get { return (_state as IShipmentPackageContentState).CreatedBy; }
            set { (_state as IShipmentPackageContentState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IShipmentPackageContentState).CreatedAt; }
            set { (_state as IShipmentPackageContentState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IShipmentPackageContentState).UpdatedBy; }
            set { (_state as IShipmentPackageContentState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IShipmentPackageContentState).UpdatedAt; }
            set { (_state as IShipmentPackageContentState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IShipmentPackageContentStateProperties).Version; }
		}

		#endregion

        bool IShipmentPackageContentState.IsUnsaved
        {
            get { return this.Version == ShipmentPackageContentState.VersionZero; }
        }

		void IShipmentPackageContentState.When(IShipmentPackageContentStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IShipmentPackageContentState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IShipmentPackageContentState.When(IShipmentPackageContentStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IShipmentPackageContentState.When(IShipmentPackageContentStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IShipmentPackageContentState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class ShipmentPackageContentStateDtoWrapperCollection : StateDtoWrapperCollectionBase<ShipmentPackageContentStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(ShipmentPackageContentStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

