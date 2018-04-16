﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRoleTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RoleType;

namespace Dddml.Wms.Domain.RoleType
{

    public class RoleTypeStateEventDtoConverter
    {
        public virtual RoleTypeStateCreatedOrMergePatchedOrDeletedDto ToRoleTypeStateEventDto(IRoleTypeEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IRoleTypeStateCreated)stateEvent;
                return ToRoleTypeStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IRoleTypeStateMergePatched)stateEvent;
                return ToRoleTypeStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Deleted)
            {
                var e = (IRoleTypeStateDeleted)stateEvent;
                return ToRoleTypeStateDeletedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual RoleTypeStateCreatedDto ToRoleTypeStateCreatedDto(IRoleTypeStateCreated e)
        {
            var dto = new RoleTypeStateCreatedDto();
            dto.RoleTypeEventId = e.RoleTypeEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ParentTypeId = e.ParentTypeId;
            dto.HasTable = e.HasTable;
            dto.Description = e.Description;
            dto.Active = e.Active;
            return dto;
        }

        public virtual RoleTypeStateMergePatchedDto ToRoleTypeStateMergePatchedDto(IRoleTypeStateMergePatched e)
        {
            var dto = new RoleTypeStateMergePatchedDto();
            dto.RoleTypeEventId = e.RoleTypeEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ParentTypeId = e.ParentTypeId;
            dto.HasTable = e.HasTable;
            dto.Description = e.Description;
            dto.Active = e.Active;
            dto.IsPropertyParentTypeIdRemoved = e.IsPropertyParentTypeIdRemoved;
            dto.IsPropertyHasTableRemoved = e.IsPropertyHasTableRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual RoleTypeStateDeletedDto ToRoleTypeStateDeletedDto(IRoleTypeStateDeleted e)
        {
            var dto = new RoleTypeStateDeletedDto();
            dto.RoleTypeEventId = e.RoleTypeEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

