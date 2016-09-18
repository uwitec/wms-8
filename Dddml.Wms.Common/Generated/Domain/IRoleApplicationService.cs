﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain
{

	public partial interface IRoleApplicationService : IApplicationService
	{
		void When(ICreateRole c);

		void When(IMergePatchRole c);

		void When(IDeleteRole c);

 		IRoleState Get(string roleId);

        IEnumerable<IRoleState> GetAll(int firstResult, int maxResults);

        IEnumerable<IRoleState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IRoleState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IRoleState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IRoleStateEvent GetStateEvent(string roleId, long version);

        IRoleState GetHistoryState(string roleId, long version);


	}

}

