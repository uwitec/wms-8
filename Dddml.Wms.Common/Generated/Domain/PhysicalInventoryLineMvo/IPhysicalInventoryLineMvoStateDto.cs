﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;

namespace Dddml.Wms.Domain.PhysicalInventoryLineMvo
{

    public interface IPhysicalInventoryLineMvoStateDto
    {
        PhysicalInventoryLineId PhysicalInventoryLineId
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

        long? Version
        {
            get;
            set;
        }

        string PhysicalInventoryDocumentStatusId
        {
            get;
            set;
        }

        string PhysicalInventoryWarehouseId
        {
            get;
            set;
        }

        string PhysicalInventoryLocatorIdPattern
        {
            get;
            set;
        }

        string PhysicalInventoryProductIdPattern
        {
            get;
            set;
        }

        bool? PhysicalInventoryPosted
        {
            get;
            set;
        }

        bool? PhysicalInventoryProcessed
        {
            get;
            set;
        }

        string PhysicalInventoryProcessing
        {
            get;
            set;
        }

        string PhysicalInventoryDocumentTypeId
        {
            get;
            set;
        }

        DateTime? PhysicalInventoryMovementDate
        {
            get;
            set;
        }

        string PhysicalInventoryDescription
        {
            get;
            set;
        }

        bool? PhysicalInventoryIsApproved
        {
            get;
            set;
        }

        decimal? PhysicalInventoryApprovalAmount
        {
            get;
            set;
        }

        bool? PhysicalInventoryIsQuantityUpdated
        {
            get;
            set;
        }

        string PhysicalInventoryReversalDocumentNumber
        {
            get;
            set;
        }

        string PhysicalInventoryCreatedBy
        {
            get;
            set;
        }

        DateTime? PhysicalInventoryCreatedAt
        {
            get;
            set;
        }

        string PhysicalInventoryUpdatedBy
        {
            get;
            set;
        }

        DateTime? PhysicalInventoryUpdatedAt
        {
            get;
            set;
        }

        bool? PhysicalInventoryActive
        {
            get;
            set;
        }

        long? PhysicalInventoryVersion
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

        IPhysicalInventoryLineMvoState ToPhysicalInventoryLineMvoState();

    }

}

