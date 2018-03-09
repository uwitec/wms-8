﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{

	public abstract class InventoryItemRequirementEntryCommandDtoBase : ICommandDto, ICreateInventoryItemRequirementEntry
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

		public virtual decimal? Quantity { get; set; }

		public virtual InventoryPRTriggeredId SourceEventId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual InventoryItemId InventoryItemRequirementId { get; set; }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto : InventoryItemRequirementEntryCommandDtoBase
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



	public class CreateInventoryItemRequirementEntryDto : CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto
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


	public class MergePatchInventoryItemRequirementEntryDto : CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto
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

	public class RemoveInventoryItemRequirementEntryDto : CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto
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


    public partial class CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDtos : IInventoryItemRequirementEntryCommands, ICreateInventoryItemRequirementEntryCommands, IEnumerable<CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto>
    {
        private List<CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto> _innerCommands = new List<CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto>();

        public virtual CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IInventoryItemRequirementEntryCommands.Add(IInventoryItemRequirementEntryCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto)c);
        }

        void IInventoryItemRequirementEntryCommands.Remove(IInventoryItemRequirementEntryCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto> IEnumerable<CreateOrMergePatchOrRemoveInventoryItemRequirementEntryDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IInventoryItemRequirementEntryCommand> IEnumerable<IInventoryItemRequirementEntryCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateInventoryItemRequirementEntryCommands.Add(ICreateInventoryItemRequirementEntry c)
        {
            _innerCommands.Add((CreateInventoryItemRequirementEntryDto)c);
        }

        void ICreateInventoryItemRequirementEntryCommands.Remove(ICreateInventoryItemRequirementEntry c)
        {
            _innerCommands.Remove((CreateInventoryItemRequirementEntryDto)c);
        }

        IEnumerator<ICreateInventoryItemRequirementEntry> IEnumerable<ICreateInventoryItemRequirementEntry>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

}

