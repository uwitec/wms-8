﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{
    public partial class InOutAggregate : AggregateBase, IInOutAggregate
    {

        readonly IInOutState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IInOutState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public InOutAggregate(IInOutState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IInOutStateProperties)_state).Version == InOutState.VersionZero)
            {
                if (IsCommandCreate((IInOutCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IInOutCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IInOutCommand c)
        {
            return c.Version == InOutState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateInOut c)
        {
            IInOutStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchInOut c)
        {
            IInOutStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteInOut c)
        {
            IInOutStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IInOutStateCreated Map(ICreateInOut c)
        {
			var stateEventId = new InOutStateEventId(c.DocumentNumber, c.Version);
            IInOutStateCreated e = NewInOutStateCreated(stateEventId);
		
            NewInOutDocumentActionCommandAndExecute(c, _state, e);
            e.Posted = c.Posted;
            e.Processed = c.Processed;
            e.Processing = c.Processing;
            e.DocumentTypeId = c.DocumentTypeId;
            e.Description = c.Description;
            e.OrderId = c.OrderId;
            e.DateOrdered = c.DateOrdered;
            e.IsPrinted = c.IsPrinted;
            e.MovementTypeId = c.MovementTypeId;
            e.MovementDate = c.MovementDate;
            e.BusinessPartnerId = c.BusinessPartnerId;
            e.WarehouseId = c.WarehouseId;
            e.POReference = c.POReference;
            e.FreightAmount = c.FreightAmount;
            e.ShipperId = c.ShipperId;
            e.ChargeAmount = c.ChargeAmount;
            e.DatePrinted = c.DatePrinted;
            e.CreatedFrom = c.CreatedFrom;
            e.SalesRepresentativeId = c.SalesRepresentativeId;
            e.NumberOfPackages = c.NumberOfPackages;
            e.PickDate = c.PickDate;
            e.ShipDate = c.ShipDate;
            e.TrackingNumber = c.TrackingNumber;
            e.DateReceived = c.DateReceived;
            e.IsInTransit = c.IsInTransit;
            e.IsApproved = c.IsApproved;
            e.IsInDispute = c.IsInDispute;
            e.RmaDocumentNumber = c.RmaDocumentNumber;
            e.ReversalDocumentNumber = c.ReversalDocumentNumber;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;

            foreach (ICreateInOutLine innerCommand in c.InOutLines)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IInOutLineStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddInOutLineEvent(innerEvent);
            }


            return e;
        }

        protected virtual IInOutStateMergePatched Map(IMergePatchInOut c)
        {
			var stateEventId = new InOutStateEventId(c.DocumentNumber, c.Version);
            IInOutStateMergePatched e = NewInOutStateMergePatched(stateEventId);

            NewInOutDocumentActionCommandAndExecute(c, _state, e);
            e.Posted = c.Posted;
            e.Processed = c.Processed;
            e.Processing = c.Processing;
            e.DocumentTypeId = c.DocumentTypeId;
            e.Description = c.Description;
            e.OrderId = c.OrderId;
            e.DateOrdered = c.DateOrdered;
            e.IsPrinted = c.IsPrinted;
            e.MovementTypeId = c.MovementTypeId;
            e.MovementDate = c.MovementDate;
            e.BusinessPartnerId = c.BusinessPartnerId;
            e.WarehouseId = c.WarehouseId;
            e.POReference = c.POReference;
            e.FreightAmount = c.FreightAmount;
            e.ShipperId = c.ShipperId;
            e.ChargeAmount = c.ChargeAmount;
            e.DatePrinted = c.DatePrinted;
            e.CreatedFrom = c.CreatedFrom;
            e.SalesRepresentativeId = c.SalesRepresentativeId;
            e.NumberOfPackages = c.NumberOfPackages;
            e.PickDate = c.PickDate;
            e.ShipDate = c.ShipDate;
            e.TrackingNumber = c.TrackingNumber;
            e.DateReceived = c.DateReceived;
            e.IsInTransit = c.IsInTransit;
            e.IsApproved = c.IsApproved;
            e.IsInDispute = c.IsInDispute;
            e.RmaDocumentNumber = c.RmaDocumentNumber;
            e.ReversalDocumentNumber = c.ReversalDocumentNumber;
            e.Active = c.Active;
            e.IsPropertyPostedRemoved = c.IsPropertyPostedRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyProcessingRemoved = c.IsPropertyProcessingRemoved;
            e.IsPropertyDocumentTypeIdRemoved = c.IsPropertyDocumentTypeIdRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyOrderIdRemoved = c.IsPropertyOrderIdRemoved;
            e.IsPropertyDateOrderedRemoved = c.IsPropertyDateOrderedRemoved;
            e.IsPropertyIsPrintedRemoved = c.IsPropertyIsPrintedRemoved;
            e.IsPropertyMovementTypeIdRemoved = c.IsPropertyMovementTypeIdRemoved;
            e.IsPropertyMovementDateRemoved = c.IsPropertyMovementDateRemoved;
            e.IsPropertyBusinessPartnerIdRemoved = c.IsPropertyBusinessPartnerIdRemoved;
            e.IsPropertyWarehouseIdRemoved = c.IsPropertyWarehouseIdRemoved;
            e.IsPropertyPOReferenceRemoved = c.IsPropertyPOReferenceRemoved;
            e.IsPropertyFreightAmountRemoved = c.IsPropertyFreightAmountRemoved;
            e.IsPropertyShipperIdRemoved = c.IsPropertyShipperIdRemoved;
            e.IsPropertyChargeAmountRemoved = c.IsPropertyChargeAmountRemoved;
            e.IsPropertyDatePrintedRemoved = c.IsPropertyDatePrintedRemoved;
            e.IsPropertyCreatedFromRemoved = c.IsPropertyCreatedFromRemoved;
            e.IsPropertySalesRepresentativeIdRemoved = c.IsPropertySalesRepresentativeIdRemoved;
            e.IsPropertyNumberOfPackagesRemoved = c.IsPropertyNumberOfPackagesRemoved;
            e.IsPropertyPickDateRemoved = c.IsPropertyPickDateRemoved;
            e.IsPropertyShipDateRemoved = c.IsPropertyShipDateRemoved;
            e.IsPropertyTrackingNumberRemoved = c.IsPropertyTrackingNumberRemoved;
            e.IsPropertyDateReceivedRemoved = c.IsPropertyDateReceivedRemoved;
            e.IsPropertyIsInTransitRemoved = c.IsPropertyIsInTransitRemoved;
            e.IsPropertyIsApprovedRemoved = c.IsPropertyIsApprovedRemoved;
            e.IsPropertyIsInDisputeRemoved = c.IsPropertyIsInDisputeRemoved;
            e.IsPropertyRmaDocumentNumberRemoved = c.IsPropertyRmaDocumentNumberRemoved;
            e.IsPropertyReversalDocumentNumberRemoved = c.IsPropertyReversalDocumentNumberRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;

            foreach (IInOutLineCommand innerCommand in c.InOutLineCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IInOutLineStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddInOutLineEvent(innerEvent);
            }


            return e;
        }

        protected virtual IInOutStateDeleted Map(IDeleteInOut c)
        {
			var stateEventId = new InOutStateEventId(c.DocumentNumber, c.Version);
            IInOutStateDeleted e = NewInOutStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();


            return e;
        }


        protected void ThrowOnInconsistentCommands(IInOutCommand command, IInOutLineCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeleteInOut;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemoveInOutLine;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.InOutDocumentNumber == default(string))
            {
                innerProperties.InOutDocumentNumber = properties.DocumentNumber;
            }
            else
            {
                var outerDocumentNumberName = "DocumentNumber";
                var outerDocumentNumberValue = properties.DocumentNumber;
                var innerInOutDocumentNumberName = "InOutDocumentNumber";
                var innerInOutDocumentNumberValue = innerProperties.InOutDocumentNumber;
                ThrowOnInconsistentIds(innerProperties, innerInOutDocumentNumberName, innerInOutDocumentNumberValue, outerDocumentNumberName, outerDocumentNumberValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IInOutLineStateEvent Map(IInOutLineCommand c, IInOutCommand outerCommand, long version, IInOutState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreateInOutLine) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchInOutLine) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemoveInOutLine) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IInOutLineStateCreated MapCreate(ICreateInOutLine c, IInOutCommand outerCommand, long version, IInOutState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new InOutLineStateEventId(c.InOutDocumentNumber, c.LineNumber, version);
            IInOutLineStateCreated e = NewInOutLineStateCreated(stateEventId);
            var s = outerState.InOutLines.Get(c.LineNumber, true);

            e.LocatorId = c.LocatorId;
            e.ProductId = c.ProductId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.Description = c.Description;
            e.QuantityUomId = c.QuantityUomId;
            e.MovementQuantity = c.MovementQuantity;
            e.PickedQuantity = c.PickedQuantity;
            e.IsInvoiced = c.IsInvoiced;
            e.Processed = c.Processed;
            e.RmaLineNumber = c.RmaLineNumber;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IInOutLineStateMergePatched MapMergePatch(IMergePatchInOutLine c, IInOutCommand outerCommand, long version, IInOutState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new InOutLineStateEventId(c.InOutDocumentNumber, c.LineNumber, version);
            IInOutLineStateMergePatched e = NewInOutLineStateMergePatched(stateEventId);
            var s = outerState.InOutLines.Get(c.LineNumber);

            e.LocatorId = c.LocatorId;
            e.ProductId = c.ProductId;
            e.AttributeSetInstanceId = c.AttributeSetInstanceId;
            e.Description = c.Description;
            e.QuantityUomId = c.QuantityUomId;
            e.MovementQuantity = c.MovementQuantity;
            e.PickedQuantity = c.PickedQuantity;
            e.IsInvoiced = c.IsInvoiced;
            e.Processed = c.Processed;
            e.RmaLineNumber = c.RmaLineNumber;
            e.ReversalLineNumber = c.ReversalLineNumber;
            e.Active = c.Active;
            e.IsPropertyLocatorIdRemoved = c.IsPropertyLocatorIdRemoved;
            e.IsPropertyProductIdRemoved = c.IsPropertyProductIdRemoved;
            e.IsPropertyAttributeSetInstanceIdRemoved = c.IsPropertyAttributeSetInstanceIdRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyQuantityUomIdRemoved = c.IsPropertyQuantityUomIdRemoved;
            e.IsPropertyMovementQuantityRemoved = c.IsPropertyMovementQuantityRemoved;
            e.IsPropertyPickedQuantityRemoved = c.IsPropertyPickedQuantityRemoved;
            e.IsPropertyIsInvoicedRemoved = c.IsPropertyIsInvoicedRemoved;
            e.IsPropertyProcessedRemoved = c.IsPropertyProcessedRemoved;
            e.IsPropertyRmaLineNumberRemoved = c.IsPropertyRmaLineNumberRemoved;
            e.IsPropertyReversalLineNumberRemoved = c.IsPropertyReversalLineNumberRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IInOutLineStateRemoved MapRemove(IRemoveInOutLine c, IInOutCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new InOutLineStateEventId(c.InOutDocumentNumber, c.LineNumber, version);
            IInOutLineStateRemoved e = NewInOutLineStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;

        }// END Map(IRemove... ////////////////////////////

        protected void NewInOutDocumentActionCommandAndExecute(IMergePatchInOut c, IInOutState s, IInOutStateMergePatched e)
        {
            var pCommandHandler = this.InOutDocumentActionCommandHandler;
            var pCmdContent = c.DocumentAction;
            var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => s.DocumentStatusId, SetState = p => e.DocumentStatusId = p, OuterCommandType = CommandType.MergePatch };
            pCommandHandler.Execute(pCmd);
        }

        protected void NewInOutDocumentActionCommandAndExecute(ICreateInOut c, IInOutState s, IInOutStateCreated e)
        {
            var pCommandHandler = this.InOutDocumentActionCommandHandler;
            var pCmdContent = c.DocumentAction;
            var pCmd = new PropertyCommand<string, string> { Content = pCmdContent, GetState = () => s.DocumentStatusId, SetState = p => e.DocumentStatusId = p, OuterCommandType = CommandType.Create };
            pCommandHandler.Execute(pCmd);
        }

        protected IPropertyCommandHandler<string, string> InOutDocumentActionCommandHandler
        {
            get
            {
                return ApplicationContext.Current["InOutDocumentActionCommandHandler"] as IPropertyCommandHandler<string, string>;
            }
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected InOutStateCreated NewInOutStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new InOutStateEventId(_state.DocumentNumber, ((IInOutStateProperties)_state).Version);
            var e = NewInOutStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected InOutStateMergePatched NewInOutStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new InOutStateEventId(_state.DocumentNumber, ((IInOutStateProperties)_state).Version);
            var e = NewInOutStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected InOutStateDeleted NewInOutStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new InOutStateEventId(_state.DocumentNumber, ((IInOutStateProperties)_state).Version);
            var e = NewInOutStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private InOutStateCreated NewInOutStateCreated(InOutStateEventId stateEventId)
		{
			return new InOutStateCreated(stateEventId);			
		}

        private InOutStateMergePatched NewInOutStateMergePatched(InOutStateEventId stateEventId)
		{
			return new InOutStateMergePatched(stateEventId);
		}

        private InOutStateDeleted NewInOutStateDeleted(InOutStateEventId stateEventId)
		{
			return new InOutStateDeleted(stateEventId);
		}

		private InOutLineStateCreated NewInOutLineStateCreated(InOutLineStateEventId stateEventId)
		{
			return new InOutLineStateCreated(stateEventId);
		}

        private InOutLineStateMergePatched NewInOutLineStateMergePatched(InOutLineStateEventId stateEventId)
		{
			return new InOutLineStateMergePatched(stateEventId);
		}

        private InOutLineStateRemoved NewInOutLineStateRemoved(InOutLineStateEventId stateEventId)
		{
			return new InOutLineStateRemoved(stateEventId);
		}


    }

}

