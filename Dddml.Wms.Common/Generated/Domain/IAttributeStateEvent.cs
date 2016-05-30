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
	public interface IAttributeStateEvent : IEvent, IStateEventDto, IGlobalIdentity<AttributeStateEventId>, ICreated<string>
	{
		AttributeStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		string Name { get; set; }

		string OrganizationId { get; set; }

		string Description { get; set; }

		bool? IsMandatory { get; set; }

		bool? IsInstanceAttribute { get; set; }

		string AttributeValueType { get; set; }

		int? AttributeValueLength { get; set; }

		bool? IsList { get; set; }

		string FieldName { get; set; }

		string ReferenceId { get; set; }

		bool? Active { get; set; }


	}

	public interface IAttributeStateCreated : IAttributeStateEvent//, IAttributeStateProperties
	{
		IEnumerable<IAttributeValueStateCreated> AttributeValueEvents { get; }
		
		void AddAttributeValueEvent(IAttributeValueStateCreated e);

		IAttributeValueStateCreated NewAttributeValueStateCreated(string value);

	
	}


	public interface IAttributeStateMergePatched : IAttributeStateEvent//, IAttributeStateProperties
	{
		bool IsPropertyNameRemoved { get; set; }

		bool IsPropertyOrganizationIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyIsMandatoryRemoved { get; set; }

		bool IsPropertyIsInstanceAttributeRemoved { get; set; }

		bool IsPropertyAttributeValueTypeRemoved { get; set; }

		bool IsPropertyAttributeValueLengthRemoved { get; set; }

		bool IsPropertyIsListRemoved { get; set; }

		bool IsPropertyFieldNameRemoved { get; set; }

		bool IsPropertyReferenceIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		IEnumerable<IAttributeValueStateEvent> AttributeValueEvents { get; }
		
		void AddAttributeValueEvent(IAttributeValueStateEvent e);

		IAttributeValueStateCreated NewAttributeValueStateCreated(string value);

		IAttributeValueStateMergePatched NewAttributeValueStateMergePatched(string value);

		IAttributeValueStateRemoved NewAttributeValueStateRemoved(string value);


	}


	public interface IAttributeStateDeleted : IAttributeStateEvent
	{
	}


}

