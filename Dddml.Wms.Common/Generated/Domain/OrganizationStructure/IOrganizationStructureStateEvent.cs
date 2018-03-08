﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrganizationStructureDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructure;

namespace Dddml.Wms.Domain.OrganizationStructure
{
	public interface IOrganizationStructureStateEvent : IEvent, IStateEventDto, IGlobalIdentity<OrganizationStructureEventId>, ICreated<string>
	{
		OrganizationStructureEventId OrganizationStructureEventId { get; }

        bool ReadOnly { get; set; }

		bool? Active { get; set; }

	}

	public interface IOrganizationStructureStateCreated : IOrganizationStructureStateEvent//, IOrganizationStructureStateProperties
	{
	
	}


	public interface IOrganizationStructureStateMergePatched : IOrganizationStructureStateEvent//, IOrganizationStructureStateProperties
	{
		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IOrganizationStructureStateDeleted : IOrganizationStructureStateEvent
	{
	}


}

