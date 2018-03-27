﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public interface IOrderStateProperties
	{
		string OrderId { get; set; }

		string OrderTypeId { get; set; }

		string OrderName { get; set; }

		string ExternalId { get; set; }

		string SalesChannelEnumId { get; set; }

		DateTime? OrderDate { get; set; }

		string Priority { get; set; }

		DateTime? EntryDate { get; set; }

		DateTime? PickSheetPrintedDate { get; set; }

		string StatusId { get; set; }

		string CurrencyUom { get; set; }

		string SyncStatusId { get; set; }

		string BillingAccountId { get; set; }

		string OriginFacilityId { get; set; }

		string WebSiteId { get; set; }

		string ProductStoreId { get; set; }

		string TerminalId { get; set; }

		string TransactionId { get; set; }

		string AutoOrderShoppingListId { get; set; }

		string NeedsInventoryIssuance { get; set; }

		string IsRushOrder { get; set; }

		string InternalCode { get; set; }

		decimal? RemainingSubTotal { get; set; }

		decimal? GrandTotal { get; set; }

		string InvoicePerShipment { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

	}

}
