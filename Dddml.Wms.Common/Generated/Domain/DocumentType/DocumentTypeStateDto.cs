﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDocumentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DocumentType;

namespace Dddml.Wms.Domain.DocumentType
{

    public partial class DocumentTypeStateDto : IDocumentTypeStateDto
    {
        public virtual string DocumentTypeId
        {
            get;
            set;
        }

        public virtual string Description
        {
            get;
            set;
        }

        public virtual string ParentDocumentTypeId
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

        public virtual IDocumentTypeState ToDocumentTypeState()
        {
            var state = new DocumentTypeState(true);
            state.DocumentTypeId = this.DocumentTypeId;
            state.Description = this.Description;
            state.ParentDocumentTypeId = this.ParentDocumentTypeId;
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

