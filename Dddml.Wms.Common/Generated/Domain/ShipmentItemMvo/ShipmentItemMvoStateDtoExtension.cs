﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItemMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentItemMvo
{

	public static partial class ShipmentItemMvoStateDtoExtension
	{

        public static IShipmentItemMvoCommand ToCreateOrMergePatchShipmentItemMvo(this ShipmentItemMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchShipmentItemMvo<CreateShipmentItemMvoDto, MergePatchShipmentItemMvoDto>();
        }

        public static DeleteShipmentItemMvoDto ToDeleteShipmentItemMvo(this ShipmentItemMvoStateDtoWrapper state)
        {
            return state.ToDeleteShipmentItemMvo<DeleteShipmentItemMvoDto>();
        }

        public static MergePatchShipmentItemMvoDto ToMergePatchShipmentItemMvo(this ShipmentItemMvoStateDtoWrapper state)
        {
            return state.ToMergePatchShipmentItemMvo<MergePatchShipmentItemMvoDto>();
        }

        public static CreateShipmentItemMvoDto ToCreateShipmentItemMvo(this ShipmentItemMvoStateDtoWrapper state)
        {
            return state.ToCreateShipmentItemMvo<CreateShipmentItemMvoDto>();
        }
		

	}

}
