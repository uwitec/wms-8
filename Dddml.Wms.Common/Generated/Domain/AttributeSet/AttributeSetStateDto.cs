﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

    public partial class AttributeSetStateDto : IAttributeSetStateDto
    {
        public virtual string AttributeSetId
        {
            get;
            set;
        }

        public virtual string Name
        {
            get;
            set;
        }

        public virtual string OrganizationId
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual string SerialNumberAttributeId
        {
            get;
            set;
        }

        public virtual string LotAttributeId
        {
            get;
            set;
        }

        public virtual string ReferenceId
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

        public virtual AttributeUseStateDto[] AttributeUses
        {
            get;
            set;
        }

        IAttributeUseStateDto[] IAttributeSetStateDto.AttributeUses
        {
            get { return this.AttributeUses; }
            set { this.AttributeUses = value.Select(e => ((AttributeUseStateDto)e)).ToArray(); }
        }

        public virtual IAttributeSetState ToAttributeSetState()
        {
            var state = new AttributeSetState(true);
            state.AttributeSetId = this.AttributeSetId;
            state.Name = this.Name;
            state.OrganizationId = this.OrganizationId;
            state.Description = this.Description;
            state.SerialNumberAttributeId = this.SerialNumberAttributeId;
            state.LotAttributeId = this.LotAttributeId;
            state.ReferenceId = this.ReferenceId;
            if (this.Active != null && this.Active.HasValue) { state.Active = this.Active.Value; }
            if (this.Version != null && this.Version.HasValue) { state.Version = this.Version.Value; }
            state.CreatedBy = this.CreatedBy;
            if (this.CreatedAt != null && this.CreatedAt.HasValue) { state.CreatedAt = this.CreatedAt.Value; }
            state.UpdatedBy = this.UpdatedBy;
            if (this.UpdatedAt != null && this.UpdatedAt.HasValue) { state.UpdatedAt = this.UpdatedAt.Value; }
            if (this.AttributeUses != null) { foreach (var s in this.AttributeUses) { state.AttributeUses.AddToSave(s.ToAttributeUseState()); } };

            return state;
        }

    }

}
