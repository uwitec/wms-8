﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePickwaveDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Pickwave;

namespace Dddml.Wms.Domain.Pickwave
{

	public abstract class PickwaveEventBase : IPickwaveEvent
	{

		public virtual PickwaveEventId PickwaveEventId { get; set; }

        public virtual long? PickwaveId
        {
            get { return PickwaveEventId.PickwaveId; }
            set { PickwaveEventId.PickwaveId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		PickwaveEventId IGlobalIdentity<PickwaveEventId>.GlobalId {
			get
			{
				return this.PickwaveEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IPickwaveEvent.ReadOnly
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

        protected PickwaveEventBase()
        {
        }

        protected PickwaveEventBase(PickwaveEventId stateEventId)
        {
            this.PickwaveEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class PickwaveStateEventBase : PickwaveEventBase, IPickwaveStateEvent
    {

		public virtual string StatusId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

        protected PickwaveStateEventBase() : base()
        {
        }

        protected PickwaveStateEventBase(PickwaveEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class PickwaveStateCreated : PickwaveStateEventBase, IPickwaveStateCreated
	{
		public PickwaveStateCreated () : this(new PickwaveEventId())
		{
		}

		public PickwaveStateCreated (PickwaveEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class PickwaveStateMergePatched : PickwaveStateEventBase, IPickwaveStateMergePatched
	{
		public virtual bool IsPropertyStatusIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public PickwaveStateMergePatched ()
		{
		}

		public PickwaveStateMergePatched (PickwaveEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class PickwaveStateDeleted : PickwaveStateEventBase, IPickwaveStateDeleted
	{
		public PickwaveStateDeleted ()
		{
		}

		public PickwaveStateDeleted (PickwaveEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

