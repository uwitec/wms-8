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

	public class UserPermissionId
	{

		private string _userId;

		public virtual string UserId { 
			get { return this._userId; } 
			set { _userId = value; } 
		}

		private string _permissionId;

		public virtual string PermissionId { 
			get { return this._permissionId; } 
			set { _permissionId = value; } 
		}


        #region  Flattened Properties


        #endregion

		public UserPermissionId ()
		{
		}

		public UserPermissionId (string userId, string permissionId)
		{
			this._userId = userId;
			this._permissionId = permissionId;

		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			UserPermissionId other = obj as UserPermissionId;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.UserId, other.UserId)
				&& Object.Equals (this.PermissionId, other.PermissionId)
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
			return hash;
		}

        public static bool operator ==(UserPermissionId obj1, UserPermissionId obj2)
        {
            return Object.Equals(obj1, obj2);
        }

        public static bool operator !=(UserPermissionId obj1, UserPermissionId obj2)
        {
            return !Object.Equals(obj1, obj2);
        }

        public override string ToString()
        {
            return String.Empty
                + "UserId: " + this.UserId + ", "
                + "PermissionId: " + this.PermissionId + ", "
                ;
        }

        protected internal static readonly string[] FlattenedPropertyNames = new string[] { "UserId", "PermissionId" };

        protected internal static readonly Type[] FlattenedPropertyTypes = new Type[] { typeof(string), typeof(string) };

        protected internal static readonly IDictionary<string, Type> FlattenedPropertyTypeDictionary;

        static UserPermissionId()
        {
            var dict = new Dictionary<string, Type>();
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                dict.Add(FlattenedPropertyNames[i], FlattenedPropertyTypes[i]);
            }
            FlattenedPropertyTypeDictionary = dict;
        }

        protected internal void ForEachFlattenedProperty(Action<string, object> act)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                object pv = m.GetValue(this);
                act(pn, pv);
            }
        }

        protected internal void SetFlattenedPropertyValues(params object[] values)
        {
            for (int i = 0; i < FlattenedPropertyNames.Length; i++)
            {
                string pn = FlattenedPropertyNames[i];
                if (Char.IsLower(pn[0])) { pn = Char.ToUpper(pn[0]) + pn.Substring(1); }
                var v = values[i];
                var m = this.GetType().GetProperty(pn, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                m.SetValue(this, v);
            }
        }
	}

}


