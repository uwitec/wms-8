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

	public abstract class UserClaimStateEventDtoBase : IStateEventDto, IUserClaimStateCreated, IUserClaimStateMergePatched, IUserClaimStateRemoved
	{

        private UserClaimEventId _userClaimEventId;

		protected internal virtual UserClaimEventId UserClaimEventId 
        {
            get 
            {
                if (_userClaimEventId == null) { _userClaimEventId = new UserClaimEventId(); }
                return _userClaimEventId;
            }
            set
            {
                _userClaimEventId = value;
            }
        }

        public virtual int ClaimId
        {
            get { return UserClaimEventId.ClaimId; }
            set { UserClaimEventId.ClaimId = value; }
        }

		public virtual string ClaimType { get; set; }

		public virtual string ClaimValue { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		UserClaimEventId IGlobalIdentity<UserClaimEventId>.GlobalId {
			get 
			{
				return this.UserClaimEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IUserClaimStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual long Version { get; set; }

		public virtual bool? IsPropertyClaimTypeRemoved { get; set; }

        bool IUserClaimStateMergePatched.IsPropertyClaimTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyClaimTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyClaimTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyClaimValueRemoved { get; set; }

        bool IUserClaimStateMergePatched.IsPropertyClaimValueRemoved
        {
            get 
            {
                var b = this.IsPropertyClaimValueRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyClaimValueRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IUserClaimStateMergePatched.IsPropertyActiveRemoved
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


        UserClaimEventId IUserClaimStateEvent.UserClaimEventId
        {
            get { return this.UserClaimEventId; }
        }

        protected UserClaimStateEventDtoBase()
        {
        }

        protected UserClaimStateEventDtoBase(UserClaimEventId stateEventId)
        {
            this.UserClaimEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class UserClaimStateCreatedOrMergePatchedOrRemovedDto : UserClaimStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class UserClaimStateCreatedDto : UserClaimStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserClaimStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class UserClaimStateMergePatchedDto : UserClaimStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserClaimStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class UserClaimStateRemovedDto : UserClaimStateCreatedOrMergePatchedOrRemovedDto
	{
		public UserClaimStateRemovedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class UserClaimStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IUserClaimStateCreated>, IEnumerable<IUserClaimStateMergePatched>, IEnumerable<IUserClaimStateRemoved>
    {
        private List<UserClaimStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<UserClaimStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual UserClaimStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<UserClaimStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserClaimStateCreated> IEnumerable<IUserClaimStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserClaimStateMergePatched> IEnumerable<IUserClaimStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IUserClaimStateRemoved> IEnumerable<IUserClaimStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddUserClaimEvent(IUserClaimStateCreated e)
        {
            _innerStateEvents.Add((UserClaimStateCreatedDto)e);
        }

        public void AddUserClaimEvent(IUserClaimStateEvent e)
        {
            _innerStateEvents.Add((UserClaimStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddUserClaimEvent(IUserClaimStateRemoved e)
        {
            _innerStateEvents.Add((UserClaimStateRemovedDto)e);
        }

    }


}

