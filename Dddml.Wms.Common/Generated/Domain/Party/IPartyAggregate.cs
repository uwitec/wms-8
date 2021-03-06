﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;

namespace Dddml.Wms.Domain.Party
{

	public partial interface IPartyAggregate : IGlobalIdentity<string>
	{
		IPartyState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateParty c);

		void MergePatch (IMergePatchParty c);

		void Delete (IDeleteParty c);


	}

}

