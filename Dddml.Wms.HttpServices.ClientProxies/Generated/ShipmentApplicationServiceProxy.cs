﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;
using Dddml.Wms.Specialization.HttpServices.ClientProxies;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class ShipmentApplicationServiceProxy : IShipmentApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public ShipmentApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public ShipmentApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public ShipmentApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateShipmentDto c)
        {
            var idObj = (c as ICreateShipment).ShipmentId;
            var uriParameters = new ShipmentUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentPutRequest(uriParameters, (CreateShipmentDto)c);
                
            var resp = await _ramlClient.Shipment.Put(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateShipmentDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchShipmentDto c)
        {
            var idObj = (c as IMergePatchShipment).ShipmentId;
            var uriParameters = new ShipmentUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentPatchRequest(uriParameters, (MergePatchShipmentDto)c);
            var resp = await _ramlClient.Shipment.Patch(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchShipmentDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteShipmentDto c)
        {
            var idObj = (c as IDeleteShipment).ShipmentId;
            var uriParameters = new ShipmentUriParameters();
            uriParameters.Id = idObj;

            var q = new ShipmentDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new ShipmentDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Shipment.Delete(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteShipmentDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IShipmentApplicationService.When(ICreateShipment c)
        {
            this.When((CreateShipmentDto)c);
        }

        void IShipmentApplicationService.When(IMergePatchShipment c)
        {
            this.When((MergePatchShipmentDto)c);
        }

        public void When(ShipmentCommands.Import c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(ShipmentCommands.Ship c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(ShipmentCommands.ReceiveItem c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(ShipmentCommands.AddItemAndReceipt c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(ShipmentCommands.IssueItem c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(ShipmentCommands.AddItemAndIssuance c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(ShipmentCommands.ConfirmAllItemsReceived c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(ShipmentCommands.ConfirmAllItemsIssued c)
        {
            throw new NotImplementedException();//todo
        }

        public async Task<IShipmentState> GetAsync(string shipmentId)
        {
            IShipmentState state = null;
            var idObj = shipmentId;
            var uriParameters = new ShipmentUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentGetRequest(uriParameters);

            var resp = await _ramlClient.Shipment.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToShipmentState();
            return state;
        }

        public IShipmentState Get(string shipmentId)
        {
            return GetAsync(shipmentId).GetAwaiter().GetResult();
        }


        public IEnumerable<IShipmentState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IShipmentState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IShipmentState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IShipmentState> states = null;
			var q = new ShipmentsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ShipmentProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ShipmentProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = ShipmentProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ShipmentsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Shipments.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToShipmentState());
            return states;
        }

        public IEnumerable<IShipmentState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IShipmentState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IShipmentState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IShipmentState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IShipmentState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IShipmentState> states = null;
			var q = new ShipmentsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ShipmentProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ShipmentProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = ShipmentProxyUtils.GetFilterQueryValueString(filter);
            var req = new ShipmentsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Shipments.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToShipmentState());
            return states;
        }

        public IEnumerable<IShipmentState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new ShipmentsCountGetQuery();
            q.FilterTag = ShipmentProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ShipmentsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentsCount.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async virtual Task<long> GetCountAsync(ICriterion filter)
		{
			var q = new ShipmentsCountGetQuery();
            q.Filter = ShipmentProxyUtils.GetFilterQueryValueString(filter);
            var req = new ShipmentsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentsCount.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IShipmentEvent> GetStateEventAsync(string shipmentId, long version)
        {
            var idObj = shipmentId;
            var uriParameters = new ShipmentStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ShipmentStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentStateEvent.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IShipmentEvent GetEvent(string shipmentId, long version)
        {
            return GetStateEventAsync(shipmentId, version).GetAwaiter().GetResult();
        }


        public async Task<IShipmentState> GetHistoryStateAsync(string shipmentId, long version)
        {
            var idObj = shipmentId;
            var uriParameters = new ShipmentHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ShipmentHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentHistoryState.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentState();
        }

        public virtual IShipmentState GetHistoryState(string shipmentId, long version)
        {
            return GetHistoryStateAsync(shipmentId, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IShipmentImageState> GetShipmentImageAsync(string shipmentId, string sequenceId)
        {
            var uriParameters = new ShipmentImageUriParameters();
            uriParameters.ShipmentId = shipmentId;
            uriParameters.SequenceId = sequenceId;

            var req = new ShipmentImageGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentImage.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentImageState();
        }

        public virtual IShipmentImageState GetShipmentImage(string shipmentId, string sequenceId)
        {
            return GetShipmentImageAsync(shipmentId, sequenceId).GetAwaiter().GetResult();
        }

        public IEnumerable<IShipmentImageState> GetShipmentImages(string shipmentId)
        {
            throw new NotImplementedException();//todo
        }

        public async virtual Task<IShipmentItemState> GetShipmentItemAsync(string shipmentId, string shipmentItemSeqId)
        {
            var uriParameters = new ShipmentItemUriParameters();
            uriParameters.ShipmentId = shipmentId;
            uriParameters.ShipmentItemSeqId = shipmentItemSeqId;

            var req = new ShipmentItemGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentItem.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentItemState();
        }

        public virtual IShipmentItemState GetShipmentItem(string shipmentId, string shipmentItemSeqId)
        {
            return GetShipmentItemAsync(shipmentId, shipmentItemSeqId).GetAwaiter().GetResult();
        }

        public IEnumerable<IShipmentItemState> GetShipmentItems(string shipmentId)
        {
            throw new NotImplementedException();//todo
        }

        public async virtual Task<IShipmentReceiptState> GetShipmentReceiptAsync(string shipmentId, string receiptSeqId)
        {
            var uriParameters = new ShipmentReceiptUriParameters();
            uriParameters.ShipmentId = shipmentId;
            uriParameters.ReceiptSeqId = receiptSeqId;

            var req = new ShipmentReceiptGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentReceipt.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentReceiptState();
        }

        public virtual IShipmentReceiptState GetShipmentReceipt(string shipmentId, string receiptSeqId)
        {
            return GetShipmentReceiptAsync(shipmentId, receiptSeqId).GetAwaiter().GetResult();
        }

        public IEnumerable<IShipmentReceiptState> GetShipmentReceipts(string shipmentId)
        {
            throw new NotImplementedException();//todo
        }

        public async virtual Task<IShipmentReceiptImageState> GetShipmentReceiptImageAsync(string shipmentId, string shipmentReceiptReceiptSeqId, string sequenceId)
        {
            var uriParameters = new ShipmentReceiptImageUriParameters();
            uriParameters.ShipmentId = shipmentId;
            uriParameters.ShipmentReceiptReceiptSeqId = shipmentReceiptReceiptSeqId;
            uriParameters.SequenceId = sequenceId;

            var req = new ShipmentReceiptImageGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentReceiptImage.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentReceiptImageState();
        }

        public virtual IShipmentReceiptImageState GetShipmentReceiptImage(string shipmentId, string shipmentReceiptReceiptSeqId, string sequenceId)
        {
            return GetShipmentReceiptImageAsync(shipmentId, shipmentReceiptReceiptSeqId, sequenceId).GetAwaiter().GetResult();
        }

        public IEnumerable<IShipmentReceiptImageState> GetShipmentReceiptImages(string shipmentId, string shipmentReceiptReceiptSeqId)
        {
            throw new NotImplementedException();//todo
        }

        public async virtual Task<IItemIssuanceState> GetItemIssuanceAsync(string shipmentId, string itemIssuanceSeqId)
        {
            var uriParameters = new ItemIssuanceUriParameters();
            uriParameters.ShipmentId = shipmentId;
            uriParameters.ItemIssuanceSeqId = itemIssuanceSeqId;

            var req = new ItemIssuanceGetRequest(uriParameters);
            var resp = await _ramlClient.ItemIssuance.Get(req);
            ShipmentProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToItemIssuanceState();
        }

        public virtual IItemIssuanceState GetItemIssuance(string shipmentId, string itemIssuanceSeqId)
        {
            return GetItemIssuanceAsync(shipmentId, itemIssuanceSeqId).GetAwaiter().GetResult();
        }

        public IEnumerable<IItemIssuanceState> GetItemIssuances(string shipmentId)
        {
            throw new NotImplementedException();//todo
        }


        protected virtual string QueryFieldValueSeparator
        {
            get { return ","; }
        }

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

    }


    public partial class ShipmentApplicationServiceProxyFactory : ProxyFactoryBase, IShipmentApplicationServiceFactory
    {

        public ShipmentApplicationServiceProxyFactory() : base()
        {}

        public ShipmentApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IShipmentApplicationService ShipmentApplicationService
        {
            get
            {
                return new ShipmentApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateShipment NewCreateShipment()
        {
            return new CreateShipmentDto();
        }

        public IMergePatchShipment NewMergePatchShipment()
        {
            return new MergePatchShipmentDto();
        }

        public IDeleteShipment NewDeleteShipment()
        {
            return new DeleteShipmentDto();
        }
    }

    public static class ShipmentProxyUtils
    {

        private class ProxyTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                throw new NotSupportedException();
            }

            public object ConvertFromString(Type type, string text)
            {
                throw new NotSupportedException();
            }

            public string ConvertToString<T>(T value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(typeof(T), value);
            }

            public string ConvertToString(object value)
            {
                return ApplicationContext.Current.TypeConverter.ConvertToString(value.GetType(), value);
            }

            public string[] ConvertToStringArray(object[] values)
            {
                var list = new List<string>();
                foreach (var o in values)
                {
                    list.Add(ConvertToString(o));
                }
                return list.ToArray();
            }
        }


        public static string GetFilterQueryValueString(ICriterion filter)
        {
            if (filter == null) { return null; }
            return WebUtility.UrlEncode(JObject.FromObject(new CriterionDto(filter, new ProxyTypeConverter())).ToString());
        }

        public static string GetFilterTagQueryValueString(IEnumerable<KeyValuePair<string, object>> filter)
        {
            if (filter == null) { return null; }
            StringBuilder sb = new StringBuilder();
            sb.Append(DateTime.Now.Ticks);
            foreach (var p in filter)
            {
                var k = p.Key;
                var v = p.Value;
                sb.Append("&");
                sb.Append(k);
                sb.Append("=");
                if (v != null)
                {
                    string valStr = ApplicationContext.Current.TypeConverter.ConvertToString(v.GetType(), v);
                    sb.Append(WebUtility.UrlEncode(valStr));
                }

            }
            return sb.ToString();
        }

        public static string GetReturnedFieldsQueryValueString(IList<string> fields, string separator)
        {
            if (fields == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var f in fields)
            {
                sb.Append(WebUtility.UrlEncode(f));
                sb.Append(separator);
            }
            return sb.ToString();
        }

        public static string GetOrdersQueryValueString(IList<string> orders)
        {
            if (orders == null) { return null; }
            StringBuilder sb = new StringBuilder();
            foreach (var ord in orders)
            {
                sb.Append(WebUtility.UrlEncode(ord));
                sb.Append(",");
            }
            return sb.ToString();
        }

        public static void ThrowOnHttpResponseError(ApiResponse resp)
        {
            var httpResponseMessage = new HttpResponseMessage()
            {
                StatusCode = resp.StatusCode,
                Content = resp.RawContent,
                ReasonPhrase = resp.ReasonPhrase
            };
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                return;
            }
            try
            {
                if (resp.StatusCode == HttpStatusCode.InternalServerError)
                {
                    IEnumerable<string> headerValues = new List<string>();
                    if (resp.RawContent != null && resp.RawContent.Headers != null)
                        resp.RawContent.Headers.TryGetValues("Content-Type", out headerValues);
                    if (headerValues.Any(hv => hv.ToLowerInvariant().Contains("json")))
                    {
                        JObject jObj = JObject.Parse(httpResponseMessage.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                        var errorName = jObj.GetValue("ErrorName").ToObject<string>();
                        var errorMessage = jObj.GetValue("ErrorMessage").ToObject<string>();
                        throw DomainError.Named(errorName, errorMessage);
                    }
                }
                throw new HttpResponseException(httpResponseMessage);
            }
            catch
            {
                throw new HttpResponseException(httpResponseMessage);
            }
        }

        public static IEnumerable<string> ToIdCollection(IEnumerable<IShipmentState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.ShipmentId);
            }
            return ids;
        }

    }

}

