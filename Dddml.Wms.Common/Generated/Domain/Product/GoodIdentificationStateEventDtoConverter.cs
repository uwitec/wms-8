﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.Product
{

    public class GoodIdentificationStateEventDtoConverter
    {
        public virtual GoodIdentificationStateCreatedOrMergePatchedOrRemovedDto ToGoodIdentificationStateEventDto(IGoodIdentificationEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IGoodIdentificationStateCreated)stateEvent;
                return ToGoodIdentificationStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IGoodIdentificationStateMergePatched)stateEvent;
                return ToGoodIdentificationStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Removed)
            {
                var e = (IGoodIdentificationStateRemoved)stateEvent;
                return ToGoodIdentificationStateRemovedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual GoodIdentificationStateCreatedDto ToGoodIdentificationStateCreatedDto(IGoodIdentificationStateCreated e)
        {
            var dto = new GoodIdentificationStateCreatedDto();
            dto.GoodIdentificationEventId = e.GoodIdentificationEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.IdValue = e.IdValue;
            dto.Active = e.Active;
            return dto;
        }

        public virtual GoodIdentificationStateMergePatchedDto ToGoodIdentificationStateMergePatchedDto(IGoodIdentificationStateMergePatched e)
        {
            var dto = new GoodIdentificationStateMergePatchedDto();
            dto.GoodIdentificationEventId = e.GoodIdentificationEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.IdValue = e.IdValue;
            dto.Active = e.Active;
            dto.IsPropertyIdValueRemoved = e.IsPropertyIdValueRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual GoodIdentificationStateRemovedDto ToGoodIdentificationStateRemovedDto(IGoodIdentificationStateRemoved e)
        {
            var dto = new GoodIdentificationStateRemovedDto();
            dto.GoodIdentificationEventId = e.GoodIdentificationEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}
