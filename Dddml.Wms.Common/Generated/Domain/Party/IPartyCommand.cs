﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePartyDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;

namespace Dddml.Wms.Domain.Party
{
	public interface IPartyCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string PartyId { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteParty : IPartyCommand
	{

		string PartyTypeId { get; set; }

		string PrimaryRoleTypeId { get; set; }

		string ExternalId { get; set; }

		string PreferredCurrencyUomId { get; set; }

		string Description { get; set; }

		string OrganizationName { get; set; }

		bool? IsSummary { get; set; }

		string Salutation { get; set; }

		string FirstName { get; set; }

		string MiddleName { get; set; }

		string LastName { get; set; }

		string PersonalTitle { get; set; }

		string Nickname { get; set; }

		string CardId { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateParty : ICreateOrMergePatchOrDeleteParty
	{
	}

	public interface IMergePatchParty : ICreateOrMergePatchOrDeleteParty
	{

		bool IsPropertyPartyTypeIdRemoved { get; set; }

		bool IsPropertyPrimaryRoleTypeIdRemoved { get; set; }

		bool IsPropertyExternalIdRemoved { get; set; }

		bool IsPropertyPreferredCurrencyUomIdRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyOrganizationNameRemoved { get; set; }

		bool IsPropertyIsSummaryRemoved { get; set; }

		bool IsPropertySalutationRemoved { get; set; }

		bool IsPropertyFirstNameRemoved { get; set; }

		bool IsPropertyMiddleNameRemoved { get; set; }

		bool IsPropertyLastNameRemoved { get; set; }

		bool IsPropertyPersonalTitleRemoved { get; set; }

		bool IsPropertyNicknameRemoved { get; set; }

		bool IsPropertyCardIdRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IDeleteParty : ICreateOrMergePatchOrDeleteParty
	{
	}


}

