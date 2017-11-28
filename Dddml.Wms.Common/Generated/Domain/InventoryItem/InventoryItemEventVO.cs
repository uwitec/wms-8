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

	public class InventoryItemEventVO
	{

		private string _inventoryItemEventTypeId;

		public virtual string InventoryItemEventTypeId { 
			get { return this._inventoryItemEventTypeId; } 
			internal set { _inventoryItemEventTypeId = value; } 
		}

		private string _documentNumber;

		public virtual string DocumentNumber { 
			get { return this._documentNumber; } 
			internal set { _documentNumber = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal InventoryItemEventVO ()
		{
		}

		public InventoryItemEventVO (string inventoryItemEventTypeId, string documentNumber)
		{
			this._inventoryItemEventTypeId = inventoryItemEventTypeId;
			this._documentNumber = documentNumber;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			InventoryItemEventVO other = obj as InventoryItemEventVO;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.InventoryItemEventTypeId, other.InventoryItemEventTypeId)
				&& Object.Equals (this.DocumentNumber, other.DocumentNumber)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.InventoryItemEventTypeId != null) {
				hash += 13 * this.InventoryItemEventTypeId.GetHashCode ();
			}
			if (this.DocumentNumber != null) {
				hash += 13 * this.DocumentNumber.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(InventoryItemEventVO obj1, InventoryItemEventVO obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(InventoryItemEventVO obj1, InventoryItemEventVO obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


