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

	public abstract class ContactMechCommandDtoBase : ICommandDto, ICreateContactMech, IMergePatchContactMech, IDeleteContactMech
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteContactMech)this).ContactMechId;
			}
		}


		long IAggregateCommand<string, long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}

		public virtual long Version { get; set; }

		public virtual string RequesterId { get; set; }

		public virtual string CommandId { get; set; }

        object ICommand.RequesterId
        {
            get { return this.RequesterId; }
            set { this.RequesterId = (string)value; }
        }

        string ICommand.CommandId
        {
            get { return this.CommandId; }
            set { this.CommandId = value; }
        }

		public virtual string ContactMechId { get; set; }

		public virtual string ContactMechTypeId { get; set; }

		public virtual string InfoString { get; set; }

		public virtual string ToName { get; set; }

		public virtual string AttnName { get; set; }

		public virtual string Address1 { get; set; }

		public virtual string Address2 { get; set; }

		public virtual string Directions { get; set; }

		public virtual string City { get; set; }

		public virtual string PostalCode { get; set; }

		public virtual string PostalCodeExt { get; set; }

		public virtual string CountryGeoId { get; set; }

		public virtual string StateProvinceGeoId { get; set; }

		public virtual string CountyGeoId { get; set; }

		public virtual string PostalCodeGeoId { get; set; }

		public virtual string GeoPointId { get; set; }

		public virtual string CountryCode { get; set; }

		public virtual string AreaCode { get; set; }

		public virtual string ContactNumber { get; set; }

		public virtual string AskForName { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? IsPropertyContactMechTypeIdRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyContactMechTypeIdRemoved
        {
            get
            {
                var b = this.IsPropertyContactMechTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyContactMechTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInfoStringRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyInfoStringRemoved
        {
            get
            {
                var b = this.IsPropertyInfoStringRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyInfoStringRemoved = value;
            }
        }

		public virtual bool? IsPropertyToNameRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyToNameRemoved
        {
            get
            {
                var b = this.IsPropertyToNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyToNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttnNameRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyAttnNameRemoved
        {
            get
            {
                var b = this.IsPropertyAttnNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttnNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAddress1Removed { get; set; }

        bool IMergePatchContactMech.IsPropertyAddress1Removed
        {
            get
            {
                var b = this.IsPropertyAddress1Removed;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAddress1Removed = value;
            }
        }

		public virtual bool? IsPropertyAddress2Removed { get; set; }

        bool IMergePatchContactMech.IsPropertyAddress2Removed
        {
            get
            {
                var b = this.IsPropertyAddress2Removed;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAddress2Removed = value;
            }
        }

		public virtual bool? IsPropertyDirectionsRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyDirectionsRemoved
        {
            get
            {
                var b = this.IsPropertyDirectionsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDirectionsRemoved = value;
            }
        }

		public virtual bool? IsPropertyCityRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyCityRemoved
        {
            get
            {
                var b = this.IsPropertyCityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCityRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostalCodeRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyPostalCodeRemoved
        {
            get
            {
                var b = this.IsPropertyPostalCodeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPostalCodeRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostalCodeExtRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyPostalCodeExtRemoved
        {
            get
            {
                var b = this.IsPropertyPostalCodeExtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPostalCodeExtRemoved = value;
            }
        }

		public virtual bool? IsPropertyCountryGeoIdRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyCountryGeoIdRemoved
        {
            get
            {
                var b = this.IsPropertyCountryGeoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCountryGeoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyStateProvinceGeoIdRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyStateProvinceGeoIdRemoved
        {
            get
            {
                var b = this.IsPropertyStateProvinceGeoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyStateProvinceGeoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyCountyGeoIdRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyCountyGeoIdRemoved
        {
            get
            {
                var b = this.IsPropertyCountyGeoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCountyGeoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostalCodeGeoIdRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyPostalCodeGeoIdRemoved
        {
            get
            {
                var b = this.IsPropertyPostalCodeGeoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPostalCodeGeoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyGeoPointIdRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyGeoPointIdRemoved
        {
            get
            {
                var b = this.IsPropertyGeoPointIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyGeoPointIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyCountryCodeRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyCountryCodeRemoved
        {
            get
            {
                var b = this.IsPropertyCountryCodeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCountryCodeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAreaCodeRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyAreaCodeRemoved
        {
            get
            {
                var b = this.IsPropertyAreaCodeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAreaCodeRemoved = value;
            }
        }

		public virtual bool? IsPropertyContactNumberRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyContactNumberRemoved
        {
            get
            {
                var b = this.IsPropertyContactNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyContactNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyAskForNameRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyAskForNameRemoved
        {
            get
            {
                var b = this.IsPropertyAskForNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAskForNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchContactMech.IsPropertyActiveRemoved
        {
            get
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyActiveRemoved = value;
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteContactMechDto : ContactMechCommandDtoBase
    {
        private string _commandType;

        public virtual string CommandType
        {
            get { return _commandType; }
            set { _commandType = value; }
        }

        protected override string GetCommandType()
        {
            return this._commandType;
        }

    }



	public class CreateContactMechDto : CreateOrMergePatchOrDeleteContactMechDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }

	}


	public class MergePatchContactMechDto : CreateOrMergePatchOrDeleteContactMechDto
	{

        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteContactMechDto : CreateOrMergePatchOrDeleteContactMechDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}

    public static partial class ContactMechCommandDtos
    {

    }

}

