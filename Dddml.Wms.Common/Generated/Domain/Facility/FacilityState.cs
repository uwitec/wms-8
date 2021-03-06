﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateFacilityDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Facility;

namespace Dddml.Wms.Domain.Facility
{

	public partial class FacilityState : FacilityStateProperties, IFacilityState
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
				return this.FacilityId;
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

        bool IFacilityState.IsUnsaved
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

        public FacilityState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.FacilityId = ((IFacilityEvent)events.First()).FacilityEventId.FacilityId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public FacilityState() : this(false)
        {
        }

        public FacilityState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IFacilityStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.FacilityTypeId = e.FacilityTypeId;

			this.ParentFacilityId = e.ParentFacilityId;

			this.OwnerPartyId = e.OwnerPartyId;

			this.DefaultInventoryItemTypeId = e.DefaultInventoryItemTypeId;

			this.FacilityName = e.FacilityName;

			this.PrimaryFacilityGroupId = e.PrimaryFacilityGroupId;

			this.OldSquareFootage = e.OldSquareFootage;

			this.FacilitySize = e.FacilitySize;

			this.FacilitySizeUomId = e.FacilitySizeUomId;

			this.ProductStoreId = e.ProductStoreId;

			this.DefaultDaysToShip = e.DefaultDaysToShip;

			this.OpenedDate = e.OpenedDate;

			this.ClosedDate = e.ClosedDate;

			this.Description = e.Description;

			this.DefaultDimensionUomId = e.DefaultDimensionUomId;

			this.DefaultWeightUomId = e.DefaultWeightUomId;

			this.GeoPointId = e.GeoPointId;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IFacilityStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.FacilityTypeId == null)
			{
				if (e.IsPropertyFacilityTypeIdRemoved)
				{
					this.FacilityTypeId = default(string);
				}
			}
			else
			{
				this.FacilityTypeId = e.FacilityTypeId;
			}

			if (e.ParentFacilityId == null)
			{
				if (e.IsPropertyParentFacilityIdRemoved)
				{
					this.ParentFacilityId = default(string);
				}
			}
			else
			{
				this.ParentFacilityId = e.ParentFacilityId;
			}

			if (e.OwnerPartyId == null)
			{
				if (e.IsPropertyOwnerPartyIdRemoved)
				{
					this.OwnerPartyId = default(string);
				}
			}
			else
			{
				this.OwnerPartyId = e.OwnerPartyId;
			}

			if (e.DefaultInventoryItemTypeId == null)
			{
				if (e.IsPropertyDefaultInventoryItemTypeIdRemoved)
				{
					this.DefaultInventoryItemTypeId = default(string);
				}
			}
			else
			{
				this.DefaultInventoryItemTypeId = e.DefaultInventoryItemTypeId;
			}

			if (e.FacilityName == null)
			{
				if (e.IsPropertyFacilityNameRemoved)
				{
					this.FacilityName = default(string);
				}
			}
			else
			{
				this.FacilityName = e.FacilityName;
			}

			if (e.PrimaryFacilityGroupId == null)
			{
				if (e.IsPropertyPrimaryFacilityGroupIdRemoved)
				{
					this.PrimaryFacilityGroupId = default(string);
				}
			}
			else
			{
				this.PrimaryFacilityGroupId = e.PrimaryFacilityGroupId;
			}

			if (e.OldSquareFootage == null)
			{
				if (e.IsPropertyOldSquareFootageRemoved)
				{
					this.OldSquareFootage = default(long?);
				}
			}
			else
			{
				this.OldSquareFootage = e.OldSquareFootage;
			}

			if (e.FacilitySize == null)
			{
				if (e.IsPropertyFacilitySizeRemoved)
				{
					this.FacilitySize = default(decimal?);
				}
			}
			else
			{
				this.FacilitySize = e.FacilitySize;
			}

			if (e.FacilitySizeUomId == null)
			{
				if (e.IsPropertyFacilitySizeUomIdRemoved)
				{
					this.FacilitySizeUomId = default(string);
				}
			}
			else
			{
				this.FacilitySizeUomId = e.FacilitySizeUomId;
			}

			if (e.ProductStoreId == null)
			{
				if (e.IsPropertyProductStoreIdRemoved)
				{
					this.ProductStoreId = default(string);
				}
			}
			else
			{
				this.ProductStoreId = e.ProductStoreId;
			}

			if (e.DefaultDaysToShip == null)
			{
				if (e.IsPropertyDefaultDaysToShipRemoved)
				{
					this.DefaultDaysToShip = default(long?);
				}
			}
			else
			{
				this.DefaultDaysToShip = e.DefaultDaysToShip;
			}

			if (e.OpenedDate == null)
			{
				if (e.IsPropertyOpenedDateRemoved)
				{
					this.OpenedDate = default(DateTime?);
				}
			}
			else
			{
				this.OpenedDate = e.OpenedDate;
			}

			if (e.ClosedDate == null)
			{
				if (e.IsPropertyClosedDateRemoved)
				{
					this.ClosedDate = default(DateTime?);
				}
			}
			else
			{
				this.ClosedDate = e.ClosedDate;
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

			if (e.DefaultDimensionUomId == null)
			{
				if (e.IsPropertyDefaultDimensionUomIdRemoved)
				{
					this.DefaultDimensionUomId = default(string);
				}
			}
			else
			{
				this.DefaultDimensionUomId = e.DefaultDimensionUomId;
			}

			if (e.DefaultWeightUomId == null)
			{
				if (e.IsPropertyDefaultWeightUomIdRemoved)
				{
					this.DefaultWeightUomId = default(string);
				}
			}
			else
			{
				this.DefaultWeightUomId = e.DefaultWeightUomId;
			}

			if (e.GeoPointId == null)
			{
				if (e.IsPropertyGeoPointIdRemoved)
				{
					this.GeoPointId = default(string);
				}
			}
			else
			{
				this.GeoPointId = e.GeoPointId;
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

		public virtual void When(IFacilityStateDeleted e)
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

        protected void ThrowOnWrongEvent(IFacilityEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("Facility|");

            var stateEntityId = this.FacilityId; // Aggregate Id
            var eventEntityId = e.FacilityEventId.FacilityId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = e.FacilityEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

