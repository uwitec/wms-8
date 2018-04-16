﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public partial class UserState : UserStateProperties, IUserState, ISaveable
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.UserId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IUserState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        private IUserRoleStates _userRoles;
      
        public virtual IUserRoleStates UserRoles
        {
            get
            {
                return this._userRoles;
            }
            set
            {
                this._userRoles = value;
            }
        }


        private IUserClaimStates _userClaims;
      
        public virtual IUserClaimStates UserClaims
        {
            get
            {
                return this._userClaims;
            }
            set
            {
                this._userClaims = value;
            }
        }


        private IUserPermissionStates _userPermissions;
      
        public virtual IUserPermissionStates UserPermissions
        {
            get
            {
                return this._userPermissions;
            }
            set
            {
                this._userPermissions = value;
            }
        }


        private IUserLoginStates _userLogins;
      
        public virtual IUserLoginStates UserLogins
        {
            get
            {
                return this._userLogins;
            }
            set
            {
                this._userLogins = value;
            }
        }


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public UserState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.UserId = ((IUserEvent)events.First()).UserEventId.UserId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public UserState() : this(false)
        {
        }

        public UserState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            _userRoles = new UserRoleStates(this);

            _userClaims = new UserClaimStates(this);

            _userPermissions = new UserPermissionStates(this);

            _userLogins = new UserLoginStates(this);

            InitializeProperties();
        }


		#region Saveable Implements

        public virtual void Save()
        {
            _userRoles.Save();

            _userClaims.Save();

            _userPermissions.Save();

            _userLogins.Save();

        }


		#endregion


		public virtual void When(IUserStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.UserName = e.UserName;

            this.AccessFailedCount = (e.AccessFailedCount != null && e.AccessFailedCount.HasValue) ? e.AccessFailedCount.Value : default(int);

			this.Email = e.Email;

            this.EmailConfirmed = (e.EmailConfirmed != null && e.EmailConfirmed.HasValue) ? e.EmailConfirmed.Value : default(bool);

            this.LockoutEnabled = (e.LockoutEnabled != null && e.LockoutEnabled.HasValue) ? e.LockoutEnabled.Value : default(bool);

			this.LockoutEndDateUtc = e.LockoutEndDateUtc;

			this.PasswordHash = e.PasswordHash;

			this.PhoneNumber = e.PhoneNumber;

            this.PhoneNumberConfirmed = (e.PhoneNumberConfirmed != null && e.PhoneNumberConfirmed.HasValue) ? e.PhoneNumberConfirmed.Value : default(bool);

            this.TwoFactorEnabled = (e.TwoFactorEnabled != null && e.TwoFactorEnabled.HasValue) ? e.TwoFactorEnabled.Value : default(bool);

			this.SecurityStamp = e.SecurityStamp;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;

			foreach (IUserRoleStateCreated innerEvent in e.UserRoleEvents) {
				IUserRoleState innerState = this.UserRoles.Get(innerEvent.GlobalId.RoleId, true);
				innerState.Mutate (innerEvent);
			}
			foreach (IUserClaimStateCreated innerEvent in e.UserClaimEvents) {
				IUserClaimState innerState = this.UserClaims.Get(innerEvent.GlobalId.ClaimId, true);
				innerState.Mutate (innerEvent);
			}
			foreach (IUserPermissionStateCreated innerEvent in e.UserPermissionEvents) {
				IUserPermissionState innerState = this.UserPermissions.Get(innerEvent.GlobalId.PermissionId, true);
				innerState.Mutate (innerEvent);
			}
			foreach (IUserLoginStateCreated innerEvent in e.UserLoginEvents) {
				IUserLoginState innerState = this.UserLogins.Get(innerEvent.GlobalId.LoginKey, true);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IUserStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.UserName == null)
			{
				if (e.IsPropertyUserNameRemoved)
				{
					this.UserName = default(string);
				}
			}
			else
			{
				this.UserName = e.UserName;
			}

			if (e.AccessFailedCount == null)
			{
				if (e.IsPropertyAccessFailedCountRemoved)
				{
					this.AccessFailedCount = default(int);
				}
			}
			else
			{
				this.AccessFailedCount = (e.AccessFailedCount != null && e.AccessFailedCount.HasValue) ? e.AccessFailedCount.Value : default(int);
			}

			if (e.Email == null)
			{
				if (e.IsPropertyEmailRemoved)
				{
					this.Email = default(string);
				}
			}
			else
			{
				this.Email = e.Email;
			}

			if (e.EmailConfirmed == null)
			{
				if (e.IsPropertyEmailConfirmedRemoved)
				{
					this.EmailConfirmed = default(bool);
				}
			}
			else
			{
				this.EmailConfirmed = (e.EmailConfirmed != null && e.EmailConfirmed.HasValue) ? e.EmailConfirmed.Value : default(bool);
			}

			if (e.LockoutEnabled == null)
			{
				if (e.IsPropertyLockoutEnabledRemoved)
				{
					this.LockoutEnabled = default(bool);
				}
			}
			else
			{
				this.LockoutEnabled = (e.LockoutEnabled != null && e.LockoutEnabled.HasValue) ? e.LockoutEnabled.Value : default(bool);
			}

			if (e.LockoutEndDateUtc == null)
			{
				if (e.IsPropertyLockoutEndDateUtcRemoved)
				{
					this.LockoutEndDateUtc = default(DateTime?);
				}
			}
			else
			{
				this.LockoutEndDateUtc = e.LockoutEndDateUtc;
			}

			if (e.PasswordHash == null)
			{
				if (e.IsPropertyPasswordHashRemoved)
				{
					this.PasswordHash = default(string);
				}
			}
			else
			{
				this.PasswordHash = e.PasswordHash;
			}

			if (e.PhoneNumber == null)
			{
				if (e.IsPropertyPhoneNumberRemoved)
				{
					this.PhoneNumber = default(string);
				}
			}
			else
			{
				this.PhoneNumber = e.PhoneNumber;
			}

			if (e.PhoneNumberConfirmed == null)
			{
				if (e.IsPropertyPhoneNumberConfirmedRemoved)
				{
					this.PhoneNumberConfirmed = default(bool);
				}
			}
			else
			{
				this.PhoneNumberConfirmed = (e.PhoneNumberConfirmed != null && e.PhoneNumberConfirmed.HasValue) ? e.PhoneNumberConfirmed.Value : default(bool);
			}

			if (e.TwoFactorEnabled == null)
			{
				if (e.IsPropertyTwoFactorEnabledRemoved)
				{
					this.TwoFactorEnabled = default(bool);
				}
			}
			else
			{
				this.TwoFactorEnabled = (e.TwoFactorEnabled != null && e.TwoFactorEnabled.HasValue) ? e.TwoFactorEnabled.Value : default(bool);
			}

			if (e.SecurityStamp == null)
			{
				if (e.IsPropertySecurityStampRemoved)
				{
					this.SecurityStamp = default(string);
				}
			}
			else
			{
				this.SecurityStamp = e.SecurityStamp;
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


			foreach (IUserRoleEvent innerEvent in e.UserRoleEvents)
            {
                IUserRoleState innerState = this.UserRoles.Get(innerEvent.GlobalId.RoleId);

                innerState.Mutate(innerEvent);
                var removed = innerEvent as IUserRoleStateRemoved;
                if (removed != null)
                {
                    this.UserRoles.Remove(innerState);
                }
          
            }

			foreach (IUserClaimEvent innerEvent in e.UserClaimEvents)
            {
                IUserClaimState innerState = this.UserClaims.Get(innerEvent.GlobalId.ClaimId);

                innerState.Mutate(innerEvent);
                var removed = innerEvent as IUserClaimStateRemoved;
                if (removed != null)
                {
                    this.UserClaims.Remove(innerState);
                }
          
            }

			foreach (IUserPermissionEvent innerEvent in e.UserPermissionEvents)
            {
                IUserPermissionState innerState = this.UserPermissions.Get(innerEvent.GlobalId.PermissionId);

                innerState.Mutate(innerEvent);
                var removed = innerEvent as IUserPermissionStateRemoved;
                if (removed != null)
                {
                    this.UserPermissions.Remove(innerState);
                }
          
            }

			foreach (IUserLoginEvent innerEvent in e.UserLoginEvents)
            {
                IUserLoginState innerState = this.UserLogins.Get(innerEvent.GlobalId.LoginKey);

                innerState.Mutate(innerEvent);
                var removed = innerEvent as IUserLoginStateRemoved;
                if (removed != null)
                {
                    this.UserLogins.Remove(innerState);
                }
          
            }

		}

		public virtual void When(IUserStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

            foreach (var innerState in this.UserRoles)
            {
                this.UserRoles.Remove(innerState);
                
                var innerE = e.NewUserRoleStateRemoved(innerState.RoleId);
                ((UserRoleEventBase)innerE).CreatedAt = e.CreatedAt;
                ((UserRoleEventBase)innerE).CreatedBy = e.CreatedBy;
                innerState.When(innerE);
                //e.AddUserRoleEvent(innerE);

            }

            foreach (var innerState in this.UserClaims)
            {
                this.UserClaims.Remove(innerState);
                
                var innerE = e.NewUserClaimStateRemoved(innerState.ClaimId);
                ((UserClaimEventBase)innerE).CreatedAt = e.CreatedAt;
                ((UserClaimEventBase)innerE).CreatedBy = e.CreatedBy;
                innerState.When(innerE);
                //e.AddUserClaimEvent(innerE);

            }

            foreach (var innerState in this.UserPermissions)
            {
                this.UserPermissions.Remove(innerState);
                
                var innerE = e.NewUserPermissionStateRemoved(innerState.PermissionId);
                ((UserPermissionEventBase)innerE).CreatedAt = e.CreatedAt;
                ((UserPermissionEventBase)innerE).CreatedBy = e.CreatedBy;
                innerState.When(innerE);
                //e.AddUserPermissionEvent(innerE);

            }

            foreach (var innerState in this.UserLogins)
            {
                this.UserLogins.Remove(innerState);
                
                var innerE = e.NewUserLoginStateRemoved(innerState.LoginKey);
                ((UserLoginEventBase)innerE).CreatedAt = e.CreatedAt;
                ((UserLoginEventBase)innerE).CreatedBy = e.CreatedBy;
                innerState.When(innerE);
                //e.AddUserLoginEvent(innerE);

            }

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IUserEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("User|");

            var stateEntityId = this.UserId; // Aggregate Id
            var eventEntityId = e.UserEventId.UserId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = e.UserEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

