﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{
    public partial class ShipmentAggregate : AggregateBase, IShipmentAggregate
    {

        readonly IShipmentState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IShipmentState State
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

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public ShipmentAggregate(IShipmentState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IShipmentStateProperties)_state).Version == ShipmentState.VersionZero)
            {
                if (IsCommandCreate((IShipmentCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (IsCommandCreate((IShipmentCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IShipmentCommand c)
        {
            return c.Version == ShipmentState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateShipment c)
        {
            IShipmentStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchShipment c)
        {
            IShipmentStateMergePatched e = Map(c);
            Apply(e);
        }


        protected virtual IShipmentStateCreated Map(ICreateShipment c)
        {
			var stateEventId = new ShipmentStateEventId(c.ShipmentId, c.Version);
            IShipmentStateCreated e = NewShipmentStateCreated(stateEventId);
		
            e.ShipmentTypeId = c.ShipmentTypeId;
            e.StatusId = c.StatusId;
            e.PrimaryOrderId = c.PrimaryOrderId;
            e.PrimaryReturnId = c.PrimaryReturnId;
            e.PicklistBinId = c.PicklistBinId;
            e.EstimatedReadyDate = c.EstimatedReadyDate;
            e.EstimatedShipDate = c.EstimatedShipDate;
            e.EstimatedShipWorkEffId = c.EstimatedShipWorkEffId;
            e.EstimatedArrivalDate = c.EstimatedArrivalDate;
            e.EstimatedArrivalWorkEffId = c.EstimatedArrivalWorkEffId;
            e.LatestCancelDate = c.LatestCancelDate;
            e.EstimatedShipCost = c.EstimatedShipCost;
            e.CurrencyUomId = c.CurrencyUomId;
            e.HandlingInstructions = c.HandlingInstructions;
            e.OriginFacilityId = c.OriginFacilityId;
            e.DestinationFacilityId = c.DestinationFacilityId;
            e.OriginContactMechId = c.OriginContactMechId;
            e.OriginTelecomNumberId = c.OriginTelecomNumberId;
            e.DestinationContactMechId = c.DestinationContactMechId;
            e.DestinationTelecomNumberId = c.DestinationTelecomNumberId;
            e.PartyIdTo = c.PartyIdTo;
            e.PartyIdFrom = c.PartyIdFrom;
            e.AdditionalShippingCharge = c.AdditionalShippingCharge;
            e.AddtlShippingChargeDesc = c.AddtlShippingChargeDesc;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;

            foreach (ICreateShipmentItem innerCommand in c.ShipmentItems)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IShipmentItemStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddShipmentItemEvent(innerEvent);
            }

            foreach (ICreateShipmentReceipt innerCommand in c.ShipmentReceipts)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IShipmentReceiptStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddShipmentReceiptEvent(innerEvent);
            }


            return e;
        }

        protected virtual IShipmentStateMergePatched Map(IMergePatchShipment c)
        {
			var stateEventId = new ShipmentStateEventId(c.ShipmentId, c.Version);
            IShipmentStateMergePatched e = NewShipmentStateMergePatched(stateEventId);

            e.ShipmentTypeId = c.ShipmentTypeId;
            e.StatusId = c.StatusId;
            e.PrimaryOrderId = c.PrimaryOrderId;
            e.PrimaryReturnId = c.PrimaryReturnId;
            e.PicklistBinId = c.PicklistBinId;
            e.EstimatedReadyDate = c.EstimatedReadyDate;
            e.EstimatedShipDate = c.EstimatedShipDate;
            e.EstimatedShipWorkEffId = c.EstimatedShipWorkEffId;
            e.EstimatedArrivalDate = c.EstimatedArrivalDate;
            e.EstimatedArrivalWorkEffId = c.EstimatedArrivalWorkEffId;
            e.LatestCancelDate = c.LatestCancelDate;
            e.EstimatedShipCost = c.EstimatedShipCost;
            e.CurrencyUomId = c.CurrencyUomId;
            e.HandlingInstructions = c.HandlingInstructions;
            e.OriginFacilityId = c.OriginFacilityId;
            e.DestinationFacilityId = c.DestinationFacilityId;
            e.OriginContactMechId = c.OriginContactMechId;
            e.OriginTelecomNumberId = c.OriginTelecomNumberId;
            e.DestinationContactMechId = c.DestinationContactMechId;
            e.DestinationTelecomNumberId = c.DestinationTelecomNumberId;
            e.PartyIdTo = c.PartyIdTo;
            e.PartyIdFrom = c.PartyIdFrom;
            e.AdditionalShippingCharge = c.AdditionalShippingCharge;
            e.AddtlShippingChargeDesc = c.AddtlShippingChargeDesc;
            e.Active = c.Active;
            e.IsPropertyShipmentTypeIdRemoved = c.IsPropertyShipmentTypeIdRemoved;
            e.IsPropertyStatusIdRemoved = c.IsPropertyStatusIdRemoved;
            e.IsPropertyPrimaryOrderIdRemoved = c.IsPropertyPrimaryOrderIdRemoved;
            e.IsPropertyPrimaryReturnIdRemoved = c.IsPropertyPrimaryReturnIdRemoved;
            e.IsPropertyPicklistBinIdRemoved = c.IsPropertyPicklistBinIdRemoved;
            e.IsPropertyEstimatedReadyDateRemoved = c.IsPropertyEstimatedReadyDateRemoved;
            e.IsPropertyEstimatedShipDateRemoved = c.IsPropertyEstimatedShipDateRemoved;
            e.IsPropertyEstimatedShipWorkEffIdRemoved = c.IsPropertyEstimatedShipWorkEffIdRemoved;
            e.IsPropertyEstimatedArrivalDateRemoved = c.IsPropertyEstimatedArrivalDateRemoved;
            e.IsPropertyEstimatedArrivalWorkEffIdRemoved = c.IsPropertyEstimatedArrivalWorkEffIdRemoved;
            e.IsPropertyLatestCancelDateRemoved = c.IsPropertyLatestCancelDateRemoved;
            e.IsPropertyEstimatedShipCostRemoved = c.IsPropertyEstimatedShipCostRemoved;
            e.IsPropertyCurrencyUomIdRemoved = c.IsPropertyCurrencyUomIdRemoved;
            e.IsPropertyHandlingInstructionsRemoved = c.IsPropertyHandlingInstructionsRemoved;
            e.IsPropertyOriginFacilityIdRemoved = c.IsPropertyOriginFacilityIdRemoved;
            e.IsPropertyDestinationFacilityIdRemoved = c.IsPropertyDestinationFacilityIdRemoved;
            e.IsPropertyOriginContactMechIdRemoved = c.IsPropertyOriginContactMechIdRemoved;
            e.IsPropertyOriginTelecomNumberIdRemoved = c.IsPropertyOriginTelecomNumberIdRemoved;
            e.IsPropertyDestinationContactMechIdRemoved = c.IsPropertyDestinationContactMechIdRemoved;
            e.IsPropertyDestinationTelecomNumberIdRemoved = c.IsPropertyDestinationTelecomNumberIdRemoved;
            e.IsPropertyPartyIdToRemoved = c.IsPropertyPartyIdToRemoved;
            e.IsPropertyPartyIdFromRemoved = c.IsPropertyPartyIdFromRemoved;
            e.IsPropertyAdditionalShippingChargeRemoved = c.IsPropertyAdditionalShippingChargeRemoved;
            e.IsPropertyAddtlShippingChargeDescRemoved = c.IsPropertyAddtlShippingChargeDescRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;

            foreach (IShipmentItemCommand innerCommand in c.ShipmentItemCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IShipmentItemStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddShipmentItemEvent(innerEvent);
            }

            foreach (IShipmentReceiptCommand innerCommand in c.ShipmentReceiptCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IShipmentReceiptStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddShipmentReceiptEvent(innerEvent);
            }


            return e;
        }


        protected void ThrowOnInconsistentCommands(IShipmentCommand command, IShipmentItemCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteShipment;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveShipmentItem;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.ShipmentId == default(string))
            {
                innerProperties.ShipmentId = properties.ShipmentId;
            }
            else
            {
                var outerShipmentIdName = "ShipmentId";
                var outerShipmentIdValue = properties.ShipmentId;
                var innerShipmentIdName = "ShipmentId";
                var innerShipmentIdValue = innerProperties.ShipmentId;
                ThrowOnInconsistentIds(innerProperties, innerShipmentIdName, innerShipmentIdValue, outerShipmentIdName, outerShipmentIdValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected void ThrowOnInconsistentCommands(IShipmentCommand command, IShipmentReceiptCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteShipment;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveShipmentReceipt;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.ShipmentId == default(string))
            {
                innerProperties.ShipmentId = properties.ShipmentId;
            }
            else
            {
                var outerShipmentIdName = "ShipmentId";
                var outerShipmentIdValue = properties.ShipmentId;
                var innerShipmentIdName = "ShipmentId";
                var innerShipmentIdValue = innerProperties.ShipmentId;
                ThrowOnInconsistentIds(innerProperties, innerShipmentIdName, innerShipmentIdValue, outerShipmentIdName, outerShipmentIdValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IShipmentItemStateEvent Map(IShipmentItemCommand c, IShipmentCommand outerCommand, long version, IShipmentState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateShipmentItem) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchShipmentItem) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            throw new NotSupportedException();
        }


        protected virtual IShipmentItemStateCreated MapCreate(ICreateShipmentItem c, IShipmentCommand outerCommand, long version, IShipmentState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new ShipmentItemStateEventId(c.ShipmentId, c.ShipmentItemSeqId, version);
            IShipmentItemStateCreated e = NewShipmentItemStateCreated(stateEventId);
            var s = outerState.ShipmentItems.Get(c.ShipmentItemSeqId, true);

            e.ProductId = c.ProductId;
            e.Quantity = c.Quantity;
            e.ShipmentContentDescription = c.ShipmentContentDescription;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IShipmentItemStateMergePatched MapMergePatch(IMergePatchShipmentItem c, IShipmentCommand outerCommand, long version, IShipmentState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new ShipmentItemStateEventId(c.ShipmentId, c.ShipmentItemSeqId, version);
            IShipmentItemStateMergePatched e = NewShipmentItemStateMergePatched(stateEventId);
            var s = outerState.ShipmentItems.Get(c.ShipmentItemSeqId);

            e.ProductId = c.ProductId;
            e.Quantity = c.Quantity;
            e.ShipmentContentDescription = c.ShipmentContentDescription;
            e.Active = c.Active;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyQuantityRemoved = c.IsPropertyQuantityRemoved;
            e.IsPropertyShipmentContentDescriptionRemoved = c.IsPropertyShipmentContentDescriptionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(IMergePatch... ////////////////////////////



        protected virtual IShipmentReceiptStateEvent Map(IShipmentReceiptCommand c, IShipmentCommand outerCommand, long version, IShipmentState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateShipmentReceipt) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchShipmentReceipt) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            throw new NotSupportedException();
        }


        protected virtual IShipmentReceiptStateCreated MapCreate(ICreateShipmentReceipt c, IShipmentCommand outerCommand, long version, IShipmentState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new ShipmentReceiptStateEventId(c.ShipmentId, c.ReceiptSeqId, version);
            IShipmentReceiptStateCreated e = NewShipmentReceiptStateCreated(stateEventId);
            var s = outerState.ShipmentReceipts.Get(c.ReceiptSeqId, true);

            e.ProductId = c.ProductId;
            e.ShipmentItemSeqId = c.ShipmentItemSeqId;
            e.RejectionId = c.RejectionId;
            e.ItemDescription = c.ItemDescription;
            e.AcceptedQuantity = c.AcceptedQuantity;
            e.RejectedQuantity = c.RejectedQuantity;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IShipmentReceiptStateMergePatched MapMergePatch(IMergePatchShipmentReceipt c, IShipmentCommand outerCommand, long version, IShipmentState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new ShipmentReceiptStateEventId(c.ShipmentId, c.ReceiptSeqId, version);
            IShipmentReceiptStateMergePatched e = NewShipmentReceiptStateMergePatched(stateEventId);
            var s = outerState.ShipmentReceipts.Get(c.ReceiptSeqId);

            e.ProductId = c.ProductId;
            e.ShipmentItemSeqId = c.ShipmentItemSeqId;
            e.RejectionId = c.RejectionId;
            e.ItemDescription = c.ItemDescription;
            e.AcceptedQuantity = c.AcceptedQuantity;
            e.RejectedQuantity = c.RejectedQuantity;
            e.Active = c.Active;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyShipmentItemSeqIdRemoved = c.IsPropertyShipmentItemSeqIdRemoved;
            e.IsPropertyRejectionIdRemoved = c.IsPropertyRejectionIdRemoved;
            e.IsPropertyItemDescriptionRemoved = c.IsPropertyItemDescriptionRemoved;
            e.IsPropertyAcceptedQuantityRemoved = c.IsPropertyAcceptedQuantityRemoved;
            e.IsPropertyRejectedQuantityRemoved = c.IsPropertyRejectedQuantityRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(IMergePatch... ////////////////////////////


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

        protected ShipmentStateCreated NewShipmentStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new ShipmentStateEventId(_state.ShipmentId, ((IShipmentStateProperties)_state).Version);
            var e = NewShipmentStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected ShipmentStateMergePatched NewShipmentStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new ShipmentStateEventId(_state.ShipmentId, ((IShipmentStateProperties)_state).Version);
            var e = NewShipmentStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


////////////////////////

		private ShipmentStateCreated NewShipmentStateCreated(ShipmentStateEventId stateEventId)
		{
			return new ShipmentStateCreated(stateEventId);			
		}

        private ShipmentStateMergePatched NewShipmentStateMergePatched(ShipmentStateEventId stateEventId)
		{
			return new ShipmentStateMergePatched(stateEventId);
		}


		private ShipmentItemStateCreated NewShipmentItemStateCreated(ShipmentItemStateEventId stateEventId)
		{
			return new ShipmentItemStateCreated(stateEventId);
		}

        private ShipmentItemStateMergePatched NewShipmentItemStateMergePatched(ShipmentItemStateEventId stateEventId)
		{
			return new ShipmentItemStateMergePatched(stateEventId);
		}


		private ShipmentReceiptStateCreated NewShipmentReceiptStateCreated(ShipmentReceiptStateEventId stateEventId)
		{
			return new ShipmentReceiptStateCreated(stateEventId);
		}

        private ShipmentReceiptStateMergePatched NewShipmentReceiptStateMergePatched(ShipmentReceiptStateEventId stateEventId)
		{
			return new ShipmentReceiptStateMergePatched(stateEventId);
		}


    }

}

