﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{

	public abstract class InventoryItemRequirementCommandBase : IInventoryItemRequirementCommand
	{
		public virtual InventoryItemId InventoryItemRequirementId { get; set; }


		InventoryItemId IAggregateCommand<InventoryItemId, long>.AggregateId
		{
			get
			{
				return this.InventoryItemRequirementId;
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

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateInventoryItemRequirement : InventoryItemRequirementCommandBase, ICreateInventoryItemRequirement
	{
		
		public CreateInventoryItemRequirement ()
		{
		}


        private CreateInventoryItemRequirementEntryCommands _entries = new CreateInventoryItemRequirementEntryCommands();

        public ICreateInventoryItemRequirementEntryCommands Entries
        {
            get
            {
                return this._entries;
            }
        }

        public CreateInventoryItemRequirementEntry NewCreateInventoryItemRequirementEntry()
        {
            var c = new CreateInventoryItemRequirementEntry();
            c.InventoryItemRequirementId = this.InventoryItemRequirementId;

            return c;
        }

        ICreateInventoryItemRequirementEntry ICreateInventoryItemRequirement.NewCreateInventoryItemRequirementEntry()
        {
            return this.NewCreateInventoryItemRequirementEntry();
        }



        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchInventoryItemRequirement :InventoryItemRequirementCommandBase, IMergePatchInventoryItemRequirement
	{

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchInventoryItemRequirement ()
		{
		}

        private InventoryItemRequirementEntryCommands _inventoryItemRequirementEntryCommands = new InventoryItemRequirementEntryCommands();

        public IInventoryItemRequirementEntryCommands InventoryItemRequirementEntryCommands
        {
            get
            {
                return this._inventoryItemRequirementEntryCommands;
            }
        }


        public CreateInventoryItemRequirementEntry NewCreateInventoryItemRequirementEntry()
        {
            var c = new CreateInventoryItemRequirementEntry();
            c.InventoryItemRequirementId = this.InventoryItemRequirementId;

            return c;
        }

        ICreateInventoryItemRequirementEntry IMergePatchInventoryItemRequirement.NewCreateInventoryItemRequirementEntry()
        {
            return this.NewCreateInventoryItemRequirementEntry();
        }


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteInventoryItemRequirement : InventoryItemRequirementCommandBase, IDeleteInventoryItemRequirement
	{
		public DeleteInventoryItemRequirement ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}


    public class CreateInventoryItemRequirementEntryCommands : ICreateInventoryItemRequirementEntryCommands
    {
        private List<ICreateInventoryItemRequirementEntry> _innerCommands = new List<ICreateInventoryItemRequirementEntry>();

        public void Add(ICreateInventoryItemRequirementEntry c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreateInventoryItemRequirementEntry c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreateInventoryItemRequirementEntry> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class InventoryItemRequirementEntryCommands : IInventoryItemRequirementEntryCommands
    {
        private List<IInventoryItemRequirementEntryCommand> _innerCommands = new List<IInventoryItemRequirementEntryCommand>();

        public void Add(IInventoryItemRequirementEntryCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IInventoryItemRequirementEntryCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IInventoryItemRequirementEntryCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public static partial class InventoryItemRequirementCommands
    {
    }

}
