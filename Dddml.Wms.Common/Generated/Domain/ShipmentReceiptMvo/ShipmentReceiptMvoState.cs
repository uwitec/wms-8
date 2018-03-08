﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentReceiptMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentReceiptMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentReceiptMvo
{

	public partial class ShipmentReceiptMvoState : ShipmentReceiptMvoStateProperties, IShipmentReceiptMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }


		#region IIdentity implementation

		ShipmentReceiptId IGlobalIdentity<ShipmentReceiptId>.GlobalId
		{
			get
			{
				return this.ShipmentReceiptId;
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
				return this.ShipmentVersion;
			}
		}


		#endregion

        bool IShipmentReceiptMvoState.IsUnsaved
        {
            get { return this.ShipmentVersion == VersionZero; }
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

        public ShipmentReceiptMvoState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.ShipmentReceiptId = ((IShipmentReceiptMvoStateEvent)events.First()).ShipmentReceiptMvoEventId.ShipmentReceiptId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.ShipmentVersion += 1;
                }
            }
        }

        public ShipmentReceiptMvoState() : this(false)
        {
        }

        public ShipmentReceiptMvoState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IShipmentReceiptMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.ProductId = e.ProductId;

			this.AttributeSetInstanceId = e.AttributeSetInstanceId;

			this.ShipmentItemSeqId = e.ShipmentItemSeqId;

			this.RejectionReasonId = e.RejectionReasonId;

			this.DamageStatusId = e.DamageStatusId;

			this.DamageReasonId = e.DamageReasonId;

			this.ReceivedBy = e.ReceivedBy;

			this.DatetimeReceived = e.DatetimeReceived;

			this.ItemDescription = e.ItemDescription;

			this.AcceptedQuantity = e.AcceptedQuantity;

			this.RejectedQuantity = e.RejectedQuantity;

			this.DamagedQuantity = e.DamagedQuantity;

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.ShipmentShipmentTypeId = e.ShipmentShipmentTypeId;

			this.ShipmentStatusId = e.ShipmentStatusId;

			this.ShipmentPrimaryOrderId = e.ShipmentPrimaryOrderId;

			this.ShipmentPrimaryReturnId = e.ShipmentPrimaryReturnId;

			this.ShipmentPicklistBinId = e.ShipmentPicklistBinId;

			this.ShipmentEstimatedReadyDate = e.ShipmentEstimatedReadyDate;

			this.ShipmentEstimatedShipDate = e.ShipmentEstimatedShipDate;

			this.ShipmentEstimatedShipWorkEffId = e.ShipmentEstimatedShipWorkEffId;

			this.ShipmentEstimatedArrivalDate = e.ShipmentEstimatedArrivalDate;

			this.ShipmentEstimatedArrivalWorkEffId = e.ShipmentEstimatedArrivalWorkEffId;

			this.ShipmentLatestCancelDate = e.ShipmentLatestCancelDate;

			this.ShipmentEstimatedShipCost = e.ShipmentEstimatedShipCost;

			this.ShipmentCurrencyUomId = e.ShipmentCurrencyUomId;

			this.ShipmentHandlingInstructions = e.ShipmentHandlingInstructions;

			this.ShipmentOriginFacilityId = e.ShipmentOriginFacilityId;

			this.ShipmentDestinationFacilityId = e.ShipmentDestinationFacilityId;

			this.ShipmentOriginContactMechId = e.ShipmentOriginContactMechId;

			this.ShipmentOriginTelecomNumberId = e.ShipmentOriginTelecomNumberId;

			this.ShipmentDestinationContactMechId = e.ShipmentDestinationContactMechId;

			this.ShipmentDestinationTelecomNumberId = e.ShipmentDestinationTelecomNumberId;

			this.ShipmentPartyIdTo = e.ShipmentPartyIdTo;

			this.ShipmentPartyIdFrom = e.ShipmentPartyIdFrom;

			this.ShipmentAdditionalShippingCharge = e.ShipmentAdditionalShippingCharge;

			this.ShipmentAddtlShippingChargeDesc = e.ShipmentAddtlShippingChargeDesc;

			this.ShipmentShipperId = e.ShipmentShipperId;

			this.ShipmentCreatedBy = e.ShipmentCreatedBy;

            this.ShipmentCreatedAt = (e.ShipmentCreatedAt != null && e.ShipmentCreatedAt.HasValue) ? e.ShipmentCreatedAt.Value : default(DateTime);

			this.ShipmentUpdatedBy = e.ShipmentUpdatedBy;

            this.ShipmentUpdatedAt = (e.ShipmentUpdatedAt != null && e.ShipmentUpdatedAt.HasValue) ? e.ShipmentUpdatedAt.Value : default(DateTime);

            this.ShipmentActive = (e.ShipmentActive != null && e.ShipmentActive.HasValue) ? e.ShipmentActive.Value : default(bool);

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IShipmentReceiptMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.ProductId == null)
			{
				if (e.IsPropertyProductIdRemoved)
				{
					this.ProductId = default(string);
				}
			}
			else
			{
				this.ProductId = e.ProductId;
			}

			if (e.AttributeSetInstanceId == null)
			{
				if (e.IsPropertyAttributeSetInstanceIdRemoved)
				{
					this.AttributeSetInstanceId = default(string);
				}
			}
			else
			{
				this.AttributeSetInstanceId = e.AttributeSetInstanceId;
			}

			if (e.ShipmentItemSeqId == null)
			{
				if (e.IsPropertyShipmentItemSeqIdRemoved)
				{
					this.ShipmentItemSeqId = default(string);
				}
			}
			else
			{
				this.ShipmentItemSeqId = e.ShipmentItemSeqId;
			}

			if (e.RejectionReasonId == null)
			{
				if (e.IsPropertyRejectionReasonIdRemoved)
				{
					this.RejectionReasonId = default(string);
				}
			}
			else
			{
				this.RejectionReasonId = e.RejectionReasonId;
			}

			if (e.DamageStatusId == null)
			{
				if (e.IsPropertyDamageStatusIdRemoved)
				{
					this.DamageStatusId = default(string);
				}
			}
			else
			{
				this.DamageStatusId = e.DamageStatusId;
			}

			if (e.DamageReasonId == null)
			{
				if (e.IsPropertyDamageReasonIdRemoved)
				{
					this.DamageReasonId = default(string);
				}
			}
			else
			{
				this.DamageReasonId = e.DamageReasonId;
			}

			if (e.ReceivedBy == null)
			{
				if (e.IsPropertyReceivedByRemoved)
				{
					this.ReceivedBy = default(string);
				}
			}
			else
			{
				this.ReceivedBy = e.ReceivedBy;
			}

			if (e.DatetimeReceived == null)
			{
				if (e.IsPropertyDatetimeReceivedRemoved)
				{
					this.DatetimeReceived = default(DateTime?);
				}
			}
			else
			{
				this.DatetimeReceived = e.DatetimeReceived;
			}

			if (e.ItemDescription == null)
			{
				if (e.IsPropertyItemDescriptionRemoved)
				{
					this.ItemDescription = default(string);
				}
			}
			else
			{
				this.ItemDescription = e.ItemDescription;
			}

			if (e.AcceptedQuantity == null)
			{
				if (e.IsPropertyAcceptedQuantityRemoved)
				{
					this.AcceptedQuantity = default(decimal?);
				}
			}
			else
			{
				this.AcceptedQuantity = e.AcceptedQuantity;
			}

			if (e.RejectedQuantity == null)
			{
				if (e.IsPropertyRejectedQuantityRemoved)
				{
					this.RejectedQuantity = default(decimal?);
				}
			}
			else
			{
				this.RejectedQuantity = e.RejectedQuantity;
			}

			if (e.DamagedQuantity == null)
			{
				if (e.IsPropertyDamagedQuantityRemoved)
				{
					this.DamagedQuantity = default(decimal?);
				}
			}
			else
			{
				this.DamagedQuantity = e.DamagedQuantity;
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

			if (e.ShipmentShipmentTypeId == null)
			{
				if (e.IsPropertyShipmentShipmentTypeIdRemoved)
				{
					this.ShipmentShipmentTypeId = default(string);
				}
			}
			else
			{
				this.ShipmentShipmentTypeId = e.ShipmentShipmentTypeId;
			}

			if (e.ShipmentStatusId == null)
			{
				if (e.IsPropertyShipmentStatusIdRemoved)
				{
					this.ShipmentStatusId = default(string);
				}
			}
			else
			{
				this.ShipmentStatusId = e.ShipmentStatusId;
			}

			if (e.ShipmentPrimaryOrderId == null)
			{
				if (e.IsPropertyShipmentPrimaryOrderIdRemoved)
				{
					this.ShipmentPrimaryOrderId = default(string);
				}
			}
			else
			{
				this.ShipmentPrimaryOrderId = e.ShipmentPrimaryOrderId;
			}

			if (e.ShipmentPrimaryReturnId == null)
			{
				if (e.IsPropertyShipmentPrimaryReturnIdRemoved)
				{
					this.ShipmentPrimaryReturnId = default(string);
				}
			}
			else
			{
				this.ShipmentPrimaryReturnId = e.ShipmentPrimaryReturnId;
			}

			if (e.ShipmentPicklistBinId == null)
			{
				if (e.IsPropertyShipmentPicklistBinIdRemoved)
				{
					this.ShipmentPicklistBinId = default(string);
				}
			}
			else
			{
				this.ShipmentPicklistBinId = e.ShipmentPicklistBinId;
			}

			if (e.ShipmentEstimatedReadyDate == null)
			{
				if (e.IsPropertyShipmentEstimatedReadyDateRemoved)
				{
					this.ShipmentEstimatedReadyDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipmentEstimatedReadyDate = e.ShipmentEstimatedReadyDate;
			}

			if (e.ShipmentEstimatedShipDate == null)
			{
				if (e.IsPropertyShipmentEstimatedShipDateRemoved)
				{
					this.ShipmentEstimatedShipDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipmentEstimatedShipDate = e.ShipmentEstimatedShipDate;
			}

			if (e.ShipmentEstimatedShipWorkEffId == null)
			{
				if (e.IsPropertyShipmentEstimatedShipWorkEffIdRemoved)
				{
					this.ShipmentEstimatedShipWorkEffId = default(string);
				}
			}
			else
			{
				this.ShipmentEstimatedShipWorkEffId = e.ShipmentEstimatedShipWorkEffId;
			}

			if (e.ShipmentEstimatedArrivalDate == null)
			{
				if (e.IsPropertyShipmentEstimatedArrivalDateRemoved)
				{
					this.ShipmentEstimatedArrivalDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipmentEstimatedArrivalDate = e.ShipmentEstimatedArrivalDate;
			}

			if (e.ShipmentEstimatedArrivalWorkEffId == null)
			{
				if (e.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved)
				{
					this.ShipmentEstimatedArrivalWorkEffId = default(string);
				}
			}
			else
			{
				this.ShipmentEstimatedArrivalWorkEffId = e.ShipmentEstimatedArrivalWorkEffId;
			}

			if (e.ShipmentLatestCancelDate == null)
			{
				if (e.IsPropertyShipmentLatestCancelDateRemoved)
				{
					this.ShipmentLatestCancelDate = default(DateTime?);
				}
			}
			else
			{
				this.ShipmentLatestCancelDate = e.ShipmentLatestCancelDate;
			}

			if (e.ShipmentEstimatedShipCost == null)
			{
				if (e.IsPropertyShipmentEstimatedShipCostRemoved)
				{
					this.ShipmentEstimatedShipCost = default(decimal?);
				}
			}
			else
			{
				this.ShipmentEstimatedShipCost = e.ShipmentEstimatedShipCost;
			}

			if (e.ShipmentCurrencyUomId == null)
			{
				if (e.IsPropertyShipmentCurrencyUomIdRemoved)
				{
					this.ShipmentCurrencyUomId = default(string);
				}
			}
			else
			{
				this.ShipmentCurrencyUomId = e.ShipmentCurrencyUomId;
			}

			if (e.ShipmentHandlingInstructions == null)
			{
				if (e.IsPropertyShipmentHandlingInstructionsRemoved)
				{
					this.ShipmentHandlingInstructions = default(string);
				}
			}
			else
			{
				this.ShipmentHandlingInstructions = e.ShipmentHandlingInstructions;
			}

			if (e.ShipmentOriginFacilityId == null)
			{
				if (e.IsPropertyShipmentOriginFacilityIdRemoved)
				{
					this.ShipmentOriginFacilityId = default(string);
				}
			}
			else
			{
				this.ShipmentOriginFacilityId = e.ShipmentOriginFacilityId;
			}

			if (e.ShipmentDestinationFacilityId == null)
			{
				if (e.IsPropertyShipmentDestinationFacilityIdRemoved)
				{
					this.ShipmentDestinationFacilityId = default(string);
				}
			}
			else
			{
				this.ShipmentDestinationFacilityId = e.ShipmentDestinationFacilityId;
			}

			if (e.ShipmentOriginContactMechId == null)
			{
				if (e.IsPropertyShipmentOriginContactMechIdRemoved)
				{
					this.ShipmentOriginContactMechId = default(string);
				}
			}
			else
			{
				this.ShipmentOriginContactMechId = e.ShipmentOriginContactMechId;
			}

			if (e.ShipmentOriginTelecomNumberId == null)
			{
				if (e.IsPropertyShipmentOriginTelecomNumberIdRemoved)
				{
					this.ShipmentOriginTelecomNumberId = default(string);
				}
			}
			else
			{
				this.ShipmentOriginTelecomNumberId = e.ShipmentOriginTelecomNumberId;
			}

			if (e.ShipmentDestinationContactMechId == null)
			{
				if (e.IsPropertyShipmentDestinationContactMechIdRemoved)
				{
					this.ShipmentDestinationContactMechId = default(string);
				}
			}
			else
			{
				this.ShipmentDestinationContactMechId = e.ShipmentDestinationContactMechId;
			}

			if (e.ShipmentDestinationTelecomNumberId == null)
			{
				if (e.IsPropertyShipmentDestinationTelecomNumberIdRemoved)
				{
					this.ShipmentDestinationTelecomNumberId = default(string);
				}
			}
			else
			{
				this.ShipmentDestinationTelecomNumberId = e.ShipmentDestinationTelecomNumberId;
			}

			if (e.ShipmentPartyIdTo == null)
			{
				if (e.IsPropertyShipmentPartyIdToRemoved)
				{
					this.ShipmentPartyIdTo = default(string);
				}
			}
			else
			{
				this.ShipmentPartyIdTo = e.ShipmentPartyIdTo;
			}

			if (e.ShipmentPartyIdFrom == null)
			{
				if (e.IsPropertyShipmentPartyIdFromRemoved)
				{
					this.ShipmentPartyIdFrom = default(string);
				}
			}
			else
			{
				this.ShipmentPartyIdFrom = e.ShipmentPartyIdFrom;
			}

			if (e.ShipmentAdditionalShippingCharge == null)
			{
				if (e.IsPropertyShipmentAdditionalShippingChargeRemoved)
				{
					this.ShipmentAdditionalShippingCharge = default(decimal?);
				}
			}
			else
			{
				this.ShipmentAdditionalShippingCharge = e.ShipmentAdditionalShippingCharge;
			}

			if (e.ShipmentAddtlShippingChargeDesc == null)
			{
				if (e.IsPropertyShipmentAddtlShippingChargeDescRemoved)
				{
					this.ShipmentAddtlShippingChargeDesc = default(string);
				}
			}
			else
			{
				this.ShipmentAddtlShippingChargeDesc = e.ShipmentAddtlShippingChargeDesc;
			}

			if (e.ShipmentShipperId == null)
			{
				if (e.IsPropertyShipmentShipperIdRemoved)
				{
					this.ShipmentShipperId = default(string);
				}
			}
			else
			{
				this.ShipmentShipperId = e.ShipmentShipperId;
			}

			if (e.ShipmentCreatedBy == null)
			{
				if (e.IsPropertyShipmentCreatedByRemoved)
				{
					this.ShipmentCreatedBy = default(string);
				}
			}
			else
			{
				this.ShipmentCreatedBy = e.ShipmentCreatedBy;
			}

			if (e.ShipmentCreatedAt == null)
			{
				if (e.IsPropertyShipmentCreatedAtRemoved)
				{
					this.ShipmentCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.ShipmentCreatedAt = (e.ShipmentCreatedAt != null && e.ShipmentCreatedAt.HasValue) ? e.ShipmentCreatedAt.Value : default(DateTime);
			}

			if (e.ShipmentUpdatedBy == null)
			{
				if (e.IsPropertyShipmentUpdatedByRemoved)
				{
					this.ShipmentUpdatedBy = default(string);
				}
			}
			else
			{
				this.ShipmentUpdatedBy = e.ShipmentUpdatedBy;
			}

			if (e.ShipmentUpdatedAt == null)
			{
				if (e.IsPropertyShipmentUpdatedAtRemoved)
				{
					this.ShipmentUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.ShipmentUpdatedAt = (e.ShipmentUpdatedAt != null && e.ShipmentUpdatedAt.HasValue) ? e.ShipmentUpdatedAt.Value : default(DateTime);
			}

			if (e.ShipmentActive == null)
			{
				if (e.IsPropertyShipmentActiveRemoved)
				{
					this.ShipmentActive = default(bool);
				}
			}
			else
			{
				this.ShipmentActive = (e.ShipmentActive != null && e.ShipmentActive.HasValue) ? e.ShipmentActive.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IShipmentReceiptMvoStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("ShipmentReceiptMvo|");

            var stateEntityId = this.ShipmentReceiptId; // Aggregate Id
            var eventEntityId = stateEvent.ShipmentReceiptMvoEventId.ShipmentReceiptId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.ShipmentVersion;
            var eventVersion = stateEvent.ShipmentReceiptMvoEventId.ShipmentVersion;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

