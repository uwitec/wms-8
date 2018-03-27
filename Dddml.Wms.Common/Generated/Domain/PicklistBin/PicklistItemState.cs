﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistBinDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistBin
{

	public partial class PicklistItemState : PicklistItemStateProperties, IPicklistItemState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private PicklistBinPicklistItemId _picklistBinPicklistItemId = new PicklistBinPicklistItemId();

        public virtual PicklistBinPicklistItemId PicklistBinPicklistItemId 
        {
            get { return this._picklistBinPicklistItemId; }
            set { this._picklistBinPicklistItemId = value; }
        }

		PicklistBinPicklistItemId IGlobalIdentity<PicklistBinPicklistItemId>.GlobalId {
			get {
				return  this.PicklistBinPicklistItemId;
			}
		}

        PicklistItemOrderShipGrpInvId ILocalIdentity<PicklistItemOrderShipGrpInvId>.LocalId
        {
            get
            {
                return this.PicklistItemOrderShipGrpInvId;
            }
        }


        public override string PicklistBinId {
			get {
				return this.PicklistBinPicklistItemId.PicklistBinId;
			}
			set {
				this.PicklistBinPicklistItemId.PicklistBinId = value;
			}
		}

        public override PicklistItemOrderShipGrpInvId PicklistItemOrderShipGrpInvId {
			get {
				return this.PicklistBinPicklistItemId.PicklistItemOrderShipGrpInvId;
			}
			set {
				this.PicklistBinPicklistItemId.PicklistItemOrderShipGrpInvId = value;
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

        bool IPicklistItemState.IsUnsaved
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

        public PicklistItemState() : this(false)
        {
        }

        public PicklistItemState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IPicklistItemStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ItemStatusId = e.ItemStatusId;

			this.Quantity = e.Quantity;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IPicklistItemStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.ItemStatusId == null)
			{
				if (e.IsPropertyItemStatusIdRemoved)
				{
					this.ItemStatusId = default(string);
				}
			}
			else
			{
				this.ItemStatusId = e.ItemStatusId;
			}

			if (e.Quantity == null)
			{
				if (e.IsPropertyQuantityRemoved)
				{
					this.Quantity = default(decimal?);
				}
			}
			else
			{
				this.Quantity = e.Quantity;
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

		public virtual void When(IPicklistItemStateRemoved e)
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

        protected void ThrowOnWrongEvent(IPicklistItemStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("PicklistItem|");

            var stateEntityIdPicklistBinId = (this as IGlobalIdentity<PicklistBinPicklistItemId>).GlobalId.PicklistBinId;
            var eventEntityIdPicklistBinId = stateEvent.PicklistItemEventId.PicklistBinId;
            if (stateEntityIdPicklistBinId != eventEntityIdPicklistBinId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id PicklistBinId {0} in state but entity id PicklistBinId {1} in event", stateEntityIdPicklistBinId, eventEntityIdPicklistBinId);
            }
            id.Append(stateEntityIdPicklistBinId).Append(",");

            var stateEntityIdPicklistItemOrderShipGrpInvId = (this as IGlobalIdentity<PicklistBinPicklistItemId>).GlobalId.PicklistItemOrderShipGrpInvId;
            var eventEntityIdPicklistItemOrderShipGrpInvId = stateEvent.PicklistItemEventId.PicklistItemOrderShipGrpInvId;
            if (stateEntityIdPicklistItemOrderShipGrpInvId != eventEntityIdPicklistItemOrderShipGrpInvId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id PicklistItemOrderShipGrpInvId {0} in state but entity id PicklistItemOrderShipGrpInvId {1} in event", stateEntityIdPicklistItemOrderShipGrpInvId, eventEntityIdPicklistItemOrderShipGrpInvId);
            }
            id.Append(stateEntityIdPicklistItemOrderShipGrpInvId).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (PicklistItemState.VersionZero == eventVersion)
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

