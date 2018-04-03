﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;
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

    [RoutePrefix("api/Shipments")]
    public partial class ShipmentsController : ApiController
    {

        IShipmentApplicationService _shipmentApplicationService = ApplicationContext.Current["ShipmentApplicationService"] as IShipmentApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IShipmentStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IShipmentState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _shipmentApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (ShipmentMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? ShipmentMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , ShipmentsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _shipmentApplicationService.Get(ShipmentsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , ShipmentsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IShipmentStateDto>();
            foreach (var s in states)
            {
                var dto = s is ShipmentStateDtoWrapper ? (ShipmentStateDtoWrapper)s : new ShipmentStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IShipmentStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = id;
            var state = _shipmentApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new ShipmentStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _shipmentApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (ShipmentMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? ShipmentMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _shipmentApplicationService.GetCount(ShipmentsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreateShipmentDto value)
        {
          try {
            if (value.ShipmentId == default(string))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "Shipment");
            }
            _shipmentApplicationService.When(value as ICreateShipment);
            var idObj = value.ShipmentId;

            return Request.CreateResponse<string>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeleteShipmentDto value)
        {
          try {
              // ///////////////////////////////
              if (value.Version != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  ShipmentsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _shipmentApplicationService.When(value as IMergePatchShipment);
                  return;
              }
              // ///////////////////////////////

            ShipmentsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _shipmentApplicationService.When(value as ICreateShipment);
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchShipmentDto value)
        {
          try {
            ShipmentsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _shipmentApplicationService.When(value as IMergePatchShipment);
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_commands/Import")]
        [HttpPut][SetRequesterId]
        public void Import(string id, [FromBody]ShipmentCommandDtos.ImportRequestContent content)
        {
          try {
            var cmd = content.ToImport();
            var idObj = id;
            if (cmd.ShipmentId == null)
            {
                cmd.ShipmentId = idObj;
            }
            else if (!cmd.ShipmentId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, cmd.ShipmentId);
            }
            _shipmentApplicationService.When(cmd);
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_commands/Ship")]
        [HttpPut][SetRequesterId]
        public void Ship(string id, [FromBody]ShipmentCommandDtos.ShipRequestContent content)
        {
          try {
            var cmd = content.ToShip();
            var idObj = id;
            if (cmd.ShipmentId == null)
            {
                cmd.ShipmentId = idObj;
            }
            else if (!cmd.ShipmentId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, cmd.ShipmentId);
            }
            _shipmentApplicationService.When(cmd);
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_commands/ReceiveItem")]
        [HttpPut][SetRequesterId]
        public void ReceiveItem(string id, [FromBody]ShipmentCommandDtos.ReceiveItemRequestContent content)
        {
          try {
            var cmd = content.ToReceiveItem();
            var idObj = id;
            if (cmd.ShipmentId == null)
            {
                cmd.ShipmentId = idObj;
            }
            else if (!cmd.ShipmentId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, cmd.ShipmentId);
            }
            _shipmentApplicationService.When(cmd);
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_commands/ConfirmAllItemsReceived")]
        [HttpPut][SetRequesterId]
        public void ConfirmAllItemsReceived(string id, [FromBody]ShipmentCommandDtos.ConfirmAllItemsReceivedRequestContent content)
        {
          try {
            var cmd = content.ToConfirmAllItemsReceived();
            var idObj = id;
            if (cmd.ShipmentId == null)
            {
                cmd.ShipmentId = idObj;
            }
            else if (!cmd.ShipmentId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, cmd.ShipmentId);
            }
            _shipmentApplicationService.When(cmd);
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in ShipmentMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public ShipmentStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = id;
            var conv = new ShipmentStateEventDtoConverter();
            var se = _shipmentApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToShipmentStateEventDto(se);
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IShipmentStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = id;
            var state = _shipmentApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new ShipmentStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{shipmentId}/ShipmentItems/{shipmentItemSeqId}")]
        [HttpGet]
        public IShipmentItemStateDto GetShipmentItem(string shipmentId, string shipmentItemSeqId)
        {
          try {
            var state = (ShipmentItemState)_shipmentApplicationService.GetShipmentItem(shipmentId, shipmentItemSeqId);
            if (state == null) { return null; }
            var stateDto = new ShipmentItemStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{shipmentId}/ShipmentItems/")]
        [HttpGet]
        public IEnumerable<IShipmentItemStateDto> GetShipmentItems(string shipmentId)
        {
          try {
            var states = _shipmentApplicationService.GetShipmentItems(shipmentId);
            if (states == null) { return null; }
            var stateDtos = new List<IShipmentItemStateDto>();
            foreach (var s in states)
            {
                var dto = s is ShipmentItemStateDtoWrapper ? (ShipmentItemStateDtoWrapper)s : new ShipmentItemStateDtoWrapper((ShipmentItemState)s);
                dto.AllFieldsReturned = true;
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{shipmentId}/ShipmentReceipts/{receiptSeqId}")]
        [HttpGet]
        public IShipmentReceiptStateDto GetShipmentReceipt(string shipmentId, string receiptSeqId)
        {
          try {
            var state = (ShipmentReceiptState)_shipmentApplicationService.GetShipmentReceipt(shipmentId, receiptSeqId);
            if (state == null) { return null; }
            var stateDto = new ShipmentReceiptStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{shipmentId}/ShipmentReceipts/")]
        [HttpGet]
        public IEnumerable<IShipmentReceiptStateDto> GetShipmentReceipts(string shipmentId)
        {
          try {
            var states = _shipmentApplicationService.GetShipmentReceipts(shipmentId);
            if (states == null) { return null; }
            var stateDtos = new List<IShipmentReceiptStateDto>();
            foreach (var s in states)
            {
                var dto = s is ShipmentReceiptStateDtoWrapper ? (ShipmentReceiptStateDtoWrapper)s : new ShipmentReceiptStateDtoWrapper((ShipmentReceiptState)s);
                dto.AllFieldsReturned = true;
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{shipmentId}/ItemIssuances/{itemIssuanceSeqId}")]
        [HttpGet]
        public IItemIssuanceStateDto GetItemIssuance(string shipmentId, string itemIssuanceSeqId)
        {
          try {
            var state = (ItemIssuanceState)_shipmentApplicationService.GetItemIssuance(shipmentId, itemIssuanceSeqId);
            if (state == null) { return null; }
            var stateDto = new ItemIssuanceStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{shipmentId}/ItemIssuances/")]
        [HttpGet]
        public IEnumerable<IItemIssuanceStateDto> GetItemIssuances(string shipmentId)
        {
          try {
            var states = _shipmentApplicationService.GetItemIssuances(shipmentId);
            if (states == null) { return null; }
            var stateDtos = new List<IItemIssuanceStateDto>();
            foreach (var s in states)
            {
                var dto = s is ItemIssuanceStateDtoWrapper ? (ItemIssuanceStateDtoWrapper)s : new ItemIssuanceStateDtoWrapper((ItemIssuanceState)s);
                dto.AllFieldsReturned = true;
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = ShipmentsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return ShipmentsControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class ShipmentsControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteShipmentDto value)
        {
            var idObj = id;
            if (value.ShipmentId == null)
            {
                value.ShipmentId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteShipment)value).ShipmentId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.ShipmentId);
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
            if (ShipmentMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return ShipmentMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (ShipmentMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return ShipmentMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IShipmentStateDto> ToShipmentStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IShipmentStateDto>();
            foreach (var id in ids)
            {
                var dto = new ShipmentStateDtoWrapper();
                dto.ShipmentId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IShipmentState> ToShipmentStateCollection(IEnumerable<string> ids)
        {
            var states = new List<ShipmentState>();
            foreach (var id in ids)
            {
                var s = new ShipmentState();
                s.ShipmentId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

