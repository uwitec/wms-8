﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryItemEntryMvo;
using Dddml.Wms.Domain.InventoryItem;
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

    [RoutePrefix("api/InventoryItemEntryMvos")][Authorize]
    public partial class InventoryItemEntryMvosController : ApiController
    {

        IInventoryItemEntryMvoApplicationService _inventoryItemEntryMvoApplicationService = ApplicationContext.Current["InventoryItemEntryMvoApplicationService"] as IInventoryItemEntryMvoApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IInventoryItemEntryMvoStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IInventoryItemEntryMvoState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _inventoryItemEntryMvoApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (InventoryItemEntryMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? InventoryItemEntryMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , InventoryItemEntryMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _inventoryItemEntryMvoApplicationService.Get(InventoryItemEntryMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , InventoryItemEntryMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IInventoryItemEntryMvoStateDto>();
            foreach (var s in states)
            {
                var dto = s is InventoryItemEntryMvoStateDtoWrapper ? (InventoryItemEntryMvoStateDtoWrapper)s : new InventoryItemEntryMvoStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = InventoryItemEntryMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IInventoryItemEntryMvoStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = InventoryItemEntryMvosControllerUtils.ParseIdString(id);
            var state = _inventoryItemEntryMvoApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new InventoryItemEntryMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = InventoryItemEntryMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _inventoryItemEntryMvoApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (InventoryItemEntryMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? InventoryItemEntryMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _inventoryItemEntryMvoApplicationService.GetCount(InventoryItemEntryMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = InventoryItemEntryMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateInventoryItemEntryMvoDto value)
        {
          try {
            InventoryItemEntryMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _inventoryItemEntryMvoApplicationService.When(value as ICreateInventoryItemEntryMvo);
          } catch (Exception ex) { var response = InventoryItemEntryMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchInventoryItemEntryMvoDto value)
        {
          try {
            InventoryItemEntryMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _inventoryItemEntryMvoApplicationService.When(value as IMergePatchInventoryItemEntryMvo);
          } catch (Exception ex) { var response = InventoryItemEntryMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in InventoryItemEntryMvoMetadata.Instance.Properties)
            {
                if (p.IsFilteringProperty)
                {
                    var pdto = new PropertyMetadataDto(p.Name, p.TypeName, p.IsFilteringProperty,
                       !String.IsNullOrWhiteSpace(p.SourceChainingName) ? p.SourceChainingName :
                       (!String.IsNullOrWhiteSpace(p.DerivedFrom) ? p.DerivedFrom : p.Name));
                    filtering.Add(pdto);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = InventoryItemEntryMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public InventoryItemEntryMvoStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = InventoryItemEntryMvosControllerUtils.ParseIdString(id);
            var conv = new InventoryItemEntryMvoStateEventDtoConverter();
            var se = _inventoryItemEntryMvoApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToInventoryItemEntryMvoStateEventDto(se);
          } catch (Exception ex) { var response = InventoryItemEntryMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IInventoryItemEntryMvoStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = InventoryItemEntryMvosControllerUtils.ParseIdString(id);
            var state = _inventoryItemEntryMvoApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new InventoryItemEntryMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = InventoryItemEntryMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return InventoryItemEntryMvosControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class InventoryItemEntryMvosControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteInventoryItemEntryMvoDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.InventoryItemEntryId == null)
            {
                value.InventoryItemEntryId = new InventoryItemEntryIdDtoWrapper(idObj);
            }
            else if (!((ICreateOrMergePatchOrDeleteInventoryItemEntryMvo)value).InventoryItemEntryId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.InventoryItemEntryId);
            }
        }

        public static InventoryItemEntryId ParseIdString(string idString)
        {
            var formatter = new InventoryItemEntryIdFlattenedDtoFormatter();
            var idDto = formatter.Parse(idString);
            var rId = idDto.ToInventoryItemEntryId();
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
            if (InventoryItemEntryMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return InventoryItemEntryMvoMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (InventoryItemEntryMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return InventoryItemEntryMvoMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IInventoryItemEntryMvoStateDto> ToInventoryItemEntryMvoStateDtoCollection(IEnumerable<InventoryItemEntryId> ids)
        {
            var states = new List<IInventoryItemEntryMvoStateDto>();
            foreach (var id in ids)
            {
                var dto = new InventoryItemEntryMvoStateDtoWrapper();
                dto.InventoryItemEntryId = new InventoryItemEntryIdDtoWrapper(id);
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IInventoryItemEntryMvoState> ToInventoryItemEntryMvoStateCollection(IEnumerable<InventoryItemEntryId> ids)
        {
            var states = new List<InventoryItemEntryMvoState>();
            foreach (var id in ids)
            {
                var s = new InventoryItemEntryMvoState();
                s.InventoryItemEntryId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

