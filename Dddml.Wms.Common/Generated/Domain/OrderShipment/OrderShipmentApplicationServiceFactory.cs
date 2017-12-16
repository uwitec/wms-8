﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipment;

namespace Dddml.Wms.Domain.OrderShipment
{

    public partial class OrderShipmentApplicationServiceFactory : IOrderShipmentApplicationServiceFactory
    {

        public virtual IOrderShipmentApplicationService OrderShipmentApplicationService 
        {
		    get
		    {
			    return ApplicationContext.Current["OrderShipmentApplicationService"] as IOrderShipmentApplicationService;
		    }
        }

        public virtual ICreateOrderShipment NewCreateOrderShipment()
        {
		    return new CreateOrderShipment();
        }

        public virtual IMergePatchOrderShipment NewMergePatchOrderShipment()
        {
            return new MergePatchOrderShipment();
        }

        public virtual IDeleteOrderShipment NewDeleteOrderShipment()
        {
            return new DeleteOrderShipment();
        }

    }


}

