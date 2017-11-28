﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;

namespace Dddml.Wms.Domain.InventoryItem
{

	public class InventoryItemStateEventIdDto
	{

		public InventoryItemStateEventIdDto()
		{
		}

        public virtual InventoryItemStateEventId ToInventoryItemStateEventId()
        {
            InventoryItemStateEventId v = new InventoryItemStateEventId();
            v.InventoryItemId = this.InventoryItemId.ToInventoryItemId();
            v.Version = this.Version;
            return v;
        }

		private InventoryItemIdDto _inventoryItemId = new InventoryItemIdDto();

		public virtual InventoryItemIdDto InventoryItemId { 
			get { return this._inventoryItemId; } 
			set { this._inventoryItemId = value; } 
		}

		public virtual long Version { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemStateEventIdDto other = obj as InventoryItemStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryItemId, other.InventoryItemId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryItemId != null) {
				hash += 13 * this.InventoryItemId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

	}

}


