﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistItemMvo;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistItemMvo
{
	public interface IPicklistItemMvoStateEvent : IEvent, IStateEventDto, IGlobalIdentity<PicklistItemMvoEventId>, ICreated<string>
	{
		PicklistItemMvoEventId PicklistItemMvoEventId { get; }

        bool ReadOnly { get; set; }

		string ItemStatusId { get; set; }

		decimal? Quantity { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string PicklistBinPicklistId { get; set; }

		long? PicklistBinBinLocationNumber { get; set; }

		string PicklistBinPrimaryOrderId { get; set; }

		long? PicklistBinPrimaryShipGroupSeqId { get; set; }

		string PicklistBinCreatedBy { get; set; }

		DateTime? PicklistBinCreatedAt { get; set; }

		string PicklistBinUpdatedBy { get; set; }

		DateTime? PicklistBinUpdatedAt { get; set; }

		bool? PicklistBinActive { get; set; }

		bool? PicklistBinDeleted { get; set; }

	}

	public interface IPicklistItemMvoStateCreated : IPicklistItemMvoStateEvent//, IPicklistItemMvoStateProperties
	{
	
	}


	public interface IPicklistItemMvoStateMergePatched : IPicklistItemMvoStateEvent//, IPicklistItemMvoStateProperties
	{
		bool IsPropertyItemStatusIdRemoved { get; set; }

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyPicklistBinPicklistIdRemoved { get; set; }

		bool IsPropertyPicklistBinBinLocationNumberRemoved { get; set; }

		bool IsPropertyPicklistBinPrimaryOrderIdRemoved { get; set; }

		bool IsPropertyPicklistBinPrimaryShipGroupSeqIdRemoved { get; set; }

		bool IsPropertyPicklistBinCreatedByRemoved { get; set; }

		bool IsPropertyPicklistBinCreatedAtRemoved { get; set; }

		bool IsPropertyPicklistBinUpdatedByRemoved { get; set; }

		bool IsPropertyPicklistBinUpdatedAtRemoved { get; set; }

		bool IsPropertyPicklistBinActiveRemoved { get; set; }

		bool IsPropertyPicklistBinDeletedRemoved { get; set; }


	}

	public interface IPicklistItemMvoStateDeleted : IPicklistItemMvoStateEvent
	{
	}


}

