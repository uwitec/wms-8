﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistItemMvo;
using Dddml.Wms.Domain.PicklistBin;
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

    public partial class PicklistItemMvoApplicationServiceProxy : IPicklistItemMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public PicklistItemMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public PicklistItemMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public PicklistItemMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreatePicklistItemMvoDto c)
        {
            var idObj = PicklistItemMvoProxyUtils.ToIdString((c as ICreatePicklistItemMvo).PicklistBinPicklistItemId);
            var uriParameters = new PicklistItemMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistItemMvoPutRequest(uriParameters, (CreatePicklistItemMvoDto)c);
                
            var resp = await _ramlClient.PicklistItemMvo.Put(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreatePicklistItemMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchPicklistItemMvoDto c)
        {
            var idObj = PicklistItemMvoProxyUtils.ToIdString((c as IMergePatchPicklistItemMvo).PicklistBinPicklistItemId);
            var uriParameters = new PicklistItemMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistItemMvoPatchRequest(uriParameters, (MergePatchPicklistItemMvoDto)c);
            var resp = await _ramlClient.PicklistItemMvo.Patch(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchPicklistItemMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeletePicklistItemMvoDto c)
        {
            var idObj = PicklistItemMvoProxyUtils.ToIdString((c as IDeletePicklistItemMvo).PicklistBinPicklistItemId);
            var uriParameters = new PicklistItemMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new PicklistItemMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.PicklistBinVersion);
                
            var req = new PicklistItemMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.PicklistItemMvo.Delete(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeletePicklistItemMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IPicklistItemMvoApplicationService.When(ICreatePicklistItemMvo c)
        {
            this.When((CreatePicklistItemMvoDto)c);
        }

        void IPicklistItemMvoApplicationService.When(IMergePatchPicklistItemMvo c)
        {
            this.When((MergePatchPicklistItemMvoDto)c);
        }

        void IPicklistItemMvoApplicationService.When(IDeletePicklistItemMvo c)
        {
            this.When((DeletePicklistItemMvoDto)c);
        }

        public async Task<IPicklistItemMvoState> GetAsync(PicklistBinPicklistItemId picklistBinPicklistItemId)
        {
            IPicklistItemMvoState state = null;
            var idObj = PicklistItemMvoProxyUtils.ToIdString(picklistBinPicklistItemId);
            var uriParameters = new PicklistItemMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistItemMvoGetRequest(uriParameters);

            var resp = await _ramlClient.PicklistItemMvo.Get(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToPicklistItemMvoState();
            return state;
        }

        public IPicklistItemMvoState Get(PicklistBinPicklistItemId picklistBinPicklistItemId)
        {
            return GetAsync(picklistBinPicklistItemId).GetAwaiter().GetResult();
        }


        public IEnumerable<IPicklistItemMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IPicklistItemMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPicklistItemMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPicklistItemMvoState> states = null;
			var q = new PicklistItemMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PicklistItemMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PicklistItemMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = PicklistItemMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PicklistItemMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistItemMvos.Get(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPicklistItemMvoState());
            return states;
        }

        public IEnumerable<IPicklistItemMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IPicklistItemMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IPicklistItemMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IPicklistItemMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPicklistItemMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPicklistItemMvoState> states = null;
			var q = new PicklistItemMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PicklistItemMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PicklistItemMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = PicklistItemMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new PicklistItemMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistItemMvos.Get(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPicklistItemMvoState());
            return states;
        }

        public IEnumerable<IPicklistItemMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new PicklistItemMvosCountGetQuery();
            q.FilterTag = PicklistItemMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PicklistItemMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistItemMvosCount.Get(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new PicklistItemMvosCountGetQuery();
            q.Filter = PicklistItemMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new PicklistItemMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistItemMvosCount.Get(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IPicklistItemMvoStateEvent> GetStateEventAsync(PicklistBinPicklistItemId picklistBinPicklistItemId, long version)
        {
            var idObj = PicklistItemMvoProxyUtils.ToIdString(picklistBinPicklistItemId);
            var uriParameters = new PicklistItemMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PicklistItemMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.PicklistItemMvoStateEvent.Get(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IPicklistItemMvoStateEvent GetStateEvent(PicklistBinPicklistItemId picklistBinPicklistItemId, long version)
        {
            return GetStateEventAsync(picklistBinPicklistItemId, version).GetAwaiter().GetResult();
        }


        public async Task<IPicklistItemMvoState> GetHistoryStateAsync(PicklistBinPicklistItemId picklistBinPicklistItemId, long version)
        {
            var idObj = PicklistItemMvoProxyUtils.ToIdString(picklistBinPicklistItemId);
            var uriParameters = new PicklistItemMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PicklistItemMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.PicklistItemMvoHistoryState.Get(req);
            PicklistItemMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToPicklistItemMvoState();
        }

        public virtual IPicklistItemMvoState GetHistoryState(PicklistBinPicklistItemId picklistBinPicklistItemId, long version)
        {
            return GetHistoryStateAsync(picklistBinPicklistItemId, version).GetAwaiter().GetResult();
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


    public partial class PicklistItemMvoApplicationServiceProxyFactory : ProxyFactoryBase, IPicklistItemMvoApplicationServiceFactory
    {

        public PicklistItemMvoApplicationServiceProxyFactory() : base()
        {}

        public PicklistItemMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IPicklistItemMvoApplicationService PicklistItemMvoApplicationService
        {
            get
            {
                return new PicklistItemMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreatePicklistItemMvo NewCreatePicklistItemMvo()
        {
            return new CreatePicklistItemMvoDto();
        }

        public IMergePatchPicklistItemMvo NewMergePatchPicklistItemMvo()
        {
            return new MergePatchPicklistItemMvoDto();
        }

        public IDeletePicklistItemMvo NewDeletePicklistItemMvo()
        {
            return new DeletePicklistItemMvoDto();
        }
    }

    public static class PicklistItemMvoProxyUtils
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

        public static string ToIdString(PicklistBinPicklistItemId id)
        {
            var formatter = (new ValueObjectTextFormatter<PicklistBinPicklistItemId>());
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

        public static IEnumerable<PicklistBinPicklistItemId> ToIdCollection(IEnumerable<IPicklistItemMvoState> states)
        {
            var ids = new List<PicklistBinPicklistItemId>();
            foreach (var s in states)
            {
                ids.Add(s.PicklistBinPicklistItemId);
            }
            return ids;
        }

    }

}
