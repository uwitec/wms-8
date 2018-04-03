﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Attribute;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Attribute
{

	public partial interface IAttributeApplicationService : IApplicationService
	{
		void When(ICreateAttribute c);

		void When(IMergePatchAttribute c);

		void When(IDeleteAttribute c);

 		IAttributeState Get(string attributeId);

        IEnumerable<IAttributeState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAttributeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IAttributeStateEvent GetStateEvent(string attributeId, long version);

        IAttributeState GetHistoryState(string attributeId, long version);

        IAttributeValueState GetAttributeValue(string attributeId, string value);

        IEnumerable<IAttributeValueState> GetAttributeValues(string attributeId);

        IAttributeAliasState GetAttributeAlias(string attributeId, string code);

        IEnumerable<IAttributeAliasState> GetAttributeAlias(string attributeId);


	}

    public static partial class AttributeApplicationServiceExtension
    {
        public static IEnumerable<IAttributeState> GetByProperty(this IAttributeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IAttributeState> GetByProperty<TPropertyType>(this IAttributeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

