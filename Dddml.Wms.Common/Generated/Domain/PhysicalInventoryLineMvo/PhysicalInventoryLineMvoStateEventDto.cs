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

	public abstract class PhysicalInventoryLineMvoStateEventDtoBase : IEventDto, IPhysicalInventoryLineMvoStateCreated, IPhysicalInventoryLineMvoStateMergePatched, IPhysicalInventoryLineMvoStateDeleted
	{

        private PhysicalInventoryLineMvoEventId _physicalInventoryLineMvoEventId;

		protected internal virtual PhysicalInventoryLineMvoEventId PhysicalInventoryLineMvoEventId 
        {
            get 
            {
                if (_physicalInventoryLineMvoEventId == null) { _physicalInventoryLineMvoEventId = new PhysicalInventoryLineMvoEventId(); }
                return _physicalInventoryLineMvoEventId;
            }
            set
            {
                _physicalInventoryLineMvoEventId = value;
            }
        }

        public virtual PhysicalInventoryLineId PhysicalInventoryLineId
        {
            get { return PhysicalInventoryLineMvoEventId.PhysicalInventoryLineId; }
            set { PhysicalInventoryLineMvoEventId.PhysicalInventoryLineId = value; }
        }

        public virtual long PhysicalInventoryVersion
        {
            get { return PhysicalInventoryLineMvoEventId.PhysicalInventoryVersion; }
            set { PhysicalInventoryLineMvoEventId.PhysicalInventoryVersion = value; }
        }

		public virtual decimal? BookQuantity { get; set; }

		public virtual decimal? CountedQuantity { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string LineNumber { get; set; }

		public virtual long? ReversalLineNumber { get; set; }

		public virtual string Description { get; set; }

		public virtual long? Version { get; set; }

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

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PhysicalInventoryLineMvoEventId IGlobalIdentity<PhysicalInventoryLineMvoEventId>.GlobalId {
			get 
			{
				return this.PhysicalInventoryLineMvoEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IPhysicalInventoryLineMvoEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyBookQuantityRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyBookQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyBookQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyBookQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyCountedQuantityRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyCountedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyCountedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCountedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyProcessedRemoved
        {
            get 
            {
                var b = this.IsPropertyProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyLineNumberRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalLineNumberRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyReversalLineNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyReversalLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReversalLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryDocumentStatusIdRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryDocumentStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryDocumentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryDocumentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryWarehouseIdRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryWarehouseIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryLocatorIdPatternRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryLocatorIdPatternRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryLocatorIdPatternRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryLocatorIdPatternRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryProductIdPatternRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryProductIdPatternRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryProductIdPatternRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryProductIdPatternRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryPostedRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryPostedRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryPostedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryPostedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryProcessedRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryProcessedRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryProcessingRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryProcessingRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryDocumentTypeIdRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryDocumentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryMovementDateRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryMovementDateRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryMovementDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryMovementDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryDescriptionRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryIsApprovedRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryIsApprovedRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryApprovalAmountRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryApprovalAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryApprovalAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryApprovalAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryIsQuantityUpdatedRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryReversalDocumentNumberRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryReversalDocumentNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryReversalDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryReversalDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryCreatedByRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryCreatedAtRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryUpdatedByRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryUpdatedAtRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryUpdatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertyPhysicalInventoryActiveRemoved { get; set; }

        bool IPhysicalInventoryLineMvoStateMergePatched.IsPropertyPhysicalInventoryActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyPhysicalInventoryActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPhysicalInventoryActiveRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        PhysicalInventoryLineMvoEventId IPhysicalInventoryLineMvoEvent.PhysicalInventoryLineMvoEventId
        {
            get { return this.PhysicalInventoryLineMvoEventId; }
        }

        protected PhysicalInventoryLineMvoStateEventDtoBase()
        {
        }

        protected PhysicalInventoryLineMvoStateEventDtoBase(PhysicalInventoryLineMvoEventId stateEventId)
        {
            this.PhysicalInventoryLineMvoEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto : PhysicalInventoryLineMvoStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetEventType()
        {
            return this._eventType;
        }

    }



	public class PhysicalInventoryLineMvoStateCreatedDto : PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public PhysicalInventoryLineMvoStateCreatedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PhysicalInventoryLineMvoStateMergePatchedDto : PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public PhysicalInventoryLineMvoStateMergePatchedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class PhysicalInventoryLineMvoStateDeletedDto : PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public PhysicalInventoryLineMvoStateDeletedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IPhysicalInventoryLineMvoStateCreated>, IEnumerable<IPhysicalInventoryLineMvoStateMergePatched>, IEnumerable<IPhysicalInventoryLineMvoStateDeleted>
    {
        private List<PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPhysicalInventoryLineMvoStateCreated> IEnumerable<IPhysicalInventoryLineMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPhysicalInventoryLineMvoStateMergePatched> IEnumerable<IPhysicalInventoryLineMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPhysicalInventoryLineMvoStateDeleted> IEnumerable<IPhysicalInventoryLineMvoStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddPhysicalInventoryLineMvoEvent(IPhysicalInventoryLineMvoStateCreated e)
        {
            _innerStateEvents.Add((PhysicalInventoryLineMvoStateCreatedDto)e);
        }

        public void AddPhysicalInventoryLineMvoEvent(IPhysicalInventoryLineMvoEvent e)
        {
            _innerStateEvents.Add((PhysicalInventoryLineMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddPhysicalInventoryLineMvoEvent(IPhysicalInventoryLineMvoStateDeleted e)
        {
            _innerStateEvents.Add((PhysicalInventoryLineMvoStateDeletedDto)e);
        }

    }


}

