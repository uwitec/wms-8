﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRejectionReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RejectionReason;

namespace Dddml.Wms.Domain.RejectionReason
{

	public abstract class RejectionReasonStateProperties : IRejectionReasonStateProperties
	{
		public virtual string RejectionReasonId { get; set; }

		public virtual string Description { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
