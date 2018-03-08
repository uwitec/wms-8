﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public abstract class AttributeAliasStateEventDtoBase : IStateEventDto, IAttributeAliasStateCreated, IAttributeAliasStateMergePatched, IAttributeAliasStateRemoved
	{

        private AttributeAliasEventIdDto _attributeAliasEventId;

		protected internal virtual AttributeAliasEventIdDto AttributeAliasEventId 
        {
            get 
            {
                if (_attributeAliasEventId == null) { _attributeAliasEventId = new AttributeAliasEventIdDto(); }
                return _attributeAliasEventId;
            }
            set
            {
                _attributeAliasEventId = value;
            }
        }

        public virtual string Code
        {
            get { return AttributeAliasEventId.Code; }
            set { AttributeAliasEventId.Code = value; }
        }

		public virtual string Name { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeAliasEventId IGlobalIdentity<AttributeAliasEventId>.GlobalId {
			get 
			{
				return this.AttributeAliasEventId.ToAttributeAliasEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeAliasStateEvent.ReadOnly
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

		public virtual bool? IsPropertyNameRemoved { get; set; }

        bool IAttributeAliasStateMergePatched.IsPropertyNameRemoved
        {
            get 
            {
                var b = this.IsPropertyNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IAttributeAliasStateMergePatched.IsPropertyActiveRemoved
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


        AttributeAliasEventId IAttributeAliasStateEvent.AttributeAliasEventId
        {
            get { return this.AttributeAliasEventId.ToAttributeAliasEventId(); }
        }

        protected AttributeAliasStateEventDtoBase()
        {
        }

        protected AttributeAliasStateEventDtoBase(AttributeAliasEventIdDto stateEventId)
        {
            this.AttributeAliasEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class AttributeAliasStateCreatedOrMergePatchedOrRemovedDto : AttributeAliasStateEventDtoBase
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



	public class AttributeAliasStateCreatedDto : AttributeAliasStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeAliasStateCreatedDto()
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


	public class AttributeAliasStateMergePatchedDto : AttributeAliasStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeAliasStateMergePatchedDto()
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


	public class AttributeAliasStateRemovedDto : AttributeAliasStateCreatedOrMergePatchedOrRemovedDto
	{
		public AttributeAliasStateRemovedDto()
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


    public partial class AttributeAliasStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IAttributeAliasStateCreated>, IEnumerable<IAttributeAliasStateMergePatched>, IEnumerable<IAttributeAliasStateRemoved>
    {
        private List<AttributeAliasStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<AttributeAliasStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual AttributeAliasStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AttributeAliasStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeAliasStateCreated> IEnumerable<IAttributeAliasStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeAliasStateMergePatched> IEnumerable<IAttributeAliasStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeAliasStateRemoved> IEnumerable<IAttributeAliasStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAttributeAliasEvent(IAttributeAliasStateCreated e)
        {
            _innerStateEvents.Add((AttributeAliasStateCreatedDto)e);
        }

        public void AddAttributeAliasEvent(IAttributeAliasStateEvent e)
        {
            _innerStateEvents.Add((AttributeAliasStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddAttributeAliasEvent(IAttributeAliasStateRemoved e)
        {
            _innerStateEvents.Add((AttributeAliasStateRemovedDto)e);
        }

    }


}

