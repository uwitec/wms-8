﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistBin;
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

    [RoutePrefix("api/PicklistBins")]
    public partial class PicklistBinsController : ApiController
    {

        IPicklistBinApplicationService _picklistBinApplicationService = ApplicationContext.Current["PicklistBinApplicationService"] as IPicklistBinApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IPicklistBinStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IPicklistBinState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _picklistBinApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (PicklistBinMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? PicklistBinMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , PicklistBinsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _picklistBinApplicationService.Get(PicklistBinsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , PicklistBinsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IPicklistBinStateDto>();
            foreach (var s in states)
            {
                var dto = s is PicklistBinStateDtoWrapper ? (PicklistBinStateDtoWrapper)s : new PicklistBinStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IPicklistBinStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = id;
            var state = _picklistBinApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new PicklistBinStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _picklistBinApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (PicklistBinMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? PicklistBinMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _picklistBinApplicationService.GetCount(PicklistBinsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreatePicklistBinDto value)
        {
          try {
            if (value.PicklistBinId == null)
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "PicklistBin");
            }
            var idObj = value.PicklistBinId;

            return Request.CreateResponse<string>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreatePicklistBinDto value)
        {
          try {
            PicklistBinsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _picklistBinApplicationService.When(value as ICreatePicklistBin);
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchPicklistBinDto value)
        {
          try {
            PicklistBinsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _picklistBinApplicationService.When(value as IMergePatchPicklistBin);
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeletePicklistBinDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.Version = (long)Convert.ChangeType(version, typeof(long));
            PicklistBinsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _picklistBinApplicationService.When(value as IDeletePicklistBin);
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in PicklistBinMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public PicklistBinStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = id;
            var conv = new PicklistBinStateEventDtoConverter();
            var se = _picklistBinApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToPicklistBinStateEventDto(se);
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IPicklistBinStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = id;
            var state = _picklistBinApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new PicklistBinStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{picklistBinId}/PicklistItems/{picklistItemOrderShipGrpInvId}")]
        [HttpGet]
        public IPicklistItemStateDto GetPicklistItem(string picklistBinId, string picklistItemOrderShipGrpInvId)
        {
          try {
            var state = (PicklistItemState)_picklistBinApplicationService.GetPicklistItem(picklistBinId, ((new ValueObjectTextFormatter<PicklistItemOrderShipGrpInvId>()).Parse(picklistItemOrderShipGrpInvId)));
            if (state == null) { return null; }
            var stateDto = new PicklistItemStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{picklistBinId}/PicklistItems/")]
        [HttpGet]
        public IEnumerable<IPicklistItemStateDto> GetPicklistItems(string picklistBinId)
        {
          try {
            var states = _picklistBinApplicationService.GetPicklistItems(picklistBinId);
            if (states == null) { return null; }
            var stateDtos = new List<IPicklistItemStateDto>();
            foreach (var s in states)
            {
                var dto = s is PicklistItemStateDtoWrapper ? (PicklistItemStateDtoWrapper)s : new PicklistItemStateDtoWrapper((PicklistItemState)s);
                dto.AllFieldsReturned = true;
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = PicklistBinsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return PicklistBinsControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class PicklistBinsControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeletePicklistBinDto value)
        {
            var idObj = id;
            if (value.PicklistBinId == null)
            {
                value.PicklistBinId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeletePicklistBin)value).PicklistBinId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.PicklistBinId);
            }
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
            if (PicklistBinMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return PicklistBinMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (PicklistBinMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return PicklistBinMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IPicklistBinStateDto> ToPicklistBinStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IPicklistBinStateDto>();
            foreach (var id in ids)
            {
                var dto = new PicklistBinStateDtoWrapper();
                dto.PicklistBinId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IPicklistBinState> ToPicklistBinStateCollection(IEnumerable<string> ids)
        {
            var states = new List<PicklistBinState>();
            foreach (var id in ids)
            {
                var s = new PicklistBinState();
                s.PicklistBinId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

