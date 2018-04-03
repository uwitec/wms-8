﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InventoryPRTriggered;
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

    [RoutePrefix("api/InventoryPRTriggereds")]
    public partial class InventoryPRTriggeredsController : ApiController
    {

        IInventoryPRTriggeredApplicationService _inventoryPRTriggeredApplicationService = ApplicationContext.Current["InventoryPRTriggeredApplicationService"] as IInventoryPRTriggeredApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IInventoryPRTriggeredStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IInventoryPRTriggeredState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _inventoryPRTriggeredApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (InventoryPRTriggeredMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? InventoryPRTriggeredMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , InventoryPRTriggeredsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _inventoryPRTriggeredApplicationService.Get(InventoryPRTriggeredsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , InventoryPRTriggeredsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IInventoryPRTriggeredStateDto>();
            foreach (var s in states)
            {
                var dto = s is InventoryPRTriggeredStateDtoWrapper ? (InventoryPRTriggeredStateDtoWrapper)s : new InventoryPRTriggeredStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = InventoryPRTriggeredsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IInventoryPRTriggeredStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = InventoryPRTriggeredsControllerUtils.ParseIdString(id);
            var state = _inventoryPRTriggeredApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new InventoryPRTriggeredStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = InventoryPRTriggeredsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _inventoryPRTriggeredApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (InventoryPRTriggeredMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? InventoryPRTriggeredMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _inventoryPRTriggeredApplicationService.GetCount(InventoryPRTriggeredsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = InventoryPRTriggeredsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreateInventoryPRTriggeredDto value)
        {
          try {
            if (value.InventoryPRTriggeredId == default(InventoryPRTriggeredId))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "InventoryPRTriggered");
            }
            _inventoryPRTriggeredApplicationService.When(value as ICreateInventoryPRTriggered);
            var idObj = value.InventoryPRTriggeredId;

            return Request.CreateResponse<InventoryPRTriggeredId>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = InventoryPRTriggeredsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeleteInventoryPRTriggeredDto value)
        {
          try {
              // ///////////////////////////////
              if (value.Version != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  InventoryPRTriggeredsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _inventoryPRTriggeredApplicationService.When(value as IMergePatchInventoryPRTriggered);
                  return;
              }
              // ///////////////////////////////

            InventoryPRTriggeredsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _inventoryPRTriggeredApplicationService.When(value as ICreateInventoryPRTriggered);
          } catch (Exception ex) { var response = InventoryPRTriggeredsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchInventoryPRTriggeredDto value)
        {
          try {
            InventoryPRTriggeredsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _inventoryPRTriggeredApplicationService.When(value as IMergePatchInventoryPRTriggered);
          } catch (Exception ex) { var response = InventoryPRTriggeredsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in InventoryPRTriggeredMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = InventoryPRTriggeredsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return InventoryPRTriggeredsControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class InventoryPRTriggeredsControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteInventoryPRTriggeredDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.InventoryPRTriggeredId == null)
            {
                value.InventoryPRTriggeredId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteInventoryPRTriggered)value).InventoryPRTriggeredId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.InventoryPRTriggeredId);
            }
        }

        public static InventoryPRTriggeredId ParseIdString(string idString)
        {
            var formatter = new ValueObjectTextFormatter<InventoryPRTriggeredId>();
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
            if (InventoryPRTriggeredMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return InventoryPRTriggeredMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (InventoryPRTriggeredMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return InventoryPRTriggeredMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IInventoryPRTriggeredStateDto> ToInventoryPRTriggeredStateDtoCollection(IEnumerable<InventoryPRTriggeredId> ids)
        {
            var states = new List<IInventoryPRTriggeredStateDto>();
            foreach (var id in ids)
            {
                var dto = new InventoryPRTriggeredStateDtoWrapper();
                dto.InventoryPRTriggeredId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IInventoryPRTriggeredState> ToInventoryPRTriggeredStateCollection(IEnumerable<InventoryPRTriggeredId> ids)
        {
            var states = new List<InventoryPRTriggeredState>();
            foreach (var id in ids)
            {
                var s = new InventoryPRTriggeredState();
                s.InventoryPRTriggeredId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

