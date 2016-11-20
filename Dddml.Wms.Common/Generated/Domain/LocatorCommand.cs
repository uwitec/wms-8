﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public abstract class LocatorCommandBase : ILocatorCommand
	{
		public virtual string LocatorId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.LocatorId;
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

		public virtual string ParentLocatorId { get; set; }

		public virtual string LocatorType { get; set; }

		public virtual string PriorityNumber { get; set; }

		public virtual bool? IsDefault { get; set; }

		public virtual string X { get; set; }

		public virtual string Y { get; set; }

		public virtual string Z { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


    public abstract class LocatorIdGeneratorBase : IIdGenerator<string, ICreateLocator>
    {
        public abstract string GenerateId(ICreateLocator command);

        public abstract string GetNextId();

        public virtual string GetOrGenerateId(ICreateLocator command, out bool reused)
        {
            throw new NotSupportedException();
        }

    }

	public class CreateLocator : LocatorCommandBase, ICreateLocator
	{
		
		public CreateLocator ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchLocator :LocatorCommandBase, IMergePatchLocator
	{

		public virtual bool IsPropertyWarehouseIdRemoved { get; set; }

		public virtual bool IsPropertyParentLocatorIdRemoved { get; set; }

		public virtual bool IsPropertyLocatorTypeRemoved { get; set; }

		public virtual bool IsPropertyPriorityNumberRemoved { get; set; }

		public virtual bool IsPropertyIsDefaultRemoved { get; set; }

		public virtual bool IsPropertyXRemoved { get; set; }

		public virtual bool IsPropertyYRemoved { get; set; }

		public virtual bool IsPropertyZRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchLocator ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteLocator : LocatorCommandBase, IDeleteLocator
	{
		public DeleteLocator ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}


}

