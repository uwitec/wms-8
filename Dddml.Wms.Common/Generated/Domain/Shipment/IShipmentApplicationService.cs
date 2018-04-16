﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;
using Dddml.Support.Criterion;

namespace Dddml.Wms.Domain.Shipment
{

	public partial interface IShipmentApplicationService : IApplicationService
	{
		void When(ICreateShipment c);

		void When(IMergePatchShipment c);

		void When(ShipmentCommands.Import c);

		void When(ShipmentCommands.Ship c);

		void When(ShipmentCommands.ReceiveItem c);

		void When(ShipmentCommands.ConfirmAllItemsReceived c);

 		IShipmentState Get(string shipmentId);

        IEnumerable<IShipmentState> GetAll(int firstResult, int maxResults);

        IEnumerable<IShipmentState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        IEnumerable<IShipmentState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue);

        long GetCount(IEnumerable<KeyValuePair<string, object>> filter);

        long GetCount(ICriterion filter);

        IShipmentEvent GetEvent(string shipmentId, long version);

        IShipmentState GetHistoryState(string shipmentId, long version);

        IShipmentItemState GetShipmentItem(string shipmentId, string shipmentItemSeqId);

        IEnumerable<IShipmentItemState> GetShipmentItems(string shipmentId);

        IShipmentReceiptState GetShipmentReceipt(string shipmentId, string receiptSeqId);

        IEnumerable<IShipmentReceiptState> GetShipmentReceipts(string shipmentId);

        IItemIssuanceState GetItemIssuance(string shipmentId, string itemIssuanceSeqId);

        IEnumerable<IItemIssuanceState> GetItemIssuances(string shipmentId);


	}

    public static partial class ShipmentApplicationServiceExtension
    {
        public static IEnumerable<IShipmentState> GetByProperty(this IShipmentApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IShipmentState, object>> propertySelector, 
            object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IShipmentState>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }

        public static IEnumerable<IShipmentState> GetByProperty<TPropertyType>(this IShipmentApplicationService applicationService,
            System.Linq.Expressions.Expression<Func<IShipmentState, TPropertyType>> propertySelector,
            TPropertyType propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return applicationService.GetByProperty(ReflectUtils.GetPropertyName<IShipmentState, TPropertyType>(propertySelector), propertyValue, orders, firstResult, maxResults);
        }
    }

}

