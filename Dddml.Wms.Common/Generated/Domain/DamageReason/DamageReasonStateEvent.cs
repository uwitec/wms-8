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

	public abstract class DamageReasonStateEventBase : IDamageReasonStateEvent
	{

		public virtual DamageReasonEventId DamageReasonEventId { get; set; }

        public virtual string DamageReasonId
        {
            get { return DamageReasonEventId.DamageReasonId; }
            set { DamageReasonEventId.DamageReasonId = value; }
        }

		public virtual string Description { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual bool? Active { get; set; }

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

        public virtual bool StateEventReadOnly { get; set; }

        bool IDamageReasonStateEvent.ReadOnly
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

        protected DamageReasonStateEventBase()
        {
        }

        protected DamageReasonStateEventBase(DamageReasonEventId stateEventId)
        {
            this.DamageReasonEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class DamageReasonStateCreated : DamageReasonStateEventBase, IDamageReasonStateCreated
	{
		public DamageReasonStateCreated () : this(new DamageReasonEventId())
		{
		}

		public DamageReasonStateCreated (DamageReasonEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
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


        protected override string GetStateEventType()
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

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

