﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateStatusItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.StatusItem;

namespace Dddml.Wms.Domain.StatusItem
{

	public class StatusItemStateEventId
	{

		private string _statusId;

		public virtual string StatusId { 
			get { return this._statusId; } 
			internal set { _statusId = value; } 
		}

		private long _version;

		public virtual long Version { 
			get { return this._version; } 
			internal set { _version = value; } 
		}


        #region  Flattened Properties


        #endregion

		internal StatusItemStateEventId ()
		{
		}

		public StatusItemStateEventId (string statusId, long version)
		{
			this._statusId = statusId;
			this._version = version;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			StatusItemStateEventId other = obj as StatusItemStateEventId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.StatusId, other.StatusId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.StatusId != null) {
				hash += 13 * this.StatusId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

        public static bool operator ==(StatusItemStateEventId obj1, StatusItemStateEventId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(StatusItemStateEventId obj1, StatusItemStateEventId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

	}

}


