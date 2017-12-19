﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstance;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeSetInstance
{

	public partial interface IAttributeSetInstanceApplicationService : IApplicationService
	{
		string CreateWithoutId(ICreateAttributeSetInstance c);

		void When(ICreateAttributeSetInstance c);

 		IAttributeSetInstanceState Get(string attributeSetInstanceId);

        IEnumerable<IAttributeSetInstanceState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAttributeSetInstanceState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetInstanceState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetInstanceState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IAttributeSetInstanceStateEvent GetStateEvent(string attributeSetInstanceId, long version);

        IAttributeSetInstanceState GetHistoryState(string attributeSetInstanceId, long version);


	}

    public static partial class AttributeSetInstanceApplicationServiceExtension
    {
        public static IEnumerable<IAttributeSetInstanceState> GetByProperty(this IAttributeSetInstanceApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeSetInstanceState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeSetInstanceState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IAttributeSetInstanceState> GetByProperty<TPropertyType>(this IAttributeSetInstanceApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeSetInstanceState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeSetInstanceState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

