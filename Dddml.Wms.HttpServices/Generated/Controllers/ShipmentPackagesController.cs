﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackage;
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

    [RoutePrefix("api/ShipmentPackages")]
    public partial class ShipmentPackagesController : ApiController
    {

        IShipmentPackageApplicationService _shipmentPackageApplicationService = ApplicationContext.Current["ShipmentPackageApplicationService"] as IShipmentPackageApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IShipmentPackageStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IShipmentPackageState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _shipmentPackageApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (ShipmentPackageMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? ShipmentPackageMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , ShipmentPackagesControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _shipmentPackageApplicationService.Get(ShipmentPackagesControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , ShipmentPackagesControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IShipmentPackageStateDto>();
            foreach (var s in states)
            {
                var dto = s is ShipmentPackageStateDtoWrapper ? (ShipmentPackageStateDtoWrapper)s : new ShipmentPackageStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IShipmentPackageStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = ShipmentPackagesControllerUtils.ParseIdString(id);
            var state = _shipmentPackageApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new ShipmentPackageStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _shipmentPackageApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (ShipmentPackageMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? ShipmentPackageMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _shipmentPackageApplicationService.GetCount(ShipmentPackagesControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreateShipmentPackageDto value)
        {
          try {
            if (value.ShipmentPackageId == default(ShipmentPackageId))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "ShipmentPackage");
            }
            _shipmentPackageApplicationService.When(value as ICreateShipmentPackage);
            var idObj = value.ShipmentPackageId;

            return Request.CreateResponse<ShipmentPackageId>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeleteShipmentPackageDto value)
        {
          try {
              // ///////////////////////////////
              if (value.Version != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  ShipmentPackagesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _shipmentPackageApplicationService.When(value as IMergePatchShipmentPackage);
                  return;
              }
              // ///////////////////////////////

            ShipmentPackagesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _shipmentPackageApplicationService.When(value as ICreateShipmentPackage);
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchShipmentPackageDto value)
        {
          try {
            ShipmentPackagesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _shipmentPackageApplicationService.When(value as IMergePatchShipmentPackage);
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteShipmentPackageDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.Version = (long)Convert.ChangeType(version, typeof(long));
            ShipmentPackagesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _shipmentPackageApplicationService.When(value as IDeleteShipmentPackage);
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in ShipmentPackageMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public ShipmentPackageStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = ShipmentPackagesControllerUtils.ParseIdString(id);
            var conv = new ShipmentPackageStateEventDtoConverter();
            var se = _shipmentPackageApplicationService.GetEvent(idObj, version);
            return se == null ? null : conv.ToShipmentPackageStateEventDto(se);
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IShipmentPackageStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = ShipmentPackagesControllerUtils.ParseIdString(id);
            var state = _shipmentPackageApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new ShipmentPackageStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{shipmentPackageId}/ShipmentPackageContents/{shipmentItemSeqId}")]
        [HttpGet]
        public IShipmentPackageContentStateDto GetShipmentPackageContent(string shipmentPackageId, string shipmentItemSeqId)
        {
          try {
            var state = (ShipmentPackageContentState)_shipmentPackageApplicationService.GetShipmentPackageContent(((new ValueObjectTextFormatter<ShipmentPackageId>()).Parse(shipmentPackageId)), shipmentItemSeqId);
            if (state == null) { return null; }
            var stateDto = new ShipmentPackageContentStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{shipmentPackageId}/ShipmentPackageContents/")]
        [HttpGet]
        public IEnumerable<IShipmentPackageContentStateDto> GetShipmentPackageContents(string shipmentPackageId)
        {
          try {
            var states = _shipmentPackageApplicationService.GetShipmentPackageContents(((new ValueObjectTextFormatter<ShipmentPackageId>()).Parse(shipmentPackageId)));
            if (states == null) { return null; }
            var stateDtos = new List<IShipmentPackageContentStateDto>();
            foreach (var s in states)
            {
                var dto = s is ShipmentPackageContentStateDtoWrapper ? (ShipmentPackageContentStateDtoWrapper)s : new ShipmentPackageContentStateDtoWrapper((ShipmentPackageContentState)s);
                dto.AllFieldsReturned = true;
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = ShipmentPackagesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return ShipmentPackagesControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class ShipmentPackagesControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteShipmentPackageDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.ShipmentPackageId == null)
            {
                value.ShipmentPackageId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteShipmentPackage)value).ShipmentPackageId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.ShipmentPackageId);
            }
        }

        public static ShipmentPackageId ParseIdString(string idString)
        {
            var formatter = new ValueObjectTextFormatter<ShipmentPackageId>();
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
            if (ShipmentPackageMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return ShipmentPackageMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (ShipmentPackageMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return ShipmentPackageMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IShipmentPackageStateDto> ToShipmentPackageStateDtoCollection(IEnumerable<ShipmentPackageId> ids)
        {
            var states = new List<IShipmentPackageStateDto>();
            foreach (var id in ids)
            {
                var dto = new ShipmentPackageStateDtoWrapper();
                dto.ShipmentPackageId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IShipmentPackageState> ToShipmentPackageStateCollection(IEnumerable<ShipmentPackageId> ids)
        {
            var states = new List<ShipmentPackageState>();
            foreach (var id in ids)
            {
                var s = new ShipmentPackageState();
                s.ShipmentPackageId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

