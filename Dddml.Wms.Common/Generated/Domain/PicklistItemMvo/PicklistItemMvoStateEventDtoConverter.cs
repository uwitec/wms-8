﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistItemMvo;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistItemMvo
{

    public class PicklistItemMvoStateEventDtoConverter
    {
        public virtual PicklistItemMvoStateCreatedOrMergePatchedOrDeletedDto ToPicklistItemMvoStateEventDto(IPicklistItemMvoStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IPicklistItemMvoStateCreated)stateEvent;
                return ToPicklistItemMvoStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IPicklistItemMvoStateMergePatched)stateEvent;
                return ToPicklistItemMvoStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Deleted)
            {
                var e = (IPicklistItemMvoStateDeleted)stateEvent;
                return ToPicklistItemMvoStateDeletedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual PicklistItemMvoStateCreatedDto ToPicklistItemMvoStateCreatedDto(IPicklistItemMvoStateCreated e)
        {
            var dto = new PicklistItemMvoStateCreatedDto();
            dto.PicklistItemMvoEventId = e.PicklistItemMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ItemStatusId = e.ItemStatusId;
            dto.Quantity = e.Quantity;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.PicklistBinPicklistId = e.PicklistBinPicklistId;
            dto.PicklistBinBinLocationNumber = e.PicklistBinBinLocationNumber;
            dto.PicklistBinPrimaryOrderId = e.PicklistBinPrimaryOrderId;
            dto.PicklistBinPrimaryShipGroupSeqId = e.PicklistBinPrimaryShipGroupSeqId;
            dto.PicklistBinCreatedBy = e.PicklistBinCreatedBy;
            dto.PicklistBinCreatedAt = e.PicklistBinCreatedAt;
            dto.PicklistBinUpdatedBy = e.PicklistBinUpdatedBy;
            dto.PicklistBinUpdatedAt = e.PicklistBinUpdatedAt;
            dto.PicklistBinActive = e.PicklistBinActive;
            dto.PicklistBinDeleted = e.PicklistBinDeleted;
            return dto;
        }

        public virtual PicklistItemMvoStateMergePatchedDto ToPicklistItemMvoStateMergePatchedDto(IPicklistItemMvoStateMergePatched e)
        {
            var dto = new PicklistItemMvoStateMergePatchedDto();
            dto.PicklistItemMvoEventId = e.PicklistItemMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ItemStatusId = e.ItemStatusId;
            dto.Quantity = e.Quantity;
            dto.Version = e.Version;
            dto.Active = e.Active;
            dto.PicklistBinPicklistId = e.PicklistBinPicklistId;
            dto.PicklistBinBinLocationNumber = e.PicklistBinBinLocationNumber;
            dto.PicklistBinPrimaryOrderId = e.PicklistBinPrimaryOrderId;
            dto.PicklistBinPrimaryShipGroupSeqId = e.PicklistBinPrimaryShipGroupSeqId;
            dto.PicklistBinCreatedBy = e.PicklistBinCreatedBy;
            dto.PicklistBinCreatedAt = e.PicklistBinCreatedAt;
            dto.PicklistBinUpdatedBy = e.PicklistBinUpdatedBy;
            dto.PicklistBinUpdatedAt = e.PicklistBinUpdatedAt;
            dto.PicklistBinActive = e.PicklistBinActive;
            dto.PicklistBinDeleted = e.PicklistBinDeleted;
            dto.IsPropertyItemStatusIdRemoved = e.IsPropertyItemStatusIdRemoved;
            dto.IsPropertyQuantityRemoved = e.IsPropertyQuantityRemoved;
            dto.IsPropertyVersionRemoved = e.IsPropertyVersionRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;
            dto.IsPropertyPicklistBinPicklistIdRemoved = e.IsPropertyPicklistBinPicklistIdRemoved;
            dto.IsPropertyPicklistBinBinLocationNumberRemoved = e.IsPropertyPicklistBinBinLocationNumberRemoved;
            dto.IsPropertyPicklistBinPrimaryOrderIdRemoved = e.IsPropertyPicklistBinPrimaryOrderIdRemoved;
            dto.IsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved = e.IsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved;
            dto.IsPropertyPicklistBinCreatedByRemoved = e.IsPropertyPicklistBinCreatedByRemoved;
            dto.IsPropertyPicklistBinCreatedAtRemoved = e.IsPropertyPicklistBinCreatedAtRemoved;
            dto.IsPropertyPicklistBinUpdatedByRemoved = e.IsPropertyPicklistBinUpdatedByRemoved;
            dto.IsPropertyPicklistBinUpdatedAtRemoved = e.IsPropertyPicklistBinUpdatedAtRemoved;
            dto.IsPropertyPicklistBinActiveRemoved = e.IsPropertyPicklistBinActiveRemoved;
            dto.IsPropertyPicklistBinDeletedRemoved = e.IsPropertyPicklistBinDeletedRemoved;

            return dto;
        }


        public virtual PicklistItemMvoStateDeletedDto ToPicklistItemMvoStateDeletedDto(IPicklistItemMvoStateDeleted e)
        {
            var dto = new PicklistItemMvoStateDeletedDto();
            dto.PicklistItemMvoEventId = e.PicklistItemMvoEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

