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

	public static partial class UserLoginMvoStateExtensions
	{

        public static IUserLoginMvoCommand ToCreateOrMergePatchUserLoginMvo(this UserLoginMvoState state)
        {
            return state.ToCreateOrMergePatchUserLoginMvo<CreateUserLoginMvo, MergePatchUserLoginMvo>();
        }

        public static DeleteUserLoginMvo ToDeleteUserLoginMvo(this UserLoginMvoState state)
        {
            return state.ToDeleteUserLoginMvo<DeleteUserLoginMvo>();
        }

        public static MergePatchUserLoginMvo ToMergePatchUserLoginMvo(this UserLoginMvoState state)
        {
            return state.ToMergePatchUserLoginMvo<MergePatchUserLoginMvo>();
        }

        public static CreateUserLoginMvo ToCreateUserLoginMvo(this UserLoginMvoState state)
        {
            return state.ToCreateUserLoginMvo<CreateUserLoginMvo>();
        }
		

	}

}

