﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;

namespace Dddml.Wms.Domain.PhysicalInventoryLineMvo
{

    public class PhysicalInventoryLineMvoStateEventDtoConverter
    {
        public virtual PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto ToPhysicalInventoryLineMvoStateEventDto(IPhysicalInventoryLineMvoStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IPhysicalInventoryLineMvoStateCreated)stateEvent;
                return ToPhysicalInventoryLineMvoStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IPhysicalInventoryLineMvoStateMergePatched)stateEvent;
                return ToPhysicalInventoryLineMvoStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IPhysicalInventoryLineMvoStateDeleted)stateEvent;
                return ToPhysicalInventoryLineMvoStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual PhysicalInventoryLineMvoStateCreatedDto ToPhysicalInventoryLineMvoStateCreatedDto(IPhysicalInventoryLineMvoStateCreated e)
        {
            var dto = new PhysicalInventoryLineMvoStateCreatedDto();
            dto.PhysicalInventoryLineMvoEventId = e.PhysicalInventoryLineMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.BookQuantity = e.BookQuantity;
            dto.CountedQuantity = e.CountedQuantity;
            dto.Processed = e.Processed;
            dto.ReversalLineNumber = e.ReversalLineNumber;
            dto.Description = e.Description;
            dto.Version = e.Version;
            dto.PhysicalInventoryDocumentStatusId = e.PhysicalInventoryDocumentStatusId;
            dto.PhysicalInventoryWarehouseId = e.PhysicalInventoryWarehouseId;
            dto.PhysicalInventoryLocatorIdPattern = e.PhysicalInventoryLocatorIdPattern;
            dto.PhysicalInventoryProductIdPattern = e.PhysicalInventoryProductIdPattern;
            dto.PhysicalInventoryPosted = e.PhysicalInventoryPosted;
            dto.PhysicalInventoryProcessed = e.PhysicalInventoryProcessed;
            dto.PhysicalInventoryProcessing = e.PhysicalInventoryProcessing;
            dto.PhysicalInventoryDocumentTypeId = e.PhysicalInventoryDocumentTypeId;
            dto.PhysicalInventoryMovementDate = e.PhysicalInventoryMovementDate;
            dto.PhysicalInventoryDescription = e.PhysicalInventoryDescription;
            dto.PhysicalInventoryIsApproved = e.PhysicalInventoryIsApproved;
            dto.PhysicalInventoryApprovalAmount = e.PhysicalInventoryApprovalAmount;
            dto.PhysicalInventoryIsQuantityUpdated = e.PhysicalInventoryIsQuantityUpdated;
            dto.PhysicalInventoryReversalDocumentNumber = e.PhysicalInventoryReversalDocumentNumber;
            dto.PhysicalInventoryCreatedBy = e.PhysicalInventoryCreatedBy;
            dto.PhysicalInventoryCreatedAt = e.PhysicalInventoryCreatedAt;
            dto.PhysicalInventoryUpdatedBy = e.PhysicalInventoryUpdatedBy;
            dto.PhysicalInventoryUpdatedAt = e.PhysicalInventoryUpdatedAt;
            dto.PhysicalInventoryActive = e.PhysicalInventoryActive;
            return dto;
        }

        public virtual PhysicalInventoryLineMvoStateMergePatchedDto ToPhysicalInventoryLineMvoStateMergePatchedDto(IPhysicalInventoryLineMvoStateMergePatched e)
        {
            var dto = new PhysicalInventoryLineMvoStateMergePatchedDto();
            dto.PhysicalInventoryLineMvoEventId = e.PhysicalInventoryLineMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.BookQuantity = e.BookQuantity;
            dto.CountedQuantity = e.CountedQuantity;
            dto.Processed = e.Processed;
            dto.ReversalLineNumber = e.ReversalLineNumber;
            dto.Description = e.Description;
            dto.Version = e.Version;
            dto.PhysicalInventoryDocumentStatusId = e.PhysicalInventoryDocumentStatusId;
            dto.PhysicalInventoryWarehouseId = e.PhysicalInventoryWarehouseId;
            dto.PhysicalInventoryLocatorIdPattern = e.PhysicalInventoryLocatorIdPattern;
            dto.PhysicalInventoryProductIdPattern = e.PhysicalInventoryProductIdPattern;
            dto.PhysicalInventoryPosted = e.PhysicalInventoryPosted;
            dto.PhysicalInventoryProcessed = e.PhysicalInventoryProcessed;
            dto.PhysicalInventoryProcessing = e.PhysicalInventoryProcessing;
            dto.PhysicalInventoryDocumentTypeId = e.PhysicalInventoryDocumentTypeId;
            dto.PhysicalInventoryMovementDate = e.PhysicalInventoryMovementDate;
            dto.PhysicalInventoryDescription = e.PhysicalInventoryDescription;
            dto.PhysicalInventoryIsApproved = e.PhysicalInventoryIsApproved;
            dto.PhysicalInventoryApprovalAmount = e.PhysicalInventoryApprovalAmount;
            dto.PhysicalInventoryIsQuantityUpdated = e.PhysicalInventoryIsQuantityUpdated;
            dto.PhysicalInventoryReversalDocumentNumber = e.PhysicalInventoryReversalDocumentNumber;
            dto.PhysicalInventoryCreatedBy = e.PhysicalInventoryCreatedBy;
            dto.PhysicalInventoryCreatedAt = e.PhysicalInventoryCreatedAt;
            dto.PhysicalInventoryUpdatedBy = e.PhysicalInventoryUpdatedBy;
            dto.PhysicalInventoryUpdatedAt = e.PhysicalInventoryUpdatedAt;
            dto.PhysicalInventoryActive = e.PhysicalInventoryActive;
            dto.IsPropertyBookQuantityRemoved = e.IsPropertyBookQuantityRemoved;
            dto.IsPropertyCountedQuantityRemoved = e.IsPropertyCountedQuantityRemoved;
            dto.IsPropertyProcessedRemoved = e.IsPropertyProcessedRemoved;
            dto.IsPropertyReversalLineNumberRemoved = e.IsPropertyReversalLineNumberRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyPhysicalInventoryDocumentStatusIdRemoved = e.IsPropertyPhysicalInventoryDocumentStatusIdRemoved;
            dto.IsPropertyPhysicalInventoryWarehouseIdRemoved = e.IsPropertyPhysicalInventoryWarehouseIdRemoved;
            dto.IsPropertyPhysicalInventoryLocatorIdPatternRemoved = e.IsPropertyPhysicalInventoryLocatorIdPatternRemoved;
            dto.IsPropertyPhysicalInventoryProductIdPatternRemoved = e.IsPropertyPhysicalInventoryProductIdPatternRemoved;
            dto.IsPropertyPhysicalInventoryPostedRemoved = e.IsPropertyPhysicalInventoryPostedRemoved;
            dto.IsPropertyPhysicalInventoryProcessedRemoved = e.IsPropertyPhysicalInventoryProcessedRemoved;
            dto.IsPropertyPhysicalInventoryProcessingRemoved = e.IsPropertyPhysicalInventoryProcessingRemoved;
            dto.IsPropertyPhysicalInventoryDocumentTypeIdRemoved = e.IsPropertyPhysicalInventoryDocumentTypeIdRemoved;
            dto.IsPropertyPhysicalInventoryMovementDateRemoved = e.IsPropertyPhysicalInventoryMovementDateRemoved;
            dto.IsPropertyPhysicalInventoryDescriptionRemoved = e.IsPropertyPhysicalInventoryDescriptionRemoved;
            dto.IsPropertyPhysicalInventoryIsApprovedRemoved = e.IsPropertyPhysicalInventoryIsApprovedRemoved;
            dto.IsPropertyPhysicalInventoryApprovalAmountRemoved = e.IsPropertyPhysicalInventoryApprovalAmountRemoved;
            dto.IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved = e.IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved;
            dto.IsPropertyPhysicalInventoryReversalDocumentNumberRemoved = e.IsPropertyPhysicalInventoryReversalDocumentNumberRemoved;
            dto.IsPropertyPhysicalInventoryCreatedByRemoved = e.IsPropertyPhysicalInventoryCreatedByRemoved;
            dto.IsPropertyPhysicalInventoryCreatedAtRemoved = e.IsPropertyPhysicalInventoryCreatedAtRemoved;
            dto.IsPropertyPhysicalInventoryUpdatedByRemoved = e.IsPropertyPhysicalInventoryUpdatedByRemoved;
            dto.IsPropertyPhysicalInventoryUpdatedAtRemoved = e.IsPropertyPhysicalInventoryUpdatedAtRemoved;
            dto.IsPropertyPhysicalInventoryActiveRemoved = e.IsPropertyPhysicalInventoryActiveRemoved;

            return dto;
        }


        public virtual PhysicalInventoryLineMvoStateDeletedDto ToPhysicalInventoryLineMvoStateDeletedDto(IPhysicalInventoryLineMvoStateDeleted e)
        {
            var dto = new PhysicalInventoryLineMvoStateDeletedDto();
            dto.PhysicalInventoryLineMvoEventId = e.PhysicalInventoryLineMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

