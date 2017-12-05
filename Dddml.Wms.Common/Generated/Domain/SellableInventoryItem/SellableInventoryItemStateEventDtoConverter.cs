﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItem
{

    public class SellableInventoryItemStateEventDtoConverter
    {
        public virtual SellableInventoryItemStateCreatedOrMergePatchedOrDeletedDto ToSellableInventoryItemStateEventDto(ISellableInventoryItemStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (ISellableInventoryItemStateCreated)stateEvent;
                return ToSellableInventoryItemStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (ISellableInventoryItemStateMergePatched)stateEvent;
                return ToSellableInventoryItemStateMergePatchedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual SellableInventoryItemStateCreatedDto ToSellableInventoryItemStateCreatedDto(ISellableInventoryItemStateCreated e)
        {
            var dto = new SellableInventoryItemStateCreatedDto();
            dto.StateEventId = new SellableInventoryItemStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.QuantitySellable = e.QuantitySellable;
            var sellableInventoryItemEntryEvents = new List<SellableInventoryItemEntryStateCreatedDto>();
            foreach (var ee in e.SellableInventoryItemEntryEvents)
            {
                SellableInventoryItemEntryStateCreatedDto eeDto = SellableInventoryItemEntryStateEventDtoConverter.ToSellableInventoryItemEntryStateCreatedDto(ee);
                sellableInventoryItemEntryEvents.Add(eeDto);
            }
            dto.SellableInventoryItemEntryEvents = sellableInventoryItemEntryEvents.ToArray();

            return dto;
        }

        public virtual SellableInventoryItemStateMergePatchedDto ToSellableInventoryItemStateMergePatchedDto(ISellableInventoryItemStateMergePatched e)
        {
            var dto = new SellableInventoryItemStateMergePatchedDto();
            dto.StateEventId = new SellableInventoryItemStateEventIdDtoWrapper(e.StateEventId);
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.QuantitySellable = e.QuantitySellable;
            dto.IsPropertyQuantitySellableRemoved = e.IsPropertyQuantitySellableRemoved;
            var sellableInventoryItemEntryEvents = new List<SellableInventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto>();
            foreach (var ee in e.SellableInventoryItemEntryEvents)
            {
                SellableInventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto eeDto = SellableInventoryItemEntryStateEventDtoConverter.ToSellableInventoryItemEntryStateEventDto(ee);
                sellableInventoryItemEntryEvents.Add(eeDto);
            }
            dto.SellableInventoryItemEntryEvents = sellableInventoryItemEntryEvents.ToArray();


            return dto;
        }


        protected virtual SellableInventoryItemEntryStateEventDtoConverter SellableInventoryItemEntryStateEventDtoConverter
        {
            get
            {
                return new SellableInventoryItemEntryStateEventDtoConverter();
            }
        }


    }


}
