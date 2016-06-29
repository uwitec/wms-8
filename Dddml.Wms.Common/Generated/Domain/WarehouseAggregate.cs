﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{
    public partial class WarehouseAggregate : AggregateBase, IWarehouseAggregate
    {

        readonly IWarehouseState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IWarehouseState State
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


        public WarehouseAggregate(IWarehouseState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IWarehouseStateProperties)_state).Version == WarehouseState.VersionZero)
            {
                if (IsCommandCreate((IWarehouseCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IWarehouseCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IWarehouseCommand c)
        {
            return c.Version == WarehouseState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateWarehouse c)
        {
            IWarehouseStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchWarehouse c)
        {
            IWarehouseStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteWarehouse c)
        {
            IWarehouseStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IWarehouseStateCreated Map(ICreateWarehouse c)
        {
			var stateEventId = new WarehouseStateEventId(c.WarehouseId, c.Version);
            IWarehouseStateCreated e = NewWarehouseStateCreated(stateEventId);
		
            e.Name = c.Name;
            e.Description = c.Description;
            e.IsInTransit = c.IsInTransit;
            e.Active = c.Active;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var version = c.Version;


            return e;
        }

        protected virtual IWarehouseStateMergePatched Map(IMergePatchWarehouse c)
        {
			var stateEventId = new WarehouseStateEventId(c.WarehouseId, c.Version);
            IWarehouseStateMergePatched e = NewWarehouseStateMergePatched(stateEventId);

            e.Name = c.Name;
            e.Description = c.Description;
            e.IsInTransit = c.IsInTransit;
            e.Active = c.Active;
            e.IsPropertyNameRemoved = c.IsPropertyNameRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyIsInTransitRemoved = c.IsPropertyIsInTransitRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var version = c.Version;


            return e;
        }

        protected virtual IWarehouseStateDeleted Map(IDeleteWarehouse c)
        {
			var stateEventId = new WarehouseStateEventId(c.WarehouseId, c.Version);
            IWarehouseStateDeleted e = NewWarehouseStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


            return e;
        }

        private void SetNullInnerIdOrThrowOnInconsistentIds(object innerObject, string innerIdName, object innerIdValue, string outerIdName, object outerIdValue)
        {
            if (innerIdValue == null)
            {
                ReflectUtils.SetPropertyValue(innerIdName, innerObject, outerIdValue);
            }
            else if (innerIdValue != outerIdValue)
            {
                if (innerIdValue is string && outerIdValue is string && ((string)innerIdValue).Normalize() == ((string)outerIdValue).Normalize())
                {
                    return;
                }
                throw DomainError.Named("inconsistentId", "Outer {0} {1} NOT equals inner {2} {3}", outerIdName, outerIdValue, innerIdName, innerIdValue);
            }
        }

////////////////////////

        protected WarehouseStateCreated NewWarehouseStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new WarehouseStateEventId(_state.WarehouseId, ((IWarehouseStateProperties)_state).Version);
            var e = NewWarehouseStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected WarehouseStateMergePatched NewWarehouseStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new WarehouseStateEventId(_state.WarehouseId, ((IWarehouseStateProperties)_state).Version);
            var e = NewWarehouseStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected WarehouseStateDeleted NewWarehouseStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new WarehouseStateEventId(_state.WarehouseId, ((IWarehouseStateProperties)_state).Version);
            var e = NewWarehouseStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private WarehouseStateCreated NewWarehouseStateCreated(WarehouseStateEventId stateEventId)
		{
			return new WarehouseStateCreated(stateEventId);			
		}

        private WarehouseStateMergePatched NewWarehouseStateMergePatched(WarehouseStateEventId stateEventId)
		{
			return new WarehouseStateMergePatched(stateEventId);
		}

        private WarehouseStateDeleted NewWarehouseStateDeleted(WarehouseStateEventId stateEventId)
		{
			return new WarehouseStateDeleted(stateEventId);
		}


    }

}

