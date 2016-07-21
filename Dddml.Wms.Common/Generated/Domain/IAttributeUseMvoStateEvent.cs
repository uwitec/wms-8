﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{
	public interface IAttributeUseMvoStateEvent : IEvent, IStateEventDto, IGlobalIdentity<AttributeUseMvoStateEventId>, ICreated<string>
	{
		AttributeUseMvoStateEventId StateEventId { get; }

        bool ReadOnly { get; set; }

		int? SequenceNumber { get; set; }

		long? Version { get; set; }

		bool? Active { get; set; }

		string AttributeSetName { get; set; }

		string AttributeSetOrganizationId { get; set; }

		string AttributeSetDescription { get; set; }

		string AttributeSetSerialNumberAttributeId { get; set; }

		string AttributeSetLotAttributeId { get; set; }

		string AttributeSetReferenceId { get; set; }

		string AttributeSetCreatedBy { get; set; }

		DateTime? AttributeSetCreatedAt { get; set; }

		string AttributeSetUpdatedBy { get; set; }

		DateTime? AttributeSetUpdatedAt { get; set; }

		bool? AttributeSetActive { get; set; }

		bool? AttributeSetDeleted { get; set; }


	}

	public interface IAttributeUseMvoStateCreated : IAttributeUseMvoStateEvent//, IAttributeUseMvoStateProperties
	{
	
	}


	public interface IAttributeUseMvoStateMergePatched : IAttributeUseMvoStateEvent//, IAttributeUseMvoStateProperties
	{
		bool IsPropertySequenceNumberRemoved { get; set; }

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyAttributeSetNameRemoved { get; set; }

		bool IsPropertyAttributeSetOrganizationIdRemoved { get; set; }

		bool IsPropertyAttributeSetDescriptionRemoved { get; set; }

		bool IsPropertyAttributeSetSerialNumberAttributeIdRemoved { get; set; }

		bool IsPropertyAttributeSetLotAttributeIdRemoved { get; set; }

		bool IsPropertyAttributeSetReferenceIdRemoved { get; set; }

		bool IsPropertyAttributeSetCreatedByRemoved { get; set; }

		bool IsPropertyAttributeSetCreatedAtRemoved { get; set; }

		bool IsPropertyAttributeSetUpdatedByRemoved { get; set; }

		bool IsPropertyAttributeSetUpdatedAtRemoved { get; set; }

		bool IsPropertyAttributeSetActiveRemoved { get; set; }

		bool IsPropertyAttributeSetDeletedRemoved { get; set; }


	}

	public interface IAttributeUseMvoStateDeleted : IAttributeUseMvoStateEvent
	{
	}


}

