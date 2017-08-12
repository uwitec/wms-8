﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

	public class UserPermissionStateEventIdDto
	{

		public UserPermissionStateEventIdDto()
		{
		}

        public virtual UserPermissionStateEventId ToUserPermissionStateEventId()
        {
            UserPermissionStateEventId v = new UserPermissionStateEventId();
            v.UserId = this.UserId;
            v.PermissionId = this.PermissionId;
            v.UserVersion = this.UserVersion;
            return v;
        }

		public virtual string UserId { 
			get;
			set;
		}

		public virtual string PermissionId { 
			get;
			set;
		}

		public virtual long UserVersion { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserPermissionStateEventIdDto other = obj as UserPermissionStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserId, other.UserId)
				&& Object.Equals (this.PermissionId, other.PermissionId)
				&& Object.Equals (this.UserVersion, other.UserVersion)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserId != null) {
				hash += 13 * this.UserId.GetHashCode ();
			}
			if (this.PermissionId != null) {
				hash += 13 * this.PermissionId.GetHashCode ();
			}
			if (this.UserVersion != null) {
				hash += 13 * this.UserVersion.GetHashCode ();
			}
			return hash;
		}

	}

}

