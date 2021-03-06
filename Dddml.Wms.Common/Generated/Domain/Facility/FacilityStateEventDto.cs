﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateFacilityDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Facility;

namespace Dddml.Wms.Domain.Facility
{

	public abstract class FacilityStateEventDtoBase : IEventDto, IFacilityStateCreated, IFacilityStateMergePatched, IFacilityStateDeleted
	{

        private FacilityEventId _facilityEventId;

		protected internal virtual FacilityEventId FacilityEventId 
        {
            get 
            {
                if (_facilityEventId == null) { _facilityEventId = new FacilityEventId(); }
                return _facilityEventId;
            }
            set
            {
                _facilityEventId = value;
            }
        }

        public virtual string FacilityId
        {
            get { return FacilityEventId.FacilityId; }
            set { FacilityEventId.FacilityId = value; }
        }

        public virtual long Version
        {
            get { return FacilityEventId.Version; }
            set { FacilityEventId.Version = value; }
        }

		public virtual string FacilityTypeId { get; set; }

		public virtual string ParentFacilityId { get; set; }

		public virtual string OwnerPartyId { get; set; }

		public virtual string DefaultInventoryItemTypeId { get; set; }

		public virtual string FacilityName { get; set; }

		public virtual string PrimaryFacilityGroupId { get; set; }

		public virtual long? OldSquareFootage { get; set; }

		public virtual decimal? FacilitySize { get; set; }

		public virtual string FacilitySizeUomId { get; set; }

		public virtual string ProductStoreId { get; set; }

		public virtual long? DefaultDaysToShip { get; set; }

		public virtual DateTime? OpenedDate { get; set; }

		public virtual DateTime? ClosedDate { get; set; }

		public virtual string Description { get; set; }

		public virtual string DefaultDimensionUomId { get; set; }

		public virtual string DefaultWeightUomId { get; set; }

		public virtual string GeoPointId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		FacilityEventId IGlobalIdentity<FacilityEventId>.GlobalId {
			get 
			{
				return this.FacilityEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IFacilityEvent.ReadOnly
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

		public virtual bool? IsPropertyFacilityTypeIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyFacilityTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyFacilityTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFacilityTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyParentFacilityIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyParentFacilityIdRemoved
        {
            get 
            {
                var b = this.IsPropertyParentFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyParentFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOwnerPartyIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyOwnerPartyIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOwnerPartyIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOwnerPartyIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDefaultInventoryItemTypeIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyDefaultInventoryItemTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDefaultInventoryItemTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDefaultInventoryItemTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyFacilityNameRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyFacilityNameRemoved
        {
            get 
            {
                var b = this.IsPropertyFacilityNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFacilityNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryFacilityGroupIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyPrimaryFacilityGroupIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPrimaryFacilityGroupIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPrimaryFacilityGroupIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOldSquareFootageRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyOldSquareFootageRemoved
        {
            get 
            {
                var b = this.IsPropertyOldSquareFootageRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOldSquareFootageRemoved = value;
            }
        }

		public virtual bool? IsPropertyFacilitySizeRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyFacilitySizeRemoved
        {
            get 
            {
                var b = this.IsPropertyFacilitySizeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFacilitySizeRemoved = value;
            }
        }

		public virtual bool? IsPropertyFacilitySizeUomIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyFacilitySizeUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyFacilitySizeUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFacilitySizeUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductStoreIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyProductStoreIdRemoved
        {
            get 
            {
                var b = this.IsPropertyProductStoreIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductStoreIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDefaultDaysToShipRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyDefaultDaysToShipRemoved
        {
            get 
            {
                var b = this.IsPropertyDefaultDaysToShipRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDefaultDaysToShipRemoved = value;
            }
        }

		public virtual bool? IsPropertyOpenedDateRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyOpenedDateRemoved
        {
            get 
            {
                var b = this.IsPropertyOpenedDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOpenedDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyClosedDateRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyClosedDateRemoved
        {
            get 
            {
                var b = this.IsPropertyClosedDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyClosedDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyDefaultDimensionUomIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyDefaultDimensionUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDefaultDimensionUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDefaultDimensionUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDefaultWeightUomIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyDefaultWeightUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDefaultWeightUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDefaultWeightUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyGeoPointIdRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyGeoPointIdRemoved
        {
            get 
            {
                var b = this.IsPropertyGeoPointIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyGeoPointIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IFacilityStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
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


        FacilityEventId IFacilityEvent.FacilityEventId
        {
            get { return this.FacilityEventId; }
        }

        protected FacilityStateEventDtoBase()
        {
        }

        protected FacilityStateEventDtoBase(FacilityEventId stateEventId)
        {
            this.FacilityEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class FacilityStateCreatedOrMergePatchedOrDeletedDto : FacilityStateEventDtoBase
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



	public class FacilityStateCreatedDto : FacilityStateCreatedOrMergePatchedOrDeletedDto
	{
		public FacilityStateCreatedDto()
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


	public class FacilityStateMergePatchedDto : FacilityStateCreatedOrMergePatchedOrDeletedDto
	{
		public FacilityStateMergePatchedDto()
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


	public class FacilityStateDeletedDto : FacilityStateCreatedOrMergePatchedOrDeletedDto
	{
		public FacilityStateDeletedDto()
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


    public partial class FacilityStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IFacilityStateCreated>, IEnumerable<IFacilityStateMergePatched>, IEnumerable<IFacilityStateDeleted>
    {
        private List<FacilityStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<FacilityStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual FacilityStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<FacilityStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IFacilityStateCreated> IEnumerable<IFacilityStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IFacilityStateMergePatched> IEnumerable<IFacilityStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IFacilityStateDeleted> IEnumerable<IFacilityStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddFacilityEvent(IFacilityStateCreated e)
        {
            _innerStateEvents.Add((FacilityStateCreatedDto)e);
        }

        public void AddFacilityEvent(IFacilityEvent e)
        {
            _innerStateEvents.Add((FacilityStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddFacilityEvent(IFacilityStateDeleted e)
        {
            _innerStateEvents.Add((FacilityStateDeletedDto)e);
        }

    }


}

