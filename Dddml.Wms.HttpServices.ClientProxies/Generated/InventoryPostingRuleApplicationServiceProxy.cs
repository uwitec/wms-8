﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPostingRule;
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

    public partial class InventoryPostingRuleApplicationServiceProxy : IInventoryPostingRuleApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public InventoryPostingRuleApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public InventoryPostingRuleApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public InventoryPostingRuleApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateInventoryPostingRuleDto c)
        {
            var idObj = (c as ICreateInventoryPostingRule).InventoryPostingRuleId;
            var uriParameters = new InventoryPostingRuleUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryPostingRulePutRequest(uriParameters, (CreateInventoryPostingRuleDto)c);
                
            var resp = await _ramlClient.InventoryPostingRule.Put(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateInventoryPostingRuleDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchInventoryPostingRuleDto c)
        {
            var idObj = (c as IMergePatchInventoryPostingRule).InventoryPostingRuleId;
            var uriParameters = new InventoryPostingRuleUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryPostingRulePatchRequest(uriParameters, (MergePatchInventoryPostingRuleDto)c);
            var resp = await _ramlClient.InventoryPostingRule.Patch(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchInventoryPostingRuleDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteInventoryPostingRuleDto c)
        {
            var idObj = (c as IDeleteInventoryPostingRule).InventoryPostingRuleId;
            var uriParameters = new InventoryPostingRuleUriParameters();
            uriParameters.Id = idObj;

            var q = new InventoryPostingRuleDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new InventoryPostingRuleDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.InventoryPostingRule.Delete(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteInventoryPostingRuleDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IInventoryPostingRuleApplicationService.When(ICreateInventoryPostingRule c)
        {
            this.When((CreateInventoryPostingRuleDto)c);
        }

        void IInventoryPostingRuleApplicationService.When(IMergePatchInventoryPostingRule c)
        {
            this.When((MergePatchInventoryPostingRuleDto)c);
        }

        void IInventoryPostingRuleApplicationService.When(IDeleteInventoryPostingRule c)
        {
            this.When((DeleteInventoryPostingRuleDto)c);
        }

        public async Task<IInventoryPostingRuleState> GetAsync(string inventoryPostingRuleId)
        {
            IInventoryPostingRuleState state = null;
            var idObj = inventoryPostingRuleId;
            var uriParameters = new InventoryPostingRuleUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryPostingRuleGetRequest(uriParameters);

            var resp = await _ramlClient.InventoryPostingRule.Get(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToInventoryPostingRuleState();
            return state;
        }

        public IInventoryPostingRuleState Get(string inventoryPostingRuleId)
        {
            return GetAsync(inventoryPostingRuleId).GetAwaiter().GetResult();
        }


        public IEnumerable<IInventoryPostingRuleState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IInventoryPostingRuleState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryPostingRuleState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryPostingRuleState> states = null;
			var q = new InventoryPostingRulesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryPostingRuleProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryPostingRuleProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = InventoryPostingRuleProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryPostingRulesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryPostingRules.Get(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryPostingRuleState());
            return states;
        }

        public IEnumerable<IInventoryPostingRuleState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IInventoryPostingRuleState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInventoryPostingRuleState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IInventoryPostingRuleState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryPostingRuleState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryPostingRuleState> states = null;
			var q = new InventoryPostingRulesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryPostingRuleProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryPostingRuleProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = InventoryPostingRuleProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryPostingRulesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryPostingRules.Get(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryPostingRuleState());
            return states;
        }

        public IEnumerable<IInventoryPostingRuleState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new InventoryPostingRulesCountGetQuery();
            q.FilterTag = InventoryPostingRuleProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryPostingRulesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryPostingRulesCount.Get(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new InventoryPostingRulesCountGetQuery();
            q.Filter = InventoryPostingRuleProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryPostingRulesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryPostingRulesCount.Get(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IInventoryPostingRuleEvent> GetStateEventAsync(string inventoryPostingRuleId, long version)
        {
            var idObj = inventoryPostingRuleId;
            var uriParameters = new InventoryPostingRuleStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryPostingRuleStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryPostingRuleStateEvent.Get(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IInventoryPostingRuleEvent GetEvent(string inventoryPostingRuleId, long version)
        {
            return GetStateEventAsync(inventoryPostingRuleId, version).GetAwaiter().GetResult();
        }


        public async Task<IInventoryPostingRuleState> GetHistoryStateAsync(string inventoryPostingRuleId, long version)
        {
            var idObj = inventoryPostingRuleId;
            var uriParameters = new InventoryPostingRuleHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryPostingRuleHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryPostingRuleHistoryState.Get(req);
            InventoryPostingRuleProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInventoryPostingRuleState();
        }

        public virtual IInventoryPostingRuleState GetHistoryState(string inventoryPostingRuleId, long version)
        {
            return GetHistoryStateAsync(inventoryPostingRuleId, version).GetAwaiter().GetResult();
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


    public partial class InventoryPostingRuleApplicationServiceProxyFactory : ProxyFactoryBase, IInventoryPostingRuleApplicationServiceFactory
    {

        public InventoryPostingRuleApplicationServiceProxyFactory() : base()
        {}

        public InventoryPostingRuleApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IInventoryPostingRuleApplicationService InventoryPostingRuleApplicationService
        {
            get
            {
                return new InventoryPostingRuleApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateInventoryPostingRule NewCreateInventoryPostingRule()
        {
            return new CreateInventoryPostingRuleDto();
        }

        public IMergePatchInventoryPostingRule NewMergePatchInventoryPostingRule()
        {
            return new MergePatchInventoryPostingRuleDto();
        }

        public IDeleteInventoryPostingRule NewDeleteInventoryPostingRule()
        {
            return new DeleteInventoryPostingRuleDto();
        }
    }

    public static class InventoryPostingRuleProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IInventoryPostingRuleState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.InventoryPostingRuleId);
            }
            return ids;
        }

    }

}

