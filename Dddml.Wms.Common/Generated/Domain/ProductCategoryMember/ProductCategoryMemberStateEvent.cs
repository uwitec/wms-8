﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductCategoryMemberDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategoryMember;

namespace Dddml.Wms.Domain.ProductCategoryMember
{

	public abstract class ProductCategoryMemberStateEventBase : IProductCategoryMemberStateEvent
	{

		public virtual ProductCategoryMemberEventId ProductCategoryMemberEventId { get; set; }

        public virtual ProductCategoryMemberId ProductCategoryMemberId
        {
            get { return ProductCategoryMemberEventId.ProductCategoryMemberId; }
            set { ProductCategoryMemberEventId.ProductCategoryMemberId = value; }
        }

		public virtual DateTime? ThruDate { get; set; }

		public virtual string Comments { get; set; }

		public virtual long? SequenceNum { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ProductCategoryMemberEventId IGlobalIdentity<ProductCategoryMemberEventId>.GlobalId {
			get
			{
				return this.ProductCategoryMemberEventId;
			}
		}

        public virtual bool StateEventReadOnly { get; set; }

        bool IProductCategoryMemberStateEvent.ReadOnly
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

        protected ProductCategoryMemberStateEventBase()
        {
        }

        protected ProductCategoryMemberStateEventBase(ProductCategoryMemberEventId stateEventId)
        {
            this.ProductCategoryMemberEventId = stateEventId;
        }


        string IStateEventDto.StateEventType
        {
            get { return this.GetStateEventType(); }
        }

        protected abstract string GetStateEventType();

	}

	public class ProductCategoryMemberStateCreated : ProductCategoryMemberStateEventBase, IProductCategoryMemberStateCreated
	{
		public ProductCategoryMemberStateCreated () : this(new ProductCategoryMemberEventId())
		{
		}

		public ProductCategoryMemberStateCreated (ProductCategoryMemberEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ProductCategoryMemberStateMergePatched : ProductCategoryMemberStateEventBase, IProductCategoryMemberStateMergePatched
	{
		public virtual bool IsPropertyThruDateRemoved { get; set; }

		public virtual bool IsPropertyCommentsRemoved { get; set; }

		public virtual bool IsPropertySequenceNumRemoved { get; set; }

		public virtual bool IsPropertyQuantityRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public ProductCategoryMemberStateMergePatched ()
		{
		}

		public ProductCategoryMemberStateMergePatched (ProductCategoryMemberEventId stateEventId) : base(stateEventId)
		{
		}


        protected override string GetStateEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}




}

