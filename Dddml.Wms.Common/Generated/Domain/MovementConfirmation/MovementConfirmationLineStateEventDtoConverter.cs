﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

    public class MovementConfirmationLineStateEventDtoConverter
    {
        public virtual MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto ToMovementConfirmationLineStateEventDto(IMovementConfirmationLineStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IMovementConfirmationLineStateCreated)stateEvent;
                return ToMovementConfirmationLineStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IMovementConfirmationLineStateMergePatched)stateEvent;
                return ToMovementConfirmationLineStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Removed)
            {
                var e = (IMovementConfirmationLineStateRemoved)stateEvent;
                return ToMovementConfirmationLineStateRemovedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual MovementConfirmationLineStateCreatedDto ToMovementConfirmationLineStateCreatedDto(IMovementConfirmationLineStateCreated e)
        {
            var dto = new MovementConfirmationLineStateCreatedDto();
            dto.StateEventId = new MovementConfirmationLineStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.MovementLineNumber = e.MovementLineNumber;
            dto.TargetQuantity = e.TargetQuantity;
            dto.ConfirmedQuantity = e.ConfirmedQuantity;
            dto.DifferenceQuantity = e.DifferenceQuantity;
            dto.ScrappedQuantity = e.ScrappedQuantity;
            dto.Description = e.Description;
            dto.Processed = e.Processed;
            dto.Active = e.Active;
            return dto;
        }

        public virtual MovementConfirmationLineStateMergePatchedDto ToMovementConfirmationLineStateMergePatchedDto(IMovementConfirmationLineStateMergePatched e)
        {
            var dto = new MovementConfirmationLineStateMergePatchedDto();
            dto.StateEventId = new MovementConfirmationLineStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.MovementLineNumber = e.MovementLineNumber;
            dto.TargetQuantity = e.TargetQuantity;
            dto.ConfirmedQuantity = e.ConfirmedQuantity;
            dto.DifferenceQuantity = e.DifferenceQuantity;
            dto.ScrappedQuantity = e.ScrappedQuantity;
            dto.Description = e.Description;
            dto.Processed = e.Processed;
            dto.Active = e.Active;
            dto.IsPropertyMovementLineNumberRemoved = e.IsPropertyMovementLineNumberRemoved;
            dto.IsPropertyTargetQuantityRemoved = e.IsPropertyTargetQuantityRemoved;
            dto.IsPropertyConfirmedQuantityRemoved = e.IsPropertyConfirmedQuantityRemoved;
            dto.IsPropertyDifferenceQuantityRemoved = e.IsPropertyDifferenceQuantityRemoved;
            dto.IsPropertyScrappedQuantityRemoved = e.IsPropertyScrappedQuantityRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyProcessedRemoved = e.IsPropertyProcessedRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual MovementConfirmationLineStateRemovedDto ToMovementConfirmationLineStateRemovedDto(IMovementConfirmationLineStateRemoved e)
        {
            var dto = new MovementConfirmationLineStateRemovedDto();
            dto.StateEventId = new MovementConfirmationLineStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}
