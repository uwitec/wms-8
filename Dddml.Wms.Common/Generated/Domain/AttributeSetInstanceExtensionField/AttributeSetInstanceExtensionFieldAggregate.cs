﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionField;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionField
{
    public partial class AttributeSetInstanceExtensionFieldAggregate : AggregateBase, IAttributeSetInstanceExtensionFieldAggregate
    {

        readonly IAttributeSetInstanceExtensionFieldState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IAttributeSetInstanceExtensionFieldState State
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


        public AttributeSetInstanceExtensionFieldAggregate(IAttributeSetInstanceExtensionFieldState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IAttributeSetInstanceExtensionFieldStateProperties)_state).Version == AttributeSetInstanceExtensionFieldState.VersionZero)
            {
                if (IsCommandCreate((IAttributeSetInstanceExtensionFieldCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IAttributeSetInstanceExtensionFieldCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IAttributeSetInstanceExtensionFieldCommand c)
        {
            return c.Version == AttributeSetInstanceExtensionFieldState.VersionZero;
        }

        protected internal virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateAttributeSetInstanceExtensionField c)
        {
            IAttributeSetInstanceExtensionFieldStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchAttributeSetInstanceExtensionField c)
        {
            IAttributeSetInstanceExtensionFieldStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteAttributeSetInstanceExtensionField c)
        {
            IAttributeSetInstanceExtensionFieldStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IAttributeSetInstanceExtensionFieldStateCreated Map(ICreateAttributeSetInstanceExtensionField c)
        {
			var stateEventId = new AttributeSetInstanceExtensionFieldStateEventId(c.Name, c.Version);
            IAttributeSetInstanceExtensionFieldStateCreated e = NewAttributeSetInstanceExtensionFieldStateCreated(stateEventId);
		
            e.Type = c.Type;
            e.Length = c.Length;
            e.Alias = c.Alias;
            e.Description = c.Description;
            e.GroupId = c.GroupId;
            e.Active = c.Active;
            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();
			var version = c.Version;


            return e;
        }

        protected virtual IAttributeSetInstanceExtensionFieldStateMergePatched Map(IMergePatchAttributeSetInstanceExtensionField c)
        {
			var stateEventId = new AttributeSetInstanceExtensionFieldStateEventId(c.Name, c.Version);
            IAttributeSetInstanceExtensionFieldStateMergePatched e = NewAttributeSetInstanceExtensionFieldStateMergePatched(stateEventId);

            e.Type = c.Type;
            e.Length = c.Length;
            e.Alias = c.Alias;
            e.Description = c.Description;
            e.GroupId = c.GroupId;
            e.Active = c.Active;
            e.IsPropertyTypeRemoved = c.IsPropertyTypeRemoved;
            e.IsPropertyLengthRemoved = c.IsPropertyLengthRemoved;
            e.IsPropertyAliasRemoved = c.IsPropertyAliasRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyGroupIdRemoved = c.IsPropertyGroupIdRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            e.CommandId = c.CommandId;


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

			var version = c.Version;


            return e;
        }

        protected virtual IAttributeSetInstanceExtensionFieldStateDeleted Map(IDeleteAttributeSetInstanceExtensionField c)
        {
			var stateEventId = new AttributeSetInstanceExtensionFieldStateEventId(c.Name, c.Version);
            IAttributeSetInstanceExtensionFieldStateDeleted e = NewAttributeSetInstanceExtensionFieldStateDeleted(stateEventId);
			
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

        protected AttributeSetInstanceExtensionFieldStateCreated NewAttributeSetInstanceExtensionFieldStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceExtensionFieldStateEventId(_state.Name, ((IAttributeSetInstanceExtensionFieldStateProperties)_state).Version);
            var e = NewAttributeSetInstanceExtensionFieldStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

        protected AttributeSetInstanceExtensionFieldStateMergePatched NewAttributeSetInstanceExtensionFieldStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceExtensionFieldStateEventId(_state.Name, ((IAttributeSetInstanceExtensionFieldStateProperties)_state).Version);
            var e = NewAttributeSetInstanceExtensionFieldStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }


        protected AttributeSetInstanceExtensionFieldStateDeleted NewAttributeSetInstanceExtensionFieldStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceExtensionFieldStateEventId(_state.Name, ((IAttributeSetInstanceExtensionFieldStateProperties)_state).Version);
            var e = NewAttributeSetInstanceExtensionFieldStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = ApplicationContext.Current.TimestampService.Now<DateTime>();

            return e;
        }

////////////////////////

		private AttributeSetInstanceExtensionFieldStateCreated NewAttributeSetInstanceExtensionFieldStateCreated(AttributeSetInstanceExtensionFieldStateEventId stateEventId)
		{
			return new AttributeSetInstanceExtensionFieldStateCreated(stateEventId);			
		}

        private AttributeSetInstanceExtensionFieldStateMergePatched NewAttributeSetInstanceExtensionFieldStateMergePatched(AttributeSetInstanceExtensionFieldStateEventId stateEventId)
		{
			return new AttributeSetInstanceExtensionFieldStateMergePatched(stateEventId);
		}

        private AttributeSetInstanceExtensionFieldStateDeleted NewAttributeSetInstanceExtensionFieldStateDeleted(AttributeSetInstanceExtensionFieldStateEventId stateEventId)
		{
			return new AttributeSetInstanceExtensionFieldStateDeleted(stateEventId);
		}

    }

}
