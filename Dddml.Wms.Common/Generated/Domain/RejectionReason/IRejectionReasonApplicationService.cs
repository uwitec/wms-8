﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRejectionReasonDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RejectionReason;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.RejectionReason
{

	public partial interface IRejectionReasonApplicationService : IApplicationService
	{
		void When(ICreateRejectionReason c);

		void When(IMergePatchRejectionReason c);

		void When(IDeleteRejectionReason c);

 		IRejectionReasonState Get(string rejectionReasonId);

        IEnumerable<IRejectionReasonState> GetAll(int firstResult, int maxResults);

        IEnumerable<IRejectionReasonState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IRejectionReasonState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IRejectionReasonState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IRejectionReasonEvent GetEvent(string rejectionReasonId, long version);

        IRejectionReasonState GetHistoryState(string rejectionReasonId, long version);


	}

    public static partial class RejectionReasonApplicationServiceExtension
    {
        public static IEnumerable<IRejectionReasonState> GetByProperty(this IRejectionReasonApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IRejectionReasonState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IRejectionReasonState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IRejectionReasonState> GetByProperty<TPropertyType>(this IRejectionReasonApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IRejectionReasonState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IRejectionReasonState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

