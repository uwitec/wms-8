﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
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

    public partial class InOutApplicationServiceProxy : IInOutApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public InOutApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public InOutApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public InOutApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateInOutDto c)
        {
            var idObj = (c as ICreateInOut).DocumentNumber;
            var uriParameters = new InOutUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutPutRequest(uriParameters, (CreateInOutDto)c);
                
            var resp = await _ramlClient.InOut.Put(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateInOutDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchInOutDto c)
        {
            var idObj = (c as IMergePatchInOut).DocumentNumber;
            var uriParameters = new InOutUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutPatchRequest(uriParameters, (MergePatchInOutDto)c);
            var resp = await _ramlClient.InOut.Patch(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchInOutDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteInOutDto c)
        {
            var idObj = (c as IDeleteInOut).DocumentNumber;
            var uriParameters = new InOutUriParameters();
            uriParameters.Id = idObj;

            var q = new InOutDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new InOutDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.InOut.Delete(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteInOutDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IInOutApplicationService.When(ICreateInOut c)
        {
            this.When((CreateInOutDto)c);
        }

        void IInOutApplicationService.When(IMergePatchInOut c)
        {
            this.When((MergePatchInOutDto)c);
        }

        public void When(InOutCommands.Complete c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(InOutCommands.Close c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(InOutCommands.Void c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(InOutCommands.Reverse c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(InOutCommands.AddLine c)
        {
            throw new NotImplementedException();//todo
        }

        public void When(InOutCommands.DocumentAction c)
        {
            throw new NotImplementedException();//todo
        }

        public async Task<IInOutState> GetAsync(string documentNumber)
        {
            IInOutState state = null;
            var idObj = documentNumber;
            var uriParameters = new InOutUriParameters();
            uriParameters.Id = idObj;

            var req = new InOutGetRequest(uriParameters);

            var resp = await _ramlClient.InOut.Get(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToInOutState();
            return state;
        }

        public IInOutState Get(string documentNumber)
        {
            return GetAsync(documentNumber).GetAwaiter().GetResult();
        }


        public IEnumerable<IInOutState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IInOutState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInOutState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInOutState> states = null;
			var q = new InOutsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InOutProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InOutProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = InOutProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InOutsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InOuts.Get(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInOutState());
            return states;
        }

        public IEnumerable<IInOutState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IInOutState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IInOutState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IInOutState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IInOutState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IInOutState> states = null;
			var q = new InOutsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = InOutProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = InOutProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = InOutProxyUtils.GetFilterQueryValueString(filter);
            var req = new InOutsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InOuts.Get(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToInOutState());
            return states;
        }

        public IEnumerable<IInOutState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new InOutsCountGetQuery();
            q.FilterTag = InOutProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new InOutsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InOutsCount.Get(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new InOutsCountGetQuery();
            q.Filter = InOutProxyUtils.GetFilterQueryValueString(filter);
            var req = new InOutsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.InOutsCount.Get(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IInOutEvent> GetStateEventAsync(string documentNumber, long version)
        {
            var idObj = documentNumber;
            var uriParameters = new InOutStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InOutStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.InOutStateEvent.Get(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IInOutEvent GetEvent(string documentNumber, long version)
        {
            return GetStateEventAsync(documentNumber, version).GetAwaiter().GetResult();
        }


        public async Task<IInOutState> GetHistoryStateAsync(string documentNumber, long version)
        {
            var idObj = documentNumber;
            var uriParameters = new InOutHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new InOutHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.InOutHistoryState.Get(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInOutState();
        }

        public virtual IInOutState GetHistoryState(string documentNumber, long version)
        {
            return GetHistoryStateAsync(documentNumber, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IInOutLineState> GetInOutLineAsync(string inOutDocumentNumber, string lineNumber)
        {
            var uriParameters = new InOutLineUriParameters();
            uriParameters.InOutDocumentNumber = inOutDocumentNumber;
            uriParameters.LineNumber = lineNumber;

            var req = new InOutLineGetRequest(uriParameters);
            var resp = await _ramlClient.InOutLine.Get(req);
            InOutProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToInOutLineState();
        }

        public virtual IInOutLineState GetInOutLine(string inOutDocumentNumber, string lineNumber)
        {
            return GetInOutLineAsync(inOutDocumentNumber, lineNumber).GetAwaiter().GetResult();
        }

        public IEnumerable<IInOutLineState> GetInOutLines(string inOutDocumentNumber)
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


    public partial class InOutApplicationServiceProxyFactory : ProxyFactoryBase, IInOutApplicationServiceFactory
    {

        public InOutApplicationServiceProxyFactory() : base()
        {}

        public InOutApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IInOutApplicationService InOutApplicationService
        {
            get
            {
                return new InOutApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateInOut NewCreateInOut()
        {
            return new CreateInOutDto();
        }

        public IMergePatchInOut NewMergePatchInOut()
        {
            return new MergePatchInOutDto();
        }

        public IDeleteInOut NewDeleteInOut()
        {
            return new DeleteInOutDto();
        }
    }

    public static class InOutProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IInOutState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.DocumentNumber);
            }
            return ids;
        }

    }

}

