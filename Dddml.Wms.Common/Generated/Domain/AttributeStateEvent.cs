﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public abstract class AttributeStateEventBase : IAttributeStateEvent
	{

		public virtual AttributeStateEventId StateEventId { get; set; }

		public virtual string Name { get; set; }

		public virtual string OrganizationId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? IsMandatory { get; set; }

		public virtual bool? IsInstanceAttribute { get; set; }

		public virtual string AttributeValueType { get; set; }

		public virtual int? AttributeValueLength { get; set; }

		public virtual bool? IsList { get; set; }

		public virtual string FieldName { get; set; }

		public virtual string ReferenceId { get; set; }

		public virtual bool? Active { get; set; }


		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

		AttributeStateEventId IGlobalIdentity<AttributeStateEventId>.GlobalId {
			get {
				return this.StateEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeStateEvent.ReadOnly
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

/*
		public virtual string AttributeId {
			get {
				return StateEventId.AttributeId;
			}
			set {
				StateEventId.AttributeId = value;
			}
		}

		public virtual long Version {
			get {
				return StateEventId.Version;
			}
			set {
				StateEventId.Version = value;
			}
		}
*/

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

        protected AttributeStateEventBase()
        {
        }

        protected AttributeStateEventBase(AttributeStateEventId stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        protected AttributeValueStateEventId NewAttributeValueStateEventId(string value)
        {
            var stateEventId = new AttributeValueStateEventId(this.StateEventId.AttributeId, value, this.StateEventId.Version);
            return stateEventId;
        }

		protected void ThrowOnInconsistentEventIds(IAttributeValueStateEvent e)
		{
			if (this.StateEventId.AttributeId != e.StateEventId.AttributeId) 
			{ 
				DomainError.Named("inconsistentEventIds", "Outer Id AttributeId {0} but inner id AttributeId {1}", 
					this.StateEventId.AttributeId, e.StateEventId.AttributeId);
			}
		}



        public abstract string StateEventType { get; }

	}

	public class AttributeStateCreated : AttributeStateEventBase, IAttributeStateCreated, ISaveable
	{
		public AttributeStateCreated ()
		{
		}

		public AttributeStateCreated (AttributeStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<AttributeValueStateEventId, IAttributeValueStateCreated> _attributeValueEvents = new Dictionary<AttributeValueStateEventId, IAttributeValueStateCreated>();
		
        private IEnumerable<IAttributeValueStateCreated> _readOnlyAttributeValueEvents;

        public virtual IEnumerable<IAttributeValueStateCreated> AttributeValueEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
					return this._attributeValueEvents.Values;
                }
                else
                {
                    if (_readOnlyAttributeValueEvents != null) { return _readOnlyAttributeValueEvents; }
                    var eventDao = ApplicationContext.Current["AttributeValueStateEventDao"] as IAttributeValueStateEventDao;
                    var eL = new List<IAttributeValueStateCreated>();
                    foreach (var e in eventDao.FindByAttributeStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IAttributeValueStateCreated)e);
                    }
                    return (_readOnlyAttributeValueEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddAttributeValueEvent(e);
                    }
                }
            }
        }
	
		public virtual void AddAttributeValueEvent(IAttributeValueStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeValueEvents[e.StateEventId] = e;
		}

        public virtual IAttributeValueStateCreated NewAttributeValueStateCreated(string value)
        {
            var stateEvent = new AttributeValueStateCreated(NewAttributeValueStateEventId(value));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeValueStateCreated e in this.AttributeValueEvents) {
				(ApplicationContext.Current["AttributeValueStateEventDao"] as IAttributeValueStateEventDao).Save(e);
			}
		}

        public override string StateEventType
        {
            get
            {
                return Dddml.Wms.Specialization.StateEventType.Created;
            }
        }

	}


	public class AttributeStateMergePatched : AttributeStateEventBase, IAttributeStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyNameRemoved { get; set; }

		public virtual bool IsPropertyOrganizationIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyIsMandatoryRemoved { get; set; }

		public virtual bool IsPropertyIsInstanceAttributeRemoved { get; set; }

		public virtual bool IsPropertyAttributeValueTypeRemoved { get; set; }

		public virtual bool IsPropertyAttributeValueLengthRemoved { get; set; }

		public virtual bool IsPropertyIsListRemoved { get; set; }

		public virtual bool IsPropertyFieldNameRemoved { get; set; }

		public virtual bool IsPropertyReferenceIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public AttributeStateMergePatched ()
		{
		}

		public AttributeStateMergePatched (AttributeStateEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<AttributeValueStateEventId, IAttributeValueStateEvent> _attributeValueEvents = new Dictionary<AttributeValueStateEventId, IAttributeValueStateEvent>();

	    private IEnumerable<IAttributeValueStateEvent> _readOnlyAttributeValueEvents;
		
        public virtual IEnumerable<IAttributeValueStateEvent> AttributeValueEvents
        {
            get
            {
                if (!StateEventReadOnly)
                {
					return this._attributeValueEvents.Values;
                }
                else
                {
                    if (_readOnlyAttributeValueEvents != null) { return _readOnlyAttributeValueEvents; }
                    var eventDao = ApplicationContext.Current["AttributeValueStateEventDao"] as IAttributeValueStateEventDao;
                    var eL = new List<IAttributeValueStateEvent>();
                    foreach (var e in eventDao.FindByAttributeStateEventId(this.StateEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IAttributeValueStateEvent)e);
                    }
                    return (_readOnlyAttributeValueEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddAttributeValueEvent(e);
                    }
                }
            }
        }

		public virtual void AddAttributeValueEvent(IAttributeValueStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._attributeValueEvents[e.StateEventId] = e;
		}

        public virtual IAttributeValueStateCreated NewAttributeValueStateCreated(string value)
        {
            var stateEvent = new AttributeValueStateCreated(NewAttributeValueStateEventId(value));
            return stateEvent;
        }

        public virtual IAttributeValueStateMergePatched NewAttributeValueStateMergePatched(string value)
        {
            var stateEvent = new AttributeValueStateMergePatched(NewAttributeValueStateEventId(value));
            return stateEvent;
        }

        public virtual IAttributeValueStateRemoved NewAttributeValueStateRemoved(string value)
        {
            var stateEvent = new AttributeValueStateRemoved(NewAttributeValueStateEventId(value));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IAttributeValueStateEvent e in this.AttributeValueEvents) {
				(ApplicationContext.Current["AttributeValueStateEventDao"] as IAttributeValueStateEventDao).Save(e);
			}
		}

        public override string StateEventType
        {
            get
            {
                return Dddml.Wms.Specialization.StateEventType.MergePatched;
            }
        }

	}


	public class AttributeStateDeleted : AttributeStateEventBase, IAttributeStateDeleted
	{
		public AttributeStateDeleted ()
		{
		}

		public AttributeStateDeleted (AttributeStateEventId stateEventId) : base(stateEventId)
		{
		}

        public override string StateEventType
        {
            get
            {
                return Dddml.Wms.Specialization.StateEventType.Deleted;
            }
        }

	}



}

