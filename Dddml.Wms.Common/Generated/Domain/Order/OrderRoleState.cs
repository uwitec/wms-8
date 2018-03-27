﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public partial class OrderRoleState : OrderRoleStateProperties, IOrderRoleState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private OrderRoleId _orderRoleId = new OrderRoleId();

        public virtual OrderRoleId OrderRoleId 
        {
            get { return this._orderRoleId; }
            set { this._orderRoleId = value; }
        }

		OrderRoleId IGlobalIdentity<OrderRoleId>.GlobalId {
			get {
				return  this.OrderRoleId;
			}
		}

        PartyRoleId ILocalIdentity<PartyRoleId>.LocalId
        {
            get
            {
                return this.PartyRoleId;
            }
        }


        public override string OrderId {
			get {
				return this.OrderRoleId.OrderId;
			}
			set {
				this.OrderRoleId.OrderId = value;
			}
		}

        public override PartyRoleId PartyRoleId {
			get {
				return this.OrderRoleId.PartyRoleId;
			}
			set {
				this.OrderRoleId.PartyRoleId = value;
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

        bool IOrderRoleState.IsUnsaved
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

        public OrderRoleState() : this(false)
        {
        }

        public OrderRoleState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IOrderRoleStateCreated e)
		{
			ThrowOnWrongEvent(e);
            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IOrderRoleStateMergePatched e)
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


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IOrderRoleStateRemoved e)
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

        protected void ThrowOnWrongEvent(IOrderRoleStateEvent stateEvent)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("OrderRole|");

            var stateEntityIdOrderId = (this as IGlobalIdentity<OrderRoleId>).GlobalId.OrderId;
            var eventEntityIdOrderId = stateEvent.OrderRoleEventId.OrderId;
            if (stateEntityIdOrderId != eventEntityIdOrderId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id OrderId {0} in state but entity id OrderId {1} in event", stateEntityIdOrderId, eventEntityIdOrderId);
            }
            id.Append(stateEntityIdOrderId).Append(",");

            var stateEntityIdPartyRoleId = (this as IGlobalIdentity<OrderRoleId>).GlobalId.PartyRoleId;
            var eventEntityIdPartyRoleId = stateEvent.OrderRoleEventId.PartyRoleId;
            if (stateEntityIdPartyRoleId != eventEntityIdPartyRoleId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id PartyRoleId {0} in state but entity id PartyRoleId {1} in event", stateEntityIdPartyRoleId, eventEntityIdPartyRoleId);
            }
            id.Append(stateEntityIdPartyRoleId).Append(",");

            id.Append("]");

            if (ForReapplying) { return; }
            var stateVersion = this.Version;
            var eventVersion = stateEvent.Version;
            if (OrderRoleState.VersionZero == eventVersion)
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

