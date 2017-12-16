﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentType;

namespace Dddml.Wms.Domain.ShipmentType
{

	public partial interface IShipmentTypeAggregate : IGlobalIdentity<string>
	{
		IShipmentTypeState State { get; }

		IList<IEvent> Changes { get; }

		void ThrowOnInvalidStateTransition (ICommand c);

		void Create (ICreateShipmentType c);

		void MergePatch (IMergePatchShipmentType c);


	}

}

