﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrganizationStructureType;
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

    public partial class OrganizationStructureTypeApplicationServiceProxy : IOrganizationStructureTypeApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public OrganizationStructureTypeApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public OrganizationStructureTypeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public OrganizationStructureTypeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateOrganizationStructureTypeDto c)
        {
            var idObj = (c as ICreateOrganizationStructureType).Id;
            var uriParameters = new OrganizationStructureTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationStructureTypePutRequest(uriParameters, (CreateOrganizationStructureTypeDto)c);
                
            var resp = await _ramlClient.OrganizationStructureType.Put(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateOrganizationStructureTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchOrganizationStructureTypeDto c)
        {
            var idObj = (c as IMergePatchOrganizationStructureType).Id;
            var uriParameters = new OrganizationStructureTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationStructureTypePatchRequest(uriParameters, (MergePatchOrganizationStructureTypeDto)c);
            var resp = await _ramlClient.OrganizationStructureType.Patch(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchOrganizationStructureTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteOrganizationStructureTypeDto c)
        {
            var idObj = (c as IDeleteOrganizationStructureType).Id;
            var uriParameters = new OrganizationStructureTypeUriParameters();
            uriParameters.Id = idObj;

            var q = new OrganizationStructureTypeDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new OrganizationStructureTypeDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.OrganizationStructureType.Delete(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteOrganizationStructureTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IOrganizationStructureTypeApplicationService.When(ICreateOrganizationStructureType c)
        {
            this.When((CreateOrganizationStructureTypeDto)c);
        }

        void IOrganizationStructureTypeApplicationService.When(IMergePatchOrganizationStructureType c)
        {
            this.When((MergePatchOrganizationStructureTypeDto)c);
        }

        void IOrganizationStructureTypeApplicationService.When(IDeleteOrganizationStructureType c)
        {
            this.When((DeleteOrganizationStructureTypeDto)c);
        }

        public async Task<IOrganizationStructureTypeState> GetAsync(string id)
        {
            IOrganizationStructureTypeState state = null;
            var idObj = id;
            var uriParameters = new OrganizationStructureTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new OrganizationStructureTypeGetRequest(uriParameters);

            var resp = await _ramlClient.OrganizationStructureType.Get(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToOrganizationStructureTypeState();
            return state;
        }

        public IOrganizationStructureTypeState Get(string id)
        {
            return GetAsync(id).GetAwaiter().GetResult();
        }


        public IEnumerable<IOrganizationStructureTypeState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IOrganizationStructureTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IOrganizationStructureTypeState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationStructureTypeState> states = null;
			var q = new OrganizationStructureTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationStructureTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationStructureTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = OrganizationStructureTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationStructureTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.OrganizationStructureTypes.Get(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToOrganizationStructureTypeState());
            return states;
        }

        public IEnumerable<IOrganizationStructureTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IOrganizationStructureTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IOrganizationStructureTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IOrganizationStructureTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IOrganizationStructureTypeState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IOrganizationStructureTypeState> states = null;
			var q = new OrganizationStructureTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = OrganizationStructureTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = OrganizationStructureTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = OrganizationStructureTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationStructureTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.OrganizationStructureTypes.Get(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToOrganizationStructureTypeState());
            return states;
        }

        public IEnumerable<IOrganizationStructureTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new OrganizationStructureTypesCountGetQuery();
            q.FilterTag = OrganizationStructureTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new OrganizationStructureTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.OrganizationStructureTypesCount.Get(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new OrganizationStructureTypesCountGetQuery();
            q.Filter = OrganizationStructureTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new OrganizationStructureTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.OrganizationStructureTypesCount.Get(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IOrganizationStructureTypeEvent> GetStateEventAsync(string id, long version)
        {
            var idObj = id;
            var uriParameters = new OrganizationStructureTypeStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new OrganizationStructureTypeStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.OrganizationStructureTypeStateEvent.Get(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IOrganizationStructureTypeEvent GetEvent(string id, long version)
        {
            return GetStateEventAsync(id, version).GetAwaiter().GetResult();
        }


        public async Task<IOrganizationStructureTypeState> GetHistoryStateAsync(string id, long version)
        {
            var idObj = id;
            var uriParameters = new OrganizationStructureTypeHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new OrganizationStructureTypeHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.OrganizationStructureTypeHistoryState.Get(req);
            OrganizationStructureTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToOrganizationStructureTypeState();
        }

        public virtual IOrganizationStructureTypeState GetHistoryState(string id, long version)
        {
            return GetHistoryStateAsync(id, version).GetAwaiter().GetResult();
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


    public partial class OrganizationStructureTypeApplicationServiceProxyFactory : ProxyFactoryBase, IOrganizationStructureTypeApplicationServiceFactory
    {

        public OrganizationStructureTypeApplicationServiceProxyFactory() : base()
        {}

        public OrganizationStructureTypeApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IOrganizationStructureTypeApplicationService OrganizationStructureTypeApplicationService
        {
            get
            {
                return new OrganizationStructureTypeApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateOrganizationStructureType NewCreateOrganizationStructureType()
        {
            return new CreateOrganizationStructureTypeDto();
        }

        public IMergePatchOrganizationStructureType NewMergePatchOrganizationStructureType()
        {
            return new MergePatchOrganizationStructureTypeDto();
        }

        public IDeleteOrganizationStructureType NewDeleteOrganizationStructureType()
        {
            return new DeleteOrganizationStructureTypeDto();
        }
    }

    public static class OrganizationStructureTypeProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IOrganizationStructureTypeState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.Id);
            }
            return ids;
        }

    }

}

