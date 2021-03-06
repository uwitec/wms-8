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
	public interface IStatusItemEvent : IEvent, IEventDto, IGlobalIdentity<StatusItemEventId>, ICreated<string>
	{
		StatusItemEventId StatusItemEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IStatusItemStateEvent : IStatusItemEvent
    {
		string StatusTypeId { get; set; }

		string StatusCode { get; set; }

		string SequenceId { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IStatusItemStateCreated : IStatusItemStateEvent
	{
	
	}


	public interface IStatusItemStateMergePatched : IStatusItemStateEvent
	{
		bool IsPropertyStatusTypeIdRemoved { get; set; }

		bool IsPropertyStatusCodeRemoved { get; set; }

		bool IsPropertySequenceIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}


}

