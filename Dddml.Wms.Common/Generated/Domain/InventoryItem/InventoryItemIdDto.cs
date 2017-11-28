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

	public class InventoryItemIdDto
	{

		public InventoryItemIdDto()
		{
		}

        public virtual InventoryItemId ToInventoryItemId()
        {
            InventoryItemId v = new InventoryItemId();
            v.ProductId = this.ProductId;
            v.LocatorId = this.LocatorId;
            v.AttributeSetInstance = this.AttributeSetInstance;
            return v;
        }

		public virtual string ProductId { 
			get;
			set;
		}

		public virtual string LocatorId { 
			get;
			set;
		}

		public virtual string AttributeSetInstance { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemIdDto other = obj as InventoryItemIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ProductId, other.ProductId)
				&& Object.Equals (this.LocatorId, other.LocatorId)
				&& Object.Equals (this.AttributeSetInstance, other.AttributeSetInstance)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ProductId != null) {
				hash += 13 * this.ProductId.GetHashCode ();
			}
			if (this.LocatorId != null) {
				hash += 13 * this.LocatorId.GetHashCode ();
			}
			if (this.AttributeSetInstance != null) {
				hash += 13 * this.AttributeSetInstance.GetHashCode ();
			}
			return hash;
		}

	}

}


