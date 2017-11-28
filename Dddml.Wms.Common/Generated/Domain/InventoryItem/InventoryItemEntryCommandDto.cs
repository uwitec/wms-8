﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

	public abstract class InventoryItemEntryCommandDtoBase : ICommandDto, ICreateInventoryItemEntry
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

		public virtual decimal? QuantityOnHandVar { get; set; }

		public virtual decimal? QuantityReservedVar { get; set; }

		public virtual decimal? QuantityOccupiedVar { get; set; }

		public virtual decimal? QuantityVirtualVar { get; set; }


		public virtual InventoryItemEventVODto EventVO { get; set; }

        InventoryItemEventVO ICreateOrMergePatchOrRemoveInventoryItemEntry.EventVO
        {
            get 
            {
                return (this.EventVO == null) ? null : this.EventVO.ToInventoryItemEventVO();
            }
            set 
            {
                this.EventVO = (value == null) ? null : new InventoryItemEventVODtoWrapper(value);
            }
        }

		public virtual bool? Active { get; set; }


		public virtual InventoryItemIdDto InventoryItemId { get; set; }

        InventoryItemId IInventoryItemEntryCommand.InventoryItemId
        {
            get 
            {
                return (this.InventoryItemId == null) ? null : this.InventoryItemId.ToInventoryItemId();
            }
            set 
            {
                this.InventoryItemId = (value == null) ? null : new InventoryItemIdDtoWrapper(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrRemoveInventoryItemEntryDto : InventoryItemEntryCommandDtoBase
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



	public class CreateInventoryItemEntryDto : CreateOrMergePatchOrRemoveInventoryItemEntryDto
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


	public class MergePatchInventoryItemEntryDto : CreateOrMergePatchOrRemoveInventoryItemEntryDto
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

	public class RemoveInventoryItemEntryDto : CreateOrMergePatchOrRemoveInventoryItemEntryDto
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


    public partial class CreateOrMergePatchOrRemoveInventoryItemEntryDtos : IInventoryItemEntryCommands, ICreateInventoryItemEntryCommands, IEnumerable<CreateOrMergePatchOrRemoveInventoryItemEntryDto>
    {
        private List<CreateOrMergePatchOrRemoveInventoryItemEntryDto> _innerCommands = new List<CreateOrMergePatchOrRemoveInventoryItemEntryDto>();

        public virtual CreateOrMergePatchOrRemoveInventoryItemEntryDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveInventoryItemEntryDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IInventoryItemEntryCommands.Add(IInventoryItemEntryCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveInventoryItemEntryDto)c);
        }

        void IInventoryItemEntryCommands.Remove(IInventoryItemEntryCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveInventoryItemEntryDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveInventoryItemEntryDto> IEnumerable<CreateOrMergePatchOrRemoveInventoryItemEntryDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IInventoryItemEntryCommand> IEnumerable<IInventoryItemEntryCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateInventoryItemEntryCommands.Add(ICreateInventoryItemEntry c)
        {
            _innerCommands.Add((CreateInventoryItemEntryDto)c);
        }

        void ICreateInventoryItemEntryCommands.Remove(ICreateInventoryItemEntry c)
        {
            _innerCommands.Remove((CreateInventoryItemEntryDto)c);
        }

        IEnumerator<ICreateInventoryItemEntry> IEnumerable<ICreateInventoryItemEntry>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

}

