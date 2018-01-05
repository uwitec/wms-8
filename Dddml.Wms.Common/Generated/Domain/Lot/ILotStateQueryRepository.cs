﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateLotDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Lot;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Lot
{
	public partial interface ILotStateQueryRepository
	{
        ILotState Get(string id);

        IEnumerable<ILotState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<ILotState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<ILotState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        ILotState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        ILotState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<ILotState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}
