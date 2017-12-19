﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderShipment;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderShipment
{

	public partial interface IOrderShipmentApplicationService : IApplicationService
	{
		void When(ICreateOrderShipment c);

		void When(IMergePatchOrderShipment c);

 		IOrderShipmentState Get(OrderShipmentId orderShipmentId);

        IEnumerable<IOrderShipmentState> GetAll(int firstResult, int maxResults);

        IEnumerable<IOrderShipmentState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrderShipmentState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrderShipmentState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IOrderShipmentStateEvent GetStateEvent(OrderShipmentId orderShipmentId, long version);

        IOrderShipmentState GetHistoryState(OrderShipmentId orderShipmentId, long version);


	}

    public static partial class OrderShipmentApplicationServiceExtension
    {
        public static IEnumerable<IOrderShipmentState> GetByProperty(this IOrderShipmentApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IOrderShipmentState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IOrderShipmentState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IOrderShipmentState> GetByProperty<TPropertyType>(this IOrderShipmentApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IOrderShipmentState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IOrderShipmentState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

