﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItemEntryMvo
{

	public partial class SellableInventoryItemEntryMvoState : SellableInventoryItemEntryMvoStateProperties, ISellableInventoryItemEntryMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

		SellableInventoryItemEntryId IGlobalIdentity<SellableInventoryItemEntryId>.GlobalId
		{
			get
			{
				return this.SellableInventoryItemEntryId;
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
				return this.SellableInventoryItemVersion;
			}
		}


		#endregion

        bool ISellableInventoryItemEntryMvoState.IsUnsaved
        {
            get { return this.SellableInventoryItemVersion == VersionZero; }
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

        public SellableInventoryItemEntryMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.SellableInventoryItemEntryId = ((ISellableInventoryItemEntryMvoStateEvent)events.First()).StateEventId.SellableInventoryItemEntryId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.SellableInventoryItemVersion += 1;
                }
            }
        }

        public SellableInventoryItemEntryMvoState() : this(false)
        {
        }

        public SellableInventoryItemEntryMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(ISellableInventoryItemEntryMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.QuantitySellable = (e.QuantitySellable != null && e.QuantitySellable.HasValue) ? e.QuantitySellable.Value : default(decimal);

			this.SourceEventId = e.SourceEventId;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.SellableInventoryItemQuantitySellable = (e.SellableInventoryItemQuantitySellable != null && e.SellableInventoryItemQuantitySellable.HasValue) ? e.SellableInventoryItemQuantitySellable.Value : default(decimal);

			this.SellableInventoryItemCreatedBy = e.SellableInventoryItemCreatedBy;

            this.SellableInventoryItemCreatedAt = (e.SellableInventoryItemCreatedAt != null && e.SellableInventoryItemCreatedAt.HasValue) ? e.SellableInventoryItemCreatedAt.Value : default(DateTime);

			this.SellableInventoryItemUpdatedBy = e.SellableInventoryItemUpdatedBy;

            this.SellableInventoryItemUpdatedAt = (e.SellableInventoryItemUpdatedAt != null && e.SellableInventoryItemUpdatedAt.HasValue) ? e.SellableInventoryItemUpdatedAt.Value : default(DateTime);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(ISellableInventoryItemEntryMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.QuantitySellable == null)
			{
				if (e.IsPropertyQuantitySellableRemoved)
				{
					this.QuantitySellable = default(decimal);
				}
			}
			else
			{
				this.QuantitySellable = (e.QuantitySellable != null && e.QuantitySellable.HasValue) ? e.QuantitySellable.Value : default(decimal);
			}

			if (e.SourceEventId == null)
			{
				if (e.IsPropertySourceEventIdRemoved)
				{
					this.SourceEventId = default(InventoryPRTriggeredId);
				}
			}
			else
			{
				this.SourceEventId = e.SourceEventId;
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

			if (e.SellableInventoryItemQuantitySellable == null)
			{
				if (e.IsPropertySellableInventoryItemQuantitySellableRemoved)
				{
					this.SellableInventoryItemQuantitySellable = default(decimal);
				}
			}
			else
			{
				this.SellableInventoryItemQuantitySellable = (e.SellableInventoryItemQuantitySellable != null && e.SellableInventoryItemQuantitySellable.HasValue) ? e.SellableInventoryItemQuantitySellable.Value : default(decimal);
			}

			if (e.SellableInventoryItemCreatedBy == null)
			{
				if (e.IsPropertySellableInventoryItemCreatedByRemoved)
				{
					this.SellableInventoryItemCreatedBy = default(string);
				}
			}
			else
			{
				this.SellableInventoryItemCreatedBy = e.SellableInventoryItemCreatedBy;
			}

			if (e.SellableInventoryItemCreatedAt == null)
			{
				if (e.IsPropertySellableInventoryItemCreatedAtRemoved)
				{
					this.SellableInventoryItemCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.SellableInventoryItemCreatedAt = (e.SellableInventoryItemCreatedAt != null && e.SellableInventoryItemCreatedAt.HasValue) ? e.SellableInventoryItemCreatedAt.Value : default(DateTime);
			}

			if (e.SellableInventoryItemUpdatedBy == null)
			{
				if (e.IsPropertySellableInventoryItemUpdatedByRemoved)
				{
					this.SellableInventoryItemUpdatedBy = default(string);
				}
			}
			else
			{
				this.SellableInventoryItemUpdatedBy = e.SellableInventoryItemUpdatedBy;
			}

			if (e.SellableInventoryItemUpdatedAt == null)
			{
				if (e.IsPropertySellableInventoryItemUpdatedAtRemoved)
				{
					this.SellableInventoryItemUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.SellableInventoryItemUpdatedAt = (e.SellableInventoryItemUpdatedAt != null && e.SellableInventoryItemUpdatedAt.HasValue) ? e.SellableInventoryItemUpdatedAt.Value : default(DateTime);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(ISellableInventoryItemEntryMvoStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("SellableInventoryItemEntryMvo|");

            var stateEntityId = this.SellableInventoryItemEntryId; // Aggregate Id
            var eventEntityId = stateEvent.StateEventId.SellableInventoryItemEntryId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.SellableInventoryItemVersion;
            var eventVersion = stateEvent.StateEventId.SellableInventoryItemVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}
