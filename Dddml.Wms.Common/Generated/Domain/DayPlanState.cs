﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public partial class DayPlanState : DayPlanStateProperties, IDayPlanState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }


		#region IIdentity implementation

        private DayPlanId _dayPlanId = new DayPlanId();

        public virtual DayPlanId DayPlanId 
        {
            get { return this._dayPlanId; }
            set { this._dayPlanId = value; }
        }

		DayPlanId IGlobalIdentity<DayPlanId>.GlobalId {
			get {
				return  this.DayPlanId;
			}
		}

        int ILocalIdentity<int>.LocalId
        {
            get
            {
                return this.Day;
            }
        }


        public override PersonalName PersonalName {
			get {
				return this.DayPlanId.PersonalName;
			}
			set {
				this.DayPlanId.PersonalName = value;
			}
		}

        public override int Year {
			get {
				return this.DayPlanId.Year;
			}
			set {
				this.DayPlanId.Year = value;
			}
		}

        public override int Month {
			get {
				return this.DayPlanId.Month;
			}
			set {
				this.DayPlanId.Month = value;
			}
		}

        public override int Day {
			get {
				return this.DayPlanId.Day;
			}
			set {
				this.DayPlanId.Day = value;
			}
		}

		#endregion



		#region IActive implementation

		bool IActive.Active
		{
			get
			{
				return this.Active;
			}
		}

		#endregion

		#region IDeleted implementation

		bool IDeleted.Deleted
		{
			get
			{
				return this.Deleted;
			}
		}

		#endregion

		#region ICreated implementation

		string ICreated<string>.CreatedBy
		{
			get
			{
				return this.CreatedBy;
			}
			set
			{
				this.CreatedBy = value;
			}
		}

		DateTime ICreated<string>.CreatedAt
		{
			get
			{
				return this.CreatedAt;
			}
			set
			{
				this.CreatedAt = value;
			}
		}

		#endregion

		#region IUpdated implementation

		string IUpdated<string>.UpdatedBy
		{
			get
			{
				return this.UpdatedBy;
			}
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get
			{
				return this.UpdatedAt;
			}
		}

		#endregion

		#region IVersioned implementation

		long IVersioned<long>.Version
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IDayPlanState.IsUnsaved
        {
            get { return ((IVersioned<long>)this).Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}

        public DayPlanState()
        {
            InitializeProperties();

        }


		public virtual void When(IDayPlanStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.Description = e.Description;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}


		public virtual void When(IDayPlanStateMergePatched e)
		{
			ThrowOnWrongEvent(e);

			if (e.Description == null)
			{
				if (e.IsPropertyDescriptionRemoved)
				{
					this.Description = default(string);
				}
			}
			else
			{
				this.Description = e.Description;
			}

			if (e.Active == null)
			{
				if (e.IsPropertyActiveRemoved)
				{
					this.Active = default(bool);
				}
			}
			else
			{
				this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);
			}


			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;


		}

		public virtual void When(IDayPlanStateRemoved e)
		{
			ThrowOnWrongEvent(e);

			this.Deleted = true;
			this.UpdatedBy = e.CreatedBy;
			this.UpdatedAt = e.CreatedAt;

		}


		public virtual void Mutate(IEvent e)
		{
			((dynamic)this).When((dynamic)e);
		}

		protected void ThrowOnWrongEvent(IDayPlanStateEvent stateEvent)
		{
				var stateEntityIdPersonalName = (this as IGlobalIdentity<DayPlanId>).GlobalId.PersonalName;
				var eventEntityIdPersonalName = stateEvent.StateEventId.PersonalName;
				if (stateEntityIdPersonalName != eventEntityIdPersonalName)
				{
					throw DomainError.Named("mutateWrongEntity", "Entity Id PersonalName {0} in state but entity id PersonalName {1} in event", stateEntityIdPersonalName, eventEntityIdPersonalName);
				}

				var stateEntityIdYear = (this as IGlobalIdentity<DayPlanId>).GlobalId.Year;
				var eventEntityIdYear = stateEvent.StateEventId.Year;
				if (stateEntityIdYear != eventEntityIdYear)
				{
					throw DomainError.Named("mutateWrongEntity", "Entity Id Year {0} in state but entity id Year {1} in event", stateEntityIdYear, eventEntityIdYear);
				}

				var stateEntityIdMonth = (this as IGlobalIdentity<DayPlanId>).GlobalId.Month;
				var eventEntityIdMonth = stateEvent.StateEventId.Month;
				if (stateEntityIdMonth != eventEntityIdMonth)
				{
					throw DomainError.Named("mutateWrongEntity", "Entity Id Month {0} in state but entity id Month {1} in event", stateEntityIdMonth, eventEntityIdMonth);
				}

				var stateEntityIdDay = (this as IGlobalIdentity<DayPlanId>).GlobalId.Day;
				var eventEntityIdDay = stateEvent.StateEventId.Day;
				if (stateEntityIdDay != eventEntityIdDay)
				{
					throw DomainError.Named("mutateWrongEntity", "Entity Id Day {0} in state but entity id Day {1} in event", stateEntityIdDay, eventEntityIdDay);
				}

			var stateVersion = this.Version;
			var eventVersion = stateEvent.Version;
			if (DayPlanState.VersionZero == eventVersion)
			{
				eventVersion = stateEvent.Version = stateVersion;
			}
			if (stateVersion != eventVersion)
			{
				throw DomainError.Named("concurrencyConflict", "Conflict between state version {0} and event version {1}", stateVersion, eventVersion);
			}

		}
	}

}

