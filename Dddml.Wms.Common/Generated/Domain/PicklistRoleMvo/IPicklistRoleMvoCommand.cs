﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;

namespace Dddml.Wms.Domain.PicklistRoleMvo
{
	public interface IPicklistRoleMvoCommand : IAggregateCommand<PicklistRoleId, long>, ICommandDto
	{
		long PicklistVersion { get; set; }

		PicklistRoleId PicklistRoleId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeletePicklistRoleMvo : IPicklistRoleMvoCommand
	{

		long? Version { get; set; }

		bool? Active { get; set; }

		string PicklistDescription { get; set; }

		string PicklistFacilityId { get; set; }

		string PicklistShipmentMethodTypeId { get; set; }

		string PicklistStatusId { get; set; }

		DateTime? PicklistPicklistDate { get; set; }

		string PicklistCreatedByUserLogin { get; set; }

		string PicklistLastModifiedByUserLogin { get; set; }

		DateTime? PicklistCreatedAt { get; set; }

		DateTime? PicklistUpdatedAt { get; set; }

		bool? PicklistActive { get; set; }

		bool? PicklistDeleted { get; set; }


	}

	public interface ICreatePicklistRoleMvo : ICreateOrMergePatchOrDeletePicklistRoleMvo
	{
	}

	public interface IMergePatchPicklistRoleMvo : ICreateOrMergePatchOrDeletePicklistRoleMvo
	{

		bool IsPropertyVersionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }

		bool IsPropertyPicklistDescriptionRemoved { get; set; }

		bool IsPropertyPicklistFacilityIdRemoved { get; set; }

		bool IsPropertyPicklistShipmentMethodTypeIdRemoved { get; set; }

		bool IsPropertyPicklistStatusIdRemoved { get; set; }

		bool IsPropertyPicklistPicklistDateRemoved { get; set; }

		bool IsPropertyPicklistCreatedByUserLoginRemoved { get; set; }

		bool IsPropertyPicklistLastModifiedByUserLoginRemoved { get; set; }

		bool IsPropertyPicklistCreatedAtRemoved { get; set; }

		bool IsPropertyPicklistUpdatedAtRemoved { get; set; }

		bool IsPropertyPicklistActiveRemoved { get; set; }

		bool IsPropertyPicklistDeletedRemoved { get; set; }


	}

	public interface IDeletePicklistRoleMvo : ICreateOrMergePatchOrDeletePicklistRoleMvo
	{
	}


}

