﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Picklist
{
	public interface IPicklistRoleEvent : IEvent, IEventDto, IGlobalIdentity<PicklistRoleEventId>, ICreated<string>
	{
		PicklistRoleEventId PicklistRoleEventId { get; }

        bool ReadOnly { get; set; }

		// Outer Id:
		//string PicklistId { get; set; }

	}

    public interface IPicklistRoleStateEvent : IPicklistRoleEvent
    {
		long Version { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IPicklistRoleStateCreated : IPicklistRoleStateEvent
	{
	
	}


	public interface IPicklistRoleStateMergePatched : IPicklistRoleStateEvent
	{
		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IPicklistRoleStateRemoved : IPicklistRoleStateEvent
	{
	}


}

