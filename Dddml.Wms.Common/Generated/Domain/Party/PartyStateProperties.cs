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

	public abstract class PartyStateProperties : IPartyStateProperties
	{
		public virtual string PartyId { get; set; }

		public virtual string PartyTypeId { get; set; }

		public virtual string PrimaryRoleTypeId { get; set; }

		public virtual string ExternalId { get; set; }

		public virtual string PreferredCurrencyUomId { get; set; }

		public virtual string Description { get; set; }

		public virtual string OrganizationName { get; set; }

		public virtual bool IsSummary { get; set; }

		public virtual string Salutation { get; set; }

		public virtual string FirstName { get; set; }

		public virtual string MiddleName { get; set; }

		public virtual string LastName { get; set; }

		public virtual string PersonalTitle { get; set; }

		public virtual string Nickname { get; set; }

		public virtual string CardId { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
