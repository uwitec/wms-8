﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{

    public partial class PhysicalInventoryStateDto : IPhysicalInventoryStateDto
    {
        public virtual string DocumentNumber
        {
            get;
            set;
        }

        public virtual string DocumentStatusId
        {
            get;
            set;
        }

        public virtual string WarehouseId
        {
            get;
            set;
        }

        public virtual string LocatorIdPattern
        {
            get;
            set;
        }

        public virtual string ProductIdPattern
        {
            get;
            set;
        }

        public virtual bool? Posted
        {
            get;
            set;
        }

        public virtual bool? Processed
        {
            get;
            set;
        }

        public virtual string Processing
        {
            get;
            set;
        }

        public virtual string DocumentTypeId
        {
            get;
            set;
        }

        public virtual DateTime? MovementDate
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual bool? IsApproved
        {
            get;
            set;
        }

        public virtual decimal? ApprovalAmount
        {
            get;
            set;
        }

        public virtual bool? IsQuantityUpdated
        {
            get;
            set;
        }

        public virtual string ReversalDocumentNumber
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

        public virtual PhysicalInventoryLineStateDto[] PhysicalInventoryLines
        {
            get;
            set;
        }

        IPhysicalInventoryLineStateDto[] IPhysicalInventoryStateDto.PhysicalInventoryLines
        {
            get { return this.PhysicalInventoryLines; }
            set { this.PhysicalInventoryLines = value.Select(e => ((PhysicalInventoryLineStateDto)e)).ToArray(); }
        }

        public virtual IPhysicalInventoryState ToPhysicalInventoryState()
        {
            var state = new PhysicalInventoryState(true);
            state.DocumentNumber = this.DocumentNumber;
            state.DocumentStatusId = this.DocumentStatusId;
            state.WarehouseId = this.WarehouseId;
            state.LocatorIdPattern = this.LocatorIdPattern;
            state.ProductIdPattern = this.ProductIdPattern;
            if (this.Posted != null && this.Posted.HasValue) { state.Posted = this.Posted.Value; }
            if (this.Processed != null && this.Processed.HasValue) { state.Processed = this.Processed.Value; }
            state.Processing = this.Processing;
            state.DocumentTypeId = this.DocumentTypeId;
            state.MovementDate = this.MovementDate;
            state.Description = this.Description;
            if (this.IsApproved != null && this.IsApproved.HasValue) { state.IsApproved = this.IsApproved.Value; }
            if (this.ApprovalAmount != null && this.ApprovalAmount.HasValue) { state.ApprovalAmount = this.ApprovalAmount.Value; }
            if (this.IsQuantityUpdated != null && this.IsQuantityUpdated.HasValue) { state.IsQuantityUpdated = this.IsQuantityUpdated.Value; }
            state.ReversalDocumentNumber = this.ReversalDocumentNumber;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }
            if (this.PhysicalInventoryLines != null) { foreach (var s in this.PhysicalInventoryLines) { state.PhysicalInventoryLines.AddToSave(s.ToPhysicalInventoryLineState()); } };

            return state;
        }

    }

}

