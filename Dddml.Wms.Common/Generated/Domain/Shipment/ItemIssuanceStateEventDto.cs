﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public abstract class ItemIssuanceStateEventDtoBase : IEventDto, IItemIssuanceStateCreated, IItemIssuanceStateMergePatched, IItemIssuanceStateRemoved
	{

        private ItemIssuanceEventId _itemIssuanceEventId;

		protected internal virtual ItemIssuanceEventId ItemIssuanceEventId 
        {
            get 
            {
                if (_itemIssuanceEventId == null) { _itemIssuanceEventId = new ItemIssuanceEventId(); }
                return _itemIssuanceEventId;
            }
            set
            {
                _itemIssuanceEventId = value;
            }
        }

        public virtual string ItemIssuanceSeqId
        {
            get { return ItemIssuanceEventId.ItemIssuanceSeqId; }
            set { ItemIssuanceEventId.ItemIssuanceSeqId = value; }
        }

		public virtual string OrderId { get; set; }

		public virtual string OrderItemSeqId { get; set; }

		public virtual long? ShipGroupSeqId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string ShipmentItemSeqId { get; set; }

		public virtual string FixedAssetId { get; set; }

		public virtual string MaintHistSeqId { get; set; }

		public virtual DateTime? IssuedDateTime { get; set; }

		public virtual string IssuedByUserLoginId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual decimal? CancelQuantity { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ItemIssuanceEventId IGlobalIdentity<ItemIssuanceEventId>.GlobalId {
			get 
			{
				return this.ItemIssuanceEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IItemIssuanceEvent.ReadOnly
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

		public virtual bool? IsPropertyOrderIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyOrderIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOrderIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOrderIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderItemSeqIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyOrderItemSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOrderItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOrderItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipGroupSeqIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyShipGroupSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipGroupSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipGroupSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyProductIdRemoved
        {
            get 
            {
                var b = this.IsPropertyProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLocatorIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyLocatorIdRemoved
        {
            get 
            {
                var b = this.IsPropertyLocatorIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyLocatorIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyAttributeSetInstanceIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetInstanceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetInstanceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipmentItemSeqIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyShipmentItemSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShipmentItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipmentItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyFixedAssetIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyFixedAssetIdRemoved
        {
            get 
            {
                var b = this.IsPropertyFixedAssetIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFixedAssetIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMaintHistSeqIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyMaintHistSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyMaintHistSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyMaintHistSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyIssuedDateTimeRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyIssuedDateTimeRemoved
        {
            get 
            {
                var b = this.IsPropertyIssuedDateTimeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIssuedDateTimeRemoved = value;
            }
        }

		public virtual bool? IsPropertyIssuedByUserLoginIdRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyIssuedByUserLoginIdRemoved
        {
            get 
            {
                var b = this.IsPropertyIssuedByUserLoginIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIssuedByUserLoginIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyQuantityRemoved
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

		public virtual bool? IsPropertyCancelQuantityRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyCancelQuantityRemoved
        {
            get 
            {
                var b = this.IsPropertyCancelQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCancelQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IItemIssuanceStateMergePatched.IsPropertyActiveRemoved
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


        ItemIssuanceEventId IItemIssuanceEvent.ItemIssuanceEventId
        {
            get { return this.ItemIssuanceEventId; }
        }

        protected ItemIssuanceStateEventDtoBase()
        {
        }

        protected ItemIssuanceStateEventDtoBase(ItemIssuanceEventId stateEventId)
        {
            this.ItemIssuanceEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto : ItemIssuanceStateEventDtoBase
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



	public class ItemIssuanceStateCreatedDto : ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto
	{
		public ItemIssuanceStateCreatedDto()
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


	public class ItemIssuanceStateMergePatchedDto : ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto
	{
		public ItemIssuanceStateMergePatchedDto()
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


	public class ItemIssuanceStateRemovedDto : ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto
	{
		public ItemIssuanceStateRemovedDto()
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
            return Dddml.Wms.Specialization.StateEventType.Removed;
        }

	}


    public partial class ItemIssuanceStateCreatedOrMergePatchedOrRemovedDtos : IEnumerable<IItemIssuanceStateCreated>, IEnumerable<IItemIssuanceStateMergePatched>, IEnumerable<IItemIssuanceStateRemoved>
    {
        private List<ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto> _innerStateEvents = new List<ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto>();

        public virtual ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IItemIssuanceStateCreated> IEnumerable<IItemIssuanceStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IItemIssuanceStateMergePatched> IEnumerable<IItemIssuanceStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IItemIssuanceStateRemoved> IEnumerable<IItemIssuanceStateRemoved>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddItemIssuanceEvent(IItemIssuanceStateCreated e)
        {
            _innerStateEvents.Add((ItemIssuanceStateCreatedDto)e);
        }

        public void AddItemIssuanceEvent(IItemIssuanceEvent e)
        {
            _innerStateEvents.Add((ItemIssuanceStateCreatedOrMergePatchedOrRemovedDto)e);
        }

        public void AddItemIssuanceEvent(IItemIssuanceStateRemoved e)
        {
            _innerStateEvents.Add((ItemIssuanceStateRemovedDto)e);
        }

    }


}

