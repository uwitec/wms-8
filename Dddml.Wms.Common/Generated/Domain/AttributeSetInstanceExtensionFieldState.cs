﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public partial class AttributeSetInstanceExtensionFieldState : AttributeSetInstanceExtensionFieldStateProperties, IAttributeSetInstanceExtensionFieldState
	{

		public virtual long Version { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }



		#region IIdentity implementation

        private AttributeSetInstanceExtensionFieldId _attributeSetInstanceExtensionFieldId = new AttributeSetInstanceExtensionFieldId();

        public virtual AttributeSetInstanceExtensionFieldId AttributeSetInstanceExtensionFieldId 
        {
            get { return this._attributeSetInstanceExtensionFieldId; }
            set { this._attributeSetInstanceExtensionFieldId = value; }
        }

		AttributeSetInstanceExtensionFieldId IGlobalIdentity<AttributeSetInstanceExtensionFieldId>.GlobalId {
			get {
				return  this.AttributeSetInstanceExtensionFieldId;
			}
		}

        string ILocalIdentity<string>.LocalId
        {
            get
            {
                return this.Index;
            }
        }


        public override string GroupId {
			get {
				return this.AttributeSetInstanceExtensionFieldId.GroupId;
			}
			set {
				this.AttributeSetInstanceExtensionFieldId.GroupId = value;
			}
		}

        public override string Index {
			get {
				return this.AttributeSetInstanceExtensionFieldId.AttributeSetInstanceExtensionFieldIndex;
			}
			set {
				this.AttributeSetInstanceExtensionFieldId.AttributeSetInstanceExtensionFieldIndex = value;
			}
		}

		#endregion



		#region IActive implementation

		bool IActive.Active
		{
			get
			{
				return this.Active;
			}
		}

		#endregion


		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get
			{
				return this.UpdatedBy;
			}
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get
			{
				return this.UpdatedAt;
			}
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


		public AttributeSetInstanceExtensionFieldState ()
		{
		}



		public virtual void When(IAttributeSetInstanceExtensionFieldStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Name = e.Name;
			this.Type = e.Type;
			this.Length = e.Length;
			this.Alias = e.Alias;
			this.Description = e.Description;
			this.Active = e.Active;
			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IAttributeSetInstanceExtensionFieldStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.IsPropertyNameRemoved)
			{
				this.Name = default(string);
			}
			else
			{
				if (e.Name != null)
				{
					this.Name = e.Name;
				}
			}
			if (e.IsPropertyTypeRemoved)
			{
				this.Type = default(string);
			}
			else
			{
				if (e.Type != null)
				{
					this.Type = e.Type;
				}
			}
			if (e.IsPropertyLengthRemoved)
			{
				this.Length = default(int?);
			}
			else
			{
				if (e.Length != null)
				{
					this.Length = e.Length;
				}
			}
			if (e.IsPropertyAliasRemoved)
			{
				this.Alias = default(string);
			}
			else
			{
				if (e.Alias != null)
				{
					this.Alias = e.Alias;
				}
			}
			if (e.IsPropertyDescriptionRemoved)
			{
				this.Description = default(string);
			}
			else
			{
				if (e.Description != null)
				{
					this.Description = e.Description;
				}
			}
			if (e.IsPropertyActiveRemoved)
			{
				this.Active = default(bool);
			}
			else
			{
				if (e.Active != null)
				{
					this.Active = e.Active;
				}
			}

			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}


		public virtual void Mutate(IEvent e)
		{
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IAttributeSetInstanceExtensionFieldStateEvent stateEvent)
		{
				var stateEntityIdGroupId = (this as IGlobalIdentity<AttributeSetInstanceExtensionFieldId>).GlobalId.GroupId;
				var eventEntityIdGroupId = stateEvent.StateEventId.GroupId;
				if (stateEntityIdGroupId != eventEntityIdGroupId)
				{
					DomainError.Named("mutateWrongEntity", "Entity Id GroupId {0} in state but entity id GroupId {1} in event", stateEntityIdGroupId, eventEntityIdGroupId);
				}
				var stateEntityIdAttributeSetInstanceExtensionFieldIndex = (this as IGlobalIdentity<AttributeSetInstanceExtensionFieldId>).GlobalId.AttributeSetInstanceExtensionFieldIndex;
				var eventEntityIdAttributeSetInstanceExtensionFieldIndex = stateEvent.StateEventId.AttributeSetInstanceExtensionFieldIndex;
				if (stateEntityIdAttributeSetInstanceExtensionFieldIndex != eventEntityIdAttributeSetInstanceExtensionFieldIndex)
				{
					DomainError.Named("mutateWrongEntity", "Entity Id AttributeSetInstanceExtensionFieldIndex {0} in state but entity id AttributeSetInstanceExtensionFieldIndex {1} in event", stateEntityIdAttributeSetInstanceExtensionFieldIndex, eventEntityIdAttributeSetInstanceExtensionFieldIndex);
				}
		}
	}

}
