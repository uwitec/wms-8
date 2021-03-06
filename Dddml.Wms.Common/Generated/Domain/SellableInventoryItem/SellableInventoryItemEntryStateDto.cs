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

    public partial class SellableInventoryItemEntryStateDto : ISellableInventoryItemEntryStateDto
    {
        public virtual long? EntrySeqId
        {
            get;
            set;
        }

        public virtual decimal? SellableQuantity
        {
            get;
            set;
        }

        public virtual InventoryPRTriggeredId SourceEventId
        {
            get;
            set;
        }

        public virtual long? Version
        {
            get;
            set;
        }

        public virtual InventoryItemId SellableInventoryItemId
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

        public virtual ISellableInventoryItemEntryState ToSellableInventoryItemEntryState()
        {
            var state = new SellableInventoryItemEntryState(true);
            if (this.EntrySeqId != null && this.EntrySeqId.HasValue) { state.EntrySeqId = this.EntrySeqId.Value; }
            if (this.SellableQuantity != null && this.SellableQuantity.HasValue) { state.SellableQuantity = this.SellableQuantity.Value; }
            state.SourceEventId = this.SourceEventId;
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.SellableInventoryItemId = this.SellableInventoryItemId;
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

