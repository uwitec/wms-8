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

	public abstract class ShipmentReceiptImageEventBase : IShipmentReceiptImageEvent
	{

		public virtual ShipmentReceiptImageEventId ShipmentReceiptImageEventId { get; set; }

        public virtual string SequenceId
        {
            get { return ShipmentReceiptImageEventId.SequenceId; }
            set { ShipmentReceiptImageEventId.SequenceId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentReceiptImageEventId IGlobalIdentity<ShipmentReceiptImageEventId>.GlobalId {
			get
			{
				return this.ShipmentReceiptImageEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IShipmentReceiptImageEvent.ReadOnly
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

        protected ShipmentReceiptImageEventBase()
        {
        }

        protected ShipmentReceiptImageEventBase(ShipmentReceiptImageEventId stateEventId)
        {
            this.ShipmentReceiptImageEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class ShipmentReceiptImageStateEventBase : ShipmentReceiptImageEventBase, IShipmentReceiptImageStateEvent
    {

		public virtual string Url { get; set; }

		public virtual bool? Active { get; set; }

        protected ShipmentReceiptImageStateEventBase() : base()
        {
        }

        protected ShipmentReceiptImageStateEventBase(ShipmentReceiptImageEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class ShipmentReceiptImageStateCreated : ShipmentReceiptImageStateEventBase, IShipmentReceiptImageStateCreated
	{
		public ShipmentReceiptImageStateCreated () : this(new ShipmentReceiptImageEventId())
		{
		}

		public ShipmentReceiptImageStateCreated (ShipmentReceiptImageEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentReceiptImageStateMergePatched : ShipmentReceiptImageStateEventBase, IShipmentReceiptImageStateMergePatched
	{
		public virtual bool IsPropertyUrlRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public ShipmentReceiptImageStateMergePatched ()
		{
		}

		public ShipmentReceiptImageStateMergePatched (ShipmentReceiptImageEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ShipmentReceiptImageStateRemoved : ShipmentReceiptImageStateEventBase, IShipmentReceiptImageStateRemoved
	{
		public ShipmentReceiptImageStateRemoved ()
		{
		}

		public ShipmentReceiptImageStateRemoved (ShipmentReceiptImageEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

