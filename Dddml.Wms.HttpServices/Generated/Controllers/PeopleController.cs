﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAggregatesControllers.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Party;
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

    [RoutePrefix("api/People")]
    public partial class PeopleController : ApiController
    {

        IPartyApplicationService _partyApplicationService = ApplicationContext.Current["PartyApplicationService"] as IPartyApplicationService;

        [Route(Order = 1)]
        [HttpGet]
        public IEnumerable<IPartyStateDto> GetAll(string sort = null, string fields = null, int firstResult = 0, int maxResults = int.MaxValue, string filter = null)
        {
          try {
            IEnumerable<IPartyState> states = null; 
            if (!String.IsNullOrWhiteSpace(filter))
            {
                states = _partyApplicationService.Get<PersonState>(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (PartyMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? PartyMetadata.Instance.FilteringPropertyAliasDictionary[n] : n))
                    , PeopleControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            else 
            {
                states = _partyApplicationService.Get<PersonState>(PeopleControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs())
                    , PeopleControllerUtils.GetQueryOrders(sort, QueryOrderSeparator), firstResult, maxResults);
            }
            var stateDtos = new List<IPartyStateDto>();
            foreach (var s in states)
            {
                var dto = s is PartyStateDtoWrapper ? (PartyStateDtoWrapper)s : new PartyStateDtoWrapper(s);
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
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpGet]
        public IPartyStateDto Get(string id, string fields = null)
        {
          try {
            var idObj = id;
            var state = _partyApplicationService.Get(idObj);
            if (state == null) { return null; }
            if (state != null && !typeof(IPersonState).IsAssignableFrom(state.GetType())) 
            {
                return null;
            }
            var stateDto = new PartyStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                count = _partyApplicationService.GetCount<PersonState>(CriterionDto.ToSubclass(JObject.Parse(filter).ToObject<CriterionDto>(), new ApiControllerTypeConverter(), new PropertyTypeResolver()
                    , n => (PartyMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(n) ? PartyMetadata.Instance.FilteringPropertyAliasDictionary[n] : n)));
            }
            else 
            {
                count = _partyApplicationService.GetCount<PersonState>(PeopleControllerUtils.GetQueryFilterDictionary(this.Request.GetQueryNameValuePairs()));
            }
            return count;
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route(Order = 1)]
        [HttpPost][SetRequesterId]
        public HttpResponseMessage Post([FromBody]CreatePartyDto value)
        {
          try {
            value.PartyTypeId = PartyTypeIds.Person;
            if (value.PartyId == default(string))
            {
                throw DomainError.Named("nullId", "Aggregate Id in cmd is null, aggregate name: {0}.", "Party");
            }
            _partyApplicationService.When(value as ICreateParty);
            var idObj = value.PartyId;

            return Request.CreateResponse<string>(HttpStatusCode.Created, idObj);
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPut][SetRequesterId]
        public void Put(string id, [FromBody]CreateOrMergePatchOrDeletePartyDto value)
        {
          try {
            value.PartyTypeId = PartyTypeIds.Person;
              // ///////////////////////////////
              if (value.Version != default(long))
              {
                  value.CommandType = CommandType.MergePatch;
                  PeopleControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
                  _partyApplicationService.When(value as IMergePatchParty);
                  return;
              }
              // ///////////////////////////////

            PeopleControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _partyApplicationService.When(value as ICreateParty);
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpPatch][SetRequesterId]
        public void Patch(string id, [FromBody]MergePatchPartyDto value)
        {
          try {
            value.PartyTypeId = PartyTypeIds.Person;
            PeopleControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _partyApplicationService.When(value as IMergePatchParty);
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [HttpDelete][SetRequesterId]
        public void Delete(string id, string commandId, string version, string requesterId = default(string))
        {
          try {
            var value = new DeletePartyDto();
            value.PartyTypeId = PartyTypeIds.Person;
            value.CommandId = commandId;
            value.RequesterId = requesterId;
            value.Version = (long)Convert.ChangeType(version, typeof(long));
            PeopleControllerUtils.SetNullIdOrThrowOnInconsistentIds(id, value);
            _partyApplicationService.When(value as IDeleteParty);
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("_metadata/filteringFields")]
        [HttpGet]
        public IEnumerable<PropertyMetadataDto> GetMetadataFilteringFields()
        {
          try {
            var filtering = new List<PropertyMetadataDto>();
            foreach (var p in PartyMetadata.Instance.Properties)
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
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_stateEvents/{version}")]
        [HttpGet]
        public PartyStateCreatedOrMergePatchedOrDeletedDto GetStateEvent(string id, long version)
        {
          try {
            var idObj = id;
            var conv = new PartyStateEventDtoConverter();
            var se = _partyApplicationService.GetEvent(idObj, version);
            return se == null ? null : conv.ToPartyStateEventDto(se);
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
        }

        [Route("{id}/_historyStates/{version}")]
        [HttpGet]
        public IPartyStateDto GetHistoryState(string id, long version, string fields = null)
        {
          try {
            var idObj = id;
            var state = _partyApplicationService.GetHistoryState(idObj, version);
            if (state == null) { return null; }
            var stateDto = new PartyStateDtoWrapper(state);
            if (String.IsNullOrWhiteSpace(fields))
            {
                stateDto.AllFieldsReturned = true;
            }
            else
            {
                stateDto.ReturnedFieldsString = fields;
            }
            return stateDto;
          } catch (Exception ex) { var response = PeopleControllerUtils.GetErrorHttpResponseMessage(ex); throw new HttpResponseException(response); }
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
                return PeopleControllerUtils.GetFilterPropertyType(propertyName);
            }
        }

    }


    
    public static class PeopleControllerUtils
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

        public static void SetNullIdOrThrowOnInconsistentIds(string id, CreateOrMergePatchOrDeletePartyDto value)
        {
            var idObj = id;
            if (value.PartyId == null)
            {
                value.PartyId = idObj;
            }
            else if (!((ICreateOrMergePatchOrDeleteParty)value).PartyId.Equals(idObj))
            {
                throw DomainError.Named("inconsistentId", "Argument Id {0} NOT equals body Id {1}", id, value.PartyId);
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
            if (PartyMetadata.Instance.FilteringPropertyAliasDictionary.ContainsKey(fieldName))
            {
                return PartyMetadata.Instance.FilteringPropertyAliasDictionary[fieldName];
            }
            return null;
        }

        public static Type GetFilterPropertyType(string propertyName)
        {
            if (PartyMetadata.Instance.PropertyMetadataDictionary.ContainsKey(propertyName))
            {
                return PartyMetadata.Instance.PropertyMetadataDictionary[propertyName].Type;
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

        public static IEnumerable<IPartyStateDto> ToPartyStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IPartyStateDto>();
            foreach (var id in ids)
            {
                var dto = new PartyStateDtoWrapper();
                dto.PartyId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IPartyState> ToPartyStateCollection(IEnumerable<string> ids)
        {
            var states = new List<PartyState>();
            foreach (var id in ids)
            {
                var s = new PartyState();
                s.PartyId = id;
                states.Add(s);
            }
            return states;
        }

        public static IEnumerable<IOrganizationStateDto> ToOrganizationStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IOrganizationStateDto>();
            foreach (var id in ids)
            {
                var dto = new OrganizationStateDtoWrapper();
                dto.PartyId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IOrganizationState> ToOrganizationStateCollection(IEnumerable<string> ids)
        {
            var states = new List<OrganizationState>();
            foreach (var id in ids)
            {
                var s = new OrganizationState();
                s.PartyId = id;
                states.Add(s);
            }
            return states;
        }

        public static IEnumerable<IPersonStateDto> ToPersonStateDtoCollection(IEnumerable<string> ids)
        {
            var states = new List<IPersonStateDto>();
            foreach (var id in ids)
            {
                var dto = new PersonStateDtoWrapper();
                dto.PartyId = id;
                states.Add(dto);
            }
            return states;
        }

        public static IEnumerable<IPersonState> ToPersonStateCollection(IEnumerable<string> ids)
        {
            var states = new List<PersonState>();
            foreach (var id in ids)
            {
                var s = new PersonState();
                s.PartyId = id;
                states.Add(s);
            }
            return states;
        }

    }

}

