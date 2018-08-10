﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public partial class InOutImageStateDtoWrapper : StateDtoWrapperBase, IInOutImageStateDto, IInOutImageState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IInOutImageState _state;

        public InOutImageStateDtoWrapper()
        {
            this._state = new InOutImageState();
        }

		public InOutImageStateDtoWrapper(IInOutImageState state)
		{
            this._state = state;
		}

		public IInOutImageState ToInOutImageState()
		{
			return this._state;
		}

		public virtual string SequenceId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SequenceId"))
                {
                    return _state.SequenceId;
                }
                return null;
            }
            set
            {
                _state.SequenceId = value;
            }
        }

        string IInOutImageStateProperties.SequenceId
        {
            get 
            {
                return (this._state as IInOutImageStateProperties).SequenceId;
            }
            set 
            {
                (this._state as IInOutImageStateProperties).SequenceId = value;
            }
        }

		public virtual string Url
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Url"))
                {
                    return _state.Url;
                }
                return null;
            }
            set
            {
                _state.Url = value;
            }
        }

        string IInOutImageStateProperties.Url
        {
            get 
            {
                return (this._state as IInOutImageStateProperties).Url;
            }
            set 
            {
                (this._state as IInOutImageStateProperties).Url = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IInOutImageStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IInOutImageStateProperties).Active = value.Value;
                }
            }
        }

        bool IInOutImageStateProperties.Active
        {
            get 
            {
                return (this._state as IInOutImageStateProperties).Active;
            }
            set 
            {
                (this._state as IInOutImageStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IInOutImageStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IInOutImageStateProperties).Version = value.Value;
                }
            }
        }

        long IInOutImageStateProperties.Version
        {
            get 
            {
                return (this._state as IInOutImageStateProperties).Version;
            }
            set 
            {
                (this._state as IInOutImageStateProperties).Version = value;
            }
        }

		public virtual string InOutDocumentNumber
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("InOutDocumentNumber"))
                {
                    return _state.InOutDocumentNumber;
                }
                return null;
            }
            set
            {
                _state.InOutDocumentNumber = value;
            }
        }

        string IInOutImageStateProperties.InOutDocumentNumber
        {
            get 
            {
                return (this._state as IInOutImageStateProperties).InOutDocumentNumber;
            }
            set 
            {
                (this._state as IInOutImageStateProperties).InOutDocumentNumber = value;
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


		InOutImageId IGlobalIdentity<InOutImageId>.GlobalId {
			get { return (_state as IInOutImageState).GlobalId; }
		}

        string ILocalIdentity<string>.LocalId
        {
			get { return (_state as IInOutImageState).LocalId; }
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
            get { return (_state as IInOutImageState).CreatedBy; }
            set { (_state as IInOutImageState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IInOutImageState).CreatedAt; }
            set { (_state as IInOutImageState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IInOutImageState).UpdatedBy; }
            set { (_state as IInOutImageState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IInOutImageState).UpdatedAt; }
            set { (_state as IInOutImageState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IEntityVersioned<long>.EntityVersion
		{
            get { return (_state as IInOutImageStateProperties).Version; }
		}

		#endregion

        bool IInOutImageState.IsUnsaved
        {
            get { return this.Version == InOutImageState.VersionZero; }
        }

		void IInOutImageState.When(IInOutImageStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IInOutImageState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IInOutImageState.When(IInOutImageStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IInOutImageState.When(IInOutImageStateRemoved e)
		{
            throw new NotSupportedException();
		}

		void IInOutImageState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class InOutImageStateDtoWrapperCollection : StateDtoWrapperCollectionBase<InOutImageStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(InOutImageStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}
