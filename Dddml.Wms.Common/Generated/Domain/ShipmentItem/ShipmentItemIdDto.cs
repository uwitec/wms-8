﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItem;

namespace Dddml.Wms.Domain.ShipmentItem
{

	public class ShipmentItemIdDto
	{

		public ShipmentItemIdDto()
		{
		}

        public virtual ShipmentItemId ToShipmentItemId()
        {
            ShipmentItemId v = new ShipmentItemId();
            v.ShipmentId = this.ShipmentId;
            v.ShipmentItemSeqId = this.ShipmentItemSeqId;
            return v;
        }

		public virtual string ShipmentId { 
			get;
			set;
		}

		public virtual string ShipmentItemSeqId { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ShipmentItemIdDto other = obj as ShipmentItemIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ShipmentId, other.ShipmentId)
				&& Object.Equals (this.ShipmentItemSeqId, other.ShipmentItemSeqId)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ShipmentId != null) {
				hash += 13 * this.ShipmentId.GetHashCode ();
			}
			if (this.ShipmentItemSeqId != null) {
				hash += 13 * this.ShipmentItemSeqId.GetHashCode ();
			}
			return hash;
		}

	}

}

