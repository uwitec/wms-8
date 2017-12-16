﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItem;

namespace Dddml.Wms.Domain.OrderItem
{

    public partial class OrderItemApplicationServiceFactory : IOrderItemApplicationServiceFactory
    {

        public virtual IOrderItemApplicationService OrderItemApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["OrderItemApplicationService"] as IOrderItemApplicationService;
		    }
        }

        public virtual ICreateOrderItem NewCreateOrderItem()
        {
		    return new CreateOrderItem();
        }

        public virtual IMergePatchOrderItem NewMergePatchOrderItem()
        {
            return new MergePatchOrderItem();
        }

        public virtual IDeleteOrderItem NewDeleteOrderItem()
        {
            return new DeleteOrderItem();
        }

    }


}
