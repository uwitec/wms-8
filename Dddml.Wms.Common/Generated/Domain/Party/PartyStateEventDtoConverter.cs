﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;

namespace Dddml.Wms.Domain.Party
{

    public class PartyStateEventDtoConverter
    {
        public virtual PartyStateCreatedOrMergePatchedOrDeletedDto ToPartyStateEventDto(IPartyStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IPartyStateCreated)stateEvent;
                return ToPartyStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IPartyStateMergePatched)stateEvent;
                return ToPartyStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IPartyStateDeleted)stateEvent;
                return ToPartyStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual PartyStateCreatedDto ToPartyStateCreatedDto(IPartyStateCreated e)
        {
            var dto = new PartyStateCreatedDto();
            dto.StateEventId = new PartyStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.PartyTypeId = e.PartyTypeId;
            dto.OrganizationName = e.OrganizationName;
            dto.Description = e.Description;
            dto.Type = e.Type;
            dto.IsSummary = e.IsSummary;
            dto.Active = e.Active;
            return dto;
        }

        public virtual PartyStateMergePatchedDto ToPartyStateMergePatchedDto(IPartyStateMergePatched e)
        {
            var dto = new PartyStateMergePatchedDto();
            dto.StateEventId = new PartyStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.PartyTypeId = e.PartyTypeId;
            dto.OrganizationName = e.OrganizationName;
            dto.Description = e.Description;
            dto.Type = e.Type;
            dto.IsSummary = e.IsSummary;
            dto.Active = e.Active;
            dto.IsPropertyPartyTypeIdRemoved = e.IsPropertyPartyTypeIdRemoved;
            dto.IsPropertyOrganizationNameRemoved = e.IsPropertyOrganizationNameRemoved;
            dto.IsPropertyDescriptionRemoved = e.IsPropertyDescriptionRemoved;
            dto.IsPropertyTypeRemoved = e.IsPropertyTypeRemoved;
            dto.IsPropertyIsSummaryRemoved = e.IsPropertyIsSummaryRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual PartyStateDeletedDto ToPartyStateDeletedDto(IPartyStateDeleted e)
        {
            var dto = new PartyStateDeletedDto();
            dto.StateEventId = new PartyStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}
