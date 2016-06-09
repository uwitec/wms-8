﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public abstract class InOutLineMvoCommandBase : IInOutLineMvoCommand
	{
		public virtual InOutLineId InOutLineId { get; set; }


		InOutLineId IAggregateCommand<InOutLineId, long>.AggregateId
		{
			get
			{
				return this.InOutLineId;
			}
		}


		long IAggregateCommand<InOutLineId, long>.AggregateVersion
		{
			get
			{
				return this.InOutVersion;
			}
		}

		public virtual long InOutVersion { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual long? LineNumber { get; set; }

		public virtual string Description { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string Product { get; set; }

		public virtual string UomId { get; set; }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual decimal? ConfirmedQuantity { get; set; }

		public virtual decimal? ScrappedQuantity { get; set; }

		public virtual decimal? TargetQuantity { get; set; }

		public virtual decimal? PickedQuantity { get; set; }

		public virtual bool? IsInvoiced { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual bool? IsDescription { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual decimal? QuantityEntered { get; set; }

		public virtual long? RmaLineNumber { get; set; }

		public virtual long? ReversalLineNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? InOutIsSOTransaction { get; set; }

		public virtual DocumentAction DocumentAction { get; set; }

		public virtual bool? InOutPosted { get; set; }

		public virtual bool? InOutProcessing { get; set; }

		public virtual bool? InOutProcessed { get; set; }

		public virtual int? InOutDocumentType { get; set; }

		public virtual string InOutDescription { get; set; }

		public virtual string InOutOrderNumber { get; set; }

		public virtual DateTime? InOutDateOrdered { get; set; }

		public virtual bool? InOutIsPrinted { get; set; }

		public virtual string InOutMovementType { get; set; }

		public virtual DateTime? InOutMovementDate { get; set; }

		public virtual string InOutBusinessPartnerId { get; set; }

		public virtual string InOutWarehouseId { get; set; }

		public virtual string InOutPOReference { get; set; }

		public virtual decimal? InOutFreightAmount { get; set; }

		public virtual string InOutShipperId { get; set; }

		public virtual decimal? InOutChargeAmount { get; set; }

		public virtual DateTime? InOutDatePrinted { get; set; }

		public virtual string InOutSalesRepresentative { get; set; }

		public virtual int? InOutNumberOfPackages { get; set; }

		public virtual DateTime? InOutPickDate { get; set; }

		public virtual DateTime? InOutShipDate { get; set; }

		public virtual string InOutTrackingNumber { get; set; }

		public virtual DateTime? InOutDateReceived { get; set; }

		public virtual bool? InOutIsInTransit { get; set; }

		public virtual bool? InOutIsApproved { get; set; }

		public virtual bool? InOutIsInDispute { get; set; }

		public virtual decimal? InOutVolume { get; set; }

		public virtual decimal? InOutWeight { get; set; }

		public virtual string InOutRmaNumber { get; set; }

		public virtual string InOutReversalNumber { get; set; }

		public virtual bool? InOutIsDropShip { get; set; }

		public virtual string InOutDropShipBusinessPartnerId { get; set; }

		public virtual string InOutCreatedBy { get; set; }

		public virtual DateTime? InOutCreatedAt { get; set; }

		public virtual string InOutUpdatedBy { get; set; }

		public virtual DateTime? InOutUpdatedAt { get; set; }

		public virtual bool? InOutActive { get; set; }

		public virtual bool? InOutDeleted { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


    public abstract class InOutLineMvoIdGeneratorBase : IIdGenerator<InOutLineId, ICreateInOutLineMvo>
    {
        public abstract InOutLineId GenerateId(ICreateInOutLineMvo command);

        public abstract InOutLineId GetNextId();

        public virtual InOutLineId GetOrGenerateId(ICreateInOutLineMvo command, out bool reused)
        {
            throw new NotSupportedException();
        }

    }

	public class CreateInOutLineMvo : InOutLineMvoCommandBase, ICreateInOutLineMvo
	{
		
		public CreateInOutLineMvo ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchInOutLineMvo :InOutLineMvoCommandBase, IMergePatchInOutLineMvo
	{

		public virtual bool IsPropertyLineNumberRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdRemoved { get; set; }

		public virtual bool IsPropertyProductRemoved { get; set; }

		public virtual bool IsPropertyUomIdRemoved { get; set; }

		public virtual bool IsPropertyMovementQuantityRemoved { get; set; }

		public virtual bool IsPropertyConfirmedQuantityRemoved { get; set; }

		public virtual bool IsPropertyScrappedQuantityRemoved { get; set; }

		public virtual bool IsPropertyTargetQuantityRemoved { get; set; }

		public virtual bool IsPropertyPickedQuantityRemoved { get; set; }

		public virtual bool IsPropertyIsInvoicedRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyIsDescriptionRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyQuantityEnteredRemoved { get; set; }

		public virtual bool IsPropertyRmaLineNumberRemoved { get; set; }

		public virtual bool IsPropertyReversalLineNumberRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyInOutIsSOTransactionRemoved { get; set; }

		public virtual bool IsPropertyInOutPostedRemoved { get; set; }

		public virtual bool IsPropertyInOutProcessingRemoved { get; set; }

		public virtual bool IsPropertyInOutProcessedRemoved { get; set; }

		public virtual bool IsPropertyInOutDocumentTypeRemoved { get; set; }

		public virtual bool IsPropertyInOutDescriptionRemoved { get; set; }

		public virtual bool IsPropertyInOutOrderNumberRemoved { get; set; }

		public virtual bool IsPropertyInOutDateOrderedRemoved { get; set; }

		public virtual bool IsPropertyInOutIsPrintedRemoved { get; set; }

		public virtual bool IsPropertyInOutMovementTypeRemoved { get; set; }

		public virtual bool IsPropertyInOutMovementDateRemoved { get; set; }

		public virtual bool IsPropertyInOutBusinessPartnerIdRemoved { get; set; }

		public virtual bool IsPropertyInOutWarehouseIdRemoved { get; set; }

		public virtual bool IsPropertyInOutPOReferenceRemoved { get; set; }

		public virtual bool IsPropertyInOutFreightAmountRemoved { get; set; }

		public virtual bool IsPropertyInOutShipperIdRemoved { get; set; }

		public virtual bool IsPropertyInOutChargeAmountRemoved { get; set; }

		public virtual bool IsPropertyInOutDatePrintedRemoved { get; set; }

		public virtual bool IsPropertyInOutSalesRepresentativeRemoved { get; set; }

		public virtual bool IsPropertyInOutNumberOfPackagesRemoved { get; set; }

		public virtual bool IsPropertyInOutPickDateRemoved { get; set; }

		public virtual bool IsPropertyInOutShipDateRemoved { get; set; }

		public virtual bool IsPropertyInOutTrackingNumberRemoved { get; set; }

		public virtual bool IsPropertyInOutDateReceivedRemoved { get; set; }

		public virtual bool IsPropertyInOutIsInTransitRemoved { get; set; }

		public virtual bool IsPropertyInOutIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyInOutIsInDisputeRemoved { get; set; }

		public virtual bool IsPropertyInOutVolumeRemoved { get; set; }

		public virtual bool IsPropertyInOutWeightRemoved { get; set; }

		public virtual bool IsPropertyInOutRmaNumberRemoved { get; set; }

		public virtual bool IsPropertyInOutReversalNumberRemoved { get; set; }

		public virtual bool IsPropertyInOutIsDropShipRemoved { get; set; }

		public virtual bool IsPropertyInOutDropShipBusinessPartnerIdRemoved { get; set; }

		public virtual bool IsPropertyInOutCreatedByRemoved { get; set; }

		public virtual bool IsPropertyInOutCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyInOutUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyInOutUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyInOutActiveRemoved { get; set; }

		public virtual bool IsPropertyInOutDeletedRemoved { get; set; }


		public MergePatchInOutLineMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteInOutLineMvo : InOutLineMvoCommandBase, IDeleteInOutLineMvo
	{
		public DeleteInOutLineMvo ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}



}
