﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dddml.Wms.HttpServices.ClientProxies.Raml;
using Dddml.Wms.HttpServices.ClientProxies.Raml.Models;
using System.Text;
using System.ComponentModel;
using RAML.Api.Core;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;


namespace Dddml.Wms.HttpServices.ClientProxies
{

    public partial class AttributeApplicationServiceProxy : IAttributeApplicationService
    {


        private DddmlWmsRamlClient _ramlClient;

        public AttributeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public AttributeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public void When(CreateAttributeDto c)
        {
            var idObj = ((c as ICreateAttribute).AttributeId);
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributePutRequest(uriParameters, (CreateAttributeDto)c);
                
            var resp = _ramlClient.Attribute.Put(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchAttributeDto c)
        {
            var idObj = ((c as IMergePatchAttribute).AttributeId);
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributePatchRequest(uriParameters, (MergePatchAttributeDto)c);
            var resp = _ramlClient.Attribute.Patch(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteAttributeDto c)
        {
            //Action act = async () =>
            //{
            var idObj = ((c as IDeleteAttribute).AttributeId);
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var q = new AttributeDeleteQuery();
            q.CommandId = c.CommandId;
                
            var req = new AttributeDeleteRequest(uriParameters);
            req.Query = q;

            var resp = _ramlClient.Attribute.Delete(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            //};
            //act();
        }
		
        void IAttributeApplicationService.When(ICreateAttribute c)
        {
            this.When((CreateAttributeDto)c);
        }

        void IAttributeApplicationService.When(IMergePatchAttribute c)
        {
            this.When((MergePatchAttributeDto)c);
        }

        void IAttributeApplicationService.When(IDeleteAttribute c)
        {
            this.When((DeleteAttributeDto)c);
        }

        public IAttributeState Get(string attributeId)
        {
            IAttributeState state = null;
            var idObj = (attributeId);
            var uriParameters = new AttributeUriParameters();
            uriParameters.Id = idObj;

            var req = new AttributeGetRequest(uriParameters);

            var resp = _ramlClient.Attribute.Get(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            state = resp.Content;
            return state;
        }

        public IEnumerable<IAttributeState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IAttributeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeState> states = null;
			var q = new AttributesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = AttributeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributesGetRequest();
            req.Query = q;
            var resp = _ramlClient.Attributes.Get(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }


        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IAttributeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IAttributeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IAttributeState> states = null;
			var q = new AttributesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = AttributeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = AttributeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = AttributeProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributesGetRequest();
            req.Query = q;
            var resp = _ramlClient.Attributes.Get(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            states = resp.Content;
            return states;
        }

        public virtual long GetCount(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new AttributesCountGetQuery();
            q.FilterTag = AttributeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new AttributesCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.AttributesCount.Get(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public virtual long GetCount(ICriterion filter)
		{
			var q = new AttributesCountGetQuery();
            q.Filter = AttributeProxyUtils.GetFilterQueryValueString(filter);
            var req = new AttributesCountGetRequest();
            req.Query = q;
            var resp = _ramlClient.AttributesCount.Get(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            return long.Parse(resp.RawContent.ReadAsStringAsync().GetAwaiter().GetResult());
		}

        public IAttributeStateEvent GetStateEvent(string attributeId, long version)
        {
            var idObj = (attributeId);
            var uriParameters = new AttributeStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new AttributeStateEventGetRequest(uriParameters);
            var resp = _ramlClient.AttributeStateEvent.Get(req).GetAwaiter().GetResult();
            AttributeProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
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


    public partial class AttributeApplicationServiceProxyFactory : IAttributeApplicationServiceFactory
    {

        private string _endpointUrl;

        public AttributeApplicationServiceProxyFactory(string endpointUrl)
        {
            this._endpointUrl = endpointUrl;
        }

        public IAttributeApplicationService AttributeApplicationService
        {
            get
            {
                return new AttributeApplicationServiceProxy(_endpointUrl);
            }
        }

        public ICreateAttribute NewCreateAttribute()
        {
            return new CreateAttributeDto();
        }

        public IMergePatchAttribute NewMergePatchAttribute()
        {
            return new MergePatchAttributeDto();
        }

        public IDeleteAttribute NewDeleteAttribute()
        {
            return new DeleteAttributeDto();
        }
    }

    public static class AttributeProxyUtils
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
                throw new NotSupportedException();
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
    }

}

