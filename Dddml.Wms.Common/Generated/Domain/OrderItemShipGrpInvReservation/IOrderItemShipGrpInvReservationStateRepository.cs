﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemShipGrpInvReservationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGrpInvReservation;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderItemShipGrpInvReservation
{
	public partial interface IOrderItemShipGrpInvReservationStateRepository
	{

        IOrderItemShipGrpInvReservationState Get(OrderItemShipGrpInvResId id, bool nullAllowed);
        
        void Save(IOrderItemShipGrpInvReservationState state);
        
	}

}

