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

	public static partial class RoleStateInterfaceExtensions
	{

        public static IRoleCommand ToCreateOrMergePatchRole<TCreateRole, TMergePatchRole>(this IRoleState state)
            where TCreateRole : ICreateRole, new()
            where TMergePatchRole : IMergePatchRole, new()
        {
            bool bUnsaved = ((IRoleState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateRole<TCreateRole>();
            }
            else 
            {
                return state.ToMergePatchRole<TMergePatchRole>();
            }
        }

        public static TDeleteRole ToDeleteRole<TDeleteRole>(this IRoleState state)
            where TDeleteRole : IDeleteRole, new()
        {
            var cmd = new TDeleteRole();
            cmd.RoleId = state.RoleId;
            cmd.Version = ((IRoleStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchRole ToMergePatchRole<TMergePatchRole>(this IRoleState state)
            where TMergePatchRole : IMergePatchRole, new()
        {
            var cmd = new TMergePatchRole();

            cmd.Version = ((IRoleStateProperties)state).Version;

            cmd.RoleId = state.RoleId;
            cmd.Name = state.Name;
            cmd.Description = state.Description;
            cmd.Active = ((IRoleStateProperties)state).Active;
            
            if (state.Name == null) { cmd.IsPropertyNameRemoved = true; }
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            return cmd;
        }

        public static TCreateRole ToCreateRole<TCreateRole>(this IRoleState state)
            where TCreateRole : ICreateRole, new()
        {
            var cmd = new TCreateRole();

            cmd.Version = ((IRoleStateProperties)state).Version;

            cmd.RoleId = state.RoleId;
            cmd.Name = state.Name;
            cmd.Description = state.Description;
            cmd.Active = ((IRoleStateProperties)state).Active;
            return cmd;
        }
		

	}

}

