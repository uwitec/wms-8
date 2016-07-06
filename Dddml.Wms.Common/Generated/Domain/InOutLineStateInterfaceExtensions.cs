﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;

namespace Dddml.Wms.Domain
{

	public static partial class InOutLineStateInterfaceExtensions
	{

        public static IInOutLineCommand ToCreateOrMergePatchInOutLine<TCreateInOutLine, TMergePatchInOutLine>(this IInOutLineState state)
            where TCreateInOutLine : ICreateInOutLine, new()
            where TMergePatchInOutLine : IMergePatchInOutLine, new()
        {
            bool bUnsaved = ((IInOutLineState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateInOutLine<TCreateInOutLine>();
            }
            else 
            {
                return state.ToMergePatchInOutLine<TMergePatchInOutLine>();
            }
        }

        public static TRemoveInOutLine ToRemoveInOutLine<TRemoveInOutLine>(this IInOutLineState state)
            where TRemoveInOutLine : IRemoveInOutLine, new()
        {
            var cmd = new TRemoveInOutLine();
            cmd.SkuId = state.SkuId;
            return cmd;
        }

        public static TMergePatchInOutLine ToMergePatchInOutLine<TMergePatchInOutLine>(this IInOutLineState state)
            where TMergePatchInOutLine : IMergePatchInOutLine, new()
        {
            var cmd = new TMergePatchInOutLine();

            cmd.SkuId = state.SkuId;
            cmd.LineNumber = state.LineNumber;
            cmd.Description = state.Description;
            cmd.LocatorId = state.LocatorId;
            cmd.Product = state.Product;
            cmd.UomId = state.UomId;
            cmd.MovementQuantity = state.MovementQuantity;
            cmd.ConfirmedQuantity = state.ConfirmedQuantity;
            cmd.ScrappedQuantity = state.ScrappedQuantity;
            cmd.TargetQuantity = state.TargetQuantity;
            cmd.PickedQuantity = state.PickedQuantity;
            cmd.IsInvoiced = state.IsInvoiced;
            cmd.AttributeSetInstanceId = state.AttributeSetInstanceId;
            cmd.IsDescription = state.IsDescription;
            cmd.Processed = state.Processed;
            cmd.QuantityEntered = state.QuantityEntered;
            cmd.RmaLineNumber = state.RmaLineNumber;
            cmd.ReversalLineNumber = state.ReversalLineNumber;
            cmd.Active = ((IInOutLineStateProperties)state).Active;
            cmd.InOutDocumentNumber = state.InOutDocumentNumber;
            
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            if (state.LocatorId == null) { cmd.IsPropertyLocatorIdRemoved = true; }
            if (state.Product == null) { cmd.IsPropertyProductRemoved = true; }
            if (state.UomId == null) { cmd.IsPropertyUomIdRemoved = true; }
            if (state.AttributeSetInstanceId == null) { cmd.IsPropertyAttributeSetInstanceIdRemoved = true; }
            return cmd;
        }

        public static TCreateInOutLine ToCreateInOutLine<TCreateInOutLine>(this IInOutLineState state)
            where TCreateInOutLine : ICreateInOutLine, new()
        {
            var cmd = new TCreateInOutLine();

            cmd.SkuId = state.SkuId;
            cmd.LineNumber = state.LineNumber;
            cmd.Description = state.Description;
            cmd.LocatorId = state.LocatorId;
            cmd.Product = state.Product;
            cmd.UomId = state.UomId;
            cmd.MovementQuantity = state.MovementQuantity;
            cmd.ConfirmedQuantity = state.ConfirmedQuantity;
            cmd.ScrappedQuantity = state.ScrappedQuantity;
            cmd.TargetQuantity = state.TargetQuantity;
            cmd.PickedQuantity = state.PickedQuantity;
            cmd.IsInvoiced = state.IsInvoiced;
            cmd.AttributeSetInstanceId = state.AttributeSetInstanceId;
            cmd.IsDescription = state.IsDescription;
            cmd.Processed = state.Processed;
            cmd.QuantityEntered = state.QuantityEntered;
            cmd.RmaLineNumber = state.RmaLineNumber;
            cmd.ReversalLineNumber = state.ReversalLineNumber;
            cmd.Active = ((IInOutLineStateProperties)state).Active;
            cmd.InOutDocumentNumber = state.InOutDocumentNumber;
            return cmd;
        }
		

	}

}

