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

	public static partial class ShipmentStateInterfaceExtension
	{

        public static IShipmentCommand ToCreateOrMergePatchShipment<TCreateShipment, TMergePatchShipment, TCreateShipmentImage, TMergePatchShipmentImage, TCreateShipmentItem, TMergePatchShipmentItem, TCreateShipmentReceipt, TMergePatchShipmentReceipt, TCreateShipmentReceiptImage, TMergePatchShipmentReceiptImage, TCreateItemIssuance, TMergePatchItemIssuance>(this IShipmentState state)
            where TCreateShipment : ICreateShipment, new()
            where TMergePatchShipment : IMergePatchShipment, new()
            where TCreateShipmentImage : ICreateShipmentImage, new()
            where TMergePatchShipmentImage : IMergePatchShipmentImage, new()
            where TCreateShipmentItem : ICreateShipmentItem, new()
            where TMergePatchShipmentItem : IMergePatchShipmentItem, new()
            where TCreateShipmentReceipt : ICreateShipmentReceipt, new()
            where TMergePatchShipmentReceipt : IMergePatchShipmentReceipt, new()
            where TCreateShipmentReceiptImage : ICreateShipmentReceiptImage, new()
            where TMergePatchShipmentReceiptImage : IMergePatchShipmentReceiptImage, new()
            where TCreateItemIssuance : ICreateItemIssuance, new()
            where TMergePatchItemIssuance : IMergePatchItemIssuance, new()
        {
            bool bUnsaved = ((IShipmentState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateShipment<TCreateShipment, TCreateShipmentImage, TCreateShipmentItem, TCreateShipmentReceipt, TCreateShipmentReceiptImage, TCreateItemIssuance>();
            }
            else 
            {
                return state.ToMergePatchShipment<TMergePatchShipment, TCreateShipmentImage, TMergePatchShipmentImage, TCreateShipmentItem, TMergePatchShipmentItem, TCreateShipmentReceipt, TMergePatchShipmentReceipt, TCreateShipmentReceiptImage, TMergePatchShipmentReceiptImage, TCreateItemIssuance, TMergePatchItemIssuance>();
            }
        }

        public static TDeleteShipment ToDeleteShipment<TDeleteShipment>(this IShipmentState state)
            where TDeleteShipment : IDeleteShipment, new()
        {
            var cmd = new TDeleteShipment();
            cmd.ShipmentId = state.ShipmentId;
            cmd.Version = ((IShipmentStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchShipment ToMergePatchShipment<TMergePatchShipment, TCreateShipmentImage, TMergePatchShipmentImage, TCreateShipmentItem, TMergePatchShipmentItem, TCreateShipmentReceipt, TMergePatchShipmentReceipt, TCreateShipmentReceiptImage, TMergePatchShipmentReceiptImage, TCreateItemIssuance, TMergePatchItemIssuance>(this IShipmentState state)
            where TMergePatchShipment : IMergePatchShipment, new()
            where TCreateShipmentImage : ICreateShipmentImage, new()
            where TMergePatchShipmentImage : IMergePatchShipmentImage, new()
            where TCreateShipmentItem : ICreateShipmentItem, new()
            where TMergePatchShipmentItem : IMergePatchShipmentItem, new()
            where TCreateShipmentReceipt : ICreateShipmentReceipt, new()
            where TMergePatchShipmentReceipt : IMergePatchShipmentReceipt, new()
            where TCreateShipmentReceiptImage : ICreateShipmentReceiptImage, new()
            where TMergePatchShipmentReceiptImage : IMergePatchShipmentReceiptImage, new()
            where TCreateItemIssuance : ICreateItemIssuance, new()
            where TMergePatchItemIssuance : IMergePatchItemIssuance, new()
        {
            var cmd = new TMergePatchShipment();

            cmd.Version = ((IShipmentStateProperties)state).Version;

            cmd.ShipmentId = state.ShipmentId;
            cmd.ShipmentTypeId = state.ShipmentTypeId;
            cmd.StatusId = state.StatusId;
            cmd.PrimaryOrderId = state.PrimaryOrderId;
            cmd.PrimaryReturnId = state.PrimaryReturnId;
            cmd.PrimaryShipGroupSeqId = state.PrimaryShipGroupSeqId;
            cmd.PicklistBinId = state.PicklistBinId;
            cmd.BolNumber = state.BolNumber;
            cmd.SealNumber = state.SealNumber;
            cmd.VehicleId = state.VehicleId;
            cmd.PoNumber = state.PoNumber;
            cmd.Carrier = state.Carrier;
            cmd.DateShipped = state.DateShipped;
            cmd.EstimatedReadyDate = state.EstimatedReadyDate;
            cmd.EstimatedShipDate = state.EstimatedShipDate;
            cmd.EstimatedShipWorkEffId = state.EstimatedShipWorkEffId;
            cmd.EstimatedArrivalDate = state.EstimatedArrivalDate;
            cmd.EstimatedArrivalWorkEffId = state.EstimatedArrivalWorkEffId;
            cmd.LatestCancelDate = state.LatestCancelDate;
            cmd.EstimatedShipCost = state.EstimatedShipCost;
            cmd.CurrencyUomId = state.CurrencyUomId;
            cmd.HandlingInstructions = state.HandlingInstructions;
            cmd.OriginFacilityId = state.OriginFacilityId;
            cmd.DestinationFacilityId = state.DestinationFacilityId;
            cmd.OriginContactMechId = state.OriginContactMechId;
            cmd.OriginTelecomNumberId = state.OriginTelecomNumberId;
            cmd.DestinationContactMechId = state.DestinationContactMechId;
            cmd.DestinationTelecomNumberId = state.DestinationTelecomNumberId;
            cmd.PartyIdTo = state.PartyIdTo;
            cmd.PartyIdFrom = state.PartyIdFrom;
            cmd.AdditionalShippingCharge = state.AdditionalShippingCharge;
            cmd.AddtlShippingChargeDesc = state.AddtlShippingChargeDesc;
            cmd.Active = ((IShipmentStateProperties)state).Active;
            
            if (state.ShipmentTypeId == null) { cmd.IsPropertyShipmentTypeIdRemoved = true; }
            if (state.StatusId == null) { cmd.IsPropertyStatusIdRemoved = true; }
            if (state.PrimaryOrderId == null) { cmd.IsPropertyPrimaryOrderIdRemoved = true; }
            if (state.PrimaryReturnId == null) { cmd.IsPropertyPrimaryReturnIdRemoved = true; }
            if (state.PrimaryShipGroupSeqId == null) { cmd.IsPropertyPrimaryShipGroupSeqIdRemoved = true; }
            if (state.PicklistBinId == null) { cmd.IsPropertyPicklistBinIdRemoved = true; }
            if (state.BolNumber == null) { cmd.IsPropertyBolNumberRemoved = true; }
            if (state.SealNumber == null) { cmd.IsPropertySealNumberRemoved = true; }
            if (state.VehicleId == null) { cmd.IsPropertyVehicleIdRemoved = true; }
            if (state.PoNumber == null) { cmd.IsPropertyPoNumberRemoved = true; }
            if (state.Carrier == null) { cmd.IsPropertyCarrierRemoved = true; }
            if (state.DateShipped == null) { cmd.IsPropertyDateShippedRemoved = true; }
            if (state.EstimatedReadyDate == null) { cmd.IsPropertyEstimatedReadyDateRemoved = true; }
            if (state.EstimatedShipDate == null) { cmd.IsPropertyEstimatedShipDateRemoved = true; }
            if (state.EstimatedShipWorkEffId == null) { cmd.IsPropertyEstimatedShipWorkEffIdRemoved = true; }
            if (state.EstimatedArrivalDate == null) { cmd.IsPropertyEstimatedArrivalDateRemoved = true; }
            if (state.EstimatedArrivalWorkEffId == null) { cmd.IsPropertyEstimatedArrivalWorkEffIdRemoved = true; }
            if (state.LatestCancelDate == null) { cmd.IsPropertyLatestCancelDateRemoved = true; }
            if (state.EstimatedShipCost == null) { cmd.IsPropertyEstimatedShipCostRemoved = true; }
            if (state.CurrencyUomId == null) { cmd.IsPropertyCurrencyUomIdRemoved = true; }
            if (state.HandlingInstructions == null) { cmd.IsPropertyHandlingInstructionsRemoved = true; }
            if (state.OriginFacilityId == null) { cmd.IsPropertyOriginFacilityIdRemoved = true; }
            if (state.DestinationFacilityId == null) { cmd.IsPropertyDestinationFacilityIdRemoved = true; }
            if (state.OriginContactMechId == null) { cmd.IsPropertyOriginContactMechIdRemoved = true; }
            if (state.OriginTelecomNumberId == null) { cmd.IsPropertyOriginTelecomNumberIdRemoved = true; }
            if (state.DestinationContactMechId == null) { cmd.IsPropertyDestinationContactMechIdRemoved = true; }
            if (state.DestinationTelecomNumberId == null) { cmd.IsPropertyDestinationTelecomNumberIdRemoved = true; }
            if (state.PartyIdTo == null) { cmd.IsPropertyPartyIdToRemoved = true; }
            if (state.PartyIdFrom == null) { cmd.IsPropertyPartyIdFromRemoved = true; }
            if (state.AdditionalShippingCharge == null) { cmd.IsPropertyAdditionalShippingChargeRemoved = true; }
            if (state.AddtlShippingChargeDesc == null) { cmd.IsPropertyAddtlShippingChargeDescRemoved = true; }
            foreach (var d in state.ShipmentImages)
            {
                var c = d.ToCreateOrMergePatchShipmentImage<TCreateShipmentImage, TMergePatchShipmentImage>();
                cmd.ShipmentImageCommands.Add(c);
            }
            foreach (var d in state.ShipmentItems)
            {
                var c = d.ToCreateOrMergePatchShipmentItem<TCreateShipmentItem, TMergePatchShipmentItem>();
                cmd.ShipmentItemCommands.Add(c);
            }
            foreach (var d in state.ShipmentReceipts)
            {
                var c = d.ToCreateOrMergePatchShipmentReceipt<TCreateShipmentReceipt, TMergePatchShipmentReceipt, TCreateShipmentReceiptImage, TMergePatchShipmentReceiptImage>();
                cmd.ShipmentReceiptCommands.Add(c);
            }
            foreach (var d in state.ItemIssuances)
            {
                var c = d.ToCreateOrMergePatchItemIssuance<TCreateItemIssuance, TMergePatchItemIssuance>();
                cmd.ItemIssuanceCommands.Add(c);
            }
            return cmd;
        }

        public static TCreateShipment ToCreateShipment<TCreateShipment, TCreateShipmentImage, TCreateShipmentItem, TCreateShipmentReceipt, TCreateShipmentReceiptImage, TCreateItemIssuance>(this IShipmentState state)
            where TCreateShipment : ICreateShipment, new()
            where TCreateShipmentImage : ICreateShipmentImage, new()
            where TCreateShipmentItem : ICreateShipmentItem, new()
            where TCreateShipmentReceipt : ICreateShipmentReceipt, new()
            where TCreateShipmentReceiptImage : ICreateShipmentReceiptImage, new()
            where TCreateItemIssuance : ICreateItemIssuance, new()
        {
            var cmd = new TCreateShipment();

            cmd.Version = ((IShipmentStateProperties)state).Version;

            cmd.ShipmentId = state.ShipmentId;
            cmd.ShipmentTypeId = state.ShipmentTypeId;
            cmd.StatusId = state.StatusId;
            cmd.PrimaryOrderId = state.PrimaryOrderId;
            cmd.PrimaryReturnId = state.PrimaryReturnId;
            cmd.PrimaryShipGroupSeqId = state.PrimaryShipGroupSeqId;
            cmd.PicklistBinId = state.PicklistBinId;
            cmd.BolNumber = state.BolNumber;
            cmd.SealNumber = state.SealNumber;
            cmd.VehicleId = state.VehicleId;
            cmd.PoNumber = state.PoNumber;
            cmd.Carrier = state.Carrier;
            cmd.DateShipped = state.DateShipped;
            cmd.EstimatedReadyDate = state.EstimatedReadyDate;
            cmd.EstimatedShipDate = state.EstimatedShipDate;
            cmd.EstimatedShipWorkEffId = state.EstimatedShipWorkEffId;
            cmd.EstimatedArrivalDate = state.EstimatedArrivalDate;
            cmd.EstimatedArrivalWorkEffId = state.EstimatedArrivalWorkEffId;
            cmd.LatestCancelDate = state.LatestCancelDate;
            cmd.EstimatedShipCost = state.EstimatedShipCost;
            cmd.CurrencyUomId = state.CurrencyUomId;
            cmd.HandlingInstructions = state.HandlingInstructions;
            cmd.OriginFacilityId = state.OriginFacilityId;
            cmd.DestinationFacilityId = state.DestinationFacilityId;
            cmd.OriginContactMechId = state.OriginContactMechId;
            cmd.OriginTelecomNumberId = state.OriginTelecomNumberId;
            cmd.DestinationContactMechId = state.DestinationContactMechId;
            cmd.DestinationTelecomNumberId = state.DestinationTelecomNumberId;
            cmd.PartyIdTo = state.PartyIdTo;
            cmd.PartyIdFrom = state.PartyIdFrom;
            cmd.AdditionalShippingCharge = state.AdditionalShippingCharge;
            cmd.AddtlShippingChargeDesc = state.AddtlShippingChargeDesc;
            cmd.Active = ((IShipmentStateProperties)state).Active;
            foreach (var d in state.ShipmentImages)
            {
                var c = d.ToCreateShipmentImage<TCreateShipmentImage>();
                cmd.ShipmentImages.Add(c);
            }
            foreach (var d in state.ShipmentItems)
            {
                var c = d.ToCreateShipmentItem<TCreateShipmentItem>();
                cmd.ShipmentItems.Add(c);
            }
            foreach (var d in state.ShipmentReceipts)
            {
                var c = d.ToCreateShipmentReceipt<TCreateShipmentReceipt, TCreateShipmentReceiptImage>();
                cmd.ShipmentReceipts.Add(c);
            }
            foreach (var d in state.ItemIssuances)
            {
                var c = d.ToCreateItemIssuance<TCreateItemIssuance>();
                cmd.ItemIssuances.Add(c);
            }
            return cmd;
        }
		

	}

}

