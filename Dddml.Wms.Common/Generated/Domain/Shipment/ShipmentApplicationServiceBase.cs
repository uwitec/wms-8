﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Shipment
{
	public abstract partial class ShipmentApplicationServiceBase : IShipmentApplicationService, IApplicationService
	{
		protected abstract IEventStore EventStore { get; }

		protected abstract IShipmentStateRepository StateRepository { get; }

		protected abstract IShipmentStateQueryRepository StateQueryRepository { get; }

        private IAggregateEventListener<IShipmentAggregate, IShipmentState> _aggregateEventListener;

        public virtual IAggregateEventListener<IShipmentAggregate, IShipmentState> AggregateEventListener
        {
            get { return _aggregateEventListener; }
            set { _aggregateEventListener = value; }
        }

		protected ShipmentApplicationServiceBase()
		{
		}

		protected virtual void Update(IShipmentCommand c, Action<IShipmentAggregate> action)
		{
			var aggregateId = c.AggregateId;
			var state = StateRepository.Get(aggregateId, false);
			var aggregate = GetShipmentAggregate(state);

			var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);

			var repeated = IsRepeatedCommand(c, eventStoreAggregateId, state);
			if (repeated) { return; }

			aggregate.ThrowOnInvalidStateTransition(c);
			action(aggregate);
			Persist(eventStoreAggregateId, aggregate, state);
		}

        private void Persist(IEventStoreAggregateId eventStoreAggregateId, IShipmentAggregate aggregate, IShipmentState state)
        {
            EventStore.AppendEvents(eventStoreAggregateId, ((IShipmentStateProperties)state).Version, aggregate.Changes, () => { StateRepository.Save(state); });
            if (AggregateEventListener != null) 
            {
                AggregateEventListener.EventAppended(new AggregateEvent<IShipmentAggregate, IShipmentState>(aggregate, state, aggregate.Changes));
            }
        }

        public virtual void Initialize(IShipmentStateCreated stateCreated)
        {
            var aggregateId = stateCreated.ShipmentEventId.ShipmentId;
            var state = new ShipmentState();
            state.ShipmentId = aggregateId;
            var aggregate = (ShipmentAggregate)GetShipmentAggregate(state);

            var eventStoreAggregateId = ToEventStoreAggregateId(aggregateId);
            aggregate.Apply(stateCreated);
            Persist(eventStoreAggregateId, aggregate, state);
        }

		protected bool IsRepeatedCommand(IShipmentCommand command, IEventStoreAggregateId eventStoreAggregateId, IShipmentState state)
		{
			bool repeated = false;
			if (((IShipmentStateProperties)state).Version > command.AggregateVersion)
			{
				var lastEvent = EventStore.GetEvent(typeof(IShipmentEvent), eventStoreAggregateId, command.AggregateVersion);
				if (lastEvent != null && lastEvent.CommandId == command.CommandId)
				{
					repeated = true;
				}
			}
			return repeated;
		}


		public virtual void Execute(object command)
		{
			((dynamic)this).When((dynamic)command);
		}


		public virtual void When(ICreateShipment c)
		{
			Update(c, ar => ar.Create(c));
		}

		public virtual void When(IMergePatchShipment c)
		{
			Update(c, ar => ar.MergePatch(c));
		}

		public virtual void When(ShipmentCommands.Import c)
		{
			Update(c, ar => ar.Import(c.ShipmentTypeId, c.PrimaryOrderId, c.PrimaryReturnId, c.BolNumber, c.VehicleId, c.SealNumber, c.PoNumber, c.Carrier, c.DateShipped, c.EstimatedReadyDate, c.EstimatedShipDate, c.EstimatedArrivalDate, c.LatestCancelDate, c.EstimatedShipCost, c.CurrencyUomId, c.HandlingInstructions, c.OriginFacilityId, c.DestinationFacilityId, c.PartyIdTo, c.PartyIdFrom, c.AdditionalShippingCharge, c.AddtlShippingChargeDesc, c.ShipmentItems, c.Version, c.CommandId, c.RequesterId));
		}

		public virtual void When(ShipmentCommands.Ship c)
		{
			Update(c, ar => ar.Ship(c.Version, c.CommandId, c.RequesterId));
		}

		public virtual void When(ShipmentCommands.ReceiveItem c)
		{
			Update(c, ar => ar.ReceiveItem(c.ShipmentItemSeqId, c.AttributeSetInstance, c.RejectionReasonId, c.DamageStatusId, c.DamageReasonId, c.AcceptedQuantity, c.RejectedQuantity, c.DamagedQuantity, c.ItemDescription, c.Version, c.CommandId, c.RequesterId));
		}

		public virtual void When(ShipmentCommands.AddItemAndReceipt c)
		{
			Update(c, ar => ar.AddItemAndReceipt(c.ReceiptSeqId, c.ProductId, c.AttributeSetInstance, c.RejectionReasonId, c.DamageStatusId, c.DamageReasonId, c.AcceptedQuantity, c.RejectedQuantity, c.DamagedQuantity, c.ItemDescription, c.Version, c.CommandId, c.RequesterId));
		}

		public virtual void When(ShipmentCommands.ConfirmAllItemsReceived c)
		{
			Update(c, ar => ar.ConfirmAllItemsReceived(c.DestinationLocatorId, c.Version, c.CommandId, c.RequesterId));
		}

        public virtual IShipmentState Get(string shipmentId)
        {
            var state = StateRepository.Get(shipmentId, true);
            return state;
        }

        public virtual IEnumerable<IShipmentState> GetAll(int firstResult, int maxResults)
		{
            var states = StateQueryRepository.GetAll(firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IShipmentState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IShipmentState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
		{
            var states = StateQueryRepository.Get(filter, orders, firstResult, maxResults);
			return states;
		}

        public virtual IEnumerable<IShipmentState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            var states = StateQueryRepository.GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults);
			return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

        public virtual long GetCount(ICriterion filter)
		{
            return StateQueryRepository.GetCount(filter);
		}

	    public virtual IShipmentEvent GetEvent(string shipmentId, long version)
        {
            var e = (IShipmentEvent)EventStore.GetEvent(ToEventStoreAggregateId(shipmentId), version);
            if (e != null)
            {
                e.ReadOnly = true;
            }
            else if (version == -1)
            {
                return GetEvent(shipmentId, 0);
            }
            return e;
        }

        public virtual IShipmentState GetHistoryState(string shipmentId, long version)
        {
            var eventStream = EventStore.LoadEventStream(typeof(IShipmentEvent), ToEventStoreAggregateId(shipmentId), version - 1);
            return new ShipmentState(eventStream.Events);
        }

        public virtual IShipmentImageState GetShipmentImage(string shipmentId, string sequenceId)
        {
            return StateQueryRepository.GetShipmentImage(shipmentId, sequenceId);
        }

        public IEnumerable<IShipmentImageState> GetShipmentImages(string shipmentId)
        {
            return StateQueryRepository.GetShipmentImages(shipmentId);
        }

        public virtual IShipmentItemState GetShipmentItem(string shipmentId, string shipmentItemSeqId)
        {
            return StateQueryRepository.GetShipmentItem(shipmentId, shipmentItemSeqId);
        }

        public IEnumerable<IShipmentItemState> GetShipmentItems(string shipmentId)
        {
            return StateQueryRepository.GetShipmentItems(shipmentId);
        }

        public virtual IShipmentReceiptState GetShipmentReceipt(string shipmentId, string receiptSeqId)
        {
            return StateQueryRepository.GetShipmentReceipt(shipmentId, receiptSeqId);
        }

        public IEnumerable<IShipmentReceiptState> GetShipmentReceipts(string shipmentId)
        {
            return StateQueryRepository.GetShipmentReceipts(shipmentId);
        }

        public virtual IShipmentReceiptImageState GetShipmentReceiptImage(string shipmentId, string shipmentReceiptReceiptSeqId, string sequenceId)
        {
            return StateQueryRepository.GetShipmentReceiptImage(shipmentId, shipmentReceiptReceiptSeqId, sequenceId);
        }

        public IEnumerable<IShipmentReceiptImageState> GetShipmentReceiptImages(string shipmentId, string shipmentReceiptReceiptSeqId)
        {
            return StateQueryRepository.GetShipmentReceiptImages(shipmentId, shipmentReceiptReceiptSeqId);
        }

        public virtual IItemIssuanceState GetItemIssuance(string shipmentId, string itemIssuanceSeqId)
        {
            return StateQueryRepository.GetItemIssuance(shipmentId, itemIssuanceSeqId);
        }

        public IEnumerable<IItemIssuanceState> GetItemIssuances(string shipmentId)
        {
            return StateQueryRepository.GetItemIssuances(shipmentId);
        }


		public abstract IShipmentAggregate GetShipmentAggregate(IShipmentState state);

		public abstract IEventStoreAggregateId ToEventStoreAggregateId(string aggregateId);


	}

}

