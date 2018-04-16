﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemRequirementEntryMvo;
using Dddml.Wms.Domain.InventoryItemRequirement;
using Dddml.Wms.Domain.InventoryPRTriggered;
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

    public partial class InventoryItemRequirementEntryMvoApplicationServiceProxy : IInventoryItemRequirementEntryMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public InventoryItemRequirementEntryMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public InventoryItemRequirementEntryMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public InventoryItemRequirementEntryMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateInventoryItemRequirementEntryMvoDto c)
        {
            var idObj = InventoryItemRequirementEntryMvoProxyUtils.ToIdString((c as ICreateInventoryItemRequirementEntryMvo).InventoryItemRequirementEntryId);
            var uriParameters = new InventoryItemRequirementEntryMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemRequirementEntryMvoPutRequest(uriParameters, (CreateInventoryItemRequirementEntryMvoDto)c);
                
            var resp = await _ramlClient.InventoryItemRequirementEntryMvo.Put(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateInventoryItemRequirementEntryMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchInventoryItemRequirementEntryMvoDto c)
        {
            var idObj = InventoryItemRequirementEntryMvoProxyUtils.ToIdString((c as IMergePatchInventoryItemRequirementEntryMvo).InventoryItemRequirementEntryId);
            var uriParameters = new InventoryItemRequirementEntryMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemRequirementEntryMvoPatchRequest(uriParameters, (MergePatchInventoryItemRequirementEntryMvoDto)c);
            var resp = await _ramlClient.InventoryItemRequirementEntryMvo.Patch(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchInventoryItemRequirementEntryMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteInventoryItemRequirementEntryMvoDto c)
        {
            var idObj = InventoryItemRequirementEntryMvoProxyUtils.ToIdString((c as IDeleteInventoryItemRequirementEntryMvo).InventoryItemRequirementEntryId);
            var uriParameters = new InventoryItemRequirementEntryMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new InventoryItemRequirementEntryMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.InventoryItemRequirementVersion);
                
            var req = new InventoryItemRequirementEntryMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.InventoryItemRequirementEntryMvo.Delete(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteInventoryItemRequirementEntryMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IInventoryItemRequirementEntryMvoApplicationService.When(ICreateInventoryItemRequirementEntryMvo c)
        {
            this.When((CreateInventoryItemRequirementEntryMvoDto)c);
        }

        void IInventoryItemRequirementEntryMvoApplicationService.When(IMergePatchInventoryItemRequirementEntryMvo c)
        {
            this.When((MergePatchInventoryItemRequirementEntryMvoDto)c);
        }

        public async Task<IInventoryItemRequirementEntryMvoState> GetAsync(InventoryItemRequirementEntryId inventoryItemRequirementEntryId)
        {
            IInventoryItemRequirementEntryMvoState state = null;
            var idObj = InventoryItemRequirementEntryMvoProxyUtils.ToIdString(inventoryItemRequirementEntryId);
            var uriParameters = new InventoryItemRequirementEntryMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InventoryItemRequirementEntryMvoGetRequest(uriParameters);

            var resp = await _ramlClient.InventoryItemRequirementEntryMvo.Get(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToInventoryItemRequirementEntryMvoState();
            return state;
        }

        public IInventoryItemRequirementEntryMvoState Get(InventoryItemRequirementEntryId inventoryItemRequirementEntryId)
        {
            return GetAsync(inventoryItemRequirementEntryId).GetAwaiter().GetResult();
        }


        public IEnumerable<IInventoryItemRequirementEntryMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IInventoryItemRequirementEntryMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryItemRequirementEntryMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryItemRequirementEntryMvoState> states = null;
			var q = new InventoryItemRequirementEntryMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryItemRequirementEntryMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryItemRequirementEntryMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = InventoryItemRequirementEntryMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryItemRequirementEntryMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemRequirementEntryMvos.Get(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryItemRequirementEntryMvoState());
            return states;
        }

        public IEnumerable<IInventoryItemRequirementEntryMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IInventoryItemRequirementEntryMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInventoryItemRequirementEntryMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IInventoryItemRequirementEntryMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInventoryItemRequirementEntryMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInventoryItemRequirementEntryMvoState> states = null;
			var q = new InventoryItemRequirementEntryMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InventoryItemRequirementEntryMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InventoryItemRequirementEntryMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = InventoryItemRequirementEntryMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryItemRequirementEntryMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemRequirementEntryMvos.Get(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInventoryItemRequirementEntryMvoState());
            return states;
        }

        public IEnumerable<IInventoryItemRequirementEntryMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new InventoryItemRequirementEntryMvosCountGetQuery();
            q.FilterTag = InventoryItemRequirementEntryMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InventoryItemRequirementEntryMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemRequirementEntryMvosCount.Get(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new InventoryItemRequirementEntryMvosCountGetQuery();
            q.Filter = InventoryItemRequirementEntryMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new InventoryItemRequirementEntryMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InventoryItemRequirementEntryMvosCount.Get(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IInventoryItemRequirementEntryMvoEvent> GetStateEventAsync(InventoryItemRequirementEntryId inventoryItemRequirementEntryId, long version)
        {
            var idObj = InventoryItemRequirementEntryMvoProxyUtils.ToIdString(inventoryItemRequirementEntryId);
            var uriParameters = new InventoryItemRequirementEntryMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryItemRequirementEntryMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryItemRequirementEntryMvoStateEvent.Get(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IInventoryItemRequirementEntryMvoEvent GetEvent(InventoryItemRequirementEntryId inventoryItemRequirementEntryId, long version)
        {
            return GetStateEventAsync(inventoryItemRequirementEntryId, version).GetAwaiter().GetResult();
        }


        public async Task<IInventoryItemRequirementEntryMvoState> GetHistoryStateAsync(InventoryItemRequirementEntryId inventoryItemRequirementEntryId, long version)
        {
            var idObj = InventoryItemRequirementEntryMvoProxyUtils.ToIdString(inventoryItemRequirementEntryId);
            var uriParameters = new InventoryItemRequirementEntryMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InventoryItemRequirementEntryMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.InventoryItemRequirementEntryMvoHistoryState.Get(req);
            InventoryItemRequirementEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInventoryItemRequirementEntryMvoState();
        }

        public virtual IInventoryItemRequirementEntryMvoState GetHistoryState(InventoryItemRequirementEntryId inventoryItemRequirementEntryId, long version)
        {
            return GetHistoryStateAsync(inventoryItemRequirementEntryId, version).GetAwaiter().GetResult();
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


    public partial class InventoryItemRequirementEntryMvoApplicationServiceProxyFactory : ProxyFactoryBase, IInventoryItemRequirementEntryMvoApplicationServiceFactory
    {

        public InventoryItemRequirementEntryMvoApplicationServiceProxyFactory() : base()
        {}

        public InventoryItemRequirementEntryMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IInventoryItemRequirementEntryMvoApplicationService InventoryItemRequirementEntryMvoApplicationService
        {
            get
            {
                return new InventoryItemRequirementEntryMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateInventoryItemRequirementEntryMvo NewCreateInventoryItemRequirementEntryMvo()
        {
            return new CreateInventoryItemRequirementEntryMvoDto();
        }

        public IMergePatchInventoryItemRequirementEntryMvo NewMergePatchInventoryItemRequirementEntryMvo()
        {
            return new MergePatchInventoryItemRequirementEntryMvoDto();
        }

        public IDeleteInventoryItemRequirementEntryMvo NewDeleteInventoryItemRequirementEntryMvo()
        {
            return new DeleteInventoryItemRequirementEntryMvoDto();
        }
    }

    public static class InventoryItemRequirementEntryMvoProxyUtils
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

        public static string ToIdString(InventoryItemRequirementEntryId id)
        {
            var formatter = (new ValueObjectTextFormatter<InventoryItemRequirementEntryId>());
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

        public static IEnumerable<InventoryItemRequirementEntryId> ToIdCollection(IEnumerable<IInventoryItemRequirementEntryMvoState> states)
        {
            var ids = new List<InventoryItemRequirementEntryId>();
            foreach (var s in states)
            {
                ids.Add(s.InventoryItemRequirementEntryId);
            }
            return ids;
        }

    }

}

