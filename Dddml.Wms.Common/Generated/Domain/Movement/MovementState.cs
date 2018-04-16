﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.Movement
{

	public partial class MovementState : MovementStateProperties, IMovementState, ISaveable
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.DocumentNumber;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
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

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IMovementState.IsUnsaved
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


        private IMovementLineStates _movementLines;
      
        public virtual IMovementLineStates MovementLines
        {
            get
            {
                return this._movementLines;
            }
            set
            {
                this._movementLines = value;
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

        public MovementState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.DocumentNumber = ((IMovementEvent)events.First()).MovementEventId.DocumentNumber;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public MovementState() : this(false)
        {
        }

        public MovementState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            _movementLines = new MovementLineStates(this);

            InitializeProperties();
        }


		#region Saveable Implements

        public virtual void Save()
        {
            _movementLines.Save();

        }


		#endregion


		public virtual void When(IMovementStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.DocumentStatusId = e.DocumentStatusId;

            this.MovementDate = (e.MovementDate != null && e.MovementDate.HasValue) ? e.MovementDate.Value : default(DateTime);

            this.Posted = (e.Posted != null && e.Posted.HasValue) ? e.Posted.Value : default(bool);

            this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);

			this.Processing = e.Processing;

            this.DateReceived = (e.DateReceived != null && e.DateReceived.HasValue) ? e.DateReceived.Value : default(DateTime);

			this.DocumentTypeId = e.DocumentTypeId;

            this.IsInTransit = (e.IsInTransit != null && e.IsInTransit.HasValue) ? e.IsInTransit.Value : default(bool);

            this.IsApproved = (e.IsApproved != null && e.IsApproved.HasValue) ? e.IsApproved.Value : default(bool);

            this.ApprovalAmount = (e.ApprovalAmount != null && e.ApprovalAmount.HasValue) ? e.ApprovalAmount.Value : default(decimal);

			this.ShipperId = e.ShipperId;

			this.SalesRepresentativeId = e.SalesRepresentativeId;

			this.BusinessPartnerId = e.BusinessPartnerId;

            this.ChargeAmount = (e.ChargeAmount != null && e.ChargeAmount.HasValue) ? e.ChargeAmount.Value : default(decimal);

			this.CreateFrom = e.CreateFrom;

            this.FreightAmount = (e.FreightAmount != null && e.FreightAmount.HasValue) ? e.FreightAmount.Value : default(decimal);

			this.ReversalDocumentNumber = e.ReversalDocumentNumber;

			this.WarehouseIdFrom = e.WarehouseIdFrom;

			this.WarehouseIdTo = e.WarehouseIdTo;

			this.Description = e.Description;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;

			foreach (IMovementLineStateCreated innerEvent in e.MovementLineEvents) {
				IMovementLineState innerState = this.MovementLines.Get(innerEvent.GlobalId.LineNumber, true);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IMovementStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.DocumentStatusId == null)
			{
				if (e.IsPropertyDocumentStatusIdRemoved)
				{
					this.DocumentStatusId = default(string);
				}
			}
			else
			{
				this.DocumentStatusId = e.DocumentStatusId;
			}

			if (e.MovementDate == null)
			{
				if (e.IsPropertyMovementDateRemoved)
				{
					this.MovementDate = default(DateTime);
				}
			}
			else
			{
				this.MovementDate = (e.MovementDate != null && e.MovementDate.HasValue) ? e.MovementDate.Value : default(DateTime);
			}

			if (e.Posted == null)
			{
				if (e.IsPropertyPostedRemoved)
				{
					this.Posted = default(bool);
				}
			}
			else
			{
				this.Posted = (e.Posted != null && e.Posted.HasValue) ? e.Posted.Value : default(bool);
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

			if (e.Processing == null)
			{
				if (e.IsPropertyProcessingRemoved)
				{
					this.Processing = default(string);
				}
			}
			else
			{
				this.Processing = e.Processing;
			}

			if (e.DateReceived == null)
			{
				if (e.IsPropertyDateReceivedRemoved)
				{
					this.DateReceived = default(DateTime);
				}
			}
			else
			{
				this.DateReceived = (e.DateReceived != null && e.DateReceived.HasValue) ? e.DateReceived.Value : default(DateTime);
			}

			if (e.DocumentTypeId == null)
			{
				if (e.IsPropertyDocumentTypeIdRemoved)
				{
					this.DocumentTypeId = default(string);
				}
			}
			else
			{
				this.DocumentTypeId = e.DocumentTypeId;
			}

			if (e.IsInTransit == null)
			{
				if (e.IsPropertyIsInTransitRemoved)
				{
					this.IsInTransit = default(bool);
				}
			}
			else
			{
				this.IsInTransit = (e.IsInTransit != null && e.IsInTransit.HasValue) ? e.IsInTransit.Value : default(bool);
			}

			if (e.IsApproved == null)
			{
				if (e.IsPropertyIsApprovedRemoved)
				{
					this.IsApproved = default(bool);
				}
			}
			else
			{
				this.IsApproved = (e.IsApproved != null && e.IsApproved.HasValue) ? e.IsApproved.Value : default(bool);
			}

			if (e.ApprovalAmount == null)
			{
				if (e.IsPropertyApprovalAmountRemoved)
				{
					this.ApprovalAmount = default(decimal);
				}
			}
			else
			{
				this.ApprovalAmount = (e.ApprovalAmount != null && e.ApprovalAmount.HasValue) ? e.ApprovalAmount.Value : default(decimal);
			}

			if (e.ShipperId == null)
			{
				if (e.IsPropertyShipperIdRemoved)
				{
					this.ShipperId = default(string);
				}
			}
			else
			{
				this.ShipperId = e.ShipperId;
			}

			if (e.SalesRepresentativeId == null)
			{
				if (e.IsPropertySalesRepresentativeIdRemoved)
				{
					this.SalesRepresentativeId = default(string);
				}
			}
			else
			{
				this.SalesRepresentativeId = e.SalesRepresentativeId;
			}

			if (e.BusinessPartnerId == null)
			{
				if (e.IsPropertyBusinessPartnerIdRemoved)
				{
					this.BusinessPartnerId = default(string);
				}
			}
			else
			{
				this.BusinessPartnerId = e.BusinessPartnerId;
			}

			if (e.ChargeAmount == null)
			{
				if (e.IsPropertyChargeAmountRemoved)
				{
					this.ChargeAmount = default(decimal);
				}
			}
			else
			{
				this.ChargeAmount = (e.ChargeAmount != null && e.ChargeAmount.HasValue) ? e.ChargeAmount.Value : default(decimal);
			}

			if (e.CreateFrom == null)
			{
				if (e.IsPropertyCreateFromRemoved)
				{
					this.CreateFrom = default(string);
				}
			}
			else
			{
				this.CreateFrom = e.CreateFrom;
			}

			if (e.FreightAmount == null)
			{
				if (e.IsPropertyFreightAmountRemoved)
				{
					this.FreightAmount = default(decimal);
				}
			}
			else
			{
				this.FreightAmount = (e.FreightAmount != null && e.FreightAmount.HasValue) ? e.FreightAmount.Value : default(decimal);
			}

			if (e.ReversalDocumentNumber == null)
			{
				if (e.IsPropertyReversalDocumentNumberRemoved)
				{
					this.ReversalDocumentNumber = default(string);
				}
			}
			else
			{
				this.ReversalDocumentNumber = e.ReversalDocumentNumber;
			}

			if (e.WarehouseIdFrom == null)
			{
				if (e.IsPropertyWarehouseIdFromRemoved)
				{
					this.WarehouseIdFrom = default(string);
				}
			}
			else
			{
				this.WarehouseIdFrom = e.WarehouseIdFrom;
			}

			if (e.WarehouseIdTo == null)
			{
				if (e.IsPropertyWarehouseIdToRemoved)
				{
					this.WarehouseIdTo = default(string);
				}
			}
			else
			{
				this.WarehouseIdTo = e.WarehouseIdTo;
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

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


			foreach (IMovementLineEvent innerEvent in e.MovementLineEvents)
            {
                IMovementLineState innerState = this.MovementLines.Get(innerEvent.GlobalId.LineNumber);

                innerState.Mutate(innerEvent);
                var removed = innerEvent as IMovementLineStateRemoved;
                if (removed != null)
                {
                    this.MovementLines.Remove(innerState);
                }
          
            }

		}

		public virtual void When(IMovementStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

            foreach (var innerState in this.MovementLines)
            {
                this.MovementLines.Remove(innerState);
                
                var innerE = e.NewMovementLineStateRemoved(innerState.LineNumber);
                ((MovementLineEventBase)innerE).CreatedAt = e.CreatedAt;
                ((MovementLineEventBase)innerE).CreatedBy = e.CreatedBy;
                innerState.When(innerE);
                //e.AddMovementLineEvent(innerE);

            }

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IMovementEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("Movement|");

            var stateEntityId = this.DocumentNumber; // Aggregate Id
            var eventEntityId = stateEvent.MovementEventId.DocumentNumber;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = stateEvent.MovementEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

