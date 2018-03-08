﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageType;

namespace Dddml.Wms.Domain.DamageType
{

	public abstract class DamageTypeStateEventBase : IDamageTypeStateEvent
	{

		public virtual DamageTypeEventId DamageTypeEventId { get; set; }

        public virtual string DamageTypeId
        {
            get { return DamageTypeEventId.DamageTypeId; }
            set { DamageTypeEventId.DamageTypeId = value; }
        }

		public virtual string Description { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual string DefaultHandlingMethodId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		DamageTypeEventId IGlobalIdentity<DamageTypeEventId>.GlobalId {
			get
			{
				return this.DamageTypeEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IDamageTypeStateEvent.ReadOnly
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

        protected DamageTypeStateEventBase()
        {
        }

        protected DamageTypeStateEventBase(DamageTypeEventId stateEventId)
        {
            this.DamageTypeEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class DamageTypeStateCreated : DamageTypeStateEventBase, IDamageTypeStateCreated
	{
		public DamageTypeStateCreated () : this(new DamageTypeEventId())
		{
		}

		public DamageTypeStateCreated (DamageTypeEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class DamageTypeStateMergePatched : DamageTypeStateEventBase, IDamageTypeStateMergePatched
	{
		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertySequenceIdRemoved { get; set; }

		public virtual bool IsPropertyDefaultHandlingMethodIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public DamageTypeStateMergePatched ()
		{
		}

		public DamageTypeStateMergePatched (DamageTypeEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class DamageTypeStateDeleted : DamageTypeStateEventBase, IDamageTypeStateDeleted
	{
		public DamageTypeStateDeleted ()
		{
		}

		public DamageTypeStateDeleted (DamageTypeEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

