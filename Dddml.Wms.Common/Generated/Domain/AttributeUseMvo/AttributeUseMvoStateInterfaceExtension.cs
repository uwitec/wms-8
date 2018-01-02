﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeUseMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeUseMvo;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeUseMvo
{

	public static partial class AttributeUseMvoStateInterfaceExtension
	{

        public static IAttributeUseMvoCommand ToCreateOrMergePatchAttributeUseMvo<TCreateAttributeUseMvo, TMergePatchAttributeUseMvo>(this IAttributeUseMvoState state)
            where TCreateAttributeUseMvo : ICreateAttributeUseMvo, new()
            where TMergePatchAttributeUseMvo : IMergePatchAttributeUseMvo, new()
        {
            bool bUnsaved = ((IAttributeUseMvoState)state).IsUnsaved;
            if (bUnsaved)
            {
                return state.ToCreateAttributeUseMvo<TCreateAttributeUseMvo>();
            }
            else 
            {
                return state.ToMergePatchAttributeUseMvo<TMergePatchAttributeUseMvo>();
            }
        }

        public static TDeleteAttributeUseMvo ToDeleteAttributeUseMvo<TDeleteAttributeUseMvo>(this IAttributeUseMvoState state)
            where TDeleteAttributeUseMvo : IDeleteAttributeUseMvo, new()
        {
            var cmd = new TDeleteAttributeUseMvo();
            cmd.AttributeSetAttributeUseId = state.AttributeSetAttributeUseId;
            cmd.AttributeSetVersion = ((IAttributeUseMvoStateProperties)state).AttributeSetVersion;

            return cmd;
        }

        public static TMergePatchAttributeUseMvo ToMergePatchAttributeUseMvo<TMergePatchAttributeUseMvo>(this IAttributeUseMvoState state)
            where TMergePatchAttributeUseMvo : IMergePatchAttributeUseMvo, new()
        {
            var cmd = new TMergePatchAttributeUseMvo();

            cmd.AttributeSetVersion = ((IAttributeUseMvoStateProperties)state).AttributeSetVersion;

            cmd.AttributeSetAttributeUseId = state.AttributeSetAttributeUseId;
            cmd.SequenceNumber = state.SequenceNumber;
            cmd.Version = ((IAttributeUseMvoStateProperties)state).Version;
            cmd.Active = ((IAttributeUseMvoStateProperties)state).Active;
            cmd.AttributeSetAttributeSetName = state.AttributeSetAttributeSetName;
            cmd.AttributeSetOrganizationId = state.AttributeSetOrganizationId;
            cmd.AttributeSetDescription = state.AttributeSetDescription;
            cmd.AttributeSetReferenceId = state.AttributeSetReferenceId;
            cmd.AttributeSetIsInstanceAttributeSet = state.AttributeSetIsInstanceAttributeSet;
            cmd.AttributeSetIsMandatory = state.AttributeSetIsMandatory;
            cmd.AttributeSetCreatedBy = state.AttributeSetCreatedBy;
            cmd.AttributeSetCreatedAt = state.AttributeSetCreatedAt;
            cmd.AttributeSetUpdatedBy = state.AttributeSetUpdatedBy;
            cmd.AttributeSetUpdatedAt = state.AttributeSetUpdatedAt;
            cmd.AttributeSetActive = state.AttributeSetActive;
            cmd.AttributeSetDeleted = state.AttributeSetDeleted;
            
            if (state.AttributeSetAttributeSetName == null) { cmd.IsPropertyAttributeSetAttributeSetNameRemoved = true; }
            if (state.AttributeSetOrganizationId == null) { cmd.IsPropertyAttributeSetOrganizationIdRemoved = true; }
            if (state.AttributeSetDescription == null) { cmd.IsPropertyAttributeSetDescriptionRemoved = true; }
            if (state.AttributeSetReferenceId == null) { cmd.IsPropertyAttributeSetReferenceIdRemoved = true; }
            if (state.AttributeSetCreatedBy == null) { cmd.IsPropertyAttributeSetCreatedByRemoved = true; }
            if (state.AttributeSetUpdatedBy == null) { cmd.IsPropertyAttributeSetUpdatedByRemoved = true; }
            return cmd;
        }

        public static TCreateAttributeUseMvo ToCreateAttributeUseMvo<TCreateAttributeUseMvo>(this IAttributeUseMvoState state)
            where TCreateAttributeUseMvo : ICreateAttributeUseMvo, new()
        {
            var cmd = new TCreateAttributeUseMvo();

            cmd.AttributeSetVersion = ((IAttributeUseMvoStateProperties)state).AttributeSetVersion;

            cmd.AttributeSetAttributeUseId = state.AttributeSetAttributeUseId;
            cmd.SequenceNumber = state.SequenceNumber;
            cmd.Version = ((IAttributeUseMvoStateProperties)state).Version;
            cmd.Active = ((IAttributeUseMvoStateProperties)state).Active;
            cmd.AttributeSetAttributeSetName = state.AttributeSetAttributeSetName;
            cmd.AttributeSetOrganizationId = state.AttributeSetOrganizationId;
            cmd.AttributeSetDescription = state.AttributeSetDescription;
            cmd.AttributeSetReferenceId = state.AttributeSetReferenceId;
            cmd.AttributeSetIsInstanceAttributeSet = state.AttributeSetIsInstanceAttributeSet;
            cmd.AttributeSetIsMandatory = state.AttributeSetIsMandatory;
            cmd.AttributeSetCreatedBy = state.AttributeSetCreatedBy;
            cmd.AttributeSetCreatedAt = state.AttributeSetCreatedAt;
            cmd.AttributeSetUpdatedBy = state.AttributeSetUpdatedBy;
            cmd.AttributeSetUpdatedAt = state.AttributeSetUpdatedAt;
            cmd.AttributeSetActive = state.AttributeSetActive;
            cmd.AttributeSetDeleted = state.AttributeSetDeleted;
            return cmd;
        }
		

	}

}

