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
	public partial interface IPersonStateRepository
	{
        IPersonState Get(PersonalName id);

        IEnumerable<IPersonState> GetAll(int firstResult, int maxResults);
        
        void Save(IPersonState state);
        
        IEnumerable<IPersonState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IPersonState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IPersonState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IPersonState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IPersonState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IYearPlanState GetYearPlan(PersonalName personalName, int year);

        IMonthPlanState GetMonthPlan(PersonalName personalName, int year, int month);

        IDayPlanState GetDayPlan(PersonalName personalName, int year, int month, int day);

	}

}
