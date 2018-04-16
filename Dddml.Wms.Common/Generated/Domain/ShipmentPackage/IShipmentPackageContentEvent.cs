﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackage;

namespace Dddml.Wms.Domain.ShipmentPackage
{
	public interface IShipmentPackageContentEvent : IEvent, IEventDto, IGlobalIdentity<ShipmentPackageContentEventId>, ICreated<string>
	{
		ShipmentPackageContentEventId ShipmentPackageContentEventId { get; }

        bool ReadOnly { get; set; }

		// Outer Id:
		//ShipmentPackageId ShipmentPackageId { get; set; }

	}

    public interface IShipmentPackageContentStateEvent : IShipmentPackageContentEvent
    {
		long Version { get; set; }

		decimal? Quantity { get; set; }

		string SubProductId { get; set; }

		decimal? SubProductQuantity { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IShipmentPackageContentStateCreated : IShipmentPackageContentStateEvent
	{
	
	}


	public interface IShipmentPackageContentStateMergePatched : IShipmentPackageContentStateEvent
	{
		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertySubProductIdRemoved { get; set; }

		bool IsPropertySubProductQuantityRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IShipmentPackageContentStateRemoved : IShipmentPackageContentStateEvent
	{
	}


}

