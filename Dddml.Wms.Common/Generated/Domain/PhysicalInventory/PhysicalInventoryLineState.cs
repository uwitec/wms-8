﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{

	public partial class PhysicalInventoryLineState : PhysicalInventoryLineStateProperties, IPhysicalInventoryLineState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private PhysicalInventoryLineId _physicalInventoryLineId = new PhysicalInventoryLineId();

        public virtual PhysicalInventoryLineId PhysicalInventoryLineId 
        {
            get { return this._physicalInventoryLineId; }
            set { this._physicalInventoryLineId = value; }
        }

		PhysicalInventoryLineId IGlobalIdentity<PhysicalInventoryLineId>.GlobalId {
			get {
				return  this.PhysicalInventoryLineId;
			}
		}

        InventoryItemId ILocalIdentity<InventoryItemId>.LocalId
        {
            get
            {
                return this.InventoryItemId;
            }
        }


        public override string PhysicalInventoryDocumentNumber {
			get {
				return this.PhysicalInventoryLineId.PhysicalInventoryDocumentNumber;
			}
			set {
				this.PhysicalInventoryLineId.PhysicalInventoryDocumentNumber = value;
			}
		}

        public override InventoryItemId InventoryItemId {
			get {
				return this.PhysicalInventoryLineId.InventoryItemId;
			}
			set {
				this.PhysicalInventoryLineId.InventoryItemId = value;
			}
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
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

		long IEntityVersioned<long>.EntityVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IPhysicalInventoryLineState.IsUnsaved
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

        public PhysicalInventoryLineState() : this(false)
        {
        }

        public PhysicalInventoryLineState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IPhysicalInventoryLineStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.BookQuantity = (e.BookQuantity != null && e.BookQuantity.HasValue) ? e.BookQuantity.Value : default(decimal);

            this.CountedQuantity = (e.CountedQuantity != null && e.CountedQuantity.HasValue) ? e.CountedQuantity.Value : default(decimal);

            this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);

            this.ReversalLineNumber = (e.ReversalLineNumber != null && e.ReversalLineNumber.HasValue) ? e.ReversalLineNumber.Value : default(long);

			this.Description = e.Description;

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IPhysicalInventoryLineStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.BookQuantity == null)
			{
				if (e.IsPropertyBookQuantityRemoved)
				{
					this.BookQuantity = default(decimal);
				}
			}
			else
			{
				this.BookQuantity = (e.BookQuantity != null && e.BookQuantity.HasValue) ? e.BookQuantity.Value : default(decimal);
			}

			if (e.CountedQuantity == null)
			{
				if (e.IsPropertyCountedQuantityRemoved)
				{
					this.CountedQuantity = default(decimal);
				}
			}
			else
			{
				this.CountedQuantity = (e.CountedQuantity != null && e.CountedQuantity.HasValue) ? e.CountedQuantity.Value : default(decimal);
			}

			if (e.Processed == null)
			{
				if (e.IsPropertyProcessedRemoved)
				{
					this.Processed = default(bool);
				}
			}
			else
			{
				this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);
			}

			if (e.ReversalLineNumber == null)
			{
				if (e.IsPropertyReversalLineNumberRemoved)
				{
					this.ReversalLineNumber = default(long);
				}
			}
			else
			{
				this.ReversalLineNumber = (e.ReversalLineNumber != null && e.ReversalLineNumber.HasValue) ? e.ReversalLineNumber.Value : default(long);
			}

			if (e.Description == null)
			{
				if (e.IsPropertyDescriptionRemoved)
				{
					this.Description = default(string);
				}
			}
			else
			{
				this.Description = e.Description;
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IPhysicalInventoryLineStateRemoved e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IPhysicalInventoryLineStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("PhysicalInventoryLine|");

            var stateEntityIdPhysicalInventoryDocumentNumber = (this as IGlobalIdentity<PhysicalInventoryLineId>).GlobalId.PhysicalInventoryDocumentNumber;
            var eventEntityIdPhysicalInventoryDocumentNumber = stateEvent.PhysicalInventoryLineEventId.PhysicalInventoryDocumentNumber;
            if (stateEntityIdPhysicalInventoryDocumentNumber != eventEntityIdPhysicalInventoryDocumentNumber)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id PhysicalInventoryDocumentNumber {0} in state but entity id PhysicalInventoryDocumentNumber {1} in event", stateEntityIdPhysicalInventoryDocumentNumber, eventEntityIdPhysicalInventoryDocumentNumber);
            }
            id.Append(stateEntityIdPhysicalInventoryDocumentNumber).Append(",");

            var stateEntityIdInventoryItemId = (this as IGlobalIdentity<PhysicalInventoryLineId>).GlobalId.InventoryItemId;
            var eventEntityIdInventoryItemId = stateEvent.PhysicalInventoryLineEventId.InventoryItemId;
            if (stateEntityIdInventoryItemId != eventEntityIdInventoryItemId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id InventoryItemId {0} in state but entity id InventoryItemId {1} in event", stateEntityIdInventoryItemId, eventEntityIdInventoryItemId);
            }
            id.Append(stateEntityIdInventoryItemId).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (PhysicalInventoryLineState.VersionZero == eventVersion)
            {
                eventVersion = stateEvent.Version = stateVersion;
            }
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

