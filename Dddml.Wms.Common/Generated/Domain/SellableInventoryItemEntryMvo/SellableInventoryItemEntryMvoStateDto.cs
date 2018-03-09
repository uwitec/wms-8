﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{

    public partial class SellableInventoryItemEntryMvoStateDto : ISellableInventoryItemEntryMvoStateDto
    {
        public virtual SellableInventoryItemEntryId SellableInventoryItemEntryId
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

        public virtual decimal? SellableInventoryItemSellableQuantity
        {
            get;
            set;
        }

        public virtual string SellableInventoryItemCreatedBy
        {
            get;
            set;
        }

        public virtual DateTime? SellableInventoryItemCreatedAt
        {
            get;
            set;
        }

        public virtual string SellableInventoryItemUpdatedBy
        {
            get;
            set;
        }

        public virtual DateTime? SellableInventoryItemUpdatedAt
        {
            get;
            set;
        }

        public virtual long? SellableInventoryItemVersion
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

        public virtual ISellableInventoryItemEntryMvoState ToSellableInventoryItemEntryMvoState()
        {
            var state = new SellableInventoryItemEntryMvoState(true);
            state.SellableInventoryItemEntryId = this.SellableInventoryItemEntryId;
            if (this.SellableQuantity != null && this.SellableQuantity.HasValue) { state.SellableQuantity = this.SellableQuantity.Value; }
            state.SourceEventId = this.SourceEventId;
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            if (this.SellableInventoryItemSellableQuantity != null && this.SellableInventoryItemSellableQuantity.HasValue) { state.SellableInventoryItemSellableQuantity = this.SellableInventoryItemSellableQuantity.Value; }
            state.SellableInventoryItemCreatedBy = this.SellableInventoryItemCreatedBy;
            if (this.SellableInventoryItemCreatedAt != null && this.SellableInventoryItemCreatedAt.HasValue) { state.SellableInventoryItemCreatedAt = this.SellableInventoryItemCreatedAt.Value; }
            state.SellableInventoryItemUpdatedBy = this.SellableInventoryItemUpdatedBy;
            if (this.SellableInventoryItemUpdatedAt != null && this.SellableInventoryItemUpdatedAt.HasValue) { state.SellableInventoryItemUpdatedAt = this.SellableInventoryItemUpdatedAt.Value; }
            if (this.SellableInventoryItemVersion != null && this.SellableInventoryItemVersion.HasValue) { state.SellableInventoryItemVersion = this.SellableInventoryItemVersion.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }

            return state;
        }

    }

}

