﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentReceiptMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentReceiptMvo;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.ShipmentReceiptMvo
{
	public interface IShipmentReceiptMvoState : IShipmentReceiptMvoStateProperties, 
		IGlobalIdentity<ShipmentReceiptId>, 
		ICreated<string>, 
		IUpdated<string>, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IShipmentReceiptMvoStateCreated e);

		void When(IShipmentReceiptMvoStateMergePatched e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}
}

