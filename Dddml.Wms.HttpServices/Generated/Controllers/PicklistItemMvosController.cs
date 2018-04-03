﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.PicklistItemMvo;
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

    [RoutePrefix("api/PicklistItemMvos")]
    public partial class PicklistItemMvosController : ApiController
    {

        IPicklistItemMvoApplicationService _picklistItemMvoApplicationService = ApplicationContext.Current["PicklistItemMvoApplicationService"] as IPicklistItemMvoApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IPicklistItemMvoStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IPicklistItemMvoState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _picklistItemMvoApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (PicklistItemMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? PicklistItemMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , PicklistItemMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _picklistItemMvoApplicationService.Get(PicklistItemMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , PicklistItemMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IPicklistItemMvoStateDto>();
            foreach (var s in states)
            {
                var dto = s is PicklistItemMvoStateDtoWrapper ? (PicklistItemMvoStateDtoWrapper)s : new PicklistItemMvoStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IPicklistItemMvoStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = PicklistItemMvosControllerUtils.ParseIdString(id);
            var state = _picklistItemMvoApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new PicklistItemMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _picklistItemMvoApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (PicklistItemMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? PicklistItemMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _picklistItemMvoApplicationService.GetCount(PicklistItemMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreatePicklistItemMvoDto value)
        {
          try {
            if (value.PicklistBinPicklistItemId == default(PicklistBinPicklistItemId))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "PicklistItemMvo");
            }
            _picklistItemMvoApplicationService.When(value as ICreatePicklistItemMvo);
            var idObj = value.PicklistBinPicklistItemId;

            return Request.CreateResponse<PicklistBinPicklistItemId>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeletePicklistItemMvoDto value)
        {
          try {
              // ///////////////////////////////
              if (value.PicklistBinVersion != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  PicklistItemMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _picklistItemMvoApplicationService.When(value as IMergePatchPicklistItemMvo);
                  return;
              }
              // ///////////////////////////////

            PicklistItemMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _picklistItemMvoApplicationService.When(value as ICreatePicklistItemMvo);
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchPicklistItemMvoDto value)
        {
          try {
            PicklistItemMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _picklistItemMvoApplicationService.When(value as IMergePatchPicklistItemMvo);
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeletePicklistItemMvoDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.PicklistBinVersion = (long)Convert.ChangeType(version, typeof(long));
            PicklistItemMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _picklistItemMvoApplicationService.When(value as IDeletePicklistItemMvo);
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in PicklistItemMvoMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public PicklistItemMvoStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = PicklistItemMvosControllerUtils.ParseIdString(id);
            var conv = new PicklistItemMvoStateEventDtoConverter();
            var se = _picklistItemMvoApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToPicklistItemMvoStateEventDto(se);
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IPicklistItemMvoStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = PicklistItemMvosControllerUtils.ParseIdString(id);
            var state = _picklistItemMvoApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new PicklistItemMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = PicklistItemMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return PicklistItemMvosControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class PicklistItemMvosControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeletePicklistItemMvoDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.PicklistBinPicklistItemId == null)
            {
                value.PicklistBinPicklistItemId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeletePicklistItemMvo)value).PicklistBinPicklistItemId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.PicklistBinPicklistItemId);
            }
        }

        public static PicklistBinPicklistItemId ParseIdString(string idString)
        {
            var formatter = new ValueObjectTextFormatter<PicklistBinPicklistItemId>();
            return formatter.Parse(idString);
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
            if (PicklistItemMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return PicklistItemMvoMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (PicklistItemMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return PicklistItemMvoMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IPicklistItemMvoStateDto> ToPicklistItemMvoStateDtoCollection(IEnumerable<PicklistBinPicklistItemId> ids)
        {
            var states = new List<IPicklistItemMvoStateDto>();
            foreach (var id in ids)
            {
                var dto = new PicklistItemMvoStateDtoWrapper();
                dto.PicklistBinPicklistItemId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IPicklistItemMvoState> ToPicklistItemMvoStateCollection(IEnumerable<PicklistBinPicklistItemId> ids)
        {
            var states = new List<PicklistItemMvoState>();
            foreach (var id in ids)
            {
                var s = new PicklistItemMvoState();
                s.PicklistBinPicklistItemId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

