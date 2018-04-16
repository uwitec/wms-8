﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentType;
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

    public partial class ShipmentTypeApplicationServiceProxy : IShipmentTypeApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public ShipmentTypeApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public ShipmentTypeApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public ShipmentTypeApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateShipmentTypeDto c)
        {
            var idObj = (c as ICreateShipmentType).ShipmentTypeId;
            var uriParameters = new ShipmentTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentTypePutRequest(uriParameters, (CreateShipmentTypeDto)c);
                
            var resp = await _ramlClient.ShipmentType.Put(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateShipmentTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchShipmentTypeDto c)
        {
            var idObj = (c as IMergePatchShipmentType).ShipmentTypeId;
            var uriParameters = new ShipmentTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentTypePatchRequest(uriParameters, (MergePatchShipmentTypeDto)c);
            var resp = await _ramlClient.ShipmentType.Patch(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchShipmentTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteShipmentTypeDto c)
        {
            var idObj = (c as IDeleteShipmentType).ShipmentTypeId;
            var uriParameters = new ShipmentTypeUriParameters();
            uriParameters.Id = idObj;

            var q = new ShipmentTypeDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new ShipmentTypeDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.ShipmentType.Delete(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteShipmentTypeDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IShipmentTypeApplicationService.When(ICreateShipmentType c)
        {
            this.When((CreateShipmentTypeDto)c);
        }

        void IShipmentTypeApplicationService.When(IMergePatchShipmentType c)
        {
            this.When((MergePatchShipmentTypeDto)c);
        }

        public async Task<IShipmentTypeState> GetAsync(string shipmentTypeId)
        {
            IShipmentTypeState state = null;
            var idObj = shipmentTypeId;
            var uriParameters = new ShipmentTypeUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentTypeGetRequest(uriParameters);

            var resp = await _ramlClient.ShipmentType.Get(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToShipmentTypeState();
            return state;
        }

        public IShipmentTypeState Get(string shipmentTypeId)
        {
            return GetAsync(shipmentTypeId).GetAwaiter().GetResult();
        }


        public IEnumerable<IShipmentTypeState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IShipmentTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IShipmentTypeState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IShipmentTypeState> states = null;
			var q = new ShipmentTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ShipmentTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ShipmentTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = ShipmentTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ShipmentTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentTypes.Get(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToShipmentTypeState());
            return states;
        }

        public IEnumerable<IShipmentTypeState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IShipmentTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IShipmentTypeState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IShipmentTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IShipmentTypeState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IShipmentTypeState> states = null;
			var q = new ShipmentTypesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ShipmentTypeProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ShipmentTypeProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = ShipmentTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new ShipmentTypesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentTypes.Get(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToShipmentTypeState());
            return states;
        }

        public IEnumerable<IShipmentTypeState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new ShipmentTypesCountGetQuery();
            q.FilterTag = ShipmentTypeProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ShipmentTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentTypesCount.Get(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new ShipmentTypesCountGetQuery();
            q.Filter = ShipmentTypeProxyUtils.GetFilterQueryValueString(filter);
            var req = new ShipmentTypesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentTypesCount.Get(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IShipmentTypeEvent> GetStateEventAsync(string shipmentTypeId, long version)
        {
            var idObj = shipmentTypeId;
            var uriParameters = new ShipmentTypeStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ShipmentTypeStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentTypeStateEvent.Get(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IShipmentTypeEvent GetEvent(string shipmentTypeId, long version)
        {
            return GetStateEventAsync(shipmentTypeId, version).GetAwaiter().GetResult();
        }


        public async Task<IShipmentTypeState> GetHistoryStateAsync(string shipmentTypeId, long version)
        {
            var idObj = shipmentTypeId;
            var uriParameters = new ShipmentTypeHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ShipmentTypeHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentTypeHistoryState.Get(req);
            ShipmentTypeProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentTypeState();
        }

        public virtual IShipmentTypeState GetHistoryState(string shipmentTypeId, long version)
        {
            return GetHistoryStateAsync(shipmentTypeId, version).GetAwaiter().GetResult();
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


    public partial class ShipmentTypeApplicationServiceProxyFactory : ProxyFactoryBase, IShipmentTypeApplicationServiceFactory
    {

        public ShipmentTypeApplicationServiceProxyFactory() : base()
        {}

        public ShipmentTypeApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IShipmentTypeApplicationService ShipmentTypeApplicationService
        {
            get
            {
                return new ShipmentTypeApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateShipmentType NewCreateShipmentType()
        {
            return new CreateShipmentTypeDto();
        }

        public IMergePatchShipmentType NewMergePatchShipmentType()
        {
            return new MergePatchShipmentTypeDto();
        }

        public IDeleteShipmentType NewDeleteShipmentType()
        {
            return new DeleteShipmentTypeDto();
        }
    }

    public static class ShipmentTypeProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IShipmentTypeState> states)
        {
            var ids = new List<string>();
            foreach (var s in states)
            {
                ids.Add(s.ShipmentTypeId);
            }
            return ids;
        }

    }

}

