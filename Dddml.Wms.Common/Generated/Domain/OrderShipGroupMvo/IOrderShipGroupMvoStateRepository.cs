﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipGroupMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipGroupMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderShipGroupMvo
{
	public partial interface IOrderShipGroupMvoStateRepository
	{

        IOrderShipGroupMvoState Get(OrderShipGroupId id, bool nullAllowed);
        
        void Save(IOrderShipGroupMvoState state);
        
	}

}

