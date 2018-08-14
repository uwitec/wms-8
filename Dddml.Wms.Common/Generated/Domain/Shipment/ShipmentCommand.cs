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

	public abstract class ShipmentCommandBase : IShipmentCommand
	{
		public virtual string ShipmentId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.ShipmentId;
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

		public virtual string ShipmentTypeId { get; set; }

		public virtual string StatusId { get; set; }

		public virtual string PrimaryOrderId { get; set; }

		public virtual string PrimaryReturnId { get; set; }

		public virtual long? PrimaryShipGroupSeqId { get; set; }

		public virtual string PicklistBinId { get; set; }

		public virtual string BolNumber { get; set; }

		public virtual string SealNumber { get; set; }

		public virtual string VehicleId { get; set; }

		public virtual string PoNumber { get; set; }

		public virtual string Carrier { get; set; }

		public virtual DateTime? DateShipped { get; set; }

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


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateShipment : ShipmentCommandBase, ICreateShipment
	{
		
		public CreateShipment ()
		{
		}


        private CreateShipmentImageCommands _shipmentImages = new CreateShipmentImageCommands();

        public ICreateShipmentImageCommands ShipmentImages
        {
            get
            {
                return this._shipmentImages;
            }
        }

        public CreateShipmentImage NewCreateShipmentImage()
        {
            var c = new CreateShipmentImage();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateShipmentImage ICreateShipment.NewCreateShipmentImage()
        {
            return this.NewCreateShipmentImage();
        }



        private CreateShipmentItemCommands _shipmentItems = new CreateShipmentItemCommands();

        public ICreateShipmentItemCommands ShipmentItems
        {
            get
            {
                return this._shipmentItems;
            }
        }

        public CreateShipmentItem NewCreateShipmentItem()
        {
            var c = new CreateShipmentItem();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateShipmentItem ICreateShipment.NewCreateShipmentItem()
        {
            return this.NewCreateShipmentItem();
        }



        private CreateShipmentReceiptCommands _shipmentReceipts = new CreateShipmentReceiptCommands();

        public ICreateShipmentReceiptCommands ShipmentReceipts
        {
            get
            {
                return this._shipmentReceipts;
            }
        }

        public CreateShipmentReceipt NewCreateShipmentReceipt()
        {
            var c = new CreateShipmentReceipt();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateShipmentReceipt ICreateShipment.NewCreateShipmentReceipt()
        {
            return this.NewCreateShipmentReceipt();
        }



        private CreateItemIssuanceCommands _itemIssuances = new CreateItemIssuanceCommands();

        public ICreateItemIssuanceCommands ItemIssuances
        {
            get
            {
                return this._itemIssuances;
            }
        }

        public CreateItemIssuance NewCreateItemIssuance()
        {
            var c = new CreateItemIssuance();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateItemIssuance ICreateShipment.NewCreateItemIssuance()
        {
            return this.NewCreateItemIssuance();
        }



        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchShipment :ShipmentCommandBase, IMergePatchShipment
	{

		public virtual bool IsPropertyShipmentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyStatusIdRemoved { get; set; }

		public virtual bool IsPropertyPrimaryOrderIdRemoved { get; set; }

		public virtual bool IsPropertyPrimaryReturnIdRemoved { get; set; }

		public virtual bool IsPropertyPrimaryShipGroupSeqIdRemoved { get; set; }

		public virtual bool IsPropertyPicklistBinIdRemoved { get; set; }

		public virtual bool IsPropertyBolNumberRemoved { get; set; }

		public virtual bool IsPropertySealNumberRemoved { get; set; }

		public virtual bool IsPropertyVehicleIdRemoved { get; set; }

		public virtual bool IsPropertyPoNumberRemoved { get; set; }

		public virtual bool IsPropertyCarrierRemoved { get; set; }

		public virtual bool IsPropertyDateShippedRemoved { get; set; }

		public virtual bool IsPropertyEstimatedReadyDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipWorkEffIdRemoved { get; set; }

		public virtual bool IsPropertyEstimatedArrivalDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedArrivalWorkEffIdRemoved { get; set; }

		public virtual bool IsPropertyLatestCancelDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipCostRemoved { get; set; }

		public virtual bool IsPropertyCurrencyUomIdRemoved { get; set; }

		public virtual bool IsPropertyHandlingInstructionsRemoved { get; set; }

		public virtual bool IsPropertyOriginFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyDestinationFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyOriginContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyOriginTelecomNumberIdRemoved { get; set; }

		public virtual bool IsPropertyDestinationContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyDestinationTelecomNumberIdRemoved { get; set; }

		public virtual bool IsPropertyPartyIdToRemoved { get; set; }

		public virtual bool IsPropertyPartyIdFromRemoved { get; set; }

		public virtual bool IsPropertyAdditionalShippingChargeRemoved { get; set; }

		public virtual bool IsPropertyAddtlShippingChargeDescRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchShipment ()
		{
		}

        private ShipmentImageCommands _shipmentImageCommands = new ShipmentImageCommands();

        public IShipmentImageCommands ShipmentImageCommands
        {
            get
            {
                return this._shipmentImageCommands;
            }
        }


        public CreateShipmentImage NewCreateShipmentImage()
        {
            var c = new CreateShipmentImage();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateShipmentImage IMergePatchShipment.NewCreateShipmentImage()
        {
            return this.NewCreateShipmentImage();
        }

        public MergePatchShipmentImage NewMergePatchShipmentImage()
        {
            var c = new MergePatchShipmentImage();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IMergePatchShipmentImage IMergePatchShipment.NewMergePatchShipmentImage()
        {
            return this.NewMergePatchShipmentImage();
        }


        public RemoveShipmentImage NewRemoveShipmentImage()
        {
            var c = new RemoveShipmentImage();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IRemoveShipmentImage IMergePatchShipment.NewRemoveShipmentImage()
        {
            return this.NewRemoveShipmentImage();
        }


        private ShipmentItemCommands _shipmentItemCommands = new ShipmentItemCommands();

        public IShipmentItemCommands ShipmentItemCommands
        {
            get
            {
                return this._shipmentItemCommands;
            }
        }


        public CreateShipmentItem NewCreateShipmentItem()
        {
            var c = new CreateShipmentItem();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateShipmentItem IMergePatchShipment.NewCreateShipmentItem()
        {
            return this.NewCreateShipmentItem();
        }

        public MergePatchShipmentItem NewMergePatchShipmentItem()
        {
            var c = new MergePatchShipmentItem();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IMergePatchShipmentItem IMergePatchShipment.NewMergePatchShipmentItem()
        {
            return this.NewMergePatchShipmentItem();
        }


        public RemoveShipmentItem NewRemoveShipmentItem()
        {
            var c = new RemoveShipmentItem();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IRemoveShipmentItem IMergePatchShipment.NewRemoveShipmentItem()
        {
            return this.NewRemoveShipmentItem();
        }


        private ShipmentReceiptCommands _shipmentReceiptCommands = new ShipmentReceiptCommands();

        public IShipmentReceiptCommands ShipmentReceiptCommands
        {
            get
            {
                return this._shipmentReceiptCommands;
            }
        }


        public CreateShipmentReceipt NewCreateShipmentReceipt()
        {
            var c = new CreateShipmentReceipt();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateShipmentReceipt IMergePatchShipment.NewCreateShipmentReceipt()
        {
            return this.NewCreateShipmentReceipt();
        }

        public MergePatchShipmentReceipt NewMergePatchShipmentReceipt()
        {
            var c = new MergePatchShipmentReceipt();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IMergePatchShipmentReceipt IMergePatchShipment.NewMergePatchShipmentReceipt()
        {
            return this.NewMergePatchShipmentReceipt();
        }


        public RemoveShipmentReceipt NewRemoveShipmentReceipt()
        {
            var c = new RemoveShipmentReceipt();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IRemoveShipmentReceipt IMergePatchShipment.NewRemoveShipmentReceipt()
        {
            return this.NewRemoveShipmentReceipt();
        }


        private ItemIssuanceCommands _itemIssuanceCommands = new ItemIssuanceCommands();

        public IItemIssuanceCommands ItemIssuanceCommands
        {
            get
            {
                return this._itemIssuanceCommands;
            }
        }


        public CreateItemIssuance NewCreateItemIssuance()
        {
            var c = new CreateItemIssuance();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        ICreateItemIssuance IMergePatchShipment.NewCreateItemIssuance()
        {
            return this.NewCreateItemIssuance();
        }

        public MergePatchItemIssuance NewMergePatchItemIssuance()
        {
            var c = new MergePatchItemIssuance();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IMergePatchItemIssuance IMergePatchShipment.NewMergePatchItemIssuance()
        {
            return this.NewMergePatchItemIssuance();
        }


        public RemoveItemIssuance NewRemoveItemIssuance()
        {
            var c = new RemoveItemIssuance();
            c.ShipmentId = this.ShipmentId;

            return c;
        }

        IRemoveItemIssuance IMergePatchShipment.NewRemoveItemIssuance()
        {
            return this.NewRemoveItemIssuance();
        }


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteShipment : ShipmentCommandBase, IDeleteShipment
	{
		public DeleteShipment ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}


    public class CreateShipmentImageCommands : ICreateShipmentImageCommands
    {
        private List<ICreateShipmentImage> _innerCommands = new List<ICreateShipmentImage>();

        public void Add(ICreateShipmentImage c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateShipmentImage c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateShipmentImage> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class ShipmentImageCommands : IShipmentImageCommands
    {
        private List<IShipmentImageCommand> _innerCommands = new List<IShipmentImageCommand>();

        public void Add(IShipmentImageCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IShipmentImageCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IShipmentImageCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }


    public class CreateShipmentItemCommands : ICreateShipmentItemCommands
    {
        private List<ICreateShipmentItem> _innerCommands = new List<ICreateShipmentItem>();

        public void Add(ICreateShipmentItem c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateShipmentItem c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateShipmentItem> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class ShipmentItemCommands : IShipmentItemCommands
    {
        private List<IShipmentItemCommand> _innerCommands = new List<IShipmentItemCommand>();

        public void Add(IShipmentItemCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IShipmentItemCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IShipmentItemCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }


    public class CreateShipmentReceiptCommands : ICreateShipmentReceiptCommands
    {
        private List<ICreateShipmentReceipt> _innerCommands = new List<ICreateShipmentReceipt>();

        public void Add(ICreateShipmentReceipt c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateShipmentReceipt c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateShipmentReceipt> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class ShipmentReceiptCommands : IShipmentReceiptCommands
    {
        private List<IShipmentReceiptCommand> _innerCommands = new List<IShipmentReceiptCommand>();

        public void Add(IShipmentReceiptCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IShipmentReceiptCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IShipmentReceiptCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }


    public class CreateItemIssuanceCommands : ICreateItemIssuanceCommands
    {
        private List<ICreateItemIssuance> _innerCommands = new List<ICreateItemIssuance>();

        public void Add(ICreateItemIssuance c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateItemIssuance c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateItemIssuance> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class ItemIssuanceCommands : IItemIssuanceCommands
    {
        private List<IItemIssuanceCommand> _innerCommands = new List<IItemIssuanceCommand>();

        public void Add(IItemIssuanceCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IItemIssuanceCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IItemIssuanceCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public static partial class ShipmentCommands
    {
        public class Import : IShipmentCommand
        {

            public string CommandType
            {
                get { return "Import"; }
            }

            public string ShipmentTypeId { get; set; }

            public string PrimaryOrderId { get; set; }

            public string PrimaryReturnId { get; set; }

            public string BolNumber { get; set; }

            public string VehicleId { get; set; }

            public string SealNumber { get; set; }

            public string PoNumber { get; set; }

            public string Carrier { get; set; }

            public DateTime? DateShipped { get; set; }

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

            public ISet<ImportingShipmentItem> ShipmentItems { get; set; }

            public string ShipmentId { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }


            string ICommand.CommandId
            {
                get
                {
                    return this.CommandId;
                }
                set
                {
                    this.CommandId = value;
                }
            }

            object ICommand.RequesterId
            {
                get { return this.RequesterId; }
                set { this.RequesterId = (string)value; }
            }

            string ICommandDto.CommandType
            {
                get { return this.CommandType; }
            }

            string IAggregateCommand<string, long>.AggregateId
            {
                get { return this.ShipmentId; }
            }

            string IShipmentCommand.ShipmentId
            {
                get { return this.ShipmentId; }
                set { this.ShipmentId = value; }
            }

            long IAggregateCommand<string, long>.AggregateVersion
            {
                get { return this.Version; }
            }

            long IShipmentCommand.Version
            {
                get
                {
                    return this.Version;
                }
                set
                {
                    this.Version = value;
                }
            }

        }

        public class Ship : IShipmentCommand
        {

            public string CommandType
            {
                get { return "Ship"; }
            }

            public string ShipmentId { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }


            string ICommand.CommandId
            {
                get
                {
                    return this.CommandId;
                }
                set
                {
                    this.CommandId = value;
                }
            }

            object ICommand.RequesterId
            {
                get { return this.RequesterId; }
                set { this.RequesterId = (string)value; }
            }

            string ICommandDto.CommandType
            {
                get { return this.CommandType; }
            }

            string IAggregateCommand<string, long>.AggregateId
            {
                get { return this.ShipmentId; }
            }

            string IShipmentCommand.ShipmentId
            {
                get { return this.ShipmentId; }
                set { this.ShipmentId = value; }
            }

            long IAggregateCommand<string, long>.AggregateVersion
            {
                get { return this.Version; }
            }

            long IShipmentCommand.Version
            {
                get
                {
                    return this.Version;
                }
                set
                {
                    this.Version = value;
                }
            }

        }

        public class ReceiveItem : IShipmentCommand
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


            string ICommand.CommandId
            {
                get
                {
                    return this.CommandId;
                }
                set
                {
                    this.CommandId = value;
                }
            }

            object ICommand.RequesterId
            {
                get { return this.RequesterId; }
                set { this.RequesterId = (string)value; }
            }

            string ICommandDto.CommandType
            {
                get { return this.CommandType; }
            }

            string IAggregateCommand<string, long>.AggregateId
            {
                get { return this.ShipmentId; }
            }

            string IShipmentCommand.ShipmentId
            {
                get { return this.ShipmentId; }
                set { this.ShipmentId = value; }
            }

            long IAggregateCommand<string, long>.AggregateVersion
            {
                get { return this.Version; }
            }

            long IShipmentCommand.Version
            {
                get
                {
                    return this.Version;
                }
                set
                {
                    this.Version = value;
                }
            }

        }

        public class AddItemAndReceipt : IShipmentCommand
        {

            public string CommandType
            {
                get { return "AddItemAndReceipt"; }
            }

            public string ReceiptSeqId { get; set; }

            public string ProductId { get; set; }

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


            string ICommand.CommandId
            {
                get
                {
                    return this.CommandId;
                }
                set
                {
                    this.CommandId = value;
                }
            }

            object ICommand.RequesterId
            {
                get { return this.RequesterId; }
                set { this.RequesterId = (string)value; }
            }

            string ICommandDto.CommandType
            {
                get { return this.CommandType; }
            }

            string IAggregateCommand<string, long>.AggregateId
            {
                get { return this.ShipmentId; }
            }

            string IShipmentCommand.ShipmentId
            {
                get { return this.ShipmentId; }
                set { this.ShipmentId = value; }
            }

            long IAggregateCommand<string, long>.AggregateVersion
            {
                get { return this.Version; }
            }

            long IShipmentCommand.Version
            {
                get
                {
                    return this.Version;
                }
                set
                {
                    this.Version = value;
                }
            }

        }

        public class ConfirmAllItemsReceived : IShipmentCommand
        {

            public string CommandType
            {
                get { return "ConfirmAllItemsReceived"; }
            }

            public string DestinationLocatorId { get; set; }

            public string ShipmentId { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }


            string ICommand.CommandId
            {
                get
                {
                    return this.CommandId;
                }
                set
                {
                    this.CommandId = value;
                }
            }

            object ICommand.RequesterId
            {
                get { return this.RequesterId; }
                set { this.RequesterId = (string)value; }
            }

            string ICommandDto.CommandType
            {
                get { return this.CommandType; }
            }

            string IAggregateCommand<string, long>.AggregateId
            {
                get { return this.ShipmentId; }
            }

            string IShipmentCommand.ShipmentId
            {
                get { return this.ShipmentId; }
                set { this.ShipmentId = value; }
            }

            long IAggregateCommand<string, long>.AggregateVersion
            {
                get { return this.Version; }
            }

            long IShipmentCommand.Version
            {
                get
                {
                    return this.Version;
                }
                set
                {
                    this.Version = value;
                }
            }

        }

    }

}
