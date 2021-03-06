﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;

namespace Dddml.Wms.Domain.Attribute
{

	public partial class AttributeAliasState : AttributeAliasStateProperties, IAttributeAliasState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private AttributeAliasId _attributeAliasId = new AttributeAliasId();

        public virtual AttributeAliasId AttributeAliasId 
        {
            get { return this._attributeAliasId; }
            set { this._attributeAliasId = value; }
        }

		AttributeAliasId IGlobalIdentity<AttributeAliasId>.GlobalId {
			get {
				return  this.AttributeAliasId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.Code;
            }
        }


        public override string AttributeId {
			get {
				return this.AttributeAliasId.AttributeId;
			}
			set {
				this.AttributeAliasId.AttributeId = value;
			}
		}

        public override string Code {
			get {
				return this.AttributeAliasId.Code;
			}
			set {
				this.AttributeAliasId.Code = value;
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

		long IEntityVersioned<long>.EntityVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IAttributeAliasState.IsUnsaved
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

        public AttributeAliasState() : this(false)
        {
        }

        public AttributeAliasState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IAttributeAliasStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Name = e.Name;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IAttributeAliasStateMergePatched e)
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


		}

		public virtual void When(IAttributeAliasStateRemoved e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IAttributeAliasEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("AttributeAlias|");

            var stateEntityIdAttributeId = (this as IGlobalIdentity<AttributeAliasId>).GlobalId.AttributeId;
            var eventEntityIdAttributeId = e.AttributeAliasEventId.AttributeId;
            if (stateEntityIdAttributeId != eventEntityIdAttributeId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id AttributeId {0} in state but entity id AttributeId {1} in event", stateEntityIdAttributeId, eventEntityIdAttributeId);
            }
            id.Append(stateEntityIdAttributeId).Append(",");

            var stateEntityIdCode = (this as IGlobalIdentity<AttributeAliasId>).GlobalId.Code;
            var eventEntityIdCode = e.AttributeAliasEventId.Code;
            if (stateEntityIdCode != eventEntityIdCode)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id Code {0} in state but entity id Code {1} in event", stateEntityIdCode, eventEntityIdCode);
            }
            id.Append(stateEntityIdCode).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var stateEvent = e is IAttributeAliasStateEvent ? (IAttributeAliasStateEvent)e : null;
            if (e == null) { return; }
            stateEvent.Version = stateVersion;
            //var stateEventStateVersion = stateEvent.Version;
            //if (AttributeAliasState.VersionZero == stateEventStateVersion)
            //{
            //    stateEventStateVersion = stateEvent.Version = stateVersion;
            //}
            //if (stateVersion != stateEventStateVersion)
            //{
            //    throw OptimisticConcurrencyException.Create(stateVersion, stateEventStateVersion, id.ToString());
            //}
        }
    }

}

