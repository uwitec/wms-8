﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Picklist
{

	public partial class PicklistRoleState : PicklistRoleStateProperties, IPicklistRoleState
	{

		public virtual string CreatedByUserLogin { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string LastModifiedByUserLogin { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private PicklistRoleId _picklistRoleId = new PicklistRoleId();

        public virtual PicklistRoleId PicklistRoleId 
        {
            get { return this._picklistRoleId; }
            set { this._picklistRoleId = value; }
        }

		PicklistRoleId IGlobalIdentity<PicklistRoleId>.GlobalId {
			get {
				return  this.PicklistRoleId;
			}
		}

        PartyRoleId ILocalIdentity<PartyRoleId>.LocalId
        {
            get
            {
                return this.PartyRoleId;
            }
        }


        public override string PicklistId {
			get {
				return this.PicklistRoleId.PicklistId;
			}
			set {
				this.PicklistRoleId.PicklistId = value;
			}
		}

        public override PartyRoleId PartyRoleId {
			get {
				return this.PicklistRoleId.PartyRoleId;
			}
			set {
				this.PicklistRoleId.PartyRoleId = value;
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
				return this.CreatedByUserLogin;
			}
			set
			{
				this.CreatedByUserLogin = value;
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
			get { return this.LastModifiedByUserLogin; }
			set { this.LastModifiedByUserLogin = value; }
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

        bool IPicklistRoleState.IsUnsaved
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

        public PicklistRoleState() : this(false)
        {
        }

        public PicklistRoleState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IPicklistRoleStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedByUserLogin = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IPicklistRoleStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

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


			this.LastModifiedByUserLogin = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IPicklistRoleStateRemoved e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.LastModifiedByUserLogin = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IPicklistRoleEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("PicklistRole|");

            var stateEntityIdPicklistId = (this as IGlobalIdentity<PicklistRoleId>).GlobalId.PicklistId;
            var eventEntityIdPicklistId = stateEvent.PicklistRoleEventId.PicklistId;
            if (stateEntityIdPicklistId != eventEntityIdPicklistId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id PicklistId {0} in state but entity id PicklistId {1} in event", stateEntityIdPicklistId, eventEntityIdPicklistId);
            }
            id.Append(stateEntityIdPicklistId).Append(",");

            var stateEntityIdPartyRoleId = (this as IGlobalIdentity<PicklistRoleId>).GlobalId.PartyRoleId;
            var eventEntityIdPartyRoleId = stateEvent.PicklistRoleEventId.PartyRoleId;
            if (stateEntityIdPartyRoleId != eventEntityIdPartyRoleId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id PartyRoleId {0} in state but entity id PartyRoleId {1} in event", stateEntityIdPartyRoleId, eventEntityIdPartyRoleId);
            }
            id.Append(stateEntityIdPartyRoleId).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (PicklistRoleState.VersionZero == eventVersion)
            {
                eventVersion = stateEvent.Version = stateVersion;
            }
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

