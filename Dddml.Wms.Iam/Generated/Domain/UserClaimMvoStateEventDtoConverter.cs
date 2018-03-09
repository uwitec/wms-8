﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserClaimMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserClaimMvo
{

    public class UserClaimMvoStateEventDtoConverter
    {
        public virtual UserClaimMvoStateCreatedOrMergePatchedOrDeletedDto ToUserClaimMvoStateEventDto(IUserClaimMvoStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IUserClaimMvoStateCreated)stateEvent;
                return ToUserClaimMvoStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IUserClaimMvoStateMergePatched)stateEvent;
                return ToUserClaimMvoStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IUserClaimMvoStateDeleted)stateEvent;
                return ToUserClaimMvoStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual UserClaimMvoStateCreatedDto ToUserClaimMvoStateCreatedDto(IUserClaimMvoStateCreated e)
        {
            var dto = new UserClaimMvoStateCreatedDto();
            dto.UserClaimMvoEventId = e.UserClaimMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ClaimType = e.ClaimType;
            dto.ClaimValue = e.ClaimValue;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.UserUserName = e.UserUserName;
            dto.UserAccessFailedCount = e.UserAccessFailedCount;
            dto.UserEmail = e.UserEmail;
            dto.UserEmailConfirmed = e.UserEmailConfirmed;
            dto.UserLockoutEnabled = e.UserLockoutEnabled;
            dto.UserLockoutEndDateUtc = e.UserLockoutEndDateUtc;
            dto.UserPasswordHash = e.UserPasswordHash;
            dto.UserPhoneNumber = e.UserPhoneNumber;
            dto.UserPhoneNumberConfirmed = e.UserPhoneNumberConfirmed;
            dto.UserTwoFactorEnabled = e.UserTwoFactorEnabled;
            dto.UserSecurityStamp = e.UserSecurityStamp;
            dto.UserCreatedBy = e.UserCreatedBy;
            dto.UserCreatedAt = e.UserCreatedAt;
            dto.UserUpdatedBy = e.UserUpdatedBy;
            dto.UserUpdatedAt = e.UserUpdatedAt;
            dto.UserActive = e.UserActive;
            dto.UserDeleted = e.UserDeleted;
            return dto;
        }

        public virtual UserClaimMvoStateMergePatchedDto ToUserClaimMvoStateMergePatchedDto(IUserClaimMvoStateMergePatched e)
        {
            var dto = new UserClaimMvoStateMergePatchedDto();
            dto.UserClaimMvoEventId = e.UserClaimMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ClaimType = e.ClaimType;
            dto.ClaimValue = e.ClaimValue;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.UserUserName = e.UserUserName;
            dto.UserAccessFailedCount = e.UserAccessFailedCount;
            dto.UserEmail = e.UserEmail;
            dto.UserEmailConfirmed = e.UserEmailConfirmed;
            dto.UserLockoutEnabled = e.UserLockoutEnabled;
            dto.UserLockoutEndDateUtc = e.UserLockoutEndDateUtc;
            dto.UserPasswordHash = e.UserPasswordHash;
            dto.UserPhoneNumber = e.UserPhoneNumber;
            dto.UserPhoneNumberConfirmed = e.UserPhoneNumberConfirmed;
            dto.UserTwoFactorEnabled = e.UserTwoFactorEnabled;
            dto.UserSecurityStamp = e.UserSecurityStamp;
            dto.UserCreatedBy = e.UserCreatedBy;
            dto.UserCreatedAt = e.UserCreatedAt;
            dto.UserUpdatedBy = e.UserUpdatedBy;
            dto.UserUpdatedAt = e.UserUpdatedAt;
            dto.UserActive = e.UserActive;
            dto.UserDeleted = e.UserDeleted;
            dto.IsPropertyClaimTypeRemoved = e.IsPropertyClaimTypeRemoved;
            dto.IsPropertyClaimValueRemoved = e.IsPropertyClaimValueRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            dto.IsPropertyUserUserNameRemoved = e.IsPropertyUserUserNameRemoved;
            dto.IsPropertyUserAccessFailedCountRemoved = e.IsPropertyUserAccessFailedCountRemoved;
            dto.IsPropertyUserEmailRemoved = e.IsPropertyUserEmailRemoved;
            dto.IsPropertyUserEmailConfirmedRemoved = e.IsPropertyUserEmailConfirmedRemoved;
            dto.IsPropertyUserLockoutEnabledRemoved = e.IsPropertyUserLockoutEnabledRemoved;
            dto.IsPropertyUserLockoutEndDateUtcRemoved = e.IsPropertyUserLockoutEndDateUtcRemoved;
            dto.IsPropertyUserPasswordHashRemoved = e.IsPropertyUserPasswordHashRemoved;
            dto.IsPropertyUserPhoneNumberRemoved = e.IsPropertyUserPhoneNumberRemoved;
            dto.IsPropertyUserPhoneNumberConfirmedRemoved = e.IsPropertyUserPhoneNumberConfirmedRemoved;
            dto.IsPropertyUserTwoFactorEnabledRemoved = e.IsPropertyUserTwoFactorEnabledRemoved;
            dto.IsPropertyUserSecurityStampRemoved = e.IsPropertyUserSecurityStampRemoved;
            dto.IsPropertyUserCreatedByRemoved = e.IsPropertyUserCreatedByRemoved;
            dto.IsPropertyUserCreatedAtRemoved = e.IsPropertyUserCreatedAtRemoved;
            dto.IsPropertyUserUpdatedByRemoved = e.IsPropertyUserUpdatedByRemoved;
            dto.IsPropertyUserUpdatedAtRemoved = e.IsPropertyUserUpdatedAtRemoved;
            dto.IsPropertyUserActiveRemoved = e.IsPropertyUserActiveRemoved;
            dto.IsPropertyUserDeletedRemoved = e.IsPropertyUserDeletedRemoved;

            return dto;
        }


        public virtual UserClaimMvoStateDeletedDto ToUserClaimMvoStateDeletedDto(IUserClaimMvoStateDeleted e)
        {
            var dto = new UserClaimMvoStateDeletedDto();
            dto.UserClaimMvoEventId = e.UserClaimMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

