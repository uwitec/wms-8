﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ComponentModel;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Web.Http;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;
using Newtonsoft.Json.Linq;
using Dddml.Wms.Domain.Metadata;
using Dddml.Support.Criterion;

namespace Dddml.Wms.HttpServices.ApiControllers
{

    [RoutePrefix("api/AttributeSetInstanceExtensionFieldGroups")]
    public partial class AttributeSetInstanceExtensionFieldGroupsController : ApiController
    {

        IAttributeSetInstanceExtensionFieldGroupApplicationService _attributeSetInstanceExtensionFieldGroupApplicationService = ApplicationContext.Current["AttributeSetInstanceExtensionFieldGroupApplicationService"] as IAttributeSetInstanceExtensionFieldGroupApplicationService;

        [HttpGet]
        public IEnumerable<AttributeSetInstanceExtensionFieldGroupStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IAttributeSetInstanceExtensionFieldGroupState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _attributeSetInstanceExtensionFieldGroupApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver())
                    , GetQueryOrders(sort), firstResult, maxResults);
            }
            else 
            {
                states = _attributeSetInstanceExtensionFieldGroupApplicationService.Get(GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , GetQueryOrders(sort), firstResult, maxResults);
            }
            var stateDtos = new List<AttributeSetInstanceExtensionFieldGroupStateDto>();
            foreach (var s in states)
            {
                var dto = new AttributeSetInstanceExtensionFieldGroupStateDto((AttributeSetInstanceExtensionFieldGroupState)s);
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
          } catch (Exception ex) { var response = GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public AttributeSetInstanceExtensionFieldGroupStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = id;
            var state = (AttributeSetInstanceExtensionFieldGroupState)_attributeSetInstanceExtensionFieldGroupApplicationService.Get(idObj);
            var stateDto = new AttributeSetInstanceExtensionFieldGroupStateDto(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _attributeSetInstanceExtensionFieldGroupApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(),new ApiControllerTypeConverter(), new PropertyTypeResolver()));
            }
            else 
            {
                count = _attributeSetInstanceExtensionFieldGroupApplicationService.GetCount(GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut]
        public void Put(string id, [FromBody]CreateAttributeSetInstanceExtensionFieldGroupDto value)
        {
          try {
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldGroupApplicationService.When(value as ICreateAttributeSetInstanceExtensionFieldGroup);
          } catch (Exception ex) { var response = GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch]
        public void Patch(string id, [FromBody]MergePatchAttributeSetInstanceExtensionFieldGroupDto value)
        {
          try {
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldGroupApplicationService.When(value as IMergePatchAttributeSetInstanceExtensionFieldGroup);
          } catch (Exception ex) { var response = GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete]
        public void Delete(string id, string commandId, string requesterId = default(string))
        {
          try {
            var value = new DeleteAttributeSetInstanceExtensionFieldGroupDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            SetNullIdOrThrowOnInconsistentIds(id, value);
            _attributeSetInstanceExtensionFieldGroupApplicationService.When(value as IDeleteAttributeSetInstanceExtensionFieldGroup);
          } catch (Exception ex) { var response = GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadata> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadata>();
            foreach (var p in AttributeSetInstanceExtensionFieldGroupMetadata.Instance.Properties)
            {
                if (PropertyMetadata.IsFilteringProperty(p))
                {
                    filtering.Add(p);
                }
            }
            return filtering;
          } catch (Exception ex) { var response = GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public IAttributeSetInstanceExtensionFieldGroupStateEvent GetStateEvent(string id, long version)
        {
          try {
            var idObj = id;
            return _attributeSetInstanceExtensionFieldGroupApplicationService.GetStateEvent(idObj, version);
          } catch (Exception ex) { var response = GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }


		// /////////////////////////////////////////////////

        protected virtual HttpResponseMessage GetErrorHttpResponseMessage(Exception ex)
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

        protected static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroupDto value)
        {
            var idObj = id;
            if (value.Id == null)
            {
                value.Id = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroup)value).Id.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.Id);
            }
        }


        protected virtual string GetFilterPropertyName(string fieldName)
        {
            if (String.Equals(fieldName, "sort", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "firstResult", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "maxResults", StringComparison.InvariantCultureIgnoreCase)
                || String.Equals(fieldName, "fields", StringComparison.InvariantCultureIgnoreCase))
            {
                return null;
            }
            if (AttributeSetInstanceExtensionFieldGroupMetadata.Instance.PropertyMetadataDictionary.ContainsKey(fieldName))
            {
                var p = AttributeSetInstanceExtensionFieldGroupMetadata.Instance.PropertyMetadataDictionary[fieldName];
                if (PropertyMetadata.IsFilteringProperty(p))
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

        protected static Type GetFilterPropertyType(string propertyName)
        {
            if (AttributeSetInstanceExtensionFieldGroupMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return AttributeSetInstanceExtensionFieldGroupMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
            }
            return typeof(string);
        }

        private IDictionary<string, object> GetQueryFilterDictionary(IEnumerable<KeyValuePair<string, string>> queryNameValuePairs)
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

        private IList<string> GetQueryOrders(string str)
        {
            if (String.IsNullOrWhiteSpace(str))
            {
                return new string[0];
            }
            var arr = str.Split(new string[] { QueryOrderSeparator }, StringSplitOptions.RemoveEmptyEntries);
            var orders = new List<string>();
            foreach (var a in arr)
            {
                orders.Add(a.Trim());
            }
            return orders;
        }

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
                return GetFilterPropertyType(propertyName);
            }
        }

    }



}

