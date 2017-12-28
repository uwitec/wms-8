﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemRequirementDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;

namespace Dddml.Wms.Domain.InventoryItemRequirement
{

	public class InventoryItemRequirementEntryStateEventId
	{

		private InventoryItemId _inventoryItemRequirementId = new InventoryItemId();

		public virtual InventoryItemId InventoryItemRequirementId { 
			get { return this._inventoryItemRequirementId; } 
			internal set { _inventoryItemRequirementId = value; } 
		}

		private long _entrySeqId;

		public virtual long EntrySeqId { 
			get { return this._entrySeqId; } 
			internal set { _entrySeqId = value; } 
		}

		private long _inventoryItemRequirementVersion;

		public virtual long InventoryItemRequirementVersion { 
			get { return this._inventoryItemRequirementVersion; } 
			internal set { _inventoryItemRequirementVersion = value; } 
		}


        #region  Flattened Properties


		public virtual string InventoryItemRequirementIdProductId {
			get { return InventoryItemRequirementId.ProductId; }
			internal set { InventoryItemRequirementId.ProductId = value; }
		}

		public virtual string InventoryItemRequirementIdLocatorId {
			get { return InventoryItemRequirementId.LocatorId; }
			internal set { InventoryItemRequirementId.LocatorId = value; }
		}

		public virtual string InventoryItemRequirementIdAttributeSetInstanceId {
			get { return InventoryItemRequirementId.AttributeSetInstanceId; }
			internal set { InventoryItemRequirementId.AttributeSetInstanceId = value; }
		}

        #endregion

		internal InventoryItemRequirementEntryStateEventId ()
		{
		}

		public InventoryItemRequirementEntryStateEventId (InventoryItemId inventoryItemRequirementId, long entrySeqId, long inventoryItemRequirementVersion)
		{
			this._inventoryItemRequirementId = inventoryItemRequirementId;
			this._entrySeqId = entrySeqId;
			this._inventoryItemRequirementVersion = inventoryItemRequirementVersion;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemRequirementEntryStateEventId other = obj as InventoryItemRequirementEntryStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryItemRequirementId, other.InventoryItemRequirementId)
				&& Object.Equals (this.EntrySeqId, other.EntrySeqId)
				&& Object.Equals (this.InventoryItemRequirementVersion, other.InventoryItemRequirementVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryItemRequirementId != null) {
				hash += 13 * this.InventoryItemRequirementId.GetHashCode ();
			}
			if (this.EntrySeqId != null) {
				hash += 13 * this.EntrySeqId.GetHashCode ();
			}
			if (this.InventoryItemRequirementVersion != null) {
				hash += 13 * this.InventoryItemRequirementVersion.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InventoryItemRequirementEntryStateEventId obj1, InventoryItemRequirementEntryStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryItemRequirementEntryStateEventId obj1, InventoryItemRequirementEntryStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}

