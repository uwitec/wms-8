﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateProductDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Product;

namespace Dddml.Wms.Domain.Product
{

	public class ProductStateEventIdDto
	{

		public ProductStateEventIdDto()
		{
		}

        public virtual ProductStateEventId ToProductStateEventId()
        {
            ProductStateEventId v = new ProductStateEventId();
            v.ProductId = this.ProductId;
            v.Version = this.Version;
            return v;
        }

		public virtual string ProductId { 
			get;
			set;
		}

		public virtual long Version { 
			get;
			set;
		}


		public override bool Equals (object obj)
		{
			if (Object.ReferenceEquals (this, obj)) {
				return true;
			}

			ProductStateEventIdDto other = obj as ProductStateEventIdDto;
			if (other == null) {
				return false;
			}

			return true 
				&& Object.Equals (this.ProductId, other.ProductId)
				&& Object.Equals (this.Version, other.Version)
				;
		}

		public override int GetHashCode ()
		{
			int hash = 0;
			if (this.ProductId != null) {
				hash += 13 * this.ProductId.GetHashCode ();
			}
			if (this.Version != null) {
				hash += 13 * this.Version.GetHashCode ();
			}
			return hash;
		}

	}

}

