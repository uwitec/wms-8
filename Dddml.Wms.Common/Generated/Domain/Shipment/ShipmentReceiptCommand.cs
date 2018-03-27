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

	public abstract class ShipmentReceiptCommandBase : IShipmentReceiptCommand
	{
		public virtual string ReceiptSeqId { get; set; }


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

		// Outer Id:

		public virtual string ShipmentId { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateShipmentReceipt : ShipmentReceiptCommandBase, ICreateShipmentReceipt
	{
		
		public CreateShipmentReceipt ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchShipmentReceipt :ShipmentReceiptCommandBase, IMergePatchShipmentReceipt
	{

		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentItemSeqIdRemoved { get; set; }

		public virtual bool IsPropertyShipmentPackageSeqIdRemoved { get; set; }

		public virtual bool IsPropertyOrderIdRemoved { get; set; }

		public virtual bool IsPropertyOrderItemSeqIdRemoved { get; set; }

		public virtual bool IsPropertyReturnIdRemoved { get; set; }

		public virtual bool IsPropertyReturnItemSeqIdRemoved { get; set; }

		public virtual bool IsPropertyRejectionReasonIdRemoved { get; set; }

		public virtual bool IsPropertyDamageStatusIdRemoved { get; set; }

		public virtual bool IsPropertyDamageReasonIdRemoved { get; set; }

		public virtual bool IsPropertyReceivedByRemoved { get; set; }

		public virtual bool IsPropertyDatetimeReceivedRemoved { get; set; }

		public virtual bool IsPropertyItemDescriptionRemoved { get; set; }

		public virtual bool IsPropertyAcceptedQuantityRemoved { get; set; }

		public virtual bool IsPropertyRejectedQuantityRemoved { get; set; }

		public virtual bool IsPropertyDamagedQuantityRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchShipmentReceipt ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class RemoveShipmentReceipt : ShipmentReceiptCommandBase, IRemoveShipmentReceipt
	{
		public RemoveShipmentReceipt ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }
	}

}
