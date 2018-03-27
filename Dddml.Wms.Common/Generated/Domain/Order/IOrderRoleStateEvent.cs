﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{
	public interface IOrderRoleStateEvent : IEvent, IStateEventDto, IGlobalIdentity<OrderRoleEventId>, ICreated<string>
	{
		OrderRoleEventId OrderRoleEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string OrderId { get; set; }

	}

	public interface IOrderRoleStateCreated : IOrderRoleStateEvent//, IOrderRoleStateProperties
	{
	
	}


	public interface IOrderRoleStateMergePatched : IOrderRoleStateEvent//, IOrderRoleStateProperties
	{
		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IOrderRoleStateRemoved : IOrderRoleStateEvent
	{
	}


}

