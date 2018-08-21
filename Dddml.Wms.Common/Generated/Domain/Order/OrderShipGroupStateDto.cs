﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

    public partial class OrderShipGroupStateDto : IOrderShipGroupStateDto
    {
        public virtual long? ShipGroupSeqId
        {
            get;
            set;
        }

        public virtual string ShipmentMethodTypeId
        {
            get;
            set;
        }

        public virtual string SupplierPartyId
        {
            get;
            set;
        }

        public virtual string VendorPartyId
        {
            get;
            set;
        }

        public virtual string CarrierPartyId
        {
            get;
            set;
        }

        public virtual string CarrierRoleTypeId
        {
            get;
            set;
        }

        public virtual string FacilityId
        {
            get;
            set;
        }

        public virtual string ContactMechId
        {
            get;
            set;
        }

        public virtual string TelecomContactMechId
        {
            get;
            set;
        }

        public virtual string TrackingNumber
        {
            get;
            set;
        }

        public virtual string ContactPartyId
        {
            get;
            set;
        }

        public virtual string VehiclePlateNumber
        {
            get;
            set;
        }

        public virtual string ShippingInstructions
        {
            get;
            set;
        }

        public virtual string MaySplit
        {
            get;
            set;
        }

        public virtual string GiftMessage
        {
            get;
            set;
        }

        public virtual string IsGift
        {
            get;
            set;
        }

        public virtual DateTime? ShipAfterDate
        {
            get;
            set;
        }

        public virtual DateTime? ShipByDate
        {
            get;
            set;
        }

        public virtual DateTime? EstimatedShipDate
        {
            get;
            set;
        }

        public virtual DateTime? EstimatedDeliveryDate
        {
            get;
            set;
        }

        public virtual long? PickwaveId
        {
            get;
            set;
        }

        public virtual int? NumberOfPackages
        {
            get;
            set;
        }

        public virtual int? NumberOfContainers
        {
            get;
            set;
        }

        public virtual int? NumberOfPakagesPerContainer
        {
            get;
            set;
        }

        public virtual string OrderShipGroupStatusId
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual string OrderId
        {
            get;
            set;
        }

        public virtual string CreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? CreatedAt
        {
            get;
            set;
        }

        public virtual string UpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? UpdatedAt
        {
            get;
            set;
        }

        public virtual OrderItemShipGroupAssociationStateDto[] OrderItemShipGroupAssociations
        {
            get;
            set;
        }

        IOrderItemShipGroupAssociationStateDto[] IOrderShipGroupStateDto.OrderItemShipGroupAssociations
        {
            get { return this.OrderItemShipGroupAssociations; }
            set { this.OrderItemShipGroupAssociations = value.Select(e => ((OrderItemShipGroupAssociationStateDto)e)).ToArray(); }
        }

        public virtual IOrderShipGroupState ToOrderShipGroupState()
        {
            var state = new OrderShipGroupState(true);
            state.ShipGroupSeqId = this.ShipGroupSeqId;
            state.ShipmentMethodTypeId = this.ShipmentMethodTypeId;
            state.SupplierPartyId = this.SupplierPartyId;
            state.VendorPartyId = this.VendorPartyId;
            state.CarrierPartyId = this.CarrierPartyId;
            state.CarrierRoleTypeId = this.CarrierRoleTypeId;
            state.FacilityId = this.FacilityId;
            state.ContactMechId = this.ContactMechId;
            state.TelecomContactMechId = this.TelecomContactMechId;
            state.TrackingNumber = this.TrackingNumber;
            state.ContactPartyId = this.ContactPartyId;
            state.VehiclePlateNumber = this.VehiclePlateNumber;
            state.ShippingInstructions = this.ShippingInstructions;
            state.MaySplit = this.MaySplit;
            state.GiftMessage = this.GiftMessage;
            state.IsGift = this.IsGift;
            state.ShipAfterDate = this.ShipAfterDate;
            state.ShipByDate = this.ShipByDate;
            state.EstimatedShipDate = this.EstimatedShipDate;
            state.EstimatedDeliveryDate = this.EstimatedDeliveryDate;
            state.PickwaveId = this.PickwaveId;
            if (this.NumberOfPackages != null && this.NumberOfPackages.HasValue) { state.NumberOfPackages = this.NumberOfPackages.Value; }
            if (this.NumberOfContainers != null && this.NumberOfContainers.HasValue) { state.NumberOfContainers = this.NumberOfContainers.Value; }
            if (this.NumberOfPakagesPerContainer != null && this.NumberOfPakagesPerContainer.HasValue) { state.NumberOfPakagesPerContainer = this.NumberOfPakagesPerContainer.Value; }
            state.OrderShipGroupStatusId = this.OrderShipGroupStatusId;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.OrderId = this.OrderId;
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }
            if (this.OrderItemShipGroupAssociations != null) { foreach (var s in this.OrderItemShipGroupAssociations) { state.OrderItemShipGroupAssociations.AddToSave(s.ToOrderItemShipGroupAssociationState()); } };

            return state;
        }

    }

}

