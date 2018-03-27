﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyRoleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.PartyRole
{

	public partial class PartyRoleStateDtoWrapper : StateDtoWrapperBase, IPartyRoleStateDto, IPartyRoleState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IPartyRoleState _state;

        public PartyRoleStateDtoWrapper()
        {
            this._state = new PartyRoleState();
        }

		public PartyRoleStateDtoWrapper(IPartyRoleState state)
		{
            this._state = state;
		}

		public IPartyRoleState ToPartyRoleState()
		{
			return this._state;
		}

		public virtual PartyRoleId PartyRoleId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PartyRoleId"))
                {
                    return _state.PartyRoleId;
                }
                return null;
            }
            set
            {
                _state.PartyRoleId = value;
            }
        }

        PartyRoleId IPartyRoleStateProperties.PartyRoleId
        {
            get 
            {
                return (this._state as IPartyRoleStateProperties).PartyRoleId;
            }
            set 
            {
                (this._state as IPartyRoleStateProperties).PartyRoleId = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IPartyRoleStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IPartyRoleStateProperties).Active = value.Value;
                }
            }
        }

        bool IPartyRoleStateProperties.Active
        {
            get 
            {
                return (this._state as IPartyRoleStateProperties).Active;
            }
            set 
            {
                (this._state as IPartyRoleStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IPartyRoleStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IPartyRoleStateProperties).Version = value.Value;
                }
            }
        }

        long IPartyRoleStateProperties.Version
        {
            get 
            {
                return (this._state as IPartyRoleStateProperties).Version;
            }
            set 
            {
                (this._state as IPartyRoleStateProperties).Version = value;
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

		PartyRoleId IGlobalIdentity<PartyRoleId>.GlobalId
		{
			get { return (_state as IPartyRoleState).GlobalId; }
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
            get { return (_state as IPartyRoleState).CreatedBy; }
            set { (_state as IPartyRoleState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IPartyRoleState).CreatedAt; }
            set { (_state as IPartyRoleState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IPartyRoleState).UpdatedBy; }
            set { (_state as IPartyRoleState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IPartyRoleState).UpdatedAt; }
            set { (_state as IPartyRoleState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IPartyRoleStateProperties).Version; }
		}

		#endregion

        bool IPartyRoleState.IsUnsaved
        {
            get { return this.Version == PartyRoleState.VersionZero; }
        }

		void IPartyRoleState.When(IPartyRoleStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IPartyRoleState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IPartyRoleState.When(IPartyRoleStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IPartyRoleState.When(IPartyRoleStateDeleted e)
		{
            throw new NotSupportedException();
		}

		void IPartyRoleState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class PartyRoleStateDtoWrapperCollection : StateDtoWrapperCollectionBase<PartyRoleStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(PartyRoleStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

