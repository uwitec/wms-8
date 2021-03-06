﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageReason;

namespace Dddml.Wms.Domain.DamageReason
{

	public abstract class DamageReasonEventBase : IDamageReasonEvent
	{

		public virtual DamageReasonEventId DamageReasonEventId { get; set; }

        public virtual string DamageReasonId
        {
            get { return DamageReasonEventId.DamageReasonId; }
            set { DamageReasonEventId.DamageReasonId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		DamageReasonEventId IGlobalIdentity<DamageReasonEventId>.GlobalId {
			get
			{
				return this.DamageReasonEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IDamageReasonEvent.ReadOnly
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

        protected DamageReasonEventBase()
        {
        }

        protected DamageReasonEventBase(DamageReasonEventId stateEventId)
        {
            this.DamageReasonEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class DamageReasonStateEventBase : DamageReasonEventBase, IDamageReasonStateEvent
    {

		public virtual string Description { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual bool? Active { get; set; }

        protected DamageReasonStateEventBase() : base()
        {
        }

        protected DamageReasonStateEventBase(DamageReasonEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class DamageReasonStateCreated : DamageReasonStateEventBase, IDamageReasonStateCreated
	{
		public DamageReasonStateCreated () : this(new DamageReasonEventId())
		{
		}

		public DamageReasonStateCreated (DamageReasonEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class DamageReasonStateMergePatched : DamageReasonStateEventBase, IDamageReasonStateMergePatched
	{
		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertySequenceIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public DamageReasonStateMergePatched ()
		{
		}

		public DamageReasonStateMergePatched (DamageReasonEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class DamageReasonStateDeleted : DamageReasonStateEventBase, IDamageReasonStateDeleted
	{
		public DamageReasonStateDeleted ()
		{
		}

		public DamageReasonStateDeleted (DamageReasonEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

