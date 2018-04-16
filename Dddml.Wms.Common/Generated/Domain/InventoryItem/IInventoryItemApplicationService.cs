﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInventoryItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.InventoryItem
{

	public partial interface IInventoryItemApplicationService : IApplicationService
	{
		void When(ICreateInventoryItem c);

		void When(IMergePatchInventoryItem c);

 		IInventoryItemState Get(InventoryItemId inventoryItemId);

        IEnumerable<IInventoryItemState> GetAll(int firstResult, int maxResults);

        IEnumerable<IInventoryItemState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IInventoryItemState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IInventoryItemState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IInventoryItemEvent GetEvent(InventoryItemId inventoryItemId, long version);

        IInventoryItemState GetHistoryState(InventoryItemId inventoryItemId, long version);

        IInventoryItemEntryState GetInventoryItemEntry(InventoryItemId inventoryItemId, long entrySeqId);

        IEnumerable<IInventoryItemEntryState> GetInventoryItemEntries(InventoryItemId inventoryItemId);


	}

    public static partial class InventoryItemApplicationServiceExtension
    {
        public static IEnumerable<IInventoryItemState> GetByProperty(this IInventoryItemApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IInventoryItemState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IInventoryItemState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IInventoryItemState> GetByProperty<TPropertyType>(this IInventoryItemApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IInventoryItemState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IInventoryItemState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

