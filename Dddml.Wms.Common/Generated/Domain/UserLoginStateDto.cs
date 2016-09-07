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

	public partial class UserLoginStateDto : StateDtoBase, IUserLoginState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private UserLoginState _state;

        public UserLoginStateDto()
        {
            this._state = new UserLoginState();
        }

		public UserLoginStateDto(UserLoginState state)
		{
            this._state = state;
		}

		internal UserLoginState ToUserLoginState()
		{
			return this._state;
		}


        public LoginKeyDto LoginKey
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("LoginKey"))
                {
					return (_state.LoginKey == null) ? null : new LoginKeyDto(_state.LoginKey);
                }
                return null;
            }
            set
            {
                _state.LoginKey = (value == null) ? null : value.ToLoginKey();
            }
        }


        LoginKey IUserLoginStateProperties.LoginKey
        {
            get 
            {
                return (this._state as IUserLoginStateProperties).LoginKey;
            }
            set 
            {
                this._state.LoginKey = value;
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

        bool IUserLoginStateProperties.Active
        {
            get 
            {
                return (this._state as IUserLoginStateProperties).Active;
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

        long IUserLoginStateProperties.Version
        {
            get 
            {
                return (this._state as IUserLoginStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
            }
        }

		public virtual string UserId
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UserId"))
                {
                    return _state.UserId;
                }
                return null;
            }
            set
            {
                _state.UserId = value;
            }
        }

        string IUserLoginStateProperties.UserId
        {
            get 
            {
                return (this._state as IUserLoginStateProperties).UserId;
            }
            set 
            {
                this._state.UserId = value;
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
                    return _state.CreatedAt;
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
                    return _state.UpdatedAt;
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


		UserLoginId IGlobalIdentity<UserLoginId>.GlobalId {
			get { return (_state as IUserLoginState).GlobalId; }
		}

        LoginKey ILocalIdentity<LoginKey>.LocalId
        {
			get { return (_state as IUserLoginState).LocalId; }
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
            get { return (_state as IUserLoginState).CreatedBy; }
            set { (_state as IUserLoginState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IUserLoginState).CreatedAt; }
            set { (_state as IUserLoginState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IUserLoginState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IUserLoginState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IUserLoginState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == UserLoginState.VersionZero; }
        }


		void IUserLoginState.When(IUserLoginStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IUserLoginState.When(IUserLoginStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IUserLoginState.When(IUserLoginStateRemoved e)
		{
            throw new NotSupportedException();
		}


		void IUserLoginState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class UserLoginStateDtoCollection : StateDtoCollectionBase<UserLoginStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(UserLoginStateDto._collectionFieldNames, fieldName);
        }

    }

}

