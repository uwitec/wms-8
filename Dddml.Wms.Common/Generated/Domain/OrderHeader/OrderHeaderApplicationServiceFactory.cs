﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderHeaderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderHeader;

namespace Dddml.Wms.Domain.OrderHeader
{

    public partial class OrderHeaderApplicationServiceFactory : IOrderHeaderApplicationServiceFactory
    {

        public virtual IOrderHeaderApplicationService OrderHeaderApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["OrderHeaderApplicationService"] as IOrderHeaderApplicationService;
		    }
        }

        public virtual ICreateOrderHeader NewCreateOrderHeader()
        {
		    return new CreateOrderHeader();
        }

        public virtual IMergePatchOrderHeader NewMergePatchOrderHeader()
        {
            return new MergePatchOrderHeader();
        }

        public virtual IDeleteOrderHeader NewDeleteOrderHeader()
        {
            return new DeleteOrderHeader();
        }

    }


}
