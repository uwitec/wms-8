﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateContactMechDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ContactMech;

namespace Dddml.Wms.Domain.ContactMech
{

	public abstract class ContactMechStateEventDtoBase : IEventDto, IContactMechStateCreated, IContactMechStateMergePatched, IContactMechStateDeleted
	{

        private ContactMechEventId _contactMechEventId;

		protected internal virtual ContactMechEventId ContactMechEventId 
        {
            get 
            {
                if (_contactMechEventId == null) { _contactMechEventId = new ContactMechEventId(); }
                return _contactMechEventId;
            }
            set
            {
                _contactMechEventId = value;
            }
        }

        public virtual string ContactMechId
        {
            get { return ContactMechEventId.ContactMechId; }
            set { ContactMechEventId.ContactMechId = value; }
        }

        public virtual long Version
        {
            get { return ContactMechEventId.Version; }
            set { ContactMechEventId.Version = value; }
        }

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

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

        public virtual string CommandId { get; set; }

        string IEvent.CommandId { get { return this.CommandId; } set { this.CommandId = value; } }

		ContactMechEventId IGlobalIdentity<ContactMechEventId>.GlobalId {
			get 
			{
				return this.ContactMechEventId;
			}
		}

        public virtual bool EventReadOnly { get; set; }

        bool IContactMechEvent.ReadOnly
        {
            get
            {
                return this.EventReadOnly;
            }
            set
            {
                this.EventReadOnly = value;
            }
        }

		public virtual bool? IsPropertyContactMechTypeIdRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyContactMechTypeIdRemoved
        {
            get 
            {
                var b = this.IsPropertyContactMechTypeIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyContactMechTypeIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyInfoStringRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyInfoStringRemoved
        {
            get 
            {
                var b = this.IsPropertyInfoStringRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyInfoStringRemoved = value;
            }
        }

		public virtual bool? IsPropertyToNameRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyToNameRemoved
        {
            get 
            {
                var b = this.IsPropertyToNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyToNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttnNameRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyAttnNameRemoved
        {
            get 
            {
                var b = this.IsPropertyAttnNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAttnNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyAddress1Removed { get; set; }

        bool IContactMechStateMergePatched.IsPropertyAddress1Removed
        {
            get 
            {
                var b = this.IsPropertyAddress1Removed;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAddress1Removed = value;
            }
        }

		public virtual bool? IsPropertyAddress2Removed { get; set; }

        bool IContactMechStateMergePatched.IsPropertyAddress2Removed
        {
            get 
            {
                var b = this.IsPropertyAddress2Removed;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAddress2Removed = value;
            }
        }

		public virtual bool? IsPropertyDirectionsRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyDirectionsRemoved
        {
            get 
            {
                var b = this.IsPropertyDirectionsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyDirectionsRemoved = value;
            }
        }

		public virtual bool? IsPropertyCityRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyCityRemoved
        {
            get 
            {
                var b = this.IsPropertyCityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCityRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostalCodeRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyPostalCodeRemoved
        {
            get 
            {
                var b = this.IsPropertyPostalCodeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPostalCodeRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostalCodeExtRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyPostalCodeExtRemoved
        {
            get 
            {
                var b = this.IsPropertyPostalCodeExtRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPostalCodeExtRemoved = value;
            }
        }

		public virtual bool? IsPropertyCountryGeoIdRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyCountryGeoIdRemoved
        {
            get 
            {
                var b = this.IsPropertyCountryGeoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCountryGeoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyStateProvinceGeoIdRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyStateProvinceGeoIdRemoved
        {
            get 
            {
                var b = this.IsPropertyStateProvinceGeoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyStateProvinceGeoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyCountyGeoIdRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyCountyGeoIdRemoved
        {
            get 
            {
                var b = this.IsPropertyCountyGeoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCountyGeoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyPostalCodeGeoIdRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyPostalCodeGeoIdRemoved
        {
            get 
            {
                var b = this.IsPropertyPostalCodeGeoIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyPostalCodeGeoIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyGeoPointIdRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyGeoPointIdRemoved
        {
            get 
            {
                var b = this.IsPropertyGeoPointIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyGeoPointIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyCountryCodeRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyCountryCodeRemoved
        {
            get 
            {
                var b = this.IsPropertyCountryCodeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyCountryCodeRemoved = value;
            }
        }

		public virtual bool? IsPropertyAreaCodeRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyAreaCodeRemoved
        {
            get 
            {
                var b = this.IsPropertyAreaCodeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAreaCodeRemoved = value;
            }
        }

		public virtual bool? IsPropertyContactNumberRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyContactNumberRemoved
        {
            get 
            {
                var b = this.IsPropertyContactNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyContactNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyAskForNameRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyAskForNameRemoved
        {
            get 
            {
                var b = this.IsPropertyAskForNameRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyAskForNameRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IContactMechStateMergePatched.IsPropertyActiveRemoved
        {
            get 
            {
                var b = this.IsPropertyActiveRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.IsPropertyActiveRemoved = value;
            }
        }

		string ICreated<string>.CreatedBy {
			get {
				return this.CreatedBy;
			}
			set {
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt {
			get {
				return this.CreatedAt;
			}
			set {
				this.CreatedAt = value;
			}
		}


        ContactMechEventId IContactMechEvent.ContactMechEventId
        {
            get { return this.ContactMechEventId; }
        }

        protected ContactMechStateEventDtoBase()
        {
        }

        protected ContactMechStateEventDtoBase(ContactMechEventId stateEventId)
        {
            this.ContactMechEventId = stateEventId;
        }

        // //////////////////////////////////////////////////

        string IEventDto.EventType 
        {
            get { return this.GetEventType(); }
        }

        protected abstract string GetEventType();

	}


    public class ContactMechStateCreatedOrMergePatchedOrDeletedDto : ContactMechStateEventDtoBase
    {
        private string _eventType;

        public virtual string EventType
        {
            get { return _eventType; }
            set { _eventType = value; }
        }

        protected override string GetEventType()
        {
            return this._eventType;
        }

    }



	public class ContactMechStateCreatedDto : ContactMechStateCreatedOrMergePatchedOrDeletedDto
	{
		public ContactMechStateCreatedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Created;
        }

	}


	public class ContactMechStateMergePatchedDto : ContactMechStateCreatedOrMergePatchedOrDeletedDto
	{
		public ContactMechStateMergePatchedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.MergePatched;
        }

	}


	public class ContactMechStateDeletedDto : ContactMechStateCreatedOrMergePatchedOrDeletedDto
	{
		public ContactMechStateDeletedDto()
		{
		}

        public override string EventType
        {
            get { return this.GetEventType(); }
            set
            {
                // do nothing
            }
        }

        protected override string GetEventType()
        {
            return Dddml.Wms.Specialization.StateEventType.Deleted;
        }

	}


    public partial class ContactMechStateCreatedOrMergePatchedOrDeletedDtos : IEnumerable<IContactMechStateCreated>, IEnumerable<IContactMechStateMergePatched>, IEnumerable<IContactMechStateDeleted>
    {
        private List<ContactMechStateCreatedOrMergePatchedOrDeletedDto> _innerStateEvents = new List<ContactMechStateCreatedOrMergePatchedOrDeletedDto>();

        public virtual ContactMechStateCreatedOrMergePatchedOrDeletedDto[] ToArray()
        {
            return _innerStateEvents.ToArray();
        }

        public virtual void Clear()
        {
            _innerStateEvents.Clear();
        }

        public virtual void AddRange(IEnumerable<ContactMechStateCreatedOrMergePatchedOrDeletedDto> es)
        {
            _innerStateEvents.AddRange(es);
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IContactMechStateCreated> IEnumerable<IContactMechStateCreated>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IContactMechStateMergePatched> IEnumerable<IContactMechStateMergePatched>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        IEnumerator<IContactMechStateDeleted> IEnumerable<IContactMechStateDeleted>.GetEnumerator()
        {
            return _innerStateEvents.GetEnumerator();
        }

        public void AddContactMechEvent(IContactMechStateCreated e)
        {
            _innerStateEvents.Add((ContactMechStateCreatedDto)e);
        }

        public void AddContactMechEvent(IContactMechEvent e)
        {
            _innerStateEvents.Add((ContactMechStateCreatedOrMergePatchedOrDeletedDto)e);
        }

        public void AddContactMechEvent(IContactMechStateDeleted e)
        {
            _innerStateEvents.Add((ContactMechStateDeletedDto)e);
        }

    }


}

