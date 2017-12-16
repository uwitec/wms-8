﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItem;

namespace Dddml.Wms.Domain.OrderItem
{

	public abstract class OrderItemStateEventDtoBase : IStateEventDto, IOrderItemStateCreated, IOrderItemStateMergePatched
	{

        private OrderItemStateEventIdDto _stateEventId;

		protected internal virtual OrderItemStateEventIdDto StateEventId 
        {
            get 
            {
                if (_stateEventId == null) { _stateEventId = new OrderItemStateEventIdDto(); }
                return _stateEventId;
            }
            set
            {
                _stateEventId = value;
            }
        }

        public virtual OrderItemIdDto OrderItemId
        {
            get { return StateEventId.OrderItemId; }
            set { StateEventId.OrderItemId = value; }
        }

        public virtual long Version
        {
            get { return StateEventId.Version; }
            set { StateEventId.Version = value; }
        }

		public virtual string ProductId { get; set; }

		public virtual string ExternalProductId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual decimal? CancelQuantity { get; set; }

		public virtual decimal? SelectedAmount { get; set; }

		public virtual string ExternalId { get; set; }

		public virtual string OrderItemTypeId { get; set; }

		public virtual string OrderItemGroupSeqId { get; set; }

		public virtual string IsItemGroupPrimary { get; set; }

		public virtual string FromInventoryItemId { get; set; }

		public virtual string IsPromo { get; set; }

		public virtual string QuoteId { get; set; }

		public virtual string QuoteItemSeqId { get; set; }

		public virtual string ShoppingListId { get; set; }

		public virtual string ShoppingListItemSeqId { get; set; }

		public virtual decimal? UnitPrice { get; set; }

		public virtual decimal? UnitListPrice { get; set; }

		public virtual decimal? UnitAverageCost { get; set; }

		public virtual decimal? UnitRecurringPrice { get; set; }

		public virtual string IsModifiedPrice { get; set; }

		public virtual string RecurringFreqUomId { get; set; }

		public virtual string ItemDescription { get; set; }

		public virtual string Comments { get; set; }

		public virtual string CorrespondingPoId { get; set; }

		public virtual string StatusId { get; set; }

		public virtual string SyncStatusId { get; set; }

		public virtual DateTime? EstimatedShipDate { get; set; }

		public virtual DateTime? EstimatedDeliveryDate { get; set; }

		public virtual DateTime? AutoCancelDate { get; set; }

		public virtual DateTime? DontCancelSetDate { get; set; }

		public virtual string DontCancelSetBy { get; set; }

		public virtual DateTime? ShipBeforeDate { get; set; }

		public virtual DateTime? ShipAfterDate { get; set; }

		public virtual DateTime? CancelBackOrderDate { get; set; }

		public virtual string OverrideGlAccountId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		OrderItemStateEventId IGlobalIdentity<OrderItemStateEventId>.GlobalId {
			get 
			{
				return this.StateEventId.ToOrderItemStateEventId();
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IOrderItemStateEvent.ReadOnly
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

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyProductIdRemoved
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

		public virtual bool? IsPropertyExternalProductIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyExternalProductIdRemoved
        {
            get 
            {
                var b = this.IsPropertyExternalProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyExternalProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyQuantityRemoved
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

        bool IOrderItemStateMergePatched.IsPropertyCancelQuantityRemoved
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

		public virtual bool? IsPropertySelectedAmountRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertySelectedAmountRemoved
        {
            get 
            {
                var b = this.IsPropertySelectedAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySelectedAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyExternalIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyExternalIdRemoved
        {
            get 
            {
                var b = this.IsPropertyExternalIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyExternalIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderItemTypeIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyOrderItemTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOrderItemTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOrderItemTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderItemGroupSeqIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyOrderItemGroupSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOrderItemGroupSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOrderItemGroupSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsItemGroupPrimaryRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyIsItemGroupPrimaryRemoved
        {
            get 
            {
                var b = this.IsPropertyIsItemGroupPrimaryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsItemGroupPrimaryRemoved = value;
            }
        }

		public virtual bool? IsPropertyFromInventoryItemIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyFromInventoryItemIdRemoved
        {
            get 
            {
                var b = this.IsPropertyFromInventoryItemIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyFromInventoryItemIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsPromoRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyIsPromoRemoved
        {
            get 
            {
                var b = this.IsPropertyIsPromoRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsPromoRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuoteIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyQuoteIdRemoved
        {
            get 
            {
                var b = this.IsPropertyQuoteIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuoteIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuoteItemSeqIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyQuoteItemSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyQuoteItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyQuoteItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShoppingListIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyShoppingListIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShoppingListIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShoppingListIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShoppingListItemSeqIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyShoppingListItemSeqIdRemoved
        {
            get 
            {
                var b = this.IsPropertyShoppingListItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShoppingListItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyUnitPriceRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyUnitPriceRemoved
        {
            get 
            {
                var b = this.IsPropertyUnitPriceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUnitPriceRemoved = value;
            }
        }

		public virtual bool? IsPropertyUnitListPriceRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyUnitListPriceRemoved
        {
            get 
            {
                var b = this.IsPropertyUnitListPriceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUnitListPriceRemoved = value;
            }
        }

		public virtual bool? IsPropertyUnitAverageCostRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyUnitAverageCostRemoved
        {
            get 
            {
                var b = this.IsPropertyUnitAverageCostRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUnitAverageCostRemoved = value;
            }
        }

		public virtual bool? IsPropertyUnitRecurringPriceRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyUnitRecurringPriceRemoved
        {
            get 
            {
                var b = this.IsPropertyUnitRecurringPriceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyUnitRecurringPriceRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsModifiedPriceRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyIsModifiedPriceRemoved
        {
            get 
            {
                var b = this.IsPropertyIsModifiedPriceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyIsModifiedPriceRemoved = value;
            }
        }

		public virtual bool? IsPropertyRecurringFreqUomIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyRecurringFreqUomIdRemoved
        {
            get 
            {
                var b = this.IsPropertyRecurringFreqUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyRecurringFreqUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyItemDescriptionRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyItemDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyItemDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyItemDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyCommentsRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyCommentsRemoved
        {
            get 
            {
                var b = this.IsPropertyCommentsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCommentsRemoved = value;
            }
        }

		public virtual bool? IsPropertyCorrespondingPoIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyCorrespondingPoIdRemoved
        {
            get 
            {
                var b = this.IsPropertyCorrespondingPoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCorrespondingPoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyStatusIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertyStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertySyncStatusIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertySyncStatusIdRemoved
        {
            get 
            {
                var b = this.IsPropertySyncStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertySyncStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedShipDateRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyEstimatedShipDateRemoved
        {
            get 
            {
                var b = this.IsPropertyEstimatedShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyEstimatedShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedDeliveryDateRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyEstimatedDeliveryDateRemoved
        {
            get 
            {
                var b = this.IsPropertyEstimatedDeliveryDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyEstimatedDeliveryDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyAutoCancelDateRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyAutoCancelDateRemoved
        {
            get 
            {
                var b = this.IsPropertyAutoCancelDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAutoCancelDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyDontCancelSetDateRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyDontCancelSetDateRemoved
        {
            get 
            {
                var b = this.IsPropertyDontCancelSetDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDontCancelSetDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyDontCancelSetByRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyDontCancelSetByRemoved
        {
            get 
            {
                var b = this.IsPropertyDontCancelSetByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDontCancelSetByRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipBeforeDateRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyShipBeforeDateRemoved
        {
            get 
            {
                var b = this.IsPropertyShipBeforeDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipBeforeDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipAfterDateRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyShipAfterDateRemoved
        {
            get 
            {
                var b = this.IsPropertyShipAfterDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShipAfterDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyCancelBackOrderDateRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyCancelBackOrderDateRemoved
        {
            get 
            {
                var b = this.IsPropertyCancelBackOrderDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCancelBackOrderDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyOverrideGlAccountIdRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyOverrideGlAccountIdRemoved
        {
            get 
            {
                var b = this.IsPropertyOverrideGlAccountIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyOverrideGlAccountIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IOrderItemStateMergePatched.IsPropertyActiveRemoved
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


        OrderItemStateEventId IOrderItemStateEvent.StateEventId
        {
            get { return this.StateEventId.ToOrderItemStateEventId(); }
        }

        protected OrderItemStateEventDtoBase()
        {
        }

        protected OrderItemStateEventDtoBase(OrderItemStateEventIdDto stateEventId)
        {
            this.StateEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class OrderItemStateCreatedOrMergePatchedOrDeletedDto : OrderItemStateEventDtoBase
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



	public class OrderItemStateCreatedDto : OrderItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrderItemStateCreatedDto()
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


	public class OrderItemStateMergePatchedDto : OrderItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrderItemStateMergePatchedDto()
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


	public class OrderItemStateDeletedDto : OrderItemStateCreatedOrMergePatchedOrDeletedDto
	{
		public OrderItemStateDeletedDto()
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


    public partial class OrderItemStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IOrderItemStateCreated>, IEnumerable<IOrderItemStateMergePatched>
    {
        private List<OrderItemStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<OrderItemStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual OrderItemStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<OrderItemStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrderItemStateCreated> IEnumerable<IOrderItemStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IOrderItemStateMergePatched> IEnumerable<IOrderItemStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }


        public void AddOrderItemEvent(IOrderItemStateCreated e)
        {
            _innerStateEvents.Add((OrderItemStateCreatedDto)e);
        }

        public void AddOrderItemEvent(IOrderItemStateEvent e)
        {
            _innerStateEvents.Add((OrderItemStateCreatedOrMergePatchedOrDeletedDto)e);
        }


    }


}

