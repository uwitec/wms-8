﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup
{
	public interface IAttributeSetInstanceExtensionFieldGroupCommand : IAggregateCommand<string, long>, ICommandDto
	{
		long Version { get; set; }

		string Id { get; set; }

	}


	public interface ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroup : IAttributeSetInstanceExtensionFieldGroupCommand
	{

		string FieldType { get; set; }

		int? FieldLength { get; set; }

		int? FieldCount { get; set; }

		string NameFormat { get; set; }

		string Description { get; set; }

		bool? Active { get; set; }


	}

	public interface ICreateAttributeSetInstanceExtensionFieldGroup : ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroup
	{
	}

	public interface IMergePatchAttributeSetInstanceExtensionFieldGroup : ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroup
	{

		bool IsPropertyFieldTypeRemoved { get; set; }

		bool IsPropertyFieldLengthRemoved { get; set; }

		bool IsPropertyFieldCountRemoved { get; set; }

		bool IsPropertyNameFormatRemoved { get; set; }

		bool IsPropertyDescriptionRemoved { get; set; }

		bool IsPropertyActiveRemoved { get; set; }


	}

	public interface IDeleteAttributeSetInstanceExtensionFieldGroup : ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroup
	{
	}


}

