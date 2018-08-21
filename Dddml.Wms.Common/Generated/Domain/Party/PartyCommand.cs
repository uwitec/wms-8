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

	public abstract class PartyCommandBase : IPartyCommand
	{
		public virtual string PartyId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.PartyId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual string PartyTypeId { get; set; }

		public virtual string PrimaryRoleTypeId { get; set; }

		public virtual string ExternalId { get; set; }

		public virtual string PreferredCurrencyUomId { get; set; }

		public virtual string Description { get; set; }

		public virtual string OrganizationName { get; set; }

		public virtual bool? IsSummary { get; set; }

		public virtual string Salutation { get; set; }

		public virtual string FirstName { get; set; }

		public virtual string MiddleName { get; set; }

		public virtual string LastName { get; set; }

		public virtual string PersonalTitle { get; set; }

		public virtual string Nickname { get; set; }

		public virtual string CardId { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateParty : PartyCommandBase, ICreateParty
	{
		
		public CreateParty ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchParty :PartyCommandBase, IMergePatchParty
	{

		public virtual bool IsPropertyPartyTypeIdRemoved { get; set; }

		public virtual bool IsPropertyPrimaryRoleTypeIdRemoved { get; set; }

		public virtual bool IsPropertyExternalIdRemoved { get; set; }

		public virtual bool IsPropertyPreferredCurrencyUomIdRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyOrganizationNameRemoved { get; set; }

		public virtual bool IsPropertyIsSummaryRemoved { get; set; }

		public virtual bool IsPropertySalutationRemoved { get; set; }

		public virtual bool IsPropertyFirstNameRemoved { get; set; }

		public virtual bool IsPropertyMiddleNameRemoved { get; set; }

		public virtual bool IsPropertyLastNameRemoved { get; set; }

		public virtual bool IsPropertyPersonalTitleRemoved { get; set; }

		public virtual bool IsPropertyNicknameRemoved { get; set; }

		public virtual bool IsPropertyCardIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchParty ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteParty : PartyCommandBase, IDeleteParty
	{
		public DeleteParty ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class PartyCommands
    {
    }

}
