﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.SellableInventoryItem;
using Dddml.Wms.Domain.InventoryItem;
using Dddml.Wms.Domain.InventoryPRTriggered;
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

    [RoutePrefix("api/SellableInventoryItems")]
    public partial class SellableInventoryItemsController : ApiController
    {

        ISellableInventoryItemApplicationService _sellableInventoryItemApplicationService = ApplicationContext.Current["SellableInventoryItemApplicationService"] as ISellableInventoryItemApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<ISellableInventoryItemStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<ISellableInventoryItemState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _sellableInventoryItemApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (SellableInventoryItemMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? SellableInventoryItemMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , SellableInventoryItemsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _sellableInventoryItemApplicationService.Get(SellableInventoryItemsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , SellableInventoryItemsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<ISellableInventoryItemStateDto>();
            foreach (var s in states)
            {
                var dto = s is SellableInventoryItemStateDtoWrapper ? (SellableInventoryItemStateDtoWrapper)s : new SellableInventoryItemStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public ISellableInventoryItemStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = SellableInventoryItemsControllerUtils.ParseIdString(id);
            var state = _sellableInventoryItemApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new SellableInventoryItemStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _sellableInventoryItemApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (SellableInventoryItemMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? SellableInventoryItemMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _sellableInventoryItemApplicationService.GetCount(SellableInventoryItemsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreateSellableInventoryItemDto value)
        {
          try {
            if (value.SellableInventoryItemId == default(InventoryItemId))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "SellableInventoryItem");
            }
            _sellableInventoryItemApplicationService.When(value as ICreateSellableInventoryItem);
            var idObj = value.SellableInventoryItemId;

            return Request.CreateResponse<InventoryItemId>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeleteSellableInventoryItemDto value)
        {
          try {
              // ///////////////////////////////
              if (value.Version != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  SellableInventoryItemsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _sellableInventoryItemApplicationService.When(value as IMergePatchSellableInventoryItem);
                  return;
              }
              // ///////////////////////////////

            SellableInventoryItemsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _sellableInventoryItemApplicationService.When(value as ICreateSellableInventoryItem);
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchSellableInventoryItemDto value)
        {
          try {
            SellableInventoryItemsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _sellableInventoryItemApplicationService.When(value as IMergePatchSellableInventoryItem);
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in SellableInventoryItemMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{sellableInventoryItemId}/SellableInventoryItemEntries/{entrySeqId}")]
        [HttpGet]
        public ISellableInventoryItemEntryStateDto GetSellableInventoryItemEntry(string sellableInventoryItemId, long entrySeqId)
        {
          try {
            var state = (SellableInventoryItemEntryState)_sellableInventoryItemApplicationService.GetSellableInventoryItemEntry(((new ValueObjectTextFormatter<InventoryItemId>()).Parse(sellableInventoryItemId)), entrySeqId);
            if (state == null) { return null; }
            var stateDto = new SellableInventoryItemEntryStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{sellableInventoryItemId}/SellableInventoryItemEntries/")]
        [HttpGet]
        public IEnumerable<ISellableInventoryItemEntryStateDto> GetSellableInventoryItemEntries(string sellableInventoryItemId)
        {
          try {
            var states = _sellableInventoryItemApplicationService.GetSellableInventoryItemEntries(((new ValueObjectTextFormatter<InventoryItemId>()).Parse(sellableInventoryItemId)));
            if (states == null) { return null; }
            var stateDtos = new List<ISellableInventoryItemEntryStateDto>();
            foreach (var s in states)
            {
                var dto = s is SellableInventoryItemEntryStateDtoWrapper ? (SellableInventoryItemEntryStateDtoWrapper)s : new SellableInventoryItemEntryStateDtoWrapper((SellableInventoryItemEntryState)s);
                dto.AllFieldsReturned = true;
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = SellableInventoryItemsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return SellableInventoryItemsControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class SellableInventoryItemsControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteSellableInventoryItemDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.SellableInventoryItemId == null)
            {
                value.SellableInventoryItemId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteSellableInventoryItem)value).SellableInventoryItemId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.SellableInventoryItemId);
            }
        }

        public static InventoryItemId ParseIdString(string idString)
        {
            var formatter = new ValueObjectTextFormatter<InventoryItemId>();
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
            if (SellableInventoryItemMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return SellableInventoryItemMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (SellableInventoryItemMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return SellableInventoryItemMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<ISellableInventoryItemStateDto> ToSellableInventoryItemStateDtoCollection(IEnumerable<InventoryItemId> ids)
        {
            var states = new List<ISellableInventoryItemStateDto>();
            foreach (var id in ids)
            {
                var dto = new SellableInventoryItemStateDtoWrapper();
                dto.SellableInventoryItemId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<ISellableInventoryItemState> ToSellableInventoryItemStateCollection(IEnumerable<InventoryItemId> ids)
        {
            var states = new List<SellableInventoryItemState>();
            foreach (var id in ids)
            {
                var s = new SellableInventoryItemState();
                s.SellableInventoryItemId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

