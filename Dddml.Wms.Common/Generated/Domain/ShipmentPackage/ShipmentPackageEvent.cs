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

	public abstract class ShipmentPackageEventBase : IShipmentPackageEvent
	{

		public virtual ShipmentPackageEventId ShipmentPackageEventId { get; set; }

        public virtual ShipmentPackageId ShipmentPackageId
        {
            get { return ShipmentPackageEventId.ShipmentPackageId; }
            set { ShipmentPackageEventId.ShipmentPackageId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ShipmentPackageEventId IGlobalIdentity<ShipmentPackageEventId>.GlobalId {
			get
			{
				return this.ShipmentPackageEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IShipmentPackageEvent.ReadOnly
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

        protected ShipmentPackageEventBase()
        {
        }

        protected ShipmentPackageEventBase(ShipmentPackageEventId stateEventId)
        {
            this.ShipmentPackageEventId = stateEventId;
        }

		protected IShipmentPackageContentEventDao ShipmentPackageContentEventDao
		{
			get { return ApplicationContext.Current["ShipmentPackageContentEventDao"] as IShipmentPackageContentEventDao; }
		}

        protected ShipmentPackageContentEventId NewShipmentPackageContentEventId(string shipmentItemSeqId)
        {
            var stateEventId = new ShipmentPackageContentEventId(this.ShipmentPackageEventId.ShipmentPackageId, shipmentItemSeqId, this.ShipmentPackageEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IShipmentPackageContentEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IShipmentPackageEvent oe, IShipmentPackageContentEvent e)
		{
			if (!oe.ShipmentPackageEventId.ShipmentPackageId.Equals(e.ShipmentPackageContentEventId.ShipmentPackageId))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id ShipmentPackageId {0} but inner id ShipmentPackageId {1}", 
					oe.ShipmentPackageEventId.ShipmentPackageId, e.ShipmentPackageContentEventId.ShipmentPackageId);
			}
		}



        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class ShipmentPackageStateEventBase : ShipmentPackageEventBase, IShipmentPackageStateEvent
    {

		public virtual string ShipmentBoxTypeId { get; set; }

		public virtual DateTime? DateCreated { get; set; }

		public virtual decimal? BoxLength { get; set; }

		public virtual decimal? BoxHeight { get; set; }

		public virtual decimal? BoxWidth { get; set; }

		public virtual string DimensionUomId { get; set; }

		public virtual decimal? Weight { get; set; }

		public virtual string WeightUomId { get; set; }

		public virtual decimal? InsuredValue { get; set; }

		public virtual bool? Active { get; set; }

        protected ShipmentPackageStateEventBase() : base()
        {
        }

        protected ShipmentPackageStateEventBase(ShipmentPackageEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class ShipmentPackageStateCreated : ShipmentPackageStateEventBase, IShipmentPackageStateCreated, ISaveable
	{
		public ShipmentPackageStateCreated () : this(new ShipmentPackageEventId())
		{
		}

		public ShipmentPackageStateCreated (ShipmentPackageEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<ShipmentPackageContentEventId, IShipmentPackageContentStateCreated> _shipmentPackageContentEvents = new Dictionary<ShipmentPackageContentEventId, IShipmentPackageContentStateCreated>();
        
        private IEnumerable<IShipmentPackageContentStateCreated> _readOnlyShipmentPackageContentEvents;

        public virtual IEnumerable<IShipmentPackageContentStateCreated> ShipmentPackageContentEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._shipmentPackageContentEvents.Values;
                }
                else
                {
                    if (_readOnlyShipmentPackageContentEvents != null) { return _readOnlyShipmentPackageContentEvents; }
                    var eventDao = ShipmentPackageContentEventDao;
                    var eL = new List<IShipmentPackageContentStateCreated>();
                    foreach (var e in eventDao.FindByShipmentPackageEventId(this.ShipmentPackageEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IShipmentPackageContentStateCreated)e);
                    }
                    return (_readOnlyShipmentPackageContentEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddShipmentPackageContentEvent(e);
                    }
                }
                else { this._shipmentPackageContentEvents.Clear(); }
            }
        }
    
		public virtual void AddShipmentPackageContentEvent(IShipmentPackageContentStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._shipmentPackageContentEvents[e.ShipmentPackageContentEventId] = e;
		}

        public virtual IShipmentPackageContentStateCreated NewShipmentPackageContentStateCreated(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentPackageContentStateCreated(NewShipmentPackageContentEventId(shipmentItemSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IShipmentPackageContentStateCreated e in this.ShipmentPackageContentEvents) {
				ShipmentPackageContentEventDao.Save(e);
			}
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ShipmentPackageStateMergePatched : ShipmentPackageStateEventBase, IShipmentPackageStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyShipmentBoxTypeIdRemoved { get; set; }

		public virtual bool IsPropertyDateCreatedRemoved { get; set; }

		public virtual bool IsPropertyBoxLengthRemoved { get; set; }

		public virtual bool IsPropertyBoxHeightRemoved { get; set; }

		public virtual bool IsPropertyBoxWidthRemoved { get; set; }

		public virtual bool IsPropertyDimensionUomIdRemoved { get; set; }

		public virtual bool IsPropertyWeightRemoved { get; set; }

		public virtual bool IsPropertyWeightUomIdRemoved { get; set; }

		public virtual bool IsPropertyInsuredValueRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public ShipmentPackageStateMergePatched ()
		{
		}

		public ShipmentPackageStateMergePatched (ShipmentPackageEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<ShipmentPackageContentEventId, IShipmentPackageContentEvent> _shipmentPackageContentEvents = new Dictionary<ShipmentPackageContentEventId, IShipmentPackageContentEvent>();

        private IEnumerable<IShipmentPackageContentEvent> _readOnlyShipmentPackageContentEvents;
        
        public virtual IEnumerable<IShipmentPackageContentEvent> ShipmentPackageContentEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._shipmentPackageContentEvents.Values;
                }
                else
                {
                    if (_readOnlyShipmentPackageContentEvents != null) { return _readOnlyShipmentPackageContentEvents; }
                    var eventDao = ShipmentPackageContentEventDao;
                    var eL = new List<IShipmentPackageContentEvent>();
                    foreach (var e in eventDao.FindByShipmentPackageEventId(this.ShipmentPackageEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IShipmentPackageContentEvent)e);
                    }
                    return (_readOnlyShipmentPackageContentEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddShipmentPackageContentEvent(e);
                    }
                }
                else { this._shipmentPackageContentEvents.Clear(); }
            }
        }

		public virtual void AddShipmentPackageContentEvent(IShipmentPackageContentEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._shipmentPackageContentEvents[e.ShipmentPackageContentEventId] = e;
		}

        public virtual IShipmentPackageContentStateCreated NewShipmentPackageContentStateCreated(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentPackageContentStateCreated(NewShipmentPackageContentEventId(shipmentItemSeqId));
            return stateEvent;
        }

        public virtual IShipmentPackageContentStateMergePatched NewShipmentPackageContentStateMergePatched(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentPackageContentStateMergePatched(NewShipmentPackageContentEventId(shipmentItemSeqId));
            return stateEvent;
        }

        public virtual IShipmentPackageContentStateRemoved NewShipmentPackageContentStateRemoved(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentPackageContentStateRemoved(NewShipmentPackageContentEventId(shipmentItemSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IShipmentPackageContentEvent e in this.ShipmentPackageContentEvents) {
				ShipmentPackageContentEventDao.Save(e);
			}
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ShipmentPackageStateDeleted : ShipmentPackageStateEventBase, IShipmentPackageStateDeleted, ISaveable
	{
		public ShipmentPackageStateDeleted ()
		{
		}

		public ShipmentPackageStateDeleted (ShipmentPackageEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

		private Dictionary<ShipmentPackageContentEventId, IShipmentPackageContentStateRemoved> _shipmentPackageContentEvents = new Dictionary<ShipmentPackageContentEventId, IShipmentPackageContentStateRemoved>();
		
        private IEnumerable<IShipmentPackageContentStateRemoved> _readOnlyShipmentPackageContentEvents;

        public virtual IEnumerable<IShipmentPackageContentStateRemoved> ShipmentPackageContentEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._shipmentPackageContentEvents.Values;
                }
                else
                {
                    if (_readOnlyShipmentPackageContentEvents != null) { return _readOnlyShipmentPackageContentEvents; }
                    var eventDao = ShipmentPackageContentEventDao;
                    var eL = new List<IShipmentPackageContentStateRemoved>();
                    foreach (var e in eventDao.FindByShipmentPackageEventId(this.ShipmentPackageEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IShipmentPackageContentStateRemoved)e);
                    }
                    return (_readOnlyShipmentPackageContentEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddShipmentPackageContentEvent(e);
                    }
                }
                else { this._shipmentPackageContentEvents.Clear(); }
            }
        }
	
		public virtual void AddShipmentPackageContentEvent(IShipmentPackageContentStateRemoved e)
		{
			ThrowOnInconsistentEventIds(e);
			this._shipmentPackageContentEvents[e.ShipmentPackageContentEventId] = e;
		}

        public virtual IShipmentPackageContentStateRemoved NewShipmentPackageContentStateRemoved(string shipmentItemSeqId)
        {
            var stateEvent = new ShipmentPackageContentStateRemoved(NewShipmentPackageContentEventId(shipmentItemSeqId));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IShipmentPackageContentStateRemoved e in this.ShipmentPackageContentEvents) {
				ShipmentPackageContentEventDao.Save(e);
			}
		}


	}



}

