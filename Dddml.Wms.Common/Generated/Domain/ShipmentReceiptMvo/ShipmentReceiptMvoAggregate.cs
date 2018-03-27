﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentReceiptMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentReceiptMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentReceiptMvo
{
    public partial class ShipmentReceiptMvoAggregate : AggregateBase, IShipmentReceiptMvoAggregate
    {

        readonly IShipmentReceiptMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IShipmentReceiptMvoState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        ShipmentReceiptId IGlobalIdentity<ShipmentReceiptId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public ShipmentReceiptMvoAggregate(IShipmentReceiptMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IShipmentReceiptMvoStateProperties)_state).ShipmentVersion == ShipmentReceiptMvoState.VersionZero)
            {
                if (IsCommandCreate((IShipmentReceiptMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (IsCommandCreate((IShipmentReceiptMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IShipmentReceiptMvoCommand c)
        {
            return c.ShipmentVersion == ShipmentReceiptMvoState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateShipmentReceiptMvo c)
        {
            IShipmentReceiptMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchShipmentReceiptMvo c)
        {
            IShipmentReceiptMvoStateMergePatched e = Map(c);
            Apply(e);
        }


        protected virtual IShipmentReceiptMvoStateCreated Map(ICreateShipmentReceiptMvo c)
        {
			var stateEventId = new ShipmentReceiptMvoEventId(c.ShipmentReceiptId, c.ShipmentVersion);
            IShipmentReceiptMvoStateCreated e = NewShipmentReceiptMvoStateCreated(stateEventId);
		
            e.ProductId = c.ProductId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.LocatorId = c.LocatorId;
            e.ShipmentItemSeqId = c.ShipmentItemSeqId;
            e.ShipmentPackageSeqId = c.ShipmentPackageSeqId;
            e.OrderId = c.OrderId;
            e.OrderItemSeqId = c.OrderItemSeqId;
            e.ReturnId = c.ReturnId;
            e.ReturnItemSeqId = c.ReturnItemSeqId;
            e.RejectionReasonId = c.RejectionReasonId;
            e.DamageStatusId = c.DamageStatusId;
            e.DamageReasonId = c.DamageReasonId;
            e.ReceivedBy = c.ReceivedBy;
            e.DatetimeReceived = c.DatetimeReceived;
            e.ItemDescription = c.ItemDescription;
            e.AcceptedQuantity = c.AcceptedQuantity;
            e.RejectedQuantity = c.RejectedQuantity;
            e.DamagedQuantity = c.DamagedQuantity;
            e.Version = c.Version;
            e.Active = c.Active;
            e.ShipmentShipmentTypeId = c.ShipmentShipmentTypeId;
            e.ShipmentStatusId = c.ShipmentStatusId;
            e.ShipmentPrimaryOrderId = c.ShipmentPrimaryOrderId;
            e.ShipmentPrimaryReturnId = c.ShipmentPrimaryReturnId;
            e.ShipmentPrimaryShipGroupSeqId = c.ShipmentPrimaryShipGroupSeqId;
            e.ShipmentPicklistBinId = c.ShipmentPicklistBinId;
            e.ShipmentEstimatedReadyDate = c.ShipmentEstimatedReadyDate;
            e.ShipmentEstimatedShipDate = c.ShipmentEstimatedShipDate;
            e.ShipmentEstimatedShipWorkEffId = c.ShipmentEstimatedShipWorkEffId;
            e.ShipmentEstimatedArrivalDate = c.ShipmentEstimatedArrivalDate;
            e.ShipmentEstimatedArrivalWorkEffId = c.ShipmentEstimatedArrivalWorkEffId;
            e.ShipmentLatestCancelDate = c.ShipmentLatestCancelDate;
            e.ShipmentEstimatedShipCost = c.ShipmentEstimatedShipCost;
            e.ShipmentCurrencyUomId = c.ShipmentCurrencyUomId;
            e.ShipmentHandlingInstructions = c.ShipmentHandlingInstructions;
            e.ShipmentOriginFacilityId = c.ShipmentOriginFacilityId;
            e.ShipmentDestinationFacilityId = c.ShipmentDestinationFacilityId;
            e.ShipmentOriginContactMechId = c.ShipmentOriginContactMechId;
            e.ShipmentOriginTelecomNumberId = c.ShipmentOriginTelecomNumberId;
            e.ShipmentDestinationContactMechId = c.ShipmentDestinationContactMechId;
            e.ShipmentDestinationTelecomNumberId = c.ShipmentDestinationTelecomNumberId;
            e.ShipmentPartyIdTo = c.ShipmentPartyIdTo;
            e.ShipmentPartyIdFrom = c.ShipmentPartyIdFrom;
            e.ShipmentAdditionalShippingCharge = c.ShipmentAdditionalShippingCharge;
            e.ShipmentAddtlShippingChargeDesc = c.ShipmentAddtlShippingChargeDesc;
            e.ShipmentCreatedBy = c.ShipmentCreatedBy;
            e.ShipmentCreatedAt = c.ShipmentCreatedAt;
            e.ShipmentUpdatedBy = c.ShipmentUpdatedBy;
            e.ShipmentUpdatedAt = c.ShipmentUpdatedAt;
            e.ShipmentActive = c.ShipmentActive;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var shipmentVersion = c.ShipmentVersion;


            return e;
        }

        protected virtual IShipmentReceiptMvoStateMergePatched Map(IMergePatchShipmentReceiptMvo c)
        {
			var stateEventId = new ShipmentReceiptMvoEventId(c.ShipmentReceiptId, c.ShipmentVersion);
            IShipmentReceiptMvoStateMergePatched e = NewShipmentReceiptMvoStateMergePatched(stateEventId);

            e.ProductId = c.ProductId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.LocatorId = c.LocatorId;
            e.ShipmentItemSeqId = c.ShipmentItemSeqId;
            e.ShipmentPackageSeqId = c.ShipmentPackageSeqId;
            e.OrderId = c.OrderId;
            e.OrderItemSeqId = c.OrderItemSeqId;
            e.ReturnId = c.ReturnId;
            e.ReturnItemSeqId = c.ReturnItemSeqId;
            e.RejectionReasonId = c.RejectionReasonId;
            e.DamageStatusId = c.DamageStatusId;
            e.DamageReasonId = c.DamageReasonId;
            e.ReceivedBy = c.ReceivedBy;
            e.DatetimeReceived = c.DatetimeReceived;
            e.ItemDescription = c.ItemDescription;
            e.AcceptedQuantity = c.AcceptedQuantity;
            e.RejectedQuantity = c.RejectedQuantity;
            e.DamagedQuantity = c.DamagedQuantity;
            e.Version = c.Version;
            e.Active = c.Active;
            e.ShipmentShipmentTypeId = c.ShipmentShipmentTypeId;
            e.ShipmentStatusId = c.ShipmentStatusId;
            e.ShipmentPrimaryOrderId = c.ShipmentPrimaryOrderId;
            e.ShipmentPrimaryReturnId = c.ShipmentPrimaryReturnId;
            e.ShipmentPrimaryShipGroupSeqId = c.ShipmentPrimaryShipGroupSeqId;
            e.ShipmentPicklistBinId = c.ShipmentPicklistBinId;
            e.ShipmentEstimatedReadyDate = c.ShipmentEstimatedReadyDate;
            e.ShipmentEstimatedShipDate = c.ShipmentEstimatedShipDate;
            e.ShipmentEstimatedShipWorkEffId = c.ShipmentEstimatedShipWorkEffId;
            e.ShipmentEstimatedArrivalDate = c.ShipmentEstimatedArrivalDate;
            e.ShipmentEstimatedArrivalWorkEffId = c.ShipmentEstimatedArrivalWorkEffId;
            e.ShipmentLatestCancelDate = c.ShipmentLatestCancelDate;
            e.ShipmentEstimatedShipCost = c.ShipmentEstimatedShipCost;
            e.ShipmentCurrencyUomId = c.ShipmentCurrencyUomId;
            e.ShipmentHandlingInstructions = c.ShipmentHandlingInstructions;
            e.ShipmentOriginFacilityId = c.ShipmentOriginFacilityId;
            e.ShipmentDestinationFacilityId = c.ShipmentDestinationFacilityId;
            e.ShipmentOriginContactMechId = c.ShipmentOriginContactMechId;
            e.ShipmentOriginTelecomNumberId = c.ShipmentOriginTelecomNumberId;
            e.ShipmentDestinationContactMechId = c.ShipmentDestinationContactMechId;
            e.ShipmentDestinationTelecomNumberId = c.ShipmentDestinationTelecomNumberId;
            e.ShipmentPartyIdTo = c.ShipmentPartyIdTo;
            e.ShipmentPartyIdFrom = c.ShipmentPartyIdFrom;
            e.ShipmentAdditionalShippingCharge = c.ShipmentAdditionalShippingCharge;
            e.ShipmentAddtlShippingChargeDesc = c.ShipmentAddtlShippingChargeDesc;
            e.ShipmentCreatedBy = c.ShipmentCreatedBy;
            e.ShipmentCreatedAt = c.ShipmentCreatedAt;
            e.ShipmentUpdatedBy = c.ShipmentUpdatedBy;
            e.ShipmentUpdatedAt = c.ShipmentUpdatedAt;
            e.ShipmentActive = c.ShipmentActive;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyAttributeSetInstanceIdRemoved = c.IsPropertyAttributeSetInstanceIdRemoved;
            e.IsPropertyLocatorIdRemoved = c.IsPropertyLocatorIdRemoved;
            e.IsPropertyShipmentItemSeqIdRemoved = c.IsPropertyShipmentItemSeqIdRemoved;
            e.IsPropertyShipmentPackageSeqIdRemoved = c.IsPropertyShipmentPackageSeqIdRemoved;
            e.IsPropertyOrderIdRemoved = c.IsPropertyOrderIdRemoved;
            e.IsPropertyOrderItemSeqIdRemoved = c.IsPropertyOrderItemSeqIdRemoved;
            e.IsPropertyReturnIdRemoved = c.IsPropertyReturnIdRemoved;
            e.IsPropertyReturnItemSeqIdRemoved = c.IsPropertyReturnItemSeqIdRemoved;
            e.IsPropertyRejectionReasonIdRemoved = c.IsPropertyRejectionReasonIdRemoved;
            e.IsPropertyDamageStatusIdRemoved = c.IsPropertyDamageStatusIdRemoved;
            e.IsPropertyDamageReasonIdRemoved = c.IsPropertyDamageReasonIdRemoved;
            e.IsPropertyReceivedByRemoved = c.IsPropertyReceivedByRemoved;
            e.IsPropertyDatetimeReceivedRemoved = c.IsPropertyDatetimeReceivedRemoved;
            e.IsPropertyItemDescriptionRemoved = c.IsPropertyItemDescriptionRemoved;
            e.IsPropertyAcceptedQuantityRemoved = c.IsPropertyAcceptedQuantityRemoved;
            e.IsPropertyRejectedQuantityRemoved = c.IsPropertyRejectedQuantityRemoved;
            e.IsPropertyDamagedQuantityRemoved = c.IsPropertyDamagedQuantityRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyShipmentShipmentTypeIdRemoved = c.IsPropertyShipmentShipmentTypeIdRemoved;
            e.IsPropertyShipmentStatusIdRemoved = c.IsPropertyShipmentStatusIdRemoved;
            e.IsPropertyShipmentPrimaryOrderIdRemoved = c.IsPropertyShipmentPrimaryOrderIdRemoved;
            e.IsPropertyShipmentPrimaryReturnIdRemoved = c.IsPropertyShipmentPrimaryReturnIdRemoved;
            e.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved = c.IsPropertyShipmentPrimaryShipGroupSeqIdRemoved;
            e.IsPropertyShipmentPicklistBinIdRemoved = c.IsPropertyShipmentPicklistBinIdRemoved;
            e.IsPropertyShipmentEstimatedReadyDateRemoved = c.IsPropertyShipmentEstimatedReadyDateRemoved;
            e.IsPropertyShipmentEstimatedShipDateRemoved = c.IsPropertyShipmentEstimatedShipDateRemoved;
            e.IsPropertyShipmentEstimatedShipWorkEffIdRemoved = c.IsPropertyShipmentEstimatedShipWorkEffIdRemoved;
            e.IsPropertyShipmentEstimatedArrivalDateRemoved = c.IsPropertyShipmentEstimatedArrivalDateRemoved;
            e.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved = c.IsPropertyShipmentEstimatedArrivalWorkEffIdRemoved;
            e.IsPropertyShipmentLatestCancelDateRemoved = c.IsPropertyShipmentLatestCancelDateRemoved;
            e.IsPropertyShipmentEstimatedShipCostRemoved = c.IsPropertyShipmentEstimatedShipCostRemoved;
            e.IsPropertyShipmentCurrencyUomIdRemoved = c.IsPropertyShipmentCurrencyUomIdRemoved;
            e.IsPropertyShipmentHandlingInstructionsRemoved = c.IsPropertyShipmentHandlingInstructionsRemoved;
            e.IsPropertyShipmentOriginFacilityIdRemoved = c.IsPropertyShipmentOriginFacilityIdRemoved;
            e.IsPropertyShipmentDestinationFacilityIdRemoved = c.IsPropertyShipmentDestinationFacilityIdRemoved;
            e.IsPropertyShipmentOriginContactMechIdRemoved = c.IsPropertyShipmentOriginContactMechIdRemoved;
            e.IsPropertyShipmentOriginTelecomNumberIdRemoved = c.IsPropertyShipmentOriginTelecomNumberIdRemoved;
            e.IsPropertyShipmentDestinationContactMechIdRemoved = c.IsPropertyShipmentDestinationContactMechIdRemoved;
            e.IsPropertyShipmentDestinationTelecomNumberIdRemoved = c.IsPropertyShipmentDestinationTelecomNumberIdRemoved;
            e.IsPropertyShipmentPartyIdToRemoved = c.IsPropertyShipmentPartyIdToRemoved;
            e.IsPropertyShipmentPartyIdFromRemoved = c.IsPropertyShipmentPartyIdFromRemoved;
            e.IsPropertyShipmentAdditionalShippingChargeRemoved = c.IsPropertyShipmentAdditionalShippingChargeRemoved;
            e.IsPropertyShipmentAddtlShippingChargeDescRemoved = c.IsPropertyShipmentAddtlShippingChargeDescRemoved;
            e.IsPropertyShipmentCreatedByRemoved = c.IsPropertyShipmentCreatedByRemoved;
            e.IsPropertyShipmentCreatedAtRemoved = c.IsPropertyShipmentCreatedAtRemoved;
            e.IsPropertyShipmentUpdatedByRemoved = c.IsPropertyShipmentUpdatedByRemoved;
            e.IsPropertyShipmentUpdatedAtRemoved = c.IsPropertyShipmentUpdatedAtRemoved;
            e.IsPropertyShipmentActiveRemoved = c.IsPropertyShipmentActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var shipmentVersion = c.ShipmentVersion;


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected ShipmentReceiptMvoStateCreated NewShipmentReceiptMvoStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new ShipmentReceiptMvoEventId(_state.ShipmentReceiptId, version);
            var e = NewShipmentReceiptMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected ShipmentReceiptMvoStateMergePatched NewShipmentReceiptMvoStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new ShipmentReceiptMvoEventId(_state.ShipmentReceiptId, version);
            var e = NewShipmentReceiptMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


////////////////////////

		private ShipmentReceiptMvoStateCreated NewShipmentReceiptMvoStateCreated(ShipmentReceiptMvoEventId stateEventId)
		{
			return new ShipmentReceiptMvoStateCreated(stateEventId);			
		}

        private ShipmentReceiptMvoStateMergePatched NewShipmentReceiptMvoStateMergePatched(ShipmentReceiptMvoEventId stateEventId)
		{
			return new ShipmentReceiptMvoStateMergePatched(stateEventId);
		}

    }

}

