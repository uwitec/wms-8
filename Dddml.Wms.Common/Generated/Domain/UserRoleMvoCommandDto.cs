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

	public abstract class UserRoleMvoCommandDtoBase : ICommandDto, ICreateUserRoleMvo, IMergePatchUserRoleMvo, IDeleteUserRoleMvo
	{

		UserRoleId IAggregateCommand<UserRoleId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteUserRoleMvo)this).UserRoleId;
			}
		}


		long IAggregateCommand<UserRoleId, long>.AggregateVersion
		{
			get
			{
				return this.UserVersion;
			}
		}

		public virtual long UserVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual UserRoleIdDto UserRoleId { get; set; }

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


        UserRoleId IUserRoleMvoCommand.UserRoleId
        {
            get 
            {
                return this.UserRoleId.ToUserRoleId();
            }
            set 
            {
                this.UserRoleId = new UserRoleIdDtoWrapper(value);
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyVersionRemoved
        {
            get
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUserNameRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserUserNameRemoved
        {
            get
            {
                var b = this.IsPropertyUserUserNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserUserNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserAccessFailedCountRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserAccessFailedCountRemoved
        {
            get
            {
                var b = this.IsPropertyUserAccessFailedCountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserAccessFailedCountRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserEmailRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserEmailRemoved
        {
            get
            {
                var b = this.IsPropertyUserEmailRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserEmailRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserEmailConfirmedRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserEmailConfirmedRemoved
        {
            get
            {
                var b = this.IsPropertyUserEmailConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserEmailConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserLockoutEnabledRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserLockoutEnabledRemoved
        {
            get
            {
                var b = this.IsPropertyUserLockoutEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserLockoutEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserLockoutEndDateUtcRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserLockoutEndDateUtcRemoved
        {
            get
            {
                var b = this.IsPropertyUserLockoutEndDateUtcRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserLockoutEndDateUtcRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPasswordHashRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserPasswordHashRemoved
        {
            get
            {
                var b = this.IsPropertyUserPasswordHashRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserPasswordHashRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPhoneNumberRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserPhoneNumberRemoved
        {
            get
            {
                var b = this.IsPropertyUserPhoneNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserPhoneNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserPhoneNumberConfirmedRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserPhoneNumberConfirmedRemoved
        {
            get
            {
                var b = this.IsPropertyUserPhoneNumberConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserPhoneNumberConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserTwoFactorEnabledRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserTwoFactorEnabledRemoved
        {
            get
            {
                var b = this.IsPropertyUserTwoFactorEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserTwoFactorEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserSecurityStampRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserSecurityStampRemoved
        {
            get
            {
                var b = this.IsPropertyUserSecurityStampRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserSecurityStampRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserCreatedByRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyUserCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserCreatedAtRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyUserCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUpdatedByRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyUserUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserUpdatedAtRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyUserUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserActiveRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserActiveRemoved
        {
            get
            {
                var b = this.IsPropertyUserActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyUserDeletedRemoved { get; set; }

        bool IMergePatchUserRoleMvo.IsPropertyUserDeletedRemoved
        {
            get
            {
                var b = this.IsPropertyUserDeletedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserDeletedRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteUserRoleMvoDto : UserRoleMvoCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateUserRoleMvoDto : CreateOrMergePatchOrDeleteUserRoleMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchUserRoleMvoDto : CreateOrMergePatchOrDeleteUserRoleMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteUserRoleMvoDto : CreateOrMergePatchOrDeleteUserRoleMvoDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class UserRoleMvoCommandDtos
    {

    }

}

