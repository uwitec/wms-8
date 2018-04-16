﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItemEntryMvo
{

	public partial class InventoryItemEntryMvoState : InventoryItemEntryMvoStateProperties, IInventoryItemEntryMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

		InventoryItemEntryId IGlobalIdentity<InventoryItemEntryId>.GlobalId
		{
			get
			{
				return this.InventoryItemEntryId;
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
				return this.InventoryItemVersion;
			}
		}


		#endregion

        bool IInventoryItemEntryMvoState.IsUnsaved
        {
            get { return this.InventoryItemVersion == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
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

        public InventoryItemEntryMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.InventoryItemEntryId = ((IInventoryItemEntryMvoEvent)events.First()).InventoryItemEntryMvoEventId.InventoryItemEntryId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.InventoryItemVersion += 1;
                }
            }
        }

        public InventoryItemEntryMvoState() : this(false)
        {
        }

        public InventoryItemEntryMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IInventoryItemEntryMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.OnHandQuantity = (e.OnHandQuantity != null && e.OnHandQuantity.HasValue) ? e.OnHandQuantity.Value : default(decimal);

            this.InTransitQuantity = (e.InTransitQuantity != null && e.InTransitQuantity.HasValue) ? e.InTransitQuantity.Value : default(decimal);

            this.ReservedQuantity = (e.ReservedQuantity != null && e.ReservedQuantity.HasValue) ? e.ReservedQuantity.Value : default(decimal);

            this.OccupiedQuantity = (e.OccupiedQuantity != null && e.OccupiedQuantity.HasValue) ? e.OccupiedQuantity.Value : default(decimal);

            this.VirtualQuantity = (e.VirtualQuantity != null && e.VirtualQuantity.HasValue) ? e.VirtualQuantity.Value : default(decimal);

			this.Source = e.Source;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.InventoryItemOnHandQuantity = (e.InventoryItemOnHandQuantity != null && e.InventoryItemOnHandQuantity.HasValue) ? e.InventoryItemOnHandQuantity.Value : default(decimal);

            this.InventoryItemInTransitQuantity = (e.InventoryItemInTransitQuantity != null && e.InventoryItemInTransitQuantity.HasValue) ? e.InventoryItemInTransitQuantity.Value : default(decimal);

            this.InventoryItemReservedQuantity = (e.InventoryItemReservedQuantity != null && e.InventoryItemReservedQuantity.HasValue) ? e.InventoryItemReservedQuantity.Value : default(decimal);

            this.InventoryItemOccupiedQuantity = (e.InventoryItemOccupiedQuantity != null && e.InventoryItemOccupiedQuantity.HasValue) ? e.InventoryItemOccupiedQuantity.Value : default(decimal);

            this.InventoryItemVirtualQuantity = (e.InventoryItemVirtualQuantity != null && e.InventoryItemVirtualQuantity.HasValue) ? e.InventoryItemVirtualQuantity.Value : default(decimal);

			this.InventoryItemCreatedBy = e.InventoryItemCreatedBy;

            this.InventoryItemCreatedAt = (e.InventoryItemCreatedAt != null && e.InventoryItemCreatedAt.HasValue) ? e.InventoryItemCreatedAt.Value : default(DateTime);

			this.InventoryItemUpdatedBy = e.InventoryItemUpdatedBy;

            this.InventoryItemUpdatedAt = (e.InventoryItemUpdatedAt != null && e.InventoryItemUpdatedAt.HasValue) ? e.InventoryItemUpdatedAt.Value : default(DateTime);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IInventoryItemEntryMvoStateMergePatched e)
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

			if (e.Source == null)
			{
				if (e.IsPropertySourceRemoved)
				{
					this.Source = default(InventoryItemSourceInfo);
				}
			}
			else
			{
				this.Source = e.Source;
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
			}

			if (e.InventoryItemOnHandQuantity == null)
			{
				if (e.IsPropertyInventoryItemOnHandQuantityRemoved)
				{
					this.InventoryItemOnHandQuantity = default(decimal);
				}
			}
			else
			{
				this.InventoryItemOnHandQuantity = (e.InventoryItemOnHandQuantity != null && e.InventoryItemOnHandQuantity.HasValue) ? e.InventoryItemOnHandQuantity.Value : default(decimal);
			}

			if (e.InventoryItemInTransitQuantity == null)
			{
				if (e.IsPropertyInventoryItemInTransitQuantityRemoved)
				{
					this.InventoryItemInTransitQuantity = default(decimal);
				}
			}
			else
			{
				this.InventoryItemInTransitQuantity = (e.InventoryItemInTransitQuantity != null && e.InventoryItemInTransitQuantity.HasValue) ? e.InventoryItemInTransitQuantity.Value : default(decimal);
			}

			if (e.InventoryItemReservedQuantity == null)
			{
				if (e.IsPropertyInventoryItemReservedQuantityRemoved)
				{
					this.InventoryItemReservedQuantity = default(decimal);
				}
			}
			else
			{
				this.InventoryItemReservedQuantity = (e.InventoryItemReservedQuantity != null && e.InventoryItemReservedQuantity.HasValue) ? e.InventoryItemReservedQuantity.Value : default(decimal);
			}

			if (e.InventoryItemOccupiedQuantity == null)
			{
				if (e.IsPropertyInventoryItemOccupiedQuantityRemoved)
				{
					this.InventoryItemOccupiedQuantity = default(decimal);
				}
			}
			else
			{
				this.InventoryItemOccupiedQuantity = (e.InventoryItemOccupiedQuantity != null && e.InventoryItemOccupiedQuantity.HasValue) ? e.InventoryItemOccupiedQuantity.Value : default(decimal);
			}

			if (e.InventoryItemVirtualQuantity == null)
			{
				if (e.IsPropertyInventoryItemVirtualQuantityRemoved)
				{
					this.InventoryItemVirtualQuantity = default(decimal);
				}
			}
			else
			{
				this.InventoryItemVirtualQuantity = (e.InventoryItemVirtualQuantity != null && e.InventoryItemVirtualQuantity.HasValue) ? e.InventoryItemVirtualQuantity.Value : default(decimal);
			}

			if (e.InventoryItemCreatedBy == null)
			{
				if (e.IsPropertyInventoryItemCreatedByRemoved)
				{
					this.InventoryItemCreatedBy = default(string);
				}
			}
			else
			{
				this.InventoryItemCreatedBy = e.InventoryItemCreatedBy;
			}

			if (e.InventoryItemCreatedAt == null)
			{
				if (e.IsPropertyInventoryItemCreatedAtRemoved)
				{
					this.InventoryItemCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.InventoryItemCreatedAt = (e.InventoryItemCreatedAt != null && e.InventoryItemCreatedAt.HasValue) ? e.InventoryItemCreatedAt.Value : default(DateTime);
			}

			if (e.InventoryItemUpdatedBy == null)
			{
				if (e.IsPropertyInventoryItemUpdatedByRemoved)
				{
					this.InventoryItemUpdatedBy = default(string);
				}
			}
			else
			{
				this.InventoryItemUpdatedBy = e.InventoryItemUpdatedBy;
			}

			if (e.InventoryItemUpdatedAt == null)
			{
				if (e.IsPropertyInventoryItemUpdatedAtRemoved)
				{
					this.InventoryItemUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.InventoryItemUpdatedAt = (e.InventoryItemUpdatedAt != null && e.InventoryItemUpdatedAt.HasValue) ? e.InventoryItemUpdatedAt.Value : default(DateTime);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IInventoryItemEntryMvoEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("InventoryItemEntryMvo|");

            var stateEntityId = this.InventoryItemEntryId; // Aggregate Id
            var eventEntityId = e.InventoryItemEntryMvoEventId.InventoryItemEntryId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.InventoryItemVersion;
            var eventVersion = e.InventoryItemEntryMvoEventId.InventoryItemVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

