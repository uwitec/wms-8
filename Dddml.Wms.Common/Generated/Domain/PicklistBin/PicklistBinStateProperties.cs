﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistBinDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistBin;

namespace Dddml.Wms.Domain.PicklistBin
{

	public abstract class PicklistBinStateProperties : IPicklistBinStateProperties
	{
		public virtual string PicklistBinId { get; set; }

		public virtual string PicklistId { get; set; }

		public virtual long? BinLocationNumber { get; set; }

		public virtual string PrimaryOrderId { get; set; }

		public virtual long? PrimaryShipGroupSeqId { get; set; }

		public virtual long Version { get; set; }

		public virtual bool Active { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}
