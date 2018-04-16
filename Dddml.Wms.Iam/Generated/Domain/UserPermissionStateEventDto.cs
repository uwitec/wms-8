﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public abstract class UserPermissionStateEventDtoBase : IEventDto, IUserPermissionStateCreated, IUserPermissionStateMergePatched, IUserPermissionStateRemoved
	{

        private UserPermissionEventId _userPermissionEventId;

		protected internal virtual UserPermissionEventId UserPermissionEventId 
        {
            get 
            {
                if (_userPermissionEventId == null) { _userPermissionEventId = new UserPermissionEventId(); }
                return _userPermissionEventId;
            }
            set
            {
                _userPermissionEventId = value;
            }
        }

        public virtual string PermissionId
        {
            get { return UserPermissionEventId.PermissionId; }
            set { UserPermissionEventId.PermissionId = value; }
        }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		UserPermissionEventId IGlobalIdentity<UserPermissionEventId>.GlobalId {
			get 
			{
				return this.UserPermissionEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IUserPermissionEvent.ReadOnly
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

        bool IUserPermissionStateMergePatched.IsPropertyActiveRemoved
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


        UserPermissionEventId IUserPermissionEvent.UserPermissionEventId
        {
            get { return this.UserPermissionEventId; }
        }

        protected UserPermissionStateEventDtoBase()
        {
        }

        protected UserPermissionStateEventDtoBase(UserPermissionEventId stateEventId)
        {
            this.UserPermissionEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class UserPermissionStateCreatedOrMergePatchedOrRemovedDto : UserPermissionStateEventDtoBase
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



	public class UserPermissionStateCreatedDto : UserPermissionStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserPermissionStateCreatedDto()
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


	public class UserPermissionStateMergePatchedDto : UserPermissionStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserPermissionStateMergePatchedDto()
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


	public class UserPermissionStateRemovedDto : UserPermissionStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserPermissionStateRemovedDto()
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


    public partial class UserPermissionStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IUserPermissionStateCreated>, IEnumerable<IUserPermissionStateMergePatched>, IEnumerable<IUserPermissionStateRemoved>
    {
        private List<UserPermissionStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<UserPermissionStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual UserPermissionStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<UserPermissionStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionStateCreated> IEnumerable<IUserPermissionStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionStateMergePatched> IEnumerable<IUserPermissionStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserPermissionStateRemoved> IEnumerable<IUserPermissionStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddUserPermissionEvent(IUserPermissionStateCreated e)
        {
            _innerStateEvents.Add((UserPermissionStateCreatedDto)e);
        }

        public void AddUserPermissionEvent(IUserPermissionEvent e)
        {
            _innerStateEvents.Add((UserPermissionStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddUserPermissionEvent(IUserPermissionStateRemoved e)
        {
            _innerStateEvents.Add((UserPermissionStateRemovedDto)e);
        }

    }


}

