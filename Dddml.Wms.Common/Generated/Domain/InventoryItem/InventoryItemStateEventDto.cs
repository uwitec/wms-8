﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

	public abstract class InventoryItemStateEventDtoBase : IStateEventDto, IInventoryItemStateCreated, IInventoryItemStateMergePatched
	{

        private InventoryItemStateEventIdDto _stateEventId;

		protected internal virtual InventoryItemStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new InventoryItemStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual InventoryItemIdDto InventoryItemId
        {
            get { return StateEventId.InventoryItemId; }
            set { StateEventId.InventoryItemId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual decimal? OnHandQuantity { get; set; }

		public virtual decimal? InTransitQuantity { get; set; }

		public virtual decimal? ReservedQuantity { get; set; }

		public virtual decimal? OccupiedQuantity { get; set; }

		public virtual decimal? VirtualQuantity { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InventoryItemStateEventId IGlobalIdentity<InventoryItemStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToInventoryItemStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInventoryItemStateEvent.ReadOnly
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

		public virtual bool? IsPropertyOnHandQuantityRemoved { get; set; }

        bool IInventoryItemStateMergePatched.IsPropertyOnHandQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyOnHandQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOnHandQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyInTransitQuantityRemoved { get; set; }

        bool IInventoryItemStateMergePatched.IsPropertyInTransitQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyInTransitQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInTransitQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyReservedQuantityRemoved { get; set; }

        bool IInventoryItemStateMergePatched.IsPropertyReservedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyReservedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyReservedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyOccupiedQuantityRemoved { get; set; }

        bool IInventoryItemStateMergePatched.IsPropertyOccupiedQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyOccupiedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOccupiedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyVirtualQuantityRemoved { get; set; }

        bool IInventoryItemStateMergePatched.IsPropertyVirtualQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyVirtualQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVirtualQuantityRemoved = value;
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


        private InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDtos _inventoryItemEntryEvents = new InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto[] InventoryItemEntryEvents
        {
            get
            {
                return _inventoryItemEntryEvents.ToArray();
            }
            set
            {
                _inventoryItemEntryEvents.Clear();
                _inventoryItemEntryEvents.AddRange(value);
            }
        }



        private InventoryItemEntryStateEventIdDto NewInventoryItemEntryStateEventId(long entrySeqId)
        {
            var eId = new InventoryItemEntryStateEventIdDto();
            eId.InventoryItemId = this.StateEventId.InventoryItemId;
            eId.EntrySeqId = entrySeqId;
            eId.InventoryItemVersion = this.StateEventId.Version;
            return eId;
        }

        public virtual InventoryItemEntryStateCreatedDto NewInventoryItemEntryStateCreated(long entrySeqId)
        {
            var e = new InventoryItemEntryStateCreatedDto();
            var eId = NewInventoryItemEntryStateEventId(entrySeqId);
            e.StateEventId = eId;
            return e;
        }

        IEnumerable<IInventoryItemEntryStateCreated> IInventoryItemStateCreated.InventoryItemEntryEvents
        {
            get { return this._inventoryItemEntryEvents; }
        }

        void IInventoryItemStateCreated.AddInventoryItemEntryEvent(IInventoryItemEntryStateCreated e)
        {
            this._inventoryItemEntryEvents.AddInventoryItemEntryEvent(e);
        }

        IInventoryItemEntryStateCreated IInventoryItemStateCreated.NewInventoryItemEntryStateCreated(long entrySeqId)
        {
            return NewInventoryItemEntryStateCreated(entrySeqId);
        }

        IEnumerable<IInventoryItemEntryStateEvent> IInventoryItemStateMergePatched.InventoryItemEntryEvents
        {
            get { return this._inventoryItemEntryEvents; }
        }

        void IInventoryItemStateMergePatched.AddInventoryItemEntryEvent(IInventoryItemEntryStateEvent e)
        {
            this._inventoryItemEntryEvents.AddInventoryItemEntryEvent(e);
        }

        IInventoryItemEntryStateCreated IInventoryItemStateMergePatched.NewInventoryItemEntryStateCreated(long entrySeqId)
        {
            return NewInventoryItemEntryStateCreated(entrySeqId);
        }


        InventoryItemStateEventId IInventoryItemStateEvent.StateEventId
        {
            get { return this.StateEventId.ToInventoryItemStateEventId(); }
        }

        protected InventoryItemStateEventDtoBase()
        {
        }

        protected InventoryItemStateEventDtoBase(InventoryItemStateEventIdDto stateEventId)
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


    public class InventoryItemStateCreatedOrMergePatchedOrDeletedDto : InventoryItemStateEventDtoBase
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



	public class InventoryItemStateCreatedDto : InventoryItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemStateCreatedDto()
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


	public class InventoryItemStateMergePatchedDto : InventoryItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemStateMergePatchedDto()
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


	public class InventoryItemStateDeletedDto : InventoryItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public InventoryItemStateDeletedDto()
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


    public partial class InventoryItemStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IInventoryItemStateCreated>, IEnumerable<IInventoryItemStateMergePatched>
    {
        private List<InventoryItemStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<InventoryItemStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual InventoryItemStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InventoryItemStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryItemStateCreated> IEnumerable<IInventoryItemStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryItemStateMergePatched> IEnumerable<IInventoryItemStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddInventoryItemEvent(IInventoryItemStateCreated e)
        {
            _innerStateEvents.Add((InventoryItemStateCreatedDto)e);
        }

        public void AddInventoryItemEvent(IInventoryItemStateEvent e)
        {
            _innerStateEvents.Add((InventoryItemStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

