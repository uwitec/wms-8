﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;
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

    public partial class PartyApplicationServiceProxy : IPartyApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public PartyApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public PartyApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public PartyApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreatePartyDto c)
        {
            var idObj = (c as ICreateParty).PartyId;
            var uriParameters = new PartyUriParameters();
            uriParameters.Id = idObj;

            var req = new PartyPutRequest(uriParameters, (CreatePartyDto)c);
                
            var resp = await _ramlClient.Party.Put(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreatePartyDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchPartyDto c)
        {
            var idObj = (c as IMergePatchParty).PartyId;
            var uriParameters = new PartyUriParameters();
            uriParameters.Id = idObj;

            var req = new PartyPatchRequest(uriParameters, (MergePatchPartyDto)c);
            var resp = await _ramlClient.Party.Patch(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchPartyDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeletePartyDto c)
        {
            var idObj = (c as IDeleteParty).PartyId;
            var uriParameters = new PartyUriParameters();
            uriParameters.Id = idObj;

            var q = new PartyDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new PartyDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Party.Delete(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeletePartyDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IPartyApplicationService.When(ICreateParty c)
        {
            this.When((CreatePartyDto)c);
        }

        void IPartyApplicationService.When(IMergePatchParty c)
        {
            this.When((MergePatchPartyDto)c);
        }

        void IPartyApplicationService.When(IDeleteParty c)
        {
            this.When((DeletePartyDto)c);
        }

        public async Task<IPartyState> GetAsync(string partyId)
        {
            IPartyState state = null;
            var idObj = partyId;
            var uriParameters = new PartyUriParameters();
            uriParameters.Id = idObj;

            var req = new PartyGetRequest(uriParameters);

            var resp = await _ramlClient.Party.Get(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToPartyState();
            return state;
        }

        public IPartyState Get(string partyId)
        {
            return GetAsync(partyId).GetAwaiter().GetResult();
        }


        public IEnumerable<IPartyState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IPartyState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPartyState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPartyState> states = null;
			var q = new PartiesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PartyProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PartyProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = PartyProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PartiesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Parties.Get(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPartyState());
            return states;
        }

        public IEnumerable<IPartyState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IPartyState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IPartyState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IPartyState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IPartyState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IPartyState> states = null;
			var q = new PartiesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = PartyProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = PartyProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = PartyProxyUtils.GetFilterQueryValueString(filter);
            var req = new PartiesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Parties.Get(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToPartyState());
            return states;
        }

        public IEnumerable<IPartyState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new PartiesCountGetQuery();
            q.FilterTag = PartyProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new PartiesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PartiesCount.Get(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new PartiesCountGetQuery();
            q.Filter = PartyProxyUtils.GetFilterQueryValueString(filter);
            var req = new PartiesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.PartiesCount.Get(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public virtual IEnumerable<T> GetAll<T>(int firstResult, int maxResults) where T : class, IPartyState
        { throw new NotImplementedException(); }//todo

        public virtual IEnumerable<T> Get<T>(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue) where T : class, IPartyState
        { throw new NotImplementedException(); }//todo

        public virtual IEnumerable<T> Get<T>(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue) where T : class, IPartyState
        { throw new NotImplementedException(); }//todo

        public virtual IEnumerable<T> GetByProperty<T>(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue) where T : class, IPartyState
        { throw new NotImplementedException(); }//todo

        public virtual long GetCount<T>(IEnumerable<KeyValuePair<string, object>> filter) where T : class, IPartyState
        { throw new NotImplementedException(); }//todo

        public virtual long GetCount<T>(ICriterion filter) where T : class, IPartyState
        { throw new NotImplementedException(); }//todo

        public async Task<IPartyEvent> GetStateEventAsync(string partyId, long version)
        {
            var idObj = partyId;
            var uriParameters = new PartyStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PartyStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.PartyStateEvent.Get(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IPartyEvent GetEvent(string partyId, long version)
        {
            return GetStateEventAsync(partyId, version).GetAwaiter().GetResult();
        }


        public async Task<IPartyState> GetHistoryStateAsync(string partyId, long version)
        {
            var idObj = partyId;
            var uriParameters = new PartyHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new PartyHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.PartyHistoryState.Get(req);
            PartyProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToPartyState();
        }

        public virtual IPartyState GetHistoryState(string partyId, long version)
        {
            return GetHistoryStateAsync(partyId, version).GetAwaiter().GetResult();
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


    public partial class PartyApplicationServiceProxyFactory : ProxyFactoryBase, IPartyApplicationServiceFactory
    {

        public PartyApplicationServiceProxyFactory() : base()
        {}

        public PartyApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IPartyApplicationService PartyApplicationService
        {
            get
            {
                return new PartyApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateParty NewCreateParty()
        {
            return new CreatePartyDto();
        }

        public IMergePatchParty NewMergePatchParty()
        {
            return new MergePatchPartyDto();
        }

        public IDeleteParty NewDeleteParty()
        {
            return new DeletePartyDto();
        }
    }

    public static class PartyProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IPartyState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.PartyId);
            }
            return ids;
        }

    }

}

