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

	public abstract class UserCommandDtoBase : ICommandDto, ICreateUser, IMergePatchUser, IDeleteUser
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteUser)this).UserId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

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

		public virtual string UserId { get; set; }

		public virtual string UserName { get; set; }

		public virtual int? AccessFailedCount { get; set; }

		public virtual string Email { get; set; }

		public virtual bool? EmailConfirmed { get; set; }

		public virtual bool? LockoutEnabled { get; set; }

		public virtual DateTime? LockoutEndDateUtc { get; set; }

		public virtual string PasswordHash { get; set; }

		public virtual string PhoneNumber { get; set; }

		public virtual bool? PhoneNumberConfirmed { get; set; }

		public virtual bool? TwoFactorEnabled { get; set; }

		public virtual string SecurityStamp { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? IsPropertyUserNameRemoved { get; set; }

        bool IMergePatchUser.IsPropertyUserNameRemoved
        {
            get
            {
                var b = this.IsPropertyUserNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUserNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAccessFailedCountRemoved { get; set; }

        bool IMergePatchUser.IsPropertyAccessFailedCountRemoved
        {
            get
            {
                var b = this.IsPropertyAccessFailedCountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAccessFailedCountRemoved = value;
            }
        }

		public virtual bool? IsPropertyEmailRemoved { get; set; }

        bool IMergePatchUser.IsPropertyEmailRemoved
        {
            get
            {
                var b = this.IsPropertyEmailRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEmailRemoved = value;
            }
        }

		public virtual bool? IsPropertyEmailConfirmedRemoved { get; set; }

        bool IMergePatchUser.IsPropertyEmailConfirmedRemoved
        {
            get
            {
                var b = this.IsPropertyEmailConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEmailConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyLockoutEnabledRemoved { get; set; }

        bool IMergePatchUser.IsPropertyLockoutEnabledRemoved
        {
            get
            {
                var b = this.IsPropertyLockoutEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLockoutEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertyLockoutEndDateUtcRemoved { get; set; }

        bool IMergePatchUser.IsPropertyLockoutEndDateUtcRemoved
        {
            get
            {
                var b = this.IsPropertyLockoutEndDateUtcRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLockoutEndDateUtcRemoved = value;
            }
        }

		public virtual bool? IsPropertyPasswordHashRemoved { get; set; }

        bool IMergePatchUser.IsPropertyPasswordHashRemoved
        {
            get
            {
                var b = this.IsPropertyPasswordHashRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPasswordHashRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhoneNumberRemoved { get; set; }

        bool IMergePatchUser.IsPropertyPhoneNumberRemoved
        {
            get
            {
                var b = this.IsPropertyPhoneNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhoneNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhoneNumberConfirmedRemoved { get; set; }

        bool IMergePatchUser.IsPropertyPhoneNumberConfirmedRemoved
        {
            get
            {
                var b = this.IsPropertyPhoneNumberConfirmedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhoneNumberConfirmedRemoved = value;
            }
        }

		public virtual bool? IsPropertyTwoFactorEnabledRemoved { get; set; }

        bool IMergePatchUser.IsPropertyTwoFactorEnabledRemoved
        {
            get
            {
                var b = this.IsPropertyTwoFactorEnabledRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyTwoFactorEnabledRemoved = value;
            }
        }

		public virtual bool? IsPropertySecurityStampRemoved { get; set; }

        bool IMergePatchUser.IsPropertySecurityStampRemoved
        {
            get
            {
                var b = this.IsPropertySecurityStampRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertySecurityStampRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchUser.IsPropertyActiveRemoved
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

        ICreateUserRoleCommands ICreateUser.UserRoles
        {
            get
            {
                return this._userRoles;
            }
        }

        IUserRoleCommands IMergePatchUser.UserRoleCommands
        {
            get
            {
                return this._userRoles;
            }
        }

        public virtual CreateUserRoleDto NewCreateUserRole()
        {
            var c = new CreateUserRoleDto();
            c.UserId = this.UserId;

            return c;
        }

        ICreateUserRole ICreateUser.NewCreateUserRole()
        {
            return this.NewCreateUserRole();
        }

        ICreateUserRole IMergePatchUser.NewCreateUserRole()
        {
            return this.NewCreateUserRole();
        }

        public virtual MergePatchUserRoleDto NewMergePatchUserRole()
        {
            var c = new MergePatchUserRoleDto();
            c.UserId = this.UserId;

            return c;
        }

        IMergePatchUserRole IMergePatchUser.NewMergePatchUserRole()
        {
            return this.NewMergePatchUserRole();
        }

        public virtual RemoveUserRoleDto NewRemoveUserRole()
        {
            var c = new RemoveUserRoleDto();
            c.UserId = this.UserId;

            return c;
        }

        IRemoveUserRole IMergePatchUser.NewRemoveUserRole()
        {
            return this.NewRemoveUserRole();
        }

        private CreateOrMergePatchOrRemoveUserRoleDtos _userRoles = new CreateOrMergePatchOrRemoveUserRoleDtos();

        public virtual CreateOrMergePatchOrRemoveUserRoleDto[] UserRoles
        {
            get
            {
                return _userRoles.ToArray();
            }
            set
            {
                _userRoles.Clear();
                _userRoles.AddRange(value);
            }
        }

        ICreateUserClaimCommands ICreateUser.UserClaims
        {
            get
            {
                return this._userClaims;
            }
        }

        IUserClaimCommands IMergePatchUser.UserClaimCommands
        {
            get
            {
                return this._userClaims;
            }
        }

        public virtual CreateUserClaimDto NewCreateUserClaim()
        {
            var c = new CreateUserClaimDto();
            c.UserId = this.UserId;

            return c;
        }

        ICreateUserClaim ICreateUser.NewCreateUserClaim()
        {
            return this.NewCreateUserClaim();
        }

        ICreateUserClaim IMergePatchUser.NewCreateUserClaim()
        {
            return this.NewCreateUserClaim();
        }

        public virtual MergePatchUserClaimDto NewMergePatchUserClaim()
        {
            var c = new MergePatchUserClaimDto();
            c.UserId = this.UserId;

            return c;
        }

        IMergePatchUserClaim IMergePatchUser.NewMergePatchUserClaim()
        {
            return this.NewMergePatchUserClaim();
        }

        public virtual RemoveUserClaimDto NewRemoveUserClaim()
        {
            var c = new RemoveUserClaimDto();
            c.UserId = this.UserId;

            return c;
        }

        IRemoveUserClaim IMergePatchUser.NewRemoveUserClaim()
        {
            return this.NewRemoveUserClaim();
        }

        private CreateOrMergePatchOrRemoveUserClaimDtos _userClaims = new CreateOrMergePatchOrRemoveUserClaimDtos();

        public virtual CreateOrMergePatchOrRemoveUserClaimDto[] UserClaims
        {
            get
            {
                return _userClaims.ToArray();
            }
            set
            {
                _userClaims.Clear();
                _userClaims.AddRange(value);
            }
        }

        ICreateUserPermissionCommands ICreateUser.UserPermissions
        {
            get
            {
                return this._userPermissions;
            }
        }

        IUserPermissionCommands IMergePatchUser.UserPermissionCommands
        {
            get
            {
                return this._userPermissions;
            }
        }

        public virtual CreateUserPermissionDto NewCreateUserPermission()
        {
            var c = new CreateUserPermissionDto();
            c.UserId = this.UserId;

            return c;
        }

        ICreateUserPermission ICreateUser.NewCreateUserPermission()
        {
            return this.NewCreateUserPermission();
        }

        ICreateUserPermission IMergePatchUser.NewCreateUserPermission()
        {
            return this.NewCreateUserPermission();
        }

        public virtual MergePatchUserPermissionDto NewMergePatchUserPermission()
        {
            var c = new MergePatchUserPermissionDto();
            c.UserId = this.UserId;

            return c;
        }

        IMergePatchUserPermission IMergePatchUser.NewMergePatchUserPermission()
        {
            return this.NewMergePatchUserPermission();
        }

        public virtual RemoveUserPermissionDto NewRemoveUserPermission()
        {
            var c = new RemoveUserPermissionDto();
            c.UserId = this.UserId;

            return c;
        }

        IRemoveUserPermission IMergePatchUser.NewRemoveUserPermission()
        {
            return this.NewRemoveUserPermission();
        }

        private CreateOrMergePatchOrRemoveUserPermissionDtos _userPermissions = new CreateOrMergePatchOrRemoveUserPermissionDtos();

        public virtual CreateOrMergePatchOrRemoveUserPermissionDto[] UserPermissions
        {
            get
            {
                return _userPermissions.ToArray();
            }
            set
            {
                _userPermissions.Clear();
                _userPermissions.AddRange(value);
            }
        }

        ICreateUserLoginCommands ICreateUser.UserLogins
        {
            get
            {
                return this._userLogins;
            }
        }

        IUserLoginCommands IMergePatchUser.UserLoginCommands
        {
            get
            {
                return this._userLogins;
            }
        }

        public virtual CreateUserLoginDto NewCreateUserLogin()
        {
            var c = new CreateUserLoginDto();
            c.UserId = this.UserId;

            return c;
        }

        ICreateUserLogin ICreateUser.NewCreateUserLogin()
        {
            return this.NewCreateUserLogin();
        }

        ICreateUserLogin IMergePatchUser.NewCreateUserLogin()
        {
            return this.NewCreateUserLogin();
        }

        public virtual MergePatchUserLoginDto NewMergePatchUserLogin()
        {
            var c = new MergePatchUserLoginDto();
            c.UserId = this.UserId;

            return c;
        }

        IMergePatchUserLogin IMergePatchUser.NewMergePatchUserLogin()
        {
            return this.NewMergePatchUserLogin();
        }

        public virtual RemoveUserLoginDto NewRemoveUserLogin()
        {
            var c = new RemoveUserLoginDto();
            c.UserId = this.UserId;

            return c;
        }

        IRemoveUserLogin IMergePatchUser.NewRemoveUserLogin()
        {
            return this.NewRemoveUserLogin();
        }

        private CreateOrMergePatchOrRemoveUserLoginDtos _userLogins = new CreateOrMergePatchOrRemoveUserLoginDtos();

        public virtual CreateOrMergePatchOrRemoveUserLoginDto[] UserLogins
        {
            get
            {
                return _userLogins.ToArray();
            }
            set
            {
                _userLogins.Clear();
                _userLogins.AddRange(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteUserDto : UserCommandDtoBase
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



	public class CreateUserDto : CreateOrMergePatchOrDeleteUserDto
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


	public class MergePatchUserDto : CreateOrMergePatchOrDeleteUserDto
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

	public class DeleteUserDto : CreateOrMergePatchOrDeleteUserDto
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

    public static partial class UserCommandDtos
    {

    }

}

