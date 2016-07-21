﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{
	public interface IInOutLineMvoStateEvent : IEvent, IStateEventDto, IGlobalIdentity<InOutLineMvoStateEventId>, ICreated<string>
	{
		InOutLineMvoStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		long? LineNumber { get; set; }

		string Description { get; set; }

		string LocatorId { get; set; }

		string Product { get; set; }

		string UomId { get; set; }

		decimal? MovementQuantity { get; set; }

		decimal? ConfirmedQuantity { get; set; }

		decimal? ScrappedQuantity { get; set; }

		decimal? TargetQuantity { get; set; }

		decimal? PickedQuantity { get; set; }

		bool? IsInvoiced { get; set; }

		string AttributeSetInstanceId { get; set; }

		bool? IsDescription { get; set; }

		bool? Processed { get; set; }

		decimal? QuantityEntered { get; set; }

		long? RmaLineNumber { get; set; }

		long? ReversalLineNumber { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		bool? InOutIsSOTransaction { get; set; }

		string InOutDocumentStatus { get; set; }

		bool? InOutPosted { get; set; }

		bool? InOutProcessing { get; set; }

		bool? InOutProcessed { get; set; }

		int? InOutDocumentType { get; set; }

		string InOutDescription { get; set; }

		string InOutOrderNumber { get; set; }

		DateTime? InOutDateOrdered { get; set; }

		bool? InOutIsPrinted { get; set; }

		string InOutMovementType { get; set; }

		DateTime? InOutMovementDate { get; set; }

		string InOutBusinessPartnerId { get; set; }

		string InOutWarehouseId { get; set; }

		string InOutPOReference { get; set; }

		Money? InOutFreightAmount { get; set; }

		string InOutShipperId { get; set; }

		Money? InOutChargeAmount { get; set; }

		DateTime? InOutDatePrinted { get; set; }

		string InOutSalesRepresentative { get; set; }

		int? InOutNumberOfPackages { get; set; }

		DateTime? InOutPickDate { get; set; }

		DateTime? InOutShipDate { get; set; }

		string InOutTrackingNumber { get; set; }

		DateTime? InOutDateReceived { get; set; }

		bool? InOutIsInTransit { get; set; }

		bool? InOutIsApproved { get; set; }

		bool? InOutIsInDispute { get; set; }

		decimal? InOutVolume { get; set; }

		decimal? InOutWeight { get; set; }

		string InOutRmaNumber { get; set; }

		string InOutReversalNumber { get; set; }

		bool? InOutIsDropShip { get; set; }

		string InOutDropShipBusinessPartnerId { get; set; }

		string InOutCreatedBy { get; set; }

		DateTime? InOutCreatedAt { get; set; }

		string InOutUpdatedBy { get; set; }

		DateTime? InOutUpdatedAt { get; set; }

		bool? InOutActive { get; set; }

		bool? InOutDeleted { get; set; }


	}

	public interface IInOutLineMvoStateCreated : IInOutLineMvoStateEvent//, IInOutLineMvoStateProperties
	{
	
	}


	public interface IInOutLineMvoStateMergePatched : IInOutLineMvoStateEvent//, IInOutLineMvoStateProperties
	{
		bool IsPropertyLineNumberRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyLocatorIdRemoved { get; set; }

		bool IsPropertyProductRemoved { get; set; }

		bool IsPropertyUomIdRemoved { get; set; }

		bool IsPropertyMovementQuantityRemoved { get; set; }

		bool IsPropertyConfirmedQuantityRemoved { get; set; }

		bool IsPropertyScrappedQuantityRemoved { get; set; }

		bool IsPropertyTargetQuantityRemoved { get; set; }

		bool IsPropertyPickedQuantityRemoved { get; set; }

		bool IsPropertyIsInvoicedRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyIsDescriptionRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyQuantityEnteredRemoved { get; set; }

		bool IsPropertyRmaLineNumberRemoved { get; set; }

		bool IsPropertyReversalLineNumberRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyInOutIsSOTransactionRemoved { get; set; }

		bool IsPropertyInOutDocumentStatusRemoved { get; set; }

		bool IsPropertyInOutPostedRemoved { get; set; }

		bool IsPropertyInOutProcessingRemoved { get; set; }

		bool IsPropertyInOutProcessedRemoved { get; set; }

		bool IsPropertyInOutDocumentTypeRemoved { get; set; }

		bool IsPropertyInOutDescriptionRemoved { get; set; }

		bool IsPropertyInOutOrderNumberRemoved { get; set; }

		bool IsPropertyInOutDateOrderedRemoved { get; set; }

		bool IsPropertyInOutIsPrintedRemoved { get; set; }

		bool IsPropertyInOutMovementTypeRemoved { get; set; }

		bool IsPropertyInOutMovementDateRemoved { get; set; }

		bool IsPropertyInOutBusinessPartnerIdRemoved { get; set; }

		bool IsPropertyInOutWarehouseIdRemoved { get; set; }

		bool IsPropertyInOutPOReferenceRemoved { get; set; }

		bool IsPropertyInOutFreightAmountRemoved { get; set; }

		bool IsPropertyInOutShipperIdRemoved { get; set; }

		bool IsPropertyInOutChargeAmountRemoved { get; set; }

		bool IsPropertyInOutDatePrintedRemoved { get; set; }

		bool IsPropertyInOutSalesRepresentativeRemoved { get; set; }

		bool IsPropertyInOutNumberOfPackagesRemoved { get; set; }

		bool IsPropertyInOutPickDateRemoved { get; set; }

		bool IsPropertyInOutShipDateRemoved { get; set; }

		bool IsPropertyInOutTrackingNumberRemoved { get; set; }

		bool IsPropertyInOutDateReceivedRemoved { get; set; }

		bool IsPropertyInOutIsInTransitRemoved { get; set; }

		bool IsPropertyInOutIsApprovedRemoved { get; set; }

		bool IsPropertyInOutIsInDisputeRemoved { get; set; }

		bool IsPropertyInOutVolumeRemoved { get; set; }

		bool IsPropertyInOutWeightRemoved { get; set; }

		bool IsPropertyInOutRmaNumberRemoved { get; set; }

		bool IsPropertyInOutReversalNumberRemoved { get; set; }

		bool IsPropertyInOutIsDropShipRemoved { get; set; }

		bool IsPropertyInOutDropShipBusinessPartnerIdRemoved { get; set; }

		bool IsPropertyInOutCreatedByRemoved { get; set; }

		bool IsPropertyInOutCreatedAtRemoved { get; set; }

		bool IsPropertyInOutUpdatedByRemoved { get; set; }

		bool IsPropertyInOutUpdatedAtRemoved { get; set; }

		bool IsPropertyInOutActiveRemoved { get; set; }

		bool IsPropertyInOutDeletedRemoved { get; set; }


	}

	public interface IInOutLineMvoStateDeleted : IInOutLineMvoStateEvent
	{
	}


}

