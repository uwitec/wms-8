﻿// <autogenerated>
//   This file was generated by T4 code generator GeneratePicklistItemMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistItemMvo;
using Dddml.Wms.Domain.PicklistBin;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.PicklistItemMvo
{
	public partial interface IPicklistItemMvoStateQueryRepository
	{
        IPicklistItemMvoState Get(PicklistBinPicklistItemId id);

        IEnumerable<IPicklistItemMvoState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IPicklistItemMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IPicklistItemMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IPicklistItemMvoState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IPicklistItemMvoState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IPicklistItemMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}
