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
	public interface IShipmentItemStateEvent : IEvent, IStateEventDto, IGlobalIdentity<ShipmentItemEventId>, ICreated<string>
	{
		ShipmentItemEventId ShipmentItemEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		decimal? Quantity { get; set; }

		string ShipmentContentDescription { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string ShipmentId { get; set; }

	}

	public interface IShipmentItemStateCreated : IShipmentItemStateEvent//, IShipmentItemStateProperties
	{
	
	}


	public interface IShipmentItemStateMergePatched : IShipmentItemStateEvent//, IShipmentItemStateProperties
	{
		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertyShipmentContentDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}


}

