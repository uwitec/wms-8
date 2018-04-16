﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Picklist
{

	public abstract class PicklistRoleStateEventDtoBase : IEventDto, IPicklistRoleStateCreated, IPicklistRoleStateMergePatched, IPicklistRoleStateRemoved
	{

        private PicklistRoleEventId _picklistRoleEventId;

		protected internal virtual PicklistRoleEventId PicklistRoleEventId 
        {
            get 
            {
                if (_picklistRoleEventId == null) { _picklistRoleEventId = new PicklistRoleEventId(); }
                return _picklistRoleEventId;
            }
            set
            {
                _picklistRoleEventId = value;
            }
        }

        public virtual PartyRoleId PartyRoleId
        {
            get { return PicklistRoleEventId.PartyRoleId; }
            set { PicklistRoleEventId.PartyRoleId = value; }
        }

		public virtual bool? Active { get; set; }

		public virtual string CreatedByUserLogin { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PicklistRoleEventId IGlobalIdentity<PicklistRoleEventId>.GlobalId {
			get 
			{
				return this.PicklistRoleEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IPicklistRoleEvent.ReadOnly
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IPicklistRoleStateMergePatched.IsPropertyActiveRemoved
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
				return this.CreatedByUserLogin;
			}
			set {
				this.CreatedByUserLogin = value;
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


        PicklistRoleEventId IPicklistRoleEvent.PicklistRoleEventId
        {
            get { return this.PicklistRoleEventId; }
        }

        protected PicklistRoleStateEventDtoBase()
        {
        }

        protected PicklistRoleStateEventDtoBase(PicklistRoleEventId stateEventId)
        {
            this.PicklistRoleEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class PicklistRoleStateCreatedOrMergePatchedOrRemovedDto : PicklistRoleStateEventDtoBase
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



	public class PicklistRoleStateCreatedDto : PicklistRoleStateCreatedOrMergePatchedOrRemovedDto
	{
		public PicklistRoleStateCreatedDto()
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


	public class PicklistRoleStateMergePatchedDto : PicklistRoleStateCreatedOrMergePatchedOrRemovedDto
	{
		public PicklistRoleStateMergePatchedDto()
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


	public class PicklistRoleStateRemovedDto : PicklistRoleStateCreatedOrMergePatchedOrRemovedDto
	{
		public PicklistRoleStateRemovedDto()
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


    public partial class PicklistRoleStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IPicklistRoleStateCreated>, IEnumerable<IPicklistRoleStateMergePatched>, IEnumerable<IPicklistRoleStateRemoved>
    {
        private List<PicklistRoleStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<PicklistRoleStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual PicklistRoleStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<PicklistRoleStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPicklistRoleStateCreated> IEnumerable<IPicklistRoleStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPicklistRoleStateMergePatched> IEnumerable<IPicklistRoleStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IPicklistRoleStateRemoved> IEnumerable<IPicklistRoleStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddPicklistRoleEvent(IPicklistRoleStateCreated e)
        {
            _innerStateEvents.Add((PicklistRoleStateCreatedDto)e);
        }

        public void AddPicklistRoleEvent(IPicklistRoleEvent e)
        {
            _innerStateEvents.Add((PicklistRoleStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddPicklistRoleEvent(IPicklistRoleStateRemoved e)
        {
            _innerStateEvents.Add((PicklistRoleStateRemovedDto)e);
        }

    }


}

