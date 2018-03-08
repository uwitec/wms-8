﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserLoginMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserLoginMvo
{

	public partial class UserLoginMvoState : UserLoginMvoStateProperties, IUserLoginMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		UserLoginId IGlobalIdentity<UserLoginId>.GlobalId
		{
			get
			{
				return this.UserLoginId;
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
				return this.UserVersion;
			}
		}


		#endregion

        bool IUserLoginMvoState.IsUnsaved
        {
            get { return this.UserVersion == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
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

        public UserLoginMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.UserLoginId = ((IUserLoginMvoStateEvent)events.First()).UserLoginMvoEventId.UserLoginId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.UserVersion += 1;
                }
            }
        }

        public UserLoginMvoState() : this(false)
        {
        }

        public UserLoginMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IUserLoginMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.UserUserName = e.UserUserName;

            this.UserAccessFailedCount = (e.UserAccessFailedCount != null && e.UserAccessFailedCount.HasValue) ? e.UserAccessFailedCount.Value : default(int);

			this.UserEmail = e.UserEmail;

            this.UserEmailConfirmed = (e.UserEmailConfirmed != null && e.UserEmailConfirmed.HasValue) ? e.UserEmailConfirmed.Value : default(bool);

            this.UserLockoutEnabled = (e.UserLockoutEnabled != null && e.UserLockoutEnabled.HasValue) ? e.UserLockoutEnabled.Value : default(bool);

			this.UserLockoutEndDateUtc = e.UserLockoutEndDateUtc;

			this.UserPasswordHash = e.UserPasswordHash;

			this.UserPhoneNumber = e.UserPhoneNumber;

            this.UserPhoneNumberConfirmed = (e.UserPhoneNumberConfirmed != null && e.UserPhoneNumberConfirmed.HasValue) ? e.UserPhoneNumberConfirmed.Value : default(bool);

            this.UserTwoFactorEnabled = (e.UserTwoFactorEnabled != null && e.UserTwoFactorEnabled.HasValue) ? e.UserTwoFactorEnabled.Value : default(bool);

			this.UserSecurityStamp = e.UserSecurityStamp;

			this.UserCreatedBy = e.UserCreatedBy;

            this.UserCreatedAt = (e.UserCreatedAt != null && e.UserCreatedAt.HasValue) ? e.UserCreatedAt.Value : default(DateTime);

			this.UserUpdatedBy = e.UserUpdatedBy;

            this.UserUpdatedAt = (e.UserUpdatedAt != null && e.UserUpdatedAt.HasValue) ? e.UserUpdatedAt.Value : default(DateTime);

            this.UserActive = (e.UserActive != null && e.UserActive.HasValue) ? e.UserActive.Value : default(bool);

            this.UserDeleted = (e.UserDeleted != null && e.UserDeleted.HasValue) ? e.UserDeleted.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IUserLoginMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
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

			if (e.UserUserName == null)
			{
				if (e.IsPropertyUserUserNameRemoved)
				{
					this.UserUserName = default(string);
				}
			}
			else
			{
				this.UserUserName = e.UserUserName;
			}

			if (e.UserAccessFailedCount == null)
			{
				if (e.IsPropertyUserAccessFailedCountRemoved)
				{
					this.UserAccessFailedCount = default(int);
				}
			}
			else
			{
				this.UserAccessFailedCount = (e.UserAccessFailedCount != null && e.UserAccessFailedCount.HasValue) ? e.UserAccessFailedCount.Value : default(int);
			}

			if (e.UserEmail == null)
			{
				if (e.IsPropertyUserEmailRemoved)
				{
					this.UserEmail = default(string);
				}
			}
			else
			{
				this.UserEmail = e.UserEmail;
			}

			if (e.UserEmailConfirmed == null)
			{
				if (e.IsPropertyUserEmailConfirmedRemoved)
				{
					this.UserEmailConfirmed = default(bool);
				}
			}
			else
			{
				this.UserEmailConfirmed = (e.UserEmailConfirmed != null && e.UserEmailConfirmed.HasValue) ? e.UserEmailConfirmed.Value : default(bool);
			}

			if (e.UserLockoutEnabled == null)
			{
				if (e.IsPropertyUserLockoutEnabledRemoved)
				{
					this.UserLockoutEnabled = default(bool);
				}
			}
			else
			{
				this.UserLockoutEnabled = (e.UserLockoutEnabled != null && e.UserLockoutEnabled.HasValue) ? e.UserLockoutEnabled.Value : default(bool);
			}

			if (e.UserLockoutEndDateUtc == null)
			{
				if (e.IsPropertyUserLockoutEndDateUtcRemoved)
				{
					this.UserLockoutEndDateUtc = default(DateTime?);
				}
			}
			else
			{
				this.UserLockoutEndDateUtc = e.UserLockoutEndDateUtc;
			}

			if (e.UserPasswordHash == null)
			{
				if (e.IsPropertyUserPasswordHashRemoved)
				{
					this.UserPasswordHash = default(string);
				}
			}
			else
			{
				this.UserPasswordHash = e.UserPasswordHash;
			}

			if (e.UserPhoneNumber == null)
			{
				if (e.IsPropertyUserPhoneNumberRemoved)
				{
					this.UserPhoneNumber = default(string);
				}
			}
			else
			{
				this.UserPhoneNumber = e.UserPhoneNumber;
			}

			if (e.UserPhoneNumberConfirmed == null)
			{
				if (e.IsPropertyUserPhoneNumberConfirmedRemoved)
				{
					this.UserPhoneNumberConfirmed = default(bool);
				}
			}
			else
			{
				this.UserPhoneNumberConfirmed = (e.UserPhoneNumberConfirmed != null && e.UserPhoneNumberConfirmed.HasValue) ? e.UserPhoneNumberConfirmed.Value : default(bool);
			}

			if (e.UserTwoFactorEnabled == null)
			{
				if (e.IsPropertyUserTwoFactorEnabledRemoved)
				{
					this.UserTwoFactorEnabled = default(bool);
				}
			}
			else
			{
				this.UserTwoFactorEnabled = (e.UserTwoFactorEnabled != null && e.UserTwoFactorEnabled.HasValue) ? e.UserTwoFactorEnabled.Value : default(bool);
			}

			if (e.UserSecurityStamp == null)
			{
				if (e.IsPropertyUserSecurityStampRemoved)
				{
					this.UserSecurityStamp = default(string);
				}
			}
			else
			{
				this.UserSecurityStamp = e.UserSecurityStamp;
			}

			if (e.UserCreatedBy == null)
			{
				if (e.IsPropertyUserCreatedByRemoved)
				{
					this.UserCreatedBy = default(string);
				}
			}
			else
			{
				this.UserCreatedBy = e.UserCreatedBy;
			}

			if (e.UserCreatedAt == null)
			{
				if (e.IsPropertyUserCreatedAtRemoved)
				{
					this.UserCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.UserCreatedAt = (e.UserCreatedAt != null && e.UserCreatedAt.HasValue) ? e.UserCreatedAt.Value : default(DateTime);
			}

			if (e.UserUpdatedBy == null)
			{
				if (e.IsPropertyUserUpdatedByRemoved)
				{
					this.UserUpdatedBy = default(string);
				}
			}
			else
			{
				this.UserUpdatedBy = e.UserUpdatedBy;
			}

			if (e.UserUpdatedAt == null)
			{
				if (e.IsPropertyUserUpdatedAtRemoved)
				{
					this.UserUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.UserUpdatedAt = (e.UserUpdatedAt != null && e.UserUpdatedAt.HasValue) ? e.UserUpdatedAt.Value : default(DateTime);
			}

			if (e.UserActive == null)
			{
				if (e.IsPropertyUserActiveRemoved)
				{
					this.UserActive = default(bool);
				}
			}
			else
			{
				this.UserActive = (e.UserActive != null && e.UserActive.HasValue) ? e.UserActive.Value : default(bool);
			}

			if (e.UserDeleted == null)
			{
				if (e.IsPropertyUserDeletedRemoved)
				{
					this.UserDeleted = default(bool);
				}
			}
			else
			{
				this.UserDeleted = (e.UserDeleted != null && e.UserDeleted.HasValue) ? e.UserDeleted.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IUserLoginMvoStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IUserLoginMvoStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("UserLoginMvo|");

            var stateEntityId = this.UserLoginId; // Aggregate Id
            var eventEntityId = stateEvent.UserLoginMvoEventId.UserLoginId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.UserVersion;
            var eventVersion = stateEvent.UserLoginMvoEventId.UserVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

