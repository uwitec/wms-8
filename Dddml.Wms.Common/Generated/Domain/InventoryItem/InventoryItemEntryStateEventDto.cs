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

	public abstract class InventoryItemEntryStateEventDtoBase : IStateEventDto, IInventoryItemEntryStateCreated
	{

        private InventoryItemEntryEventIdDto _inventoryItemEntryEventId;

		protected internal virtual InventoryItemEntryEventIdDto InventoryItemEntryEventId 
        {
            get 
            {
                if (_inventoryItemEntryEventId == null) { _inventoryItemEntryEventId = new InventoryItemEntryEventIdDto(); }
                return _inventoryItemEntryEventId;
            }
            set
            {
                _inventoryItemEntryEventId = value;
            }
        }

        public virtual long EntrySeqId
        {
            get { return InventoryItemEntryEventId.EntrySeqId; }
            set { InventoryItemEntryEventId.EntrySeqId = value; }
        }

		public virtual decimal? OnHandQuantity { get; set; }

		public virtual decimal? InTransitQuantity { get; set; }

		public virtual decimal? ReservedQuantity { get; set; }

		public virtual decimal? OccupiedQuantity { get; set; }

		public virtual decimal? VirtualQuantity { get; set; }

		private InventoryItemSourceInfoDto _source = new InventoryItemSourceInfoDto();

		public virtual InventoryItemSourceInfoDto Source { get { return _source; } set { _source = value; } }

		InventoryItemSourceInfo IInventoryItemEntryStateEvent.Source
		{ 
			get 
			{
				return this.Source == null ? null : this.Source.ToInventoryItemSourceInfo(); 
			} 
			set
			{
				if (value == null) { Source = null; } else { Source = new InventoryItemSourceInfoDtoWrapper(value); }
			} 
		}

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InventoryItemEntryEventId IGlobalIdentity<InventoryItemEntryEventId>.GlobalId {
			get 
			{
				return this.InventoryItemEntryEventId.ToInventoryItemEntryEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInventoryItemEntryStateEvent.ReadOnly
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


        InventoryItemEntryEventId IInventoryItemEntryStateEvent.InventoryItemEntryEventId
        {
            get { return this.InventoryItemEntryEventId.ToInventoryItemEntryEventId(); }
        }

        protected InventoryItemEntryStateEventDtoBase()
        {
        }

        protected InventoryItemEntryStateEventDtoBase(InventoryItemEntryEventIdDto stateEventId)
        {
            this.InventoryItemEntryEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto : InventoryItemEntryStateEventDtoBase
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



	public class InventoryItemEntryStateCreatedDto : InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto
	{
		public InventoryItemEntryStateCreatedDto()
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


	public class InventoryItemEntryStateMergePatchedDto : InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto
	{
		public InventoryItemEntryStateMergePatchedDto()
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


	public class InventoryItemEntryStateRemovedDto : InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto
	{
		public InventoryItemEntryStateRemovedDto()
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


    public partial class InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IInventoryItemEntryStateCreated>
    {
        private List<InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IInventoryItemEntryStateCreated> IEnumerable<IInventoryItemEntryStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddInventoryItemEntryEvent(IInventoryItemEntryStateCreated e)
        {
            _innerStateEvents.Add((InventoryItemEntryStateCreatedDto)e);
        }

        public void AddInventoryItemEntryEvent(IInventoryItemEntryStateEvent e)
        {
            _innerStateEvents.Add((InventoryItemEntryStateCreatedOrMergePatchedOrRemovedDto)e);
        }


    }


}

