﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

    public class InOutLineImageStateEventDtoConverter
    {
        public virtual InOutLineImageStateCreatedOrMergePatchedOrRemovedDto ToInOutLineImageStateEventDto(IInOutLineImageEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IInOutLineImageStateCreated)stateEvent;
                return ToInOutLineImageStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IInOutLineImageStateMergePatched)stateEvent;
                return ToInOutLineImageStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Removed)
            {
                var e = (IInOutLineImageStateRemoved)stateEvent;
                return ToInOutLineImageStateRemovedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual InOutLineImageStateCreatedDto ToInOutLineImageStateCreatedDto(IInOutLineImageStateCreated e)
        {
            var dto = new InOutLineImageStateCreatedDto();
            dto.InOutLineImageEventId = e.InOutLineImageEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Url = e.Url;
            dto.Active = e.Active;
            return dto;
        }

        public virtual InOutLineImageStateMergePatchedDto ToInOutLineImageStateMergePatchedDto(IInOutLineImageStateMergePatched e)
        {
            var dto = new InOutLineImageStateMergePatchedDto();
            dto.InOutLineImageEventId = e.InOutLineImageEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.Url = e.Url;
            dto.Active = e.Active;
            dto.IsPropertyUrlRemoved = e.IsPropertyUrlRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual InOutLineImageStateRemovedDto ToInOutLineImageStateRemovedDto(IInOutLineImageStateRemoved e)
        {
            var dto = new InOutLineImageStateRemovedDto();
            dto.InOutLineImageEventId = e.InOutLineImageEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}
