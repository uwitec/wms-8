﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistBinDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistBin
{
	public interface IPicklistItemStateEvent : IEvent, IStateEventDto, IGlobalIdentity<PicklistItemEventId>, ICreated<string>
	{
		PicklistItemEventId PicklistItemEventId { get; }

        bool ReadOnly { get; set; }

		long Version { get; set; }

		string ItemStatusId { get; set; }

		decimal? Quantity { get; set; }

		bool? Active { get; set; }

		// Outer Id:
		//string PicklistBinId { get; set; }

	}

	public interface IPicklistItemStateCreated : IPicklistItemStateEvent//, IPicklistItemStateProperties
	{
	
	}


	public interface IPicklistItemStateMergePatched : IPicklistItemStateEvent//, IPicklistItemStateProperties
	{
		bool IsPropertyItemStatusIdRemoved { get; set; }

		bool IsPropertyQuantityRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IPicklistItemStateRemoved : IPicklistItemStateEvent
	{
	}


}

