﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutLineMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOutLineMvo
{

	public abstract class InOutLineMvoStateEventBase : IInOutLineMvoStateEvent
	{

		public virtual InOutLineMvoEventId InOutLineMvoEventId { get; set; }

        public virtual InOutLineId InOutLineId
        {
            get { return InOutLineMvoEventId.InOutLineId; }
            set { InOutLineMvoEventId.InOutLineId = value; }
        }

		public virtual string LocatorId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string Description { get; set; }

		public virtual string QuantityUomId { get; set; }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual decimal? PickedQuantity { get; set; }

		public virtual bool? IsInvoiced { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string RmaLineNumber { get; set; }

		public virtual string ReversalLineNumber { get; set; }

		public virtual long? Version { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string InOutDocumentStatusId { get; set; }

		public virtual bool? InOutPosted { get; set; }

		public virtual bool? InOutProcessed { get; set; }

		public virtual string InOutProcessing { get; set; }

		public virtual string InOutDocumentTypeId { get; set; }

		public virtual string InOutDescription { get; set; }

		public virtual string InOutOrderId { get; set; }

		public virtual DateTime? InOutDateOrdered { get; set; }

		public virtual bool? InOutIsPrinted { get; set; }

		public virtual string InOutMovementTypeId { get; set; }

		public virtual DateTime? InOutMovementDate { get; set; }

		public virtual string InOutBusinessPartnerId { get; set; }

		public virtual string InOutWarehouseId { get; set; }

		public virtual string InOutPOReference { get; set; }

		public virtual decimal? InOutFreightAmount { get; set; }

		public virtual string InOutShipperId { get; set; }

		public virtual decimal? InOutChargeAmount { get; set; }

		public virtual DateTime? InOutDatePrinted { get; set; }

		public virtual string InOutCreatedFrom { get; set; }

		public virtual string InOutSalesRepresentativeId { get; set; }

		public virtual int? InOutNumberOfPackages { get; set; }

		public virtual DateTime? InOutPickDate { get; set; }

		public virtual DateTime? InOutShipDate { get; set; }

		public virtual string InOutTrackingNumber { get; set; }

		public virtual DateTime? InOutDateReceived { get; set; }

		public virtual bool? InOutIsInTransit { get; set; }

		public virtual bool? InOutIsApproved { get; set; }

		public virtual bool? InOutIsInDispute { get; set; }

		public virtual string InOutRmaDocumentNumber { get; set; }

		public virtual string InOutReversalDocumentNumber { get; set; }

		public virtual string InOutCreatedBy { get; set; }

		public virtual DateTime? InOutCreatedAt { get; set; }

		public virtual string InOutUpdatedBy { get; set; }

		public virtual DateTime? InOutUpdatedAt { get; set; }

		public virtual bool? InOutActive { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		InOutLineMvoEventId IGlobalIdentity<InOutLineMvoEventId>.GlobalId {
			get
			{
				return this.InOutLineMvoEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IInOutLineMvoStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }


		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}

        protected InOutLineMvoStateEventBase()
        {
        }

        protected InOutLineMvoStateEventBase(InOutLineMvoEventId stateEventId)
        {
            this.InOutLineMvoEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class InOutLineMvoStateCreated : InOutLineMvoStateEventBase, IInOutLineMvoStateCreated
	{
		public InOutLineMvoStateCreated () : this(new InOutLineMvoEventId())
		{
		}

		public InOutLineMvoStateCreated (InOutLineMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class InOutLineMvoStateMergePatched : InOutLineMvoStateEventBase, IInOutLineMvoStateMergePatched
	{
		public virtual bool IsPropertyLocatorIdRemoved { get; set; }

		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyQuantityUomIdRemoved { get; set; }

		public virtual bool IsPropertyMovementQuantityRemoved { get; set; }

		public virtual bool IsPropertyPickedQuantityRemoved { get; set; }

		public virtual bool IsPropertyIsInvoicedRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyRmaLineNumberRemoved { get; set; }

		public virtual bool IsPropertyReversalLineNumberRemoved { get; set; }

		public virtual bool IsPropertyVersionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }

		public virtual bool IsPropertyInOutDocumentStatusIdRemoved { get; set; }

		public virtual bool IsPropertyInOutPostedRemoved { get; set; }

		public virtual bool IsPropertyInOutProcessedRemoved { get; set; }

		public virtual bool IsPropertyInOutProcessingRemoved { get; set; }

		public virtual bool IsPropertyInOutDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyInOutDescriptionRemoved { get; set; }

		public virtual bool IsPropertyInOutOrderIdRemoved { get; set; }

		public virtual bool IsPropertyInOutDateOrderedRemoved { get; set; }

		public virtual bool IsPropertyInOutIsPrintedRemoved { get; set; }

		public virtual bool IsPropertyInOutMovementTypeIdRemoved { get; set; }

		public virtual bool IsPropertyInOutMovementDateRemoved { get; set; }

		public virtual bool IsPropertyInOutBusinessPartnerIdRemoved { get; set; }

		public virtual bool IsPropertyInOutWarehouseIdRemoved { get; set; }

		public virtual bool IsPropertyInOutPOReferenceRemoved { get; set; }

		public virtual bool IsPropertyInOutFreightAmountRemoved { get; set; }

		public virtual bool IsPropertyInOutShipperIdRemoved { get; set; }

		public virtual bool IsPropertyInOutChargeAmountRemoved { get; set; }

		public virtual bool IsPropertyInOutDatePrintedRemoved { get; set; }

		public virtual bool IsPropertyInOutCreatedFromRemoved { get; set; }

		public virtual bool IsPropertyInOutSalesRepresentativeIdRemoved { get; set; }

		public virtual bool IsPropertyInOutNumberOfPackagesRemoved { get; set; }

		public virtual bool IsPropertyInOutPickDateRemoved { get; set; }

		public virtual bool IsPropertyInOutShipDateRemoved { get; set; }

		public virtual bool IsPropertyInOutTrackingNumberRemoved { get; set; }

		public virtual bool IsPropertyInOutDateReceivedRemoved { get; set; }

		public virtual bool IsPropertyInOutIsInTransitRemoved { get; set; }

		public virtual bool IsPropertyInOutIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyInOutIsInDisputeRemoved { get; set; }

		public virtual bool IsPropertyInOutRmaDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyInOutReversalDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyInOutCreatedByRemoved { get; set; }

		public virtual bool IsPropertyInOutCreatedAtRemoved { get; set; }

		public virtual bool IsPropertyInOutUpdatedByRemoved { get; set; }

		public virtual bool IsPropertyInOutUpdatedAtRemoved { get; set; }

		public virtual bool IsPropertyInOutActiveRemoved { get; set; }


		public InOutLineMvoStateMergePatched ()
		{
		}

		public InOutLineMvoStateMergePatched (InOutLineMvoEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class InOutLineMvoStateDeleted : InOutLineMvoStateEventBase, IInOutLineMvoStateDeleted
	{
		public InOutLineMvoStateDeleted ()
		{
		}

		public InOutLineMvoStateDeleted (InOutLineMvoEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }



	}



}

