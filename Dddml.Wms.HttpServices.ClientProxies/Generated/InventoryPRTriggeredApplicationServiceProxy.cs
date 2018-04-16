﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPRTriggered;
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

    public partial class InventoryPRTriggeredApplicationServiceProxy : IInventoryPRTriggeredApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public InventoryPRTriggeredApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public InventoryPRTriggeredApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public InventoryPRTriggeredApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateInventoryPRTriggeredDto c)
        {
            var idObj = InventoryPRTriggeredProxyUtils.ToIdString((c as ICreateInventoryPRTriggered).InventoryPRTriggeredId);
            var uriParameters = new InventoryPRTriggeredUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryPRTriggeredPutRequest(uriParameters, (CreateInventoryPRTriggeredDto)c);
                
            var resp = await _ramlClient.InventoryPRTriggered.Put(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateInventoryPRTriggeredDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchInventoryPRTriggeredDto c)
        {
            var idObj = InventoryPRTriggeredProxyUtils.ToIdString((c as IMergePatchInventoryPRTriggered).InventoryPRTriggeredId);
            var uriParameters = new InventoryPRTriggeredUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryPRTriggeredPatchRequest(uriParameters, (MergePatchInventoryPRTriggeredDto)c);
            var resp = await _ramlClient.InventoryPRTriggered.Patch(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchInventoryPRTriggeredDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteInventoryPRTriggeredDto c)
        {
            var idObj = InventoryPRTriggeredProxyUtils.ToIdString((c as IDeleteInventoryPRTriggered).InventoryPRTriggeredId);
            var uriParameters = new InventoryPRTriggeredUriParameters();
            uriParameters.Id = idObj;

            var q = new InventoryPRTriggeredDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new InventoryPRTriggeredDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.InventoryPRTriggered.Delete(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteInventoryPRTriggeredDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IInventoryPRTriggeredApplicationService.When(ICreateInventoryPRTriggered c)
        {
            this.When((CreateInventoryPRTriggeredDto)c);
        }

        void IInventoryPRTriggeredApplicationService.When(IMergePatchInventoryPRTriggered c)
        {
            this.When((MergePatchInventoryPRTriggeredDto)c);
        }

        public async Task<IInventoryPRTriggeredState> GetAsync(InventoryPRTriggeredId inventoryPRTriggeredId)
        {
            IInventoryPRTriggeredState state = null;
            var idObj = InventoryPRTriggeredProxyUtils.ToIdString(inventoryPRTriggeredId);
            var uriParameters = new InventoryPRTriggeredUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryPRTriggeredGetRequest(uriParameters);

            var resp = await _ramlClient.InventoryPRTriggered.Get(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToInventoryPRTriggeredState();
            return state;
        }

        public IInventoryPRTriggeredState Get(InventoryPRTriggeredId inventoryPRTriggeredId)
        {
            return GetAsync(inventoryPRTriggeredId).GetAwaiter().GetResult();
        }


        public IEnumerable<IInventoryPRTriggeredState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IInventoryPRTriggeredState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryPRTriggeredState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryPRTriggeredState> states = null;
			var q = new InventoryPRTriggeredsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryPRTriggeredProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryPRTriggeredProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = InventoryPRTriggeredProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryPRTriggeredsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryPRTriggereds.Get(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryPRTriggeredState());
            return states;
        }

        public IEnumerable<IInventoryPRTriggeredState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IInventoryPRTriggeredState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInventoryPRTriggeredState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IInventoryPRTriggeredState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryPRTriggeredState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryPRTriggeredState> states = null;
			var q = new InventoryPRTriggeredsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryPRTriggeredProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryPRTriggeredProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = InventoryPRTriggeredProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryPRTriggeredsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryPRTriggereds.Get(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryPRTriggeredState());
            return states;
        }

        public IEnumerable<IInventoryPRTriggeredState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new InventoryPRTriggeredsCountGetQuery();
            q.FilterTag = InventoryPRTriggeredProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryPRTriggeredsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryPRTriggeredsCount.Get(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new InventoryPRTriggeredsCountGetQuery();
            q.Filter = InventoryPRTriggeredProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryPRTriggeredsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryPRTriggeredsCount.Get(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IInventoryPRTriggeredEvent> GetStateEventAsync(InventoryPRTriggeredId inventoryPRTriggeredId, long version)
        {
            var idObj = InventoryPRTriggeredProxyUtils.ToIdString(inventoryPRTriggeredId);
            var uriParameters = new InventoryPRTriggeredStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryPRTriggeredStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryPRTriggeredStateEvent.Get(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IInventoryPRTriggeredEvent GetEvent(InventoryPRTriggeredId inventoryPRTriggeredId, long version)
        {
            return GetStateEventAsync(inventoryPRTriggeredId, version).GetAwaiter().GetResult();
        }


        public async Task<IInventoryPRTriggeredState> GetHistoryStateAsync(InventoryPRTriggeredId inventoryPRTriggeredId, long version)
        {
            var idObj = InventoryPRTriggeredProxyUtils.ToIdString(inventoryPRTriggeredId);
            var uriParameters = new InventoryPRTriggeredHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryPRTriggeredHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryPRTriggeredHistoryState.Get(req);
            InventoryPRTriggeredProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInventoryPRTriggeredState();
        }

        public virtual IInventoryPRTriggeredState GetHistoryState(InventoryPRTriggeredId inventoryPRTriggeredId, long version)
        {
            return GetHistoryStateAsync(inventoryPRTriggeredId, version).GetAwaiter().GetResult();
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


    public partial class InventoryPRTriggeredApplicationServiceProxyFactory : ProxyFactoryBase, IInventoryPRTriggeredApplicationServiceFactory
    {

        public InventoryPRTriggeredApplicationServiceProxyFactory() : base()
        {}

        public InventoryPRTriggeredApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IInventoryPRTriggeredApplicationService InventoryPRTriggeredApplicationService
        {
            get
            {
                return new InventoryPRTriggeredApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateInventoryPRTriggered NewCreateInventoryPRTriggered()
        {
            return new CreateInventoryPRTriggeredDto();
        }

        public IMergePatchInventoryPRTriggered NewMergePatchInventoryPRTriggered()
        {
            return new MergePatchInventoryPRTriggeredDto();
        }

        public IDeleteInventoryPRTriggered NewDeleteInventoryPRTriggered()
        {
            return new DeleteInventoryPRTriggeredDto();
        }
    }

    public static class InventoryPRTriggeredProxyUtils
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

        public static string ToIdString(InventoryPRTriggeredId id)
        {
            var formatter = (new ValueObjectTextFormatter<InventoryPRTriggeredId>());
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

        public static IEnumerable<InventoryPRTriggeredId> ToIdCollection(IEnumerable<IInventoryPRTriggeredState> states)
        {
            var ids = new List<InventoryPRTriggeredId>();
            foreach (var s in states)
            {
                ids.Add(s.InventoryPRTriggeredId);
            }
            return ids;
        }

    }

}

