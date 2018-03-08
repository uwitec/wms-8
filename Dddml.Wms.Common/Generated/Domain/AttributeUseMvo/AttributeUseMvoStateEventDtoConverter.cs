﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeUseMvo
{

    public class AttributeUseMvoStateEventDtoConverter
    {
        public virtual AttributeUseMvoStateCreatedOrMergePatchedOrDeletedDto ToAttributeUseMvoStateEventDto(IAttributeUseMvoStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IAttributeUseMvoStateCreated)stateEvent;
                return ToAttributeUseMvoStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IAttributeUseMvoStateMergePatched)stateEvent;
                return ToAttributeUseMvoStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IAttributeUseMvoStateDeleted)stateEvent;
                return ToAttributeUseMvoStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual AttributeUseMvoStateCreatedDto ToAttributeUseMvoStateCreatedDto(IAttributeUseMvoStateCreated e)
        {
            var dto = new AttributeUseMvoStateCreatedDto();
            dto.AttributeUseMvoEventId = new AttributeUseMvoEventIdDtoWrapper(e.AttributeUseMvoEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.SequenceNumber = e.SequenceNumber;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.AttributeSetAttributeSetName = e.AttributeSetAttributeSetName;
            dto.AttributeSetOrganizationId = e.AttributeSetOrganizationId;
            dto.AttributeSetDescription = e.AttributeSetDescription;
            dto.AttributeSetReferenceId = e.AttributeSetReferenceId;
            dto.AttributeSetIsInstanceAttributeSet = e.AttributeSetIsInstanceAttributeSet;
            dto.AttributeSetIsMandatory = e.AttributeSetIsMandatory;
            dto.AttributeSetCreatedBy = e.AttributeSetCreatedBy;
            dto.AttributeSetCreatedAt = e.AttributeSetCreatedAt;
            dto.AttributeSetUpdatedBy = e.AttributeSetUpdatedBy;
            dto.AttributeSetUpdatedAt = e.AttributeSetUpdatedAt;
            dto.AttributeSetActive = e.AttributeSetActive;
            dto.AttributeSetDeleted = e.AttributeSetDeleted;
            return dto;
        }

        public virtual AttributeUseMvoStateMergePatchedDto ToAttributeUseMvoStateMergePatchedDto(IAttributeUseMvoStateMergePatched e)
        {
            var dto = new AttributeUseMvoStateMergePatchedDto();
            dto.AttributeUseMvoEventId = new AttributeUseMvoEventIdDtoWrapper(e.AttributeUseMvoEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.SequenceNumber = e.SequenceNumber;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.AttributeSetAttributeSetName = e.AttributeSetAttributeSetName;
            dto.AttributeSetOrganizationId = e.AttributeSetOrganizationId;
            dto.AttributeSetDescription = e.AttributeSetDescription;
            dto.AttributeSetReferenceId = e.AttributeSetReferenceId;
            dto.AttributeSetIsInstanceAttributeSet = e.AttributeSetIsInstanceAttributeSet;
            dto.AttributeSetIsMandatory = e.AttributeSetIsMandatory;
            dto.AttributeSetCreatedBy = e.AttributeSetCreatedBy;
            dto.AttributeSetCreatedAt = e.AttributeSetCreatedAt;
            dto.AttributeSetUpdatedBy = e.AttributeSetUpdatedBy;
            dto.AttributeSetUpdatedAt = e.AttributeSetUpdatedAt;
            dto.AttributeSetActive = e.AttributeSetActive;
            dto.AttributeSetDeleted = e.AttributeSetDeleted;
            dto.IsPropertySequenceNumberRemoved = e.IsPropertySequenceNumberRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            dto.IsPropertyAttributeSetAttributeSetNameRemoved = e.IsPropertyAttributeSetAttributeSetNameRemoved;
            dto.IsPropertyAttributeSetOrganizationIdRemoved = e.IsPropertyAttributeSetOrganizationIdRemoved;
            dto.IsPropertyAttributeSetDescriptionRemoved = e.IsPropertyAttributeSetDescriptionRemoved;
            dto.IsPropertyAttributeSetReferenceIdRemoved = e.IsPropertyAttributeSetReferenceIdRemoved;
            dto.IsPropertyAttributeSetIsInstanceAttributeSetRemoved = e.IsPropertyAttributeSetIsInstanceAttributeSetRemoved;
            dto.IsPropertyAttributeSetIsMandatoryRemoved = e.IsPropertyAttributeSetIsMandatoryRemoved;
            dto.IsPropertyAttributeSetCreatedByRemoved = e.IsPropertyAttributeSetCreatedByRemoved;
            dto.IsPropertyAttributeSetCreatedAtRemoved = e.IsPropertyAttributeSetCreatedAtRemoved;
            dto.IsPropertyAttributeSetUpdatedByRemoved = e.IsPropertyAttributeSetUpdatedByRemoved;
            dto.IsPropertyAttributeSetUpdatedAtRemoved = e.IsPropertyAttributeSetUpdatedAtRemoved;
            dto.IsPropertyAttributeSetActiveRemoved = e.IsPropertyAttributeSetActiveRemoved;
            dto.IsPropertyAttributeSetDeletedRemoved = e.IsPropertyAttributeSetDeletedRemoved;

            return dto;
        }


        public virtual AttributeUseMvoStateDeletedDto ToAttributeUseMvoStateDeletedDto(IAttributeUseMvoStateDeleted e)
        {
            var dto = new AttributeUseMvoStateDeletedDto();
            dto.AttributeUseMvoEventId = new AttributeUseMvoEventIdDtoWrapper(e.AttributeUseMvoEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

