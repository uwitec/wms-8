﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserPermissionMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserPermissionMvo
{
	public interface IUserPermissionMvoStateEvent : IEvent, IStateEventDto, IGlobalIdentity<UserPermissionMvoEventId>, ICreated<string>
	{
		UserPermissionMvoEventId UserPermissionMvoEventId { get; }

        bool ReadOnly { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string UserUserName { get; set; }

		int? UserAccessFailedCount { get; set; }

		string UserEmail { get; set; }

		bool? UserEmailConfirmed { get; set; }

		bool? UserLockoutEnabled { get; set; }

		DateTime? UserLockoutEndDateUtc { get; set; }

		string UserPasswordHash { get; set; }

		string UserPhoneNumber { get; set; }

		bool? UserPhoneNumberConfirmed { get; set; }

		bool? UserTwoFactorEnabled { get; set; }

		string UserSecurityStamp { get; set; }

		string UserCreatedBy { get; set; }

		DateTime? UserCreatedAt { get; set; }

		string UserUpdatedBy { get; set; }

		DateTime? UserUpdatedAt { get; set; }

		bool? UserActive { get; set; }

		bool? UserDeleted { get; set; }

	}

	public interface IUserPermissionMvoStateCreated : IUserPermissionMvoStateEvent//, IUserPermissionMvoStateProperties
	{
	
	}


	public interface IUserPermissionMvoStateMergePatched : IUserPermissionMvoStateEvent//, IUserPermissionMvoStateProperties
	{
		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyUserUserNameRemoved { get; set; }

		bool IsPropertyUserAccessFailedCountRemoved { get; set; }

		bool IsPropertyUserEmailRemoved { get; set; }

		bool IsPropertyUserEmailConfirmedRemoved { get; set; }

		bool IsPropertyUserLockoutEnabledRemoved { get; set; }

		bool IsPropertyUserLockoutEndDateUtcRemoved { get; set; }

		bool IsPropertyUserPasswordHashRemoved { get; set; }

		bool IsPropertyUserPhoneNumberRemoved { get; set; }

		bool IsPropertyUserPhoneNumberConfirmedRemoved { get; set; }

		bool IsPropertyUserTwoFactorEnabledRemoved { get; set; }

		bool IsPropertyUserSecurityStampRemoved { get; set; }

		bool IsPropertyUserCreatedByRemoved { get; set; }

		bool IsPropertyUserCreatedAtRemoved { get; set; }

		bool IsPropertyUserUpdatedByRemoved { get; set; }

		bool IsPropertyUserUpdatedAtRemoved { get; set; }

		bool IsPropertyUserActiveRemoved { get; set; }

		bool IsPropertyUserDeletedRemoved { get; set; }


	}

	public interface IUserPermissionMvoStateDeleted : IUserPermissionMvoStateEvent
	{
	}


}

