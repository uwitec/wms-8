﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackage;
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

    public partial class ShipmentPackageApplicationServiceProxy : IShipmentPackageApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public ShipmentPackageApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public ShipmentPackageApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public ShipmentPackageApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateShipmentPackageDto c)
        {
            var idObj = ShipmentPackageProxyUtils.ToIdString((c as ICreateShipmentPackage).ShipmentPackageId);
            var uriParameters = new ShipmentPackageUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentPackagePutRequest(uriParameters, (CreateShipmentPackageDto)c);
                
            var resp = await _ramlClient.ShipmentPackage.Put(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateShipmentPackageDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchShipmentPackageDto c)
        {
            var idObj = ShipmentPackageProxyUtils.ToIdString((c as IMergePatchShipmentPackage).ShipmentPackageId);
            var uriParameters = new ShipmentPackageUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentPackagePatchRequest(uriParameters, (MergePatchShipmentPackageDto)c);
            var resp = await _ramlClient.ShipmentPackage.Patch(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchShipmentPackageDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteShipmentPackageDto c)
        {
            var idObj = ShipmentPackageProxyUtils.ToIdString((c as IDeleteShipmentPackage).ShipmentPackageId);
            var uriParameters = new ShipmentPackageUriParameters();
            uriParameters.Id = idObj;

            var q = new ShipmentPackageDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new ShipmentPackageDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.ShipmentPackage.Delete(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteShipmentPackageDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IShipmentPackageApplicationService.When(ICreateShipmentPackage c)
        {
            this.When((CreateShipmentPackageDto)c);
        }

        void IShipmentPackageApplicationService.When(IMergePatchShipmentPackage c)
        {
            this.When((MergePatchShipmentPackageDto)c);
        }

        void IShipmentPackageApplicationService.When(IDeleteShipmentPackage c)
        {
            this.When((DeleteShipmentPackageDto)c);
        }

        public async Task<IShipmentPackageState> GetAsync(ShipmentPackageId shipmentPackageId)
        {
            IShipmentPackageState state = null;
            var idObj = ShipmentPackageProxyUtils.ToIdString(shipmentPackageId);
            var uriParameters = new ShipmentPackageUriParameters();
            uriParameters.Id = idObj;

            var req = new ShipmentPackageGetRequest(uriParameters);

            var resp = await _ramlClient.ShipmentPackage.Get(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToShipmentPackageState();
            return state;
        }

        public IShipmentPackageState Get(ShipmentPackageId shipmentPackageId)
        {
            return GetAsync(shipmentPackageId).GetAwaiter().GetResult();
        }


        public IEnumerable<IShipmentPackageState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IShipmentPackageState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IShipmentPackageState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IShipmentPackageState> states = null;
			var q = new ShipmentPackagesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ShipmentPackageProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ShipmentPackageProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = ShipmentPackageProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ShipmentPackagesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentPackages.Get(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToShipmentPackageState());
            return states;
        }

        public IEnumerable<IShipmentPackageState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IShipmentPackageState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IShipmentPackageState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IShipmentPackageState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IShipmentPackageState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IShipmentPackageState> states = null;
			var q = new ShipmentPackagesGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ShipmentPackageProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ShipmentPackageProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = ShipmentPackageProxyUtils.GetFilterQueryValueString(filter);
            var req = new ShipmentPackagesGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentPackages.Get(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToShipmentPackageState());
            return states;
        }

        public IEnumerable<IShipmentPackageState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new ShipmentPackagesCountGetQuery();
            q.FilterTag = ShipmentPackageProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ShipmentPackagesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentPackagesCount.Get(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new ShipmentPackagesCountGetQuery();
            q.Filter = ShipmentPackageProxyUtils.GetFilterQueryValueString(filter);
            var req = new ShipmentPackagesCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ShipmentPackagesCount.Get(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IShipmentPackageStateEvent> GetStateEventAsync(ShipmentPackageId shipmentPackageId, long version)
        {
            var idObj = ShipmentPackageProxyUtils.ToIdString(shipmentPackageId);
            var uriParameters = new ShipmentPackageStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ShipmentPackageStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentPackageStateEvent.Get(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IShipmentPackageStateEvent GetStateEvent(ShipmentPackageId shipmentPackageId, long version)
        {
            return GetStateEventAsync(shipmentPackageId, version).GetAwaiter().GetResult();
        }


        public async Task<IShipmentPackageState> GetHistoryStateAsync(ShipmentPackageId shipmentPackageId, long version)
        {
            var idObj = ShipmentPackageProxyUtils.ToIdString(shipmentPackageId);
            var uriParameters = new ShipmentPackageHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ShipmentPackageHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentPackageHistoryState.Get(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentPackageState();
        }

        public virtual IShipmentPackageState GetHistoryState(ShipmentPackageId shipmentPackageId, long version)
        {
            return GetHistoryStateAsync(shipmentPackageId, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IShipmentPackageContentState> GetShipmentPackageContentAsync(ShipmentPackageId shipmentPackageId, string shipmentItemSeqId)
        {
            var uriParameters = new ShipmentPackageContentUriParameters();
            uriParameters.ShipmentPackageId = ((new ValueObjectTextFormatter<ShipmentPackageId>())).ToString(shipmentPackageId);
            uriParameters.ShipmentItemSeqId = shipmentItemSeqId;

            var req = new ShipmentPackageContentGetRequest(uriParameters);
            var resp = await _ramlClient.ShipmentPackageContent.Get(req);
            ShipmentPackageProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToShipmentPackageContentState();
        }

        public virtual IShipmentPackageContentState GetShipmentPackageContent(ShipmentPackageId shipmentPackageId, string shipmentItemSeqId)
        {
            return GetShipmentPackageContentAsync(shipmentPackageId, shipmentItemSeqId).GetAwaiter().GetResult();
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


    public partial class ShipmentPackageApplicationServiceProxyFactory : ProxyFactoryBase, IShipmentPackageApplicationServiceFactory
    {

        public ShipmentPackageApplicationServiceProxyFactory() : base()
        {}

        public ShipmentPackageApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IShipmentPackageApplicationService ShipmentPackageApplicationService
        {
            get
            {
                return new ShipmentPackageApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateShipmentPackage NewCreateShipmentPackage()
        {
            return new CreateShipmentPackageDto();
        }

        public IMergePatchShipmentPackage NewMergePatchShipmentPackage()
        {
            return new MergePatchShipmentPackageDto();
        }

        public IDeleteShipmentPackage NewDeleteShipmentPackage()
        {
            return new DeleteShipmentPackageDto();
        }
    }

    public static class ShipmentPackageProxyUtils
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

        public static string ToIdString(ShipmentPackageId id)
        {
            var formatter = (new ValueObjectTextFormatter<ShipmentPackageId>());
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

        public static IEnumerable<ShipmentPackageId> ToIdCollection(IEnumerable<IShipmentPackageState> states)
        {
            var ids = new List<ShipmentPackageId>();
            foreach (var s in states)
            {
                ids.Add(s.ShipmentPackageId);
            }
            return ids;
        }

    }

}

