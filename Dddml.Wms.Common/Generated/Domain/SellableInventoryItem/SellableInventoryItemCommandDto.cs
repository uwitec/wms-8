﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSellableInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.SellableInventoryItem
{

	public abstract class SellableInventoryItemCommandDtoBase : ICommandDto, ICreateSellableInventoryItem, IMergePatchSellableInventoryItem, IDeleteSellableInventoryItem
	{

		InventoryItemId IAggregateCommand<InventoryItemId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteSellableInventoryItem)this).SellableInventoryItemId;
			}
		}


		long IAggregateCommand<InventoryItemId, long>.AggregateVersion
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

		public virtual InventoryItemIdDto SellableInventoryItemId { get; set; }

		public virtual bool? Active { get; set; }


        InventoryItemId ISellableInventoryItemCommand.SellableInventoryItemId
        {
            get 
            {
                return this.SellableInventoryItemId.ToInventoryItemId();
            }
            set 
            {
                this.SellableInventoryItemId = new InventoryItemIdDtoWrapper(value);
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchSellableInventoryItem.IsPropertyActiveRemoved
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

        ICreateSellableInventoryItemEntryCommands ICreateSellableInventoryItem.Entries
        {
            get
            {
                return this._entries;
            }
        }

        ISellableInventoryItemEntryCommands IMergePatchSellableInventoryItem.SellableInventoryItemEntryCommands
        {
            get
            {
                return this._entries;
            }
        }

        public virtual CreateSellableInventoryItemEntryDto NewCreateSellableInventoryItemEntry()
        {
            var c = new CreateSellableInventoryItemEntryDto();
            c.SellableInventoryItemId = this.SellableInventoryItemId;

            return c;
        }

        ICreateSellableInventoryItemEntry ICreateSellableInventoryItem.NewCreateSellableInventoryItemEntry()
        {
            return this.NewCreateSellableInventoryItemEntry();
        }

        ICreateSellableInventoryItemEntry IMergePatchSellableInventoryItem.NewCreateSellableInventoryItemEntry()
        {
            return this.NewCreateSellableInventoryItemEntry();
        }

        public virtual MergePatchSellableInventoryItemEntryDto NewMergePatchSellableInventoryItemEntry()
        {
            var c = new MergePatchSellableInventoryItemEntryDto();
            c.SellableInventoryItemId = this.SellableInventoryItemId;

            return c;
        }

        public virtual RemoveSellableInventoryItemEntryDto NewRemoveSellableInventoryItemEntry()
        {
            var c = new RemoveSellableInventoryItemEntryDto();
            c.SellableInventoryItemId = this.SellableInventoryItemId;

            return c;
        }

        private CreateOrMergePatchOrRemoveSellableInventoryItemEntryDtos _entries = new CreateOrMergePatchOrRemoveSellableInventoryItemEntryDtos();

        public virtual CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto[] Entries
        {
            get
            {
                return _entries.ToArray();
            }
            set
            {
                _entries.Clear();
                _entries.AddRange(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteSellableInventoryItemDto : SellableInventoryItemCommandDtoBase
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



	public class CreateSellableInventoryItemDto : CreateOrMergePatchOrDeleteSellableInventoryItemDto
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


	public class MergePatchSellableInventoryItemDto : CreateOrMergePatchOrDeleteSellableInventoryItemDto
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

	public class DeleteSellableInventoryItemDto : CreateOrMergePatchOrDeleteSellableInventoryItemDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class SellableInventoryItemCommandDtos
    {

    }

}
