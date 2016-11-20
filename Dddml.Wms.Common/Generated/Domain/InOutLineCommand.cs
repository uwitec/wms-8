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

	public abstract class InOutLineCommandBase : IInOutLineCommand
	{
		public virtual SkuId SkuId { get; set; }


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

		public virtual long? LineNumber { get; set; }

		public virtual string Description { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string Product { get; set; }

		public virtual string UomId { get; set; }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual decimal? ConfirmedQuantity { get; set; }

		public virtual decimal? ScrappedQuantity { get; set; }

		public virtual decimal? TargetQuantity { get; set; }

		public virtual decimal? PickedQuantity { get; set; }

		public virtual bool? IsInvoiced { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual bool? IsDescription { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual decimal? QuantityEntered { get; set; }

		public virtual long? RmaLineNumber { get; set; }

		public virtual long? ReversalLineNumber { get; set; }

		public virtual bool? Active { get; set; }

		// Outer Id:

		public virtual string InOutDocumentNumber { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


    public abstract class InOutLineIdGeneratorBase : IIdGenerator<SkuId, ICreateInOutLine>
    {
        public abstract SkuId GenerateId(ICreateInOutLine command);

        public abstract SkuId GetNextId();

        public virtual SkuId GetOrGenerateId(ICreateInOutLine command, out bool reused)
        {
            throw new NotSupportedException();
        }

    }

	public class CreateInOutLine : InOutLineCommandBase, ICreateInOutLine
	{
		
		public CreateInOutLine ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchInOutLine :InOutLineCommandBase, IMergePatchInOutLine
	{

		public virtual bool IsPropertyLineNumberRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdRemoved { get; set; }

		public virtual bool IsPropertyProductRemoved { get; set; }

		public virtual bool IsPropertyUomIdRemoved { get; set; }

		public virtual bool IsPropertyMovementQuantityRemoved { get; set; }

		public virtual bool IsPropertyConfirmedQuantityRemoved { get; set; }

		public virtual bool IsPropertyScrappedQuantityRemoved { get; set; }

		public virtual bool IsPropertyTargetQuantityRemoved { get; set; }

		public virtual bool IsPropertyPickedQuantityRemoved { get; set; }

		public virtual bool IsPropertyIsInvoicedRemoved { get; set; }

		public virtual bool IsPropertyAttributeSetInstanceIdRemoved { get; set; }

		public virtual bool IsPropertyIsDescriptionRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyQuantityEnteredRemoved { get; set; }

		public virtual bool IsPropertyRmaLineNumberRemoved { get; set; }

		public virtual bool IsPropertyReversalLineNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchInOutLine ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class RemoveInOutLine : InOutLineCommandBase, IRemoveInOutLine
	{
		public RemoveInOutLine ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }
	}


}

