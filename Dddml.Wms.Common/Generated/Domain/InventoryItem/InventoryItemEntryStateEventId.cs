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

	public class InventoryItemEntryStateEventId
	{

		private InventoryItemId _inventoryItemId = new InventoryItemId();

		public virtual InventoryItemId InventoryItemId { 
			get { return this._inventoryItemId; } 
			internal set { _inventoryItemId = value; } 
		}

		private long _entrySeqId;

		public virtual long EntrySeqId { 
			get { return this._entrySeqId; } 
			internal set { _entrySeqId = value; } 
		}

		private long _inventoryItemVersion;

		public virtual long InventoryItemVersion { 
			get { return this._inventoryItemVersion; } 
			internal set { _inventoryItemVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string InventoryItemIdProductId {
			get { return InventoryItemId.ProductId; }
			internal set { InventoryItemId.ProductId = value; }
		}

		public virtual string InventoryItemIdLocatorId {
			get { return InventoryItemId.LocatorId; }
			internal set { InventoryItemId.LocatorId = value; }
		}

		public virtual string InventoryItemIdAttributeSetInstance {
			get { return InventoryItemId.AttributeSetInstance; }
			internal set { InventoryItemId.AttributeSetInstance = value; }
		}

        #endregion

		internal InventoryItemEntryStateEventId ()
		{
		}

		public InventoryItemEntryStateEventId (InventoryItemId inventoryItemId, long entrySeqId, long inventoryItemVersion)
		{
			this._inventoryItemId = inventoryItemId;
			this._entrySeqId = entrySeqId;
			this._inventoryItemVersion = inventoryItemVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemEntryStateEventId other = obj as InventoryItemEntryStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryItemId, other.InventoryItemId)
				&& Object.Equals (this.EntrySeqId, other.EntrySeqId)
				&& Object.Equals (this.InventoryItemVersion, other.InventoryItemVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryItemId != null) {
				hash += 13 * this.InventoryItemId.GetHashCode ();
			}
			if (this.EntrySeqId != null) {
				hash += 13 * this.EntrySeqId.GetHashCode ();
			}
			if (this.InventoryItemVersion != null) {
				hash += 13 * this.InventoryItemVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InventoryItemEntryStateEventId obj1, InventoryItemEntryStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryItemEntryStateEventId obj1, InventoryItemEntryStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


