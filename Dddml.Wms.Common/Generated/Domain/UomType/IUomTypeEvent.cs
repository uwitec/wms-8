﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateUomTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UomType;

namespace Dddml.Wms.Domain.UomType
{
	public interface IUomTypeEvent : IEvent, IEventDto, IGlobalIdentity<UomTypeEventId>, ICreated<string>
	{
		UomTypeEventId UomTypeEventId { get; }

        bool ReadOnly { get; set; }

	}

    public interface IUomTypeStateEvent : IUomTypeEvent
    {
		string ParentTypeId { get; set; }

		string HasTable { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }

    }
   
	public interface IUomTypeStateCreated : IUomTypeStateEvent
	{
	
	}


	public interface IUomTypeStateMergePatched : IUomTypeStateEvent
	{
		bool IsPropertyParentTypeIdRemoved { get; set; }

		bool IsPropertyHasTableRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IUomTypeStateDeleted : IUomTypeStateEvent
	{
	}


}

