﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public partial class ShipmentState : ShipmentStateProperties, IShipmentState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.ShipmentId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
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

        bool IShipmentState.IsUnsaved
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

        public ShipmentState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.ShipmentId = ((IShipmentStateEvent)events.First()).StateEventId.ShipmentId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public ShipmentState() : this(false)
        {
        }

        public ShipmentState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IShipmentStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ShipmentTypeId = e.ShipmentTypeId;

			this.StatusId = e.StatusId;

			this.PrimaryOrderId = e.PrimaryOrderId;

			this.PrimaryReturnId = e.PrimaryReturnId;

			this.PicklistBinId = e.PicklistBinId;

			this.EstimatedReadyDate = e.EstimatedReadyDate;

			this.EstimatedShipDate = e.EstimatedShipDate;

			this.EstimatedShipWorkEffId = e.EstimatedShipWorkEffId;

			this.EstimatedArrivalDate = e.EstimatedArrivalDate;

			this.EstimatedArrivalWorkEffId = e.EstimatedArrivalWorkEffId;

			this.LatestCancelDate = e.LatestCancelDate;

			this.EstimatedShipCost = e.EstimatedShipCost;

			this.CurrencyUomId = e.CurrencyUomId;

			this.HandlingInstructions = e.HandlingInstructions;

			this.OriginFacilityId = e.OriginFacilityId;

			this.DestinationFacilityId = e.DestinationFacilityId;

			this.OriginContactMechId = e.OriginContactMechId;

			this.OriginTelecomNumberId = e.OriginTelecomNumberId;

			this.DestinationContactMechId = e.DestinationContactMechId;

			this.DestinationTelecomNumberId = e.DestinationTelecomNumberId;

			this.PartyIdTo = e.PartyIdTo;

			this.PartyIdFrom = e.PartyIdFrom;

			this.AdditionalShippingCharge = e.AdditionalShippingCharge;

			this.AddtlShippingChargeDesc = e.AddtlShippingChargeDesc;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IShipmentStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.ShipmentTypeId == null)
			{
				if (e.IsPropertyShipmentTypeIdRemoved)
				{
					this.ShipmentTypeId = default(string);
				}
			}
			else
			{
				this.ShipmentTypeId = e.ShipmentTypeId;
			}

			if (e.StatusId == null)
			{
				if (e.IsPropertyStatusIdRemoved)
				{
					this.StatusId = default(string);
				}
			}
			else
			{
				this.StatusId = e.StatusId;
			}

			if (e.PrimaryOrderId == null)
			{
				if (e.IsPropertyPrimaryOrderIdRemoved)
				{
					this.PrimaryOrderId = default(string);
				}
			}
			else
			{
				this.PrimaryOrderId = e.PrimaryOrderId;
			}

			if (e.PrimaryReturnId == null)
			{
				if (e.IsPropertyPrimaryReturnIdRemoved)
				{
					this.PrimaryReturnId = default(string);
				}
			}
			else
			{
				this.PrimaryReturnId = e.PrimaryReturnId;
			}

			if (e.PicklistBinId == null)
			{
				if (e.IsPropertyPicklistBinIdRemoved)
				{
					this.PicklistBinId = default(string);
				}
			}
			else
			{
				this.PicklistBinId = e.PicklistBinId;
			}

			if (e.EstimatedReadyDate == null)
			{
				if (e.IsPropertyEstimatedReadyDateRemoved)
				{
					this.EstimatedReadyDate = default(DateTime?);
				}
			}
			else
			{
				this.EstimatedReadyDate = e.EstimatedReadyDate;
			}

			if (e.EstimatedShipDate == null)
			{
				if (e.IsPropertyEstimatedShipDateRemoved)
				{
					this.EstimatedShipDate = default(DateTime?);
				}
			}
			else
			{
				this.EstimatedShipDate = e.EstimatedShipDate;
			}

			if (e.EstimatedShipWorkEffId == null)
			{
				if (e.IsPropertyEstimatedShipWorkEffIdRemoved)
				{
					this.EstimatedShipWorkEffId = default(string);
				}
			}
			else
			{
				this.EstimatedShipWorkEffId = e.EstimatedShipWorkEffId;
			}

			if (e.EstimatedArrivalDate == null)
			{
				if (e.IsPropertyEstimatedArrivalDateRemoved)
				{
					this.EstimatedArrivalDate = default(DateTime?);
				}
			}
			else
			{
				this.EstimatedArrivalDate = e.EstimatedArrivalDate;
			}

			if (e.EstimatedArrivalWorkEffId == null)
			{
				if (e.IsPropertyEstimatedArrivalWorkEffIdRemoved)
				{
					this.EstimatedArrivalWorkEffId = default(string);
				}
			}
			else
			{
				this.EstimatedArrivalWorkEffId = e.EstimatedArrivalWorkEffId;
			}

			if (e.LatestCancelDate == null)
			{
				if (e.IsPropertyLatestCancelDateRemoved)
				{
					this.LatestCancelDate = default(DateTime?);
				}
			}
			else
			{
				this.LatestCancelDate = e.LatestCancelDate;
			}

			if (e.EstimatedShipCost == null)
			{
				if (e.IsPropertyEstimatedShipCostRemoved)
				{
					this.EstimatedShipCost = default(decimal?);
				}
			}
			else
			{
				this.EstimatedShipCost = e.EstimatedShipCost;
			}

			if (e.CurrencyUomId == null)
			{
				if (e.IsPropertyCurrencyUomIdRemoved)
				{
					this.CurrencyUomId = default(string);
				}
			}
			else
			{
				this.CurrencyUomId = e.CurrencyUomId;
			}

			if (e.HandlingInstructions == null)
			{
				if (e.IsPropertyHandlingInstructionsRemoved)
				{
					this.HandlingInstructions = default(string);
				}
			}
			else
			{
				this.HandlingInstructions = e.HandlingInstructions;
			}

			if (e.OriginFacilityId == null)
			{
				if (e.IsPropertyOriginFacilityIdRemoved)
				{
					this.OriginFacilityId = default(string);
				}
			}
			else
			{
				this.OriginFacilityId = e.OriginFacilityId;
			}

			if (e.DestinationFacilityId == null)
			{
				if (e.IsPropertyDestinationFacilityIdRemoved)
				{
					this.DestinationFacilityId = default(string);
				}
			}
			else
			{
				this.DestinationFacilityId = e.DestinationFacilityId;
			}

			if (e.OriginContactMechId == null)
			{
				if (e.IsPropertyOriginContactMechIdRemoved)
				{
					this.OriginContactMechId = default(string);
				}
			}
			else
			{
				this.OriginContactMechId = e.OriginContactMechId;
			}

			if (e.OriginTelecomNumberId == null)
			{
				if (e.IsPropertyOriginTelecomNumberIdRemoved)
				{
					this.OriginTelecomNumberId = default(string);
				}
			}
			else
			{
				this.OriginTelecomNumberId = e.OriginTelecomNumberId;
			}

			if (e.DestinationContactMechId == null)
			{
				if (e.IsPropertyDestinationContactMechIdRemoved)
				{
					this.DestinationContactMechId = default(string);
				}
			}
			else
			{
				this.DestinationContactMechId = e.DestinationContactMechId;
			}

			if (e.DestinationTelecomNumberId == null)
			{
				if (e.IsPropertyDestinationTelecomNumberIdRemoved)
				{
					this.DestinationTelecomNumberId = default(string);
				}
			}
			else
			{
				this.DestinationTelecomNumberId = e.DestinationTelecomNumberId;
			}

			if (e.PartyIdTo == null)
			{
				if (e.IsPropertyPartyIdToRemoved)
				{
					this.PartyIdTo = default(string);
				}
			}
			else
			{
				this.PartyIdTo = e.PartyIdTo;
			}

			if (e.PartyIdFrom == null)
			{
				if (e.IsPropertyPartyIdFromRemoved)
				{
					this.PartyIdFrom = default(string);
				}
			}
			else
			{
				this.PartyIdFrom = e.PartyIdFrom;
			}

			if (e.AdditionalShippingCharge == null)
			{
				if (e.IsPropertyAdditionalShippingChargeRemoved)
				{
					this.AdditionalShippingCharge = default(decimal?);
				}
			}
			else
			{
				this.AdditionalShippingCharge = e.AdditionalShippingCharge;
			}

			if (e.AddtlShippingChargeDesc == null)
			{
				if (e.IsPropertyAddtlShippingChargeDescRemoved)
				{
					this.AddtlShippingChargeDesc = default(string);
				}
			}
			else
			{
				this.AddtlShippingChargeDesc = e.AddtlShippingChargeDesc;
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


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IShipmentStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("Shipment|");

            var stateEntityId = this.ShipmentId; // Aggregate Id
            var eventEntityId = stateEvent.StateEventId.ShipmentId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = stateEvent.StateEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

