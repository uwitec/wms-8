﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup
{
	public interface IAttributeSetInstanceExtensionFieldGroupState : IAttributeSetInstanceExtensionFieldGroupStateProperties, 
		IGlobalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IDeleted, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IAttributeSetInstanceExtensionFieldGroupStateCreated e);

		void When(IAttributeSetInstanceExtensionFieldGroupStateMergePatched e);

		void When(IAttributeSetInstanceExtensionFieldGroupStateDeleted e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}
}

