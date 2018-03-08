﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserClaimMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserClaimMvo
{

	public abstract class UserClaimMvoStateEventDtoBase : IStateEventDto, IUserClaimMvoStateCreated, IUserClaimMvoStateMergePatched, IUserClaimMvoStateDeleted
	{

        private UserClaimMvoEventIdDto _userClaimMvoEventId;

		protected internal virtual UserClaimMvoEventIdDto UserClaimMvoEventId 
        {
            get 
            {
                if (_userClaimMvoEventId == null) { _userClaimMvoEventId = new UserClaimMvoEventIdDto(); }
                return _userClaimMvoEventId;
            }
            set
            {
                _userClaimMvoEventId = value;
            }
        }

        public virtual UserClaimIdDto UserClaimId
        {
            get { return UserClaimMvoEventId.UserClaimId; }
            set { UserClaimMvoEventId.UserClaimId = value; }
        }

        public virtual long UserVersion
        {
            get { return UserClaimMvoEventId.UserVersion; }
            set { UserClaimMvoEventId.UserVersion = value; }
        }

		public virtual string ClaimType { get; set; }

		public virtual string ClaimValue { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string UserUserName { get; set; }

		public virtual int? UserAccessFailedCount { get; set; }

		public virtual string UserEmail { get; set; }

		public virtual bool? UserEmailConfirmed { get; set; }

		public virtual bool? UserLockoutEnabled { get; set; }

		public virtual DateTime? UserLockoutEndDateUtc { get; set; }

		public virtual string UserPasswordHash { get; set; }

		public virtual string UserPhoneNumber { get; set; }

		public virtual bool? UserPhoneNumberConfirmed { get; set; }

		public virtual bool? UserTwoFactorEnabled { get; set; }

		public virtual string UserSecurityStamp { get; set; }

		public virtual string UserCreatedBy { get; set; }

		public virtual DateTime? UserCreatedAt { get; set; }

		public virtual string UserUpdatedBy { get; set; }

		public virtual DateTime? UserUpdatedAt { get; set; }

		public virtual bool? UserActive { get; set; }

		public virtual bool? UserDeleted { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		UserClaimMvoEventId IGlobalIdentity<UserClaimMvoEventId>.GlobalId {
			get 
			{
				return this.UserClaimMvoEventId.ToUserClaimMvoEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IUserClaimMvoStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyClaimTypeRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyClaimTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyClaimTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyClaimTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyClaimValueRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyClaimValueRemoved
        {
            get 
            {
                var b = this.IsPropertyClaimValueRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyClaimValueRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUserNameRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserUserNameRemoved
        {
            get 
            {
                var b = this.IsPropertyUserUserNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserUserNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserAccessFailedCountRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserAccessFailedCountRemoved
        {
            get 
            {
                var b = this.IsPropertyUserAccessFailedCountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserAccessFailedCountRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserEmailRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserEmailRemoved
        {
            get 
            {
                var b = this.IsPropertyUserEmailRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserEmailRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserEmailConfirmedRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserEmailConfirmedRemoved
        {
            get 
            {
                var b = this.IsPropertyUserEmailConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserEmailConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserLockoutEnabledRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserLockoutEnabledRemoved
        {
            get 
            {
                var b = this.IsPropertyUserLockoutEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserLockoutEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserLockoutEndDateUtcRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserLockoutEndDateUtcRemoved
        {
            get 
            {
                var b = this.IsPropertyUserLockoutEndDateUtcRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserLockoutEndDateUtcRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPasswordHashRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserPasswordHashRemoved
        {
            get 
            {
                var b = this.IsPropertyUserPasswordHashRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserPasswordHashRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPhoneNumberRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserPhoneNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyUserPhoneNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserPhoneNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPhoneNumberConfirmedRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserPhoneNumberConfirmedRemoved
        {
            get 
            {
                var b = this.IsPropertyUserPhoneNumberConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserPhoneNumberConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserTwoFactorEnabledRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserTwoFactorEnabledRemoved
        {
            get 
            {
                var b = this.IsPropertyUserTwoFactorEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserTwoFactorEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserSecurityStampRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserSecurityStampRemoved
        {
            get 
            {
                var b = this.IsPropertyUserSecurityStampRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserSecurityStampRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserCreatedByRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyUserCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserCreatedAtRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyUserCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUpdatedByRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyUserUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUpdatedAtRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyUserUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserActiveRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyUserActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserDeletedRemoved { get; set; }

        bool IUserClaimMvoStateMergePatched.IsPropertyUserDeletedRemoved
        {
            get 
            {
                var b = this.IsPropertyUserDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUserDeletedRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        UserClaimMvoEventId IUserClaimMvoStateEvent.UserClaimMvoEventId
        {
            get { return this.UserClaimMvoEventId.ToUserClaimMvoEventId(); }
        }

        protected UserClaimMvoStateEventDtoBase()
        {
        }

        protected UserClaimMvoStateEventDtoBase(UserClaimMvoEventIdDto stateEventId)
        {
            this.UserClaimMvoEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto : UserClaimMvoStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class UserClaimMvoStateCreatedDto : UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public UserClaimMvoStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class UserClaimMvoStateMergePatchedDto : UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public UserClaimMvoStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class UserClaimMvoStateDeletedDto : UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public UserClaimMvoStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class UserClaimMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IUserClaimMvoStateCreated>, IEnumerable<IUserClaimMvoStateMergePatched>, IEnumerable<IUserClaimMvoStateDeleted>
    {
        private List<UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserClaimMvoStateCreated> IEnumerable<IUserClaimMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserClaimMvoStateMergePatched> IEnumerable<IUserClaimMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserClaimMvoStateDeleted> IEnumerable<IUserClaimMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddUserClaimMvoEvent(IUserClaimMvoStateCreated e)
        {
            _innerStateEvents.Add((UserClaimMvoStateCreatedDto)e);
        }

        public void AddUserClaimMvoEvent(IUserClaimMvoStateEvent e)
        {
            _innerStateEvents.Add((UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddUserClaimMvoEvent(IUserClaimMvoStateDeleted e)
        {
            _innerStateEvents.Add((UserClaimMvoStateDeletedDto)e);
        }

    }


}

