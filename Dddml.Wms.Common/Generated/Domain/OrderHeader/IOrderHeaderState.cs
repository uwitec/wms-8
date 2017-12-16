﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderHeaderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderHeader;

namespace Dddml.Wms.Domain.OrderHeader
{
	public interface IOrderHeaderState : IOrderHeaderStateProperties, 
		IGlobalIdentity<string>, 
		ICreated<string>, 
		IUpdated<string>, 
		IActive, 
		IAggregateVersioned<long>,
		IState
	{

		bool ForReapplying { get; }

		void When(IOrderHeaderStateCreated e);

		void When(IOrderHeaderStateMergePatched e);

		void Mutate(IEvent e);


        bool IsUnsaved { get; }

	}
}
