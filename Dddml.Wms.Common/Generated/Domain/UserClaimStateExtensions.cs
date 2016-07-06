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

	public static partial class UserClaimStateExtensions
	{

        public static IUserClaimCommand ToCreateOrMergePatchUserClaim(this UserClaimState state)
        {
            return state.ToCreateOrMergePatchUserClaim<CreateUserClaim, MergePatchUserClaim>();
        }

        public static RemoveUserClaim ToRemoveUserClaim(this UserClaimState state)
        {
            return state.ToRemoveUserClaim<RemoveUserClaim>();
        }

        public static MergePatchUserClaim ToMergePatchUserClaim(this UserClaimState state)
        {
            return state.ToMergePatchUserClaim<MergePatchUserClaim>();
        }

        public static CreateUserClaim ToCreateUserClaim(this UserClaimState state)
        {
            return state.ToCreateUserClaim<CreateUserClaim>();
        }
		

	}

}

