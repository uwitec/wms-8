﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;

namespace Dddml.Wms.Domain.PhysicalInventoryLineMvo
{

	public abstract class PhysicalInventoryLineMvoCommandDtoBase : ICommandDto, ICreatePhysicalInventoryLineMvo, IMergePatchPhysicalInventoryLineMvo, IDeletePhysicalInventoryLineMvo
	{

		PhysicalInventoryLineId IAggregateCommand<PhysicalInventoryLineId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeletePhysicalInventoryLineMvo)this).PhysicalInventoryLineId;
			}
		}


		long IAggregateCommand<PhysicalInventoryLineId, long>.AggregateVersion
		{
			get
			{
				return this.PhysicalInventoryVersion;
			}
		}

		public virtual long PhysicalInventoryVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual PhysicalInventoryLineId PhysicalInventoryLineId { get; set; }

		public virtual decimal? BookQuantity { get; set; }

		public virtual decimal? CountedQuantity { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual long? ReversalLineNumber { get; set; }

		public virtual string Description { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string PhysicalInventoryDocumentStatusId { get; set; }

		public virtual string PhysicalInventoryWarehouseId { get; set; }

		public virtual string PhysicalInventoryLocatorIdPattern { get; set; }

		public virtual string PhysicalInventoryProductIdPattern { get; set; }

		public virtual bool? PhysicalInventoryPosted { get; set; }

		public virtual bool? PhysicalInventoryProcessed { get; set; }

		public virtual string PhysicalInventoryProcessing { get; set; }

		public virtual string PhysicalInventoryDocumentTypeId { get; set; }

		public virtual DateTime? PhysicalInventoryMovementDate { get; set; }

		public virtual string PhysicalInventoryDescription { get; set; }

		public virtual bool? PhysicalInventoryIsApproved { get; set; }

		public virtual decimal? PhysicalInventoryApprovalAmount { get; set; }

		public virtual bool? PhysicalInventoryIsQuantityUpdated { get; set; }

		public virtual string PhysicalInventoryReversalDocumentNumber { get; set; }

		public virtual string PhysicalInventoryCreatedBy { get; set; }

		public virtual DateTime? PhysicalInventoryCreatedAt { get; set; }

		public virtual string PhysicalInventoryUpdatedBy { get; set; }

		public virtual DateTime? PhysicalInventoryUpdatedAt { get; set; }

		public virtual bool? PhysicalInventoryActive { get; set; }

		public virtual bool? IsPropertyBookQuantityRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyBookQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyBookQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyBookQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyCountedQuantityRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyCountedQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyCountedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCountedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyProcessedRemoved
        {
            get
            {
                var b = this.IsPropertyProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalLineNumberRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyReversalLineNumberRemoved
        {
            get
            {
                var b = this.IsPropertyReversalLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReversalLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyVersionRemoved
        {
            get
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryDocumentStatusIdRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryDocumentStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryDocumentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryDocumentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryWarehouseIdRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryWarehouseIdRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryLocatorIdPatternRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryLocatorIdPatternRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryLocatorIdPatternRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryLocatorIdPatternRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryProductIdPatternRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryProductIdPatternRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryProductIdPatternRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryProductIdPatternRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryPostedRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryPostedRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryPostedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryPostedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryProcessedRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryProcessedRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryProcessingRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryProcessingRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryDocumentTypeIdRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryDocumentTypeIdRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryMovementDateRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryMovementDateRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryMovementDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryMovementDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryDescriptionRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryIsApprovedRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryIsApprovedRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryApprovalAmountRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryApprovalAmountRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryApprovalAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryApprovalAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryReversalDocumentNumberRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryReversalDocumentNumberRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryReversalDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryReversalDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryCreatedByRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryCreatedByRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryCreatedAtRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryCreatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryUpdatedByRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryUpdatedByRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryUpdatedAtRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryUpdatedAtRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryActiveRemoved { get; set; }

        bool IMergePatchPhysicalInventoryLineMvo.IsPropertyPhysicalInventoryActiveRemoved
        {
            get
            {
                var b = this.IsPropertyPhysicalInventoryActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPhysicalInventoryActiveRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeletePhysicalInventoryLineMvoDto : PhysicalInventoryLineMvoCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreatePhysicalInventoryLineMvoDto : CreateOrMergePatchOrDeletePhysicalInventoryLineMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchPhysicalInventoryLineMvoDto : CreateOrMergePatchOrDeletePhysicalInventoryLineMvoDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeletePhysicalInventoryLineMvoDto : CreateOrMergePatchOrDeletePhysicalInventoryLineMvoDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class PhysicalInventoryLineMvoCommandDtos
    {

    }

}

