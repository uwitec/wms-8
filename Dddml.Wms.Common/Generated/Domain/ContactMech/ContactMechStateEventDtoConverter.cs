﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateContactMechDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ContactMech;

namespace Dddml.Wms.Domain.ContactMech
{

    public class ContactMechStateEventDtoConverter
    {
        public virtual ContactMechStateCreatedOrMergePatchedOrDeletedDto ToContactMechStateEventDto(IContactMechEvent stateEvent)
        {
            if (stateEvent.EventType == StateEventType.Created)
            {
                var e = (IContactMechStateCreated)stateEvent;
                return ToContactMechStateCreatedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.MergePatched)
            {
                var e = (IContactMechStateMergePatched)stateEvent;
                return ToContactMechStateMergePatchedDto(e);
            }
            else if (stateEvent.EventType == StateEventType.Deleted)
            {
                var e = (IContactMechStateDeleted)stateEvent;
                return ToContactMechStateDeletedDto(e);
            }
            throw DomainError.Named("invalidEventType", String.Format("Invalid state event type: {0}", stateEvent.EventType));
        }

        public virtual ContactMechStateCreatedDto ToContactMechStateCreatedDto(IContactMechStateCreated e)
        {
            var dto = new ContactMechStateCreatedDto();
            dto.ContactMechEventId = e.ContactMechEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ContactMechTypeId = e.ContactMechTypeId;
            dto.InfoString = e.InfoString;
            dto.ToName = e.ToName;
            dto.AttnName = e.AttnName;
            dto.Address1 = e.Address1;
            dto.Address2 = e.Address2;
            dto.Directions = e.Directions;
            dto.City = e.City;
            dto.PostalCode = e.PostalCode;
            dto.PostalCodeExt = e.PostalCodeExt;
            dto.CountryGeoId = e.CountryGeoId;
            dto.StateProvinceGeoId = e.StateProvinceGeoId;
            dto.CountyGeoId = e.CountyGeoId;
            dto.PostalCodeGeoId = e.PostalCodeGeoId;
            dto.GeoPointId = e.GeoPointId;
            dto.CountryCode = e.CountryCode;
            dto.AreaCode = e.AreaCode;
            dto.ContactNumber = e.ContactNumber;
            dto.AskForName = e.AskForName;
            dto.Active = e.Active;
            return dto;
        }

        public virtual ContactMechStateMergePatchedDto ToContactMechStateMergePatchedDto(IContactMechStateMergePatched e)
        {
            var dto = new ContactMechStateMergePatchedDto();
            dto.ContactMechEventId = e.ContactMechEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;
            dto.ContactMechTypeId = e.ContactMechTypeId;
            dto.InfoString = e.InfoString;
            dto.ToName = e.ToName;
            dto.AttnName = e.AttnName;
            dto.Address1 = e.Address1;
            dto.Address2 = e.Address2;
            dto.Directions = e.Directions;
            dto.City = e.City;
            dto.PostalCode = e.PostalCode;
            dto.PostalCodeExt = e.PostalCodeExt;
            dto.CountryGeoId = e.CountryGeoId;
            dto.StateProvinceGeoId = e.StateProvinceGeoId;
            dto.CountyGeoId = e.CountyGeoId;
            dto.PostalCodeGeoId = e.PostalCodeGeoId;
            dto.GeoPointId = e.GeoPointId;
            dto.CountryCode = e.CountryCode;
            dto.AreaCode = e.AreaCode;
            dto.ContactNumber = e.ContactNumber;
            dto.AskForName = e.AskForName;
            dto.Active = e.Active;
            dto.IsPropertyContactMechTypeIdRemoved = e.IsPropertyContactMechTypeIdRemoved;
            dto.IsPropertyInfoStringRemoved = e.IsPropertyInfoStringRemoved;
            dto.IsPropertyToNameRemoved = e.IsPropertyToNameRemoved;
            dto.IsPropertyAttnNameRemoved = e.IsPropertyAttnNameRemoved;
            dto.IsPropertyAddress1Removed = e.IsPropertyAddress1Removed;
            dto.IsPropertyAddress2Removed = e.IsPropertyAddress2Removed;
            dto.IsPropertyDirectionsRemoved = e.IsPropertyDirectionsRemoved;
            dto.IsPropertyCityRemoved = e.IsPropertyCityRemoved;
            dto.IsPropertyPostalCodeRemoved = e.IsPropertyPostalCodeRemoved;
            dto.IsPropertyPostalCodeExtRemoved = e.IsPropertyPostalCodeExtRemoved;
            dto.IsPropertyCountryGeoIdRemoved = e.IsPropertyCountryGeoIdRemoved;
            dto.IsPropertyStateProvinceGeoIdRemoved = e.IsPropertyStateProvinceGeoIdRemoved;
            dto.IsPropertyCountyGeoIdRemoved = e.IsPropertyCountyGeoIdRemoved;
            dto.IsPropertyPostalCodeGeoIdRemoved = e.IsPropertyPostalCodeGeoIdRemoved;
            dto.IsPropertyGeoPointIdRemoved = e.IsPropertyGeoPointIdRemoved;
            dto.IsPropertyCountryCodeRemoved = e.IsPropertyCountryCodeRemoved;
            dto.IsPropertyAreaCodeRemoved = e.IsPropertyAreaCodeRemoved;
            dto.IsPropertyContactNumberRemoved = e.IsPropertyContactNumberRemoved;
            dto.IsPropertyAskForNameRemoved = e.IsPropertyAskForNameRemoved;
            dto.IsPropertyActiveRemoved = e.IsPropertyActiveRemoved;

            return dto;
        }


        public virtual ContactMechStateDeletedDto ToContactMechStateDeletedDto(IContactMechStateDeleted e)
        {
            var dto = new ContactMechStateDeletedDto();
            dto.ContactMechEventId = e.ContactMechEventId;
            dto.CreatedAt = e.CreatedAt;
            dto.CreatedBy = e.CreatedBy;
            dto.CommandId = e.CommandId;

            return dto;
        }


    }


}

