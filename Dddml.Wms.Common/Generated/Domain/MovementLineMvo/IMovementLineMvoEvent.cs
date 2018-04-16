﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementLineMvo;
using Dddml.Wms.Domain.Movement;

namespace Dddml.Wms.Domain.MovementLineMvo
{
	public interface IMovementLineMvoEvent : IEvent, IEventDto, IGlobalIdentity<MovementLineMvoEventId>, ICreated<string>
	{
		MovementLineMvoEventId MovementLineMvoEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IMovementLineMvoStateEvent : IMovementLineMvoEvent
    {
		decimal? MovementQuantity { get; set; }

		string ProductId { get; set; }

		string LocatorIdFrom { get; set; }

		string LocatorIdTo { get; set; }

		string AttributeSetInstanceId { get; set; }

		bool? Processed { get; set; }

		string ReversalLineNumber { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string MovementDocumentStatusId { get; set; }

		DateTime? MovementMovementDate { get; set; }

		bool? MovementPosted { get; set; }

		bool? MovementProcessed { get; set; }

		string MovementProcessing { get; set; }

		DateTime? MovementDateReceived { get; set; }

		string MovementDocumentTypeId { get; set; }

		bool? MovementIsInTransit { get; set; }

		bool? MovementIsApproved { get; set; }

		decimal? MovementApprovalAmount { get; set; }

		string MovementShipperId { get; set; }

		string MovementSalesRepresentativeId { get; set; }

		string MovementBusinessPartnerId { get; set; }

		decimal? MovementChargeAmount { get; set; }

		string MovementCreateFrom { get; set; }

		decimal? MovementFreightAmount { get; set; }

		string MovementReversalDocumentNumber { get; set; }

		string MovementWarehouseIdFrom { get; set; }

		string MovementWarehouseIdTo { get; set; }

		string MovementDescription { get; set; }

		string MovementCreatedBy { get; set; }

		DateTime? MovementCreatedAt { get; set; }

		string MovementUpdatedBy { get; set; }

		DateTime? MovementUpdatedAt { get; set; }

		bool? MovementActive { get; set; }

		bool? MovementDeleted { get; set; }

    }
   
	public interface IMovementLineMvoStateCreated : IMovementLineMvoStateEvent
	{
	
	}


	public interface IMovementLineMvoStateMergePatched : IMovementLineMvoStateEvent
	{
		bool IsPropertyMovementQuantityRemoved { get; set; }

		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyLocatorIdFromRemoved { get; set; }

		bool IsPropertyLocatorIdToRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyReversalLineNumberRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyMovementDocumentStatusIdRemoved { get; set; }

		bool IsPropertyMovementMovementDateRemoved { get; set; }

		bool IsPropertyMovementPostedRemoved { get; set; }

		bool IsPropertyMovementProcessedRemoved { get; set; }

		bool IsPropertyMovementProcessingRemoved { get; set; }

		bool IsPropertyMovementDateReceivedRemoved { get; set; }

		bool IsPropertyMovementDocumentTypeIdRemoved { get; set; }

		bool IsPropertyMovementIsInTransitRemoved { get; set; }

		bool IsPropertyMovementIsApprovedRemoved { get; set; }

		bool IsPropertyMovementApprovalAmountRemoved { get; set; }

		bool IsPropertyMovementShipperIdRemoved { get; set; }

		bool IsPropertyMovementSalesRepresentativeIdRemoved { get; set; }

		bool IsPropertyMovementBusinessPartnerIdRemoved { get; set; }

		bool IsPropertyMovementChargeAmountRemoved { get; set; }

		bool IsPropertyMovementCreateFromRemoved { get; set; }

		bool IsPropertyMovementFreightAmountRemoved { get; set; }

		bool IsPropertyMovementReversalDocumentNumberRemoved { get; set; }

		bool IsPropertyMovementWarehouseIdFromRemoved { get; set; }

		bool IsPropertyMovementWarehouseIdToRemoved { get; set; }

		bool IsPropertyMovementDescriptionRemoved { get; set; }

		bool IsPropertyMovementCreatedByRemoved { get; set; }

		bool IsPropertyMovementCreatedAtRemoved { get; set; }

		bool IsPropertyMovementUpdatedByRemoved { get; set; }

		bool IsPropertyMovementUpdatedAtRemoved { get; set; }

		bool IsPropertyMovementActiveRemoved { get; set; }

		bool IsPropertyMovementDeletedRemoved { get; set; }


	}

	public interface IMovementLineMvoStateDeleted : IMovementLineMvoStateEvent
	{
	}


}

