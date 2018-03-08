﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Audience;

namespace Dddml.Wms.Domain.Audience
{

	public abstract class AudienceStateEventBase : IAudienceStateEvent
	{

		public virtual AudienceEventId AudienceEventId { get; set; }

        public virtual string ClientId
        {
            get { return AudienceEventId.ClientId; }
            set { AudienceEventId.ClientId = value; }
        }

		public virtual string Name { get; set; }

		public virtual string Base64Secret { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AudienceEventId IGlobalIdentity<AudienceEventId>.GlobalId {
			get
			{
				return this.AudienceEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAudienceStateEvent.ReadOnly
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

        protected AudienceStateEventBase()
        {
        }

        protected AudienceStateEventBase(AudienceEventId stateEventId)
        {
            this.AudienceEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class AudienceStateCreated : AudienceStateEventBase, IAudienceStateCreated
	{
		public AudienceStateCreated () : this(new AudienceEventId())
		{
		}

		public AudienceStateCreated (AudienceEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AudienceStateMergePatched : AudienceStateEventBase, IAudienceStateMergePatched
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyBase64SecretRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AudienceStateMergePatched ()
		{
		}

		public AudienceStateMergePatched (AudienceEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AudienceStateDeleted : AudienceStateEventBase, IAudienceStateDeleted
	{
		public AudienceStateDeleted ()
		{
		}

		public AudienceStateDeleted (AudienceEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

