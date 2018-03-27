﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public abstract class OrderShipGroupCommandBase : IOrderShipGroupCommand
	{
		public virtual long? ShipGroupSeqId { get; set; }


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

		public virtual string ShipmentMethodTypeId { get; set; }

		public virtual string SupplierPartyId { get; set; }

		public virtual string VendorPartyId { get; set; }

		public virtual string CarrierPartyId { get; set; }

		public virtual string CarrierRoleTypeId { get; set; }

		public virtual string FacilityId { get; set; }

		public virtual string ContactMechId { get; set; }

		public virtual string TelecomContactMechId { get; set; }

		public virtual string TrackingNumber { get; set; }

		public virtual string ShippingInstructions { get; set; }

		public virtual string MaySplit { get; set; }

		public virtual string GiftMessage { get; set; }

		public virtual string IsGift { get; set; }

		public virtual DateTime? ShipAfterDate { get; set; }

		public virtual DateTime? ShipByDate { get; set; }

		public virtual DateTime? EstimatedShipDate { get; set; }

		public virtual DateTime? EstimatedDeliveryDate { get; set; }

		public virtual bool? Active { get; set; }

		// Outer Id:

		public virtual string OrderId { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateOrderShipGroup : OrderShipGroupCommandBase, ICreateOrderShipGroup
	{
		
		public CreateOrderShipGroup ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchOrderShipGroup :OrderShipGroupCommandBase, IMergePatchOrderShipGroup
	{

		public virtual bool IsPropertyShipmentMethodTypeIdRemoved { get; set; }

		public virtual bool IsPropertySupplierPartyIdRemoved { get; set; }

		public virtual bool IsPropertyVendorPartyIdRemoved { get; set; }

		public virtual bool IsPropertyCarrierPartyIdRemoved { get; set; }

		public virtual bool IsPropertyCarrierRoleTypeIdRemoved { get; set; }

		public virtual bool IsPropertyFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyTelecomContactMechIdRemoved { get; set; }

		public virtual bool IsPropertyTrackingNumberRemoved { get; set; }

		public virtual bool IsPropertyShippingInstructionsRemoved { get; set; }

		public virtual bool IsPropertyMaySplitRemoved { get; set; }

		public virtual bool IsPropertyGiftMessageRemoved { get; set; }

		public virtual bool IsPropertyIsGiftRemoved { get; set; }

		public virtual bool IsPropertyShipAfterDateRemoved { get; set; }

		public virtual bool IsPropertyShipByDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedShipDateRemoved { get; set; }

		public virtual bool IsPropertyEstimatedDeliveryDateRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchOrderShipGroup ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class RemoveOrderShipGroup : OrderShipGroupCommandBase, IRemoveOrderShipGroup
	{
		public RemoveOrderShipGroup ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }
	}

}
