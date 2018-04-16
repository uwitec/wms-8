﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipment;

namespace Dddml.Wms.Domain.OrderShipment
{

	public abstract class OrderShipmentStateEventDtoBase : IEventDto, IOrderShipmentStateCreated, IOrderShipmentStateMergePatched
	{

        private OrderShipmentEventId _orderShipmentEventId;

		protected internal virtual OrderShipmentEventId OrderShipmentEventId 
        {
            get 
            {
                if (_orderShipmentEventId == null) { _orderShipmentEventId = new OrderShipmentEventId(); }
                return _orderShipmentEventId;
            }
            set
            {
                _orderShipmentEventId = value;
            }
        }

        public virtual OrderShipmentId OrderShipmentId
        {
            get { return OrderShipmentEventId.OrderShipmentId; }
            set { OrderShipmentEventId.OrderShipmentId = value; }
        }

        public virtual long Version
        {
            get { return OrderShipmentEventId.Version; }
            set { OrderShipmentEventId.Version = value; }
        }

		public virtual decimal? Quantity { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrderShipmentEventId IGlobalIdentity<OrderShipmentEventId>.GlobalId {
			get 
			{
				return this.OrderShipmentEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IOrderShipmentEvent.ReadOnly
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

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IOrderShipmentStateMergePatched.IsPropertyQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IOrderShipmentStateMergePatched.IsPropertyActiveRemoved
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


        OrderShipmentEventId IOrderShipmentEvent.OrderShipmentEventId
        {
            get { return this.OrderShipmentEventId; }
        }

        protected OrderShipmentStateEventDtoBase()
        {
        }

        protected OrderShipmentStateEventDtoBase(OrderShipmentEventId stateEventId)
        {
            this.OrderShipmentEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class OrderShipmentStateCreatedOrMergePatchedOrDeletedDto : OrderShipmentStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetEventType()
        {
            return this._eventType;
        }

    }



	public class OrderShipmentStateCreatedDto : OrderShipmentStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrderShipmentStateCreatedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class OrderShipmentStateMergePatchedDto : OrderShipmentStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrderShipmentStateMergePatchedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class OrderShipmentStateDeletedDto : OrderShipmentStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrderShipmentStateDeletedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class OrderShipmentStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IOrderShipmentStateCreated>, IEnumerable<IOrderShipmentStateMergePatched>
    {
        private List<OrderShipmentStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<OrderShipmentStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual OrderShipmentStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<OrderShipmentStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrderShipmentStateCreated> IEnumerable<IOrderShipmentStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrderShipmentStateMergePatched> IEnumerable<IOrderShipmentStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddOrderShipmentEvent(IOrderShipmentStateCreated e)
        {
            _innerStateEvents.Add((OrderShipmentStateCreatedDto)e);
        }

        public void AddOrderShipmentEvent(IOrderShipmentEvent e)
        {
            _innerStateEvents.Add((OrderShipmentStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

