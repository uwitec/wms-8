﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItem;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.ShipmentItem
{
	public partial interface IShipmentItemStateQueryRepository
	{
        IShipmentItemState Get(ShipmentItemId id);

        IEnumerable<IShipmentItemState> GetAll(int firstResult, int maxResults);
        
        IEnumerable<IShipmentItemState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentItemState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IShipmentItemState GetFirst(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null);

        IShipmentItemState GetFirst(KeyValuePair<string, object> keyValue, IList<string> orders = null);

        IEnumerable<IShipmentItemState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

	}

}
