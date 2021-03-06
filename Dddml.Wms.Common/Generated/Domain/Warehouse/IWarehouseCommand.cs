﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateWarehouseDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Warehouse;

namespace Dddml.Wms.Domain.Warehouse
{
	public interface IWarehouseCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string WarehouseId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteWarehouse : IWarehouseCommand
	{

		string WarehouseName { get; set; }

		string Description { get; set; }

		bool? IsInTransit { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateWarehouse : ICreateOrMergePatchOrDeleteWarehouse
	{
	}

	public interface IMergePatchWarehouse : ICreateOrMergePatchOrDeleteWarehouse
	{

		bool IsPropertyWarehouseNameRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyIsInTransitRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IDeleteWarehouse : ICreateOrMergePatchOrDeleteWarehouse
	{
	}


}

