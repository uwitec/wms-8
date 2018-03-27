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

	public abstract class PicklistRoleStateEventBase : IPicklistRoleStateEvent
	{

		public virtual PicklistRoleEventId PicklistRoleEventId { get; set; }

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

        public virtual bool StateEventReadOnly { get; set; }

        bool IPicklistRoleStateEvent.ReadOnly
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

        protected PicklistRoleStateEventBase()
        {
        }

        protected PicklistRoleStateEventBase(PicklistRoleEventId stateEventId)
        {
            this.PicklistRoleEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class PicklistRoleStateCreated : PicklistRoleStateEventBase, IPicklistRoleStateCreated
	{
		public PicklistRoleStateCreated () : this(new PicklistRoleEventId())
		{
		}

		public PicklistRoleStateCreated (PicklistRoleEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
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


        protected override string GetStateEventType()
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

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

