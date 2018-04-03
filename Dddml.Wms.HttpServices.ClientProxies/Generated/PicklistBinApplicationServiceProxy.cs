﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
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

    public partial class PicklistBinApplicationServiceProxy : IPicklistBinApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public PicklistBinApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public PicklistBinApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public PicklistBinApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreatePicklistBinDto c)
        {
            var idObj = (c as ICreatePicklistBin).PicklistBinId;
            var uriParameters = new PicklistBinUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistBinPutRequest(uriParameters, (CreatePicklistBinDto)c);
                
            var resp = await _ramlClient.PicklistBin.Put(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreatePicklistBinDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchPicklistBinDto c)
        {
            var idObj = (c as IMergePatchPicklistBin).PicklistBinId;
            var uriParameters = new PicklistBinUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistBinPatchRequest(uriParameters, (MergePatchPicklistBinDto)c);
            var resp = await _ramlClient.PicklistBin.Patch(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchPicklistBinDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeletePicklistBinDto c)
        {
            var idObj = (c as IDeletePicklistBin).PicklistBinId;
            var uriParameters = new PicklistBinUriParameters();
            uriParameters.Id = idObj;

            var q = new PicklistBinDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new PicklistBinDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.PicklistBin.Delete(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeletePicklistBinDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IPicklistBinApplicationService.When(ICreatePicklistBin c)
        {
            this.When((CreatePicklistBinDto)c);
        }

        void IPicklistBinApplicationService.When(IMergePatchPicklistBin c)
        {
            this.When((MergePatchPicklistBinDto)c);
        }

        void IPicklistBinApplicationService.When(IDeletePicklistBin c)
        {
            this.When((DeletePicklistBinDto)c);
        }

        public async Task<IPicklistBinState> GetAsync(string picklistBinId)
        {
            IPicklistBinState state = null;
            var idObj = picklistBinId;
            var uriParameters = new PicklistBinUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistBinGetRequest(uriParameters);

            var resp = await _ramlClient.PicklistBin.Get(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToPicklistBinState();
            return state;
        }

        public IPicklistBinState Get(string picklistBinId)
        {
            return GetAsync(picklistBinId).GetAwaiter().GetResult();
        }


        public IEnumerable<IPicklistBinState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IPicklistBinState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPicklistBinState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPicklistBinState> states = null;
			var q = new PicklistBinsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PicklistBinProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PicklistBinProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = PicklistBinProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PicklistBinsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistBins.Get(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPicklistBinState());
            return states;
        }

        public IEnumerable<IPicklistBinState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IPicklistBinState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IPicklistBinState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IPicklistBinState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPicklistBinState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPicklistBinState> states = null;
			var q = new PicklistBinsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PicklistBinProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PicklistBinProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = PicklistBinProxyUtils.GetFilterQueryValueString(filter);
            var req = new PicklistBinsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistBins.Get(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPicklistBinState());
            return states;
        }

        public IEnumerable<IPicklistBinState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new PicklistBinsCountGetQuery();
            q.FilterTag = PicklistBinProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PicklistBinsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistBinsCount.Get(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new PicklistBinsCountGetQuery();
            q.Filter = PicklistBinProxyUtils.GetFilterQueryValueString(filter);
            var req = new PicklistBinsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistBinsCount.Get(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IPicklistBinStateEvent> GetStateEventAsync(string picklistBinId, long version)
        {
            var idObj = picklistBinId;
            var uriParameters = new PicklistBinStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PicklistBinStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.PicklistBinStateEvent.Get(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IPicklistBinStateEvent GetStateEvent(string picklistBinId, long version)
        {
            return GetStateEventAsync(picklistBinId, version).GetAwaiter().GetResult();
        }


        public async Task<IPicklistBinState> GetHistoryStateAsync(string picklistBinId, long version)
        {
            var idObj = picklistBinId;
            var uriParameters = new PicklistBinHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PicklistBinHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.PicklistBinHistoryState.Get(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToPicklistBinState();
        }

        public virtual IPicklistBinState GetHistoryState(string picklistBinId, long version)
        {
            return GetHistoryStateAsync(picklistBinId, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IPicklistItemState> GetPicklistItemAsync(string picklistBinId, PicklistItemOrderShipGrpInvId picklistItemOrderShipGrpInvId)
        {
            var uriParameters = new PicklistItemUriParameters();
            uriParameters.PicklistBinId = picklistBinId;
            uriParameters.PicklistItemOrderShipGrpInvId = ((new ValueObjectTextFormatter<PicklistItemOrderShipGrpInvId>())).ToString(picklistItemOrderShipGrpInvId);

            var req = new PicklistItemGetRequest(uriParameters);
            var resp = await _ramlClient.PicklistItem.Get(req);
            PicklistBinProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToPicklistItemState();
        }

        public virtual IPicklistItemState GetPicklistItem(string picklistBinId, PicklistItemOrderShipGrpInvId picklistItemOrderShipGrpInvId)
        {
            return GetPicklistItemAsync(picklistBinId, picklistItemOrderShipGrpInvId).GetAwaiter().GetResult();
        }

        public IEnumerable<IPicklistItemState> GetPicklistItems(string picklistBinId)
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


    public partial class PicklistBinApplicationServiceProxyFactory : ProxyFactoryBase, IPicklistBinApplicationServiceFactory
    {

        public PicklistBinApplicationServiceProxyFactory() : base()
        {}

        public PicklistBinApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IPicklistBinApplicationService PicklistBinApplicationService
        {
            get
            {
                return new PicklistBinApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreatePicklistBin NewCreatePicklistBin()
        {
            return new CreatePicklistBinDto();
        }

        public IMergePatchPicklistBin NewMergePatchPicklistBin()
        {
            return new MergePatchPicklistBinDto();
        }

        public IDeletePicklistBin NewDeletePicklistBin()
        {
            return new DeletePicklistBinDto();
        }
    }

    public static class PicklistBinProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IPicklistBinState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.PicklistBinId);
            }
            return ids;
        }

    }

}

