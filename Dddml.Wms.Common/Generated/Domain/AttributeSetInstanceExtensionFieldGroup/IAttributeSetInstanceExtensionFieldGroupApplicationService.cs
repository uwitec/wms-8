﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceExtensionFieldGroupDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.AttributeSetInstanceExtensionFieldGroup
{

	public partial interface IAttributeSetInstanceExtensionFieldGroupApplicationService : IApplicationService
	{
		void When(ICreateAttributeSetInstanceExtensionFieldGroup c);

		void When(IMergePatchAttributeSetInstanceExtensionFieldGroup c);

		void When(IDeleteAttributeSetInstanceExtensionFieldGroup c);

 		IAttributeSetInstanceExtensionFieldGroupState Get(string id);

        IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IAttributeSetInstanceExtensionFieldGroupEvent GetEvent(string id, long version);

        IAttributeSetInstanceExtensionFieldGroupState GetHistoryState(string id, long version);


	}

    public static partial class AttributeSetInstanceExtensionFieldGroupApplicationServiceExtension
    {
        public static IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetByProperty(this IAttributeSetInstanceExtensionFieldGroupApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeSetInstanceExtensionFieldGroupState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeSetInstanceExtensionFieldGroupState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> GetByProperty<TPropertyType>(this IAttributeSetInstanceExtensionFieldGroupApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAttributeSetInstanceExtensionFieldGroupState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAttributeSetInstanceExtensionFieldGroupState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

