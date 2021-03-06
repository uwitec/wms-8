﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateRamlClientProxies.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.MovementConfirmation;
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

    public partial class MovementConfirmationApplicationServiceProxy : IMovementConfirmationApplicationService
    {

        private DddmlWmsRamlClient _ramlClient;

        public MovementConfirmationApplicationServiceProxy(ProxyTemplate proxyTemplate)
            : this(proxyTemplate.GetEndpointUrl())
        {
            _ramlClient.GetAuthenticationHeaderValue = proxyTemplate.GetAuthenticationHeaderValue;
        }

        public MovementConfirmationApplicationServiceProxy(string endpointUrl)
        {
            _ramlClient = new DddmlWmsRamlClient(endpointUrl);
        }

        public MovementConfirmationApplicationServiceProxy(HttpClient httpClient)
        {
            _ramlClient = new DddmlWmsRamlClient(httpClient);
        }

        public async Task WhenAsync(CreateMovementConfirmationDto c)
        {
            var idObj = (c as ICreateMovementConfirmation).DocumentNumber;
            var uriParameters = new MovementConfirmationUriParameters();
            uriParameters.Id = idObj;

            var req = new MovementConfirmationPutRequest(uriParameters, (CreateMovementConfirmationDto)c);
                
            var resp = await _ramlClient.MovementConfirmation.Put(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(CreateMovementConfirmationDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(MergePatchMovementConfirmationDto c)
        {
            var idObj = (c as IMergePatchMovementConfirmation).DocumentNumber;
            var uriParameters = new MovementConfirmationUriParameters();
            uriParameters.Id = idObj;

            var req = new MovementConfirmationPatchRequest(uriParameters, (MergePatchMovementConfirmationDto)c);
            var resp = await _ramlClient.MovementConfirmation.Patch(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(MergePatchMovementConfirmationDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }

        public async Task WhenAsync(DeleteMovementConfirmationDto c)
        {
            var idObj = (c as IDeleteMovementConfirmation).DocumentNumber;
            var uriParameters = new MovementConfirmationUriParameters();
            uriParameters.Id = idObj;

            var q = new MovementConfirmationDeleteQuery();
            q.CommandId = c.CommandId;
            q.RequesterId = c.RequesterId;
            q.Version = Convert.ToString(c.Version);
                
            var req = new MovementConfirmationDeleteRequest(uriParameters);
            req.Query = q;

            var resp = await _ramlClient.MovementConfirmation.Delete(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
        }

        public void When(DeleteMovementConfirmationDto c)
        {
            WhenAsync(c).GetAwaiter().GetResult();
        }
		
        void IMovementConfirmationApplicationService.When(ICreateMovementConfirmation c)
        {
            this.When((CreateMovementConfirmationDto)c);
        }

        void IMovementConfirmationApplicationService.When(IMergePatchMovementConfirmation c)
        {
            this.When((MergePatchMovementConfirmationDto)c);
        }

        void IMovementConfirmationApplicationService.When(IDeleteMovementConfirmation c)
        {
            this.When((DeleteMovementConfirmationDto)c);
        }

        public void When(MovementConfirmationCommands.DocumentAction c)
        {
            throw new NotImplementedException();//todo
        }

        public async Task<IMovementConfirmationState> GetAsync(string documentNumber)
        {
            IMovementConfirmationState state = null;
            var idObj = documentNumber;
            var uriParameters = new MovementConfirmationUriParameters();
            uriParameters.Id = idObj;

            var req = new MovementConfirmationGetRequest(uriParameters);

            var resp = await _ramlClient.MovementConfirmation.Get(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
            state = (resp.Content == null) ? null : resp.Content.ToMovementConfirmationState();
            return state;
        }

        public IMovementConfirmationState Get(string documentNumber)
        {
            return GetAsync(documentNumber).GetAwaiter().GetResult();
        }


        public IEnumerable<IMovementConfirmationState> GetAll(int firstResult, int maxResults)
        {
            return Get((IDictionary<string, object>)null, null, firstResult, maxResults);
        }

        public IEnumerable<IMovementConfirmationState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IMovementConfirmationState>> GetAsync(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IMovementConfirmationState> states = null;
			var q = new MovementConfirmationsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = MovementConfirmationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = MovementConfirmationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.FilterTag = MovementConfirmationProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new MovementConfirmationsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.MovementConfirmations.Get(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToMovementConfirmationState());
            return states;
        }

        public IEnumerable<IMovementConfirmationState> Get(IEnumerable<KeyValuePair<string, object>> filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public IEnumerable<IMovementConfirmationState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return GetByProperty(propertyName, propertyValue, orders, firstResult, maxResults, null);
        }

        public IEnumerable<IMovementConfirmationState> GetByProperty(string propertyName, object propertyValue, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            var filter = Restrictions.Eq(propertyName, propertyValue);
            return Get(filter, orders, firstResult, maxResults, fields);
        }

        public virtual void Execute(object command)
        {
            ((dynamic)this).When((dynamic)command);
        }

        public IEnumerable<IMovementConfirmationState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue)
        {
            return Get(filter, orders, firstResult, maxResults, null);
        }

        public async Task<IEnumerable<IMovementConfirmationState>> GetAsync(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            IEnumerable<IMovementConfirmationState> states = null;
			var q = new MovementConfirmationsGetQuery();
			q.FirstResult = firstResult;
			q.MaxResults = maxResults;
            q.Sort = MovementConfirmationProxyUtils.GetOrdersQueryValueString(orders);
            q.Fields = MovementConfirmationProxyUtils.GetReturnedFieldsQueryValueString(fields, QueryFieldValueSeparator);
            q.Filter = MovementConfirmationProxyUtils.GetFilterQueryValueString(filter);
            var req = new MovementConfirmationsGetRequest();
            req.Query = q;
            var resp = await _ramlClient.MovementConfirmations.Get(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
            states = (resp.Content == null) ? null : resp.Content.Select(e => e.ToMovementConfirmationState());
            return states;
        }

        public IEnumerable<IMovementConfirmationState> Get(ICriterion filter, IList<string> orders = null, int firstResult = 0, int maxResults = int.MaxValue, IList<string> fields = null)
        {
            return GetAsync(filter, orders, firstResult, maxResults, fields).GetAwaiter().GetResult();
        }

        public async virtual Task<long> GetCountAsync(IEnumerable<KeyValuePair<string, object>> filter)
		{
			var q = new MovementConfirmationsCountGetQuery();
            q.FilterTag = MovementConfirmationProxyUtils.GetFilterTagQueryValueString(filter);
            var req = new MovementConfirmationsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.MovementConfirmationsCount.Get(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
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
			var q = new MovementConfirmationsCountGetQuery();
            q.Filter = MovementConfirmationProxyUtils.GetFilterQueryValueString(filter);
            var req = new MovementConfirmationsCountGetRequest();
            req.Query = q;
            var resp = await _ramlClient.MovementConfirmationsCount.Get(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
            string str = await resp.RawContent.ReadAsStringAsync();
            if (str.StartsWith("\"")) { str = str.Substring(1); }
            if (str.EndsWith("\"")) { str = str.Substring(0, str.Length - 1); }
            return long.Parse(str);
		}

        public virtual long GetCount(ICriterion filter)
		{
		    return GetCountAsync(filter).GetAwaiter().GetResult();
		}

        public async Task<IMovementConfirmationEvent> GetStateEventAsync(string documentNumber, long version)
        {
            var idObj = documentNumber;
            var uriParameters = new MovementConfirmationStateEventUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new MovementConfirmationStateEventGetRequest(uriParameters);
            var resp = await _ramlClient.MovementConfirmationStateEvent.Get(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
            return resp.Content;
        }

        public IMovementConfirmationEvent GetEvent(string documentNumber, long version)
        {
            return GetStateEventAsync(documentNumber, version).GetAwaiter().GetResult();
        }


        public async Task<IMovementConfirmationState> GetHistoryStateAsync(string documentNumber, long version)
        {
            var idObj = documentNumber;
            var uriParameters = new MovementConfirmationHistoryStateUriParameters();
            uriParameters.Id = idObj;
            uriParameters.Version = version.ToString();

            var req = new MovementConfirmationHistoryStateGetRequest(uriParameters);
            var resp = await _ramlClient.MovementConfirmationHistoryState.Get(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToMovementConfirmationState();
        }

        public virtual IMovementConfirmationState GetHistoryState(string documentNumber, long version)
        {
            return GetHistoryStateAsync(documentNumber, version).GetAwaiter().GetResult();
        }

        public async virtual Task<IMovementConfirmationLineState> GetMovementConfirmationLineAsync(string movementConfirmationDocumentNumber, string lineNumber)
        {
            var uriParameters = new MovementConfirmationLineUriParameters();
            uriParameters.MovementConfirmationDocumentNumber = movementConfirmationDocumentNumber;
            uriParameters.LineNumber = lineNumber;

            var req = new MovementConfirmationLineGetRequest(uriParameters);
            var resp = await _ramlClient.MovementConfirmationLine.Get(req);
            MovementConfirmationProxyUtils.ThrowOnHttpResponseError(resp);
            return (resp.Content == null) ? null : resp.Content.ToMovementConfirmationLineState();
        }

        public virtual IMovementConfirmationLineState GetMovementConfirmationLine(string movementConfirmationDocumentNumber, string lineNumber)
        {
            return GetMovementConfirmationLineAsync(movementConfirmationDocumentNumber, lineNumber).GetAwaiter().GetResult();
        }

        public IEnumerable<IMovementConfirmationLineState> GetMovementConfirmationLines(string movementConfirmationDocumentNumber)
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


    public partial class MovementConfirmationApplicationServiceProxyFactory : ProxyFactoryBase, IMovementConfirmationApplicationServiceFactory
    {

        public MovementConfirmationApplicationServiceProxyFactory() : base()
        {}

        public MovementConfirmationApplicationServiceProxyFactory(string endpointUrl) : base(endpointUrl)
        {}

        public IMovementConfirmationApplicationService MovementConfirmationApplicationService
        {
            get
            {
                return new MovementConfirmationApplicationServiceProxy(ProxyTemplate);
            }
        }
		
        public ICreateMovementConfirmation NewCreateMovementConfirmation()
        {
            return new CreateMovementConfirmationDto();
        }

        public IMergePatchMovementConfirmation NewMergePatchMovementConfirmation()
        {
            return new MergePatchMovementConfirmationDto();
        }

        public IDeleteMovementConfirmation NewDeleteMovementConfirmation()
        {
            return new DeleteMovementConfirmationDto();
        }
    }

    public static class MovementConfirmationProxyUtils
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

        public static IEnumerable<string> ToIdCollection(IEnumerable<IMovementConfirmationState> states)
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

