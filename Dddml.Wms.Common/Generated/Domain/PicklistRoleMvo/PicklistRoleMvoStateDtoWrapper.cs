﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;

namespace Dddml.Wms.Domain.PicklistRoleMvo
{

	public partial class PicklistRoleMvoStateDtoWrapper : StateDtoWrapperBase, IPicklistRoleMvoStateDto, IPicklistRoleMvoState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private IPicklistRoleMvoState _state;

        public PicklistRoleMvoStateDtoWrapper()
        {
            this._state = new PicklistRoleMvoState();
        }

		public PicklistRoleMvoStateDtoWrapper(IPicklistRoleMvoState state)
		{
            this._state = state;
		}

		public IPicklistRoleMvoState ToPicklistRoleMvoState()
		{
			return this._state;
		}

		public virtual PicklistRoleId PicklistRoleId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistRoleId"))
                {
                    return _state.PicklistRoleId;
                }
                return null;
            }
            set
            {
                _state.PicklistRoleId = value;
            }
        }

        PicklistRoleId IPicklistRoleMvoStateProperties.PicklistRoleId
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistRoleId;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistRoleId = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as IPicklistRoleMvoStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IPicklistRoleMvoStateProperties).Version = value.Value;
                }
            }
        }

        long IPicklistRoleMvoStateProperties.Version
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).Version;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).Version = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as IPicklistRoleMvoStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as IPicklistRoleMvoStateProperties).Active = value.Value;
                }
            }
        }

        bool IPicklistRoleMvoStateProperties.Active
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).Active;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).Active = value;
            }
        }

		public virtual string PicklistDescription
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistDescription"))
                {
                    return _state.PicklistDescription;
                }
                return null;
            }
            set
            {
                _state.PicklistDescription = value;
            }
        }

        string IPicklistRoleMvoStateProperties.PicklistDescription
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistDescription;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistDescription = value;
            }
        }

		public virtual string PicklistFacilityId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistFacilityId"))
                {
                    return _state.PicklistFacilityId;
                }
                return null;
            }
            set
            {
                _state.PicklistFacilityId = value;
            }
        }

        string IPicklistRoleMvoStateProperties.PicklistFacilityId
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistFacilityId;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistFacilityId = value;
            }
        }

		public virtual string PicklistShipmentMethodTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistShipmentMethodTypeId"))
                {
                    return _state.PicklistShipmentMethodTypeId;
                }
                return null;
            }
            set
            {
                _state.PicklistShipmentMethodTypeId = value;
            }
        }

        string IPicklistRoleMvoStateProperties.PicklistShipmentMethodTypeId
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistShipmentMethodTypeId;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistShipmentMethodTypeId = value;
            }
        }

		public virtual string PicklistStatusId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistStatusId"))
                {
                    return _state.PicklistStatusId;
                }
                return null;
            }
            set
            {
                _state.PicklistStatusId = value;
            }
        }

        string IPicklistRoleMvoStateProperties.PicklistStatusId
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistStatusId;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistStatusId = value;
            }
        }

		public virtual DateTime? PicklistPicklistDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistPicklistDate"))
                {
                    return _state.PicklistPicklistDate;
                }
                return null;
            }
            set
            {
                _state.PicklistPicklistDate = value;
            }
        }

        DateTime? IPicklistRoleMvoStateProperties.PicklistPicklistDate
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistPicklistDate;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistPicklistDate = value;
            }
        }

		public virtual string PicklistCreatedByUserLogin
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistCreatedByUserLogin"))
                {
                    return _state.PicklistCreatedByUserLogin;
                }
                return null;
            }
            set
            {
                _state.PicklistCreatedByUserLogin = value;
            }
        }

        string IPicklistRoleMvoStateProperties.PicklistCreatedByUserLogin
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistCreatedByUserLogin;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistCreatedByUserLogin = value;
            }
        }

		public virtual string PicklistLastModifiedByUserLogin
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistLastModifiedByUserLogin"))
                {
                    return _state.PicklistLastModifiedByUserLogin;
                }
                return null;
            }
            set
            {
                _state.PicklistLastModifiedByUserLogin = value;
            }
        }

        string IPicklistRoleMvoStateProperties.PicklistLastModifiedByUserLogin
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistLastModifiedByUserLogin;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistLastModifiedByUserLogin = value;
            }
        }

		public virtual DateTime? PicklistCreatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistCreatedAt"))
                {
                    return _state.PicklistCreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.PicklistCreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PicklistCreatedAt = value.Value;
                }
            }
        }

        DateTime IPicklistRoleMvoStateProperties.PicklistCreatedAt
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistCreatedAt;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistCreatedAt = value;
            }
        }

		public virtual DateTime? PicklistUpdatedAt
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistUpdatedAt"))
                {
                    return _state.PicklistUpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.PicklistUpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PicklistUpdatedAt = value.Value;
                }
            }
        }

        DateTime IPicklistRoleMvoStateProperties.PicklistUpdatedAt
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistUpdatedAt;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistUpdatedAt = value;
            }
        }

		public virtual bool? PicklistActive
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistActive"))
                {
                    return _state.PicklistActive;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PicklistActive = value.Value;
                }
            }
        }

        bool IPicklistRoleMvoStateProperties.PicklistActive
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistActive;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistActive = value;
            }
        }

		public virtual bool? PicklistDeleted
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistDeleted"))
                {
                    return _state.PicklistDeleted;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PicklistDeleted = value.Value;
                }
            }
        }

        bool IPicklistRoleMvoStateProperties.PicklistDeleted
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistDeleted;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistDeleted = value;
            }
        }

		public virtual long? PicklistVersion
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("PicklistVersion"))
                {
                    return _state.PicklistVersion;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.PicklistVersion = value.Value;
                }
            }
        }

        long IPicklistRoleMvoStateProperties.PicklistVersion
        {
            get 
            {
                return (this._state as IPicklistRoleMvoStateProperties).PicklistVersion;
            }
            set 
            {
                (this._state as IPicklistRoleMvoStateProperties).PicklistVersion = value;
            }
        }

		public virtual string CreatedByUserLogin
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedByUserLogin"))
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

		public virtual string LastModifiedByUserLogin
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("LastModifiedByUserLogin"))
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

		PicklistRoleId IGlobalIdentity<PicklistRoleId>.GlobalId
		{
			get { return (_state as IPicklistRoleMvoState).GlobalId; }
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
            get { return (_state as IPicklistRoleMvoState).CreatedBy; }
            set { (_state as IPicklistRoleMvoState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IPicklistRoleMvoState).CreatedAt; }
            set { (_state as IPicklistRoleMvoState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IPicklistRoleMvoState).UpdatedBy; }
            set { (_state as IPicklistRoleMvoState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IPicklistRoleMvoState).UpdatedAt; }
            set { (_state as IPicklistRoleMvoState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as IPicklistRoleMvoStateProperties).PicklistVersion; }
		}

		#endregion

        bool IPicklistRoleMvoState.IsUnsaved
        {
            get { return this.PicklistVersion == PicklistRoleMvoState.VersionZero; }
        }

		void IPicklistRoleMvoState.When(IPicklistRoleMvoStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool IPicklistRoleMvoState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void IPicklistRoleMvoState.When(IPicklistRoleMvoStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IPicklistRoleMvoState.When(IPicklistRoleMvoStateDeleted e)
		{
            throw new NotSupportedException();
		}

		void IPicklistRoleMvoState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class PicklistRoleMvoStateDtoWrapperCollection : StateDtoWrapperCollectionBase<PicklistRoleMvoStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(PicklistRoleMvoStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}

