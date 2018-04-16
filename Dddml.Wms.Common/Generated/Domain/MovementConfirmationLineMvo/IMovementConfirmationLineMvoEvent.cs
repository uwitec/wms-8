﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmationLineMvo;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmationLineMvo
{
	public interface IMovementConfirmationLineMvoEvent : IEvent, IEventDto, IGlobalIdentity<MovementConfirmationLineMvoEventId>, ICreated<string>
	{
		MovementConfirmationLineMvoEventId MovementConfirmationLineMvoEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IMovementConfirmationLineMvoStateEvent : IMovementConfirmationLineMvoEvent
    {
		string MovementLineNumber { get; set; }

		decimal? TargetQuantity { get; set; }

		decimal? ConfirmedQuantity { get; set; }

		decimal? DifferenceQuantity { get; set; }

		decimal? ScrappedQuantity { get; set; }

		string Description { get; set; }

		bool? Processed { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string MovementConfirmationDocumentStatusId { get; set; }

		string MovementConfirmationMovementDocumentNumber { get; set; }

		bool? MovementConfirmationIsApproved { get; set; }

		decimal? MovementConfirmationApprovalAmount { get; set; }

		bool? MovementConfirmationProcessed { get; set; }

		string MovementConfirmationProcessing { get; set; }

		string MovementConfirmationDocumentTypeId { get; set; }

		string MovementConfirmationDescription { get; set; }

		string MovementConfirmationCreatedBy { get; set; }

		DateTime? MovementConfirmationCreatedAt { get; set; }

		string MovementConfirmationUpdatedBy { get; set; }

		DateTime? MovementConfirmationUpdatedAt { get; set; }

		bool? MovementConfirmationActive { get; set; }

		bool? MovementConfirmationDeleted { get; set; }

    }
   
	public interface IMovementConfirmationLineMvoStateCreated : IMovementConfirmationLineMvoStateEvent
	{
	
	}


	public interface IMovementConfirmationLineMvoStateMergePatched : IMovementConfirmationLineMvoStateEvent
	{
		bool IsPropertyMovementLineNumberRemoved { get; set; }

		bool IsPropertyTargetQuantityRemoved { get; set; }

		bool IsPropertyConfirmedQuantityRemoved { get; set; }

		bool IsPropertyDifferenceQuantityRemoved { get; set; }

		bool IsPropertyScrappedQuantityRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyMovementConfirmationDocumentStatusIdRemoved { get; set; }

		bool IsPropertyMovementConfirmationMovementDocumentNumberRemoved { get; set; }

		bool IsPropertyMovementConfirmationIsApprovedRemoved { get; set; }

		bool IsPropertyMovementConfirmationApprovalAmountRemoved { get; set; }

		bool IsPropertyMovementConfirmationProcessedRemoved { get; set; }

		bool IsPropertyMovementConfirmationProcessingRemoved { get; set; }

		bool IsPropertyMovementConfirmationDocumentTypeIdRemoved { get; set; }

		bool IsPropertyMovementConfirmationDescriptionRemoved { get; set; }

		bool IsPropertyMovementConfirmationCreatedByRemoved { get; set; }

		bool IsPropertyMovementConfirmationCreatedAtRemoved { get; set; }

		bool IsPropertyMovementConfirmationUpdatedByRemoved { get; set; }

		bool IsPropertyMovementConfirmationUpdatedAtRemoved { get; set; }

		bool IsPropertyMovementConfirmationActiveRemoved { get; set; }

		bool IsPropertyMovementConfirmationDeletedRemoved { get; set; }


	}

	public interface IMovementConfirmationLineMvoStateDeleted : IMovementConfirmationLineMvoStateEvent
	{
	}


}

