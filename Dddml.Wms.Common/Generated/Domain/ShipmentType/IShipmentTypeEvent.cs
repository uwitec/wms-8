﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentType;

namespace Dddml.Wms.Domain.ShipmentType
{
	public interface IShipmentTypeEvent : IEvent, IEventDto, IGlobalIdentity<ShipmentTypeEventId>, ICreated<string>
	{
		ShipmentTypeEventId ShipmentTypeEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IShipmentTypeStateEvent : IShipmentTypeEvent
    {
		string ParentTypeId { get; set; }

		string HasTable { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IShipmentTypeStateCreated : IShipmentTypeStateEvent
	{
	
	}


	public interface IShipmentTypeStateMergePatched : IShipmentTypeStateEvent
	{
		bool IsPropertyParentTypeIdRemoved { get; set; }

		bool IsPropertyHasTableRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}


}
