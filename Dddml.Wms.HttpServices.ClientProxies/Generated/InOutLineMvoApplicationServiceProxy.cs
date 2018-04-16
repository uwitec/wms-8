﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOutLineMvo;
using Dddml.Wms.Domain.InOut;
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

    public partial class InOutLineMvoApplicationServiceProxy : IInOutLineMvoApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public InOutLineMvoApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public InOutLineMvoApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public InOutLineMvoApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateInOutLineMvoDto c)
        {
            var idObj = InOutLineMvoProxyUtils.ToIdString((c as ICreateInOutLineMvo).InOutLineId);
            var uriParameters = new InOutLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutLineMvoPutRequest(uriParameters, (CreateInOutLineMvoDto)c);
                
            var resp = await _ramlClient.InOutLineMvo.Put(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateInOutLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchInOutLineMvoDto c)
        {
            var idObj = InOutLineMvoProxyUtils.ToIdString((c as IMergePatchInOutLineMvo).InOutLineId);
            var uriParameters = new InOutLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutLineMvoPatchRequest(uriParameters, (MergePatchInOutLineMvoDto)c);
            var resp = await _ramlClient.InOutLineMvo.Patch(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchInOutLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteInOutLineMvoDto c)
        {
            var idObj = InOutLineMvoProxyUtils.ToIdString((c as IDeleteInOutLineMvo).InOutLineId);
            var uriParameters = new InOutLineMvoUriParameters();
            uriParameters.Id = idObj;

            var q = new InOutLineMvoDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.InOutVersion);
                
            var req = new InOutLineMvoDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.InOutLineMvo.Delete(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteInOutLineMvoDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IInOutLineMvoApplicationService.When(ICreateInOutLineMvo c)
        {
            this.When((CreateInOutLineMvoDto)c);
        }

        void IInOutLineMvoApplicationService.When(IMergePatchInOutLineMvo c)
        {
            this.When((MergePatchInOutLineMvoDto)c);
        }

        void IInOutLineMvoApplicationService.When(IDeleteInOutLineMvo c)
        {
            this.When((DeleteInOutLineMvoDto)c);
        }

        public async Task<IInOutLineMvoState> GetAsync(InOutLineId inOutLineId)
        {
            IInOutLineMvoState state = null;
            var idObj = InOutLineMvoProxyUtils.ToIdString(inOutLineId);
            var uriParameters = new InOutLineMvoUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutLineMvoGetRequest(uriParameters);

            var resp = await _ramlClient.InOutLineMvo.Get(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToInOutLineMvoState();
            return state;
        }

        public IInOutLineMvoState Get(InOutLineId inOutLineId)
        {
            return GetAsync(inOutLineId).GetAwaiter().GetResult();
        }


        public IEnumerable<IInOutLineMvoState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IInOutLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInOutLineMvoState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInOutLineMvoState> states = null;
			var q = new InOutLineMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InOutLineMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InOutLineMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = InOutLineMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InOutLineMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InOutLineMvos.Get(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInOutLineMvoState());
            return states;
        }

        public IEnumerable<IInOutLineMvoState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IInOutLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInOutLineMvoState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IInOutLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInOutLineMvoState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInOutLineMvoState> states = null;
			var q = new InOutLineMvosGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InOutLineMvoProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InOutLineMvoProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = InOutLineMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new InOutLineMvosGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InOutLineMvos.Get(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInOutLineMvoState());
            return states;
        }

        public IEnumerable<IInOutLineMvoState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new InOutLineMvosCountGetQuery();
            q.FilterTag = InOutLineMvoProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InOutLineMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InOutLineMvosCount.Get(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new InOutLineMvosCountGetQuery();
            q.Filter = InOutLineMvoProxyUtils.GetFilterQueryValueString(filter);
            var req = new InOutLineMvosCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InOutLineMvosCount.Get(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IInOutLineMvoEvent> GetStateEventAsync(InOutLineId inOutLineId, long version)
        {
            var idObj = InOutLineMvoProxyUtils.ToIdString(inOutLineId);
            var uriParameters = new InOutLineMvoStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InOutLineMvoStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.InOutLineMvoStateEvent.Get(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IInOutLineMvoEvent GetEvent(InOutLineId inOutLineId, long version)
        {
            return GetStateEventAsync(inOutLineId, version).GetAwaiter().GetResult();
        }


        public async Task<IInOutLineMvoState> GetHistoryStateAsync(InOutLineId inOutLineId, long version)
        {
            var idObj = InOutLineMvoProxyUtils.ToIdString(inOutLineId);
            var uriParameters = new InOutLineMvoHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InOutLineMvoHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.InOutLineMvoHistoryState.Get(req);
            InOutLineMvoProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInOutLineMvoState();
        }

        public virtual IInOutLineMvoState GetHistoryState(InOutLineId inOutLineId, long version)
        {
            return GetHistoryStateAsync(inOutLineId, version).GetAwaiter().GetResult();
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


    public partial class InOutLineMvoApplicationServiceProxyFactory : ProxyFactoryBase, IInOutLineMvoApplicationServiceFactory
    {

        public InOutLineMvoApplicationServiceProxyFactory() : base()
        {}

        public InOutLineMvoApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IInOutLineMvoApplicationService InOutLineMvoApplicationService
        {
            get
            {
                return new InOutLineMvoApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateInOutLineMvo NewCreateInOutLineMvo()
        {
            return new CreateInOutLineMvoDto();
        }

        public IMergePatchInOutLineMvo NewMergePatchInOutLineMvo()
        {
            return new MergePatchInOutLineMvoDto();
        }

        public IDeleteInOutLineMvo NewDeleteInOutLineMvo()
        {
            return new DeleteInOutLineMvoDto();
        }
    }

    public static class InOutLineMvoProxyUtils
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

        public static string ToIdString(InOutLineId id)
        {
            var formatter = (new ValueObjectTextFormatter<InOutLineId>());
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

        public static IEnumerable<InOutLineId> ToIdCollection(IEnumerable<IInOutLineMvoState> states)
        {
            var ids = new List<InOutLineId>();
            foreach (var s in states)
            {
                ids.Add(s.InOutLineId);
            }
            return ids;
        }

    }

}

