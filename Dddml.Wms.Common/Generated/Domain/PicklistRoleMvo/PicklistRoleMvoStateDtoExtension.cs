﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;

namespace Dddml.Wms.Domain.PicklistRoleMvo
{

	public static partial class PicklistRoleMvoStateDtoExtension
	{

        public static IPicklistRoleMvoCommand ToCreateOrMergePatchPicklistRoleMvo(this PicklistRoleMvoStateDtoWrapper state)
        {
            return state.ToCreateOrMergePatchPicklistRoleMvo<CreatePicklistRoleMvoDto, MergePatchPicklistRoleMvoDto>();
        }

        public static DeletePicklistRoleMvoDto ToDeletePicklistRoleMvo(this PicklistRoleMvoStateDtoWrapper state)
        {
            return state.ToDeletePicklistRoleMvo<DeletePicklistRoleMvoDto>();
        }

        public static MergePatchPicklistRoleMvoDto ToMergePatchPicklistRoleMvo(this PicklistRoleMvoStateDtoWrapper state)
        {
            return state.ToMergePatchPicklistRoleMvo<MergePatchPicklistRoleMvoDto>();
        }

        public static CreatePicklistRoleMvoDto ToCreatePicklistRoleMvo(this PicklistRoleMvoStateDtoWrapper state)
        {
            return state.ToCreatePicklistRoleMvo<CreatePicklistRoleMvoDto>();
        }
		

	}

}

