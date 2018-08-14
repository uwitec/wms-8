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

	public abstract class ShipmentStateEventDtoBase : IEventDto, IShipmentStateCreated, IShipmentStateMergePatched
	{

        private ShipmentEventId _shipmentEventId;

		protected internal virtual ShipmentEventId ShipmentEventId 
        {
            get 
            {
                if (_shipmentEventId == null) { _shipmentEventId = new ShipmentEventId(); }
                return _shipmentEventId;
            }
            set
            {
                _shipmentEventId = value;
            }
        }

        public virtual string ShipmentId
        {
            get { return ShipmentEventId.ShipmentId; }
            set { ShipmentEventId.ShipmentId = value; }
        }

        public virtual long Version
        {
            get { return ShipmentEventId.Version; }
            set { ShipmentEventId.Version = value; }
        }

		public virtual string ShipmentTypeId { get; set; }

		public virtual string StatusId { get; set; }

		public virtual string PrimaryOrderId { get; set; }

		public virtual string PrimaryReturnId { get; set; }

		public virtual long? PrimaryShipGroupSeqId { get; set; }

		public virtual string PicklistBinId { get; set; }

		public virtual string BolNumber { get; set; }

		public virtual string SealNumber { get; set; }

		public virtual string VehicleId { get; set; }

		public virtual string PoNumber { get; set; }

		public virtual string Carrier { get; set; }

		public virtual DateTime? DateShipped { get; set; }

		public virtual DateTime? EstimatedReadyDate { get; set; }

		public virtual DateTime? EstimatedShipDate { get; set; }

		public virtual string EstimatedShipWorkEffId { get; set; }

		public virtual DateTime? EstimatedArrivalDate { get; set; }

		public virtual string EstimatedArrivalWorkEffId { get; set; }

		public virtual DateTime? LatestCancelDate { get; set; }

		public virtual decimal? EstimatedShipCost { get; set; }

		public virtual string CurrencyUomId { get; set; }

		public virtual string HandlingInstructions { get; set; }

		public virtual string OriginFacilityId { get; set; }

		public virtual string DestinationFacilityId { get; set; }

		public virtual string OriginContactMechId { get; set; }

		public virtual string OriginTelecomNumberId { get; set; }

		public virtual string DestinationContactMechId { get; set; }

		public virtual string DestinationTelecomNumberId { get; set; }

		public virtual string PartyIdTo { get; set; }

		public virtual string PartyIdFrom { get; set; }

		public virtual decimal? AdditionalShippingCharge { get; set; }

		public virtual string AddtlShippingChargeDesc { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentEventId IGlobalIdentity<ShipmentEventId>.GlobalId {
			get 
			{
				return this.ShipmentEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IShipmentEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyShipmentTypeIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyShipmentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyStatusIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryOrderIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyPrimaryOrderIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPrimaryOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPrimaryOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryReturnIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyPrimaryReturnIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPrimaryReturnIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPrimaryReturnIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryShipGroupSeqIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyPrimaryShipGroupSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPrimaryShipGroupSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPrimaryShipGroupSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPicklistBinIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyPicklistBinIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPicklistBinIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPicklistBinIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyBolNumberRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyBolNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyBolNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyBolNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertySealNumberRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertySealNumberRemoved
        {
            get 
            {
                var b = this.IsPropertySealNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySealNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyVehicleIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyVehicleIdRemoved
        {
            get 
            {
                var b = this.IsPropertyVehicleIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyVehicleIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPoNumberRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyPoNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyPoNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPoNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyCarrierRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyCarrierRemoved
        {
            get 
            {
                var b = this.IsPropertyCarrierRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCarrierRemoved = value;
            }
        }

		public virtual bool? IsPropertyDateShippedRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyDateShippedRemoved
        {
            get 
            {
                var b = this.IsPropertyDateShippedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDateShippedRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedReadyDateRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyEstimatedReadyDateRemoved
        {
            get 
            {
                var b = this.IsPropertyEstimatedReadyDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyEstimatedReadyDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedShipDateRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyEstimatedShipDateRemoved
        {
            get 
            {
                var b = this.IsPropertyEstimatedShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyEstimatedShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedShipWorkEffIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyEstimatedShipWorkEffIdRemoved
        {
            get 
            {
                var b = this.IsPropertyEstimatedShipWorkEffIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyEstimatedShipWorkEffIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedArrivalDateRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyEstimatedArrivalDateRemoved
        {
            get 
            {
                var b = this.IsPropertyEstimatedArrivalDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyEstimatedArrivalDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedArrivalWorkEffIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyEstimatedArrivalWorkEffIdRemoved
        {
            get 
            {
                var b = this.IsPropertyEstimatedArrivalWorkEffIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyEstimatedArrivalWorkEffIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLatestCancelDateRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyLatestCancelDateRemoved
        {
            get 
            {
                var b = this.IsPropertyLatestCancelDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLatestCancelDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedShipCostRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyEstimatedShipCostRemoved
        {
            get 
            {
                var b = this.IsPropertyEstimatedShipCostRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyEstimatedShipCostRemoved = value;
            }
        }

		public virtual bool? IsPropertyCurrencyUomIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyCurrencyUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyCurrencyUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCurrencyUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyHandlingInstructionsRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyHandlingInstructionsRemoved
        {
            get 
            {
                var b = this.IsPropertyHandlingInstructionsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyHandlingInstructionsRemoved = value;
            }
        }

		public virtual bool? IsPropertyOriginFacilityIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyOriginFacilityIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOriginFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOriginFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDestinationFacilityIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyDestinationFacilityIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDestinationFacilityIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDestinationFacilityIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOriginContactMechIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyOriginContactMechIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOriginContactMechIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOriginContactMechIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOriginTelecomNumberIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyOriginTelecomNumberIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOriginTelecomNumberIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOriginTelecomNumberIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDestinationContactMechIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyDestinationContactMechIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDestinationContactMechIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDestinationContactMechIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDestinationTelecomNumberIdRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyDestinationTelecomNumberIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDestinationTelecomNumberIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDestinationTelecomNumberIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPartyIdToRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyPartyIdToRemoved
        {
            get 
            {
                var b = this.IsPropertyPartyIdToRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPartyIdToRemoved = value;
            }
        }

		public virtual bool? IsPropertyPartyIdFromRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyPartyIdFromRemoved
        {
            get 
            {
                var b = this.IsPropertyPartyIdFromRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPartyIdFromRemoved = value;
            }
        }

		public virtual bool? IsPropertyAdditionalShippingChargeRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyAdditionalShippingChargeRemoved
        {
            get 
            {
                var b = this.IsPropertyAdditionalShippingChargeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAdditionalShippingChargeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAddtlShippingChargeDescRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyAddtlShippingChargeDescRemoved
        {
            get 
            {
                var b = this.IsPropertyAddtlShippingChargeDescRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAddtlShippingChargeDescRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IShipmentStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
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


        private ShipmentImageStateCreatedOrMergePatchedOrRemovedDtos _shipmentImageEvents = new ShipmentImageStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual ShipmentImageStateCreatedOrMergePatchedOrRemovedDto[] ShipmentImageEvents
        {
            get
            {
                return _shipmentImageEvents.ToArray();
            }
            set
            {
                _shipmentImageEvents.Clear();
                _shipmentImageEvents.AddRange(value);
            }
        }



        private ShipmentImageEventId NewShipmentImageEventId(string sequenceId)
        {
            var eId = new ShipmentImageEventId();
            eId.ShipmentId = this.ShipmentEventId.ShipmentId;
            eId.SequenceId = sequenceId;
            eId.ShipmentVersion = this.ShipmentEventId.Version;
            return eId;
        }

        public virtual ShipmentImageStateCreatedDto NewShipmentImageStateCreated(string sequenceId)
        {
            var e = new ShipmentImageStateCreatedDto();
            var eId = NewShipmentImageEventId(sequenceId);
            e.ShipmentImageEventId = eId;
            return e;
        }

        public virtual ShipmentImageStateMergePatchedDto NewShipmentImageStateMergePatched(string sequenceId)
        {
            var e = new ShipmentImageStateMergePatchedDto();
            var eId = NewShipmentImageEventId(sequenceId);
            e.ShipmentImageEventId = eId;
            return e;
        }

        public virtual ShipmentImageStateRemovedDto NewShipmentImageStateRemoved(string sequenceId)
        {
            var e = new ShipmentImageStateRemovedDto();
            var eId = NewShipmentImageEventId(sequenceId);
            e.ShipmentImageEventId = eId;
            return e;
        }

        IEnumerable<IShipmentImageStateCreated> IShipmentStateCreated.ShipmentImageEvents
        {
            get { return this._shipmentImageEvents; }
        }

        void IShipmentStateCreated.AddShipmentImageEvent(IShipmentImageStateCreated e)
        {
            this._shipmentImageEvents.AddShipmentImageEvent(e);
        }

        IShipmentImageStateCreated IShipmentStateCreated.NewShipmentImageStateCreated(string sequenceId)
        {
            return NewShipmentImageStateCreated(sequenceId);
        }

        IEnumerable<IShipmentImageEvent> IShipmentStateMergePatched.ShipmentImageEvents
        {
            get { return this._shipmentImageEvents; }
        }

        void IShipmentStateMergePatched.AddShipmentImageEvent(IShipmentImageEvent e)
        {
            this._shipmentImageEvents.AddShipmentImageEvent(e);
        }

        IShipmentImageStateCreated IShipmentStateMergePatched.NewShipmentImageStateCreated(string sequenceId)
        {
            return NewShipmentImageStateCreated(sequenceId);
        }

        IShipmentImageStateMergePatched IShipmentStateMergePatched.NewShipmentImageStateMergePatched(string sequenceId)
        {
            return NewShipmentImageStateMergePatched(sequenceId);
        }

        IShipmentImageStateRemoved IShipmentStateMergePatched.NewShipmentImageStateRemoved(string sequenceId)
        {
            return NewShipmentImageStateRemoved(sequenceId);
        }


        private ShipmentItemStateCreatedOrMergePatchedOrRemovedDtos _shipmentItemEvents = new ShipmentItemStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual ShipmentItemStateCreatedOrMergePatchedOrRemovedDto[] ShipmentItemEvents
        {
            get
            {
                return _shipmentItemEvents.ToArray();
            }
            set
            {
                _shipmentItemEvents.Clear();
                _shipmentItemEvents.AddRange(value);
            }
        }



        private ShipmentItemEventId NewShipmentItemEventId(string shipmentItemSeqId)
        {
            var eId = new ShipmentItemEventId();
            eId.ShipmentId = this.ShipmentEventId.ShipmentId;
            eId.ShipmentItemSeqId = shipmentItemSeqId;
            eId.ShipmentVersion = this.ShipmentEventId.Version;
            return eId;
        }

        public virtual ShipmentItemStateCreatedDto NewShipmentItemStateCreated(string shipmentItemSeqId)
        {
            var e = new ShipmentItemStateCreatedDto();
            var eId = NewShipmentItemEventId(shipmentItemSeqId);
            e.ShipmentItemEventId = eId;
            return e;
        }

        public virtual ShipmentItemStateMergePatchedDto NewShipmentItemStateMergePatched(string shipmentItemSeqId)
        {
            var e = new ShipmentItemStateMergePatchedDto();
            var eId = NewShipmentItemEventId(shipmentItemSeqId);
            e.ShipmentItemEventId = eId;
            return e;
        }

        IEnumerable<IShipmentItemStateCreated> IShipmentStateCreated.ShipmentItemEvents
        {
            get { return this._shipmentItemEvents; }
        }

        void IShipmentStateCreated.AddShipmentItemEvent(IShipmentItemStateCreated e)
        {
            this._shipmentItemEvents.AddShipmentItemEvent(e);
        }

        IShipmentItemStateCreated IShipmentStateCreated.NewShipmentItemStateCreated(string shipmentItemSeqId)
        {
            return NewShipmentItemStateCreated(shipmentItemSeqId);
        }

        IEnumerable<IShipmentItemEvent> IShipmentStateMergePatched.ShipmentItemEvents
        {
            get { return this._shipmentItemEvents; }
        }

        void IShipmentStateMergePatched.AddShipmentItemEvent(IShipmentItemEvent e)
        {
            this._shipmentItemEvents.AddShipmentItemEvent(e);
        }

        IShipmentItemStateCreated IShipmentStateMergePatched.NewShipmentItemStateCreated(string shipmentItemSeqId)
        {
            return NewShipmentItemStateCreated(shipmentItemSeqId);
        }

        IShipmentItemStateMergePatched IShipmentStateMergePatched.NewShipmentItemStateMergePatched(string shipmentItemSeqId)
        {
            return NewShipmentItemStateMergePatched(shipmentItemSeqId);
        }


        private ShipmentReceiptStateCreatedOrMergePatchedOrRemovedDtos _shipmentReceiptEvents = new ShipmentReceiptStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual ShipmentReceiptStateCreatedOrMergePatchedOrRemovedDto[] ShipmentReceiptEvents
        {
            get
            {
                return _shipmentReceiptEvents.ToArray();
            }
            set
            {
                _shipmentReceiptEvents.Clear();
                _shipmentReceiptEvents.AddRange(value);
            }
        }



        private ShipmentReceiptEventId NewShipmentReceiptEventId(string receiptSeqId)
        {
            var eId = new ShipmentReceiptEventId();
            eId.ShipmentId = this.ShipmentEventId.ShipmentId;
            eId.ReceiptSeqId = receiptSeqId;
            eId.ShipmentVersion = this.ShipmentEventId.Version;
            return eId;
        }

        public virtual ShipmentReceiptStateCreatedDto NewShipmentReceiptStateCreated(string receiptSeqId)
        {
            var e = new ShipmentReceiptStateCreatedDto();
            var eId = NewShipmentReceiptEventId(receiptSeqId);
            e.ShipmentReceiptEventId = eId;
            return e;
        }

        public virtual ShipmentReceiptStateMergePatchedDto NewShipmentReceiptStateMergePatched(string receiptSeqId)
        {
            var e = new ShipmentReceiptStateMergePatchedDto();
            var eId = NewShipmentReceiptEventId(receiptSeqId);
            e.ShipmentReceiptEventId = eId;
            return e;
        }

        IEnumerable<IShipmentReceiptStateCreated> IShipmentStateCreated.ShipmentReceiptEvents
        {
            get { return this._shipmentReceiptEvents; }
        }

        void IShipmentStateCreated.AddShipmentReceiptEvent(IShipmentReceiptStateCreated e)
        {
            this._shipmentReceiptEvents.AddShipmentReceiptEvent(e);
        }

        IShipmentReceiptStateCreated IShipmentStateCreated.NewShipmentReceiptStateCreated(string receiptSeqId)
        {
            return NewShipmentReceiptStateCreated(receiptSeqId);
        }

        IEnumerable<IShipmentReceiptEvent> IShipmentStateMergePatched.ShipmentReceiptEvents
        {
            get { return this._shipmentReceiptEvents; }
        }

        void IShipmentStateMergePatched.AddShipmentReceiptEvent(IShipmentReceiptEvent e)
        {
            this._shipmentReceiptEvents.AddShipmentReceiptEvent(e);
        }

        IShipmentReceiptStateCreated IShipmentStateMergePatched.NewShipmentReceiptStateCreated(string receiptSeqId)
        {
            return NewShipmentReceiptStateCreated(receiptSeqId);
        }

        IShipmentReceiptStateMergePatched IShipmentStateMergePatched.NewShipmentReceiptStateMergePatched(string receiptSeqId)
        {
            return NewShipmentReceiptStateMergePatched(receiptSeqId);
        }


        private ItemIssuanceStateCreatedOrMergePatchedOrRemovedDtos _itemIssuanceEvents = new ItemIssuanceStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto[] ItemIssuanceEvents
        {
            get
            {
                return _itemIssuanceEvents.ToArray();
            }
            set
            {
                _itemIssuanceEvents.Clear();
                _itemIssuanceEvents.AddRange(value);
            }
        }



        private ItemIssuanceEventId NewItemIssuanceEventId(string itemIssuanceSeqId)
        {
            var eId = new ItemIssuanceEventId();
            eId.ShipmentId = this.ShipmentEventId.ShipmentId;
            eId.ItemIssuanceSeqId = itemIssuanceSeqId;
            eId.ShipmentVersion = this.ShipmentEventId.Version;
            return eId;
        }

        public virtual ItemIssuanceStateCreatedDto NewItemIssuanceStateCreated(string itemIssuanceSeqId)
        {
            var e = new ItemIssuanceStateCreatedDto();
            var eId = NewItemIssuanceEventId(itemIssuanceSeqId);
            e.ItemIssuanceEventId = eId;
            return e;
        }

        public virtual ItemIssuanceStateMergePatchedDto NewItemIssuanceStateMergePatched(string itemIssuanceSeqId)
        {
            var e = new ItemIssuanceStateMergePatchedDto();
            var eId = NewItemIssuanceEventId(itemIssuanceSeqId);
            e.ItemIssuanceEventId = eId;
            return e;
        }

        public virtual ItemIssuanceStateRemovedDto NewItemIssuanceStateRemoved(string itemIssuanceSeqId)
        {
            var e = new ItemIssuanceStateRemovedDto();
            var eId = NewItemIssuanceEventId(itemIssuanceSeqId);
            e.ItemIssuanceEventId = eId;
            return e;
        }

        IEnumerable<IItemIssuanceStateCreated> IShipmentStateCreated.ItemIssuanceEvents
        {
            get { return this._itemIssuanceEvents; }
        }

        void IShipmentStateCreated.AddItemIssuanceEvent(IItemIssuanceStateCreated e)
        {
            this._itemIssuanceEvents.AddItemIssuanceEvent(e);
        }

        IItemIssuanceStateCreated IShipmentStateCreated.NewItemIssuanceStateCreated(string itemIssuanceSeqId)
        {
            return NewItemIssuanceStateCreated(itemIssuanceSeqId);
        }

        IEnumerable<IItemIssuanceEvent> IShipmentStateMergePatched.ItemIssuanceEvents
        {
            get { return this._itemIssuanceEvents; }
        }

        void IShipmentStateMergePatched.AddItemIssuanceEvent(IItemIssuanceEvent e)
        {
            this._itemIssuanceEvents.AddItemIssuanceEvent(e);
        }

        IItemIssuanceStateCreated IShipmentStateMergePatched.NewItemIssuanceStateCreated(string itemIssuanceSeqId)
        {
            return NewItemIssuanceStateCreated(itemIssuanceSeqId);
        }

        IItemIssuanceStateMergePatched IShipmentStateMergePatched.NewItemIssuanceStateMergePatched(string itemIssuanceSeqId)
        {
            return NewItemIssuanceStateMergePatched(itemIssuanceSeqId);
        }

        IItemIssuanceStateRemoved IShipmentStateMergePatched.NewItemIssuanceStateRemoved(string itemIssuanceSeqId)
        {
            return NewItemIssuanceStateRemoved(itemIssuanceSeqId);
        }


        ShipmentEventId IShipmentEvent.ShipmentEventId
        {
            get { return this.ShipmentEventId; }
        }

        protected ShipmentStateEventDtoBase()
        {
        }

        protected ShipmentStateEventDtoBase(ShipmentEventId stateEventId)
        {
            this.ShipmentEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class ShipmentStateCreatedOrMergePatchedOrDeletedDto : ShipmentStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetEventType()
        {
            return this._eventType;
        }

    }



	public class ShipmentStateCreatedDto : ShipmentStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentStateCreatedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentStateMergePatchedDto : ShipmentStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentStateMergePatchedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ShipmentStateDeletedDto : ShipmentStateCreatedOrMergePatchedOrDeletedDto
	{
		public ShipmentStateDeletedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class ShipmentStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IShipmentStateCreated>, IEnumerable<IShipmentStateMergePatched>
    {
        private List<ShipmentStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<ShipmentStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual ShipmentStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<ShipmentStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentStateCreated> IEnumerable<IShipmentStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IShipmentStateMergePatched> IEnumerable<IShipmentStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddShipmentEvent(IShipmentStateCreated e)
        {
            _innerStateEvents.Add((ShipmentStateCreatedDto)e);
        }

        public void AddShipmentEvent(IShipmentEvent e)
        {
            _innerStateEvents.Add((ShipmentStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

