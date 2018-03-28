﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;
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

    [RoutePrefix("api/Orders")]
    public partial class OrdersController : ApiController
    {

        IOrderApplicationService _orderApplicationService = ApplicationContext.Current["OrderApplicationService"] as IOrderApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IOrderStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IOrderState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _orderApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (OrderMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? OrderMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , OrdersControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _orderApplicationService.Get(OrdersControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , OrdersControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IOrderStateDto>();
            foreach (var s in states)
            {
                var dto = s is OrderStateDtoWrapper ? (OrderStateDtoWrapper)s : new OrderStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IOrderStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = id;
            var state = _orderApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new OrderStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _orderApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (OrderMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? OrderMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _orderApplicationService.GetCount(OrdersControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrderDto value)
        {
          try {
            OrdersControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _orderApplicationService.When(value as ICreateOrder);
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchOrderDto value)
        {
          try {
            OrdersControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _orderApplicationService.When(value as IMergePatchOrder);
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in OrderMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public OrderStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = id;
            var conv = new OrderStateEventDtoConverter();
            var se = _orderApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToOrderStateEventDto(se);
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IOrderStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = id;
            var state = _orderApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new OrderStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{orderId}/OrderRoles/{partyRoleId}")]
        [HttpGet]
        public IOrderRoleStateDto GetOrderRole(string orderId, string partyRoleId)
        {
          try {
            var state = (OrderRoleState)_orderApplicationService.GetOrderRole(orderId, ((new ValueObjectTextFormatter<PartyRoleId>()).Parse(partyRoleId)));
            if (state == null) { return null; }
            var stateDto = new OrderRoleStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{orderId}/OrderItems/{orderItemSeqId}")]
        [HttpGet]
        public IOrderItemStateDto GetOrderItem(string orderId, string orderItemSeqId)
        {
          try {
            var state = (OrderItemState)_orderApplicationService.GetOrderItem(orderId, orderItemSeqId);
            if (state == null) { return null; }
            var stateDto = new OrderItemStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{orderId}/OrderShipGroups/{shipGroupSeqId}")]
        [HttpGet]
        public IOrderShipGroupStateDto GetOrderShipGroup(string orderId, long? shipGroupSeqId)
        {
          try {
            var state = (OrderShipGroupState)_orderApplicationService.GetOrderShipGroup(orderId, shipGroupSeqId);
            if (state == null) { return null; }
            var stateDto = new OrderShipGroupStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{orderId}/OrderShipGroups/{orderShipGroupShipGroupSeqId}/OrderItemShipGroupAssociations/{orderItemSeqId}")]
        [HttpGet]
        public IOrderItemShipGroupAssociationStateDto GetOrderItemShipGroupAssociation(string orderId, long? orderShipGroupShipGroupSeqId, string orderItemSeqId)
        {
          try {
            var state = (OrderItemShipGroupAssociationState)_orderApplicationService.GetOrderItemShipGroupAssociation(orderId, orderShipGroupShipGroupSeqId, orderItemSeqId);
            if (state == null) { return null; }
            var stateDto = new OrderItemShipGroupAssociationStateDtoWrapper(state);
            stateDto.AllFieldsReturned = true;
            return stateDto;
          } catch (Exception ex) { var response = OrdersControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return OrdersControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class OrdersControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteOrderDto value)
        {
            var idObj = id;
            if (value.OrderId == null)
            {
                value.OrderId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteOrder)value).OrderId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.OrderId);
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
            if (OrderMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return OrderMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (OrderMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return OrderMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IOrderStateDto> ToOrderStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IOrderStateDto>();
            foreach (var id in ids)
            {
                var dto = new OrderStateDtoWrapper();
                dto.OrderId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IOrderState> ToOrderStateCollection(IEnumerable<string> ids)
        {
            var states = new List<OrderState>();
            foreach (var id in ids)
            {
                var s = new OrderState();
                s.OrderId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

