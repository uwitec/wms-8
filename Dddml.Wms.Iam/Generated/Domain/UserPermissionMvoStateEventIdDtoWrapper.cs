﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.UserPermissionMvo;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.UserPermissionMvo
{

	public class UserPermissionMvoStateEventIdDtoWrapper : UserPermissionMvoStateEventIdDto
	{

        private UserPermissionMvoStateEventId _value = new UserPermissionMvoStateEventId();

		public UserPermissionMvoStateEventIdDtoWrapper()
		{
		}

		public UserPermissionMvoStateEventIdDtoWrapper(UserPermissionMvoStateEventId val)
		{
			if (val == null) { throw new ArgumentNullException("val"); }
			this._value = val;
		}

        public override UserPermissionMvoStateEventId ToUserPermissionMvoStateEventId()
        {
            return this._value;
        }

		public override UserPermissionIdDto UserPermissionId { 
			get { return new UserPermissionIdDtoWrapper(_value.UserPermissionId); } 
			set { _value.UserPermissionId = value.ToUserPermissionId(); } 
		}

		public override long UserVersion { 
			get { return _value.UserVersion; } 
			set { _value.UserVersion = value; } 
		}


	}

}

