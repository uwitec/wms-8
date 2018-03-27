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

	public abstract class OrderItemCommandDtoBase : ICommandDto, ICreateOrderItem, IMergePatchOrderItem, IRemoveOrderItem
	{

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual string OrderItemSeqId { get; set; }

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

		public virtual string OrderId { get; set; }

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyProductIdRemoved
        {
            get
            {
                var b = this.IsPropertyProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyExternalProductIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyExternalProductIdRemoved
        {
            get
            {
                var b = this.IsPropertyExternalProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyExternalProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyCancelQuantityRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyCancelQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyCancelQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCancelQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertySelectedAmountRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertySelectedAmountRemoved
        {
            get
            {
                var b = this.IsPropertySelectedAmountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertySelectedAmountRemoved = value;
            }
        }

		public virtual bool? IsPropertyExternalIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyExternalIdRemoved
        {
            get
            {
                var b = this.IsPropertyExternalIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyExternalIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderItemTypeIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyOrderItemTypeIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderItemTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderItemTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyOrderItemGroupSeqIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyOrderItemGroupSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyOrderItemGroupSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOrderItemGroupSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsItemGroupPrimaryRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyIsItemGroupPrimaryRemoved
        {
            get
            {
                var b = this.IsPropertyIsItemGroupPrimaryRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsItemGroupPrimaryRemoved = value;
            }
        }

		public virtual bool? IsPropertyFromInventoryItemIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyFromInventoryItemIdRemoved
        {
            get
            {
                var b = this.IsPropertyFromInventoryItemIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyFromInventoryItemIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsPromoRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyIsPromoRemoved
        {
            get
            {
                var b = this.IsPropertyIsPromoRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsPromoRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuoteIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyQuoteIdRemoved
        {
            get
            {
                var b = this.IsPropertyQuoteIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyQuoteIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuoteItemSeqIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyQuoteItemSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyQuoteItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyQuoteItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShoppingListIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyShoppingListIdRemoved
        {
            get
            {
                var b = this.IsPropertyShoppingListIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShoppingListIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyShoppingListItemSeqIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyShoppingListItemSeqIdRemoved
        {
            get
            {
                var b = this.IsPropertyShoppingListItemSeqIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShoppingListItemSeqIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyUnitPriceRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyUnitPriceRemoved
        {
            get
            {
                var b = this.IsPropertyUnitPriceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUnitPriceRemoved = value;
            }
        }

		public virtual bool? IsPropertyUnitListPriceRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyUnitListPriceRemoved
        {
            get
            {
                var b = this.IsPropertyUnitListPriceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUnitListPriceRemoved = value;
            }
        }

		public virtual bool? IsPropertyUnitAverageCostRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyUnitAverageCostRemoved
        {
            get
            {
                var b = this.IsPropertyUnitAverageCostRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUnitAverageCostRemoved = value;
            }
        }

		public virtual bool? IsPropertyUnitRecurringPriceRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyUnitRecurringPriceRemoved
        {
            get
            {
                var b = this.IsPropertyUnitRecurringPriceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUnitRecurringPriceRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsModifiedPriceRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyIsModifiedPriceRemoved
        {
            get
            {
                var b = this.IsPropertyIsModifiedPriceRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsModifiedPriceRemoved = value;
            }
        }

		public virtual bool? IsPropertyRecurringFreqUomIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyRecurringFreqUomIdRemoved
        {
            get
            {
                var b = this.IsPropertyRecurringFreqUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyRecurringFreqUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyItemDescriptionRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyItemDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyItemDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyItemDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyCommentsRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyCommentsRemoved
        {
            get
            {
                var b = this.IsPropertyCommentsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCommentsRemoved = value;
            }
        }

		public virtual bool? IsPropertyCorrespondingPoIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyCorrespondingPoIdRemoved
        {
            get
            {
                var b = this.IsPropertyCorrespondingPoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCorrespondingPoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyStatusIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertyStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertySyncStatusIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertySyncStatusIdRemoved
        {
            get
            {
                var b = this.IsPropertySyncStatusIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertySyncStatusIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedShipDateRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyEstimatedShipDateRemoved
        {
            get
            {
                var b = this.IsPropertyEstimatedShipDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEstimatedShipDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyEstimatedDeliveryDateRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyEstimatedDeliveryDateRemoved
        {
            get
            {
                var b = this.IsPropertyEstimatedDeliveryDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyEstimatedDeliveryDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyAutoCancelDateRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyAutoCancelDateRemoved
        {
            get
            {
                var b = this.IsPropertyAutoCancelDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAutoCancelDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyDontCancelSetDateRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyDontCancelSetDateRemoved
        {
            get
            {
                var b = this.IsPropertyDontCancelSetDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDontCancelSetDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyDontCancelSetByRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyDontCancelSetByRemoved
        {
            get
            {
                var b = this.IsPropertyDontCancelSetByRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDontCancelSetByRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipBeforeDateRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyShipBeforeDateRemoved
        {
            get
            {
                var b = this.IsPropertyShipBeforeDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShipBeforeDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyShipAfterDateRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyShipAfterDateRemoved
        {
            get
            {
                var b = this.IsPropertyShipAfterDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyShipAfterDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyCancelBackOrderDateRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyCancelBackOrderDateRemoved
        {
            get
            {
                var b = this.IsPropertyCancelBackOrderDateRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCancelBackOrderDateRemoved = value;
            }
        }

		public virtual bool? IsPropertyOverrideGlAccountIdRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyOverrideGlAccountIdRemoved
        {
            get
            {
                var b = this.IsPropertyOverrideGlAccountIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyOverrideGlAccountIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchOrderItem.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrRemoveOrderItemDto : OrderItemCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateOrderItemDto : CreateOrMergePatchOrRemoveOrderItemDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchOrderItemDto : CreateOrMergePatchOrRemoveOrderItemDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class RemoveOrderItemDto : CreateOrMergePatchOrRemoveOrderItemDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}


    public partial class CreateOrMergePatchOrRemoveOrderItemDtos : IOrderItemCommands, ICreateOrderItemCommands, IEnumerable<CreateOrMergePatchOrRemoveOrderItemDto>
    {
        private List<CreateOrMergePatchOrRemoveOrderItemDto> _innerCommands = new List<CreateOrMergePatchOrRemoveOrderItemDto>();

        public virtual CreateOrMergePatchOrRemoveOrderItemDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveOrderItemDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IOrderItemCommands.Add(IOrderItemCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveOrderItemDto)c);
        }

        void IOrderItemCommands.Remove(IOrderItemCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveOrderItemDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveOrderItemDto> IEnumerable<CreateOrMergePatchOrRemoveOrderItemDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IOrderItemCommand> IEnumerable<IOrderItemCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateOrderItemCommands.Add(ICreateOrderItem c)
        {
            _innerCommands.Add((CreateOrderItemDto)c);
        }

        void ICreateOrderItemCommands.Remove(ICreateOrderItem c)
        {
            _innerCommands.Remove((CreateOrderItemDto)c);
        }

        IEnumerator<ICreateOrderItem> IEnumerable<ICreateOrderItem>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

}

