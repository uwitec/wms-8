﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomConversionDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomConversion;

namespace Dddml.Wms.Domain.UomConversion
{

    public partial class UomConversionStateDto : IUomConversionStateDto
    {
        public virtual UomConversionId UomConversionId
        {
            get;
            set;
        }

        public virtual double? ConversionFactor
        {
            get;
            set;
        }

        public virtual string CustomMethodId
        {
            get;
            set;
        }

        public virtual long? DecimalScale
        {
            get;
            set;
        }

        public virtual string RoundingMode
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

        public virtual IUomConversionState ToUomConversionState()
        {
            var state = new UomConversionState(true);
            state.UomConversionId = this.UomConversionId;
            state.ConversionFactor = this.ConversionFactor;
            state.CustomMethodId = this.CustomMethodId;
            state.DecimalScale = this.DecimalScale;
            state.RoundingMode = this.RoundingMode;
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

