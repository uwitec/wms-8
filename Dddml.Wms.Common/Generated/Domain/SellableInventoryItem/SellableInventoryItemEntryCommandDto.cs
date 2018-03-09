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

	public abstract class SellableInventoryItemEntryCommandDtoBase : ICommandDto, ICreateSellableInventoryItemEntry
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

		public virtual long EntrySeqId { get; set; }

		public virtual decimal? SellableQuantity { get; set; }

		public virtual InventoryPRTriggeredId SourceEventId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual InventoryItemId SellableInventoryItemId { get; set; }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto : SellableInventoryItemEntryCommandDtoBase
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



	public class CreateSellableInventoryItemEntryDto : CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto
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


	public class MergePatchSellableInventoryItemEntryDto : CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto
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

	public class RemoveSellableInventoryItemEntryDto : CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto
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


    public partial class CreateOrMergePatchOrRemoveSellableInventoryItemEntryDtos : ISellableInventoryItemEntryCommands, ICreateSellableInventoryItemEntryCommands, IEnumerable<CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto>
    {
        private List<CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto> _innerCommands = new List<CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto>();

        public virtual CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void ISellableInventoryItemEntryCommands.Add(ISellableInventoryItemEntryCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto)c);
        }

        void ISellableInventoryItemEntryCommands.Remove(ISellableInventoryItemEntryCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto> IEnumerable<CreateOrMergePatchOrRemoveSellableInventoryItemEntryDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<ISellableInventoryItemEntryCommand> IEnumerable<ISellableInventoryItemEntryCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateSellableInventoryItemEntryCommands.Add(ICreateSellableInventoryItemEntry c)
        {
            _innerCommands.Add((CreateSellableInventoryItemEntryDto)c);
        }

        void ICreateSellableInventoryItemEntryCommands.Remove(ICreateSellableInventoryItemEntry c)
        {
            _innerCommands.Remove((CreateSellableInventoryItemEntryDto)c);
        }

        IEnumerator<ICreateSellableInventoryItemEntry> IEnumerable<ICreateSellableInventoryItemEntry>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

}

