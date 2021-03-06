﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistBinDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistBin
{

	public abstract class PicklistItemStateEventDtoBase : IEventDto, IPicklistItemStateCreated, IPicklistItemStateMergePatched, IPicklistItemStateRemoved
	{

        private PicklistItemEventId _picklistItemEventId;

		protected internal virtual PicklistItemEventId PicklistItemEventId 
        {
            get 
            {
                if (_picklistItemEventId == null) { _picklistItemEventId = new PicklistItemEventId(); }
                return _picklistItemEventId;
            }
            set
            {
                _picklistItemEventId = value;
            }
        }

        public virtual PicklistItemOrderShipGrpInvId PicklistItemOrderShipGrpInvId
        {
            get { return PicklistItemEventId.PicklistItemOrderShipGrpInvId; }
            set { PicklistItemEventId.PicklistItemOrderShipGrpInvId = value; }
        }

		public virtual string ItemStatusId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PicklistItemEventId IGlobalIdentity<PicklistItemEventId>.GlobalId {
			get 
			{
				return this.PicklistItemEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IPicklistItemEvent.ReadOnly
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

		public virtual long Version { get; set; }

		public virtual bool? IsPropertyItemStatusIdRemoved { get; set; }

        bool IPicklistItemStateMergePatched.IsPropertyItemStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyItemStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyItemStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IPicklistItemStateMergePatched.IsPropertyQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IPicklistItemStateMergePatched.IsPropertyActiveRemoved
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


        PicklistItemEventId IPicklistItemEvent.PicklistItemEventId
        {
            get { return this.PicklistItemEventId; }
        }

        protected PicklistItemStateEventDtoBase()
        {
        }

        protected PicklistItemStateEventDtoBase(PicklistItemEventId stateEventId)
        {
            this.PicklistItemEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class PicklistItemStateCreatedOrMergePatchedOrRemovedDto : PicklistItemStateEventDtoBase
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



	public class PicklistItemStateCreatedDto : PicklistItemStateCreatedOrMergePatchedOrRemovedDto
	{
		public PicklistItemStateCreatedDto()
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


	public class PicklistItemStateMergePatchedDto : PicklistItemStateCreatedOrMergePatchedOrRemovedDto
	{
		public PicklistItemStateMergePatchedDto()
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


	public class PicklistItemStateRemovedDto : PicklistItemStateCreatedOrMergePatchedOrRemovedDto
	{
		public PicklistItemStateRemovedDto()
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
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class PicklistItemStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IPicklistItemStateCreated>, IEnumerable<IPicklistItemStateMergePatched>, IEnumerable<IPicklistItemStateRemoved>
    {
        private List<PicklistItemStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<PicklistItemStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual PicklistItemStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<PicklistItemStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPicklistItemStateCreated> IEnumerable<IPicklistItemStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPicklistItemStateMergePatched> IEnumerable<IPicklistItemStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPicklistItemStateRemoved> IEnumerable<IPicklistItemStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddPicklistItemEvent(IPicklistItemStateCreated e)
        {
            _innerStateEvents.Add((PicklistItemStateCreatedDto)e);
        }

        public void AddPicklistItemEvent(IPicklistItemEvent e)
        {
            _innerStateEvents.Add((PicklistItemStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddPicklistItemEvent(IPicklistItemStateRemoved e)
        {
            _innerStateEvents.Add((PicklistItemStateRemovedDto)e);
        }

    }


}

