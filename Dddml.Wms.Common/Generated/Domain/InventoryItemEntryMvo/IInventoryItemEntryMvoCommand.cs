﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemEntryMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItemEntryMvo
{
	public interface IInventoryItemEntryMvoCommand : IAggregateCommand<InventoryItemEntryId, long>, ICommandDto
	{
		long InventoryItemVersion { get; set; }

		InventoryItemEntryId InventoryItemEntryId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteInventoryItemEntryMvo : IInventoryItemEntryMvoCommand
	{

		decimal? OnHandQuantity { get; set; }

		decimal? InTransitQuantity { get; set; }

		decimal? ReservedQuantity { get; set; }

		decimal? OccupiedQuantity { get; set; }

		decimal? VirtualQuantity { get; set; }

		InventoryItemSourceInfo Source { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		decimal? InventoryItemOnHandQuantity { get; set; }

		decimal? InventoryItemInTransitQuantity { get; set; }

		decimal? InventoryItemReservedQuantity { get; set; }

		decimal? InventoryItemOccupiedQuantity { get; set; }

		decimal? InventoryItemVirtualQuantity { get; set; }

		string InventoryItemCreatedBy { get; set; }

		DateTime? InventoryItemCreatedAt { get; set; }

		string InventoryItemUpdatedBy { get; set; }

		DateTime? InventoryItemUpdatedAt { get; set; }


	}

	public interface ICreateInventoryItemEntryMvo : ICreateOrMergePatchOrDeleteInventoryItemEntryMvo
	{
	}

	public interface IMergePatchInventoryItemEntryMvo : ICreateOrMergePatchOrDeleteInventoryItemEntryMvo
	{

		bool IsPropertyOnHandQuantityRemoved { get; set; }

		bool IsPropertyInTransitQuantityRemoved { get; set; }

		bool IsPropertyReservedQuantityRemoved { get; set; }

		bool IsPropertyOccupiedQuantityRemoved { get; set; }

		bool IsPropertyVirtualQuantityRemoved { get; set; }

		bool IsPropertySourceRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyInventoryItemOnHandQuantityRemoved { get; set; }

		bool IsPropertyInventoryItemInTransitQuantityRemoved { get; set; }

		bool IsPropertyInventoryItemReservedQuantityRemoved { get; set; }

		bool IsPropertyInventoryItemOccupiedQuantityRemoved { get; set; }

		bool IsPropertyInventoryItemVirtualQuantityRemoved { get; set; }

		bool IsPropertyInventoryItemCreatedByRemoved { get; set; }

		bool IsPropertyInventoryItemCreatedAtRemoved { get; set; }

		bool IsPropertyInventoryItemUpdatedByRemoved { get; set; }

		bool IsPropertyInventoryItemUpdatedAtRemoved { get; set; }


	}

	public interface IDeleteInventoryItemEntryMvo : ICreateOrMergePatchOrDeleteInventoryItemEntryMvo
	{
	}


}

