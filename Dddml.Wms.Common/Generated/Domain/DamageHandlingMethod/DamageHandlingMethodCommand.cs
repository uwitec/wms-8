﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateDamageHandlingMethodDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DamageHandlingMethod;

namespace Dddml.Wms.Domain.DamageHandlingMethod
{

	public abstract class DamageHandlingMethodCommandBase : IDamageHandlingMethodCommand
	{
		public virtual string DamageHandlingMethodId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.DamageHandlingMethodId;
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

		public virtual string Description { get; set; }

		public virtual string SequenceId { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateDamageHandlingMethod : DamageHandlingMethodCommandBase, ICreateDamageHandlingMethod
	{
		
		public CreateDamageHandlingMethod ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchDamageHandlingMethod :DamageHandlingMethodCommandBase, IMergePatchDamageHandlingMethod
	{

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertySequenceIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchDamageHandlingMethod ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteDamageHandlingMethod : DamageHandlingMethodCommandBase, IDeleteDamageHandlingMethod
	{
		public DeleteDamageHandlingMethod ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class DamageHandlingMethodCommands
    {
    }

}
