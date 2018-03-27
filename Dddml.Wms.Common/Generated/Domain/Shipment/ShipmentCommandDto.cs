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

	public abstract class ShipmentCommandDtoBase : ICommandDto, ICreateShipment, IMergePatchShipment, IDeleteShipment
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteShipment)this).ShipmentId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual string ShipmentId { get; set; }

		public virtual string ShipmentTypeId { get; set; }

		public virtual string StatusId { get; set; }

		public virtual string PrimaryOrderId { get; set; }

		public virtual string PrimaryReturnId { get; set; }

		public virtual long? PrimaryShipGroupSeqId { get; set; }

		public virtual string PicklistBinId { get; set; }

		public virtual DateTime? EstimatedReadyDate { get; set; }

		public virtual DateTime? EstimatedShipDate { get; set; }

		public virtual string EstimatedShipWorkEffId { get; set; }

		public virtual DateTime? EstimatedArrivalDate { get; set; }

		public virtual string EstimatedArrivalWorkEffId { get; set; }

		public virtual DateTime? LatestCancelDate { get; set; }

		public virtual decimal? EstimatedShipCost { get; set; }

		public virtual string CurrencyUomId { get; set; }

		public virtual string HandlingInstructions { get; set; }

		public virtual string OriginFacilityId { get; set; }

		public virtual string DestinationFacilityId { get; set; }

		public virtual string OriginContactMechId { get; set; }

		public virtual string OriginTelecomNumberId { get; set; }

		public virtual string DestinationContactMechId { get; set; }

		public virtual string DestinationTelecomNumberId { get; set; }

		public virtual string PartyIdTo { get; set; }

		public virtual string PartyIdFrom { get; set; }

		public virtual decimal? AdditionalShippingCharge { get; set; }

		public virtual string AddtlShippingChargeDesc { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? IsPropertyShipmentTypeIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyShipmentTypeIdRemoved
        {
            get
            {
                var b = this.IsPropertyShipmentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShipmentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyStatusIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertyStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryOrderIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyPrimaryOrderIdRemoved
        {
            get
            {
                var b = this.IsPropertyPrimaryOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPrimaryOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryReturnIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyPrimaryReturnIdRemoved
        {
            get
            {
                var b = this.IsPropertyPrimaryReturnIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPrimaryReturnIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryShipGroupSeqIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyPrimaryShipGroupSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyPrimaryShipGroupSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPrimaryShipGroupSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyPicklistBinIdRemoved
        {
            get
            {
                var b = this.IsPropertyPicklistBinIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPicklistBinIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedReadyDateRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyEstimatedReadyDateRemoved
        {
            get
            {
                var b = this.IsPropertyEstimatedReadyDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEstimatedReadyDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedShipDateRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyEstimatedShipDateRemoved
        {
            get
            {
                var b = this.IsPropertyEstimatedShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEstimatedShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedShipWorkEffIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyEstimatedShipWorkEffIdRemoved
        {
            get
            {
                var b = this.IsPropertyEstimatedShipWorkEffIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEstimatedShipWorkEffIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedArrivalDateRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyEstimatedArrivalDateRemoved
        {
            get
            {
                var b = this.IsPropertyEstimatedArrivalDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEstimatedArrivalDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedArrivalWorkEffIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyEstimatedArrivalWorkEffIdRemoved
        {
            get
            {
                var b = this.IsPropertyEstimatedArrivalWorkEffIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEstimatedArrivalWorkEffIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLatestCancelDateRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyLatestCancelDateRemoved
        {
            get
            {
                var b = this.IsPropertyLatestCancelDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLatestCancelDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedShipCostRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyEstimatedShipCostRemoved
        {
            get
            {
                var b = this.IsPropertyEstimatedShipCostRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEstimatedShipCostRemoved = value;
            }
        }

		public virtual bool? IsPropertyCurrencyUomIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyCurrencyUomIdRemoved
        {
            get
            {
                var b = this.IsPropertyCurrencyUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCurrencyUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyHandlingInstructionsRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyHandlingInstructionsRemoved
        {
            get
            {
                var b = this.IsPropertyHandlingInstructionsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyHandlingInstructionsRemoved = value;
            }
        }

		public virtual bool? IsPropertyOriginFacilityIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyOriginFacilityIdRemoved
        {
            get
            {
                var b = this.IsPropertyOriginFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOriginFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDestinationFacilityIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyDestinationFacilityIdRemoved
        {
            get
            {
                var b = this.IsPropertyDestinationFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDestinationFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOriginContactMechIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyOriginContactMechIdRemoved
        {
            get
            {
                var b = this.IsPropertyOriginContactMechIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOriginContactMechIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOriginTelecomNumberIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyOriginTelecomNumberIdRemoved
        {
            get
            {
                var b = this.IsPropertyOriginTelecomNumberIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOriginTelecomNumberIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDestinationContactMechIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyDestinationContactMechIdRemoved
        {
            get
            {
                var b = this.IsPropertyDestinationContactMechIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDestinationContactMechIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDestinationTelecomNumberIdRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyDestinationTelecomNumberIdRemoved
        {
            get
            {
                var b = this.IsPropertyDestinationTelecomNumberIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDestinationTelecomNumberIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPartyIdToRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyPartyIdToRemoved
        {
            get
            {
                var b = this.IsPropertyPartyIdToRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPartyIdToRemoved = value;
            }
        }

		public virtual bool? IsPropertyPartyIdFromRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyPartyIdFromRemoved
        {
            get
            {
                var b = this.IsPropertyPartyIdFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPartyIdFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyAdditionalShippingChargeRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyAdditionalShippingChargeRemoved
        {
            get
            {
                var b = this.IsPropertyAdditionalShippingChargeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAdditionalShippingChargeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAddtlShippingChargeDescRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyAddtlShippingChargeDescRemoved
        {
            get
            {
                var b = this.IsPropertyAddtlShippingChargeDescRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAddtlShippingChargeDescRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchShipment.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

        ICreateShipmentItemCommands ICreateShipment.ShipmentItems
        {
            get
            {
                return this._shipmentItems;
            }
        }

        IShipmentItemCommands IMergePatchShipment.ShipmentItemCommands
        {
            get
            {
                return this._shipmentItems;
            }
        }

        public virtual CreateShipmentItemDto NewCreateShipmentItem()
        {
            var c = new CreateShipmentItemDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateShipmentItem ICreateShipment.NewCreateShipmentItem()
        {
            return this.NewCreateShipmentItem();
        }

        ICreateShipmentItem IMergePatchShipment.NewCreateShipmentItem()
        {
            return this.NewCreateShipmentItem();
        }

        public virtual MergePatchShipmentItemDto NewMergePatchShipmentItem()
        {
            var c = new MergePatchShipmentItemDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IMergePatchShipmentItem IMergePatchShipment.NewMergePatchShipmentItem()
        {
            return this.NewMergePatchShipmentItem();
        }

        public virtual RemoveShipmentItemDto NewRemoveShipmentItem()
        {
            var c = new RemoveShipmentItemDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IRemoveShipmentItem IMergePatchShipment.NewRemoveShipmentItem()
        {
            return this.NewRemoveShipmentItem();
        }

        private CreateOrMergePatchOrRemoveShipmentItemDtos _shipmentItems = new CreateOrMergePatchOrRemoveShipmentItemDtos();

        public virtual CreateOrMergePatchOrRemoveShipmentItemDto[] ShipmentItems
        {
            get
            {
                return _shipmentItems.ToArray();
            }
            set
            {
                _shipmentItems.Clear();
                _shipmentItems.AddRange(value);
            }
        }

        ICreateShipmentReceiptCommands ICreateShipment.ShipmentReceipts
        {
            get
            {
                return this._shipmentReceipts;
            }
        }

        IShipmentReceiptCommands IMergePatchShipment.ShipmentReceiptCommands
        {
            get
            {
                return this._shipmentReceipts;
            }
        }

        public virtual CreateShipmentReceiptDto NewCreateShipmentReceipt()
        {
            var c = new CreateShipmentReceiptDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateShipmentReceipt ICreateShipment.NewCreateShipmentReceipt()
        {
            return this.NewCreateShipmentReceipt();
        }

        ICreateShipmentReceipt IMergePatchShipment.NewCreateShipmentReceipt()
        {
            return this.NewCreateShipmentReceipt();
        }

        public virtual MergePatchShipmentReceiptDto NewMergePatchShipmentReceipt()
        {
            var c = new MergePatchShipmentReceiptDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IMergePatchShipmentReceipt IMergePatchShipment.NewMergePatchShipmentReceipt()
        {
            return this.NewMergePatchShipmentReceipt();
        }

        public virtual RemoveShipmentReceiptDto NewRemoveShipmentReceipt()
        {
            var c = new RemoveShipmentReceiptDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IRemoveShipmentReceipt IMergePatchShipment.NewRemoveShipmentReceipt()
        {
            return this.NewRemoveShipmentReceipt();
        }

        private CreateOrMergePatchOrRemoveShipmentReceiptDtos _shipmentReceipts = new CreateOrMergePatchOrRemoveShipmentReceiptDtos();

        public virtual CreateOrMergePatchOrRemoveShipmentReceiptDto[] ShipmentReceipts
        {
            get
            {
                return _shipmentReceipts.ToArray();
            }
            set
            {
                _shipmentReceipts.Clear();
                _shipmentReceipts.AddRange(value);
            }
        }

        ICreateItemIssuanceCommands ICreateShipment.ItemIssuances
        {
            get
            {
                return this._itemIssuances;
            }
        }

        IItemIssuanceCommands IMergePatchShipment.ItemIssuanceCommands
        {
            get
            {
                return this._itemIssuances;
            }
        }

        public virtual CreateItemIssuanceDto NewCreateItemIssuance()
        {
            var c = new CreateItemIssuanceDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateItemIssuance ICreateShipment.NewCreateItemIssuance()
        {
            return this.NewCreateItemIssuance();
        }

        ICreateItemIssuance IMergePatchShipment.NewCreateItemIssuance()
        {
            return this.NewCreateItemIssuance();
        }

        public virtual MergePatchItemIssuanceDto NewMergePatchItemIssuance()
        {
            var c = new MergePatchItemIssuanceDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IMergePatchItemIssuance IMergePatchShipment.NewMergePatchItemIssuance()
        {
            return this.NewMergePatchItemIssuance();
        }

        public virtual RemoveItemIssuanceDto NewRemoveItemIssuance()
        {
            var c = new RemoveItemIssuanceDto();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IRemoveItemIssuance IMergePatchShipment.NewRemoveItemIssuance()
        {
            return this.NewRemoveItemIssuance();
        }

        private CreateOrMergePatchOrRemoveItemIssuanceDtos _itemIssuances = new CreateOrMergePatchOrRemoveItemIssuanceDtos();

        public virtual CreateOrMergePatchOrRemoveItemIssuanceDto[] ItemIssuances
        {
            get
            {
                return _itemIssuances.ToArray();
            }
            set
            {
                _itemIssuances.Clear();
                _itemIssuances.AddRange(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteShipmentDto : ShipmentCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateShipmentDto : CreateOrMergePatchOrDeleteShipmentDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchShipmentDto : CreateOrMergePatchOrDeleteShipmentDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteShipmentDto : CreateOrMergePatchOrDeleteShipmentDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class ShipmentCommandDtos
    {

        public class ImportRequestContent : ICommandDto
        {

            public string CommandType
            {
                get { return "Import"; }
            }

            public string ShipmentTypeId { get; set; }

            public string PrimaryOrderId { get; set; }

            public string PrimaryReturnId { get; set; }

            public DateTime? EstimatedReadyDate { get; set; }

            public DateTime? EstimatedShipDate { get; set; }

            public DateTime? EstimatedArrivalDate { get; set; }

            public DateTime? LatestCancelDate { get; set; }

            public decimal? EstimatedShipCost { get; set; }

            public string CurrencyUomId { get; set; }

            public string HandlingInstructions { get; set; }

            public string OriginFacilityId { get; set; }

            public string DestinationFacilityId { get; set; }

            public string PartyIdTo { get; set; }

            public string PartyIdFrom { get; set; }

            public decimal? AdditionalShippingCharge { get; set; }

            public string AddtlShippingChargeDesc { get; set; }

            public ImportingShipmentItem[] ShipmentItems { get; set; }

            public string ShipmentId { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }

            public ShipmentCommands.Import ToImport()
            {
                var cmd = new ShipmentCommands.Import();
                cmd.ShipmentTypeId = this.ShipmentTypeId;
                cmd.PrimaryOrderId = this.PrimaryOrderId;
                cmd.PrimaryReturnId = this.PrimaryReturnId;
                cmd.EstimatedReadyDate = this.EstimatedReadyDate;
                cmd.EstimatedShipDate = this.EstimatedShipDate;
                cmd.EstimatedArrivalDate = this.EstimatedArrivalDate;
                cmd.LatestCancelDate = this.LatestCancelDate;
                cmd.EstimatedShipCost = this.EstimatedShipCost;
                cmd.CurrencyUomId = this.CurrencyUomId;
                cmd.HandlingInstructions = this.HandlingInstructions;
                cmd.OriginFacilityId = this.OriginFacilityId;
                cmd.DestinationFacilityId = this.DestinationFacilityId;
                cmd.PartyIdTo = this.PartyIdTo;
                cmd.PartyIdFrom = this.PartyIdFrom;
                cmd.AdditionalShippingCharge = this.AdditionalShippingCharge;
                cmd.AddtlShippingChargeDesc = this.AddtlShippingChargeDesc;
                cmd.ShipmentItems = this.ShipmentItems == null ? null : new HashSet<ImportingShipmentItem>(this.ShipmentItems);
                cmd.ShipmentId = this.ShipmentId;
                cmd.Version = this.Version;
                cmd.CommandId = this.CommandId;
                cmd.RequesterId = this.RequesterId;
                return cmd;
            }

        }

        public class ShipRequestContent : ICommandDto
        {

            public string CommandType
            {
                get { return "Ship"; }
            }

            public string ShipmentId { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }

            public ShipmentCommands.Ship ToShip()
            {
                var cmd = new ShipmentCommands.Ship();
                cmd.ShipmentId = this.ShipmentId;
                cmd.Version = this.Version;
                cmd.CommandId = this.CommandId;
                cmd.RequesterId = this.RequesterId;
                return cmd;
            }

        }

        public class ReceiveItemRequestContent : ICommandDto
        {

            public string CommandType
            {
                get { return "ReceiveItem"; }
            }

            public string ShipmentItemSeqId { get; set; }

            public IDictionary<string, object> AttributeSetInstance { get; set; }

            public string RejectionReasonId { get; set; }

            public string DamageStatusId { get; set; }

            public string DamageReasonId { get; set; }

            public decimal? AcceptedQuantity { get; set; }

            public decimal? RejectedQuantity { get; set; }

            public decimal? DamagedQuantity { get; set; }

            public string ItemDescription { get; set; }

            public string ShipmentId { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }

            public ShipmentCommands.ReceiveItem ToReceiveItem()
            {
                var cmd = new ShipmentCommands.ReceiveItem();
                cmd.ShipmentItemSeqId = this.ShipmentItemSeqId;
                cmd.AttributeSetInstance = this.AttributeSetInstance;
                cmd.RejectionReasonId = this.RejectionReasonId;
                cmd.DamageStatusId = this.DamageStatusId;
                cmd.DamageReasonId = this.DamageReasonId;
                cmd.AcceptedQuantity = this.AcceptedQuantity;
                cmd.RejectedQuantity = this.RejectedQuantity;
                cmd.DamagedQuantity = this.DamagedQuantity;
                cmd.ItemDescription = this.ItemDescription;
                cmd.ShipmentId = this.ShipmentId;
                cmd.Version = this.Version;
                cmd.CommandId = this.CommandId;
                cmd.RequesterId = this.RequesterId;
                return cmd;
            }

        }

        public class ConfirmAllItemsReceivedRequestContent : ICommandDto
        {

            public string CommandType
            {
                get { return "ConfirmAllItemsReceived"; }
            }

            public string ShipmentId { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }

            public ShipmentCommands.ConfirmAllItemsReceived ToConfirmAllItemsReceived()
            {
                var cmd = new ShipmentCommands.ConfirmAllItemsReceived();
                cmd.ShipmentId = this.ShipmentId;
                cmd.Version = this.Version;
                cmd.CommandId = this.CommandId;
                cmd.RequesterId = this.RequesterId;
                return cmd;
            }

        }

    }

}

