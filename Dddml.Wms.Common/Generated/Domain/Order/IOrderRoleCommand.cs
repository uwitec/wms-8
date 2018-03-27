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
	public interface IOrderRoleCommand : ICommand, ICommandDto
	{
		// Outer Id:

		string OrderId { get; set; }

		PartyRoleId PartyRoleId { get; set; }

	}


	public interface ICreateOrMergePatchOrRemoveOrderRole : IOrderRoleCommand
	{

		bool? Active { get; set; }


	}

	public interface ICreateOrderRole : ICreateOrMergePatchOrRemoveOrderRole
	{
	}

	public interface IMergePatchOrderRole : ICreateOrMergePatchOrRemoveOrderRole
	{

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveOrderRole : ICreateOrMergePatchOrRemoveOrderRole
	{
	}


}

