﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItem;

namespace Dddml.Wms.Domain.ShipmentItem
{

	public abstract class ShipmentItemCommandBase : IShipmentItemCommand
	{
		public virtual ShipmentItemId ShipmentItemId { get; set; }


		ShipmentItemId IAggregateCommand<ShipmentItemId, long>.AggregateId
		{
			get
			{
				return this.ShipmentItemId;
			}
		}


		long IAggregateCommand<ShipmentItemId, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

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

		public virtual string ProductId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual string ShipmentContentDescription { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateShipmentItem : ShipmentItemCommandBase, ICreateShipmentItem
	{
		
		public CreateShipmentItem ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchShipmentItem :ShipmentItemCommandBase, IMergePatchShipmentItem
	{

		public virtual bool IsPropertyProductIdRemoved { get; set; }

		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyShipmentContentDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchShipmentItem ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteShipmentItem : ShipmentItemCommandBase, IDeleteShipmentItem
	{
		public DeleteShipmentItem ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class ShipmentItemCommands
    {
    }

}