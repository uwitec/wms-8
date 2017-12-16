﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateStatusItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.StatusItem;

namespace Dddml.Wms.Domain.StatusItem
{

	public abstract class StatusItemCommandBase : IStatusItemCommand
	{
		public virtual string StatusId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.StatusId;
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

		public virtual string StatusTypeId { get; set; }

		public virtual string StatusCode { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateStatusItem : StatusItemCommandBase, ICreateStatusItem
	{
		
		public CreateStatusItem ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchStatusItem :StatusItemCommandBase, IMergePatchStatusItem
	{

		public virtual bool IsPropertyStatusTypeIdRemoved { get; set; }

		public virtual bool IsPropertyStatusCodeRemoved { get; set; }

		public virtual bool IsPropertySequenceIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchStatusItem ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteStatusItem : StatusItemCommandBase, IDeleteStatusItem
	{
		public DeleteStatusItem ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class StatusItemCommands
    {
    }

}