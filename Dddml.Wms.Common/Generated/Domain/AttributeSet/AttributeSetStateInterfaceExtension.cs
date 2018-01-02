﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

	public static partial class AttributeSetStateInterfaceExtension
	{

        public static IAttributeSetCommand ToCreateOrMergePatchAttributeSet<TCreateAttributeSet, TMergePatchAttributeSet, TCreateAttributeUse, TMergePatchAttributeUse>(this IAttributeSetState state)
            where TCreateAttributeSet : ICreateAttributeSet, new()
            where TMergePatchAttributeSet : IMergePatchAttributeSet, new()
            where TCreateAttributeUse : ICreateAttributeUse, new()
            where TMergePatchAttributeUse : IMergePatchAttributeUse, new()
        {
            bool bUnsaved = ((IAttributeSetState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateAttributeSet<TCreateAttributeSet, TCreateAttributeUse>();
            }
            else 
            {
                return state.ToMergePatchAttributeSet<TMergePatchAttributeSet, TCreateAttributeUse, TMergePatchAttributeUse>();
            }
        }

        public static TDeleteAttributeSet ToDeleteAttributeSet<TDeleteAttributeSet>(this IAttributeSetState state)
            where TDeleteAttributeSet : IDeleteAttributeSet, new()
        {
            var cmd = new TDeleteAttributeSet();
            cmd.AttributeSetId = state.AttributeSetId;
            cmd.Version = ((IAttributeSetStateProperties)state).Version;

            return cmd;
        }

        public static TMergePatchAttributeSet ToMergePatchAttributeSet<TMergePatchAttributeSet, TCreateAttributeUse, TMergePatchAttributeUse>(this IAttributeSetState state)
            where TMergePatchAttributeSet : IMergePatchAttributeSet, new()
            where TCreateAttributeUse : ICreateAttributeUse, new()
            where TMergePatchAttributeUse : IMergePatchAttributeUse, new()
        {
            var cmd = new TMergePatchAttributeSet();

            cmd.Version = ((IAttributeSetStateProperties)state).Version;

            cmd.AttributeSetId = state.AttributeSetId;
            cmd.AttributeSetName = state.AttributeSetName;
            cmd.OrganizationId = state.OrganizationId;
            cmd.Description = state.Description;
            cmd.ReferenceId = state.ReferenceId;
            cmd.IsInstanceAttributeSet = state.IsInstanceAttributeSet;
            cmd.IsMandatory = state.IsMandatory;
            cmd.Active = ((IAttributeSetStateProperties)state).Active;
            
            if (state.AttributeSetName == null) { cmd.IsPropertyAttributeSetNameRemoved = true; }
            if (state.OrganizationId == null) { cmd.IsPropertyOrganizationIdRemoved = true; }
            if (state.Description == null) { cmd.IsPropertyDescriptionRemoved = true; }
            if (state.ReferenceId == null) { cmd.IsPropertyReferenceIdRemoved = true; }
            foreach (var d in state.AttributeUses)
            {
                var c = d.ToCreateOrMergePatchAttributeUse<TCreateAttributeUse, TMergePatchAttributeUse>();
                cmd.AttributeUseCommands.Add(c);
            }
            return cmd;
        }

        public static TCreateAttributeSet ToCreateAttributeSet<TCreateAttributeSet, TCreateAttributeUse>(this IAttributeSetState state)
            where TCreateAttributeSet : ICreateAttributeSet, new()
            where TCreateAttributeUse : ICreateAttributeUse, new()
        {
            var cmd = new TCreateAttributeSet();

            cmd.Version = ((IAttributeSetStateProperties)state).Version;

            cmd.AttributeSetId = state.AttributeSetId;
            cmd.AttributeSetName = state.AttributeSetName;
            cmd.OrganizationId = state.OrganizationId;
            cmd.Description = state.Description;
            cmd.ReferenceId = state.ReferenceId;
            cmd.IsInstanceAttributeSet = state.IsInstanceAttributeSet;
            cmd.IsMandatory = state.IsMandatory;
            cmd.Active = ((IAttributeSetStateProperties)state).Active;
            foreach (var d in state.AttributeUses)
            {
                var c = d.ToCreateAttributeUse<TCreateAttributeUse>();
                cmd.AttributeUses.Add(c);
            }
            return cmd;
        }
		

	}

}

