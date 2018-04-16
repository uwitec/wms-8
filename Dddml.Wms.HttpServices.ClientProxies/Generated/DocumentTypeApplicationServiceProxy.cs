﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.DocumentType;
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

    public partial class DocumentTypeApplicationServiceProxy : IDocumentTypeApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public DocumentTypeApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public DocumentTypeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public DocumentTypeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateDocumentTypeDto c)
        {
            var idObj = (c as ICreateDocumentType).DocumentTypeId;
            var uriParameters = new DocumentTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new DocumentTypePutRequest(uriParameters, (CreateDocumentTypeDto)c);
                
            var resp = await _ramlClient.DocumentType.Put(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateDocumentTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchDocumentTypeDto c)
        {
            var idObj = (c as IMergePatchDocumentType).DocumentTypeId;
            var uriParameters = new DocumentTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new DocumentTypePatchRequest(uriParameters, (MergePatchDocumentTypeDto)c);
            var resp = await _ramlClient.DocumentType.Patch(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchDocumentTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteDocumentTypeDto c)
        {
            var idObj = (c as IDeleteDocumentType).DocumentTypeId;
            var uriParameters = new DocumentTypeUriParameters();
            uriParameters.Id = idObj;

            var q = new DocumentTypeDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new DocumentTypeDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.DocumentType.Delete(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteDocumentTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IDocumentTypeApplicationService.When(ICreateDocumentType c)
        {
            this.When((CreateDocumentTypeDto)c);
        }

        void IDocumentTypeApplicationService.When(IMergePatchDocumentType c)
        {
            this.When((MergePatchDocumentTypeDto)c);
        }

        void IDocumentTypeApplicationService.When(IDeleteDocumentType c)
        {
            this.When((DeleteDocumentTypeDto)c);
        }

        public async Task<IDocumentTypeState> GetAsync(string documentTypeId)
        {
            IDocumentTypeState state = null;
            var idObj = documentTypeId;
            var uriParameters = new DocumentTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new DocumentTypeGetRequest(uriParameters);

            var resp = await _ramlClient.DocumentType.Get(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToDocumentTypeState();
            return state;
        }

        public IDocumentTypeState Get(string documentTypeId)
        {
            return GetAsync(documentTypeId).GetAwaiter().GetResult();
        }


        public IEnumerable<IDocumentTypeState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IDocumentTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IDocumentTypeState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IDocumentTypeState> states = null;
			var q = new DocumentTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = DocumentTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = DocumentTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = DocumentTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new DocumentTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.DocumentTypes.Get(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToDocumentTypeState());
            return states;
        }

        public IEnumerable<IDocumentTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IDocumentTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IDocumentTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IDocumentTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IDocumentTypeState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IDocumentTypeState> states = null;
			var q = new DocumentTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = DocumentTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = DocumentTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = DocumentTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new DocumentTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.DocumentTypes.Get(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToDocumentTypeState());
            return states;
        }

        public IEnumerable<IDocumentTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new DocumentTypesCountGetQuery();
            q.FilterTag = DocumentTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new DocumentTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.DocumentTypesCount.Get(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new DocumentTypesCountGetQuery();
            q.Filter = DocumentTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new DocumentTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.DocumentTypesCount.Get(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IDocumentTypeEvent> GetStateEventAsync(string documentTypeId, long version)
        {
            var idObj = documentTypeId;
            var uriParameters = new DocumentTypeStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new DocumentTypeStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.DocumentTypeStateEvent.Get(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IDocumentTypeEvent GetEvent(string documentTypeId, long version)
        {
            return GetStateEventAsync(documentTypeId, version).GetAwaiter().GetResult();
        }


        public async Task<IDocumentTypeState> GetHistoryStateAsync(string documentTypeId, long version)
        {
            var idObj = documentTypeId;
            var uriParameters = new DocumentTypeHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new DocumentTypeHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.DocumentTypeHistoryState.Get(req);
            DocumentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToDocumentTypeState();
        }

        public virtual IDocumentTypeState GetHistoryState(string documentTypeId, long version)
        {
            return GetHistoryStateAsync(documentTypeId, version).GetAwaiter().GetResult();
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


    public partial class DocumentTypeApplicationServiceProxyFactory : ProxyFactoryBase, IDocumentTypeApplicationServiceFactory
    {

        public DocumentTypeApplicationServiceProxyFactory() : base()
        {}

        public DocumentTypeApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IDocumentTypeApplicationService DocumentTypeApplicationService
        {
            get
            {
                return new DocumentTypeApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateDocumentType NewCreateDocumentType()
        {
            return new CreateDocumentTypeDto();
        }

        public IMergePatchDocumentType NewMergePatchDocumentType()
        {
            return new MergePatchDocumentTypeDto();
        }

        public IDeleteDocumentType NewDeleteDocumentType()
        {
            return new DeleteDocumentTypeDto();
        }
    }

    public static class DocumentTypeProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IDocumentTypeState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.DocumentTypeId);
            }
            return ids;
        }

    }

}

