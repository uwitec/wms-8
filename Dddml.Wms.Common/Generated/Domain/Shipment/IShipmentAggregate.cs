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

	public partial interface IShipmentAggregate : IGlobalIdentity<string>
	{
		IShipmentState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateShipment c);

		void MergePatch (IMergePatchShipment c);

		void Import(IEnumerable<ImportingShipmentItem> shipmentItems, long version, string commandId, string requesterId);


	}

}

