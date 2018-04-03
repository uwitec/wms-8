﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentPackageContentMvo;
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

    [RoutePrefix("api/ShipmentPackageContentMvos")]
    public partial class ShipmentPackageContentMvosController : ApiController
    {

        IShipmentPackageContentMvoApplicationService _shipmentPackageContentMvoApplicationService = ApplicationContext.Current["ShipmentPackageContentMvoApplicationService"] as IShipmentPackageContentMvoApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IShipmentPackageContentMvoStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IShipmentPackageContentMvoState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _shipmentPackageContentMvoApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (ShipmentPackageContentMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? ShipmentPackageContentMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , ShipmentPackageContentMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _shipmentPackageContentMvoApplicationService.Get(ShipmentPackageContentMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , ShipmentPackageContentMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IShipmentPackageContentMvoStateDto>();
            foreach (var s in states)
            {
                var dto = s is ShipmentPackageContentMvoStateDtoWrapper ? (ShipmentPackageContentMvoStateDtoWrapper)s : new ShipmentPackageContentMvoStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IShipmentPackageContentMvoStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = ShipmentPackageContentMvosControllerUtils.ParseIdString(id);
            var state = _shipmentPackageContentMvoApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new ShipmentPackageContentMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _shipmentPackageContentMvoApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (ShipmentPackageContentMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? ShipmentPackageContentMvoMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _shipmentPackageContentMvoApplicationService.GetCount(ShipmentPackageContentMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreateShipmentPackageContentMvoDto value)
        {
          try {
            if (value.ShipmentPackageContentId == default(ShipmentPackageContentId))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "ShipmentPackageContentMvo");
            }
            _shipmentPackageContentMvoApplicationService.When(value as ICreateShipmentPackageContentMvo);
            var idObj = value.ShipmentPackageContentId;

            return Request.CreateResponse<ShipmentPackageContentId>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeleteShipmentPackageContentMvoDto value)
        {
          try {
              // ///////////////////////////////
              if (value.ShipmentPackageVersion != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  ShipmentPackageContentMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _shipmentPackageContentMvoApplicationService.When(value as IMergePatchShipmentPackageContentMvo);
                  return;
              }
              // ///////////////////////////////

            ShipmentPackageContentMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _shipmentPackageContentMvoApplicationService.When(value as ICreateShipmentPackageContentMvo);
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchShipmentPackageContentMvoDto value)
        {
          try {
            ShipmentPackageContentMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _shipmentPackageContentMvoApplicationService.When(value as IMergePatchShipmentPackageContentMvo);
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteShipmentPackageContentMvoDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.ShipmentPackageVersion = (long)Convert.ChangeType(version, typeof(long));
            ShipmentPackageContentMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _shipmentPackageContentMvoApplicationService.When(value as IDeleteShipmentPackageContentMvo);
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in ShipmentPackageContentMvoMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public ShipmentPackageContentMvoStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = ShipmentPackageContentMvosControllerUtils.ParseIdString(id);
            var conv = new ShipmentPackageContentMvoStateEventDtoConverter();
            var se = _shipmentPackageContentMvoApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToShipmentPackageContentMvoStateEventDto(se);
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IShipmentPackageContentMvoStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = ShipmentPackageContentMvosControllerUtils.ParseIdString(id);
            var state = _shipmentPackageContentMvoApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new ShipmentPackageContentMvoStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = ShipmentPackageContentMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return ShipmentPackageContentMvosControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class ShipmentPackageContentMvosControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteShipmentPackageContentMvoDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.ShipmentPackageContentId == null)
            {
                value.ShipmentPackageContentId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteShipmentPackageContentMvo)value).ShipmentPackageContentId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.ShipmentPackageContentId);
            }
        }

        public static ShipmentPackageContentId ParseIdString(string idString)
        {
            var formatter = new ValueObjectTextFormatter<ShipmentPackageContentId>();
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
            if (ShipmentPackageContentMvoMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return ShipmentPackageContentMvoMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (ShipmentPackageContentMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return ShipmentPackageContentMvoMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IShipmentPackageContentMvoStateDto> ToShipmentPackageContentMvoStateDtoCollection(IEnumerable<ShipmentPackageContentId> ids)
        {
            var states = new List<IShipmentPackageContentMvoStateDto>();
            foreach (var id in ids)
            {
                var dto = new ShipmentPackageContentMvoStateDtoWrapper();
                dto.ShipmentPackageContentId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IShipmentPackageContentMvoState> ToShipmentPackageContentMvoStateCollection(IEnumerable<ShipmentPackageContentId> ids)
        {
            var states = new List<ShipmentPackageContentMvoState>();
            foreach (var id in ids)
            {
                var s = new ShipmentPackageContentMvoState();
                s.ShipmentPackageContentId = id;
                states.Add(s);
            }
            return states;
        }

    }

}
