﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateStatusItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.StatusItem;

namespace Dddml.Wms.Domain.StatusItem
{

	public partial interface IStatusItemAggregate : IGlobalIdentity<string>
	{
		IStatusItemState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateStatusItem c);

		void MergePatch (IMergePatchStatusItem c);


	}

}

