﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using NodaMoney;
using Dddml.Wms.Domain.Metadata;
using Dddml.Wms.HttpServices.Filters;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json.Linq;
using Dddml.Support.Criterion;

namespace Dddml.Wms.HttpServices.ApiControllers
{

    [RoutePrefix("api/InOutLineMvos")][Authorize]
    public partial class InOutLineMvosController : ApiController
    {

        IInOutLineMvoApplicationService _inOutLineMvoApplicationService = ApplicationContext.Current["InOutLineMvoApplicationService"] as IInOutLineMvoApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IInOutLineMvoStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IInOutLineMvoState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _inOutLineMvoApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                    , InOutLineMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _inOutLineMvoApplicationService.Get(InOutLineMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , InOutLineMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IInOutLineMvoStateDto>();
            foreach (var s in states)
            {
                var dto = s is InOutLineMvoStateDto ? (InOutLineMvoStateDto)s : new InOutLineMvoStateDto((InOutLineMvoState)s);
                if (String.IsNullOrWhiteSpace(fields))
                {
                    dto.AllFieldsReturned = true;
                }
                else
                {
                    dto.ReturnedFieldsString = fields;
                }
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IInOutLineMvoStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = InOutLineMvosControllerUtils.ParseIdString(id);
            var state = (InOutLineMvoState)_inOutLineMvoApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new InOutLineMvoStateDto(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


        [Route("_count")]
        [HttpGet]
        public long GetCount(string filter = null)
        {
          try
          {
            long count = 0;
            if (!String.IsNullOrWhiteSpace(filter))
            {
                count = _inOutLineMvoApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver()));
            }
            else 
            {
                count = _inOutLineMvoApplicationService.GetCount(InOutLineMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateInOutLineMvoDto value)
        {
          try {
            InOutLineMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _inOutLineMvoApplicationService.When(value as ICreateInOutLineMvo);
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchInOutLineMvoDto value)
        {
          try {
            InOutLineMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _inOutLineMvoApplicationService.When(value as IMergePatchInOutLineMvo);
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteInOutLineMvoDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.InOutVersion = (long)Convert.ChangeType(version, typeof(long));
            InOutLineMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _inOutLineMvoApplicationService.When(value as IDeleteInOutLineMvo);
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadata> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadata>();
            foreach (var p in InOutLineMvoMetadata.Instance.Properties)
            {
                if (p.IsFilteringProperty)
                {
                    filtering.Add(p);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public InOutLineMvoStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = InOutLineMvosControllerUtils.ParseIdString(id);
            var conv = new InOutLineMvoStateEventDtoConverter();
            var se = _inOutLineMvoApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToInOutLineMvoStateEventDto(se);
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IInOutLineMvoStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = InOutLineMvosControllerUtils.ParseIdString(id);
            var state = (InOutLineMvoState)_inOutLineMvoApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new InOutLineMvoStateDto(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = InOutLineMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


		// /////////////////////////////////////////////////

        protected virtual string QueryOrderSeparator
        {
            get { return ","; }
        }

        // ////////////////////////////////

        private class ApiControllerTypeConverter : Dddml.Support.Criterion.ITypeConverter
        {
            public T ConvertFromString<T>(string text)
            {
                return (T)ApplicationContext.Current.TypeConverter.ConvertFromString(typeof(T), text);
            }

            public object ConvertFromString(Type type, string text)
            {
                return ApplicationContext.Current.TypeConverter.ConvertFromString(type, text);
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

        private class PropertyTypeResolver : IPropertyTypeResolver
        {

            public Type ResolveTypeByPropertyName(string propertyName)
            {
                return InOutLineMvosControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class InOutLineMvosControllerUtils
    {

        public static HttpResponseMessage GetErrorHttpResponseMessage(Exception ex)
        {
            var errorName = ex.GetType().Name;
            var errorMessage = ex.Message;
            if (ex is DomainError)
            {
                DomainError de = ex as DomainError;
                errorName = de.Name;
                errorMessage = de.Message;
            }
            else
            {
                //改进??
                errorMessage = String.IsNullOrWhiteSpace(ex.Message) ? String.Empty : ex.Message.Substring(0, (ex.Message.Length > 140) ? 140 : ex.Message.Length);
            }
            dynamic content = new JObject();
            content.ErrorName = errorName;
            content.ErrorMessage = errorMessage;
            var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new ObjectContent<JObject>(content as JObject, new JsonMediaTypeFormatter()),
                ReasonPhrase = "Server Error"
            };
            return response;
        }

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteInOutLineMvoDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.InOutLineId == null)
            {
                value.InOutLineId = new InOutLineIdDtoWrapper(idObj);
            }
            else if (!((ICreateOrMergePatchOrDeleteInOutLineMvo)value).InOutLineId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.InOutLineId);
            }
        }

        public static InOutLineId ParseIdString(string idString)
        {
            var formatter = new InOutLineIdFlattenedDtoFormatter();
            var idDto = formatter.Parse(idString);
            var rId = idDto.ToInOutLineId();
            return rId;
        }

        public static string GetFilterPropertyName(string fieldName)
        {
            if (String.Equals(fieldName, "sort", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "firstResult", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "maxResults", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "fields", StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }
            if (InOutLineMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(fieldName))
            {
                var p = InOutLineMvoMetadata.Instance.PropertyMetadataDictionary[fieldName];
                if (p.IsFilteringProperty)
                {
                    var propertyName = fieldName;
                    if (p.IsDerived)
                    {
                        propertyName = p.DerivedFrom;
                    }
                    return propertyName;
                }
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (InOutLineMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return InOutLineMvoMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
            }
            return typeof(string);
        }

        public static IDictionary<string, object> GetQueryFilterDictionary(IEnumerable<KeyValuePair<string, string>> queryNameValuePairs)
        {
            var filter = new Dictionary<string, object>();
            foreach (var p in queryNameValuePairs)
            {
                var pName = GetFilterPropertyName(p.Key);
                if (!String.IsNullOrWhiteSpace(pName))
                {
                    Type type = GetFilterPropertyType(pName);
                    var pValue = ApplicationContext.Current.TypeConverter.ConvertFromString(type, p.Value);
                    filter.Add(pName, pValue);
                }
            }
            return filter;
        }

        public static IList<string> GetQueryOrders(string str, string separator)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return new string[0];
            }
            var arr = str.Split(new string[] { separator }, StringSplitOptions.RemoveEmptyEntries);
            var orders = new List<string>();
            foreach (var a in arr)
            {
                orders.Add(a.Trim());
            }
            return orders;
        }

        public static IEnumerable<IInOutLineMvoStateDto> ToInOutLineMvoStateDtoCollection(IEnumerable<InOutLineId> ids)
        {
            var states = new List<InOutLineMvoStateDto>();
            foreach (var id in ids)
            {
                var dto = new InOutLineMvoStateDto();
                dto.InOutLineId = new InOutLineIdDtoWrapper(id);
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IInOutLineMvoState> ToInOutLineMvoStateCollection(IEnumerable<InOutLineId> ids)
        {
            var states = new List<InOutLineMvoState>();
            foreach (var id in ids)
            {
                var s = new InOutLineMvoState();
                s.InOutLineId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

