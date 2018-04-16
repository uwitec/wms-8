﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategoryMember;
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

    public partial class ProductCategoryMemberApplicationServiceProxy : IProductCategoryMemberApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public ProductCategoryMemberApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public ProductCategoryMemberApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public ProductCategoryMemberApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateProductCategoryMemberDto c)
        {
            var idObj = ProductCategoryMemberProxyUtils.ToIdString((c as ICreateProductCategoryMember).ProductCategoryMemberId);
            var uriParameters = new ProductCategoryMemberUriParameters();
            uriParameters.Id = idObj;

            var req = new ProductCategoryMemberPutRequest(uriParameters, (CreateProductCategoryMemberDto)c);
                
            var resp = await _ramlClient.ProductCategoryMember.Put(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateProductCategoryMemberDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchProductCategoryMemberDto c)
        {
            var idObj = ProductCategoryMemberProxyUtils.ToIdString((c as IMergePatchProductCategoryMember).ProductCategoryMemberId);
            var uriParameters = new ProductCategoryMemberUriParameters();
            uriParameters.Id = idObj;

            var req = new ProductCategoryMemberPatchRequest(uriParameters, (MergePatchProductCategoryMemberDto)c);
            var resp = await _ramlClient.ProductCategoryMember.Patch(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchProductCategoryMemberDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteProductCategoryMemberDto c)
        {
            var idObj = ProductCategoryMemberProxyUtils.ToIdString((c as IDeleteProductCategoryMember).ProductCategoryMemberId);
            var uriParameters = new ProductCategoryMemberUriParameters();
            uriParameters.Id = idObj;

            var q = new ProductCategoryMemberDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new ProductCategoryMemberDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.ProductCategoryMember.Delete(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteProductCategoryMemberDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IProductCategoryMemberApplicationService.When(ICreateProductCategoryMember c)
        {
            this.When((CreateProductCategoryMemberDto)c);
        }

        void IProductCategoryMemberApplicationService.When(IMergePatchProductCategoryMember c)
        {
            this.When((MergePatchProductCategoryMemberDto)c);
        }

        public async Task<IProductCategoryMemberState> GetAsync(ProductCategoryMemberId productCategoryMemberId)
        {
            IProductCategoryMemberState state = null;
            var idObj = ProductCategoryMemberProxyUtils.ToIdString(productCategoryMemberId);
            var uriParameters = new ProductCategoryMemberUriParameters();
            uriParameters.Id = idObj;

            var req = new ProductCategoryMemberGetRequest(uriParameters);

            var resp = await _ramlClient.ProductCategoryMember.Get(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToProductCategoryMemberState();
            return state;
        }

        public IProductCategoryMemberState Get(ProductCategoryMemberId productCategoryMemberId)
        {
            return GetAsync(productCategoryMemberId).GetAwaiter().GetResult();
        }


        public IEnumerable<IProductCategoryMemberState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IProductCategoryMemberState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IProductCategoryMemberState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IProductCategoryMemberState> states = null;
			var q = new ProductCategoryMembersGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ProductCategoryMemberProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ProductCategoryMemberProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = ProductCategoryMemberProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ProductCategoryMembersGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ProductCategoryMembers.Get(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToProductCategoryMemberState());
            return states;
        }

        public IEnumerable<IProductCategoryMemberState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IProductCategoryMemberState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IProductCategoryMemberState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IProductCategoryMemberState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IProductCategoryMemberState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IProductCategoryMemberState> states = null;
			var q = new ProductCategoryMembersGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = ProductCategoryMemberProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = ProductCategoryMemberProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = ProductCategoryMemberProxyUtils.GetFilterQueryValueString(filter);
            var req = new ProductCategoryMembersGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ProductCategoryMembers.Get(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToProductCategoryMemberState());
            return states;
        }

        public IEnumerable<IProductCategoryMemberState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new ProductCategoryMembersCountGetQuery();
            q.FilterTag = ProductCategoryMemberProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new ProductCategoryMembersCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ProductCategoryMembersCount.Get(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new ProductCategoryMembersCountGetQuery();
            q.Filter = ProductCategoryMemberProxyUtils.GetFilterQueryValueString(filter);
            var req = new ProductCategoryMembersCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.ProductCategoryMembersCount.Get(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IProductCategoryMemberEvent> GetStateEventAsync(ProductCategoryMemberId productCategoryMemberId, long version)
        {
            var idObj = ProductCategoryMemberProxyUtils.ToIdString(productCategoryMemberId);
            var uriParameters = new ProductCategoryMemberStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ProductCategoryMemberStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.ProductCategoryMemberStateEvent.Get(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IProductCategoryMemberEvent GetEvent(ProductCategoryMemberId productCategoryMemberId, long version)
        {
            return GetStateEventAsync(productCategoryMemberId, version).GetAwaiter().GetResult();
        }


        public async Task<IProductCategoryMemberState> GetHistoryStateAsync(ProductCategoryMemberId productCategoryMemberId, long version)
        {
            var idObj = ProductCategoryMemberProxyUtils.ToIdString(productCategoryMemberId);
            var uriParameters = new ProductCategoryMemberHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new ProductCategoryMemberHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.ProductCategoryMemberHistoryState.Get(req);
            ProductCategoryMemberProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToProductCategoryMemberState();
        }

        public virtual IProductCategoryMemberState GetHistoryState(ProductCategoryMemberId productCategoryMemberId, long version)
        {
            return GetHistoryStateAsync(productCategoryMemberId, version).GetAwaiter().GetResult();
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


    public partial class ProductCategoryMemberApplicationServiceProxyFactory : ProxyFactoryBase, IProductCategoryMemberApplicationServiceFactory
    {

        public ProductCategoryMemberApplicationServiceProxyFactory() : base()
        {}

        public ProductCategoryMemberApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IProductCategoryMemberApplicationService ProductCategoryMemberApplicationService
        {
            get
            {
                return new ProductCategoryMemberApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateProductCategoryMember NewCreateProductCategoryMember()
        {
            return new CreateProductCategoryMemberDto();
        }

        public IMergePatchProductCategoryMember NewMergePatchProductCategoryMember()
        {
            return new MergePatchProductCategoryMemberDto();
        }

        public IDeleteProductCategoryMember NewDeleteProductCategoryMember()
        {
            return new DeleteProductCategoryMemberDto();
        }
    }

    public static class ProductCategoryMemberProxyUtils
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

        public static string ToIdString(ProductCategoryMemberId id)
        {
            var formatter = (new ValueObjectTextFormatter<ProductCategoryMemberId>());
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

        public static IEnumerable<ProductCategoryMemberId> ToIdCollection(IEnumerable<IProductCategoryMemberState> states)
        {
            var ids = new List<ProductCategoryMemberId>();
            foreach (var s in states)
            {
                ids.Add(s.ProductCategoryMemberId);
            }
            return ids;
        }

    }

}

