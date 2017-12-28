﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{

    public partial class MovementLineMvoStateDto : IMovementLineMvoStateDto
    {

        public virtual MovementLineIdDto MovementLineId
        {
            get;
            set;
        }

        public virtual decimal? MovementQuantity
        {
            get;
            set;
        }

        public virtual string ProductId
        {
            get;
            set;
        }

        public virtual string LocatorIdFrom
        {
            get;
            set;
        }

        public virtual string LocatorIdTo
        {
            get;
            set;
        }

        public virtual string AttributeSetInstanceIdFrom
        {
            get;
            set;
        }

        public virtual string AttributeSetInstanceIdTo
        {
            get;
            set;
        }

        public virtual bool? Processed
        {
            get;
            set;
        }

        public virtual string ReversalLineNumber
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual bool? Active
        {
            get;
            set;
        }

        public virtual string MovementDocumentStatusId
        {
            get;
            set;
        }

        public virtual DateTime? MovementMovementDate
        {
            get;
            set;
        }

        public virtual bool? MovementPosted
        {
            get;
            set;
        }

        public virtual bool? MovementProcessed
        {
            get;
            set;
        }

        public virtual string MovementProcessing
        {
            get;
            set;
        }

        public virtual DateTime? MovementDateReceived
        {
            get;
            set;
        }

        public virtual string MovementDocumentTypeId
        {
            get;
            set;
        }

        public virtual bool? MovementIsInTransit
        {
            get;
            set;
        }

        public virtual bool? MovementIsApproved
        {
            get;
            set;
        }

        public virtual decimal? MovementApprovalAmount
        {
            get;
            set;
        }

        public virtual string MovementShipperId
        {
            get;
            set;
        }

        public virtual string MovementSalesRepresentativeId
        {
            get;
            set;
        }

        public virtual string MovementBusinessPartnerId
        {
            get;
            set;
        }

        public virtual decimal? MovementChargeAmount
        {
            get;
            set;
        }

        public virtual string MovementCreateFrom
        {
            get;
            set;
        }

        public virtual decimal? MovementFreightAmount
        {
            get;
            set;
        }

        public virtual string MovementReversalDocumentNumber
        {
            get;
            set;
        }

        public virtual string MovementWarehouseIdFrom
        {
            get;
            set;
        }

        public virtual string MovementWarehouseIdTo
        {
            get;
            set;
        }

        public virtual string MovementDescription
        {
            get;
            set;
        }

        public virtual string MovementCreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? MovementCreatedAt
        {
            get;
            set;
        }

        public virtual string MovementUpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? MovementUpdatedAt
        {
            get;
            set;
        }

        public virtual bool? MovementActive
        {
            get;
            set;
        }

        public virtual bool? MovementDeleted
        {
            get;
            set;
        }

        public virtual long? MovementVersion
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

        public virtual IMovementLineMvoState ToMovementLineMvoState()
        {
            var state = new MovementLineMvoState(true);
            state.MovementLineId = (this.MovementLineId == null) ? null : this.MovementLineId.ToMovementLineId();
            if (this.MovementQuantity != null && this.MovementQuantity.HasValue) { state.MovementQuantity = this.MovementQuantity.Value; }
            state.ProductId = this.ProductId;
            state.LocatorIdFrom = this.LocatorIdFrom;
            state.LocatorIdTo = this.LocatorIdTo;
            state.AttributeSetInstanceIdFrom = this.AttributeSetInstanceIdFrom;
            state.AttributeSetInstanceIdTo = this.AttributeSetInstanceIdTo;
            if (this.Processed != null && this.Processed.HasValue) { state.Processed = this.Processed.Value; }
            state.ReversalLineNumber = this.ReversalLineNumber;
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            state.MovementDocumentStatusId = this.MovementDocumentStatusId;
            if (this.MovementMovementDate != null && this.MovementMovementDate.HasValue) { state.MovementMovementDate = this.MovementMovementDate.Value; }
            if (this.MovementPosted != null && this.MovementPosted.HasValue) { state.MovementPosted = this.MovementPosted.Value; }
            if (this.MovementProcessed != null && this.MovementProcessed.HasValue) { state.MovementProcessed = this.MovementProcessed.Value; }
            state.MovementProcessing = this.MovementProcessing;
            if (this.MovementDateReceived != null && this.MovementDateReceived.HasValue) { state.MovementDateReceived = this.MovementDateReceived.Value; }
            state.MovementDocumentTypeId = this.MovementDocumentTypeId;
            if (this.MovementIsInTransit != null && this.MovementIsInTransit.HasValue) { state.MovementIsInTransit = this.MovementIsInTransit.Value; }
            if (this.MovementIsApproved != null && this.MovementIsApproved.HasValue) { state.MovementIsApproved = this.MovementIsApproved.Value; }
            if (this.MovementApprovalAmount != null && this.MovementApprovalAmount.HasValue) { state.MovementApprovalAmount = this.MovementApprovalAmount.Value; }
            state.MovementShipperId = this.MovementShipperId;
            state.MovementSalesRepresentativeId = this.MovementSalesRepresentativeId;
            state.MovementBusinessPartnerId = this.MovementBusinessPartnerId;
            if (this.MovementChargeAmount != null && this.MovementChargeAmount.HasValue) { state.MovementChargeAmount = this.MovementChargeAmount.Value; }
            state.MovementCreateFrom = this.MovementCreateFrom;
            if (this.MovementFreightAmount != null && this.MovementFreightAmount.HasValue) { state.MovementFreightAmount = this.MovementFreightAmount.Value; }
            state.MovementReversalDocumentNumber = this.MovementReversalDocumentNumber;
            state.MovementWarehouseIdFrom = this.MovementWarehouseIdFrom;
            state.MovementWarehouseIdTo = this.MovementWarehouseIdTo;
            state.MovementDescription = this.MovementDescription;
            state.MovementCreatedBy = this.MovementCreatedBy;
            if (this.MovementCreatedAt != null && this.MovementCreatedAt.HasValue) { state.MovementCreatedAt = this.MovementCreatedAt.Value; }
            state.MovementUpdatedBy = this.MovementUpdatedBy;
            if (this.MovementUpdatedAt != null && this.MovementUpdatedAt.HasValue) { state.MovementUpdatedAt = this.MovementUpdatedAt.Value; }
            if (this.MovementActive != null && this.MovementActive.HasValue) { state.MovementActive = this.MovementActive.Value; }
            if (this.MovementDeleted != null && this.MovementDeleted.HasValue) { state.MovementDeleted = this.MovementDeleted.Value; }
            if (this.MovementVersion != null && this.MovementVersion.HasValue) { state.MovementVersion = this.MovementVersion.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}
