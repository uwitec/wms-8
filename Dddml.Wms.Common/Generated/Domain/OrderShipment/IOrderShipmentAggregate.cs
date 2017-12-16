﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipment;

namespace Dddml.Wms.Domain.OrderShipment
{

	public partial interface IOrderShipmentAggregate : IGlobalIdentity<OrderShipmentId>
	{
		IOrderShipmentState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateOrderShipment c);

		void MergePatch (IMergePatchOrderShipment c);


	}

}

