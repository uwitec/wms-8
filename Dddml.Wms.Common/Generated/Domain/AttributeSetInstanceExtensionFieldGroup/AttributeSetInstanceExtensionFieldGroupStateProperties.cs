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

	public abstract class AttributeSetInstanceExtensionFieldGroupStateProperties : IAttributeSetInstanceExtensionFieldGroupStateProperties
	{
		public virtual string Id { get; set; }

		public virtual string FieldType { get; set; }

		public virtual int? FieldLength { get; set; }

		public virtual int FieldCount { get; set; }

		public virtual string NameFormat { get; set; }

		public virtual string Description { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
