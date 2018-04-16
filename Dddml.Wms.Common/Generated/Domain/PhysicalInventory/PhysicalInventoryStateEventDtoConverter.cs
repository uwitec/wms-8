﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{

    public class PhysicalInventoryStateEventDtoConverter
    {
        public virtual PhysicalInventoryStateCreatedOrMergePatchedOrDeletedDto ToPhysicalInventoryStateEventDto(IPhysicalInventoryEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IPhysicalInventoryStateCreated)stateEvent;
                return ToPhysicalInventoryStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IPhysicalInventoryStateMergePatched)stateEvent;
                return ToPhysicalInventoryStateMergePatchedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual PhysicalInventoryStateCreatedDto ToPhysicalInventoryStateCreatedDto(IPhysicalInventoryStateCreated e)
        {
            var dto = new PhysicalInventoryStateCreatedDto();
            dto.PhysicalInventoryEventId = e.PhysicalInventoryEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.DocumentStatusId = e.DocumentStatusId;
            dto.WarehouseId = e.WarehouseId;
            dto.LocatorIdPattern = e.LocatorIdPattern;
            dto.ProductIdPattern = e.ProductIdPattern;
            dto.Posted = e.Posted;
            dto.Processed = e.Processed;
            dto.Processing = e.Processing;
            dto.DocumentTypeId = e.DocumentTypeId;
            dto.MovementDate = e.MovementDate;
            dto.Description = e.Description;
            dto.IsApproved = e.IsApproved;
            dto.ApprovalAmount = e.ApprovalAmount;
            dto.IsQuantityUpdated = e.IsQuantityUpdated;
            dto.ReversalDocumentNumber = e.ReversalDocumentNumber;
            dto.Active = e.Active;
            var physicalInventoryLineEvents = new List<PhysicalInventoryLineStateCreatedDto>();
            foreach (var ee in e.PhysicalInventoryLineEvents)
            {
                PhysicalInventoryLineStateCreatedDto eeDto = PhysicalInventoryLineStateEventDtoConverter.ToPhysicalInventoryLineStateCreatedDto(ee);
                physicalInventoryLineEvents.Add(eeDto);
            }
            dto.PhysicalInventoryLineEvents = physicalInventoryLineEvents.ToArray();

            return dto;
        }

        public virtual PhysicalInventoryStateMergePatchedDto ToPhysicalInventoryStateMergePatchedDto(IPhysicalInventoryStateMergePatched e)
        {
            var dto = new PhysicalInventoryStateMergePatchedDto();
            dto.PhysicalInventoryEventId = e.PhysicalInventoryEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.DocumentStatusId = e.DocumentStatusId;
            dto.WarehouseId = e.WarehouseId;
            dto.LocatorIdPattern = e.LocatorIdPattern;
            dto.ProductIdPattern = e.ProductIdPattern;
            dto.Posted = e.Posted;
            dto.Processed = e.Processed;
            dto.Processing = e.Processing;
            dto.DocumentTypeId = e.DocumentTypeId;
            dto.MovementDate = e.MovementDate;
            dto.Description = e.Description;
            dto.IsApproved = e.IsApproved;
            dto.ApprovalAmount = e.ApprovalAmount;
            dto.IsQuantityUpdated = e.IsQuantityUpdated;
            dto.ReversalDocumentNumber = e.ReversalDocumentNumber;
            dto.Active = e.Active;
            dto.IsPropertyDocumentStatusIdRemoved = e.IsPropertyDocumentStatusIdRemoved;
            dto.IsPropertyWarehouseIdRemoved = e.IsPropertyWarehouseIdRemoved;
            dto.IsPropertyLocatorIdPatternRemoved = e.IsPropertyLocatorIdPatternRemoved;
            dto.IsPropertyProductIdPatternRemoved = e.IsPropertyProductIdPatternRemoved;
            dto.IsPropertyPostedRemoved = e.IsPropertyPostedRemoved;
            dto.IsPropertyProcessedRemoved = e.IsPropertyProcessedRemoved;
            dto.IsPropertyProcessingRemoved = e.IsPropertyProcessingRemoved;
            dto.IsPropertyDocumentTypeIdRemoved = e.IsPropertyDocumentTypeIdRemoved;
            dto.IsPropertyMovementDateRemoved = e.IsPropertyMovementDateRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyIsApprovedRemoved = e.IsPropertyIsApprovedRemoved;
            dto.IsPropertyApprovalAmountRemoved = e.IsPropertyApprovalAmountRemoved;
            dto.IsPropertyIsQuantityUpdatedRemoved = e.IsPropertyIsQuantityUpdatedRemoved;
            dto.IsPropertyReversalDocumentNumberRemoved = e.IsPropertyReversalDocumentNumberRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            var physicalInventoryLineEvents = new List<PhysicalInventoryLineStateCreatedOrMergePatchedOrRemovedDto>();
            foreach (var ee in e.PhysicalInventoryLineEvents)
            {
                PhysicalInventoryLineStateCreatedOrMergePatchedOrRemovedDto eeDto = PhysicalInventoryLineStateEventDtoConverter.ToPhysicalInventoryLineStateEventDto(ee);
                physicalInventoryLineEvents.Add(eeDto);
            }
            dto.PhysicalInventoryLineEvents = physicalInventoryLineEvents.ToArray();


            return dto;
        }


        protected virtual PhysicalInventoryLineStateEventDtoConverter PhysicalInventoryLineStateEventDtoConverter
        {
            get
            {
                return new PhysicalInventoryLineStateEventDtoConverter();
            }
        }


    }


}

