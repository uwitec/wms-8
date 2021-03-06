﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ProductCategory;
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

    [RoutePrefix("api/ProductCategories")]
    public partial class ProductCategoriesController : ApiController
    {

        IProductCategoryApplicationService _productCategoryApplicationService = ApplicationContext.Current["ProductCategoryApplicationService"] as IProductCategoryApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IProductCategoryStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IProductCategoryState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _productCategoryApplicationService.Get(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (ProductCategoryMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? ProductCategoryMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , ProductCategoriesControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _productCategoryApplicationService.Get(ProductCategoriesControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , ProductCategoriesControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IProductCategoryStateDto>();
            foreach (var s in states)
            {
                var dto = s is ProductCategoryStateDtoWrapper ? (ProductCategoryStateDtoWrapper)s : new ProductCategoryStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IProductCategoryStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = id;
            var state = _productCategoryApplicationService.Get(idObj);
            if (state == null) { return null; }
            var stateDto = new ProductCategoryStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _productCategoryApplicationService.GetCount(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (ProductCategoryMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? ProductCategoryMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _productCategoryApplicationService.GetCount(ProductCategoriesControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/ChildProductCategories")]
        [HttpGet]
        public IEnumerable<IProductCategoryStateDto> GetChildProductCategories(string id)
        {
          try {
            var idObj = id;
            var states = _productCategoryApplicationService.GetChildProductCategories(idObj);
            if (states == null) { return null; }
            var stateDtos = new List<IProductCategoryStateDto>();
            foreach (var s in states)
            {
                var dto = s is ProductCategoryStateDtoWrapper ? (ProductCategoryStateDtoWrapper)s : new ProductCategoryStateDtoWrapper((IProductCategoryState)s);
                dto.AllFieldsReturned = true;
                stateDtos.Add(dto);
            }
            return stateDtos;
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreateProductCategoryDto value)
        {
          try {
            if (value.ProductCategoryId == default(string))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "ProductCategory");
            }
            _productCategoryApplicationService.When(value as ICreateProductCategory);
            var idObj = value.ProductCategoryId;

            return Request.CreateResponse<string>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeleteProductCategoryDto value)
        {
          try {
              // ///////////////////////////////
              if (value.Version != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  ProductCategoriesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _productCategoryApplicationService.When(value as IMergePatchProductCategory);
                  return;
              }
              // ///////////////////////////////

            ProductCategoriesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _productCategoryApplicationService.When(value as ICreateProductCategory);
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchProductCategoryDto value)
        {
          try {
            ProductCategoriesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _productCategoryApplicationService.When(value as IMergePatchProductCategory);
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeleteProductCategoryDto();
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.Version = (long)Convert.ChangeType(version, typeof(long));
            ProductCategoriesControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _productCategoryApplicationService.When(value as IDeleteProductCategory);
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in ProductCategoryMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public ProductCategoryStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = id;
            var conv = new ProductCategoryStateEventDtoConverter();
            var se = _productCategoryApplicationService.GetEvent(idObj, version);
            return se == null ? null : conv.ToProductCategoryStateEventDto(se);
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IProductCategoryStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = id;
            var state = _productCategoryApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new ProductCategoryStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = ProductCategoriesControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return ProductCategoriesControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class ProductCategoriesControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeleteProductCategoryDto value)
        {
            var idObj = id;
            if (value.ProductCategoryId == null)
            {
                value.ProductCategoryId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteProductCategory)value).ProductCategoryId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.ProductCategoryId);
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
            if (ProductCategoryMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return ProductCategoryMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (ProductCategoryMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return ProductCategoryMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IProductCategoryStateDto> ToProductCategoryStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IProductCategoryStateDto>();
            foreach (var id in ids)
            {
                var dto = new ProductCategoryStateDtoWrapper();
                dto.ProductCategoryId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IProductCategoryState> ToProductCategoryStateCollection(IEnumerable<string> ids)
        {
            var states = new List<ProductCategoryState>();
            foreach (var id in ids)
            {
                var s = new ProductCategoryState();
                s.ProductCategoryId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

