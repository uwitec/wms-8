﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLotDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Lot;

namespace Dddml.Wms.Domain.Lot
{

	public class LotStateEventId
	{

		private string _lotId;

		public virtual string LotId { 
			get { return this._lotId; } 
			internal set { _lotId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal LotStateEventId ()
		{
		}

		public LotStateEventId (string lotId, long version)
		{
			this._lotId = lotId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			LotStateEventId other = obj as LotStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.LotId, other.LotId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.LotId != null) {
				hash += 13 * this.LotId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(LotStateEventId obj1, LotStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(LotStateEventId obj1, LotStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


