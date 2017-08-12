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

	public class UserLoginIdDto
	{

		public UserLoginIdDto()
		{
		}

        public virtual UserLoginId ToUserLoginId()
        {
            UserLoginId v = new UserLoginId();
            v.UserId = this.UserId;
            v.LoginKey = this.LoginKey.ToLoginKey();
            return v;
        }

		public virtual string UserId { 
			get;
			set;
		}

		private LoginKeyDto _loginKey = new LoginKeyDto();

		public virtual LoginKeyDto LoginKey { 
			get { return this._loginKey; } 
			set { this._loginKey = value; } 
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserLoginIdDto other = obj as UserLoginIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserId, other.UserId)
				&& Object.Equals (this.LoginKey, other.LoginKey)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.UserId != null) {
				hash += 13 * this.UserId.GetHashCode ();
			}
			if (this.LoginKey != null) {
				hash += 13 * this.LoginKey.GetHashCode ();
			}
			return hash;
		}

	}

}

