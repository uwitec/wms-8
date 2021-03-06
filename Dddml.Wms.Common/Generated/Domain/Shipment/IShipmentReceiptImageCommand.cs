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
	public interface IShipmentReceiptImageCommand : ICommand, ICommandDto
	{
		// Outer Id:

		string ShipmentId { get; set; }

		// Outer Id:

		string ShipmentReceiptReceiptSeqId { get; set; }

		string SequenceId { get; set; }

	}


	public interface ICreateOrMergePatchOrRemoveShipmentReceiptImage : IShipmentReceiptImageCommand
	{

		string Url { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateShipmentReceiptImage : ICreateOrMergePatchOrRemoveShipmentReceiptImage
	{
	}

	public interface IMergePatchShipmentReceiptImage : ICreateOrMergePatchOrRemoveShipmentReceiptImage
	{

		bool IsPropertyUrlRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveShipmentReceiptImage : ICreateOrMergePatchOrRemoveShipmentReceiptImage
	{
	}


}

