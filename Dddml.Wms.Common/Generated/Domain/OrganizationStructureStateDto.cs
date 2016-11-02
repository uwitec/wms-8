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

	public partial class OrganizationStructureStateDto : StateDtoBase, IOrganizationStructureState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private OrganizationStructureState _state;

        public OrganizationStructureStateDto()
        {
            this._state = new OrganizationStructureState();
        }

		public OrganizationStructureStateDto(OrganizationStructureState state)
		{
            this._state = state;
		}

		internal OrganizationStructureState ToOrganizationStructureState()
		{
			return this._state;
		}


        public OrganizationStructureIdDto Id
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Id"))
                {
					return (_state.Id == null) ? null : new OrganizationStructureIdDto(_state.Id);
                }
                return null;
            }
            set
            {
                _state.Id = (value == null) ? null : value.ToOrganizationStructureId();
            }
        }


        OrganizationStructureId IOrganizationStructureStateProperties.Id
        {
            get 
            {
                return (this._state as IOrganizationStructureStateProperties).Id;
            }
            set 
            {
                this._state.Id = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Active"))
                {
                    return _state.Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Active = value.Value;
                }
            }
        }

        bool IOrganizationStructureStateProperties.Active
        {
            get 
            {
                return (this._state as IOrganizationStructureStateProperties).Active;
            }
            set 
            {
                this._state.Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("Version"))
                {
                    return _state.Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.Version = value.Value;
                }
            }
        }

        long IOrganizationStructureStateProperties.Version
        {
            get 
            {
                return (this._state as IOrganizationStructureStateProperties).Version;
            }
            set 
            {
                this._state.Version = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("CreatedBy"))
                {
                    return _state.CreatedBy;
                }
                return null;
            }
            set
            {
                _state.CreatedBy = value;
            }
        }
		public virtual DateTime? CreatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("CreatedAt"))
                {
                    return _state.CreatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.CreatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.CreatedAt = value.Value;
                }
            }
        }
		public virtual string UpdatedBy
		{
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedBy"))
                {
                    return _state.UpdatedBy;
                }
                return null;
            }
            set
            {
                _state.UpdatedBy = value;
            }
        }
		public virtual DateTime? UpdatedAt
        {
            get
            {
                if ((this as IStateDto).ReturnedFieldsContains("UpdatedAt"))
                {
                    return _state.UpdatedAt.Date < default(DateTime).Date.AddDays(1) ? (DateTime?)null : _state.UpdatedAt;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.UpdatedAt = value.Value;
                }
            }
        }

		#region IIdentity implementation

		OrganizationStructureId IGlobalIdentity<OrganizationStructureId>.GlobalId
		{
			get { return (_state as IOrganizationStructureState).GlobalId; }
		}

		#endregion


		#region IActive implementation

		bool IActive.Active
		{
            get { return (_state as IActive).Active; }
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
            get { return (_state as IDeleted).Deleted; }
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as IOrganizationStructureState).CreatedBy; }
            set { (_state as IOrganizationStructureState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as IOrganizationStructureState).CreatedAt; }
            set { (_state as IOrganizationStructureState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as IOrganizationStructureState).UpdatedBy; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as IOrganizationStructureState).UpdatedAt; }
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
            get { return _state.Version; }
		}

		#endregion

        bool IOrganizationStructureState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == OrganizationStructureState.VersionZero; }
        }


		void IOrganizationStructureState.When(IOrganizationStructureStateCreated e)
		{
            throw new NotSupportedException();
		}


		void IOrganizationStructureState.When(IOrganizationStructureStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void IOrganizationStructureState.When(IOrganizationStructureStateDeleted e)
		{
            throw new NotSupportedException();
		}


		void IOrganizationStructureState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////


	}

    partial class OrganizationStructureStateDtoCollection : StateDtoCollectionBase<OrganizationStructureStateDto>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(OrganizationStructureStateDto._collectionFieldNames, fieldName);
        }

    }

}

