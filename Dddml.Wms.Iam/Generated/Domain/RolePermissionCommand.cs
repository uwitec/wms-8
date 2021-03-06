﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RolePermission;

namespace Dddml.Wms.Domain.RolePermission
{

	public abstract class RolePermissionCommandBase : IRolePermissionCommand
	{
		public virtual RolePermissionId Id { get; set; }


		RolePermissionId IAggregateCommand<RolePermissionId, long>.AggregateId
		{
			get
			{
				return this.Id;
			}
		}


		long IAggregateCommand<RolePermissionId, long>.AggregateVersion
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


	public class CreateRolePermission : RolePermissionCommandBase, ICreateRolePermission
	{
		
		public CreateRolePermission ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchRolePermission :RolePermissionCommandBase, IMergePatchRolePermission
	{

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchRolePermission ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteRolePermission : RolePermissionCommandBase, IDeleteRolePermission
	{
		public DeleteRolePermission ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class RolePermissionCommands
    {
    }

}
