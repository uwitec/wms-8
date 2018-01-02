﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentReceiptMvoDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentReceiptMvo;
using Dddml.Wms.Domain.Shipment;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.ShipmentReceiptMvo
{

	public partial interface IShipmentReceiptMvoApplicationService : IApplicationService
	{
		void When(ICreateShipmentReceiptMvo c);

		void When(IMergePatchShipmentReceiptMvo c);

 		IShipmentReceiptMvoState Get(ShipmentReceiptId shipmentReceiptId);

        IEnumerable<IShipmentReceiptMvoState> GetAll(int firstResult, int maxResults);

        IEnumerable<IShipmentReceiptMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentReceiptMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentReceiptMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IShipmentReceiptMvoStateEvent GetStateEvent(ShipmentReceiptId shipmentReceiptId, long version);

        IShipmentReceiptMvoState GetHistoryState(ShipmentReceiptId shipmentReceiptId, long version);


	}

    public static partial class ShipmentReceiptMvoApplicationServiceExtension
    {
        public static IEnumerable<IShipmentReceiptMvoState> GetByProperty(this IShipmentReceiptMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IShipmentReceiptMvoState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IShipmentReceiptMvoState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IShipmentReceiptMvoState> GetByProperty<TPropertyType>(this IShipmentReceiptMvoApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IShipmentReceiptMvoState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IShipmentReceiptMvoState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

