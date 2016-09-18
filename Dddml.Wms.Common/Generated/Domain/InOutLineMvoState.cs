﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

	public partial class InOutLineMvoState : InOutLineMvoStateProperties, IInOutLineMvoState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		InOutLineId IGlobalIdentity<InOutLineId>.GlobalId
		{
			get
			{
				return this.InOutLineId;
			}
		}

		#endregion



		#region IActive implementation

		bool IActive.Active
		{
			get
			{
				return this.Active;
			}
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get
			{
				return this.UpdatedBy;
			}
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get
			{
				return this.UpdatedAt;
			}
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
			get
			{
				return this.InOutVersion;
			}
		}


		#endregion

        bool IInOutLineMvoState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}

        public InOutLineMvoState() : this(null)
        {
        }

        public InOutLineMvoState(IEnumerable<IEvent> events)
        {
            InitializeProperties();

            if (events != null && events.Count() > 0)
            {
                this.InOutLineId = ((IInOutLineMvoStateEvent)events.First()).StateEventId.InOutLineId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.InOutVersion += 1;
                }
            }
        }


		public virtual void When(IInOutLineMvoStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.LineNumber = (e.LineNumber != null && e.LineNumber.HasValue) ? e.LineNumber.Value : default(long);

			this.Description = e.Description;

			this.LocatorId = e.LocatorId;

			this.Product = e.Product;

			this.UomId = e.UomId;

            this.MovementQuantity = (e.MovementQuantity != null && e.MovementQuantity.HasValue) ? e.MovementQuantity.Value : default(decimal);

            this.ConfirmedQuantity = (e.ConfirmedQuantity != null && e.ConfirmedQuantity.HasValue) ? e.ConfirmedQuantity.Value : default(decimal);

            this.ScrappedQuantity = (e.ScrappedQuantity != null && e.ScrappedQuantity.HasValue) ? e.ScrappedQuantity.Value : default(decimal);

            this.TargetQuantity = (e.TargetQuantity != null && e.TargetQuantity.HasValue) ? e.TargetQuantity.Value : default(decimal);

            this.PickedQuantity = (e.PickedQuantity != null && e.PickedQuantity.HasValue) ? e.PickedQuantity.Value : default(decimal);

            this.IsInvoiced = (e.IsInvoiced != null && e.IsInvoiced.HasValue) ? e.IsInvoiced.Value : default(bool);

			this.AttributeSetInstanceId = e.AttributeSetInstanceId;

            this.IsDescription = (e.IsDescription != null && e.IsDescription.HasValue) ? e.IsDescription.Value : default(bool);

            this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);

            this.QuantityEntered = (e.QuantityEntered != null && e.QuantityEntered.HasValue) ? e.QuantityEntered.Value : default(decimal);

            this.RmaLineNumber = (e.RmaLineNumber != null && e.RmaLineNumber.HasValue) ? e.RmaLineNumber.Value : default(long);

            this.ReversalLineNumber = (e.ReversalLineNumber != null && e.ReversalLineNumber.HasValue) ? e.ReversalLineNumber.Value : default(long);

            this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

            this.InOutIsSOTransaction = (e.InOutIsSOTransaction != null && e.InOutIsSOTransaction.HasValue) ? e.InOutIsSOTransaction.Value : default(bool);

			this.InOutDocumentStatus = e.InOutDocumentStatus;

            this.InOutPosted = (e.InOutPosted != null && e.InOutPosted.HasValue) ? e.InOutPosted.Value : default(bool);

            this.InOutProcessing = (e.InOutProcessing != null && e.InOutProcessing.HasValue) ? e.InOutProcessing.Value : default(bool);

            this.InOutProcessed = (e.InOutProcessed != null && e.InOutProcessed.HasValue) ? e.InOutProcessed.Value : default(bool);

            this.InOutDocumentType = (e.InOutDocumentType != null && e.InOutDocumentType.HasValue) ? e.InOutDocumentType.Value : default(int);

			this.InOutDescription = e.InOutDescription;

			this.InOutOrderNumber = e.InOutOrderNumber;

			this.InOutDateOrdered = e.InOutDateOrdered;

            this.InOutIsPrinted = (e.InOutIsPrinted != null && e.InOutIsPrinted.HasValue) ? e.InOutIsPrinted.Value : default(bool);

			this.InOutMovementType = e.InOutMovementType;

			this.InOutMovementDate = e.InOutMovementDate;

			this.InOutBusinessPartnerId = e.InOutBusinessPartnerId;

			this.InOutWarehouseId = e.InOutWarehouseId;

			this.InOutPOReference = e.InOutPOReference;

            this.InOutFreightAmount = (e.InOutFreightAmount != null && e.InOutFreightAmount.HasValue) ? e.InOutFreightAmount.Value : default(Money);

			this.InOutShipperId = e.InOutShipperId;

            this.InOutChargeAmount = (e.InOutChargeAmount != null && e.InOutChargeAmount.HasValue) ? e.InOutChargeAmount.Value : default(Money);

			this.InOutDatePrinted = e.InOutDatePrinted;

			this.InOutSalesRepresentative = e.InOutSalesRepresentative;

            this.InOutNumberOfPackages = (e.InOutNumberOfPackages != null && e.InOutNumberOfPackages.HasValue) ? e.InOutNumberOfPackages.Value : default(int);

			this.InOutPickDate = e.InOutPickDate;

			this.InOutShipDate = e.InOutShipDate;

			this.InOutTrackingNumber = e.InOutTrackingNumber;

			this.InOutDateReceived = e.InOutDateReceived;

            this.InOutIsInTransit = (e.InOutIsInTransit != null && e.InOutIsInTransit.HasValue) ? e.InOutIsInTransit.Value : default(bool);

            this.InOutIsApproved = (e.InOutIsApproved != null && e.InOutIsApproved.HasValue) ? e.InOutIsApproved.Value : default(bool);

            this.InOutIsInDispute = (e.InOutIsInDispute != null && e.InOutIsInDispute.HasValue) ? e.InOutIsInDispute.Value : default(bool);

            this.InOutVolume = (e.InOutVolume != null && e.InOutVolume.HasValue) ? e.InOutVolume.Value : default(decimal);

            this.InOutWeight = (e.InOutWeight != null && e.InOutWeight.HasValue) ? e.InOutWeight.Value : default(decimal);

			this.InOutRmaNumber = e.InOutRmaNumber;

			this.InOutReversalNumber = e.InOutReversalNumber;

            this.InOutIsDropShip = (e.InOutIsDropShip != null && e.InOutIsDropShip.HasValue) ? e.InOutIsDropShip.Value : default(bool);

			this.InOutDropShipBusinessPartnerId = e.InOutDropShipBusinessPartnerId;

			this.InOutCreatedBy = e.InOutCreatedBy;

            this.InOutCreatedAt = (e.InOutCreatedAt != null && e.InOutCreatedAt.HasValue) ? e.InOutCreatedAt.Value : default(DateTime);

			this.InOutUpdatedBy = e.InOutUpdatedBy;

            this.InOutUpdatedAt = (e.InOutUpdatedAt != null && e.InOutUpdatedAt.HasValue) ? e.InOutUpdatedAt.Value : default(DateTime);

            this.InOutActive = (e.InOutActive != null && e.InOutActive.HasValue) ? e.InOutActive.Value : default(bool);

            this.InOutDeleted = (e.InOutDeleted != null && e.InOutDeleted.HasValue) ? e.InOutDeleted.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IInOutLineMvoStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.LineNumber == null)
			{
				if (e.IsPropertyLineNumberRemoved)
				{
					this.LineNumber = default(long);
				}
			}
			else
			{
				this.LineNumber = (e.LineNumber != null && e.LineNumber.HasValue) ? e.LineNumber.Value : default(long);
			}

			if (e.Description == null)
			{
				if (e.IsPropertyDescriptionRemoved)
				{
					this.Description = default(string);
				}
			}
			else
			{
				this.Description = e.Description;
			}

			if (e.LocatorId == null)
			{
				if (e.IsPropertyLocatorIdRemoved)
				{
					this.LocatorId = default(string);
				}
			}
			else
			{
				this.LocatorId = e.LocatorId;
			}

			if (e.Product == null)
			{
				if (e.IsPropertyProductRemoved)
				{
					this.Product = default(string);
				}
			}
			else
			{
				this.Product = e.Product;
			}

			if (e.UomId == null)
			{
				if (e.IsPropertyUomIdRemoved)
				{
					this.UomId = default(string);
				}
			}
			else
			{
				this.UomId = e.UomId;
			}

			if (e.MovementQuantity == null)
			{
				if (e.IsPropertyMovementQuantityRemoved)
				{
					this.MovementQuantity = default(decimal);
				}
			}
			else
			{
				this.MovementQuantity = (e.MovementQuantity != null && e.MovementQuantity.HasValue) ? e.MovementQuantity.Value : default(decimal);
			}

			if (e.ConfirmedQuantity == null)
			{
				if (e.IsPropertyConfirmedQuantityRemoved)
				{
					this.ConfirmedQuantity = default(decimal);
				}
			}
			else
			{
				this.ConfirmedQuantity = (e.ConfirmedQuantity != null && e.ConfirmedQuantity.HasValue) ? e.ConfirmedQuantity.Value : default(decimal);
			}

			if (e.ScrappedQuantity == null)
			{
				if (e.IsPropertyScrappedQuantityRemoved)
				{
					this.ScrappedQuantity = default(decimal);
				}
			}
			else
			{
				this.ScrappedQuantity = (e.ScrappedQuantity != null && e.ScrappedQuantity.HasValue) ? e.ScrappedQuantity.Value : default(decimal);
			}

			if (e.TargetQuantity == null)
			{
				if (e.IsPropertyTargetQuantityRemoved)
				{
					this.TargetQuantity = default(decimal);
				}
			}
			else
			{
				this.TargetQuantity = (e.TargetQuantity != null && e.TargetQuantity.HasValue) ? e.TargetQuantity.Value : default(decimal);
			}

			if (e.PickedQuantity == null)
			{
				if (e.IsPropertyPickedQuantityRemoved)
				{
					this.PickedQuantity = default(decimal);
				}
			}
			else
			{
				this.PickedQuantity = (e.PickedQuantity != null && e.PickedQuantity.HasValue) ? e.PickedQuantity.Value : default(decimal);
			}

			if (e.IsInvoiced == null)
			{
				if (e.IsPropertyIsInvoicedRemoved)
				{
					this.IsInvoiced = default(bool);
				}
			}
			else
			{
				this.IsInvoiced = (e.IsInvoiced != null && e.IsInvoiced.HasValue) ? e.IsInvoiced.Value : default(bool);
			}

			if (e.AttributeSetInstanceId == null)
			{
				if (e.IsPropertyAttributeSetInstanceIdRemoved)
				{
					this.AttributeSetInstanceId = default(string);
				}
			}
			else
			{
				this.AttributeSetInstanceId = e.AttributeSetInstanceId;
			}

			if (e.IsDescription == null)
			{
				if (e.IsPropertyIsDescriptionRemoved)
				{
					this.IsDescription = default(bool);
				}
			}
			else
			{
				this.IsDescription = (e.IsDescription != null && e.IsDescription.HasValue) ? e.IsDescription.Value : default(bool);
			}

			if (e.Processed == null)
			{
				if (e.IsPropertyProcessedRemoved)
				{
					this.Processed = default(bool);
				}
			}
			else
			{
				this.Processed = (e.Processed != null && e.Processed.HasValue) ? e.Processed.Value : default(bool);
			}

			if (e.QuantityEntered == null)
			{
				if (e.IsPropertyQuantityEnteredRemoved)
				{
					this.QuantityEntered = default(decimal);
				}
			}
			else
			{
				this.QuantityEntered = (e.QuantityEntered != null && e.QuantityEntered.HasValue) ? e.QuantityEntered.Value : default(decimal);
			}

			if (e.RmaLineNumber == null)
			{
				if (e.IsPropertyRmaLineNumberRemoved)
				{
					this.RmaLineNumber = default(long);
				}
			}
			else
			{
				this.RmaLineNumber = (e.RmaLineNumber != null && e.RmaLineNumber.HasValue) ? e.RmaLineNumber.Value : default(long);
			}

			if (e.ReversalLineNumber == null)
			{
				if (e.IsPropertyReversalLineNumberRemoved)
				{
					this.ReversalLineNumber = default(long);
				}
			}
			else
			{
				this.ReversalLineNumber = (e.ReversalLineNumber != null && e.ReversalLineNumber.HasValue) ? e.ReversalLineNumber.Value : default(long);
			}

			if (e.Version == null)
			{
				if (e.IsPropertyVersionRemoved)
				{
					this.Version = default(long);
				}
			}
			else
			{
				this.Version = (e.Version != null && e.Version.HasValue) ? e.Version.Value : default(long);
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}

			if (e.InOutIsSOTransaction == null)
			{
				if (e.IsPropertyInOutIsSOTransactionRemoved)
				{
					this.InOutIsSOTransaction = default(bool);
				}
			}
			else
			{
				this.InOutIsSOTransaction = (e.InOutIsSOTransaction != null && e.InOutIsSOTransaction.HasValue) ? e.InOutIsSOTransaction.Value : default(bool);
			}

			if (e.InOutDocumentStatus == null)
			{
				if (e.IsPropertyInOutDocumentStatusRemoved)
				{
					this.InOutDocumentStatus = default(string);
				}
			}
			else
			{
				this.InOutDocumentStatus = e.InOutDocumentStatus;
			}

			if (e.InOutPosted == null)
			{
				if (e.IsPropertyInOutPostedRemoved)
				{
					this.InOutPosted = default(bool);
				}
			}
			else
			{
				this.InOutPosted = (e.InOutPosted != null && e.InOutPosted.HasValue) ? e.InOutPosted.Value : default(bool);
			}

			if (e.InOutProcessing == null)
			{
				if (e.IsPropertyInOutProcessingRemoved)
				{
					this.InOutProcessing = default(bool);
				}
			}
			else
			{
				this.InOutProcessing = (e.InOutProcessing != null && e.InOutProcessing.HasValue) ? e.InOutProcessing.Value : default(bool);
			}

			if (e.InOutProcessed == null)
			{
				if (e.IsPropertyInOutProcessedRemoved)
				{
					this.InOutProcessed = default(bool);
				}
			}
			else
			{
				this.InOutProcessed = (e.InOutProcessed != null && e.InOutProcessed.HasValue) ? e.InOutProcessed.Value : default(bool);
			}

			if (e.InOutDocumentType == null)
			{
				if (e.IsPropertyInOutDocumentTypeRemoved)
				{
					this.InOutDocumentType = default(int);
				}
			}
			else
			{
				this.InOutDocumentType = (e.InOutDocumentType != null && e.InOutDocumentType.HasValue) ? e.InOutDocumentType.Value : default(int);
			}

			if (e.InOutDescription == null)
			{
				if (e.IsPropertyInOutDescriptionRemoved)
				{
					this.InOutDescription = default(string);
				}
			}
			else
			{
				this.InOutDescription = e.InOutDescription;
			}

			if (e.InOutOrderNumber == null)
			{
				if (e.IsPropertyInOutOrderNumberRemoved)
				{
					this.InOutOrderNumber = default(string);
				}
			}
			else
			{
				this.InOutOrderNumber = e.InOutOrderNumber;
			}

			if (e.InOutDateOrdered == null)
			{
				if (e.IsPropertyInOutDateOrderedRemoved)
				{
					this.InOutDateOrdered = default(DateTime?);
				}
			}
			else
			{
				this.InOutDateOrdered = e.InOutDateOrdered;
			}

			if (e.InOutIsPrinted == null)
			{
				if (e.IsPropertyInOutIsPrintedRemoved)
				{
					this.InOutIsPrinted = default(bool);
				}
			}
			else
			{
				this.InOutIsPrinted = (e.InOutIsPrinted != null && e.InOutIsPrinted.HasValue) ? e.InOutIsPrinted.Value : default(bool);
			}

			if (e.InOutMovementType == null)
			{
				if (e.IsPropertyInOutMovementTypeRemoved)
				{
					this.InOutMovementType = default(string);
				}
			}
			else
			{
				this.InOutMovementType = e.InOutMovementType;
			}

			if (e.InOutMovementDate == null)
			{
				if (e.IsPropertyInOutMovementDateRemoved)
				{
					this.InOutMovementDate = default(DateTime?);
				}
			}
			else
			{
				this.InOutMovementDate = e.InOutMovementDate;
			}

			if (e.InOutBusinessPartnerId == null)
			{
				if (e.IsPropertyInOutBusinessPartnerIdRemoved)
				{
					this.InOutBusinessPartnerId = default(string);
				}
			}
			else
			{
				this.InOutBusinessPartnerId = e.InOutBusinessPartnerId;
			}

			if (e.InOutWarehouseId == null)
			{
				if (e.IsPropertyInOutWarehouseIdRemoved)
				{
					this.InOutWarehouseId = default(string);
				}
			}
			else
			{
				this.InOutWarehouseId = e.InOutWarehouseId;
			}

			if (e.InOutPOReference == null)
			{
				if (e.IsPropertyInOutPOReferenceRemoved)
				{
					this.InOutPOReference = default(string);
				}
			}
			else
			{
				this.InOutPOReference = e.InOutPOReference;
			}

			if (e.InOutFreightAmount == null)
			{
				if (e.IsPropertyInOutFreightAmountRemoved)
				{
					this.InOutFreightAmount = default(Money);
				}
			}
			else
			{
				this.InOutFreightAmount = (e.InOutFreightAmount != null && e.InOutFreightAmount.HasValue) ? e.InOutFreightAmount.Value : default(Money);
			}

			if (e.InOutShipperId == null)
			{
				if (e.IsPropertyInOutShipperIdRemoved)
				{
					this.InOutShipperId = default(string);
				}
			}
			else
			{
				this.InOutShipperId = e.InOutShipperId;
			}

			if (e.InOutChargeAmount == null)
			{
				if (e.IsPropertyInOutChargeAmountRemoved)
				{
					this.InOutChargeAmount = default(Money);
				}
			}
			else
			{
				this.InOutChargeAmount = (e.InOutChargeAmount != null && e.InOutChargeAmount.HasValue) ? e.InOutChargeAmount.Value : default(Money);
			}

			if (e.InOutDatePrinted == null)
			{
				if (e.IsPropertyInOutDatePrintedRemoved)
				{
					this.InOutDatePrinted = default(DateTime?);
				}
			}
			else
			{
				this.InOutDatePrinted = e.InOutDatePrinted;
			}

			if (e.InOutSalesRepresentative == null)
			{
				if (e.IsPropertyInOutSalesRepresentativeRemoved)
				{
					this.InOutSalesRepresentative = default(string);
				}
			}
			else
			{
				this.InOutSalesRepresentative = e.InOutSalesRepresentative;
			}

			if (e.InOutNumberOfPackages == null)
			{
				if (e.IsPropertyInOutNumberOfPackagesRemoved)
				{
					this.InOutNumberOfPackages = default(int);
				}
			}
			else
			{
				this.InOutNumberOfPackages = (e.InOutNumberOfPackages != null && e.InOutNumberOfPackages.HasValue) ? e.InOutNumberOfPackages.Value : default(int);
			}

			if (e.InOutPickDate == null)
			{
				if (e.IsPropertyInOutPickDateRemoved)
				{
					this.InOutPickDate = default(DateTime?);
				}
			}
			else
			{
				this.InOutPickDate = e.InOutPickDate;
			}

			if (e.InOutShipDate == null)
			{
				if (e.IsPropertyInOutShipDateRemoved)
				{
					this.InOutShipDate = default(DateTime?);
				}
			}
			else
			{
				this.InOutShipDate = e.InOutShipDate;
			}

			if (e.InOutTrackingNumber == null)
			{
				if (e.IsPropertyInOutTrackingNumberRemoved)
				{
					this.InOutTrackingNumber = default(string);
				}
			}
			else
			{
				this.InOutTrackingNumber = e.InOutTrackingNumber;
			}

			if (e.InOutDateReceived == null)
			{
				if (e.IsPropertyInOutDateReceivedRemoved)
				{
					this.InOutDateReceived = default(DateTime?);
				}
			}
			else
			{
				this.InOutDateReceived = e.InOutDateReceived;
			}

			if (e.InOutIsInTransit == null)
			{
				if (e.IsPropertyInOutIsInTransitRemoved)
				{
					this.InOutIsInTransit = default(bool);
				}
			}
			else
			{
				this.InOutIsInTransit = (e.InOutIsInTransit != null && e.InOutIsInTransit.HasValue) ? e.InOutIsInTransit.Value : default(bool);
			}

			if (e.InOutIsApproved == null)
			{
				if (e.IsPropertyInOutIsApprovedRemoved)
				{
					this.InOutIsApproved = default(bool);
				}
			}
			else
			{
				this.InOutIsApproved = (e.InOutIsApproved != null && e.InOutIsApproved.HasValue) ? e.InOutIsApproved.Value : default(bool);
			}

			if (e.InOutIsInDispute == null)
			{
				if (e.IsPropertyInOutIsInDisputeRemoved)
				{
					this.InOutIsInDispute = default(bool);
				}
			}
			else
			{
				this.InOutIsInDispute = (e.InOutIsInDispute != null && e.InOutIsInDispute.HasValue) ? e.InOutIsInDispute.Value : default(bool);
			}

			if (e.InOutVolume == null)
			{
				if (e.IsPropertyInOutVolumeRemoved)
				{
					this.InOutVolume = default(decimal);
				}
			}
			else
			{
				this.InOutVolume = (e.InOutVolume != null && e.InOutVolume.HasValue) ? e.InOutVolume.Value : default(decimal);
			}

			if (e.InOutWeight == null)
			{
				if (e.IsPropertyInOutWeightRemoved)
				{
					this.InOutWeight = default(decimal);
				}
			}
			else
			{
				this.InOutWeight = (e.InOutWeight != null && e.InOutWeight.HasValue) ? e.InOutWeight.Value : default(decimal);
			}

			if (e.InOutRmaNumber == null)
			{
				if (e.IsPropertyInOutRmaNumberRemoved)
				{
					this.InOutRmaNumber = default(string);
				}
			}
			else
			{
				this.InOutRmaNumber = e.InOutRmaNumber;
			}

			if (e.InOutReversalNumber == null)
			{
				if (e.IsPropertyInOutReversalNumberRemoved)
				{
					this.InOutReversalNumber = default(string);
				}
			}
			else
			{
				this.InOutReversalNumber = e.InOutReversalNumber;
			}

			if (e.InOutIsDropShip == null)
			{
				if (e.IsPropertyInOutIsDropShipRemoved)
				{
					this.InOutIsDropShip = default(bool);
				}
			}
			else
			{
				this.InOutIsDropShip = (e.InOutIsDropShip != null && e.InOutIsDropShip.HasValue) ? e.InOutIsDropShip.Value : default(bool);
			}

			if (e.InOutDropShipBusinessPartnerId == null)
			{
				if (e.IsPropertyInOutDropShipBusinessPartnerIdRemoved)
				{
					this.InOutDropShipBusinessPartnerId = default(string);
				}
			}
			else
			{
				this.InOutDropShipBusinessPartnerId = e.InOutDropShipBusinessPartnerId;
			}

			if (e.InOutCreatedBy == null)
			{
				if (e.IsPropertyInOutCreatedByRemoved)
				{
					this.InOutCreatedBy = default(string);
				}
			}
			else
			{
				this.InOutCreatedBy = e.InOutCreatedBy;
			}

			if (e.InOutCreatedAt == null)
			{
				if (e.IsPropertyInOutCreatedAtRemoved)
				{
					this.InOutCreatedAt = default(DateTime);
				}
			}
			else
			{
				this.InOutCreatedAt = (e.InOutCreatedAt != null && e.InOutCreatedAt.HasValue) ? e.InOutCreatedAt.Value : default(DateTime);
			}

			if (e.InOutUpdatedBy == null)
			{
				if (e.IsPropertyInOutUpdatedByRemoved)
				{
					this.InOutUpdatedBy = default(string);
				}
			}
			else
			{
				this.InOutUpdatedBy = e.InOutUpdatedBy;
			}

			if (e.InOutUpdatedAt == null)
			{
				if (e.IsPropertyInOutUpdatedAtRemoved)
				{
					this.InOutUpdatedAt = default(DateTime);
				}
			}
			else
			{
				this.InOutUpdatedAt = (e.InOutUpdatedAt != null && e.InOutUpdatedAt.HasValue) ? e.InOutUpdatedAt.Value : default(DateTime);
			}

			if (e.InOutActive == null)
			{
				if (e.IsPropertyInOutActiveRemoved)
				{
					this.InOutActive = default(bool);
				}
			}
			else
			{
				this.InOutActive = (e.InOutActive != null && e.InOutActive.HasValue) ? e.InOutActive.Value : default(bool);
			}

			if (e.InOutDeleted == null)
			{
				if (e.IsPropertyInOutDeletedRemoved)
				{
					this.InOutDeleted = default(bool);
				}
			}
			else
			{
				this.InOutDeleted = (e.InOutDeleted != null && e.InOutDeleted.HasValue) ? e.InOutDeleted.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IInOutLineMvoStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IInOutLineMvoStateEvent stateEvent)
		{
			var stateEntityId = this.InOutLineId; // Aggregate Id
			var eventEntityId = stateEvent.StateEventId.InOutLineId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
			if (stateEntityId != eventEntityId)
			{
				throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
			}

			var stateVersion = this.InOutVersion;
			var eventVersion = stateEvent.StateEventId.InOutVersion;
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}

