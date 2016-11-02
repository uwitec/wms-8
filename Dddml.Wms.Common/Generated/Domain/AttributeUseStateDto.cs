﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public partial class AttributeUseStateDto : StateDtoBase, IAttributeUseState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private AttributeUseState _state;

        public AttributeUseStateDto()
        {
            this._state = new AttributeUseState();
        }

		public AttributeUseStateDto(AttributeUseState state)
		{
            this._state = state;
		}

		internal AttributeUseState ToAttributeUseState()
		{
			return this._state;
		}

		public virtual string AttributeId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeId"))
                {
                    return _state.AttributeId;
                }
                return null;
            }
            set
            {
                _state.AttributeId = value;
            }
        }

        string IAttributeUseStateProperties.AttributeId
        {
            get 
            {
                return (this._state as IAttributeUseStateProperties).AttributeId;
            }
            set 
            {
                this._state.AttributeId = value;
            }
        }

		public virtual int? SequenceNumber
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("SequenceNumber"))
                {
                    return _state.SequenceNumber;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.SequenceNumber = value.Value;
                }
            }
        }

        int IAttributeUseStateProperties.SequenceNumber
        {
            get 
            {
                return (this._state as IAttributeUseStateProperties).SequenceNumber;
            }
            set 
            {
                this._state.SequenceNumber = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Active"))
                {
                    return _state.Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Active = value.Value;
                }
            }
        }

        bool IAttributeUseStateProperties.Active
        {
            get 
            {
                return (this._state as IAttributeUseStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Version"))
                {
                    return _state.Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Version = value.Value;
                }
            }
        }

        long IAttributeUseStateProperties.Version
        {
            get 
            {
                return (this._state as IAttributeUseStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
            }
        }

		public virtual string AttributeSetId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("AttributeSetId"))
                {
                    return _state.AttributeSetId;
                }
                return null;
            }
            set
            {
                _state.AttributeSetId = value;
            }
        }

        string IAttributeUseStateProperties.AttributeSetId
        {
            get 
            {
                return (this._state as IAttributeUseStateProperties).AttributeSetId;
            }
            set 
            {
                this._state.AttributeSetId = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("CreatedBy"))
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
                if ((this as IStateDto).ReturnedFieldsContains("CreatedAt"))
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
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedBy"))
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
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedAt"))
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


		AttributeSetAttributeUseId IGlobalIdentity<AttributeSetAttributeUseId>.GlobalId {
			get { return (_state as IAttributeUseState).GlobalId; }
		}

        string ILocalIdentity<string>.LocalId
        {
			get { return (_state as IAttributeUseState).LocalId; }
        }

		#endregion


		#region IActive implementation

		bool IActive.Active
		{
            get { return (_state as IActive).Active; }
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
            get { return (_state as IAttributeUseState).CreatedBy; }
            set { (_state as IAttributeUseState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IAttributeUseState).CreatedAt; }
            set { (_state as IAttributeUseState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IAttributeUseState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IAttributeUseState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IAttributeUseState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == AttributeUseState.VersionZero; }
        }


		void IAttributeUseState.When(IAttributeUseStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IAttributeUseState.When(IAttributeUseStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IAttributeUseState.When(IAttributeUseStateRemoved e)
		{
            throw new NotSupportedException();
		}


		void IAttributeUseState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class AttributeUseStateDtoCollection : StateDtoCollectionBase<AttributeUseStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(AttributeUseStateDto._collectionFieldNames, fieldName);
        }

    }

}

