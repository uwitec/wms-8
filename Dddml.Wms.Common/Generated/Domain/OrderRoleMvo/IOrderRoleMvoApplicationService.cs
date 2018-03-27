﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderRoleMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderRoleMvo;
using Dddml.Wms.Domain.Order;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.OrderRoleMvo
{

	public partial interface IOrderRoleMvoApplicationService : IApplicationService
	{
		void When(ICreateOrderRoleMvo c);

		void When(IMergePatchOrderRoleMvo c);

		void When(IDeleteOrderRoleMvo c);

 		IOrderRoleMvoState Get(OrderRoleId orderRoleId);

        IEnumerable<IOrderRoleMvoState> GetAll(int firstResult, int maxResults);

        IEnumerable<IOrderRoleMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrderRoleMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IOrderRoleMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IOrderRoleMvoStateEvent GetStateEvent(OrderRoleId orderRoleId, long version);

        IOrderRoleMvoState GetHistoryState(OrderRoleId orderRoleId, long version);


	}

    public static partial class OrderRoleMvoApplicationServiceExtension
    {
        public static IEnumerable<IOrderRoleMvoState> GetByProperty(this IOrderRoleMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IOrderRoleMvoState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IOrderRoleMvoState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IOrderRoleMvoState> GetByProperty<TPropertyType>(this IOrderRoleMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IOrderRoleMvoState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IOrderRoleMvoState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

