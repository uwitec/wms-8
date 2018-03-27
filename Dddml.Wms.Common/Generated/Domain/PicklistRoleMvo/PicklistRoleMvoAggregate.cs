﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistRoleMvo;
using Dddml.Wms.Domain.Picklist;

namespace Dddml.Wms.Domain.PicklistRoleMvo
{
    public partial class PicklistRoleMvoAggregate : AggregateBase, IPicklistRoleMvoAggregate
    {

        readonly IPicklistRoleMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IPicklistRoleMvoState State
        {
            get
            {
                return _state;
            }
        }

        public IList<IEvent> Changes
        {
            get
            {
                return _changes;
            }
        }

        #region IIdentity implementation

        PicklistRoleId IGlobalIdentity<PicklistRoleId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public PicklistRoleMvoAggregate(IPicklistRoleMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IPicklistRoleMvoStateProperties)_state).PicklistVersion == PicklistRoleMvoState.VersionZero)
            {
                if (IsCommandCreate((IPicklistRoleMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IPicklistRoleMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IPicklistRoleMvoCommand c)
        {
            return c.PicklistVersion == PicklistRoleMvoState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreatePicklistRoleMvo c)
        {
            IPicklistRoleMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchPicklistRoleMvo c)
        {
            IPicklistRoleMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeletePicklistRoleMvo c)
        {
            IPicklistRoleMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IPicklistRoleMvoStateCreated Map(ICreatePicklistRoleMvo c)
        {
			var stateEventId = new PicklistRoleMvoEventId(c.PicklistRoleId, c.PicklistVersion);
            IPicklistRoleMvoStateCreated e = NewPicklistRoleMvoStateCreated(stateEventId);
		
            e.Version = c.Version;
            e.Active = c.Active;
            e.PicklistDescription = c.PicklistDescription;
            e.PicklistFacilityId = c.PicklistFacilityId;
            e.PicklistShipmentMethodTypeId = c.PicklistShipmentMethodTypeId;
            e.PicklistStatusId = c.PicklistStatusId;
            e.PicklistPicklistDate = c.PicklistPicklistDate;
            e.PicklistCreatedByUserLogin = c.PicklistCreatedByUserLogin;
            e.PicklistLastModifiedByUserLogin = c.PicklistLastModifiedByUserLogin;
            e.PicklistCreatedAt = c.PicklistCreatedAt;
            e.PicklistUpdatedAt = c.PicklistUpdatedAt;
            e.PicklistActive = c.PicklistActive;
            e.PicklistDeleted = c.PicklistDeleted;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var picklistVersion = c.PicklistVersion;


            return e;
        }

        protected virtual IPicklistRoleMvoStateMergePatched Map(IMergePatchPicklistRoleMvo c)
        {
			var stateEventId = new PicklistRoleMvoEventId(c.PicklistRoleId, c.PicklistVersion);
            IPicklistRoleMvoStateMergePatched e = NewPicklistRoleMvoStateMergePatched(stateEventId);

            e.Version = c.Version;
            e.Active = c.Active;
            e.PicklistDescription = c.PicklistDescription;
            e.PicklistFacilityId = c.PicklistFacilityId;
            e.PicklistShipmentMethodTypeId = c.PicklistShipmentMethodTypeId;
            e.PicklistStatusId = c.PicklistStatusId;
            e.PicklistPicklistDate = c.PicklistPicklistDate;
            e.PicklistCreatedByUserLogin = c.PicklistCreatedByUserLogin;
            e.PicklistLastModifiedByUserLogin = c.PicklistLastModifiedByUserLogin;
            e.PicklistCreatedAt = c.PicklistCreatedAt;
            e.PicklistUpdatedAt = c.PicklistUpdatedAt;
            e.PicklistActive = c.PicklistActive;
            e.PicklistDeleted = c.PicklistDeleted;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyPicklistDescriptionRemoved = c.IsPropertyPicklistDescriptionRemoved;
            e.IsPropertyPicklistFacilityIdRemoved = c.IsPropertyPicklistFacilityIdRemoved;
            e.IsPropertyPicklistShipmentMethodTypeIdRemoved = c.IsPropertyPicklistShipmentMethodTypeIdRemoved;
            e.IsPropertyPicklistStatusIdRemoved = c.IsPropertyPicklistStatusIdRemoved;
            e.IsPropertyPicklistPicklistDateRemoved = c.IsPropertyPicklistPicklistDateRemoved;
            e.IsPropertyPicklistCreatedByUserLoginRemoved = c.IsPropertyPicklistCreatedByUserLoginRemoved;
            e.IsPropertyPicklistLastModifiedByUserLoginRemoved = c.IsPropertyPicklistLastModifiedByUserLoginRemoved;
            e.IsPropertyPicklistCreatedAtRemoved = c.IsPropertyPicklistCreatedAtRemoved;
            e.IsPropertyPicklistUpdatedAtRemoved = c.IsPropertyPicklistUpdatedAtRemoved;
            e.IsPropertyPicklistActiveRemoved = c.IsPropertyPicklistActiveRemoved;
            e.IsPropertyPicklistDeletedRemoved = c.IsPropertyPicklistDeletedRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var picklistVersion = c.PicklistVersion;


            return e;
        }

        protected virtual IPicklistRoleMvoStateDeleted Map(IDeletePicklistRoleMvo c)
        {
			var stateEventId = new PicklistRoleMvoEventId(c.PicklistRoleId, c.PicklistVersion);
            IPicklistRoleMvoStateDeleted e = NewPicklistRoleMvoStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();


            return e;
        }

        private void ThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (!Object.Equals(innerIdValue, outerIdValue))
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected PicklistRoleMvoStateCreated NewPicklistRoleMvoStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new PicklistRoleMvoEventId(_state.PicklistRoleId, version);
            var e = NewPicklistRoleMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedByUserLogin = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected PicklistRoleMvoStateMergePatched NewPicklistRoleMvoStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new PicklistRoleMvoEventId(_state.PicklistRoleId, version);
            var e = NewPicklistRoleMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedByUserLogin = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected PicklistRoleMvoStateDeleted NewPicklistRoleMvoStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new PicklistRoleMvoEventId(_state.PicklistRoleId, version);
            var e = NewPicklistRoleMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedByUserLogin = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private PicklistRoleMvoStateCreated NewPicklistRoleMvoStateCreated(PicklistRoleMvoEventId stateEventId)
		{
			return new PicklistRoleMvoStateCreated(stateEventId);			
		}

        private PicklistRoleMvoStateMergePatched NewPicklistRoleMvoStateMergePatched(PicklistRoleMvoEventId stateEventId)
		{
			return new PicklistRoleMvoStateMergePatched(stateEventId);
		}

        private PicklistRoleMvoStateDeleted NewPicklistRoleMvoStateDeleted(PicklistRoleMvoEventId stateEventId)
		{
			return new PicklistRoleMvoStateDeleted(stateEventId);
		}
    }

}

