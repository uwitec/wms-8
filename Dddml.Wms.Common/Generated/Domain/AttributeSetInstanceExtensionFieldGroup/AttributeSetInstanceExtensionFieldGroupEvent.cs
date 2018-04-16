﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup
{

	public abstract class AttributeSetInstanceExtensionFieldGroupEventBase : IAttributeSetInstanceExtensionFieldGroupEvent
	{

		public virtual AttributeSetInstanceExtensionFieldGroupEventId AttributeSetInstanceExtensionFieldGroupEventId { get; set; }

        public virtual string Id
        {
            get { return AttributeSetInstanceExtensionFieldGroupEventId.Id; }
            set { AttributeSetInstanceExtensionFieldGroupEventId.Id = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeSetInstanceExtensionFieldGroupEventId IGlobalIdentity<AttributeSetInstanceExtensionFieldGroupEventId>.GlobalId {
			get
			{
				return this.AttributeSetInstanceExtensionFieldGroupEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IAttributeSetInstanceExtensionFieldGroupEvent.ReadOnly
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

        protected AttributeSetInstanceExtensionFieldGroupEventBase()
        {
        }

        protected AttributeSetInstanceExtensionFieldGroupEventBase(AttributeSetInstanceExtensionFieldGroupEventId stateEventId)
        {
            this.AttributeSetInstanceExtensionFieldGroupEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class AttributeSetInstanceExtensionFieldGroupStateEventBase : AttributeSetInstanceExtensionFieldGroupEventBase, IAttributeSetInstanceExtensionFieldGroupStateEvent
    {

		public virtual string FieldType { get; set; }

		public virtual int? FieldLength { get; set; }

		public virtual int? FieldCount { get; set; }

		public virtual string NameFormat { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

        protected AttributeSetInstanceExtensionFieldGroupStateEventBase() : base()
        {
        }

        protected AttributeSetInstanceExtensionFieldGroupStateEventBase(AttributeSetInstanceExtensionFieldGroupEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class AttributeSetInstanceExtensionFieldGroupStateCreated : AttributeSetInstanceExtensionFieldGroupStateEventBase, IAttributeSetInstanceExtensionFieldGroupStateCreated
	{
		public AttributeSetInstanceExtensionFieldGroupStateCreated () : this(new AttributeSetInstanceExtensionFieldGroupEventId())
		{
		}

		public AttributeSetInstanceExtensionFieldGroupStateCreated (AttributeSetInstanceExtensionFieldGroupEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class AttributeSetInstanceExtensionFieldGroupStateMergePatched : AttributeSetInstanceExtensionFieldGroupStateEventBase, IAttributeSetInstanceExtensionFieldGroupStateMergePatched
	{
		public virtual bool IsPropertyFieldTypeRemoved { get; set; }

		public virtual bool IsPropertyFieldLengthRemoved { get; set; }

		public virtual bool IsPropertyFieldCountRemoved { get; set; }

		public virtual bool IsPropertyNameFormatRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeSetInstanceExtensionFieldGroupStateMergePatched ()
		{
		}

		public AttributeSetInstanceExtensionFieldGroupStateMergePatched (AttributeSetInstanceExtensionFieldGroupEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class AttributeSetInstanceExtensionFieldGroupStateDeleted : AttributeSetInstanceExtensionFieldGroupStateEventBase, IAttributeSetInstanceExtensionFieldGroupStateDeleted
	{
		public AttributeSetInstanceExtensionFieldGroupStateDeleted ()
		{
		}

		public AttributeSetInstanceExtensionFieldGroupStateDeleted (AttributeSetInstanceExtensionFieldGroupEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

