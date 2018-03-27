﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentPackageDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackage;

namespace Dddml.Wms.Domain.ShipmentPackage
{

	public abstract class ShipmentPackageContentStateEventBase : IShipmentPackageContentStateEvent
	{

		public virtual ShipmentPackageContentEventId ShipmentPackageContentEventId { get; set; }

        public virtual string ShipmentItemSeqId
        {
            get { return ShipmentPackageContentEventId.ShipmentItemSeqId; }
            set { ShipmentPackageContentEventId.ShipmentItemSeqId = value; }
        }

		public virtual decimal? Quantity { get; set; }

		public virtual string SubProductId { get; set; }

		public virtual decimal? SubProductQuantity { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentPackageContentEventId IGlobalIdentity<ShipmentPackageContentEventId>.GlobalId {
			get
			{
				return this.ShipmentPackageContentEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IShipmentPackageContentStateEvent.ReadOnly
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

        protected ShipmentPackageContentStateEventBase()
        {
        }

        protected ShipmentPackageContentStateEventBase(ShipmentPackageContentEventId stateEventId)
        {
            this.ShipmentPackageContentEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class ShipmentPackageContentStateCreated : ShipmentPackageContentStateEventBase, IShipmentPackageContentStateCreated
	{
		public ShipmentPackageContentStateCreated () : this(new ShipmentPackageContentEventId())
		{
		}

		public ShipmentPackageContentStateCreated (ShipmentPackageContentEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentPackageContentStateMergePatched : ShipmentPackageContentStateEventBase, IShipmentPackageContentStateMergePatched
	{
		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertySubProductIdRemoved { get; set; }

		public virtual bool IsPropertySubProductQuantityRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public ShipmentPackageContentStateMergePatched ()
		{
		}

		public ShipmentPackageContentStateMergePatched (ShipmentPackageContentEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ShipmentPackageContentStateRemoved : ShipmentPackageContentStateEventBase, IShipmentPackageContentStateRemoved
	{
		public ShipmentPackageContentStateRemoved ()
		{
		}

		public ShipmentPackageContentStateRemoved (ShipmentPackageContentEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

