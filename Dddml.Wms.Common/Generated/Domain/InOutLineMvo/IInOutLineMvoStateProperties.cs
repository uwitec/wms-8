﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{

	public interface IInOutLineMvoStateProperties
	{
		InOutLineId InOutLineId { get; set; }

		string LocatorId { get; set; }

		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		string Description { get; set; }

		string QuantityUomId { get; set; }

		decimal MovementQuantity { get; set; }

		decimal PickedQuantity { get; set; }

		bool IsInvoiced { get; set; }

		bool Processed { get; set; }

		long RmaLineNumber { get; set; }

		long ReversalLineNumber { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

		string InOutDocumentStatusId { get; set; }

		bool InOutPosted { get; set; }

		bool InOutProcessed { get; set; }

		string InOutProcessing { get; set; }

		string InOutDocumentTypeId { get; set; }

		string InOutDescription { get; set; }

		string InOutOrderId { get; set; }

		DateTime? InOutDateOrdered { get; set; }

		bool InOutIsPrinted { get; set; }

		string InOutMovementTypeId { get; set; }

		DateTime? InOutMovementDate { get; set; }

		string InOutBusinessPartnerId { get; set; }

		string InOutWarehouseId { get; set; }

		string InOutPOReference { get; set; }

		decimal InOutFreightAmount { get; set; }

		string InOutShipperId { get; set; }

		decimal InOutChargeAmount { get; set; }

		DateTime? InOutDatePrinted { get; set; }

		string InOutCreatedFrom { get; set; }

		string InOutSalesRepresentativeId { get; set; }

		int InOutNumberOfPackages { get; set; }

		DateTime? InOutPickDate { get; set; }

		DateTime? InOutShipDate { get; set; }

		string InOutTrackingNumber { get; set; }

		DateTime? InOutDateReceived { get; set; }

		bool InOutIsInTransit { get; set; }

		bool InOutIsApproved { get; set; }

		bool InOutIsInDispute { get; set; }

		string InOutRmaDocumentNumber { get; set; }

		string InOutReversalDocumentNumber { get; set; }

		long InOutVersion { get; set; }

		string InOutCreatedBy { get; set; }

		DateTime InOutCreatedAt { get; set; }

		string InOutUpdatedBy { get; set; }

		DateTime InOutUpdatedAt { get; set; }

		bool InOutActive { get; set; }

		bool InOutDeleted { get; set; }

	}

}
