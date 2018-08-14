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

	public abstract class ShipmentReceiptCommandDtoBase : ICommandDto, ICreateShipmentReceipt, IMergePatchShipmentReceipt, IRemoveShipmentReceipt
	{

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

		public virtual string ReceiptSeqId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string ShipmentItemSeqId { get; set; }

		public virtual string ShipmentPackageSeqId { get; set; }

		public virtual string OrderId { get; set; }

		public virtual string OrderItemSeqId { get; set; }

		public virtual string ReturnId { get; set; }

		public virtual string ReturnItemSeqId { get; set; }

		public virtual string RejectionReasonId { get; set; }

		public virtual string DamageStatusId { get; set; }

		public virtual string DamageReasonId { get; set; }

		public virtual string ReceivedBy { get; set; }

		public virtual DateTime? DatetimeReceived { get; set; }

		public virtual string ItemDescription { get; set; }

		public virtual decimal? AcceptedQuantity { get; set; }

		public virtual decimal? RejectedQuantity { get; set; }

		public virtual decimal? DamagedQuantity { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string ShipmentId { get; set; }

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyProductIdRemoved
        {
            get
            {
                var b = this.IsPropertyProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyAttributeSetInstanceIdRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeSetInstanceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeSetInstanceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLocatorIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyLocatorIdRemoved
        {
            get
            {
                var b = this.IsPropertyLocatorIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLocatorIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentItemSeqIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyShipmentItemSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyShipmentItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShipmentItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentPackageSeqIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyShipmentPackageSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyShipmentPackageSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShipmentPackageSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyOrderIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderItemSeqIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyOrderItemSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyReturnIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyReturnIdRemoved
        {
            get
            {
                var b = this.IsPropertyReturnIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReturnIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyReturnItemSeqIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyReturnItemSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyReturnItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReturnItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyRejectionReasonIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyRejectionReasonIdRemoved
        {
            get
            {
                var b = this.IsPropertyRejectionReasonIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyRejectionReasonIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDamageStatusIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyDamageStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertyDamageStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDamageStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDamageReasonIdRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyDamageReasonIdRemoved
        {
            get
            {
                var b = this.IsPropertyDamageReasonIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDamageReasonIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyReceivedByRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyReceivedByRemoved
        {
            get
            {
                var b = this.IsPropertyReceivedByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReceivedByRemoved = value;
            }
        }

		public virtual bool? IsPropertyDatetimeReceivedRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyDatetimeReceivedRemoved
        {
            get
            {
                var b = this.IsPropertyDatetimeReceivedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDatetimeReceivedRemoved = value;
            }
        }

		public virtual bool? IsPropertyItemDescriptionRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyItemDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyItemDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyItemDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyAcceptedQuantityRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyAcceptedQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyAcceptedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAcceptedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyRejectedQuantityRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyRejectedQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyRejectedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyRejectedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyDamagedQuantityRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyDamagedQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyDamagedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDamagedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchShipmentReceipt.IsPropertyActiveRemoved
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

        ICreateShipmentReceiptImageCommands ICreateShipmentReceipt.ShipmentReceiptImages
        {
            get
            {
                return this._shipmentReceiptImages;
            }
        }

        IShipmentReceiptImageCommands IMergePatchShipmentReceipt.ShipmentReceiptImageCommands
        {
            get
            {
                return this._shipmentReceiptImages;
            }
        }

        public virtual CreateShipmentReceiptImageDto NewCreateShipmentReceiptImage()
        {
            var c = new CreateShipmentReceiptImageDto();
            c.ShipmentId = this.ShipmentId;

            c.ShipmentReceiptReceiptSeqId = this.ReceiptSeqId;

            return c;
        }

        ICreateShipmentReceiptImage ICreateShipmentReceipt.NewCreateShipmentReceiptImage()
        {
            return this.NewCreateShipmentReceiptImage();
        }

        ICreateShipmentReceiptImage IMergePatchShipmentReceipt.NewCreateShipmentReceiptImage()
        {
            return this.NewCreateShipmentReceiptImage();
        }

        public virtual MergePatchShipmentReceiptImageDto NewMergePatchShipmentReceiptImage()
        {
            var c = new MergePatchShipmentReceiptImageDto();
            c.ShipmentId = this.ShipmentId;

            c.ShipmentReceiptReceiptSeqId = this.ReceiptSeqId;

            return c;
        }

        IMergePatchShipmentReceiptImage IMergePatchShipmentReceipt.NewMergePatchShipmentReceiptImage()
        {
            return this.NewMergePatchShipmentReceiptImage();
        }

        public virtual RemoveShipmentReceiptImageDto NewRemoveShipmentReceiptImage()
        {
            var c = new RemoveShipmentReceiptImageDto();
            c.ShipmentId = this.ShipmentId;

            c.ShipmentReceiptReceiptSeqId = this.ReceiptSeqId;

            return c;
        }

        IRemoveShipmentReceiptImage IMergePatchShipmentReceipt.NewRemoveShipmentReceiptImage()
        {
            return this.NewRemoveShipmentReceiptImage();
        }

        private CreateOrMergePatchOrRemoveShipmentReceiptImageDtos _shipmentReceiptImages = new CreateOrMergePatchOrRemoveShipmentReceiptImageDtos();

        public virtual CreateOrMergePatchOrRemoveShipmentReceiptImageDto[] ShipmentReceiptImages
        {
            get
            {
                return _shipmentReceiptImages.ToArray();
            }
            set
            {
                _shipmentReceiptImages.Clear();
                _shipmentReceiptImages.AddRange(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrRemoveShipmentReceiptDto : ShipmentReceiptCommandDtoBase
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



	public class CreateShipmentReceiptDto : CreateOrMergePatchOrRemoveShipmentReceiptDto
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


	public class MergePatchShipmentReceiptDto : CreateOrMergePatchOrRemoveShipmentReceiptDto
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

	public class RemoveShipmentReceiptDto : CreateOrMergePatchOrRemoveShipmentReceiptDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}


    public partial class CreateOrMergePatchOrRemoveShipmentReceiptDtos : IShipmentReceiptCommands, ICreateShipmentReceiptCommands, IEnumerable<CreateOrMergePatchOrRemoveShipmentReceiptDto>
    {
        private List<CreateOrMergePatchOrRemoveShipmentReceiptDto> _innerCommands = new List<CreateOrMergePatchOrRemoveShipmentReceiptDto>();

        public virtual CreateOrMergePatchOrRemoveShipmentReceiptDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveShipmentReceiptDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IShipmentReceiptCommands.Add(IShipmentReceiptCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveShipmentReceiptDto)c);
        }

        void IShipmentReceiptCommands.Remove(IShipmentReceiptCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveShipmentReceiptDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveShipmentReceiptDto> IEnumerable<CreateOrMergePatchOrRemoveShipmentReceiptDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IShipmentReceiptCommand> IEnumerable<IShipmentReceiptCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateShipmentReceiptCommands.Add(ICreateShipmentReceipt c)
        {
            _innerCommands.Add((CreateShipmentReceiptDto)c);
        }

        void ICreateShipmentReceiptCommands.Remove(ICreateShipmentReceipt c)
        {
            _innerCommands.Remove((CreateShipmentReceiptDto)c);
        }

        IEnumerator<ICreateShipmentReceipt> IEnumerable<ICreateShipmentReceipt>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

}

