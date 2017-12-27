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
	public interface IInOutLineCommand : ICommand, ICommandDto
	{
		// Outer Id:

		string InOutDocumentNumber { get; set; }

		string LineNumber { get; set; }

	}


	public interface ICreateOrMergePatchOrRemoveInOutLine : IInOutLineCommand
	{

		string LocatorId { get; set; }

		string ProductId { get; set; }

		string AttributeSetInstanceId { get; set; }

		string Description { get; set; }

		string QuantityUomId { get; set; }

		decimal? MovementQuantity { get; set; }

		decimal? PickedQuantity { get; set; }

		bool? IsInvoiced { get; set; }

		bool? Processed { get; set; }

		long? RmaLineNumber { get; set; }

		long? ReversalLineNumber { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateInOutLine : ICreateOrMergePatchOrRemoveInOutLine
	{
	}

	public interface IMergePatchInOutLine : ICreateOrMergePatchOrRemoveInOutLine
	{

		bool IsPropertyLocatorIdRemoved { get; set; }

		bool IsPropertyProductIdRemoved { get; set; }

		bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyQuantityUomIdRemoved { get; set; }

		bool IsPropertyMovementQuantityRemoved { get; set; }

		bool IsPropertyPickedQuantityRemoved { get; set; }

		bool IsPropertyIsInvoicedRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyRmaLineNumberRemoved { get; set; }

		bool IsPropertyReversalLineNumberRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IRemoveInOutLine : ICreateOrMergePatchOrRemoveInOutLine
	{
	}


}

