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

	public class StatusItemStateEventIdDto
	{

		public StatusItemStateEventIdDto()
		{
		}

        public virtual StatusItemStateEventId ToStatusItemStateEventId()
        {
            StatusItemStateEventId v = new StatusItemStateEventId();
            v.StatusId = this.StatusId;
            v.Version = this.Version;
            return v;
        }

		public virtual string StatusId { 
			get;
			set;
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

			StatusItemStateEventIdDto other = obj as StatusItemStateEventIdDto;
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

	}

}


