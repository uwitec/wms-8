﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{

	public partial class PhysicalInventoryLineStateDtoWrapper : StateDtoWrapperBase, IPhysicalInventoryLineStateDto, IPhysicalInventoryLineState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IPhysicalInventoryLineState _state;

        public PhysicalInventoryLineStateDtoWrapper()
        {
            this._state = new PhysicalInventoryLineState();
        }

		public PhysicalInventoryLineStateDtoWrapper(IPhysicalInventoryLineState state)
		{
            this._state = state;
		}

		public IPhysicalInventoryLineState ToPhysicalInventoryLineState()
		{
			return this._state;
		}

		public virtual InventoryItemId InventoryItemId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InventoryItemId"))
                {
                    return _state.InventoryItemId;
                }
                return null;
            }
            set
            {
                _state.InventoryItemId = value;
            }
        }

        InventoryItemId IPhysicalInventoryLineStateProperties.InventoryItemId
        {
            get 
            {
                return (this._state as IPhysicalInventoryLineStateProperties).InventoryItemId;
            }
            set 
            {
                (this._state as IPhysicalInventoryLineStateProperties).InventoryItemId = value;
            }
        }

		public virtual decimal? BookQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("BookQuantity"))
                {
                    return _state.BookQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.BookQuantity = value.Value;
                }
            }
        }

        decimal IPhysicalInventoryLineStateProperties.BookQuantity
        {
            get 
            {
                return (this._state as IPhysicalInventoryLineStateProperties).BookQuantity;
            }
            set 
            {
                (this._state as IPhysicalInventoryLineStateProperties).BookQuantity = value;
            }
        }

		public virtual decimal? CountedQuantity
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CountedQuantity"))
                {
                    return _state.CountedQuantity;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.CountedQuantity = value.Value;
                }
            }
        }

        decimal IPhysicalInventoryLineStateProperties.CountedQuantity
        {
            get 
            {
                return (this._state as IPhysicalInventoryLineStateProperties).CountedQuantity;
            }
            set 
            {
                (this._state as IPhysicalInventoryLineStateProperties).CountedQuantity = value;
            }
        }

		public virtual bool? Processed
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Processed"))
                {
                    return _state.Processed;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Processed = value.Value;
                }
            }
        }

        bool IPhysicalInventoryLineStateProperties.Processed
        {
            get 
            {
                return (this._state as IPhysicalInventoryLineStateProperties).Processed;
            }
            set 
            {
                (this._state as IPhysicalInventoryLineStateProperties).Processed = value;
            }
        }

		public virtual long? ReversalLineNumber
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ReversalLineNumber"))
                {
                    return _state.ReversalLineNumber;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.ReversalLineNumber = value.Value;
                }
            }
        }

        long IPhysicalInventoryLineStateProperties.ReversalLineNumber
        {
            get 
            {
                return (this._state as IPhysicalInventoryLineStateProperties).ReversalLineNumber;
            }
            set 
            {
                (this._state as IPhysicalInventoryLineStateProperties).ReversalLineNumber = value;
            }
        }

		public virtual string Description
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Description"))
                {
                    return _state.Description;
                }
                return null;
            }
            set
            {
                _state.Description = value;
            }
        }

        string IPhysicalInventoryLineStateProperties.Description
        {
            get 
            {
                return (this._state as IPhysicalInventoryLineStateProperties).Description;
            }
            set 
            {
                (this._state as IPhysicalInventoryLineStateProperties).Description = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IPhysicalInventoryLineStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IPhysicalInventoryLineStateProperties).Version = value.Value;
                }
            }
        }

        long IPhysicalInventoryLineStateProperties.Version
        {
            get 
            {
                return (this._state as IPhysicalInventoryLineStateProperties).Version;
            }
            set 
            {
                (this._state as IPhysicalInventoryLineStateProperties).Version = value;
            }
        }

		public virtual string PhysicalInventoryDocumentNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PhysicalInventoryDocumentNumber"))
                {
                    return _state.PhysicalInventoryDocumentNumber;
                }
                return null;
            }
            set
            {
                _state.PhysicalInventoryDocumentNumber = value;
            }
        }

        string IPhysicalInventoryLineStateProperties.PhysicalInventoryDocumentNumber
        {
            get 
            {
                return (this._state as IPhysicalInventoryLineStateProperties).PhysicalInventoryDocumentNumber;
            }
            set 
            {
                (this._state as IPhysicalInventoryLineStateProperties).PhysicalInventoryDocumentNumber = value;
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


		PhysicalInventoryLineId IGlobalIdentity<PhysicalInventoryLineId>.GlobalId {
			get { return (_state as IPhysicalInventoryLineState).GlobalId; }
		}

        InventoryItemId ILocalIdentity<InventoryItemId>.LocalId
        {
			get { return (_state as IPhysicalInventoryLineState).LocalId; }
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
            get { return (_state as IPhysicalInventoryLineState).CreatedBy; }
            set { (_state as IPhysicalInventoryLineState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IPhysicalInventoryLineState).CreatedAt; }
            set { (_state as IPhysicalInventoryLineState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IPhysicalInventoryLineState).UpdatedBy; }
            set { (_state as IPhysicalInventoryLineState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IPhysicalInventoryLineState).UpdatedAt; }
            set { (_state as IPhysicalInventoryLineState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IPhysicalInventoryLineStateProperties).Version; }
		}

		#endregion

        bool IPhysicalInventoryLineState.IsUnsaved
        {
            get { return this.Version == PhysicalInventoryLineState.VersionZero; }
        }

		void IPhysicalInventoryLineState.When(IPhysicalInventoryLineStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IPhysicalInventoryLineState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IPhysicalInventoryLineState.When(IPhysicalInventoryLineStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IPhysicalInventoryLineState.When(IPhysicalInventoryLineStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IPhysicalInventoryLineState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class PhysicalInventoryLineStateDtoWrapperCollection : StateDtoWrapperCollectionBase<PhysicalInventoryLineStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(PhysicalInventoryLineStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

