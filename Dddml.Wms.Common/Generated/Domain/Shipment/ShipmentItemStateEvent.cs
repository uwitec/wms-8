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

	public abstract class ShipmentItemStateEventBase : IShipmentItemStateEvent
	{

		public virtual ShipmentItemEventId ShipmentItemEventId { get; set; }

        public virtual string ShipmentItemSeqId
        {
            get { return ShipmentItemEventId.ShipmentItemSeqId; }
            set { ShipmentItemEventId.ShipmentItemSeqId = value; }
        }

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual decimal? TargetQuantity { get; set; }

		public virtual string ShipmentContentDescription { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentItemEventId IGlobalIdentity<ShipmentItemEventId>.GlobalId {
			get
			{
				return this.ShipmentItemEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IShipmentItemStateEvent.ReadOnly
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

		public virtual long Version { get; set; }


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

        protected ShipmentItemStateEventBase()
        {
        }

        protected ShipmentItemStateEventBase(ShipmentItemEventId stateEventId)
        {
            this.ShipmentItemEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class ShipmentItemStateCreated : ShipmentItemStateEventBase, IShipmentItemStateCreated
	{
		public ShipmentItemStateCreated () : this(new ShipmentItemEventId())
		{
		}

		public ShipmentItemStateCreated (ShipmentItemEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentItemStateMergePatched : ShipmentItemStateEventBase, IShipmentItemStateMergePatched
	{
		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyTargetQuantityRemoved { get; set; }

		public virtual bool IsPropertyShipmentContentDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public ShipmentItemStateMergePatched ()
		{
		}

		public ShipmentItemStateMergePatched (ShipmentItemEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

