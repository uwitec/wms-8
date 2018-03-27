﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Picklist
{
    public partial class PicklistAggregate : AggregateBase, IPicklistAggregate
    {

        readonly IPicklistState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IPicklistState State
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

        string IGlobalIdentity<string>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public PicklistAggregate(IPicklistState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IPicklistStateProperties)_state).Version == PicklistState.VersionZero)
            {
                if (IsCommandCreate((IPicklistCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IPicklistCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IPicklistCommand c)
        {
            return c.Version == PicklistState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreatePicklist c)
        {
            IPicklistStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchPicklist c)
        {
            IPicklistStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeletePicklist c)
        {
            IPicklistStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IPicklistStateCreated Map(ICreatePicklist c)
        {
			var stateEventId = new PicklistEventId(c.PicklistId, c.Version);
            IPicklistStateCreated e = NewPicklistStateCreated(stateEventId);
		
            e.Description = c.Description;
            e.FacilityId = c.FacilityId;
            e.ShipmentMethodTypeId = c.ShipmentMethodTypeId;
            e.StatusId = c.StatusId;
            e.PicklistDate = c.PicklistDate;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;

            foreach (ICreatePicklistRole innerCommand in c.PicklistRoles)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IPicklistRoleStateCreated innerEvent = MapCreate(innerCommand, c, version, _state);
                e.AddPicklistRoleEvent(innerEvent);
            }


            return e;
        }

        protected virtual IPicklistStateMergePatched Map(IMergePatchPicklist c)
        {
			var stateEventId = new PicklistEventId(c.PicklistId, c.Version);
            IPicklistStateMergePatched e = NewPicklistStateMergePatched(stateEventId);

            e.Description = c.Description;
            e.FacilityId = c.FacilityId;
            e.ShipmentMethodTypeId = c.ShipmentMethodTypeId;
            e.StatusId = c.StatusId;
            e.PicklistDate = c.PicklistDate;
            e.Active = c.Active;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyFacilityIdRemoved = c.IsPropertyFacilityIdRemoved;
            e.IsPropertyShipmentMethodTypeIdRemoved = c.IsPropertyShipmentMethodTypeIdRemoved;
            e.IsPropertyStatusIdRemoved = c.IsPropertyStatusIdRemoved;
            e.IsPropertyPicklistDateRemoved = c.IsPropertyPicklistDateRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;

            foreach (IPicklistRoleCommand innerCommand in c.PicklistRoleCommands)
            {
                ThrowOnInconsistentCommands(c, innerCommand);

                IPicklistRoleStateEvent innerEvent = Map(innerCommand, c, version, _state);
                e.AddPicklistRoleEvent(innerEvent);
            }


            return e;
        }

        protected virtual IPicklistStateDeleted Map(IDeletePicklist c)
        {
			var stateEventId = new PicklistEventId(c.PicklistId, c.Version);
            IPicklistStateDeleted e = NewPicklistStateDeleted(stateEventId);
			
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();


            return e;
        }


        protected void ThrowOnInconsistentCommands(IPicklistCommand command, IPicklistRoleCommand innerCommand)
        {

            var properties =  command as ICreateOrMergePatchOrDeletePicklist;
            var innerProperties = innerCommand as ICreateOrMergePatchOrRemovePicklistRole;
            if (properties == null || innerProperties == null) { return; }
            if (innerProperties.PicklistId == default(string))
            {
                innerProperties.PicklistId = properties.PicklistId;
            }
            else
            {
                var outerPicklistIdName = "PicklistId";
                var outerPicklistIdValue = properties.PicklistId;
                var innerPicklistIdName = "PicklistId";
                var innerPicklistIdValue = innerProperties.PicklistId;
                ThrowOnInconsistentIds(innerProperties, innerPicklistIdName, innerPicklistIdValue, outerPicklistIdName, outerPicklistIdValue);
            }

        }// END ThrowOnInconsistentCommands /////////////////////


        protected virtual IPicklistRoleStateEvent Map(IPicklistRoleCommand c, IPicklistCommand outerCommand, long version, IPicklistState outerState)
        {
            var create = (c.CommandType == CommandType.Create) ? (c as ICreatePicklistRole) : null;
            if(create != null)
            {
                return MapCreate(create, outerCommand, version, outerState);
            }

            var merge = (c.CommandType == CommandType.MergePatch) ? (c as IMergePatchPicklistRole) : null;
            if(merge != null)
            {
                return MapMergePatch(merge, outerCommand, version, outerState);
            }

            var remove = (c.CommandType == CommandType.Remove) ? (c as IRemovePicklistRole) : null;
            if (remove != null)
            {
                return MapRemove(remove, outerCommand, version);
            }
            throw new NotSupportedException();
        }


        protected virtual IPicklistRoleStateCreated MapCreate(ICreatePicklistRole c, IPicklistCommand outerCommand, long version, IPicklistState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new PicklistRoleEventId(c.PicklistId, c.PartyRoleId, version);
            IPicklistRoleStateCreated e = NewPicklistRoleStateCreated(stateEventId);
            var s = outerState.PicklistRoles.Get(c.PartyRoleId, true);

            e.Active = c.Active;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(ICreate... ////////////////////////////



        protected virtual IPicklistRoleStateMergePatched MapMergePatch(IMergePatchPicklistRole c, IPicklistCommand outerCommand, long version, IPicklistState outerState)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new PicklistRoleEventId(c.PicklistId, c.PartyRoleId, version);
            IPicklistRoleStateMergePatched e = NewPicklistRoleStateMergePatched(stateEventId);
            var s = outerState.PicklistRoles.Get(c.PartyRoleId);

            e.Active = c.Active;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
            return e;

        }// END Map(IMergePatch... ////////////////////////////


        protected virtual IPicklistRoleStateRemoved MapRemove(IRemovePicklistRole c, IPicklistCommand outerCommand, long version)
        {
            c.RequesterId = outerCommand.RequesterId;
			var stateEventId = new PicklistRoleEventId(c.PicklistId, c.PartyRoleId, version);
            IPicklistRoleStateRemoved e = NewPicklistRoleStateRemoved(stateEventId);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;

        }// END Map(IRemove... ////////////////////////////

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

        protected PicklistStateCreated NewPicklistStateCreated(long version, string commandId, string requesterId)
        {
            var stateEventId = new PicklistEventId(_state.PicklistId, version);
            var e = NewPicklistStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedByUserLogin = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected PicklistStateMergePatched NewPicklistStateMergePatched(long version, string commandId, string requesterId)
        {
            var stateEventId = new PicklistEventId(_state.PicklistId, version);
            var e = NewPicklistStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedByUserLogin = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected PicklistStateDeleted NewPicklistStateDeleted(long version, string commandId, string requesterId)
        {
            var stateEventId = new PicklistEventId(_state.PicklistId, version);
            var e = NewPicklistStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedByUserLogin = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private PicklistStateCreated NewPicklistStateCreated(PicklistEventId stateEventId)
		{
			return new PicklistStateCreated(stateEventId);			
		}

        private PicklistStateMergePatched NewPicklistStateMergePatched(PicklistEventId stateEventId)
		{
			return new PicklistStateMergePatched(stateEventId);
		}

        private PicklistStateDeleted NewPicklistStateDeleted(PicklistEventId stateEventId)
		{
			return new PicklistStateDeleted(stateEventId);
		}

		private PicklistRoleStateCreated NewPicklistRoleStateCreated(PicklistRoleEventId stateEventId)
		{
			return new PicklistRoleStateCreated(stateEventId);
		}

        private PicklistRoleStateMergePatched NewPicklistRoleStateMergePatched(PicklistRoleEventId stateEventId)
		{
			return new PicklistRoleStateMergePatched(stateEventId);
		}

        private PicklistRoleStateRemoved NewPicklistRoleStateRemoved(PicklistRoleEventId stateEventId)
		{
			return new PicklistRoleStateRemoved(stateEventId);
		}

    }

}

