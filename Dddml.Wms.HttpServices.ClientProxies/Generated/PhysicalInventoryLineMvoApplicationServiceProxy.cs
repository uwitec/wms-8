﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PhysicalInventoryLineMvo;
using Dddml.Wms.Domain.PhysicalInventory;
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

    public partial class PhysicalInventoryLineMvoApplicationServiceProxy : IPhysicalInventoryLineMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public PhysicalInventoryLineMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public PhysicalInventoryLineMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public PhysicalInventoryLineMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreatePhysicalInventoryLineMvoDto c)
        {
            var idObj = PhysicalInventoryLineMvoProxyUtils.ToIdString((c as ICreatePhysicalInventoryLineMvo).PhysicalInventoryLineId);
            var uriParameters = new PhysicalInventoryLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new PhysicalInventoryLineMvoPutRequest(uriParameters, (CreatePhysicalInventoryLineMvoDto)c);
                
            var resp = await _ramlClient.PhysicalInventoryLineMvo.Put(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreatePhysicalInventoryLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchPhysicalInventoryLineMvoDto c)
        {
            var idObj = PhysicalInventoryLineMvoProxyUtils.ToIdString((c as IMergePatchPhysicalInventoryLineMvo).PhysicalInventoryLineId);
            var uriParameters = new PhysicalInventoryLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new PhysicalInventoryLineMvoPatchRequest(uriParameters, (MergePatchPhysicalInventoryLineMvoDto)c);
            var resp = await _ramlClient.PhysicalInventoryLineMvo.Patch(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchPhysicalInventoryLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeletePhysicalInventoryLineMvoDto c)
        {
            var idObj = PhysicalInventoryLineMvoProxyUtils.ToIdString((c as IDeletePhysicalInventoryLineMvo).PhysicalInventoryLineId);
            var uriParameters = new PhysicalInventoryLineMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new PhysicalInventoryLineMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.PhysicalInventoryVersion);
                
            var req = new PhysicalInventoryLineMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.PhysicalInventoryLineMvo.Delete(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeletePhysicalInventoryLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IPhysicalInventoryLineMvoApplicationService.When(ICreatePhysicalInventoryLineMvo c)
        {
            this.When((CreatePhysicalInventoryLineMvoDto)c);
        }

        void IPhysicalInventoryLineMvoApplicationService.When(IMergePatchPhysicalInventoryLineMvo c)
        {
            this.When((MergePatchPhysicalInventoryLineMvoDto)c);
        }

        void IPhysicalInventoryLineMvoApplicationService.When(IDeletePhysicalInventoryLineMvo c)
        {
            this.When((DeletePhysicalInventoryLineMvoDto)c);
        }

        public async Task<IPhysicalInventoryLineMvoState> GetAsync(PhysicalInventoryLineId physicalInventoryLineId)
        {
            IPhysicalInventoryLineMvoState state = null;
            var idObj = PhysicalInventoryLineMvoProxyUtils.ToIdString(physicalInventoryLineId);
            var uriParameters = new PhysicalInventoryLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new PhysicalInventoryLineMvoGetRequest(uriParameters);

            var resp = await _ramlClient.PhysicalInventoryLineMvo.Get(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToPhysicalInventoryLineMvoState();
            return state;
        }

        public IPhysicalInventoryLineMvoState Get(PhysicalInventoryLineId physicalInventoryLineId)
        {
            return GetAsync(physicalInventoryLineId).GetAwaiter().GetResult();
        }


        public IEnumerable<IPhysicalInventoryLineMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IPhysicalInventoryLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPhysicalInventoryLineMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPhysicalInventoryLineMvoState> states = null;
			var q = new PhysicalInventoryLineMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PhysicalInventoryLineMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PhysicalInventoryLineMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = PhysicalInventoryLineMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PhysicalInventoryLineMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PhysicalInventoryLineMvos.Get(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPhysicalInventoryLineMvoState());
            return states;
        }

        public IEnumerable<IPhysicalInventoryLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IPhysicalInventoryLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IPhysicalInventoryLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IPhysicalInventoryLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPhysicalInventoryLineMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPhysicalInventoryLineMvoState> states = null;
			var q = new PhysicalInventoryLineMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PhysicalInventoryLineMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PhysicalInventoryLineMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = PhysicalInventoryLineMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new PhysicalInventoryLineMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PhysicalInventoryLineMvos.Get(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPhysicalInventoryLineMvoState());
            return states;
        }

        public IEnumerable<IPhysicalInventoryLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new PhysicalInventoryLineMvosCountGetQuery();
            q.FilterTag = PhysicalInventoryLineMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PhysicalInventoryLineMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PhysicalInventoryLineMvosCount.Get(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new PhysicalInventoryLineMvosCountGetQuery();
            q.Filter = PhysicalInventoryLineMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new PhysicalInventoryLineMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PhysicalInventoryLineMvosCount.Get(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IPhysicalInventoryLineMvoStateEvent> GetStateEventAsync(PhysicalInventoryLineId physicalInventoryLineId, long version)
        {
            var idObj = PhysicalInventoryLineMvoProxyUtils.ToIdString(physicalInventoryLineId);
            var uriParameters = new PhysicalInventoryLineMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PhysicalInventoryLineMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.PhysicalInventoryLineMvoStateEvent.Get(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IPhysicalInventoryLineMvoStateEvent GetStateEvent(PhysicalInventoryLineId physicalInventoryLineId, long version)
        {
            return GetStateEventAsync(physicalInventoryLineId, version).GetAwaiter().GetResult();
        }


        public async Task<IPhysicalInventoryLineMvoState> GetHistoryStateAsync(PhysicalInventoryLineId physicalInventoryLineId, long version)
        {
            var idObj = PhysicalInventoryLineMvoProxyUtils.ToIdString(physicalInventoryLineId);
            var uriParameters = new PhysicalInventoryLineMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PhysicalInventoryLineMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.PhysicalInventoryLineMvoHistoryState.Get(req);
            PhysicalInventoryLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToPhysicalInventoryLineMvoState();
        }

        public virtual IPhysicalInventoryLineMvoState GetHistoryState(PhysicalInventoryLineId physicalInventoryLineId, long version)
        {
            return GetHistoryStateAsync(physicalInventoryLineId, version).GetAwaiter().GetResult();
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


    public partial class PhysicalInventoryLineMvoApplicationServiceProxyFactory : ProxyFactoryBase, IPhysicalInventoryLineMvoApplicationServiceFactory
    {

        public PhysicalInventoryLineMvoApplicationServiceProxyFactory() : base()
        {}

        public PhysicalInventoryLineMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IPhysicalInventoryLineMvoApplicationService PhysicalInventoryLineMvoApplicationService
        {
            get
            {
                return new PhysicalInventoryLineMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreatePhysicalInventoryLineMvo NewCreatePhysicalInventoryLineMvo()
        {
            return new CreatePhysicalInventoryLineMvoDto();
        }

        public IMergePatchPhysicalInventoryLineMvo NewMergePatchPhysicalInventoryLineMvo()
        {
            return new MergePatchPhysicalInventoryLineMvoDto();
        }

        public IDeletePhysicalInventoryLineMvo NewDeletePhysicalInventoryLineMvo()
        {
            return new DeletePhysicalInventoryLineMvoDto();
        }
    }

    public static class PhysicalInventoryLineMvoProxyUtils
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

        public static string ToIdString(PhysicalInventoryLineId id)
        {
            var formatter = (new ValueObjectTextFormatter<PhysicalInventoryLineId>());
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

        public static IEnumerable<PhysicalInventoryLineId> ToIdCollection(IEnumerable<IPhysicalInventoryLineMvoState> states)
        {
            var ids = new List<PhysicalInventoryLineId>();
            foreach (var s in states)
            {
                ids.Add(s.PhysicalInventoryLineId);
            }
            return ids;
        }

    }

}

