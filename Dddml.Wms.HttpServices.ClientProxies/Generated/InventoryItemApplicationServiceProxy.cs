﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItem;
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

    public partial class InventoryItemApplicationServiceProxy : IInventoryItemApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public InventoryItemApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public InventoryItemApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public InventoryItemApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateInventoryItemDto c)
        {
            var idObj = InventoryItemProxyUtils.ToIdString((c as ICreateInventoryItem).InventoryItemId);
            var uriParameters = new InventoryItemUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemPutRequest(uriParameters, (CreateInventoryItemDto)c);
                
            var resp = await _ramlClient.InventoryItem.Put(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateInventoryItemDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchInventoryItemDto c)
        {
            var idObj = InventoryItemProxyUtils.ToIdString((c as IMergePatchInventoryItem).InventoryItemId);
            var uriParameters = new InventoryItemUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemPatchRequest(uriParameters, (MergePatchInventoryItemDto)c);
            var resp = await _ramlClient.InventoryItem.Patch(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchInventoryItemDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteInventoryItemDto c)
        {
            var idObj = InventoryItemProxyUtils.ToIdString((c as IDeleteInventoryItem).InventoryItemId);
            var uriParameters = new InventoryItemUriParameters();
            uriParameters.Id = idObj;

            var q = new InventoryItemDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new InventoryItemDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.InventoryItem.Delete(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteInventoryItemDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IInventoryItemApplicationService.When(ICreateInventoryItem c)
        {
            this.When((CreateInventoryItemDto)c);
        }

        void IInventoryItemApplicationService.When(IMergePatchInventoryItem c)
        {
            this.When((MergePatchInventoryItemDto)c);
        }

        public async Task<IInventoryItemState> GetAsync(InventoryItemId inventoryItemId)
        {
            IInventoryItemState state = null;
            var idObj = InventoryItemProxyUtils.ToIdString(inventoryItemId);
            var uriParameters = new InventoryItemUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemGetRequest(uriParameters);

            var resp = await _ramlClient.InventoryItem.Get(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToInventoryItemState();
            return state;
        }

        public IInventoryItemState Get(InventoryItemId inventoryItemId)
        {
            return GetAsync(inventoryItemId).GetAwaiter().GetResult();
        }


        public IEnumerable<IInventoryItemState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IInventoryItemState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryItemState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryItemState> states = null;
			var q = new InventoryItemsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryItemProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryItemProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = InventoryItemProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryItemsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItems.Get(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryItemState());
            return states;
        }

        public IEnumerable<IInventoryItemState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IInventoryItemState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInventoryItemState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IInventoryItemState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryItemState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryItemState> states = null;
			var q = new InventoryItemsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryItemProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryItemProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = InventoryItemProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryItemsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItems.Get(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryItemState());
            return states;
        }

        public IEnumerable<IInventoryItemState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new InventoryItemsCountGetQuery();
            q.FilterTag = InventoryItemProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryItemsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemsCount.Get(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new InventoryItemsCountGetQuery();
            q.Filter = InventoryItemProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryItemsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemsCount.Get(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IInventoryItemStateEvent> GetStateEventAsync(InventoryItemId inventoryItemId, long version)
        {
            var idObj = InventoryItemProxyUtils.ToIdString(inventoryItemId);
            var uriParameters = new InventoryItemStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryItemStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryItemStateEvent.Get(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IInventoryItemStateEvent GetStateEvent(InventoryItemId inventoryItemId, long version)
        {
            return GetStateEventAsync(inventoryItemId, version).GetAwaiter().GetResult();
        }


        public async Task<IInventoryItemState> GetHistoryStateAsync(InventoryItemId inventoryItemId, long version)
        {
            var idObj = InventoryItemProxyUtils.ToIdString(inventoryItemId);
            var uriParameters = new InventoryItemHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryItemHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryItemHistoryState.Get(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInventoryItemState();
        }

        public virtual IInventoryItemState GetHistoryState(InventoryItemId inventoryItemId, long version)
        {
            return GetHistoryStateAsync(inventoryItemId, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IInventoryItemEntryState> GetInventoryItemEntryAsync(InventoryItemId inventoryItemId, long entrySeqId)
        {
            var uriParameters = new InventoryItemEntryUriParameters();
            uriParameters.InventoryItemId = ((new ValueObjectTextFormatter<InventoryItemId>())).ToString(inventoryItemId);
            uriParameters.EntrySeqId = entrySeqId;

            var req = new InventoryItemEntryGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryItemEntry.Get(req);
            InventoryItemProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInventoryItemEntryState();
        }

        public virtual IInventoryItemEntryState GetInventoryItemEntry(InventoryItemId inventoryItemId, long entrySeqId)
        {
            return GetInventoryItemEntryAsync(inventoryItemId, entrySeqId).GetAwaiter().GetResult();
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


    public partial class InventoryItemApplicationServiceProxyFactory : ProxyFactoryBase, IInventoryItemApplicationServiceFactory
    {

        public InventoryItemApplicationServiceProxyFactory() : base()
        {}

        public InventoryItemApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IInventoryItemApplicationService InventoryItemApplicationService
        {
            get
            {
                return new InventoryItemApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateInventoryItem NewCreateInventoryItem()
        {
            return new CreateInventoryItemDto();
        }

        public IMergePatchInventoryItem NewMergePatchInventoryItem()
        {
            return new MergePatchInventoryItemDto();
        }

        public IDeleteInventoryItem NewDeleteInventoryItem()
        {
            return new DeleteInventoryItemDto();
        }
    }

    public static class InventoryItemProxyUtils
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

        public static string ToIdString(InventoryItemId id)
        {
            var formatter = (new ValueObjectTextFormatter<InventoryItemId>());
            var idStr = formatter.ToString(id);
            return idStr;
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

        public static IEnumerable<InventoryItemId> ToIdCollection(IEnumerable<IInventoryItemState> states)
        {
            var ids = new List<InventoryItemId>();
            foreach (var s in states)
            {
                ids.Add(s.InventoryItemId);
            }
            return ids;
        }

    }

}

