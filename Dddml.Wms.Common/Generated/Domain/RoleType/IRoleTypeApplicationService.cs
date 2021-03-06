﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRoleTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.RoleType;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.RoleType
{

	public partial interface IRoleTypeApplicationService : IApplicationService
	{
		void When(ICreateRoleType c);

		void When(IMergePatchRoleType c);

		void When(IDeleteRoleType c);

 		IRoleTypeState Get(string roleTypeId);

        IEnumerable<IRoleTypeState> GetAll(int firstResult, int maxResults);

        IEnumerable<IRoleTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IRoleTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IRoleTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IRoleTypeEvent GetEvent(string roleTypeId, long version);

        IRoleTypeState GetHistoryState(string roleTypeId, long version);


	}

    public static partial class RoleTypeApplicationServiceExtension
    {
        public static IEnumerable<IRoleTypeState> GetByProperty(this IRoleTypeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IRoleTypeState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IRoleTypeState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IRoleTypeState> GetByProperty<TPropertyType>(this IRoleTypeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IRoleTypeState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IRoleTypeState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

