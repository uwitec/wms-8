﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;

namespace Dddml.Wms.Domain.ProductCategory
{

	public abstract class ProductCategoryStateEventDtoBase : IStateEventDto, IProductCategoryStateCreated, IProductCategoryStateMergePatched, IProductCategoryStateDeleted
	{

        private ProductCategoryEventId _productCategoryEventId;

		protected internal virtual ProductCategoryEventId ProductCategoryEventId 
        {
            get 
            {
                if (_productCategoryEventId == null) { _productCategoryEventId = new ProductCategoryEventId(); }
                return _productCategoryEventId;
            }
            set
            {
                _productCategoryEventId = value;
            }
        }

        public virtual string ProductCategoryId
        {
            get { return ProductCategoryEventId.ProductCategoryId; }
            set { ProductCategoryEventId.ProductCategoryId = value; }
        }

        public virtual long Version
        {
            get { return ProductCategoryEventId.Version; }
            set { ProductCategoryEventId.Version = value; }
        }

		public virtual string ProductCategoryTypeId { get; set; }

		public virtual string PrimaryParentCategoryId { get; set; }

		public virtual string CategoryName { get; set; }

		public virtual string Description { get; set; }

		public virtual string CategoryImageUrl { get; set; }

		public virtual string DetailScreen { get; set; }

		public virtual bool? ShowInSelect { get; set; }

		public virtual string AttributeSetId { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ProductCategoryEventId IGlobalIdentity<ProductCategoryEventId>.GlobalId {
			get 
			{
				return this.ProductCategoryEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IProductCategoryStateEvent.ReadOnly
        {
            get
            {
                return this.StateEventReadOnly;
            }
            set
            {
                this.StateEventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyProductCategoryTypeIdRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyProductCategoryTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyProductCategoryTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyProductCategoryTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPrimaryParentCategoryIdRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyPrimaryParentCategoryIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPrimaryParentCategoryIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPrimaryParentCategoryIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyCategoryNameRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyCategoryNameRemoved
        {
            get 
            {
                var b = this.IsPropertyCategoryNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCategoryNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyDescriptionRemoved
        {
            get 
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyCategoryImageUrlRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyCategoryImageUrlRemoved
        {
            get 
            {
                var b = this.IsPropertyCategoryImageUrlRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCategoryImageUrlRemoved = value;
            }
        }

		public virtual bool? IsPropertyDetailScreenRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyDetailScreenRemoved
        {
            get 
            {
                var b = this.IsPropertyDetailScreenRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDetailScreenRemoved = value;
            }
        }

		public virtual bool? IsPropertyShowInSelectRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyShowInSelectRemoved
        {
            get 
            {
                var b = this.IsPropertyShowInSelectRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyShowInSelectRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetIdRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyAttributeSetIdRemoved
        {
            get 
            {
                var b = this.IsPropertyAttributeSetIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttributeSetIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IProductCategoryStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        ProductCategoryEventId IProductCategoryStateEvent.ProductCategoryEventId
        {
            get { return this.ProductCategoryEventId; }
        }

        protected ProductCategoryStateEventDtoBase()
        {
        }

        protected ProductCategoryStateEventDtoBase(ProductCategoryEventId stateEventId)
        {
            this.ProductCategoryEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IStateEventDto.StateEventType 
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}


    public class ProductCategoryStateCreatedOrMergePatchedOrDeletedDto : ProductCategoryStateEventDtoBase
    {
        private string _stateEventType;

        public virtual string StateEventType
        {
            get { return _stateEventType; }
            set { _stateEventType = value; }
        }

        protected override string GetStateEventType()
        {
            return this._stateEventType;
        }

    }



	public class ProductCategoryStateCreatedDto : ProductCategoryStateCreatedOrMergePatchedOrDeletedDto
	{
		public ProductCategoryStateCreatedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ProductCategoryStateMergePatchedDto : ProductCategoryStateCreatedOrMergePatchedOrDeletedDto
	{
		public ProductCategoryStateMergePatchedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ProductCategoryStateDeletedDto : ProductCategoryStateCreatedOrMergePatchedOrDeletedDto
	{
		public ProductCategoryStateDeletedDto()
		{
		}

        public override string StateEventType
        {
            get { return this.GetStateEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class ProductCategoryStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IProductCategoryStateCreated>, IEnumerable<IProductCategoryStateMergePatched>, IEnumerable<IProductCategoryStateDeleted>
    {
        private List<ProductCategoryStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<ProductCategoryStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual ProductCategoryStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<ProductCategoryStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IProductCategoryStateCreated> IEnumerable<IProductCategoryStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IProductCategoryStateMergePatched> IEnumerable<IProductCategoryStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IProductCategoryStateDeleted> IEnumerable<IProductCategoryStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddProductCategoryEvent(IProductCategoryStateCreated e)
        {
            _innerStateEvents.Add((ProductCategoryStateCreatedDto)e);
        }

        public void AddProductCategoryEvent(IProductCategoryStateEvent e)
        {
            _innerStateEvents.Add((ProductCategoryStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddProductCategoryEvent(IProductCategoryStateDeleted e)
        {
            _innerStateEvents.Add((ProductCategoryStateDeletedDto)e);
        }

    }


}

