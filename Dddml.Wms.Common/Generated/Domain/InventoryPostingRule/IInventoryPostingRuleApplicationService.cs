﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryPostingRuleDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPostingRule;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.InventoryPostingRule
{

	public partial interface IInventoryPostingRuleApplicationService : IApplicationService
	{
		void When(ICreateInventoryPostingRule c);

		void When(IMergePatchInventoryPostingRule c);

		void When(IDeleteInventoryPostingRule c);

 		IInventoryPostingRuleState Get(string inventoryPostingRuleId);

        IEnumerable<IInventoryPostingRuleState> GetAll(int firstResult, int maxResults);

        IEnumerable<IInventoryPostingRuleState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IInventoryPostingRuleState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IInventoryPostingRuleState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IInventoryPostingRuleStateEvent GetStateEvent(string inventoryPostingRuleId, long version);

        IInventoryPostingRuleState GetHistoryState(string inventoryPostingRuleId, long version);


	}

    public static partial class InventoryPostingRuleApplicationServiceExtension
    {
        public static IEnumerable<IInventoryPostingRuleState> GetByProperty(this IInventoryPostingRuleApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IInventoryPostingRuleState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IInventoryPostingRuleState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IInventoryPostingRuleState> GetByProperty<TPropertyType>(this IInventoryPostingRuleApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IInventoryPostingRuleState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IInventoryPostingRuleState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

