﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGrpInvReservationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGrpInvReservation;

namespace Dddml.Wms.Domain.OrderItemShipGrpInvReservation
{

    public partial class OrderItemShipGrpInvReservationStateDto : IOrderItemShipGrpInvReservationStateDto
    {
        public virtual OrderItemShipGrpInvResId OrderItemShipGrpInvResId
        {
            get;
            set;
        }

        public virtual string ReserveOrderEnumId
        {
            get;
            set;
        }

        public virtual decimal? Quantity
        {
            get;
            set;
        }

        public virtual decimal? QuantityNotAvailable
        {
            get;
            set;
        }

        public virtual DateTime? ReservedDatetime
        {
            get;
            set;
        }

        public virtual DateTime? CreatedDatetime
        {
            get;
            set;
        }

        public virtual DateTime? PromisedDatetime
        {
            get;
            set;
        }

        public virtual DateTime? CurrentPromisedDate
        {
            get;
            set;
        }

        public virtual string Priority
        {
            get;
            set;
        }

        public virtual long? SequenceId
        {
            get;
            set;
        }

        public virtual DateTime? OldPickStartDate
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

        public virtual IOrderItemShipGrpInvReservationState ToOrderItemShipGrpInvReservationState()
        {
            var state = new OrderItemShipGrpInvReservationState(true);
            state.OrderItemShipGrpInvResId = this.OrderItemShipGrpInvResId;
            state.ReserveOrderEnumId = this.ReserveOrderEnumId;
            state.Quantity = this.Quantity;
            state.QuantityNotAvailable = this.QuantityNotAvailable;
            state.ReservedDatetime = this.ReservedDatetime;
            state.CreatedDatetime = this.CreatedDatetime;
            state.PromisedDatetime = this.PromisedDatetime;
            state.CurrentPromisedDate = this.CurrentPromisedDate;
            state.Priority = this.Priority;
            state.SequenceId = this.SequenceId;
            state.OldPickStartDate = this.OldPickStartDate;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}
