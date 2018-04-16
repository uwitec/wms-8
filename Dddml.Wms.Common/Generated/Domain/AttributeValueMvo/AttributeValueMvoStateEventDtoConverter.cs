﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.AttributeValueMvo
{

    public class AttributeValueMvoStateEventDtoConverter
    {
        public virtual AttributeValueMvoStateCreatedOrMergePatchedOrDeletedDto ToAttributeValueMvoStateEventDto(IAttributeValueMvoEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IAttributeValueMvoStateCreated)stateEvent;
                return ToAttributeValueMvoStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IAttributeValueMvoStateMergePatched)stateEvent;
                return ToAttributeValueMvoStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Deleted)
            {
                var e = (IAttributeValueMvoStateDeleted)stateEvent;
                return ToAttributeValueMvoStateDeletedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual AttributeValueMvoStateCreatedDto ToAttributeValueMvoStateCreatedDto(IAttributeValueMvoStateCreated e)
        {
            var dto = new AttributeValueMvoStateCreatedDto();
            dto.AttributeValueMvoEventId = e.AttributeValueMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.AttributeValueName = e.AttributeValueName;
            dto.Description = e.Description;
            dto.ReferenceId = e.ReferenceId;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.AttributeAttributeName = e.AttributeAttributeName;
            dto.AttributeOrganizationId = e.AttributeOrganizationId;
            dto.AttributeDescription = e.AttributeDescription;
            dto.AttributeIsMandatory = e.AttributeIsMandatory;
            dto.AttributeAttributeValueType = e.AttributeAttributeValueType;
            dto.AttributeAttributeValueLength = e.AttributeAttributeValueLength;
            dto.AttributeIsList = e.AttributeIsList;
            dto.AttributeFieldName = e.AttributeFieldName;
            dto.AttributeReferenceId = e.AttributeReferenceId;
            dto.AttributeCreatedBy = e.AttributeCreatedBy;
            dto.AttributeCreatedAt = e.AttributeCreatedAt;
            dto.AttributeUpdatedBy = e.AttributeUpdatedBy;
            dto.AttributeUpdatedAt = e.AttributeUpdatedAt;
            dto.AttributeActive = e.AttributeActive;
            dto.AttributeDeleted = e.AttributeDeleted;
            return dto;
        }

        public virtual AttributeValueMvoStateMergePatchedDto ToAttributeValueMvoStateMergePatchedDto(IAttributeValueMvoStateMergePatched e)
        {
            var dto = new AttributeValueMvoStateMergePatchedDto();
            dto.AttributeValueMvoEventId = e.AttributeValueMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.AttributeValueName = e.AttributeValueName;
            dto.Description = e.Description;
            dto.ReferenceId = e.ReferenceId;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.AttributeAttributeName = e.AttributeAttributeName;
            dto.AttributeOrganizationId = e.AttributeOrganizationId;
            dto.AttributeDescription = e.AttributeDescription;
            dto.AttributeIsMandatory = e.AttributeIsMandatory;
            dto.AttributeAttributeValueType = e.AttributeAttributeValueType;
            dto.AttributeAttributeValueLength = e.AttributeAttributeValueLength;
            dto.AttributeIsList = e.AttributeIsList;
            dto.AttributeFieldName = e.AttributeFieldName;
            dto.AttributeReferenceId = e.AttributeReferenceId;
            dto.AttributeCreatedBy = e.AttributeCreatedBy;
            dto.AttributeCreatedAt = e.AttributeCreatedAt;
            dto.AttributeUpdatedBy = e.AttributeUpdatedBy;
            dto.AttributeUpdatedAt = e.AttributeUpdatedAt;
            dto.AttributeActive = e.AttributeActive;
            dto.AttributeDeleted = e.AttributeDeleted;
            dto.IsPropertyAttributeValueNameRemoved = e.IsPropertyAttributeValueNameRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyReferenceIdRemoved = e.IsPropertyReferenceIdRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            dto.IsPropertyAttributeAttributeNameRemoved = e.IsPropertyAttributeAttributeNameRemoved;
            dto.IsPropertyAttributeOrganizationIdRemoved = e.IsPropertyAttributeOrganizationIdRemoved;
            dto.IsPropertyAttributeDescriptionRemoved = e.IsPropertyAttributeDescriptionRemoved;
            dto.IsPropertyAttributeIsMandatoryRemoved = e.IsPropertyAttributeIsMandatoryRemoved;
            dto.IsPropertyAttributeAttributeValueTypeRemoved = e.IsPropertyAttributeAttributeValueTypeRemoved;
            dto.IsPropertyAttributeAttributeValueLengthRemoved = e.IsPropertyAttributeAttributeValueLengthRemoved;
            dto.IsPropertyAttributeIsListRemoved = e.IsPropertyAttributeIsListRemoved;
            dto.IsPropertyAttributeFieldNameRemoved = e.IsPropertyAttributeFieldNameRemoved;
            dto.IsPropertyAttributeReferenceIdRemoved = e.IsPropertyAttributeReferenceIdRemoved;
            dto.IsPropertyAttributeCreatedByRemoved = e.IsPropertyAttributeCreatedByRemoved;
            dto.IsPropertyAttributeCreatedAtRemoved = e.IsPropertyAttributeCreatedAtRemoved;
            dto.IsPropertyAttributeUpdatedByRemoved = e.IsPropertyAttributeUpdatedByRemoved;
            dto.IsPropertyAttributeUpdatedAtRemoved = e.IsPropertyAttributeUpdatedAtRemoved;
            dto.IsPropertyAttributeActiveRemoved = e.IsPropertyAttributeActiveRemoved;
            dto.IsPropertyAttributeDeletedRemoved = e.IsPropertyAttributeDeletedRemoved;

            return dto;
        }


        public virtual AttributeValueMvoStateDeletedDto ToAttributeValueMvoStateDeletedDto(IAttributeValueMvoStateDeleted e)
        {
            var dto = new AttributeValueMvoStateDeletedDto();
            dto.AttributeValueMvoEventId = e.AttributeValueMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

