﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEventType;
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

    public partial class InventoryItemEventTypeApplicationServiceProxy : IInventoryItemEventTypeApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public InventoryItemEventTypeApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public InventoryItemEventTypeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public InventoryItemEventTypeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateInventoryItemEventTypeDto c)
        {
            var idObj = (c as ICreateInventoryItemEventType).InventoryItemEventTypeId;
            var uriParameters = new InventoryItemEventTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemEventTypePutRequest(uriParameters, (CreateInventoryItemEventTypeDto)c);
                
            var resp = await _ramlClient.InventoryItemEventType.Put(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateInventoryItemEventTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchInventoryItemEventTypeDto c)
        {
            var idObj = (c as IMergePatchInventoryItemEventType).InventoryItemEventTypeId;
            var uriParameters = new InventoryItemEventTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemEventTypePatchRequest(uriParameters, (MergePatchInventoryItemEventTypeDto)c);
            var resp = await _ramlClient.InventoryItemEventType.Patch(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchInventoryItemEventTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteInventoryItemEventTypeDto c)
        {
            var idObj = (c as IDeleteInventoryItemEventType).InventoryItemEventTypeId;
            var uriParameters = new InventoryItemEventTypeUriParameters();
            uriParameters.Id = idObj;

            var q = new InventoryItemEventTypeDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new InventoryItemEventTypeDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.InventoryItemEventType.Delete(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteInventoryItemEventTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IInventoryItemEventTypeApplicationService.When(ICreateInventoryItemEventType c)
        {
            this.When((CreateInventoryItemEventTypeDto)c);
        }

        void IInventoryItemEventTypeApplicationService.When(IMergePatchInventoryItemEventType c)
        {
            this.When((MergePatchInventoryItemEventTypeDto)c);
        }

        void IInventoryItemEventTypeApplicationService.When(IDeleteInventoryItemEventType c)
        {
            this.When((DeleteInventoryItemEventTypeDto)c);
        }

        public async Task<IInventoryItemEventTypeState> GetAsync(string inventoryItemEventTypeId)
        {
            IInventoryItemEventTypeState state = null;
            var idObj = inventoryItemEventTypeId;
            var uriParameters = new InventoryItemEventTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemEventTypeGetRequest(uriParameters);

            var resp = await _ramlClient.InventoryItemEventType.Get(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToInventoryItemEventTypeState();
            return state;
        }

        public IInventoryItemEventTypeState Get(string inventoryItemEventTypeId)
        {
            return GetAsync(inventoryItemEventTypeId).GetAwaiter().GetResult();
        }


        public IEnumerable<IInventoryItemEventTypeState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IInventoryItemEventTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryItemEventTypeState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryItemEventTypeState> states = null;
			var q = new InventoryItemEventTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryItemEventTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryItemEventTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = InventoryItemEventTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryItemEventTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemEventTypes.Get(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryItemEventTypeState());
            return states;
        }

        public IEnumerable<IInventoryItemEventTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IInventoryItemEventTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInventoryItemEventTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IInventoryItemEventTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryItemEventTypeState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryItemEventTypeState> states = null;
			var q = new InventoryItemEventTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryItemEventTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryItemEventTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = InventoryItemEventTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryItemEventTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemEventTypes.Get(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryItemEventTypeState());
            return states;
        }

        public IEnumerable<IInventoryItemEventTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new InventoryItemEventTypesCountGetQuery();
            q.FilterTag = InventoryItemEventTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryItemEventTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemEventTypesCount.Get(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new InventoryItemEventTypesCountGetQuery();
            q.Filter = InventoryItemEventTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryItemEventTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemEventTypesCount.Get(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IInventoryItemEventTypeStateEvent> GetStateEventAsync(string inventoryItemEventTypeId, long version)
        {
            var idObj = inventoryItemEventTypeId;
            var uriParameters = new InventoryItemEventTypeStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryItemEventTypeStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryItemEventTypeStateEvent.Get(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IInventoryItemEventTypeStateEvent GetStateEvent(string inventoryItemEventTypeId, long version)
        {
            return GetStateEventAsync(inventoryItemEventTypeId, version).GetAwaiter().GetResult();
        }


        public async Task<IInventoryItemEventTypeState> GetHistoryStateAsync(string inventoryItemEventTypeId, long version)
        {
            var idObj = inventoryItemEventTypeId;
            var uriParameters = new InventoryItemEventTypeHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryItemEventTypeHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryItemEventTypeHistoryState.Get(req);
            InventoryItemEventTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInventoryItemEventTypeState();
        }

        public virtual IInventoryItemEventTypeState GetHistoryState(string inventoryItemEventTypeId, long version)
        {
            return GetHistoryStateAsync(inventoryItemEventTypeId, version).GetAwaiter().GetResult();
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


    public partial class InventoryItemEventTypeApplicationServiceProxyFactory : ProxyFactoryBase, IInventoryItemEventTypeApplicationServiceFactory
    {

        public InventoryItemEventTypeApplicationServiceProxyFactory() : base()
        {}

        public InventoryItemEventTypeApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IInventoryItemEventTypeApplicationService InventoryItemEventTypeApplicationService
        {
            get
            {
                return new InventoryItemEventTypeApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateInventoryItemEventType NewCreateInventoryItemEventType()
        {
            return new CreateInventoryItemEventTypeDto();
        }

        public IMergePatchInventoryItemEventType NewMergePatchInventoryItemEventType()
        {
            return new MergePatchInventoryItemEventTypeDto();
        }

        public IDeleteInventoryItemEventType NewDeleteInventoryItemEventType()
        {
            return new DeleteInventoryItemEventTypeDto();
        }
    }

    public static class InventoryItemEventTypeProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IInventoryItemEventTypeState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.InventoryItemEventTypeId);
            }
            return ids;
        }

    }

}

