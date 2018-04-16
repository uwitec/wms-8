﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Uom;
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

    public partial class UomApplicationServiceProxy : IUomApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public UomApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public UomApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public UomApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateUomDto c)
        {
            var idObj = (c as ICreateUom).UomId;
            var uriParameters = new UomUriParameters();
            uriParameters.Id = idObj;

            var req = new UomPutRequest(uriParameters, (CreateUomDto)c);
                
            var resp = await _ramlClient.Uom.Put(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateUomDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchUomDto c)
        {
            var idObj = (c as IMergePatchUom).UomId;
            var uriParameters = new UomUriParameters();
            uriParameters.Id = idObj;

            var req = new UomPatchRequest(uriParameters, (MergePatchUomDto)c);
            var resp = await _ramlClient.Uom.Patch(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchUomDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteUomDto c)
        {
            var idObj = (c as IDeleteUom).UomId;
            var uriParameters = new UomUriParameters();
            uriParameters.Id = idObj;

            var q = new UomDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new UomDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Uom.Delete(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteUomDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IUomApplicationService.When(ICreateUom c)
        {
            this.When((CreateUomDto)c);
        }

        void IUomApplicationService.When(IMergePatchUom c)
        {
            this.When((MergePatchUomDto)c);
        }

        void IUomApplicationService.When(IDeleteUom c)
        {
            this.When((DeleteUomDto)c);
        }

        public async Task<IUomState> GetAsync(string uomId)
        {
            IUomState state = null;
            var idObj = uomId;
            var uriParameters = new UomUriParameters();
            uriParameters.Id = idObj;

            var req = new UomGetRequest(uriParameters);

            var resp = await _ramlClient.Uom.Get(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToUomState();
            return state;
        }

        public IUomState Get(string uomId)
        {
            return GetAsync(uomId).GetAwaiter().GetResult();
        }


        public IEnumerable<IUomState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IUomState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUomState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUomState> states = null;
			var q = new UomsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UomProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UomProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = UomProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UomsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Uoms.Get(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToUomState());
            return states;
        }

        public IEnumerable<IUomState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IUomState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IUomState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IUomState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IUomState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IUomState> states = null;
			var q = new UomsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = UomProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = UomProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = UomProxyUtils.GetFilterQueryValueString(filter);
            var req = new UomsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Uoms.Get(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToUomState());
            return states;
        }

        public IEnumerable<IUomState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new UomsCountGetQuery();
            q.FilterTag = UomProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new UomsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UomsCount.Get(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new UomsCountGetQuery();
            q.Filter = UomProxyUtils.GetFilterQueryValueString(filter);
            var req = new UomsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.UomsCount.Get(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IUomEvent> GetStateEventAsync(string uomId, long version)
        {
            var idObj = uomId;
            var uriParameters = new UomStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UomStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.UomStateEvent.Get(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IUomEvent GetEvent(string uomId, long version)
        {
            return GetStateEventAsync(uomId, version).GetAwaiter().GetResult();
        }


        public async Task<IUomState> GetHistoryStateAsync(string uomId, long version)
        {
            var idObj = uomId;
            var uriParameters = new UomHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new UomHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.UomHistoryState.Get(req);
            UomProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToUomState();
        }

        public virtual IUomState GetHistoryState(string uomId, long version)
        {
            return GetHistoryStateAsync(uomId, version).GetAwaiter().GetResult();
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


    public partial class UomApplicationServiceProxyFactory : ProxyFactoryBase, IUomApplicationServiceFactory
    {

        public UomApplicationServiceProxyFactory() : base()
        {}

        public UomApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IUomApplicationService UomApplicationService
        {
            get
            {
                return new UomApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateUom NewCreateUom()
        {
            return new CreateUomDto();
        }

        public IMergePatchUom NewMergePatchUom()
        {
            return new MergePatchUomDto();
        }

        public IDeleteUom NewDeleteUom()
        {
            return new DeleteUomDto();
        }
    }

    public static class UomProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IUomState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.UomId);
            }
            return ids;
        }

    }

}

