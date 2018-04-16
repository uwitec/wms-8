﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

	public partial class MovementConfirmationLineState : MovementConfirmationLineStateProperties, IMovementConfirmationLineState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private MovementConfirmationLineId _movementConfirmationLineId = new MovementConfirmationLineId();

        public virtual MovementConfirmationLineId MovementConfirmationLineId 
        {
            get { return this._movementConfirmationLineId; }
            set { this._movementConfirmationLineId = value; }
        }

		MovementConfirmationLineId IGlobalIdentity<MovementConfirmationLineId>.GlobalId {
			get {
				return  this.MovementConfirmationLineId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.LineNumber;
            }
        }


        public override string MovementConfirmationDocumentNumber {
			get {
				return this.MovementConfirmationLineId.MovementConfirmationDocumentNumber;
			}
			set {
				this.MovementConfirmationLineId.MovementConfirmationDocumentNumber = value;
			}
		}

        public override string LineNumber {
			get {
				return this.MovementConfirmationLineId.LineNumber;
			}
			set {
				this.MovementConfirmationLineId.LineNumber = value;
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

		long IEntityVersioned<long>.EntityVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IMovementConfirmationLineState.IsUnsaved
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

        public MovementConfirmationLineState() : this(false)
        {
        }

        public MovementConfirmationLineState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IMovementConfirmationLineStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.MovementLineNumber = e.MovementLineNumber;

            this.TargetQuantity = (e.TargetQuantity != null && e.TargetQuantity.HasValue) ? e.TargetQuantity.Value : default(decimal);

            this.ConfirmedQuantity = (e.ConfirmedQuantity != null && e.ConfirmedQuantity.HasValue) ? e.ConfirmedQuantity.Value : default(decimal);

            this.DifferenceQuantity = (e.DifferenceQuantity != null && e.DifferenceQuantity.HasValue) ? e.DifferenceQuantity.Value : default(decimal);

            this.ScrappedQuantity = (e.ScrappedQuantity != null && e.ScrappedQuantity.HasValue) ? e.ScrappedQuantity.Value : default(decimal);

			this.Description = e.Description;

            this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IMovementConfirmationLineStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.MovementLineNumber == null)
			{
				if (e.IsPropertyMovementLineNumberRemoved)
				{
					this.MovementLineNumber = default(string);
				}
			}
			else
			{
				this.MovementLineNumber = e.MovementLineNumber;
			}

			if (e.TargetQuantity == null)
			{
				if (e.IsPropertyTargetQuantityRemoved)
				{
					this.TargetQuantity = default(decimal);
				}
			}
			else
			{
				this.TargetQuantity = (e.TargetQuantity != null && e.TargetQuantity.HasValue) ? e.TargetQuantity.Value : default(decimal);
			}

			if (e.ConfirmedQuantity == null)
			{
				if (e.IsPropertyConfirmedQuantityRemoved)
				{
					this.ConfirmedQuantity = default(decimal);
				}
			}
			else
			{
				this.ConfirmedQuantity = (e.ConfirmedQuantity != null && e.ConfirmedQuantity.HasValue) ? e.ConfirmedQuantity.Value : default(decimal);
			}

			if (e.DifferenceQuantity == null)
			{
				if (e.IsPropertyDifferenceQuantityRemoved)
				{
					this.DifferenceQuantity = default(decimal);
				}
			}
			else
			{
				this.DifferenceQuantity = (e.DifferenceQuantity != null && e.DifferenceQuantity.HasValue) ? e.DifferenceQuantity.Value : default(decimal);
			}

			if (e.ScrappedQuantity == null)
			{
				if (e.IsPropertyScrappedQuantityRemoved)
				{
					this.ScrappedQuantity = default(decimal);
				}
			}
			else
			{
				this.ScrappedQuantity = (e.ScrappedQuantity != null && e.ScrappedQuantity.HasValue) ? e.ScrappedQuantity.Value : default(decimal);
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


		}

		public virtual void When(IMovementConfirmationLineStateRemoved e)
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
            if (!(this.ConfirmedQuantity == 0 || this.TargetQuantity + this.DifferenceQuantity == this.ConfirmedQuantity))
            {
                throw DomainError.Named("constraintViolated", "Violated validation logic: {0}", "this.ConfirmedQuantity == 0 || this.TargetQuantity + this.DifferenceQuantity == this.ConfirmedQuantity");
            }
            if (!(this.ScrappedQuantity <= this.ConfirmedQuantity))
            {
                throw DomainError.Named("constraintViolated", "Violated validation logic: {0}", "this.ScrappedQuantity <= this.ConfirmedQuantity");
            }
		}

        protected void ThrowOnWrongEvent(IMovementConfirmationLineEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("MovementConfirmationLine|");

            var stateEntityIdMovementConfirmationDocumentNumber = (this as IGlobalIdentity<MovementConfirmationLineId>).GlobalId.MovementConfirmationDocumentNumber;
            var eventEntityIdMovementConfirmationDocumentNumber = stateEvent.MovementConfirmationLineEventId.MovementConfirmationDocumentNumber;
            if (stateEntityIdMovementConfirmationDocumentNumber != eventEntityIdMovementConfirmationDocumentNumber)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id MovementConfirmationDocumentNumber {0} in state but entity id MovementConfirmationDocumentNumber {1} in event", stateEntityIdMovementConfirmationDocumentNumber, eventEntityIdMovementConfirmationDocumentNumber);
            }
            id.Append(stateEntityIdMovementConfirmationDocumentNumber).Append(",");

            var stateEntityIdLineNumber = (this as IGlobalIdentity<MovementConfirmationLineId>).GlobalId.LineNumber;
            var eventEntityIdLineNumber = stateEvent.MovementConfirmationLineEventId.LineNumber;
            if (stateEntityIdLineNumber != eventEntityIdLineNumber)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id LineNumber {0} in state but entity id LineNumber {1} in event", stateEntityIdLineNumber, eventEntityIdLineNumber);
            }
            id.Append(stateEntityIdLineNumber).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (MovementConfirmationLineState.VersionZero == eventVersion)
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

