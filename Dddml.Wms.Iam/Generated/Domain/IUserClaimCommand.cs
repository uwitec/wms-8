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
	public interface IUserClaimCommand : ICommand, ICommandDto
	{
		// Outer Id:

		string UserId { get; set; }

		int ClaimId { get; set; }

	}


	public interface ICreateOrMergePatchOrRemoveUserClaim : IUserClaimCommand
	{

		string ClaimType { get; set; }

		string ClaimValue { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateUserClaim : ICreateOrMergePatchOrRemoveUserClaim
	{
	}

	public interface IMergePatchUserClaim : ICreateOrMergePatchOrRemoveUserClaim
	{

		bool IsPropertyClaimTypeRemoved { get; set; }

		bool IsPropertyClaimValueRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveUserClaim : ICreateOrMergePatchOrRemoveUserClaim
	{
	}


}

