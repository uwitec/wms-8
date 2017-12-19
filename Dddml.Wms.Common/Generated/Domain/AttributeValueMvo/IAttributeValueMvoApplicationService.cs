﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeValueMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeValueMvo;
using Dddml.Wms.Domain.Attribute;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeValueMvo
{

	public partial interface IAttributeValueMvoApplicationService : IApplicationService
	{
		void When(ICreateAttributeValueMvo c);

		void When(IMergePatchAttributeValueMvo c);

		void When(IDeleteAttributeValueMvo c);

 		IAttributeValueMvoState Get(AttributeValueId attributeValueId);

        IEnumerable<IAttributeValueMvoState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAttributeValueMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeValueMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeValueMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IAttributeValueMvoStateEvent GetStateEvent(AttributeValueId attributeValueId, long version);

        IAttributeValueMvoState GetHistoryState(AttributeValueId attributeValueId, long version);


	}

    public static partial class AttributeValueMvoApplicationServiceExtension
    {
        public static IEnumerable<IAttributeValueMvoState> GetByProperty(this IAttributeValueMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeValueMvoState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeValueMvoState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IAttributeValueMvoState> GetByProperty<TPropertyType>(this IAttributeValueMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeValueMvoState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeValueMvoState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

