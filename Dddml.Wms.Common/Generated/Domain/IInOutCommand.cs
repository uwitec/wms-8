﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{
	public interface IInOutCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string DocumentNumber { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteInOut : IInOutCommand
	{

		bool? IsSOTransaction { get; set; }

		string DocumentAction { get; set; }

		bool? Posted { get; set; }

		bool? Processing { get; set; }

		bool? Processed { get; set; }

		int? DocumentType { get; set; }

		string Description { get; set; }

		string OrderNumber { get; set; }

		DateTime? DateOrdered { get; set; }

		bool? IsPrinted { get; set; }

		string MovementType { get; set; }

		DateTime? MovementDate { get; set; }

		string BusinessPartnerId { get; set; }

		string WarehouseId { get; set; }

		string POReference { get; set; }

		Money? FreightAmount { get; set; }

		string ShipperId { get; set; }

		Money? ChargeAmount { get; set; }

		DateTime? DatePrinted { get; set; }

		string SalesRepresentative { get; set; }

		int? NumberOfPackages { get; set; }

		DateTime? PickDate { get; set; }

		DateTime? ShipDate { get; set; }

		string TrackingNumber { get; set; }

		DateTime? DateReceived { get; set; }

		bool? IsInTransit { get; set; }

		bool? IsApproved { get; set; }

		bool? IsInDispute { get; set; }

		decimal? Volume { get; set; }

		decimal? Weight { get; set; }

		string RmaNumber { get; set; }

		string ReversalNumber { get; set; }

		bool? IsDropShip { get; set; }

		string DropShipBusinessPartnerId { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateInOut : ICreateOrMergePatchOrDeleteInOut
	{
        ICreateInOutLineCommands InOutLines { get; }

        ICreateInOutLine NewCreateInOutLine();

	}

	public interface IMergePatchInOut : ICreateOrMergePatchOrDeleteInOut
	{

		bool IsPropertyIsSOTransactionRemoved { get; set; }

		bool IsPropertyPostedRemoved { get; set; }

		bool IsPropertyProcessingRemoved { get; set; }

		bool IsPropertyProcessedRemoved { get; set; }

		bool IsPropertyDocumentTypeRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyOrderNumberRemoved { get; set; }

		bool IsPropertyDateOrderedRemoved { get; set; }

		bool IsPropertyIsPrintedRemoved { get; set; }

		bool IsPropertyMovementTypeRemoved { get; set; }

		bool IsPropertyMovementDateRemoved { get; set; }

		bool IsPropertyBusinessPartnerIdRemoved { get; set; }

		bool IsPropertyWarehouseIdRemoved { get; set; }

		bool IsPropertyPOReferenceRemoved { get; set; }

		bool IsPropertyFreightAmountRemoved { get; set; }

		bool IsPropertyShipperIdRemoved { get; set; }

		bool IsPropertyChargeAmountRemoved { get; set; }

		bool IsPropertyDatePrintedRemoved { get; set; }

		bool IsPropertySalesRepresentativeRemoved { get; set; }

		bool IsPropertyNumberOfPackagesRemoved { get; set; }

		bool IsPropertyPickDateRemoved { get; set; }

		bool IsPropertyShipDateRemoved { get; set; }

		bool IsPropertyTrackingNumberRemoved { get; set; }

		bool IsPropertyDateReceivedRemoved { get; set; }

		bool IsPropertyIsInTransitRemoved { get; set; }

		bool IsPropertyIsApprovedRemoved { get; set; }

		bool IsPropertyIsInDisputeRemoved { get; set; }

		bool IsPropertyVolumeRemoved { get; set; }

		bool IsPropertyWeightRemoved { get; set; }

		bool IsPropertyRmaNumberRemoved { get; set; }

		bool IsPropertyReversalNumberRemoved { get; set; }

		bool IsPropertyIsDropShipRemoved { get; set; }

		bool IsPropertyDropShipBusinessPartnerIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

        IInOutLineCommands InOutLineCommands { get; }

        ICreateInOutLine NewCreateInOutLine();

        IMergePatchInOutLine NewMergePatchInOutLine();

        IRemoveInOutLine NewRemoveInOutLine();


	}

	public interface IDeleteInOut : ICreateOrMergePatchOrDeleteInOut
	{
	}

    public interface ICreateInOutLineCommands : IEnumerable<ICreateInOutLine>
    {
        void Add(ICreateInOutLine c);

        void Remove(ICreateInOutLine c);

        void Clear();

    }

    public interface IInOutLineCommands : IEnumerable<IInOutLineCommand>
    {
        void Add(IInOutLineCommand c);

        void Remove(IInOutLineCommand c);

        void Clear();

    }


}

