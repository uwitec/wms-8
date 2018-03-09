﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItemEntryMvo;
using Dddml.Wms.Domain.SellableInventoryItem;
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

    public partial class SellableInventoryItemEntryMvoApplicationServiceProxy : ISellableInventoryItemEntryMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public SellableInventoryItemEntryMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public SellableInventoryItemEntryMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public SellableInventoryItemEntryMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateSellableInventoryItemEntryMvoDto c)
        {
            var idObj = SellableInventoryItemEntryMvoProxyUtils.ToIdString((c as ICreateSellableInventoryItemEntryMvo).SellableInventoryItemEntryId);
            var uriParameters = new SellableInventoryItemEntryMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new SellableInventoryItemEntryMvoPutRequest(uriParameters, (CreateSellableInventoryItemEntryMvoDto)c);
                
            var resp = await _ramlClient.SellableInventoryItemEntryMvo.Put(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateSellableInventoryItemEntryMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchSellableInventoryItemEntryMvoDto c)
        {
            var idObj = SellableInventoryItemEntryMvoProxyUtils.ToIdString((c as IMergePatchSellableInventoryItemEntryMvo).SellableInventoryItemEntryId);
            var uriParameters = new SellableInventoryItemEntryMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new SellableInventoryItemEntryMvoPatchRequest(uriParameters, (MergePatchSellableInventoryItemEntryMvoDto)c);
            var resp = await _ramlClient.SellableInventoryItemEntryMvo.Patch(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchSellableInventoryItemEntryMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteSellableInventoryItemEntryMvoDto c)
        {
            var idObj = SellableInventoryItemEntryMvoProxyUtils.ToIdString((c as IDeleteSellableInventoryItemEntryMvo).SellableInventoryItemEntryId);
            var uriParameters = new SellableInventoryItemEntryMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new SellableInventoryItemEntryMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.SellableInventoryItemVersion);
                
            var req = new SellableInventoryItemEntryMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.SellableInventoryItemEntryMvo.Delete(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteSellableInventoryItemEntryMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void ISellableInventoryItemEntryMvoApplicationService.When(ICreateSellableInventoryItemEntryMvo c)
        {
            this.When((CreateSellableInventoryItemEntryMvoDto)c);
        }

        void ISellableInventoryItemEntryMvoApplicationService.When(IMergePatchSellableInventoryItemEntryMvo c)
        {
            this.When((MergePatchSellableInventoryItemEntryMvoDto)c);
        }

        public async Task<ISellableInventoryItemEntryMvoState> GetAsync(SellableInventoryItemEntryId sellableInventoryItemEntryId)
        {
            ISellableInventoryItemEntryMvoState state = null;
            var idObj = SellableInventoryItemEntryMvoProxyUtils.ToIdString(sellableInventoryItemEntryId);
            var uriParameters = new SellableInventoryItemEntryMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new SellableInventoryItemEntryMvoGetRequest(uriParameters);

            var resp = await _ramlClient.SellableInventoryItemEntryMvo.Get(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToSellableInventoryItemEntryMvoState();
            return state;
        }

        public ISellableInventoryItemEntryMvoState Get(SellableInventoryItemEntryId sellableInventoryItemEntryId)
        {
            return GetAsync(sellableInventoryItemEntryId).GetAwaiter().GetResult();
        }


        public IEnumerable<ISellableInventoryItemEntryMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<ISellableInventoryItemEntryMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<ISellableInventoryItemEntryMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<ISellableInventoryItemEntryMvoState> states = null;
			var q = new SellableInventoryItemEntryMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = SellableInventoryItemEntryMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = SellableInventoryItemEntryMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = SellableInventoryItemEntryMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new SellableInventoryItemEntryMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.SellableInventoryItemEntryMvos.Get(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToSellableInventoryItemEntryMvoState());
            return states;
        }

        public IEnumerable<ISellableInventoryItemEntryMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<ISellableInventoryItemEntryMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<ISellableInventoryItemEntryMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<ISellableInventoryItemEntryMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<ISellableInventoryItemEntryMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<ISellableInventoryItemEntryMvoState> states = null;
			var q = new SellableInventoryItemEntryMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = SellableInventoryItemEntryMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = SellableInventoryItemEntryMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = SellableInventoryItemEntryMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new SellableInventoryItemEntryMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.SellableInventoryItemEntryMvos.Get(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToSellableInventoryItemEntryMvoState());
            return states;
        }

        public IEnumerable<ISellableInventoryItemEntryMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new SellableInventoryItemEntryMvosCountGetQuery();
            q.FilterTag = SellableInventoryItemEntryMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new SellableInventoryItemEntryMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.SellableInventoryItemEntryMvosCount.Get(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new SellableInventoryItemEntryMvosCountGetQuery();
            q.Filter = SellableInventoryItemEntryMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new SellableInventoryItemEntryMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.SellableInventoryItemEntryMvosCount.Get(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<ISellableInventoryItemEntryMvoStateEvent> GetStateEventAsync(SellableInventoryItemEntryId sellableInventoryItemEntryId, long version)
        {
            var idObj = SellableInventoryItemEntryMvoProxyUtils.ToIdString(sellableInventoryItemEntryId);
            var uriParameters = new SellableInventoryItemEntryMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new SellableInventoryItemEntryMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.SellableInventoryItemEntryMvoStateEvent.Get(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public ISellableInventoryItemEntryMvoStateEvent GetStateEvent(SellableInventoryItemEntryId sellableInventoryItemEntryId, long version)
        {
            return GetStateEventAsync(sellableInventoryItemEntryId, version).GetAwaiter().GetResult();
        }


        public async Task<ISellableInventoryItemEntryMvoState> GetHistoryStateAsync(SellableInventoryItemEntryId sellableInventoryItemEntryId, long version)
        {
            var idObj = SellableInventoryItemEntryMvoProxyUtils.ToIdString(sellableInventoryItemEntryId);
            var uriParameters = new SellableInventoryItemEntryMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new SellableInventoryItemEntryMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.SellableInventoryItemEntryMvoHistoryState.Get(req);
            SellableInventoryItemEntryMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToSellableInventoryItemEntryMvoState();
        }

        public virtual ISellableInventoryItemEntryMvoState GetHistoryState(SellableInventoryItemEntryId sellableInventoryItemEntryId, long version)
        {
            return GetHistoryStateAsync(sellableInventoryItemEntryId, version).GetAwaiter().GetResult();
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


    public partial class SellableInventoryItemEntryMvoApplicationServiceProxyFactory : ProxyFactoryBase, ISellableInventoryItemEntryMvoApplicationServiceFactory
    {

        public SellableInventoryItemEntryMvoApplicationServiceProxyFactory() : base()
        {}

        public SellableInventoryItemEntryMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public ISellableInventoryItemEntryMvoApplicationService SellableInventoryItemEntryMvoApplicationService
        {
            get
            {
                return new SellableInventoryItemEntryMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateSellableInventoryItemEntryMvo NewCreateSellableInventoryItemEntryMvo()
        {
            return new CreateSellableInventoryItemEntryMvoDto();
        }

        public IMergePatchSellableInventoryItemEntryMvo NewMergePatchSellableInventoryItemEntryMvo()
        {
            return new MergePatchSellableInventoryItemEntryMvoDto();
        }

        public IDeleteSellableInventoryItemEntryMvo NewDeleteSellableInventoryItemEntryMvo()
        {
            return new DeleteSellableInventoryItemEntryMvoDto();
        }
    }

    public static class SellableInventoryItemEntryMvoProxyUtils
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

        public static string ToIdString(SellableInventoryItemEntryId id)
        {
            var formatter = (new ValueObjectTextFormatter<SellableInventoryItemEntryId>());
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

        public static IEnumerable<SellableInventoryItemEntryId> ToIdCollection(IEnumerable<ISellableInventoryItemEntryMvoState> states)
        {
            var ids = new List<SellableInventoryItemEntryId>();
            foreach (var s in states)
            {
                ids.Add(s.SellableInventoryItemEntryId);
            }
            return ids;
        }

    }

}

