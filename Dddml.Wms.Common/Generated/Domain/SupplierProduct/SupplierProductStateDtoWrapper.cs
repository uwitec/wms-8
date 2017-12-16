﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateSupplierProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SupplierProduct;

namespace Dddml.Wms.Domain.SupplierProduct
{

	public partial class SupplierProductStateDtoWrapper : StateDtoWrapperBase, ISupplierProductStateDto, ISupplierProductState
	{

        internal static IList<string> _collectionFieldNames = new string[] {  };

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(_collectionFieldNames, fieldName);
        }

		private ISupplierProductState _state;

        public SupplierProductStateDtoWrapper()
        {
            this._state = new SupplierProductState();
        }

		public SupplierProductStateDtoWrapper(ISupplierProductState state)
		{
            this._state = state;
		}

		public ISupplierProductState ToSupplierProductState()
		{
			return this._state;
		}

        public SupplierProductIdDto SupplierProductId
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SupplierProductId"))
                {
					return (_state.SupplierProductId == null) ? null : new SupplierProductIdDtoWrapper(_state.SupplierProductId);
                }
                return null;
            }
            set
            {
                _state.SupplierProductId = (value == null) ? null : value.ToSupplierProductId();
            }
        }

        SupplierProductId ISupplierProductStateProperties.SupplierProductId
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).SupplierProductId;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).SupplierProductId = value;
            }
        }

		public virtual DateTime? AvailableThruDate
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("AvailableThruDate"))
                {
                    return _state.AvailableThruDate;
                }
                return null;
            }
            set
            {
                _state.AvailableThruDate = value;
            }
        }

        DateTime? ISupplierProductStateProperties.AvailableThruDate
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).AvailableThruDate;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).AvailableThruDate = value;
            }
        }

		public virtual string SupplierPrefOrderId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SupplierPrefOrderId"))
                {
                    return _state.SupplierPrefOrderId;
                }
                return null;
            }
            set
            {
                _state.SupplierPrefOrderId = value;
            }
        }

        string ISupplierProductStateProperties.SupplierPrefOrderId
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).SupplierPrefOrderId;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).SupplierPrefOrderId = value;
            }
        }

		public virtual string SupplierRatingTypeId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("SupplierRatingTypeId"))
                {
                    return _state.SupplierRatingTypeId;
                }
                return null;
            }
            set
            {
                _state.SupplierRatingTypeId = value;
            }
        }

        string ISupplierProductStateProperties.SupplierRatingTypeId
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).SupplierRatingTypeId;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).SupplierRatingTypeId = value;
            }
        }

		public virtual decimal? StandardLeadTimeDays
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("StandardLeadTimeDays"))
                {
                    return _state.StandardLeadTimeDays;
                }
                return null;
            }
            set
            {
                _state.StandardLeadTimeDays = value;
            }
        }

        decimal? ISupplierProductStateProperties.StandardLeadTimeDays
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).StandardLeadTimeDays;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).StandardLeadTimeDays = value;
            }
        }

		public virtual decimal? ManufacturingLeadTimeDays
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ManufacturingLeadTimeDays"))
                {
                    return _state.ManufacturingLeadTimeDays;
                }
                return null;
            }
            set
            {
                _state.ManufacturingLeadTimeDays = value;
            }
        }

        decimal? ISupplierProductStateProperties.ManufacturingLeadTimeDays
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).ManufacturingLeadTimeDays;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).ManufacturingLeadTimeDays = value;
            }
        }

		public virtual decimal? DeliveryLeadTimeDays
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("DeliveryLeadTimeDays"))
                {
                    return _state.DeliveryLeadTimeDays;
                }
                return null;
            }
            set
            {
                _state.DeliveryLeadTimeDays = value;
            }
        }

        decimal? ISupplierProductStateProperties.DeliveryLeadTimeDays
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).DeliveryLeadTimeDays;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).DeliveryLeadTimeDays = value;
            }
        }

		public virtual string QuantityUomId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("QuantityUomId"))
                {
                    return _state.QuantityUomId;
                }
                return null;
            }
            set
            {
                _state.QuantityUomId = value;
            }
        }

        string ISupplierProductStateProperties.QuantityUomId
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).QuantityUomId;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).QuantityUomId = value;
            }
        }

		public virtual decimal? LastPrice
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("LastPrice"))
                {
                    return _state.LastPrice;
                }
                return null;
            }
            set
            {
                _state.LastPrice = value;
            }
        }

        decimal? ISupplierProductStateProperties.LastPrice
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).LastPrice;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).LastPrice = value;
            }
        }

		public virtual decimal? ShippingPrice
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ShippingPrice"))
                {
                    return _state.ShippingPrice;
                }
                return null;
            }
            set
            {
                _state.ShippingPrice = value;
            }
        }

        decimal? ISupplierProductStateProperties.ShippingPrice
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).ShippingPrice;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).ShippingPrice = value;
            }
        }

		public virtual string ExternalProductName
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ExternalProductName"))
                {
                    return _state.ExternalProductName;
                }
                return null;
            }
            set
            {
                _state.ExternalProductName = value;
            }
        }

        string ISupplierProductStateProperties.ExternalProductName
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).ExternalProductName;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).ExternalProductName = value;
            }
        }

		public virtual string ExternalProductId
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("ExternalProductId"))
                {
                    return _state.ExternalProductId;
                }
                return null;
            }
            set
            {
                _state.ExternalProductId = value;
            }
        }

        string ISupplierProductStateProperties.ExternalProductId
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).ExternalProductId;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).ExternalProductId = value;
            }
        }

		public virtual bool? CanDropShip
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CanDropShip"))
                {
                    return _state.CanDropShip;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    _state.CanDropShip = value.Value;
                }
            }
        }

        bool ISupplierProductStateProperties.CanDropShip
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).CanDropShip;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).CanDropShip = value;
            }
        }

		public virtual string Comments
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Comments"))
                {
                    return _state.Comments;
                }
                return null;
            }
            set
            {
                _state.Comments = value;
            }
        }

        string ISupplierProductStateProperties.Comments
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).Comments;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).Comments = value;
            }
        }

		public virtual bool? Active
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Active"))
                {
                    return (this._state as ISupplierProductStateProperties).Active;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as ISupplierProductStateProperties).Active = value.Value;
                }
            }
        }

        bool ISupplierProductStateProperties.Active
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).Active;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).Active = value;
            }
        }

		public virtual long? Version
        {
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("Version"))
                {
                    return (this._state as ISupplierProductStateProperties).Version;
                }
                return null;
            }
            set
            {
                if (value != null && value.HasValue)
                {
                    (this._state as ISupplierProductStateProperties).Version = value.Value;
                }
            }
        }

        long ISupplierProductStateProperties.Version
        {
            get 
            {
                return (this._state as ISupplierProductStateProperties).Version;
            }
            set 
            {
                (this._state as ISupplierProductStateProperties).Version = value;
            }
        }

		public virtual string CreatedBy
		{
            get
            {
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedBy"))
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
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("CreatedAt"))
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
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedBy"))
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
                if ((this as IStateDtoWrapper).ReturnedFieldsContains("UpdatedAt"))
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

		SupplierProductId IGlobalIdentity<SupplierProductId>.GlobalId
		{
			get { return (_state as ISupplierProductState).GlobalId; }
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
            return (_state as IActive).IsActive();
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
            get { return (_state as ISupplierProductState).CreatedBy; }
            set { (_state as ISupplierProductState).CreatedBy = value; }
		}

		DateTime ICreated<string>.CreatedAt
		{
            get { return (_state as ISupplierProductState).CreatedAt; }
            set { (_state as ISupplierProductState).CreatedAt = value; }
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
            get { return (_state as ISupplierProductState).UpdatedBy; }
            set { (_state as ISupplierProductState).UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
            get { return (_state as ISupplierProductState).UpdatedAt; }
            set { (_state as ISupplierProductState).UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
            get { return (_state as ISupplierProductStateProperties).Version; }
		}

		#endregion

        bool ISupplierProductState.IsUnsaved
        {
            get { return this.Version == SupplierProductState.VersionZero; }
        }

		void ISupplierProductState.When(ISupplierProductStateCreated e)
		{
            throw new NotSupportedException();
		}

		bool ISupplierProductState.ForReapplying
		{
            get { throw new NotSupportedException(); }
		}

        public bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }

		void ISupplierProductState.When(ISupplierProductStateMergePatched e)
		{
            throw new NotSupportedException();
		}

		void ISupplierProductState.Mutate(IEvent e)
		{
            throw new NotSupportedException();
		}

        // //////////////////////////////////////////////////////////////

	}

    partial class SupplierProductStateDtoWrapperCollection : StateDtoWrapperCollectionBase<SupplierProductStateDtoWrapper>
    {

        protected override bool IsCollectionField(string fieldName)
        {
            return CollectionUtils.CollectionContainsIgnoringCase(SupplierProductStateDtoWrapper._collectionFieldNames, fieldName);
        }

    }

}
