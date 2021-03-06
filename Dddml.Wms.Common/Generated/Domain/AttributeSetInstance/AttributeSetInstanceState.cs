﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateAttributeSetInstanceDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.AttributeSetInstance;

namespace Dddml.Wms.Domain.AttributeSetInstance
{

	public partial class AttributeSetInstanceState : AttributeSetInstanceStateProperties, IAttributeSetInstanceState
	{

		public virtual string CreatedBy { get; set; }

		public virtual DateTime CreatedAt { get; set; }

		public virtual string UpdatedBy { get; set; }

		public virtual DateTime UpdatedAt { get; set; }

		public virtual bool Deleted { get; set; }

        public virtual string CommandId { get; set; }


		#region IIdentity implementation

		string IGlobalIdentity<string>.GlobalId
		{
			get
			{
				return this.AttributeSetInstanceId;
			}
		}

		#endregion

		#region IActive implementation

		bool IActive.IsActive()
		{
			return this.Active;
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
			get { return this.UpdatedBy; }
			set { this.UpdatedBy = value; }
		}

		DateTime IUpdated<string>.UpdatedAt
		{
			get { return this.UpdatedAt; }
			set { this.UpdatedAt = value; }
		}

		#endregion

		#region IVersioned implementation

		long IAggregateVersioned<long>.AggregateVersion
		{
			get
			{
				return this.Version;
			}
		}


		#endregion

        bool IAttributeSetInstanceState.IsUnsaved
        {
            get { return this.Version == VersionZero; }
        }

		public static long VersionZero
		{
			get
			{
				return (long)0;
			}
		}


        public virtual bool StateReadOnly { get; set; }

        bool IState.ReadOnly
        {
            get { return this.StateReadOnly; }
            set { this.StateReadOnly = value; }
        }
	
        private bool _forReapplying;

        public virtual bool ForReapplying
        {
            get { return _forReapplying; }
            set { _forReapplying = value; } 
        }

        public AttributeSetInstanceState(IEnumerable<IEvent> events) : this(true)
        {
            if (events != null && events.Count() > 0)
            {
                this.AttributeSetInstanceId = ((IAttributeSetInstanceEvent)events.First()).AttributeSetInstanceEventId.AttributeSetInstanceId;
                foreach (var e in events)
                {
                    Mutate(e);
                    this.Version += 1;
                }
            }
        }

        public AttributeSetInstanceState() : this(false)
        {
        }

        public AttributeSetInstanceState(bool forReapplying)
        {
            this._forReapplying = forReapplying;
            InitializeProperties();
        }


		public virtual void When(IAttributeSetInstanceStateCreated e)
		{
			ThrowOnWrongEvent(e);
			this.AttributeSetId = e.AttributeSetId;

			this.OrganizationId = e.OrganizationId;

			this.ReferenceId = e.ReferenceId;

			this.SerialNumber = e.SerialNumber;

			this.LotId = e.LotId;

			this.StatusIds = e.StatusIds;

			this.ImageUrl = e.ImageUrl;

			this.Description = e.Description;

			this.Hash = e.Hash;

			this.WidthInch = e.WidthInch;

			this.DiameterInch = e.DiameterInch;

			this.WeightLbs = e.WeightLbs;

			this.WeightKg = e.WeightKg;

			this.AirDryWeightLbs = e.AirDryWeightLbs;

			this.AirDryWeightKg = e.AirDryWeightKg;

			this.AirDryMetricTon = e.AirDryMetricTon;

			this.RollCnt = e.RollCnt;

			this.AirDryPct = e.AirDryPct;

			this._F_B_0_ = e._F_B_0_;

			this._F_I_0_ = e._F_I_0_;

			this._F_L_0_ = e._F_L_0_;

			this._F_DT_0_ = e._F_DT_0_;

			this._F_N_0_ = e._F_N_0_;

			this._F_C5_0_ = e._F_C5_0_;

			this._F_C10_0_ = e._F_C10_0_;

			this._F_C20_0_ = e._F_C20_0_;

			this._F_C50_0_ = e._F_C50_0_;

			this._F_C100_0_ = e._F_C100_0_;

			this._F_C200_0_ = e._F_C200_0_;

			this._F_C500_0_ = e._F_C500_0_;

			this._F_C1000_0_ = e._F_C1000_0_;

			this._F_B_1_ = e._F_B_1_;

			this._F_I_1_ = e._F_I_1_;

			this._F_L_1_ = e._F_L_1_;

			this._F_DT_1_ = e._F_DT_1_;

			this._F_N_1_ = e._F_N_1_;

			this._F_C5_1_ = e._F_C5_1_;

			this._F_C10_1_ = e._F_C10_1_;

			this._F_C20_1_ = e._F_C20_1_;

			this._F_C50_1_ = e._F_C50_1_;

			this._F_C100_1_ = e._F_C100_1_;

			this._F_C200_1_ = e._F_C200_1_;

			this._F_B_2_ = e._F_B_2_;

			this._F_I_2_ = e._F_I_2_;

			this._F_L_2_ = e._F_L_2_;

			this._F_DT_2_ = e._F_DT_2_;

			this._F_N_2_ = e._F_N_2_;

			this._F_C5_2_ = e._F_C5_2_;

			this._F_C10_2_ = e._F_C10_2_;

			this._F_C20_2_ = e._F_C20_2_;

			this._F_C50_2_ = e._F_C50_2_;

			this._F_B_3_ = e._F_B_3_;

			this._F_I_3_ = e._F_I_3_;

			this._F_L_3_ = e._F_L_3_;

			this._F_DT_3_ = e._F_DT_3_;

			this._F_N_3_ = e._F_N_3_;

			this._F_C5_3_ = e._F_C5_3_;

			this._F_C10_3_ = e._F_C10_3_;

			this._F_C20_3_ = e._F_C20_3_;

			this._F_C50_3_ = e._F_C50_3_;

			this._F_B_4_ = e._F_B_4_;

			this._F_I_4_ = e._F_I_4_;

			this._F_L_4_ = e._F_L_4_;

			this._F_DT_4_ = e._F_DT_4_;

			this._F_N_4_ = e._F_N_4_;

			this._F_C5_4_ = e._F_C5_4_;

			this._F_C10_4_ = e._F_C10_4_;

			this._F_C20_4_ = e._F_C20_4_;

			this._F_C50_4_ = e._F_C50_4_;

            this.Active = (e.Active != null && e.Active.HasValue) ? e.Active.Value : default(bool);

			this.Deleted = false;

			this.CreatedBy = e.CreatedBy;
			this.CreatedAt = e.CreatedAt;


		}



		public virtual void Mutate(IEvent e)
		{
            StateReadOnly = false;
			((dynamic)this).When((dynamic)e);
		}

        protected void ThrowOnWrongEvent(IAttributeSetInstanceEvent e)
        {
            var id = new System.Text.StringBuilder(); 
            id.Append("[").Append("AttributeSetInstance|");

            var stateEntityId = this.AttributeSetInstanceId; // Aggregate Id
            var eventEntityId = e.AttributeSetInstanceEventId.AttributeSetInstanceId;
            if (stateEntityId != eventEntityId)
            {
                throw DomainError.Named("mutateWrongEntity", "Entity Id {0} in state but entity id {1} in event", stateEntityId, eventEntityId);
            }
            id.Append(stateEntityId).Append(",");

            id.Append("]");

            var stateVersion = this.Version;
            var eventVersion = e.AttributeSetInstanceEventId.Version;
            if (stateVersion != eventVersion)
            {
                throw OptimisticConcurrencyException.Create(stateVersion, eventVersion, id.ToString());
            }
        }
    }

}

