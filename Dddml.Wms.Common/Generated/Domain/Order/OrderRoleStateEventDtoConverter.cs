﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

    public class OrderRoleStateEventDtoConverter
    {
        public virtual OrderRoleStateCreatedOrMergePatchedOrRemovedDto ToOrderRoleStateEventDto(IOrderRoleEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IOrderRoleStateCreated)stateEvent;
                return ToOrderRoleStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IOrderRoleStateMergePatched)stateEvent;
                return ToOrderRoleStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Removed)
            {
                var e = (IOrderRoleStateRemoved)stateEvent;
                return ToOrderRoleStateRemovedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual OrderRoleStateCreatedDto ToOrderRoleStateCreatedDto(IOrderRoleStateCreated e)
        {
            var dto = new OrderRoleStateCreatedDto();
            dto.OrderRoleEventId = e.OrderRoleEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            return dto;
        }

        public virtual OrderRoleStateMergePatchedDto ToOrderRoleStateMergePatchedDto(IOrderRoleStateMergePatched e)
        {
            var dto = new OrderRoleStateMergePatchedDto();
            dto.OrderRoleEventId = e.OrderRoleEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Active = e.Active;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual OrderRoleStateRemovedDto ToOrderRoleStateRemovedDto(IOrderRoleStateRemoved e)
        {
            var dto = new OrderRoleStateRemovedDto();
            dto.OrderRoleEventId = e.OrderRoleEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

