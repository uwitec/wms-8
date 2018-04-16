﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public abstract class OrderRoleEventBase : IOrderRoleEvent
	{

		public virtual OrderRoleEventId OrderRoleEventId { get; set; }

        public virtual PartyRoleId PartyRoleId
        {
            get { return OrderRoleEventId.PartyRoleId; }
            set { OrderRoleEventId.PartyRoleId = value; }
        }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrderRoleEventId IGlobalIdentity<OrderRoleEventId>.GlobalId {
			get
			{
				return this.OrderRoleEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IOrderRoleEvent.ReadOnly
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

        protected OrderRoleEventBase()
        {
        }

        protected OrderRoleEventBase(OrderRoleEventId stateEventId)
        {
            this.OrderRoleEventId = stateEventId;
        }


        string IEventDto.EventType
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}

    public abstract class OrderRoleStateEventBase : OrderRoleEventBase, IOrderRoleStateEvent
    {

		public virtual bool? Active { get; set; }

        protected OrderRoleStateEventBase() : base()
        {
        }

        protected OrderRoleStateEventBase(OrderRoleEventId stateEventId) : base(stateEventId)
        {
        }

    }

	public class OrderRoleStateCreated : OrderRoleStateEventBase, IOrderRoleStateCreated
	{
		public OrderRoleStateCreated () : this(new OrderRoleEventId())
		{
		}

		public OrderRoleStateCreated (OrderRoleEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class OrderRoleStateMergePatched : OrderRoleStateEventBase, IOrderRoleStateMergePatched
	{
		public virtual bool IsPropertyActiveRemoved { get; set; }


		public OrderRoleStateMergePatched ()
		{
		}

		public OrderRoleStateMergePatched (OrderRoleEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class OrderRoleStateRemoved : OrderRoleStateEventBase, IOrderRoleStateRemoved
	{
		public OrderRoleStateRemoved ()
		{
		}

		public OrderRoleStateRemoved (OrderRoleEventId stateEventId) : base(stateEventId)
		{
		}

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }



	}



}

