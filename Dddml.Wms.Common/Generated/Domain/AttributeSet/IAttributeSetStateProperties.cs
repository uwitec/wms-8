﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSet;

namespace Dddml.Wms.Domain.AttributeSet
{

	public interface IAttributeSetStateProperties
	{
		string AttributeSetId { get; set; }

		string AttributeSetName { get; set; }

		string OrganizationId { get; set; }

		string Description { get; set; }

		string SerialNumberAttributeId { get; set; }

		string LotAttributeId { get; set; }

		string ReferenceId { get; set; }

		bool IsInstanceAttributeSet { get; set; }

		bool IsMandatory { get; set; }

		long Version { get; set; }

		bool Active { get; set; }

	}

}
