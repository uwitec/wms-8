﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLocatorDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Locator;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Locator
{

	public partial interface ILocatorApplicationService : IApplicationService
	{
		void When(ICreateLocator c);

		void When(IMergePatchLocator c);

		void When(IDeleteLocator c);

 		ILocatorState Get(string locatorId);

        IEnumerable<ILocatorState> GetAll(int firstResult, int maxResults);

        IEnumerable<ILocatorState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<ILocatorState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<ILocatorState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        ILocatorStateEvent GetStateEvent(string locatorId, long version);

        ILocatorState GetHistoryState(string locatorId, long version);


	}

    public static partial class LocatorApplicationServiceExtension
    {
        public static IEnumerable<ILocatorState> GetByProperty(this ILocatorApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<ILocatorState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<ILocatorState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<ILocatorState> GetByProperty<TPropertyType>(this ILocatorApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<ILocatorState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<ILocatorState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

