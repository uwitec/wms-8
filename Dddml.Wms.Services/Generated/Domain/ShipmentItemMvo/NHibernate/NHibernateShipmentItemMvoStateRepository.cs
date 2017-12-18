﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentItemMvoDomainNHibernate.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.ShipmentItemMvo;
using Dddml.Wms.Domain.Shipment;
using Dddml.Wms.Specialization.NHibernate;
using NHibernate;
using NHibernate.Criterion;
using Spring.Transaction.Interceptor;
using Dddml.Support.Criterion;
using NHibernateICriterion = NHibernate.Criterion.ICriterion;
using NHibernateRestrictions = NHibernate.Criterion.Restrictions;
using NHibernateDisjunction = NHibernate.Criterion.Disjunction;

namespace Dddml.Wms.Domain.ShipmentItemMvo.NHibernate
{

	public partial class NHibernateShipmentItemMvoStateRepository : IShipmentItemMvoStateRepository
	{
		public ISessionFactory SessionFactory { get; set; }

		protected ISession CurrentSession {
			get { return this.SessionFactory.GetCurrentSession (); }
		}

        private static readonly ISet<string> _readOnlyPropertyNames = new SortedSet<string>(new String[] { "ShipmentItemId", "ProductId", "Quantity", "ShipmentContentDescription", "Version", "CreatedBy", "CreatedAt", "UpdatedBy", "UpdatedAt", "Active", "Deleted", "ShipmentShipmentTypeId", "ShipmentStatusId", "ShipmentPrimaryOrderId", "ShipmentPrimaryReturnId", "ShipmentPicklistBinId", "ShipmentEstimatedReadyDate", "ShipmentEstimatedShipDate", "ShipmentEstimatedShipWorkEffId", "ShipmentEstimatedArrivalDate", "ShipmentEstimatedArrivalWorkEffId", "ShipmentLatestCancelDate", "ShipmentEstimatedShipCost", "ShipmentCurrencyUomId", "ShipmentHandlingInstructions", "ShipmentOriginFacilityId", "ShipmentDestinationFacilityId", "ShipmentOriginContactMechId", "ShipmentOriginTelecomNumberId", "ShipmentDestinationContactMechId", "ShipmentDestinationTelecomNumberId", "ShipmentPartyIdTo", "ShipmentPartyIdFrom", "ShipmentAdditionalShippingCharge", "ShipmentAddtlShippingChargeDesc", "ShipmentShipmentItems", "ShipmentVersion", "ShipmentCreatedBy", "ShipmentCreatedAt", "ShipmentUpdatedBy", "ShipmentUpdatedAt", "ShipmentActive" });
    
        public IReadOnlyProxyGenerator ReadOnlyProxyGenerator { get; set; }

		public NHibernateShipmentItemMvoStateRepository()
		{
		}

		[Transaction (ReadOnly = true)]
		public IShipmentItemMvoState Get(ShipmentItemId id, bool nullAllowed)
		{
			IShipmentItemMvoState state = CurrentSession.Get<ShipmentItemMvoState> (id);
			if (!nullAllowed && state == null) {
				state = new ShipmentItemMvoState ();
				(state as ShipmentItemMvoState).ShipmentItemId = id;
			}
            if (ReadOnlyProxyGenerator != null && state != null)
            {
                return ReadOnlyProxyGenerator.CreateProxy<IShipmentItemMvoState>(state, new Type[] {  }, _readOnlyPropertyNames);
            }
			return state;
		}

		[Transaction]
		public void Save(IShipmentItemMvoState state)
		{
            IShipmentItemMvoState s = state;
            if (ReadOnlyProxyGenerator != null)
            {
                s = ReadOnlyProxyGenerator.GetTarget<IShipmentItemMvoState>(state);
            }
			CurrentSession.SaveOrUpdate (s);

			var saveable = s as ISaveable;
			if (saveable != null) {
				saveable.Save ();
			}
		}

        //protected static void AddNotDeletedRestriction(ICriteria criteria)
        //{
        //    criteria.Add(NHibernateRestrictions.Eq("Deleted", false));
        //}

	}
}
