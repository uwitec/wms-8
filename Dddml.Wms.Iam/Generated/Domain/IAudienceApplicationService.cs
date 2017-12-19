﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Audience;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Audience
{

	public partial interface IAudienceApplicationService : IApplicationService
	{
		void When(ICreateAudience c);

		void When(IMergePatchAudience c);

		void When(IDeleteAudience c);

 		IAudienceState Get(string clientId);

        IEnumerable<IAudienceState> GetAll(int firstResult, int maxResults);

        IEnumerable<IAudienceState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAudienceState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IAudienceState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IAudienceStateEvent GetStateEvent(string clientId, long version);

        IAudienceState GetHistoryState(string clientId, long version);


	}

    public static partial class AudienceApplicationServiceExtension
    {
        public static IEnumerable<IAudienceState> GetByProperty(this IAudienceApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAudienceState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAudienceState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IAudienceState> GetByProperty<TPropertyType>(this IAudienceApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IAudienceState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IAudienceState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

