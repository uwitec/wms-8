﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Lot;
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

    public partial class LotApplicationServiceProxy : ILotApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public LotApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public LotApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public LotApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateLotDto c)
        {
            var idObj = (c as ICreateLot).LotId;
            var uriParameters = new LotUriParameters();
            uriParameters.Id = idObj;

            var req = new LotPutRequest(uriParameters, (CreateLotDto)c);
                
            var resp = await _ramlClient.Lot.Put(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateLotDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchLotDto c)
        {
            var idObj = (c as IMergePatchLot).LotId;
            var uriParameters = new LotUriParameters();
            uriParameters.Id = idObj;

            var req = new LotPatchRequest(uriParameters, (MergePatchLotDto)c);
            var resp = await _ramlClient.Lot.Patch(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchLotDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteLotDto c)
        {
            var idObj = (c as IDeleteLot).LotId;
            var uriParameters = new LotUriParameters();
            uriParameters.Id = idObj;

            var q = new LotDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new LotDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.Lot.Delete(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteLotDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void ILotApplicationService.When(ICreateLot c)
        {
            this.When((CreateLotDto)c);
        }

        void ILotApplicationService.When(IMergePatchLot c)
        {
            this.When((MergePatchLotDto)c);
        }

        void ILotApplicationService.When(IDeleteLot c)
        {
            this.When((DeleteLotDto)c);
        }

        public async Task<ILotState> GetAsync(string lotId)
        {
            ILotState state = null;
            var idObj = lotId;
            var uriParameters = new LotUriParameters();
            uriParameters.Id = idObj;

            var req = new LotGetRequest(uriParameters);

            var resp = await _ramlClient.Lot.Get(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToLotState();
            return state;
        }

        public ILotState Get(string lotId)
        {
            return GetAsync(lotId).GetAwaiter().GetResult();
        }


        public IEnumerable<ILotState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<ILotState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<ILotState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<ILotState> states = null;
			var q = new LotsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = LotProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = LotProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = LotProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new LotsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Lots.Get(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToLotState());
            return states;
        }

        public IEnumerable<ILotState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<ILotState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<ILotState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<ILotState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<ILotState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<ILotState> states = null;
			var q = new LotsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = LotProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = LotProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = LotProxyUtils.GetFilterQueryValueString(filter);
            var req = new LotsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.Lots.Get(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToLotState());
            return states;
        }

        public IEnumerable<ILotState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new LotsCountGetQuery();
            q.FilterTag = LotProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new LotsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.LotsCount.Get(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new LotsCountGetQuery();
            q.Filter = LotProxyUtils.GetFilterQueryValueString(filter);
            var req = new LotsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.LotsCount.Get(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<ILotEvent> GetStateEventAsync(string lotId, long version)
        {
            var idObj = lotId;
            var uriParameters = new LotStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new LotStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.LotStateEvent.Get(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public ILotEvent GetEvent(string lotId, long version)
        {
            return GetStateEventAsync(lotId, version).GetAwaiter().GetResult();
        }


        public async Task<ILotState> GetHistoryStateAsync(string lotId, long version)
        {
            var idObj = lotId;
            var uriParameters = new LotHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new LotHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.LotHistoryState.Get(req);
            LotProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToLotState();
        }

        public virtual ILotState GetHistoryState(string lotId, long version)
        {
            return GetHistoryStateAsync(lotId, version).GetAwaiter().GetResult();
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


    public partial class LotApplicationServiceProxyFactory : ProxyFactoryBase, ILotApplicationServiceFactory
    {

        public LotApplicationServiceProxyFactory() : base()
        {}

        public LotApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public ILotApplicationService LotApplicationService
        {
            get
            {
                return new LotApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateLot NewCreateLot()
        {
            return new CreateLotDto();
        }

        public IMergePatchLot NewMergePatchLot()
        {
            return new MergePatchLotDto();
        }

        public IDeleteLot NewDeleteLot()
        {
            return new DeleteLotDto();
        }
    }

    public static class LotProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<ILotState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.LotId);
            }
            return ids;
        }

    }

}

