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

	public abstract class MovementConfirmationStateEventDtoBase : IStateEventDto, IMovementConfirmationStateCreated, IMovementConfirmationStateMergePatched, IMovementConfirmationStateDeleted
	{

        private MovementConfirmationEventId _movementConfirmationEventId;

		protected internal virtual MovementConfirmationEventId MovementConfirmationEventId 
        {
            get 
            {
                if (_movementConfirmationEventId == null) { _movementConfirmationEventId = new MovementConfirmationEventId(); }
                return _movementConfirmationEventId;
            }
            set
            {
                _movementConfirmationEventId = value;
            }
        }

        public virtual string DocumentNumber
        {
            get { return MovementConfirmationEventId.DocumentNumber; }
            set { MovementConfirmationEventId.DocumentNumber = value; }
        }

        public virtual long Version
        {
            get { return MovementConfirmationEventId.Version; }
            set { MovementConfirmationEventId.Version = value; }
        }

		public virtual string DocumentStatusId { get; set; }

		public virtual string MovementDocumentNumber { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual decimal? ApprovalAmount { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string Processing { get; set; }

		public virtual string DocumentTypeId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

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

        public virtual bool StateEventReadOnly { get; set; }

        bool IMovementConfirmationStateEvent.ReadOnly
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

		public virtual bool? IsPropertyDocumentStatusIdRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyDocumentStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDocumentStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDocumentStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementDocumentNumberRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyMovementDocumentNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyMovementDocumentNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMovementDocumentNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsApprovedRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyIsApprovedRemoved
        {
            get 
            {
                var b = this.IsPropertyIsApprovedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsApprovedRemoved = value;
            }
        }

		public virtual bool? IsPropertyApprovalAmountRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyApprovalAmountRemoved
        {
            get 
            {
                var b = this.IsPropertyApprovalAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyApprovalAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyProcessedRemoved
        {
            get 
            {
                var b = this.IsPropertyProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessingRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyProcessingRemoved
        {
            get 
            {
                var b = this.IsPropertyProcessingRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProcessingRemoved = value;
            }
        }

		public virtual bool? IsPropertyDocumentTypeIdRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyDocumentTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyDocumentTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDocumentTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMovementConfirmationStateMergePatched.IsPropertyActiveRemoved
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


        private MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDtos _movementConfirmationLineEvents = new MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDtos();

        public virtual MovementConfirmationLineStateCreatedOrMergePatchedOrRemovedDto[] MovementConfirmationLineEvents
        {
            get
            {
                return _movementConfirmationLineEvents.ToArray();
            }
            set
            {
                _movementConfirmationLineEvents.Clear();
                _movementConfirmationLineEvents.AddRange(value);
            }
        }



        private MovementConfirmationLineEventId NewMovementConfirmationLineEventId(string lineNumber)
        {
            var eId = new MovementConfirmationLineEventId();
            eId.MovementConfirmationDocumentNumber = this.MovementConfirmationEventId.DocumentNumber;
            eId.LineNumber = lineNumber;
            eId.MovementConfirmationVersion = this.MovementConfirmationEventId.Version;
            return eId;
        }

        public virtual MovementConfirmationLineStateCreatedDto NewMovementConfirmationLineStateCreated(string lineNumber)
        {
            var e = new MovementConfirmationLineStateCreatedDto();
            var eId = NewMovementConfirmationLineEventId(lineNumber);
            e.MovementConfirmationLineEventId = eId;
            return e;
        }

        public virtual MovementConfirmationLineStateMergePatchedDto NewMovementConfirmationLineStateMergePatched(string lineNumber)
        {
            var e = new MovementConfirmationLineStateMergePatchedDto();
            var eId = NewMovementConfirmationLineEventId(lineNumber);
            e.MovementConfirmationLineEventId = eId;
            return e;
        }

        public virtual MovementConfirmationLineStateRemovedDto NewMovementConfirmationLineStateRemoved(string lineNumber)
        {
            var e = new MovementConfirmationLineStateRemovedDto();
            var eId = NewMovementConfirmationLineEventId(lineNumber);
            e.MovementConfirmationLineEventId = eId;
            return e;
        }

        IEnumerable<IMovementConfirmationLineStateCreated> IMovementConfirmationStateCreated.MovementConfirmationLineEvents
        {
            get { return this._movementConfirmationLineEvents; }
        }

        void IMovementConfirmationStateCreated.AddMovementConfirmationLineEvent(IMovementConfirmationLineStateCreated e)
        {
            this._movementConfirmationLineEvents.AddMovementConfirmationLineEvent(e);
        }

        IMovementConfirmationLineStateCreated IMovementConfirmationStateCreated.NewMovementConfirmationLineStateCreated(string lineNumber)
        {
            return NewMovementConfirmationLineStateCreated(lineNumber);
        }

        IEnumerable<IMovementConfirmationLineStateEvent> IMovementConfirmationStateMergePatched.MovementConfirmationLineEvents
        {
            get { return this._movementConfirmationLineEvents; }
        }

        void IMovementConfirmationStateMergePatched.AddMovementConfirmationLineEvent(IMovementConfirmationLineStateEvent e)
        {
            this._movementConfirmationLineEvents.AddMovementConfirmationLineEvent(e);
        }

        IMovementConfirmationLineStateCreated IMovementConfirmationStateMergePatched.NewMovementConfirmationLineStateCreated(string lineNumber)
        {
            return NewMovementConfirmationLineStateCreated(lineNumber);
        }

        IMovementConfirmationLineStateMergePatched IMovementConfirmationStateMergePatched.NewMovementConfirmationLineStateMergePatched(string lineNumber)
        {
            return NewMovementConfirmationLineStateMergePatched(lineNumber);
        }

        IMovementConfirmationLineStateRemoved IMovementConfirmationStateMergePatched.NewMovementConfirmationLineStateRemoved(string lineNumber)
        {
            return NewMovementConfirmationLineStateRemoved(lineNumber);
        }


        IEnumerable<IMovementConfirmationLineStateRemoved> IMovementConfirmationStateDeleted.MovementConfirmationLineEvents
        {
            get { return this._movementConfirmationLineEvents; }
        }

        void IMovementConfirmationStateDeleted.AddMovementConfirmationLineEvent(IMovementConfirmationLineStateRemoved e)
        {
            this._movementConfirmationLineEvents.AddMovementConfirmationLineEvent(e);
        }

        IMovementConfirmationLineStateRemoved IMovementConfirmationStateDeleted.NewMovementConfirmationLineStateRemoved(string lineNumber)
        {
            return NewMovementConfirmationLineStateRemoved(lineNumber);
        }



        MovementConfirmationEventId IMovementConfirmationStateEvent.MovementConfirmationEventId
        {
            get { return this.MovementConfirmationEventId; }
        }

        protected MovementConfirmationStateEventDtoBase()
        {
        }

        protected MovementConfirmationStateEventDtoBase(MovementConfirmationEventId stateEventId)
        {
            this.MovementConfirmationEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto : MovementConfirmationStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class MovementConfirmationStateCreatedDto : MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementConfirmationStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class MovementConfirmationStateMergePatchedDto : MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementConfirmationStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class MovementConfirmationStateDeletedDto : MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto
	{
		public MovementConfirmationStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class MovementConfirmationStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IMovementConfirmationStateCreated>, IEnumerable<IMovementConfirmationStateMergePatched>, IEnumerable<IMovementConfirmationStateDeleted>
    {
        private List<MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementConfirmationStateCreated> IEnumerable<IMovementConfirmationStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementConfirmationStateMergePatched> IEnumerable<IMovementConfirmationStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IMovementConfirmationStateDeleted> IEnumerable<IMovementConfirmationStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddMovementConfirmationEvent(IMovementConfirmationStateCreated e)
        {
            _innerStateEvents.Add((MovementConfirmationStateCreatedDto)e);
        }

        public void AddMovementConfirmationEvent(IMovementConfirmationStateEvent e)
        {
            _innerStateEvents.Add((MovementConfirmationStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddMovementConfirmationEvent(IMovementConfirmationStateDeleted e)
        {
            _innerStateEvents.Add((MovementConfirmationStateDeletedDto)e);
        }

    }


}

