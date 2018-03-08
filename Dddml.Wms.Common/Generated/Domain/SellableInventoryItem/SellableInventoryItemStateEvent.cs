﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItem
{

	public abstract class SellableInventoryItemStateEventBase : ISellableInventoryItemStateEvent
	{

		public virtual SellableInventoryItemEventId SellableInventoryItemEventId { get; set; }

        public virtual InventoryItemId SellableInventoryItemId
        {
            get { return SellableInventoryItemEventId.SellableInventoryItemId; }
            set { SellableInventoryItemEventId.SellableInventoryItemId = value; }
        }

		public virtual decimal? SellableQuantity { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		SellableInventoryItemEventId IGlobalIdentity<SellableInventoryItemEventId>.GlobalId {
			get
			{
				return this.SellableInventoryItemEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool ISellableInventoryItemStateEvent.ReadOnly
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

        protected SellableInventoryItemStateEventBase()
        {
        }

        protected SellableInventoryItemStateEventBase(SellableInventoryItemEventId stateEventId)
        {
            this.SellableInventoryItemEventId = stateEventId;
        }

        protected SellableInventoryItemEntryEventId NewSellableInventoryItemEntryEventId(long entrySeqId)
        {
            var stateEventId = new SellableInventoryItemEntryEventId(this.SellableInventoryItemEventId.SellableInventoryItemId, entrySeqId, this.SellableInventoryItemEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(ISellableInventoryItemEntryStateEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(ISellableInventoryItemStateEvent oe, ISellableInventoryItemEntryStateEvent e)
		{
			if (!oe.SellableInventoryItemEventId.SellableInventoryItemId.Equals(e.SellableInventoryItemEntryEventId.SellableInventoryItemId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id SellableInventoryItemId {0} but inner id SellableInventoryItemId {1}", 
					oe.SellableInventoryItemEventId.SellableInventoryItemId, e.SellableInventoryItemEntryEventId.SellableInventoryItemId);
			}
		}



        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class SellableInventoryItemStateCreated : SellableInventoryItemStateEventBase, ISellableInventoryItemStateCreated
	{
		public SellableInventoryItemStateCreated () : this(new SellableInventoryItemEventId())
		{
		}

		public SellableInventoryItemStateCreated (SellableInventoryItemEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<SellableInventoryItemEntryEventId, ISellableInventoryItemEntryStateCreated> _sellableInventoryItemEntryEvents = new Dictionary<SellableInventoryItemEntryEventId, ISellableInventoryItemEntryStateCreated>();
        
        private IEnumerable<ISellableInventoryItemEntryStateCreated> _readOnlySellableInventoryItemEntryEvents;

        public virtual IEnumerable<ISellableInventoryItemEntryStateCreated> SellableInventoryItemEntryEvents
        {
            get
            {
                return this._sellableInventoryItemEntryEvents.Values;
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddSellableInventoryItemEntryEvent(e);
                    }
                }
                else { this._sellableInventoryItemEntryEvents.Clear(); }
            }
        }
    
		public virtual void AddSellableInventoryItemEntryEvent(ISellableInventoryItemEntryStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._sellableInventoryItemEntryEvents[e.SellableInventoryItemEntryEventId] = e;
		}

        public virtual ISellableInventoryItemEntryStateCreated NewSellableInventoryItemEntryStateCreated(long entrySeqId)
        {
            var stateEvent = new SellableInventoryItemEntryStateCreated(NewSellableInventoryItemEntryEventId(entrySeqId));
            return stateEvent;
        }


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class SellableInventoryItemStateMergePatched : SellableInventoryItemStateEventBase, ISellableInventoryItemStateMergePatched
	{
		public virtual bool IsPropertySellableQuantityRemoved { get; set; }


		public SellableInventoryItemStateMergePatched ()
		{
		}

		public SellableInventoryItemStateMergePatched (SellableInventoryItemEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<SellableInventoryItemEntryEventId, ISellableInventoryItemEntryStateEvent> _sellableInventoryItemEntryEvents = new Dictionary<SellableInventoryItemEntryEventId, ISellableInventoryItemEntryStateEvent>();

        private IEnumerable<ISellableInventoryItemEntryStateEvent> _readOnlySellableInventoryItemEntryEvents;
        
        public virtual IEnumerable<ISellableInventoryItemEntryStateEvent> SellableInventoryItemEntryEvents
        {
            get
            {
                return this._sellableInventoryItemEntryEvents.Values;
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddSellableInventoryItemEntryEvent(e);
                    }
                }
                else { this._sellableInventoryItemEntryEvents.Clear(); }
            }
        }

		public virtual void AddSellableInventoryItemEntryEvent(ISellableInventoryItemEntryStateEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._sellableInventoryItemEntryEvents[e.SellableInventoryItemEntryEventId] = e;
		}

        public virtual ISellableInventoryItemEntryStateCreated NewSellableInventoryItemEntryStateCreated(long entrySeqId)
        {
            var stateEvent = new SellableInventoryItemEntryStateCreated(NewSellableInventoryItemEntryEventId(entrySeqId));
            return stateEvent;
        }


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

