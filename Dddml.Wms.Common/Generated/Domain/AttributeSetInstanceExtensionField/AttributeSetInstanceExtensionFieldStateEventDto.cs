﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionField;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionField
{

	public abstract class AttributeSetInstanceExtensionFieldStateEventDtoBase : IStateEventDto, IAttributeSetInstanceExtensionFieldStateCreated, IAttributeSetInstanceExtensionFieldStateMergePatched, IAttributeSetInstanceExtensionFieldStateDeleted
	{

        private AttributeSetInstanceExtensionFieldEventIdDto _attributeSetInstanceExtensionFieldEventId;

		protected internal virtual AttributeSetInstanceExtensionFieldEventIdDto AttributeSetInstanceExtensionFieldEventId 
        {
            get 
            {
                if (_attributeSetInstanceExtensionFieldEventId == null) { _attributeSetInstanceExtensionFieldEventId = new AttributeSetInstanceExtensionFieldEventIdDto(); }
                return _attributeSetInstanceExtensionFieldEventId;
            }
            set
            {
                _attributeSetInstanceExtensionFieldEventId = value;
            }
        }

        public virtual string Name
        {
            get { return AttributeSetInstanceExtensionFieldEventId.Name; }
            set { AttributeSetInstanceExtensionFieldEventId.Name = value; }
        }

        public virtual long Version
        {
            get { return AttributeSetInstanceExtensionFieldEventId.Version; }
            set { AttributeSetInstanceExtensionFieldEventId.Version = value; }
        }

		public virtual string Type { get; set; }

		public virtual int? Length { get; set; }

		public virtual string Alias { get; set; }

		public virtual string Description { get; set; }

		public virtual string GroupId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		AttributeSetInstanceExtensionFieldEventId IGlobalIdentity<AttributeSetInstanceExtensionFieldEventId>.GlobalId {
			get 
			{
				return this.AttributeSetInstanceExtensionFieldEventId.ToAttributeSetInstanceExtensionFieldEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IAttributeSetInstanceExtensionFieldStateEvent.ReadOnly
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

		public virtual bool? IsPropertyTypeRemoved { get; set; }

        bool IAttributeSetInstanceExtensionFieldStateMergePatched.IsPropertyTypeRemoved
        {
            get 
            {
                var b = this.IsPropertyTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyLengthRemoved { get; set; }

        bool IAttributeSetInstanceExtensionFieldStateMergePatched.IsPropertyLengthRemoved
        {
            get 
            {
                var b = this.IsPropertyLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyAliasRemoved { get; set; }

        bool IAttributeSetInstanceExtensionFieldStateMergePatched.IsPropertyAliasRemoved
        {
            get 
            {
                var b = this.IsPropertyAliasRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAliasRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IAttributeSetInstanceExtensionFieldStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyGroupIdRemoved { get; set; }

        bool IAttributeSetInstanceExtensionFieldStateMergePatched.IsPropertyGroupIdRemoved
        {
            get 
            {
                var b = this.IsPropertyGroupIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyGroupIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IAttributeSetInstanceExtensionFieldStateMergePatched.IsPropertyActiveRemoved
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


        AttributeSetInstanceExtensionFieldEventId IAttributeSetInstanceExtensionFieldStateEvent.AttributeSetInstanceExtensionFieldEventId
        {
            get { return this.AttributeSetInstanceExtensionFieldEventId.ToAttributeSetInstanceExtensionFieldEventId(); }
        }

        protected AttributeSetInstanceExtensionFieldStateEventDtoBase()
        {
        }

        protected AttributeSetInstanceExtensionFieldStateEventDtoBase(AttributeSetInstanceExtensionFieldEventIdDto stateEventId)
        {
            this.AttributeSetInstanceExtensionFieldEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto : AttributeSetInstanceExtensionFieldStateEventDtoBase
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



	public class AttributeSetInstanceExtensionFieldStateCreatedDto : AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeSetInstanceExtensionFieldStateCreatedDto()
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


	public class AttributeSetInstanceExtensionFieldStateMergePatchedDto : AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeSetInstanceExtensionFieldStateMergePatchedDto()
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


	public class AttributeSetInstanceExtensionFieldStateDeletedDto : AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto
	{
		public AttributeSetInstanceExtensionFieldStateDeletedDto()
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
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IAttributeSetInstanceExtensionFieldStateCreated>, IEnumerable<IAttributeSetInstanceExtensionFieldStateMergePatched>, IEnumerable<IAttributeSetInstanceExtensionFieldStateDeleted>
    {
        private List<AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeSetInstanceExtensionFieldStateCreated> IEnumerable<IAttributeSetInstanceExtensionFieldStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeSetInstanceExtensionFieldStateMergePatched> IEnumerable<IAttributeSetInstanceExtensionFieldStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IAttributeSetInstanceExtensionFieldStateDeleted> IEnumerable<IAttributeSetInstanceExtensionFieldStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddAttributeSetInstanceExtensionFieldEvent(IAttributeSetInstanceExtensionFieldStateCreated e)
        {
            _innerStateEvents.Add((AttributeSetInstanceExtensionFieldStateCreatedDto)e);
        }

        public void AddAttributeSetInstanceExtensionFieldEvent(IAttributeSetInstanceExtensionFieldStateEvent e)
        {
            _innerStateEvents.Add((AttributeSetInstanceExtensionFieldStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddAttributeSetInstanceExtensionFieldEvent(IAttributeSetInstanceExtensionFieldStateDeleted e)
        {
            _innerStateEvents.Add((AttributeSetInstanceExtensionFieldStateDeletedDto)e);
        }

    }


}

