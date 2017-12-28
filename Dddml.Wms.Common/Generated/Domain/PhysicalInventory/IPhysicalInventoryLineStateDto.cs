﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;

namespace Dddml.Wms.Domain.PhysicalInventory
{

    public interface IPhysicalInventoryLineStateDto
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

        decimal? BookQuantity
        {
            get;
            set;
        }

        decimal? CountedQuantity
        {
            get;
            set;
        }

        bool? Processed
        {
            get;
            set;
        }

        long? ReversalLineNumber
        {
            get;
            set;
        }

        string Description
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

        string PhysicalInventoryDocumentNumber
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

        IPhysicalInventoryLineState ToPhysicalInventoryLineState();

    }

}
