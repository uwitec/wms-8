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

	public static partial class UserClaimStateInterfaceExtensions
	{

        public static IUserClaimCommand ToCreateOrMergePatchUserClaim<TCreateUserClaim, TMergePatchUserClaim>(this IUserClaimState state)
            where TCreateUserClaim : ICreateUserClaim, new()
            where TMergePatchUserClaim : IMergePatchUserClaim, new()
        {
            bool bUnsaved = ((IUserClaimState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateUserClaim<TCreateUserClaim>();
            }
            else 
            {
                return state.ToMergePatchUserClaim<TMergePatchUserClaim>();
            }
        }

        public static TRemoveUserClaim ToRemoveUserClaim<TRemoveUserClaim>(this IUserClaimState state)
            where TRemoveUserClaim : IRemoveUserClaim, new()
        {
            var cmd = new TRemoveUserClaim();
            cmd.ClaimId = state.ClaimId;
            return cmd;
        }

        public static TMergePatchUserClaim ToMergePatchUserClaim<TMergePatchUserClaim>(this IUserClaimState state)
            where TMergePatchUserClaim : IMergePatchUserClaim, new()
        {
            var cmd = new TMergePatchUserClaim();

            cmd.ClaimId = state.ClaimId;
            cmd.ClaimType = state.ClaimType;
            cmd.ClaimValue = state.ClaimValue;
            cmd.Active = ((IUserClaimStateProperties)state).Active;
            cmd.UserId = state.UserId;
            
            if (state.ClaimType == null) { cmd.IsPropertyClaimTypeRemoved = true; }
            if (state.ClaimValue == null) { cmd.IsPropertyClaimValueRemoved = true; }
            return cmd;
        }

        public static TCreateUserClaim ToCreateUserClaim<TCreateUserClaim>(this IUserClaimState state)
            where TCreateUserClaim : ICreateUserClaim, new()
        {
            var cmd = new TCreateUserClaim();

            cmd.ClaimId = state.ClaimId;
            cmd.ClaimType = state.ClaimType;
            cmd.ClaimValue = state.ClaimValue;
            cmd.Active = ((IUserClaimStateProperties)state).Active;
            cmd.UserId = state.UserId;
            return cmd;
        }
		

	}

}

