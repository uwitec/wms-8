﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryPRTriggeredDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPRTriggered;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryPRTriggered
{

	public abstract class InventoryPRTriggeredStateProperties : IInventoryPRTriggeredStateProperties
	{
		public virtual InventoryPRTriggeredId InventoryPRTriggeredId { get; set; }

		public virtual bool IsProcessed { get; set; }

		public virtual long Version { get; set; }

        protected virtual void InitializeProperties()
        { 
        }

	}
}