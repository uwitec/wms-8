﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateMovementConfirmationDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;

namespace Dddml.Wms.Domain.MovementConfirmation
{

	public abstract class MovementConfirmationEventBase : IMovementConfirmationEvent
	{

		public virtual MovementConfirmationEventId MovementConfirmationEventId { get; set; }

        public virtual string DocumentNumber
        {
            get { return MovementConfirmationEventId.DocumentNumber; }
            set { MovementConfirmationEventId.DocumentNumber = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		MovementConfirmationEventId IGlobalIdentity<MovementConfirmationEventId>.GlobalId {
			get
			{
				return this.MovementConfirmationEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IMovementConfirmationEvent.ReadOnly
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

        protected MovementConfirmationEventBase()
        {
        }

        protected MovementConfirmationEventBase(MovementConfirmationEventId stateEventId)
        {
            this.MovementConfirmationEventId = stateEventId;
        }

		protected IMovementConfirmationLineEventDao MovementConfirmationLineEventDao
		{
			get { return ApplicationContext.Current["MovementConfirmationLineEventDao"] as IMovementConfirmationLineEventDao; }
		}

        protected MovementConfirmationLineEventId NewMovementConfirmationLineEventId(string lineNumber)
        {
            var stateEventId = new MovementConfirmationLineEventId(this.MovementConfirmationEventId.DocumentNumber, lineNumber, this.MovementConfirmationEventId.Version);
            return stateEventId;
        }


        protected void ThrowOnInconsistentEventIds(IMovementConfirmationLineEvent e)
        {
            ThrowOnInconsistentEventIds(this, e);
        }

		public static void ThrowOnInconsistentEventIds(IMovementConfirmationEvent oe, IMovementConfirmationLineEvent e)
		{
			if (!oe.MovementConfirmationEventId.DocumentNumber.Equals(e.MovementConfirmationLineEventId.MovementConfirmationDocumentNumber))
			{ 
				throw DomainError.Named("inconsistentEventIds", "Outer Id DocumentNumber {0} but inner id MovementConfirmationDocumentNumber {1}", 
					oe.MovementConfirmationEventId.DocumentNumber, e.MovementConfirmationLineEventId.MovementConfirmationDocumentNumber);
			}
		}



        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class MovementConfirmationStateEventBase : MovementConfirmationEventBase, IMovementConfirmationStateEvent
    {

		public virtual string DocumentStatusId { get; set; }

		public virtual string MovementDocumentNumber { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual decimal? ApprovalAmount { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string Processing { get; set; }

		public virtual string DocumentTypeId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

        protected MovementConfirmationStateEventBase() : base()
        {
        }

        protected MovementConfirmationStateEventBase(MovementConfirmationEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class MovementConfirmationStateCreated : MovementConfirmationStateEventBase, IMovementConfirmationStateCreated, ISaveable
	{
		public MovementConfirmationStateCreated () : this(new MovementConfirmationEventId())
		{
		}

		public MovementConfirmationStateCreated (MovementConfirmationEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<MovementConfirmationLineEventId, IMovementConfirmationLineStateCreated> _movementConfirmationLineEvents = new Dictionary<MovementConfirmationLineEventId, IMovementConfirmationLineStateCreated>();
        
        private IEnumerable<IMovementConfirmationLineStateCreated> _readOnlyMovementConfirmationLineEvents;

        public virtual IEnumerable<IMovementConfirmationLineStateCreated> MovementConfirmationLineEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._movementConfirmationLineEvents.Values;
                }
                else
                {
                    if (_readOnlyMovementConfirmationLineEvents != null) { return _readOnlyMovementConfirmationLineEvents; }
                    var eventDao = MovementConfirmationLineEventDao;
                    var eL = new List<IMovementConfirmationLineStateCreated>();
                    foreach (var e in eventDao.FindByMovementConfirmationEventId(this.MovementConfirmationEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IMovementConfirmationLineStateCreated)e);
                    }
                    return (_readOnlyMovementConfirmationLineEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddMovementConfirmationLineEvent(e);
                    }
                }
                else { this._movementConfirmationLineEvents.Clear(); }
            }
        }
    
		public virtual void AddMovementConfirmationLineEvent(IMovementConfirmationLineStateCreated e)
		{
			ThrowOnInconsistentEventIds(e);
			this._movementConfirmationLineEvents[e.MovementConfirmationLineEventId] = e;
		}

        public virtual IMovementConfirmationLineStateCreated NewMovementConfirmationLineStateCreated(string lineNumber)
        {
            var stateEvent = new MovementConfirmationLineStateCreated(NewMovementConfirmationLineEventId(lineNumber));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IMovementConfirmationLineStateCreated e in this.MovementConfirmationLineEvents) {
				MovementConfirmationLineEventDao.Save(e);
			}
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class MovementConfirmationStateMergePatched : MovementConfirmationStateEventBase, IMovementConfirmationStateMergePatched, ISaveable
	{
		public virtual bool IsPropertyDocumentStatusIdRemoved { get; set; }

		public virtual bool IsPropertyMovementDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyApprovalAmountRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyProcessingRemoved { get; set; }

		public virtual bool IsPropertyDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MovementConfirmationStateMergePatched ()
		{
		}

		public MovementConfirmationStateMergePatched (MovementConfirmationEventId stateEventId) : base(stateEventId)
		{
		}

		private Dictionary<MovementConfirmationLineEventId, IMovementConfirmationLineEvent> _movementConfirmationLineEvents = new Dictionary<MovementConfirmationLineEventId, IMovementConfirmationLineEvent>();

        private IEnumerable<IMovementConfirmationLineEvent> _readOnlyMovementConfirmationLineEvents;
        
        public virtual IEnumerable<IMovementConfirmationLineEvent> MovementConfirmationLineEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._movementConfirmationLineEvents.Values;
                }
                else
                {
                    if (_readOnlyMovementConfirmationLineEvents != null) { return _readOnlyMovementConfirmationLineEvents; }
                    var eventDao = MovementConfirmationLineEventDao;
                    var eL = new List<IMovementConfirmationLineEvent>();
                    foreach (var e in eventDao.FindByMovementConfirmationEventId(this.MovementConfirmationEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IMovementConfirmationLineEvent)e);
                    }
                    return (_readOnlyMovementConfirmationLineEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddMovementConfirmationLineEvent(e);
                    }
                }
                else { this._movementConfirmationLineEvents.Clear(); }
            }
        }

		public virtual void AddMovementConfirmationLineEvent(IMovementConfirmationLineEvent e)
		{
			ThrowOnInconsistentEventIds(e);
			this._movementConfirmationLineEvents[e.MovementConfirmationLineEventId] = e;
		}

        public virtual IMovementConfirmationLineStateCreated NewMovementConfirmationLineStateCreated(string lineNumber)
        {
            var stateEvent = new MovementConfirmationLineStateCreated(NewMovementConfirmationLineEventId(lineNumber));
            return stateEvent;
        }

        public virtual IMovementConfirmationLineStateMergePatched NewMovementConfirmationLineStateMergePatched(string lineNumber)
        {
            var stateEvent = new MovementConfirmationLineStateMergePatched(NewMovementConfirmationLineEventId(lineNumber));
            return stateEvent;
        }

        public virtual IMovementConfirmationLineStateRemoved NewMovementConfirmationLineStateRemoved(string lineNumber)
        {
            var stateEvent = new MovementConfirmationLineStateRemoved(NewMovementConfirmationLineEventId(lineNumber));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IMovementConfirmationLineEvent e in this.MovementConfirmationLineEvents) {
				MovementConfirmationLineEventDao.Save(e);
			}
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class MovementConfirmationStateDeleted : MovementConfirmationStateEventBase, IMovementConfirmationStateDeleted, ISaveable
	{
		public MovementConfirmationStateDeleted ()
		{
		}

		public MovementConfirmationStateDeleted (MovementConfirmationEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

		private Dictionary<MovementConfirmationLineEventId, IMovementConfirmationLineStateRemoved> _movementConfirmationLineEvents = new Dictionary<MovementConfirmationLineEventId, IMovementConfirmationLineStateRemoved>();
		
        private IEnumerable<IMovementConfirmationLineStateRemoved> _readOnlyMovementConfirmationLineEvents;

        public virtual IEnumerable<IMovementConfirmationLineStateRemoved> MovementConfirmationLineEvents
        {
            get
            {
                if (!EventReadOnly)
                {
                    return this._movementConfirmationLineEvents.Values;
                }
                else
                {
                    if (_readOnlyMovementConfirmationLineEvents != null) { return _readOnlyMovementConfirmationLineEvents; }
                    var eventDao = MovementConfirmationLineEventDao;
                    var eL = new List<IMovementConfirmationLineStateRemoved>();
                    foreach (var e in eventDao.FindByMovementConfirmationEventId(this.MovementConfirmationEventId))
                    {
                        e.ReadOnly = true;
                        eL.Add((IMovementConfirmationLineStateRemoved)e);
                    }
                    return (_readOnlyMovementConfirmationLineEvents = eL);
                }
            }
            set 
            {
                if (value != null)
                {
                    foreach (var e in value)
                    {
                        AddMovementConfirmationLineEvent(e);
                    }
                }
                else { this._movementConfirmationLineEvents.Clear(); }
            }
        }
	
		public virtual void AddMovementConfirmationLineEvent(IMovementConfirmationLineStateRemoved e)
		{
			ThrowOnInconsistentEventIds(e);
			this._movementConfirmationLineEvents[e.MovementConfirmationLineEventId] = e;
		}

        public virtual IMovementConfirmationLineStateRemoved NewMovementConfirmationLineStateRemoved(string lineNumber)
        {
            var stateEvent = new MovementConfirmationLineStateRemoved(NewMovementConfirmationLineEventId(lineNumber));
            return stateEvent;
        }

		public virtual void Save ()
		{
			foreach (IMovementConfirmationLineStateRemoved e in this.MovementConfirmationLineEvents) {
				MovementConfirmationLineEventDao.Save(e);
			}
		}


	}



}

