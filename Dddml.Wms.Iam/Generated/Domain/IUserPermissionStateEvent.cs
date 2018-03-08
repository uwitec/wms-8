﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{
	public interface IUserPermissionStateEvent : IEvent, IStateEventDto, IGlobalIdentity<UserPermissionEventId>, ICreated<string>
	{
		UserPermissionEventId UserPermissionEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string UserId { get; set; }

	}

	public interface IUserPermissionStateCreated : IUserPermissionStateEvent//, IUserPermissionStateProperties
	{
	
	}


	public interface IUserPermissionStateMergePatched : IUserPermissionStateEvent//, IUserPermissionStateProperties
	{
		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IUserPermissionStateRemoved : IUserPermissionStateEvent
	{
	}


}

