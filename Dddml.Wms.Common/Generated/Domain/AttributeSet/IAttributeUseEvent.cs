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
	public interface IAttributeUseEvent : IEvent, IEventDto, IGlobalIdentity<AttributeUseEventId>, ICreated<string>
	{
		AttributeUseEventId AttributeUseEventId { get; }

        bool ReadOnly { get; set; }

		// Outer Id:
		//string AttributeSetId { get; set; }

	}

    public interface IAttributeUseStateEvent : IAttributeUseEvent
    {
		long Version { get; set; }

		int? SequenceNumber { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IAttributeUseStateCreated : IAttributeUseStateEvent
	{
	
	}


	public interface IAttributeUseStateMergePatched : IAttributeUseStateEvent
	{
		bool IsPropertySequenceNumberRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IAttributeUseStateRemoved : IAttributeUseStateEvent
	{
	}


}

