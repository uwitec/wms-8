﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.User;

namespace Dddml.Wms.Domain.User
{

    public class UserRoleStates : IUserRoleStates
    {
        
		protected IUserRoleStateDao UserRoleStateDao
		{
			get
			{
				return ApplicationContext.Current["UserRoleStateDao"] as IUserRoleStateDao;
			}
		}

		private Dictionary<UserRoleId, IUserRoleState> _loadedUserRoleStates = new Dictionary<UserRoleId, IUserRoleState>();

		private Dictionary<UserRoleId, IUserRoleState> _removedUserRoleStates = new Dictionary<UserRoleId, IUserRoleState>();

		protected virtual IEnumerable<IUserRoleState> LoadedUserRoleStates {
			get {
				return this._loadedUserRoleStates.Values;
			}
		}

        private IUserState _userState;

        private IEnumerable<IUserRoleState> InnerEnumeralbe
        {
            get
            {
                if (!ForReapplying)
                {
                    return UserRoleStateDao.FindByUserId(_userState.UserId);
                }
                else
                {
                    return _loadedUserRoleStates.Values.Where(s => !(_removedUserRoleStates.ContainsKey(s.GlobalId) && s.Deleted));
                }
            }
        }

        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public UserRoleStates(IUserState outerState)
        {
            this._userState = outerState;
            this._forReapplying = outerState.ForReapplying;
        }

        public IEnumerator<IUserRoleState> GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return InnerEnumeralbe.GetEnumerator();
        }

        public virtual void Remove(IUserRoleState state)
        {
            this._removedUserRoleStates.Add(state.GlobalId, state);
        }

        public virtual IUserRoleState Get(string roleId)
		{
			return Get(roleId, false, false);
		}

        public virtual IUserRoleState Get(string roleId, bool forCreation)
        {
			return Get(roleId, forCreation, false);
        }

        public virtual IUserRoleState Get(string roleId, bool forCreation, bool nullAllowed)
        {
            UserRoleId globalId = new UserRoleId(_userState.UserId, roleId);
            if (_loadedUserRoleStates.ContainsKey(globalId)) {
                var state = _loadedUserRoleStates[globalId];
                if (this._userState != null && this._userState.ReadOnly == false) { ((IUserRoleState)state).ReadOnly = false; }
                return state;
            }
            if (forCreation || ForReapplying)
            {
                var state = new UserRoleState(ForReapplying);
                state.UserRoleId = globalId;
                _loadedUserRoleStates.Add(globalId, state);
                if (this._userState != null && this._userState.ReadOnly == false) { ((IUserRoleState)state).ReadOnly = false; }
                return state;
            }
            else
            {
                var state = UserRoleStateDao.Get(globalId, nullAllowed);
                if (state != null)
                {
                    _loadedUserRoleStates.Add(globalId, state);
                }
                if (this._userState != null && this._userState.ReadOnly == false) { ((IUserRoleState)state).ReadOnly = false; }
                return state;
            }
        }

        public virtual void AddToSave(IUserRoleState state)
        {
            this._loadedUserRoleStates[state.GlobalId] = state;
        }

		#region Saveable Implements

		public virtual void Save ()
		{
			foreach (IUserRoleState s in this.LoadedUserRoleStates) {
                UserRoleStateDao.Save(s);
			}
            foreach(IUserRoleState s in this._removedUserRoleStates.Values)
            {
                UserRoleStateDao.Delete(s);
            }
		}

		#endregion


    }



}


