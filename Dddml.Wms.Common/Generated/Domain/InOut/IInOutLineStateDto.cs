﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

    public interface IInOutLineStateDto
    {
        string LineNumber
        {
            get;
            set;
        }

        string LocatorId
        {
            get;
            set;
        }

        string ProductId
        {
            get;
            set;
        }

        string AttributeSetInstanceId
        {
            get;
            set;
        }

        string Description
        {
            get;
            set;
        }

        string QuantityUomId
        {
            get;
            set;
        }

        decimal? MovementQuantity
        {
            get;
            set;
        }

        decimal? PickedQuantity
        {
            get;
            set;
        }

        bool? IsInvoiced
        {
            get;
            set;
        }

        bool? Processed
        {
            get;
            set;
        }

        string RmaLineNumber
        {
            get;
            set;
        }

        string ReversalLineNumber
        {
            get;
            set;
        }

        bool? Active
        {
            get;
            set;
        }

        long? Version
        {
            get;
            set;
        }

        string InOutDocumentNumber
        {
            get;
            set;
        }

        string CreatedBy
        {
            get;
            set;
        }

        DateTime? CreatedAt
        {
            get;
            set;
        }

        string UpdatedBy
        {
            get;
            set;
        }

        DateTime? UpdatedAt
        {
            get;
            set;
        }

        string[] DamageStatusIds
        {
            get;
            set;
        }

        IInOutLineImageStateDto[] InOutLineImages
        {
            get;
            set;
        }

        IInOutLineState ToInOutLineState();

    }

}

