﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionField;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionField
{

	public partial interface IAttributeSetInstanceExtensionFieldAggregate : IGlobalIdentity<string>
	{
		IAttributeSetInstanceExtensionFieldState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateAttributeSetInstanceExtensionField c);

		void MergePatch (IMergePatchAttributeSetInstanceExtensionField c);

		void Delete (IDeleteAttributeSetInstanceExtensionField c);


	}

}

