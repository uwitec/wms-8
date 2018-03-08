﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

	public partial class AttributeSetState : AttributeSetStateProperties, IAttributeSetState, ISaveable
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.AttributeSetId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
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
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IAttributeSetState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        private IAttributeUseStates _attributeUses;
      
        public virtual IAttributeUseStates AttributeUses
        {
            get
            {
                return this._attributeUses;
            }
            set
            {
                this._attributeUses = value;
            }
        }


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public AttributeSetState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.AttributeSetId = ((IAttributeSetStateEvent)events.First()).AttributeSetEventId.AttributeSetId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public AttributeSetState() : this(false)
        {
        }

        public AttributeSetState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            _attributeUses = new AttributeUseStates(this);

            InitializeProperties();
        }


		#region Saveable Implements

        public virtual void Save()
        {
            _attributeUses.Save();

        }


		#endregion


		public virtual void When(IAttributeSetStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.AttributeSetName = e.AttributeSetName;

			this.OrganizationId = e.OrganizationId;

			this.Description = e.Description;

			this.ReferenceId = e.ReferenceId;

            if(e.IsInstanceAttributeSet != null) { this.IsInstanceAttributeSet = (e.IsInstanceAttributeSet != null && e.IsInstanceAttributeSet.HasValue) ? e.IsInstanceAttributeSet.Value : default(bool); }

            if(e.IsMandatory != null) { this.IsMandatory = (e.IsMandatory != null && e.IsMandatory.HasValue) ? e.IsMandatory.Value : default(bool); }

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;

			foreach (IAttributeUseStateCreated innerEvent in e.AttributeUseEvents) {
				IAttributeUseState innerState = this.AttributeUses.Get(innerEvent.GlobalId.AttributeId, true);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IAttributeSetStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.AttributeSetName == null)
			{
				if (e.IsPropertyAttributeSetNameRemoved)
				{
					this.AttributeSetName = default(string);
				}
			}
			else
			{
				this.AttributeSetName = e.AttributeSetName;
			}

			if (e.OrganizationId == null)
			{
				if (e.IsPropertyOrganizationIdRemoved)
				{
					this.OrganizationId = default(string);
				}
			}
			else
			{
				this.OrganizationId = e.OrganizationId;
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

			if (e.ReferenceId == null)
			{
				if (e.IsPropertyReferenceIdRemoved)
				{
					this.ReferenceId = default(string);
				}
			}
			else
			{
				this.ReferenceId = e.ReferenceId;
			}

			if (e.IsInstanceAttributeSet == null)
			{
				if (e.IsPropertyIsInstanceAttributeSetRemoved)
				{
					this.IsInstanceAttributeSet = default(bool);
				}
			}
			else
			{
				this.IsInstanceAttributeSet = (e.IsInstanceAttributeSet != null && e.IsInstanceAttributeSet.HasValue) ? e.IsInstanceAttributeSet.Value : default(bool);
			}

			if (e.IsMandatory == null)
			{
				if (e.IsPropertyIsMandatoryRemoved)
				{
					this.IsMandatory = default(bool);
				}
			}
			else
			{
				this.IsMandatory = (e.IsMandatory != null && e.IsMandatory.HasValue) ? e.IsMandatory.Value : default(bool);
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


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


			foreach (IAttributeUseStateEvent innerEvent in e.AttributeUseEvents)
            {
                IAttributeUseState innerState = this.AttributeUses.Get(innerEvent.GlobalId.AttributeId);

                innerState.Mutate(innerEvent);
                var removed = innerEvent as IAttributeUseStateRemoved;
                if (removed != null)
                {
                    this.AttributeUses.Remove(innerState);
                }
          
            }

		}

		public virtual void When(IAttributeSetStateDeleted e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

            foreach (var innerState in this.AttributeUses)
            {
                this.AttributeUses.Remove(innerState);
                
                var innerE = e.NewAttributeUseStateRemoved(innerState.AttributeId);
                ((AttributeUseStateEventBase)innerE).CreatedAt = e.CreatedAt;
                ((AttributeUseStateEventBase)innerE).CreatedBy = e.CreatedBy;
                innerState.When(innerE);
                //e.AddAttributeUseEvent(innerE);

            }

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IAttributeSetStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("AttributeSet|");

            var stateEntityId = this.AttributeSetId; // Aggregate Id
            var eventEntityId = stateEvent.AttributeSetEventId.AttributeSetId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = stateEvent.AttributeSetEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

