﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.OrderItemShipGrpInvReservation;
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

    [RoutePrefix("api/OrderItemShipGrpInvReservations")]
    public partial class OrderItemShipGrpInvReservationsController : ApiController
    {

        IOrderItemShipGrpInvReservationApplicationService _orderItemShipGrpInvReservationApplicationService = ApplicationContext.Current["OrderItemShipGrpInvReservationApplicationService"] as IOrderItemShipGrpInvReservationApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IOrderItemShipGrpInvReservationStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IOrderItemShipGrpInvReservationState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _orderItemShipGrpInvReservationApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (OrderItemShipGrpInvReservationMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? OrderItemShipGrpInvReservationMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , OrderItemShipGrpInvReservationsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _orderItemShipGrpInvReservationApplicationService.Get(OrderItemShipGrpInvReservationsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , OrderItemShipGrpInvReservationsControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IOrderItemShipGrpInvReservationStateDto>();
            foreach (var s in states)
            {
                var dto = s is OrderItemShipGrpInvReservationStateDtoWrapper ? (OrderItemShipGrpInvReservationStateDtoWrapper)s : new OrderItemShipGrpInvReservationStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IOrderItemShipGrpInvReservationStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = OrderItemShipGrpInvReservationsControllerUtils.ParseIdString(id);
            var state = _orderItemShipGrpInvReservationApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new OrderItemShipGrpInvReservationStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _orderItemShipGrpInvReservationApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (OrderItemShipGrpInvReservationMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? OrderItemShipGrpInvReservationMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _orderItemShipGrpInvReservationApplicationService.GetCount(OrderItemShipGrpInvReservationsControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrderItemShipGrpInvReservationDto value)
        {
          try {
            OrderItemShipGrpInvReservationsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _orderItemShipGrpInvReservationApplicationService.When(value as ICreateOrderItemShipGrpInvReservation);
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchOrderItemShipGrpInvReservationDto value)
        {
          try {
            OrderItemShipGrpInvReservationsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _orderItemShipGrpInvReservationApplicationService.When(value as IMergePatchOrderItemShipGrpInvReservation);
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteOrderItemShipGrpInvReservationDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.Version = (long)Convert.ChangeType(version, typeof(long));
            OrderItemShipGrpInvReservationsControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _orderItemShipGrpInvReservationApplicationService.When(value as IDeleteOrderItemShipGrpInvReservation);
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in OrderItemShipGrpInvReservationMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public OrderItemShipGrpInvReservationStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = OrderItemShipGrpInvReservationsControllerUtils.ParseIdString(id);
            var conv = new OrderItemShipGrpInvReservationStateEventDtoConverter();
            var se = _orderItemShipGrpInvReservationApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToOrderItemShipGrpInvReservationStateEventDto(se);
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IOrderItemShipGrpInvReservationStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = OrderItemShipGrpInvReservationsControllerUtils.ParseIdString(id);
            var state = _orderItemShipGrpInvReservationApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new OrderItemShipGrpInvReservationStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = OrderItemShipGrpInvReservationsControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return OrderItemShipGrpInvReservationsControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class OrderItemShipGrpInvReservationsControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteOrderItemShipGrpInvReservationDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.OrderItemShipGrpInvResId == null)
            {
                value.OrderItemShipGrpInvResId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteOrderItemShipGrpInvReservation)value).OrderItemShipGrpInvResId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.OrderItemShipGrpInvResId);
            }
        }

        public static OrderItemShipGrpInvResId ParseIdString(string idString)
        {
            var formatter = new ValueObjectTextFormatter<OrderItemShipGrpInvResId>();
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
            if (OrderItemShipGrpInvReservationMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return OrderItemShipGrpInvReservationMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (OrderItemShipGrpInvReservationMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return OrderItemShipGrpInvReservationMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IOrderItemShipGrpInvReservationStateDto> ToOrderItemShipGrpInvReservationStateDtoCollection(IEnumerable<OrderItemShipGrpInvResId> ids)
        {
            var states = new List<IOrderItemShipGrpInvReservationStateDto>();
            foreach (var id in ids)
            {
                var dto = new OrderItemShipGrpInvReservationStateDtoWrapper();
                dto.OrderItemShipGrpInvResId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IOrderItemShipGrpInvReservationState> ToOrderItemShipGrpInvReservationStateCollection(IEnumerable<OrderItemShipGrpInvResId> ids)
        {
            var states = new List<OrderItemShipGrpInvReservationState>();
            foreach (var id in ids)
            {
                var s = new OrderItemShipGrpInvReservationState();
                s.OrderItemShipGrpInvResId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

