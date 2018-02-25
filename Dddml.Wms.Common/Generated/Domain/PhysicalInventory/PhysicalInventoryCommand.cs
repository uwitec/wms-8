﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePhysicalInventoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventory;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.PhysicalInventory
{

	public abstract class PhysicalInventoryCommandBase : IPhysicalInventoryCommand
	{
		public virtual string DocumentNumber { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.DocumentNumber;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
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

		public virtual string WarehouseId { get; set; }

		public virtual string LocatorIdPattern { get; set; }

		public virtual string ProductIdPattern { get; set; }

		public virtual bool? Posted { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string Processing { get; set; }

		public virtual string DocumentTypeId { get; set; }

		public virtual DateTime? MovementDate { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? IsApproved { get; set; }

		public virtual decimal? ApprovalAmount { get; set; }

		public virtual bool? IsQuantityUpdated { get; set; }

		public virtual string ReversalDocumentNumber { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreatePhysicalInventory : PhysicalInventoryCommandBase, ICreatePhysicalInventory
	{
		
		public CreatePhysicalInventory ()
		{
		}


        private CreatePhysicalInventoryLineCommands _physicalInventoryLines = new CreatePhysicalInventoryLineCommands();

        public ICreatePhysicalInventoryLineCommands PhysicalInventoryLines
        {
            get
            {
                return this._physicalInventoryLines;
            }
        }

        public CreatePhysicalInventoryLine NewCreatePhysicalInventoryLine()
        {
            var c = new CreatePhysicalInventoryLine();
            c.PhysicalInventoryDocumentNumber = this.DocumentNumber;

            return c;
        }

        ICreatePhysicalInventoryLine ICreatePhysicalInventory.NewCreatePhysicalInventoryLine()
        {
            return this.NewCreatePhysicalInventoryLine();
        }



        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchPhysicalInventory :PhysicalInventoryCommandBase, IMergePatchPhysicalInventory
	{

		public virtual bool IsPropertyWarehouseIdRemoved { get; set; }

		public virtual bool IsPropertyLocatorIdPatternRemoved { get; set; }

		public virtual bool IsPropertyProductIdPatternRemoved { get; set; }

		public virtual bool IsPropertyPostedRemoved { get; set; }

		public virtual bool IsPropertyProcessedRemoved { get; set; }

		public virtual bool IsPropertyProcessingRemoved { get; set; }

		public virtual bool IsPropertyDocumentTypeIdRemoved { get; set; }

		public virtual bool IsPropertyMovementDateRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyIsApprovedRemoved { get; set; }

		public virtual bool IsPropertyApprovalAmountRemoved { get; set; }

		public virtual bool IsPropertyIsQuantityUpdatedRemoved { get; set; }

		public virtual bool IsPropertyReversalDocumentNumberRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchPhysicalInventory ()
		{
		}

        private PhysicalInventoryLineCommands _physicalInventoryLineCommands = new PhysicalInventoryLineCommands();

        public IPhysicalInventoryLineCommands PhysicalInventoryLineCommands
        {
            get
            {
                return this._physicalInventoryLineCommands;
            }
        }


        public CreatePhysicalInventoryLine NewCreatePhysicalInventoryLine()
        {
            var c = new CreatePhysicalInventoryLine();
            c.PhysicalInventoryDocumentNumber = this.DocumentNumber;

            return c;
        }

        ICreatePhysicalInventoryLine IMergePatchPhysicalInventory.NewCreatePhysicalInventoryLine()
        {
            return this.NewCreatePhysicalInventoryLine();
        }

        public MergePatchPhysicalInventoryLine NewMergePatchPhysicalInventoryLine()
        {
            var c = new MergePatchPhysicalInventoryLine();
            c.PhysicalInventoryDocumentNumber = this.DocumentNumber;

            return c;
        }

        IMergePatchPhysicalInventoryLine IMergePatchPhysicalInventory.NewMergePatchPhysicalInventoryLine()
        {
            return this.NewMergePatchPhysicalInventoryLine();
        }


        public RemovePhysicalInventoryLine NewRemovePhysicalInventoryLine()
        {
            var c = new RemovePhysicalInventoryLine();
            c.PhysicalInventoryDocumentNumber = this.DocumentNumber;

            return c;
        }

        IRemovePhysicalInventoryLine IMergePatchPhysicalInventory.NewRemovePhysicalInventoryLine()
        {
            return this.NewRemovePhysicalInventoryLine();
        }


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeletePhysicalInventory : PhysicalInventoryCommandBase, IDeletePhysicalInventory
	{
		public DeletePhysicalInventory ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}


    public class CreatePhysicalInventoryLineCommands : ICreatePhysicalInventoryLineCommands
    {
        private List<ICreatePhysicalInventoryLine> _innerCommands = new List<ICreatePhysicalInventoryLine>();

        public void Add(ICreatePhysicalInventoryLine c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(ICreatePhysicalInventoryLine c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<ICreatePhysicalInventoryLine> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public class PhysicalInventoryLineCommands : IPhysicalInventoryLineCommands
    {
        private List<IPhysicalInventoryLineCommand> _innerCommands = new List<IPhysicalInventoryLineCommand>();

        public void Add(IPhysicalInventoryLineCommand c)
        {
            _innerCommands.Add(c);
        }

        public void Remove(IPhysicalInventoryLineCommand c)
        {
            _innerCommands.Remove(c);
        }

        public void Clear()
        {
            _innerCommands.Clear();
        }

        public IEnumerator<IPhysicalInventoryLineCommand> GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

    public static partial class PhysicalInventoryCommands
    {
        public class CountItem : IPhysicalInventoryCommand
        {

            public string CommandType
            {
                get { return "CountItem"; }
            }

            public string LocatorId { get; set; }

            public string ProductId { get; set; }

            public string AttributeSetInstanceId { get; set; }

            public decimal CountedQuantity { get; set; }

            public string DocumentNumber { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }


            string ICommand.CommandId
            {
                get
                {
                    return this.CommandId;
                }
                set
                {
                    this.CommandId = value;
                }
            }

            object ICommand.RequesterId
            {
                get { return this.RequesterId; }
                set { this.RequesterId = (string)value; }
            }

            string ICommandDto.CommandType
            {
                get { return this.CommandType; }
            }

            string IAggregateCommand<string, long>.AggregateId
            {
                get { return this.DocumentNumber; }
            }

            string IPhysicalInventoryCommand.DocumentNumber
            {
                get { return this.DocumentNumber; }
                set { this.DocumentNumber = value; }
            }

            long IAggregateCommand<string, long>.AggregateVersion
            {
                get { return this.Version; }
            }

            long IPhysicalInventoryCommand.Version
            {
                get
                {
                    return this.Version;
                }
                set
                {
                    this.Version = value;
                }
            }

        }

        public class DocumentAction : IPhysicalInventoryCommand
        {

            public string CommandType
            {
                get { return "DocumentAction"; }
            }

            public string Value { get; set; }

            public string DocumentNumber { get; set; }

            public long Version { get; set; }

            public string CommandId { get; set; }

            public string RequesterId { get; set; }


            string ICommand.CommandId
            {
                get
                {
                    return this.CommandId;
                }
                set
                {
                    this.CommandId = value;
                }
            }

            object ICommand.RequesterId
            {
                get { return this.RequesterId; }
                set { this.RequesterId = (string)value; }
            }

            string ICommandDto.CommandType
            {
                get { return this.CommandType; }
            }

            string IAggregateCommand<string, long>.AggregateId
            {
                get { return this.DocumentNumber; }
            }

            string IPhysicalInventoryCommand.DocumentNumber
            {
                get { return this.DocumentNumber; }
                set { this.DocumentNumber = value; }
            }

            long IAggregateCommand<string, long>.AggregateVersion
            {
                get { return this.Version; }
            }

            long IPhysicalInventoryCommand.Version
            {
                get
                {
                    return this.Version;
                }
                set
                {
                    this.Version = value;
                }
            }

        }

    }

}
