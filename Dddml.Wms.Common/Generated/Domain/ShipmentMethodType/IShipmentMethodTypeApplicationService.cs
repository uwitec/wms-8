﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentMethodTypeDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentMethodType;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.ShipmentMethodType
{

	public partial interface IShipmentMethodTypeApplicationService : IApplicationService
	{
		void When(ICreateShipmentMethodType c);

		void When(IMergePatchShipmentMethodType c);

		void When(IDeleteShipmentMethodType c);

 		IShipmentMethodTypeState Get(string shipmentMethodTypeId);

        IEnumerable<IShipmentMethodTypeState> GetAll(int firstResult, int maxResults);

        IEnumerable<IShipmentMethodTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentMethodTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentMethodTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IShipmentMethodTypeStateEvent GetStateEvent(string shipmentMethodTypeId, long version);

        IShipmentMethodTypeState GetHistoryState(string shipmentMethodTypeId, long version);


	}

    public static partial class ShipmentMethodTypeApplicationServiceExtension
    {
        public static IEnumerable<IShipmentMethodTypeState> GetByProperty(this IShipmentMethodTypeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IShipmentMethodTypeState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IShipmentMethodTypeState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IShipmentMethodTypeState> GetByProperty<TPropertyType>(this IShipmentMethodTypeApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IShipmentMethodTypeState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IShipmentMethodTypeState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

