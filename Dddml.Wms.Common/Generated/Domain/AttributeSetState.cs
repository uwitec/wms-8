﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
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
				return this.Version;
			}
		}


		#endregion

        bool IAttributeSetState.IsUnsaved
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


        private IAttributeUseStates _attributeUses;
      
        public virtual IAttributeUseStates AttributeUses
        {
            get
            {
                return this._attributeUses;
            }
        }

        protected internal virtual void SetAttributeUses(IAttributeUseStates value)
        {
            this._attributeUses = value;
        }


        public AttributeSetState() : this(null)
        {
        }

        public AttributeSetState(IEnumerable<IEvent> events)
        {
            _attributeUses = new AttributeUseStates(this);

            InitializeProperties();

            if (events != null && events.Count() > 0)
            {
                this.AttributeSetId = ((IAttributeSetStateEvent)events.First()).StateEventId.AttributeSetId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
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
			this.Name = e.Name;

			this.OrganizationId = e.OrganizationId;

			this.Description = e.Description;

			this.SerialNumberAttributeId = e.SerialNumberAttributeId;

			this.LotAttributeId = e.LotAttributeId;

			this.ReferenceId = e.ReferenceId;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;

			foreach (IAttributeUseStateCreated innerEvent in e.AttributeUseEvents) {
				IAttributeUseState innerState = this.AttributeUses.Get(innerEvent.GlobalId.AttributeId);
				innerState.Mutate (innerEvent);
			}

		}


		public virtual void When(IAttributeSetStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Name == null)
			{
				if (e.IsPropertyNameRemoved)
				{
					this.Name = default(string);
				}
			}
			else
			{
				this.Name = e.Name;
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

			if (e.SerialNumberAttributeId == null)
			{
				if (e.IsPropertySerialNumberAttributeIdRemoved)
				{
					this.SerialNumberAttributeId = default(string);
				}
			}
			else
			{
				this.SerialNumberAttributeId = e.SerialNumberAttributeId;
			}

			if (e.LotAttributeId == null)
			{
				if (e.IsPropertyLotAttributeIdRemoved)
				{
					this.LotAttributeId = default(string);
				}
			}
			else
			{
				this.LotAttributeId = e.LotAttributeId;
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
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IAttributeSetStateEvent stateEvent)
		{
			var stateEntityId = this.AttributeSetId; // Aggregate Id
			var eventEntityId = stateEvent.StateEventId.AttributeSetId; // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
			if (stateEntityId != eventEntityId)
			{
				throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
			}

			var stateVersion = this.Version;
			var eventVersion = stateEvent.StateEventId.Version;
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}

