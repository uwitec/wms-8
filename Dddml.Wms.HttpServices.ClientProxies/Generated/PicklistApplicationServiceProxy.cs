﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Picklist;
using Dddml.Wms.Domain.PartyRole;
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

    public partial class PicklistApplicationServiceProxy : IPicklistApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public PicklistApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public PicklistApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public PicklistApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreatePicklistDto c)
        {
            var idObj = (c as ICreatePicklist).PicklistId;
            var uriParameters = new PicklistUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistPutRequest(uriParameters, (CreatePicklistDto)c);
                
            var resp = await _ramlClient.Picklist.Put(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreatePicklistDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchPicklistDto c)
        {
            var idObj = (c as IMergePatchPicklist).PicklistId;
            var uriParameters = new PicklistUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistPatchRequest(uriParameters, (MergePatchPicklistDto)c);
            var resp = await _ramlClient.Picklist.Patch(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchPicklistDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeletePicklistDto c)
        {
            var idObj = (c as IDeletePicklist).PicklistId;
            var uriParameters = new PicklistUriParameters();
            uriParameters.Id = idObj;

            var q = new PicklistDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new PicklistDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Picklist.Delete(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeletePicklistDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IPicklistApplicationService.When(ICreatePicklist c)
        {
            this.When((CreatePicklistDto)c);
        }

        void IPicklistApplicationService.When(IMergePatchPicklist c)
        {
            this.When((MergePatchPicklistDto)c);
        }

        void IPicklistApplicationService.When(IDeletePicklist c)
        {
            this.When((DeletePicklistDto)c);
        }

        public async Task<IPicklistState> GetAsync(string picklistId)
        {
            IPicklistState state = null;
            var idObj = picklistId;
            var uriParameters = new PicklistUriParameters();
            uriParameters.Id = idObj;

            var req = new PicklistGetRequest(uriParameters);

            var resp = await _ramlClient.Picklist.Get(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToPicklistState();
            return state;
        }

        public IPicklistState Get(string picklistId)
        {
            return GetAsync(picklistId).GetAwaiter().GetResult();
        }


        public IEnumerable<IPicklistState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IPicklistState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPicklistState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPicklistState> states = null;
			var q = new PicklistsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PicklistProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PicklistProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = PicklistProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PicklistsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Picklists.Get(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPicklistState());
            return states;
        }

        public IEnumerable<IPicklistState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IPicklistState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IPicklistState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IPicklistState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPicklistState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPicklistState> states = null;
			var q = new PicklistsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PicklistProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PicklistProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = PicklistProxyUtils.GetFilterQueryValueString(filter);
            var req = new PicklistsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Picklists.Get(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPicklistState());
            return states;
        }

        public IEnumerable<IPicklistState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new PicklistsCountGetQuery();
            q.FilterTag = PicklistProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PicklistsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistsCount.Get(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new PicklistsCountGetQuery();
            q.Filter = PicklistProxyUtils.GetFilterQueryValueString(filter);
            var req = new PicklistsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PicklistsCount.Get(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IPicklistEvent> GetStateEventAsync(string picklistId, long version)
        {
            var idObj = picklistId;
            var uriParameters = new PicklistStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PicklistStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.PicklistStateEvent.Get(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IPicklistEvent GetEvent(string picklistId, long version)
        {
            return GetStateEventAsync(picklistId, version).GetAwaiter().GetResult();
        }


        public async Task<IPicklistState> GetHistoryStateAsync(string picklistId, long version)
        {
            var idObj = picklistId;
            var uriParameters = new PicklistHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PicklistHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.PicklistHistoryState.Get(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToPicklistState();
        }

        public virtual IPicklistState GetHistoryState(string picklistId, long version)
        {
            return GetHistoryStateAsync(picklistId, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IPicklistRoleState> GetPicklistRoleAsync(string picklistId, PartyRoleId partyRoleId)
        {
            var uriParameters = new PicklistRoleUriParameters();
            uriParameters.PicklistId = picklistId;
            uriParameters.PartyRoleId = ((new ValueObjectTextFormatter<PartyRoleId>())).ToString(partyRoleId);

            var req = new PicklistRoleGetRequest(uriParameters);
            var resp = await _ramlClient.PicklistRole.Get(req);
            PicklistProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToPicklistRoleState();
        }

        public virtual IPicklistRoleState GetPicklistRole(string picklistId, PartyRoleId partyRoleId)
        {
            return GetPicklistRoleAsync(picklistId, partyRoleId).GetAwaiter().GetResult();
        }

        public IEnumerable<IPicklistRoleState> GetPicklistRoles(string picklistId)
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


    public partial class PicklistApplicationServiceProxyFactory : ProxyFactoryBase, IPicklistApplicationServiceFactory
    {

        public PicklistApplicationServiceProxyFactory() : base()
        {}

        public PicklistApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IPicklistApplicationService PicklistApplicationService
        {
            get
            {
                return new PicklistApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreatePicklist NewCreatePicklist()
        {
            return new CreatePicklistDto();
        }

        public IMergePatchPicklist NewMergePatchPicklist()
        {
            return new MergePatchPicklistDto();
        }

        public IDeletePicklist NewDeletePicklist()
        {
            return new DeletePicklistDto();
        }
    }

    public static class PicklistProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IPicklistState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.PicklistId);
            }
            return ids;
        }

    }

}

