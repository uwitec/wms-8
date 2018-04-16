﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGrpInvReservationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGrpInvReservation;

namespace Dddml.Wms.Domain.OrderItemShipGrpInvReservation
{
	public interface IOrderItemShipGrpInvReservationEvent : IEvent, IEventDto, IGlobalIdentity<OrderItemShipGrpInvReservationEventId>, ICreated<string>
	{
		OrderItemShipGrpInvReservationEventId OrderItemShipGrpInvReservationEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IOrderItemShipGrpInvReservationStateEvent : IOrderItemShipGrpInvReservationEvent
    {
		string ReserveOrderEnumId { get; set; }

		decimal? Quantity { get; set; }

		decimal? QuantityNotAvailable { get; set; }

		DateTime? ReservedDatetime { get; set; }

		DateTime? CreatedDatetime { get; set; }

		DateTime? PromisedDatetime { get; set; }

		DateTime? CurrentPromisedDate { get; set; }

		string Priority { get; set; }

		long? SequenceId { get; set; }

		DateTime? OldPickStartDate { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IOrderItemShipGrpInvReservationStateCreated : IOrderItemShipGrpInvReservationStateEvent
	{
	
	}


	public interface IOrderItemShipGrpInvReservationStateMergePatched : IOrderItemShipGrpInvReservationStateEvent
	{
		bool IsPropertyReserveOrderEnumIdRemoved { get; set; }

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertyQuantityNotAvailableRemoved { get; set; }

		bool IsPropertyReservedDatetimeRemoved { get; set; }

		bool IsPropertyCreatedDatetimeRemoved { get; set; }

		bool IsPropertyPromisedDatetimeRemoved { get; set; }

		bool IsPropertyCurrentPromisedDateRemoved { get; set; }

		bool IsPropertyPriorityRemoved { get; set; }

		bool IsPropertySequenceIdRemoved { get; set; }

		bool IsPropertyOldPickStartDateRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IOrderItemShipGrpInvReservationStateDeleted : IOrderItemShipGrpInvReservationStateEvent
	{
	}


}

