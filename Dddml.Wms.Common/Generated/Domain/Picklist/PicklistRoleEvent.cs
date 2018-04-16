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

	public abstract class PicklistRoleEventBase : IPicklistRoleEvent
	{

		public virtual PicklistRoleEventId PicklistRoleEventId { get; set; }

        public virtual PartyRoleId PartyRoleId
        {
            get { return PicklistRoleEventId.PartyRoleId; }
            set { PicklistRoleEventId.PartyRoleId = value; }
        }

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

        protected PicklistRoleEventBase()
        {
        }

        protected PicklistRoleEventBase(PicklistRoleEventId stateEventId)
        {
            this.PicklistRoleEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class PicklistRoleStateEventBase : PicklistRoleEventBase, IPicklistRoleStateEvent
    {

		public virtual bool? Active { get; set; }

        protected PicklistRoleStateEventBase() : base()
        {
        }

        protected PicklistRoleStateEventBase(PicklistRoleEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class PicklistRoleStateCreated : PicklistRoleStateEventBase, IPicklistRoleStateCreated
	{
		public PicklistRoleStateCreated () : this(new PicklistRoleEventId())
		{
		}

		public PicklistRoleStateCreated (PicklistRoleEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PicklistRoleStateMergePatched : PicklistRoleStateEventBase, IPicklistRoleStateMergePatched
	{
		public virtual bool IsPropertyActiveRemoved { get; set; }


		public PicklistRoleStateMergePatched ()
		{
		}

		public PicklistRoleStateMergePatched (PicklistRoleEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class PicklistRoleStateRemoved : PicklistRoleStateEventBase, IPicklistRoleStateRemoved
	{
		public PicklistRoleStateRemoved ()
		{
		}

		public PicklistRoleStateRemoved (PicklistRoleEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

