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
    public partial class AttributeSetInstanceExtensionFieldMvoAggregate : AggregateBase, IAttributeSetInstanceExtensionFieldMvoAggregate
    {

        readonly IAttributeSetInstanceExtensionFieldMvoState _state;

        readonly IList<IEvent> _changes = new List<IEvent>();

        public IAttributeSetInstanceExtensionFieldMvoState State
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

        AttributeSetInstanceExtensionFieldId IGlobalIdentity<AttributeSetInstanceExtensionFieldId>.GlobalId
        {
            get
            {
                return this._state.GlobalId;
            }
        }

        #endregion


        public AttributeSetInstanceExtensionFieldMvoAggregate(IAttributeSetInstanceExtensionFieldMvoState state)
        {
            _state = state;
        }


        public virtual void ThrowOnInvalidStateTransition(ICommand c)
        {
            if (((IAttributeSetInstanceExtensionFieldMvoStateProperties)_state).AttrSetInstEFGroupVersion == AttributeSetInstanceExtensionFieldMvoState.VersionZero)
            {
                if (IsCommandCreate((IAttributeSetInstanceExtensionFieldMvoCommand)c))
                {
                    return;
                }
                throw DomainError.Named("premature", "Can't do anything to unexistent aggregate");
            }
            if (_state.Deleted)
            {
                throw DomainError.Named("zombie", "Can't do anything to deleted aggregate.");
            }
            if (IsCommandCreate((IAttributeSetInstanceExtensionFieldMvoCommand)c))
                throw DomainError.Named("rebirth", "Can't create aggregate that already exists");
        }

        private static bool IsCommandCreate(IAttributeSetInstanceExtensionFieldMvoCommand c)
        {
            return c.AttrSetInstEFGroupVersion == AttributeSetInstanceExtensionFieldMvoState.VersionZero;
        }

        protected virtual void Apply(IEvent e)
        {
            OnApplying(e);
            _state.Mutate(e);
            _changes.Add(e);
        }

        public virtual void Create(ICreateAttributeSetInstanceExtensionFieldMvo c)
        {
            IAttributeSetInstanceExtensionFieldMvoStateCreated e = Map(c);
            Apply(e);
        }

        public virtual void MergePatch(IMergePatchAttributeSetInstanceExtensionFieldMvo c)
        {
            IAttributeSetInstanceExtensionFieldMvoStateMergePatched e = Map(c);
            Apply(e);
        }

        public virtual void Delete(IDeleteAttributeSetInstanceExtensionFieldMvo c)
        {
            IAttributeSetInstanceExtensionFieldMvoStateDeleted e = Map(c);
            Apply(e);
        }


        protected virtual IAttributeSetInstanceExtensionFieldMvoStateCreated Map(ICreateAttributeSetInstanceExtensionFieldMvo c)
        {
			var stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(c.AttributeSetInstanceExtensionFieldId, c.AttrSetInstEFGroupVersion);
            IAttributeSetInstanceExtensionFieldMvoStateCreated e = NewAttributeSetInstanceExtensionFieldMvoStateCreated(stateEventId);
		
            e.Name = c.Name;
            e.Type = c.Type;
            e.Length = c.Length;
            e.Alias = c.Alias;
            e.Description = c.Description;
            e.Version = c.Version;
            e.Active = c.Active;
            e.AttrSetInstEFGroupFieldType = c.AttrSetInstEFGroupFieldType;
            e.AttrSetInstEFGroupFieldLength = c.AttrSetInstEFGroupFieldLength;
            e.AttrSetInstEFGroupFieldCount = c.AttrSetInstEFGroupFieldCount;
            e.AttrSetInstEFGroupNameFormat = c.AttrSetInstEFGroupNameFormat;
            e.AttrSetInstEFGroupDescription = c.AttrSetInstEFGroupDescription;
            e.AttrSetInstEFGroupCreatedBy = c.AttrSetInstEFGroupCreatedBy;
            e.AttrSetInstEFGroupCreatedAt = c.AttrSetInstEFGroupCreatedAt;
            e.AttrSetInstEFGroupUpdatedBy = c.AttrSetInstEFGroupUpdatedBy;
            e.AttrSetInstEFGroupUpdatedAt = c.AttrSetInstEFGroupUpdatedAt;
            e.AttrSetInstEFGroupActive = c.AttrSetInstEFGroupActive;
            e.AttrSetInstEFGroupDeleted = c.AttrSetInstEFGroupDeleted;
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;
			var attrSetInstEFGroupVersion = c.AttrSetInstEFGroupVersion;


            return e;
        }

        protected virtual IAttributeSetInstanceExtensionFieldMvoStateMergePatched Map(IMergePatchAttributeSetInstanceExtensionFieldMvo c)
        {
			var stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(c.AttributeSetInstanceExtensionFieldId, c.AttrSetInstEFGroupVersion);
            IAttributeSetInstanceExtensionFieldMvoStateMergePatched e = NewAttributeSetInstanceExtensionFieldMvoStateMergePatched(stateEventId);

            e.Name = c.Name;
            e.Type = c.Type;
            e.Length = c.Length;
            e.Alias = c.Alias;
            e.Description = c.Description;
            e.Version = c.Version;
            e.Active = c.Active;
            e.AttrSetInstEFGroupFieldType = c.AttrSetInstEFGroupFieldType;
            e.AttrSetInstEFGroupFieldLength = c.AttrSetInstEFGroupFieldLength;
            e.AttrSetInstEFGroupFieldCount = c.AttrSetInstEFGroupFieldCount;
            e.AttrSetInstEFGroupNameFormat = c.AttrSetInstEFGroupNameFormat;
            e.AttrSetInstEFGroupDescription = c.AttrSetInstEFGroupDescription;
            e.AttrSetInstEFGroupCreatedBy = c.AttrSetInstEFGroupCreatedBy;
            e.AttrSetInstEFGroupCreatedAt = c.AttrSetInstEFGroupCreatedAt;
            e.AttrSetInstEFGroupUpdatedBy = c.AttrSetInstEFGroupUpdatedBy;
            e.AttrSetInstEFGroupUpdatedAt = c.AttrSetInstEFGroupUpdatedAt;
            e.AttrSetInstEFGroupActive = c.AttrSetInstEFGroupActive;
            e.AttrSetInstEFGroupDeleted = c.AttrSetInstEFGroupDeleted;
            e.IsPropertyNameRemoved = c.IsPropertyNameRemoved;
            e.IsPropertyTypeRemoved = c.IsPropertyTypeRemoved;
            e.IsPropertyLengthRemoved = c.IsPropertyLengthRemoved;
            e.IsPropertyAliasRemoved = c.IsPropertyAliasRemoved;
            e.IsPropertyDescriptionRemoved = c.IsPropertyDescriptionRemoved;
            e.IsPropertyVersionRemoved = c.IsPropertyVersionRemoved;
            e.IsPropertyActiveRemoved = c.IsPropertyActiveRemoved;
            e.IsPropertyAttrSetInstEFGroupFieldTypeRemoved = c.IsPropertyAttrSetInstEFGroupFieldTypeRemoved;
            e.IsPropertyAttrSetInstEFGroupFieldLengthRemoved = c.IsPropertyAttrSetInstEFGroupFieldLengthRemoved;
            e.IsPropertyAttrSetInstEFGroupFieldCountRemoved = c.IsPropertyAttrSetInstEFGroupFieldCountRemoved;
            e.IsPropertyAttrSetInstEFGroupNameFormatRemoved = c.IsPropertyAttrSetInstEFGroupNameFormatRemoved;
            e.IsPropertyAttrSetInstEFGroupDescriptionRemoved = c.IsPropertyAttrSetInstEFGroupDescriptionRemoved;
            e.IsPropertyAttrSetInstEFGroupCreatedByRemoved = c.IsPropertyAttrSetInstEFGroupCreatedByRemoved;
            e.IsPropertyAttrSetInstEFGroupCreatedAtRemoved = c.IsPropertyAttrSetInstEFGroupCreatedAtRemoved;
            e.IsPropertyAttrSetInstEFGroupUpdatedByRemoved = c.IsPropertyAttrSetInstEFGroupUpdatedByRemoved;
            e.IsPropertyAttrSetInstEFGroupUpdatedAtRemoved = c.IsPropertyAttrSetInstEFGroupUpdatedAtRemoved;
            e.IsPropertyAttrSetInstEFGroupActiveRemoved = c.IsPropertyAttrSetInstEFGroupActiveRemoved;
            e.IsPropertyAttrSetInstEFGroupDeletedRemoved = c.IsPropertyAttrSetInstEFGroupDeletedRemoved;

            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;

			var attrSetInstEFGroupVersion = c.AttrSetInstEFGroupVersion;


            return e;
        }

        protected virtual IAttributeSetInstanceExtensionFieldMvoStateDeleted Map(IDeleteAttributeSetInstanceExtensionFieldMvo c)
        {
			var stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(c.AttributeSetInstanceExtensionFieldId, c.AttrSetInstEFGroupVersion);
            IAttributeSetInstanceExtensionFieldMvoStateDeleted e = NewAttributeSetInstanceExtensionFieldMvoStateDeleted(stateEventId);
			
            ReflectUtils.CopyPropertyValue("CommandId", c, e);


            e.CreatedBy = (string)c.RequesterId;
            e.CreatedAt = DateTime.Now;


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

        protected AttributeSetInstanceExtensionFieldMvoStateCreated NewAttributeSetInstanceExtensionFieldMvoStateCreated(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(_state.AttributeSetInstanceExtensionFieldId, ((IAttributeSetInstanceExtensionFieldMvoStateProperties)_state).AttrSetInstEFGroupVersion);
            var e = NewAttributeSetInstanceExtensionFieldMvoStateCreated(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

        protected AttributeSetInstanceExtensionFieldMvoStateMergePatched NewAttributeSetInstanceExtensionFieldMvoStateMergePatched(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(_state.AttributeSetInstanceExtensionFieldId, ((IAttributeSetInstanceExtensionFieldMvoStateProperties)_state).AttrSetInstEFGroupVersion);
            var e = NewAttributeSetInstanceExtensionFieldMvoStateMergePatched(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }


        protected AttributeSetInstanceExtensionFieldMvoStateDeleted NewAttributeSetInstanceExtensionFieldMvoStateDeleted(string commandId, string requesterId)
        {
            var stateEventId = new AttributeSetInstanceExtensionFieldMvoStateEventId(_state.AttributeSetInstanceExtensionFieldId, ((IAttributeSetInstanceExtensionFieldMvoStateProperties)_state).AttrSetInstEFGroupVersion);
            var e = NewAttributeSetInstanceExtensionFieldMvoStateDeleted(stateEventId);

            e.CommandId = commandId;

            e.CreatedBy = (string)requesterId;
            e.CreatedAt = DateTime.Now;

            return e;
        }

////////////////////////

		private AttributeSetInstanceExtensionFieldMvoStateCreated NewAttributeSetInstanceExtensionFieldMvoStateCreated(AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId)
		{
			return new AttributeSetInstanceExtensionFieldMvoStateCreated(stateEventId);			
		}

        private AttributeSetInstanceExtensionFieldMvoStateMergePatched NewAttributeSetInstanceExtensionFieldMvoStateMergePatched(AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId)
		{
			return new AttributeSetInstanceExtensionFieldMvoStateMergePatched(stateEventId);
		}

        private AttributeSetInstanceExtensionFieldMvoStateDeleted NewAttributeSetInstanceExtensionFieldMvoStateDeleted(AttributeSetInstanceExtensionFieldMvoStateEventId stateEventId)
		{
			return new AttributeSetInstanceExtensionFieldMvoStateDeleted(stateEventId);
		}


    }

}

