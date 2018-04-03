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

	public partial interface IOrderShipGroupMvoApplicationService : IApplicationService
	{
		void When(ICreateOrderShipGroupMvo c);

		void When(IMergePatchOrderShipGroupMvo c);

		void When(IDeleteOrderShipGroupMvo c);

 		IOrderShipGroupMvoState Get(OrderShipGroupId orderShipGroupId);

        IEnumerable<IOrderShipGroupMvoState> GetAll(int firstResult, int maxResults);

        IEnumerable<IOrderShipGroupMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrderShipGroupMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrderShipGroupMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IOrderShipGroupMvoStateEvent GetStateEvent(OrderShipGroupId orderShipGroupId, long version);

        IOrderShipGroupMvoState GetHistoryState(OrderShipGroupId orderShipGroupId, long version);


	}

    public static partial class OrderShipGroupMvoApplicationServiceExtension
    {
        public static IEnumerable<IOrderShipGroupMvoState> GetByProperty(this IOrderShipGroupMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IOrderShipGroupMvoState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IOrderShipGroupMvoState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IOrderShipGroupMvoState> GetByProperty<TPropertyType>(this IOrderShipGroupMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IOrderShipGroupMvoState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IOrderShipGroupMvoState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}
