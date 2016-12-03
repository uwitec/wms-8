﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
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

    [RoutePrefix("api/UserLoginMvos")][Authorize]
    public partial class UserLoginMvosController : ApiController
    {

        IUserLoginMvoApplicationService _userLoginMvoApplicationService = ApplicationContext.Current["UserLoginMvoApplicationService"] as IUserLoginMvoApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IUserLoginMvoStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IUserLoginMvoState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _userLoginMvoApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                    , UserLoginMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _userLoginMvoApplicationService.Get(UserLoginMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , UserLoginMvosControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IUserLoginMvoStateDto>();
            foreach (var s in states)
            {
                var dto = s is UserLoginMvoStateDto ? (UserLoginMvoStateDto)s : new UserLoginMvoStateDto((UserLoginMvoState)s);
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
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IUserLoginMvoStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = UserLoginMvosControllerUtils.ParseIdString(id);
            var state = (UserLoginMvoState)_userLoginMvoApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new UserLoginMvoStateDto(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _userLoginMvoApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver()));
            }
            else 
            {
                count = _userLoginMvoApplicationService.GetCount(UserLoginMvosControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateUserLoginMvoDto value)
        {
          try {
            UserLoginMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _userLoginMvoApplicationService.When(value as ICreateUserLoginMvo);
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchUserLoginMvoDto value)
        {
          try {
            UserLoginMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _userLoginMvoApplicationService.When(value as IMergePatchUserLoginMvo);
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteUserLoginMvoDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.UserVersion = (long)Convert.ChangeType(version, typeof(long));
            UserLoginMvosControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _userLoginMvoApplicationService.When(value as IDeleteUserLoginMvo);
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadata> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadata>();
            foreach (var p in UserLoginMvoMetadata.Instance.Properties)
            {
                if (p.IsFilteringProperty)
                {
                    filtering.Add(p);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public UserLoginMvoStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = UserLoginMvosControllerUtils.ParseIdString(id);
            var conv = new UserLoginMvoStateEventDtoConverter();
            var se = _userLoginMvoApplicationService.GetStateEvent(idObj, version);
            return se == null ? null : conv.ToUserLoginMvoStateEventDto(se);
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IUserLoginMvoStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = UserLoginMvosControllerUtils.ParseIdString(id);
            var state = (UserLoginMvoState)_userLoginMvoApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new UserLoginMvoStateDto(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = UserLoginMvosControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return UserLoginMvosControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class UserLoginMvosControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteUserLoginMvoDto value)
        {
            var idObj = ParseIdString(id.IsNormalized() ? id : id.Normalize());
            if (value.UserLoginId == null)
            {
                value.UserLoginId = new UserLoginIdDtoWrapper(idObj);
            }
            else if (!((ICreateOrMergePatchOrDeleteUserLoginMvo)value).UserLoginId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.UserLoginId);
            }
        }

        public static UserLoginId ParseIdString(string idString)
        {
            var formatter = new UserLoginIdFlattenedDtoFormatter();
            var idDto = formatter.Parse(idString);
            var rId = idDto.ToUserLoginId();
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
            if (UserLoginMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(fieldName))
            {
                var p = UserLoginMvoMetadata.Instance.PropertyMetadataDictionary[fieldName];
                if (p.IsFilteringProperty)
                {
                    var propertyName = fieldName;
                    if (p.IsDerived)
                    {
                        propertyName = p.DerivedFrom;
                    }
                    return propertyName;
                }
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (UserLoginMvoMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return UserLoginMvoMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IUserLoginMvoStateDto> ToUserLoginMvoStateDtoCollection(IEnumerable<UserLoginId> ids)
        {
            var states = new List<UserLoginMvoStateDto>();
            foreach (var id in ids)
            {
                var dto = new UserLoginMvoStateDto();
                dto.UserLoginId = new UserLoginIdDtoWrapper(id);
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IUserLoginMvoState> ToUserLoginMvoStateCollection(IEnumerable<UserLoginId> ids)
        {
            var states = new List<UserLoginMvoState>();
            foreach (var id in ids)
            {
                var s = new UserLoginMvoState();
                s.UserLoginId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

