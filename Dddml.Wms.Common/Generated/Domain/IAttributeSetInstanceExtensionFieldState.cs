﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{
	public interface IAttributeSetInstanceExtensionFieldState : IAttributeSetInstanceExtensionFieldStateProperties, 
		IGlobalIdentity<AttributeSetInstanceExtensionFieldId>, 
		ILocalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IActive, 
		IVersioned<long>
	{
		
		void When(IAttributeSetInstanceExtensionFieldStateCreated e);

		void When(IAttributeSetInstanceExtensionFieldStateMergePatched e);

		//void When(IAttributeSetInstanceExtensionFieldStateRemoved e);

		void Mutate(IEvent e);


	}
}
