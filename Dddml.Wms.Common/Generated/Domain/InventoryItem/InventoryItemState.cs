﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

	public partial class InventoryItemState : InventoryItemStateProperties, IInventoryItemState, ISaveable
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

		InventoryItemId IGlobalIdentity<InventoryItemId>.GlobalId
		{
			get
			{
				return this.InventoryItemId;
			}
		}

		#endregion


		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IInventoryItemState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        private IInventoryItemEntryStates _entries;
      
        public virtual IInventoryItemEntryStates Entries
        {
            get
            {
                return this._entries;
            }
            set
            {
                this._entries = value;
            }
        }


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public InventoryItemState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.InventoryItemId = ((IInventoryItemStateEvent)events.First()).InventoryItemEventId.InventoryItemId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public InventoryItemState() : this(false)
        {
        }

        public InventoryItemState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            _entries = new InventoryItemEntryStates(this);

            InitializeProperties();
        }


		#region Saveable Implements

        public virtual void Save()
        {
            _entries.Save();

        }


		#endregion


		public virtual void When(IInventoryItemStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.OnHandQuantity = (e.OnHandQuantity != null && e.OnHandQuantity.HasValue) ? e.OnHandQuantity.Value : default(decimal);

            this.InTransitQuantity = (e.InTransitQuantity != null && e.InTransitQuantity.HasValue) ? e.InTransitQuantity.Value : default(decimal);

            this.ReservedQuantity = (e.ReservedQuantity != null && e.ReservedQuantity.HasValue) ? e.ReservedQuantity.Value : default(decimal);

            this.OccupiedQuantity = (e.OccupiedQuantity != null && e.OccupiedQuantity.HasValue) ? e.OccupiedQuantity.Value : default(decimal);

            this.VirtualQuantity = (e.VirtualQuantity != null && e.VirtualQuantity.HasValue) ? e.VirtualQuantity.Value : default(decimal);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;

			foreach (IInventoryItemEntryStateCreated innerEvent in e.InventoryItemEntryEvents) {
				IInventoryItemEntryState innerState = this.Entries.Get(innerEvent.GlobalId.EntrySeqId, true);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IInventoryItemStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.OnHandQuantity == null)
			{
				if (e.IsPropertyOnHandQuantityRemoved)
				{
					this.OnHandQuantity = default(decimal);
				}
			}
			else
			{
				this.OnHandQuantity = (e.OnHandQuantity != null && e.OnHandQuantity.HasValue) ? e.OnHandQuantity.Value : default(decimal);
			}

			if (e.InTransitQuantity == null)
			{
				if (e.IsPropertyInTransitQuantityRemoved)
				{
					this.InTransitQuantity = default(decimal);
				}
			}
			else
			{
				this.InTransitQuantity = (e.InTransitQuantity != null && e.InTransitQuantity.HasValue) ? e.InTransitQuantity.Value : default(decimal);
			}

			if (e.ReservedQuantity == null)
			{
				if (e.IsPropertyReservedQuantityRemoved)
				{
					this.ReservedQuantity = default(decimal);
				}
			}
			else
			{
				this.ReservedQuantity = (e.ReservedQuantity != null && e.ReservedQuantity.HasValue) ? e.ReservedQuantity.Value : default(decimal);
			}

			if (e.OccupiedQuantity == null)
			{
				if (e.IsPropertyOccupiedQuantityRemoved)
				{
					this.OccupiedQuantity = default(decimal);
				}
			}
			else
			{
				this.OccupiedQuantity = (e.OccupiedQuantity != null && e.OccupiedQuantity.HasValue) ? e.OccupiedQuantity.Value : default(decimal);
			}

			if (e.VirtualQuantity == null)
			{
				if (e.IsPropertyVirtualQuantityRemoved)
				{
					this.VirtualQuantity = default(decimal);
				}
			}
			else
			{
				this.VirtualQuantity = (e.VirtualQuantity != null && e.VirtualQuantity.HasValue) ? e.VirtualQuantity.Value : default(decimal);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


			foreach (IInventoryItemEntryStateEvent innerEvent in e.InventoryItemEntryEvents)
            {
                IInventoryItemEntryState innerState = this.Entries.Get(innerEvent.GlobalId.EntrySeqId);

                innerState.Mutate(innerEvent);
          
            }

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IInventoryItemStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("InventoryItem|");

            var stateEntityId = this.InventoryItemId; // Aggregate Id
            var eventEntityId = stateEvent.InventoryItemEventId.InventoryItemId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = stateEvent.InventoryItemEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

