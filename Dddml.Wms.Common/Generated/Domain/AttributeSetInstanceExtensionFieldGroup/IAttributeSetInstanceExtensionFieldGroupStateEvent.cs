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
	public interface IAttributeSetInstanceExtensionFieldGroupStateEvent : IEvent, IStateEventDto, IGlobalIdentity<AttributeSetInstanceExtensionFieldGroupEventId>, ICreated<string>
	{
		AttributeSetInstanceExtensionFieldGroupEventId AttributeSetInstanceExtensionFieldGroupEventId { get; }

        bool ReadOnly { get; set; }

		string FieldType { get; set; }

		int? FieldLength { get; set; }

		int? FieldCount { get; set; }

		string NameFormat { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

	}

	public interface IAttributeSetInstanceExtensionFieldGroupStateCreated : IAttributeSetInstanceExtensionFieldGroupStateEvent//, IAttributeSetInstanceExtensionFieldGroupStateProperties
	{
	
	}


	public interface IAttributeSetInstanceExtensionFieldGroupStateMergePatched : IAttributeSetInstanceExtensionFieldGroupStateEvent//, IAttributeSetInstanceExtensionFieldGroupStateProperties
	{
		bool IsPropertyFieldTypeRemoved { get; set; }

		bool IsPropertyFieldLengthRemoved { get; set; }

		bool IsPropertyFieldCountRemoved { get; set; }

		bool IsPropertyNameFormatRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IAttributeSetInstanceExtensionFieldGroupStateDeleted : IAttributeSetInstanceExtensionFieldGroupStateEvent
	{
	}


}

