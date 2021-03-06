﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public interface IInOutStateProperties
	{
		string DocumentNumber { get; set; }

		string DocumentStatusId { get; set; }

		bool Posted { get; set; }

		bool Processed { get; set; }

		string Processing { get; set; }

		string DocumentTypeId { get; set; }

		string Description { get; set; }

		string OrderId { get; set; }

		DateTime? DateOrdered { get; set; }

		bool IsPrinted { get; set; }

		string MovementTypeId { get; set; }

		DateTime? MovementDate { get; set; }

		string BusinessPartnerId { get; set; }

		string WarehouseId { get; set; }

		string POReference { get; set; }

		decimal FreightAmount { get; set; }

		string ShipperId { get; set; }

		decimal ChargeAmount { get; set; }

		DateTime? DatePrinted { get; set; }

		string CreatedFrom { get; set; }

		string SalesRepresentativeId { get; set; }

		int NumberOfPackages { get; set; }

		DateTime? PickDate { get; set; }

		DateTime? ShipDate { get; set; }

		string TrackingNumber { get; set; }

		DateTime? DateReceived { get; set; }

		bool IsInTransit { get; set; }

		bool IsApproved { get; set; }

		bool IsInDispute { get; set; }

		string RmaDocumentNumber { get; set; }

		string ReversalDocumentNumber { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

	}

}
