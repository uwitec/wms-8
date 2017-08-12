﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Permission;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Permission
{
	public partial interface IPermissionStateQueryRepository
	{
        IPermissionState Get(string id);

        IEnumerable<IPermissionState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IPermissionState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IPermissionState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IPermissionState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IPermissionState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IPermissionState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}
