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

	public partial interface IUserLoginMvoApplicationService : IApplicationService
	{
		void When(ICreateUserLoginMvo c);

		void When(IMergePatchUserLoginMvo c);

		void When(IDeleteUserLoginMvo c);

 		IUserLoginMvoState Get(UserLoginId userLoginId);

        IEnumerable<IUserLoginMvoState> GetAll(int firstResult, int maxResults);

        IEnumerable<IUserLoginMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IUserLoginMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IUserLoginMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IUserLoginMvoStateEvent GetStateEvent(UserLoginId userLoginId, long version);

        IUserLoginMvoState GetHistoryState(UserLoginId userLoginId, long version);


	}

}

