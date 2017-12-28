﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{

	public abstract class SellableInventoryItemEntryMvoStateEventDtoBase : IStateEventDto, ISellableInventoryItemEntryMvoStateCreated, ISellableInventoryItemEntryMvoStateMergePatched
	{

        private SellableInventoryItemEntryMvoStateEventIdDto _stateEventId;

		protected internal virtual SellableInventoryItemEntryMvoStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new SellableInventoryItemEntryMvoStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual SellableInventoryItemEntryIdDto SellableInventoryItemEntryId
        {
            get { return StateEventId.SellableInventoryItemEntryId; }
            set { StateEventId.SellableInventoryItemEntryId = value; }
        }

        public virtual long SellableInventoryItemVersion
        {
            get { return StateEventId.SellableInventoryItemVersion; }
            set { StateEventId.SellableInventoryItemVersion = value; }
        }

		public virtual decimal? SellableQuantity { get; set; }

		private InventoryPRTriggeredIdDto _sourceEventId = new InventoryPRTriggeredIdDto();

		public virtual InventoryPRTriggeredIdDto SourceEventId { get { return _sourceEventId; } set { _sourceEventId = value; } }

		InventoryPRTriggeredId ISellableInventoryItemEntryMvoStateEvent.SourceEventId
		{ 
			get 
			{
				return this.SourceEventId == null ? null : this.SourceEventId.ToInventoryPRTriggeredId(); 
			} 
			set
			{
				if (value == null) { SourceEventId = null; } else { SourceEventId = new InventoryPRTriggeredIdDtoWrapper(value); }
			} 
		}

		public virtual long? Version { get; set; }

		public virtual decimal? SellableInventoryItemSellableQuantity { get; set; }

		public virtual string SellableInventoryItemCreatedBy { get; set; }

		public virtual DateTime? SellableInventoryItemCreatedAt { get; set; }

		public virtual string SellableInventoryItemUpdatedBy { get; set; }

		public virtual DateTime? SellableInventoryItemUpdatedAt { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		SellableInventoryItemEntryMvoStateEventId IGlobalIdentity<SellableInventoryItemEntryMvoStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToSellableInventoryItemEntryMvoStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool ISellableInventoryItemEntryMvoStateEvent.ReadOnly
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

		public virtual bool? IsPropertySellableQuantityRemoved { get; set; }

        bool ISellableInventoryItemEntryMvoStateMergePatched.IsPropertySellableQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertySellableQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySellableQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertySourceEventIdRemoved { get; set; }

        bool ISellableInventoryItemEntryMvoStateMergePatched.IsPropertySourceEventIdRemoved
        {
            get 
            {
                var b = this.IsPropertySourceEventIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySourceEventIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyVersionRemoved { get; set; }

        bool ISellableInventoryItemEntryMvoStateMergePatched.IsPropertyVersionRemoved
        {
            get 
            {
                var b = this.IsPropertyVersionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVersionRemoved = value;
            }
        }

		public virtual bool? IsPropertySellableInventoryItemSellableQuantityRemoved { get; set; }

        bool ISellableInventoryItemEntryMvoStateMergePatched.IsPropertySellableInventoryItemSellableQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertySellableInventoryItemSellableQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySellableInventoryItemSellableQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertySellableInventoryItemCreatedByRemoved { get; set; }

        bool ISellableInventoryItemEntryMvoStateMergePatched.IsPropertySellableInventoryItemCreatedByRemoved
        {
            get 
            {
                var b = this.IsPropertySellableInventoryItemCreatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySellableInventoryItemCreatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertySellableInventoryItemCreatedAtRemoved { get; set; }

        bool ISellableInventoryItemEntryMvoStateMergePatched.IsPropertySellableInventoryItemCreatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertySellableInventoryItemCreatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySellableInventoryItemCreatedAtRemoved = value;
            }
        }

		public virtual bool? IsPropertySellableInventoryItemUpdatedByRemoved { get; set; }

        bool ISellableInventoryItemEntryMvoStateMergePatched.IsPropertySellableInventoryItemUpdatedByRemoved
        {
            get 
            {
                var b = this.IsPropertySellableInventoryItemUpdatedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySellableInventoryItemUpdatedByRemoved = value;
            }
        }

		public virtual bool? IsPropertySellableInventoryItemUpdatedAtRemoved { get; set; }

        bool ISellableInventoryItemEntryMvoStateMergePatched.IsPropertySellableInventoryItemUpdatedAtRemoved
        {
            get 
            {
                var b = this.IsPropertySellableInventoryItemUpdatedAtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySellableInventoryItemUpdatedAtRemoved = value;
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


        SellableInventoryItemEntryMvoStateEventId ISellableInventoryItemEntryMvoStateEvent.StateEventId
        {
            get { return this.StateEventId.ToSellableInventoryItemEntryMvoStateEventId(); }
        }

        protected SellableInventoryItemEntryMvoStateEventDtoBase()
        {
        }

        protected SellableInventoryItemEntryMvoStateEventDtoBase(SellableInventoryItemEntryMvoStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto : SellableInventoryItemEntryMvoStateEventDtoBase
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



	public class SellableInventoryItemEntryMvoStateCreatedDto : SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public SellableInventoryItemEntryMvoStateCreatedDto()
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


	public class SellableInventoryItemEntryMvoStateMergePatchedDto : SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public SellableInventoryItemEntryMvoStateMergePatchedDto()
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


	public class SellableInventoryItemEntryMvoStateDeletedDto : SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto
	{
		public SellableInventoryItemEntryMvoStateDeletedDto()
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


    public partial class SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<ISellableInventoryItemEntryMvoStateCreated>, IEnumerable<ISellableInventoryItemEntryMvoStateMergePatched>
    {
        private List<SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<ISellableInventoryItemEntryMvoStateCreated> IEnumerable<ISellableInventoryItemEntryMvoStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<ISellableInventoryItemEntryMvoStateMergePatched> IEnumerable<ISellableInventoryItemEntryMvoStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddSellableInventoryItemEntryMvoEvent(ISellableInventoryItemEntryMvoStateCreated e)
        {
            _innerStateEvents.Add((SellableInventoryItemEntryMvoStateCreatedDto)e);
        }

        public void AddSellableInventoryItemEntryMvoEvent(ISellableInventoryItemEntryMvoStateEvent e)
        {
            _innerStateEvents.Add((SellableInventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

