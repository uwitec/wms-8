﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRoleTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RoleType;

namespace Dddml.Wms.Domain.RoleType
{

	public partial interface IRoleTypeAggregate : IGlobalIdentity<string>
	{
		IRoleTypeState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateRoleType c);

		void MergePatch (IMergePatchRoleType c);

		void Delete (IDeleteRoleType c);


	}

}

