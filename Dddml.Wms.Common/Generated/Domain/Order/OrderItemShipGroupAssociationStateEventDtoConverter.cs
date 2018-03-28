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

    public class OrderItemShipGroupAssociationStateEventDtoConverter
    {
        public virtual OrderItemShipGroupAssociationStateCreatedOrMergePatchedOrRemovedDto ToOrderItemShipGroupAssociationStateEventDto(IOrderItemShipGroupAssociationStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IOrderItemShipGroupAssociationStateCreated)stateEvent;
                return ToOrderItemShipGroupAssociationStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IOrderItemShipGroupAssociationStateMergePatched)stateEvent;
                return ToOrderItemShipGroupAssociationStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Removed)
            {
                var e = (IOrderItemShipGroupAssociationStateRemoved)stateEvent;
                return ToOrderItemShipGroupAssociationStateRemovedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual OrderItemShipGroupAssociationStateCreatedDto ToOrderItemShipGroupAssociationStateCreatedDto(IOrderItemShipGroupAssociationStateCreated e)
        {
            var dto = new OrderItemShipGroupAssociationStateCreatedDto();
            dto.OrderItemShipGroupAssociationEventId = e.OrderItemShipGroupAssociationEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Quantity = e.Quantity;
            dto.CancelQuantity = e.CancelQuantity;
            dto.Active = e.Active;
            return dto;
        }

        public virtual OrderItemShipGroupAssociationStateMergePatchedDto ToOrderItemShipGroupAssociationStateMergePatchedDto(IOrderItemShipGroupAssociationStateMergePatched e)
        {
            var dto = new OrderItemShipGroupAssociationStateMergePatchedDto();
            dto.OrderItemShipGroupAssociationEventId = e.OrderItemShipGroupAssociationEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Quantity = e.Quantity;
            dto.CancelQuantity = e.CancelQuantity;
            dto.Active = e.Active;
            dto.IsPropertyQuantityRemoved = e.IsPropertyQuantityRemoved;
            dto.IsPropertyCancelQuantityRemoved = e.IsPropertyCancelQuantityRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual OrderItemShipGroupAssociationStateRemovedDto ToOrderItemShipGroupAssociationStateRemovedDto(IOrderItemShipGroupAssociationStateRemoved e)
        {
            var dto = new OrderItemShipGroupAssociationStateRemovedDto();
            dto.OrderItemShipGroupAssociationEventId = e.OrderItemShipGroupAssociationEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

