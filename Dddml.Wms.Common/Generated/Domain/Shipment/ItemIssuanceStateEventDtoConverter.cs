﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

    public class ItemIssuanceStateEventDtoConverter
    {
        public virtual ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto ToItemIssuanceStateEventDto(IItemIssuanceStateEvent stateEvent)
        {
            if (stateEvent.StateEventType == StateEventType.Created)
            {
                var e = (IItemIssuanceStateCreated)stateEvent;
                return ToItemIssuanceStateCreatedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.MergePatched)
            {
                var e = (IItemIssuanceStateMergePatched)stateEvent;
                return ToItemIssuanceStateMergePatchedDto(e);
            }
            else if (stateEvent.StateEventType == StateEventType.Removed)
            {
                var e = (IItemIssuanceStateRemoved)stateEvent;
                return ToItemIssuanceStateRemovedDto(e);
            }
            throw DomainError.Named("invalidStateEventType", String.Format("Invalid state event type: {0}", stateEvent.StateEventType));
        }

        public virtual ItemIssuanceStateCreatedDto ToItemIssuanceStateCreatedDto(IItemIssuanceStateCreated e)
        {
            var dto = new ItemIssuanceStateCreatedDto();
            dto.ItemIssuanceEventId = e.ItemIssuanceEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.OrderId = e.OrderId;
            dto.OrderItemSeqId = e.OrderItemSeqId;
            dto.ShipGroupSeqId = e.ShipGroupSeqId;
            dto.ProductId = e.ProductId;
            dto.LocatorId = e.LocatorId;
            dto.AttributeSetInstanceId = e.AttributeSetInstanceId;
            dto.ShipmentItemSeqId = e.ShipmentItemSeqId;
            dto.FixedAssetId = e.FixedAssetId;
            dto.MaintHistSeqId = e.MaintHistSeqId;
            dto.IssuedDateTime = e.IssuedDateTime;
            dto.IssuedByUserLoginId = e.IssuedByUserLoginId;
            dto.Quantity = e.Quantity;
            dto.CancelQuantity = e.CancelQuantity;
            dto.Active = e.Active;
            return dto;
        }

        public virtual ItemIssuanceStateMergePatchedDto ToItemIssuanceStateMergePatchedDto(IItemIssuanceStateMergePatched e)
        {
            var dto = new ItemIssuanceStateMergePatchedDto();
            dto.ItemIssuanceEventId = e.ItemIssuanceEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;
            dto.OrderId = e.OrderId;
            dto.OrderItemSeqId = e.OrderItemSeqId;
            dto.ShipGroupSeqId = e.ShipGroupSeqId;
            dto.ProductId = e.ProductId;
            dto.LocatorId = e.LocatorId;
            dto.AttributeSetInstanceId = e.AttributeSetInstanceId;
            dto.ShipmentItemSeqId = e.ShipmentItemSeqId;
            dto.FixedAssetId = e.FixedAssetId;
            dto.MaintHistSeqId = e.MaintHistSeqId;
            dto.IssuedDateTime = e.IssuedDateTime;
            dto.IssuedByUserLoginId = e.IssuedByUserLoginId;
            dto.Quantity = e.Quantity;
            dto.CancelQuantity = e.CancelQuantity;
            dto.Active = e.Active;
            dto.IsPropertyOrderIdRemoved = e.IsPropertyOrderIdRemoved;
            dto.IsPropertyOrderItemSeqIdRemoved = e.IsPropertyOrderItemSeqIdRemoved;
            dto.IsPropertyShipGroupSeqIdRemoved = e.IsPropertyShipGroupSeqIdRemoved;
            dto.IsPropertyProductIdRemoved = e.IsPropertyProductIdRemoved;
            dto.IsPropertyLocatorIdRemoved = e.IsPropertyLocatorIdRemoved;
            dto.IsPropertyAttributeSetInstanceIdRemoved = e.IsPropertyAttributeSetInstanceIdRemoved;
            dto.IsPropertyShipmentItemSeqIdRemoved = e.IsPropertyShipmentItemSeqIdRemoved;
            dto.IsPropertyFixedAssetIdRemoved = e.IsPropertyFixedAssetIdRemoved;
            dto.IsPropertyMaintHistSeqIdRemoved = e.IsPropertyMaintHistSeqIdRemoved;
            dto.IsPropertyIssuedDateTimeRemoved = e.IsPropertyIssuedDateTimeRemoved;
            dto.IsPropertyIssuedByUserLoginIdRemoved = e.IsPropertyIssuedByUserLoginIdRemoved;
            dto.IsPropertyQuantityRemoved = e.IsPropertyQuantityRemoved;
            dto.IsPropertyCancelQuantityRemoved = e.IsPropertyCancelQuantityRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual ItemIssuanceStateRemovedDto ToItemIssuanceStateRemovedDto(IItemIssuanceStateRemoved e)
        {
            var dto = new ItemIssuanceStateRemovedDto();
            dto.ItemIssuanceEventId = e.ItemIssuanceEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.Version = e.Version;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}
