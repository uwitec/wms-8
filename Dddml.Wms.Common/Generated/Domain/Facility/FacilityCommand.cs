﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateFacilityDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Facility;

namespace Dddml.Wms.Domain.Facility
{

	public abstract class FacilityCommandBase : IFacilityCommand
	{
		public virtual string FacilityId { get; set; }


		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return this.FacilityId;
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

		public virtual string FacilityTypeId { get; set; }

		public virtual string ParentFacilityId { get; set; }

		public virtual string OwnerPartyId { get; set; }

		public virtual string DefaultInventoryItemTypeId { get; set; }

		public virtual string FacilityName { get; set; }

		public virtual string PrimaryFacilityGroupId { get; set; }

		public virtual long? OldSquareFootage { get; set; }

		public virtual decimal? FacilitySize { get; set; }

		public virtual string FacilitySizeUomId { get; set; }

		public virtual string ProductStoreId { get; set; }

		public virtual long? DefaultDaysToShip { get; set; }

		public virtual DateTime? OpenedDate { get; set; }

		public virtual DateTime? ClosedDate { get; set; }

		public virtual string Description { get; set; }

		public virtual string DefaultDimensionUomId { get; set; }

		public virtual string DefaultWeightUomId { get; set; }

		public virtual string GeoPointId { get; set; }

		public virtual bool? Active { get; set; }


		// //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();


	}


	public class CreateFacility : FacilityCommandBase, ICreateFacility
	{
		
		public CreateFacility ()
		{
		}


        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Create;
        }
	}


	public class MergePatchFacility :FacilityCommandBase, IMergePatchFacility
	{

		public virtual bool IsPropertyFacilityTypeIdRemoved { get; set; }

		public virtual bool IsPropertyParentFacilityIdRemoved { get; set; }

		public virtual bool IsPropertyOwnerPartyIdRemoved { get; set; }

		public virtual bool IsPropertyDefaultInventoryItemTypeIdRemoved { get; set; }

		public virtual bool IsPropertyFacilityNameRemoved { get; set; }

		public virtual bool IsPropertyPrimaryFacilityGroupIdRemoved { get; set; }

		public virtual bool IsPropertyOldSquareFootageRemoved { get; set; }

		public virtual bool IsPropertyFacilitySizeRemoved { get; set; }

		public virtual bool IsPropertyFacilitySizeUomIdRemoved { get; set; }

		public virtual bool IsPropertyProductStoreIdRemoved { get; set; }

		public virtual bool IsPropertyDefaultDaysToShipRemoved { get; set; }

		public virtual bool IsPropertyOpenedDateRemoved { get; set; }

		public virtual bool IsPropertyClosedDateRemoved { get; set; }

		public virtual bool IsPropertyDescriptionRemoved { get; set; }

		public virtual bool IsPropertyDefaultDimensionUomIdRemoved { get; set; }

		public virtual bool IsPropertyDefaultWeightUomIdRemoved { get; set; }

		public virtual bool IsPropertyGeoPointIdRemoved { get; set; }

		public virtual bool IsPropertyActiveRemoved { get; set; }


		public MergePatchFacility ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.MergePatch;
        }

	}

	public class DeleteFacility : FacilityCommandBase, IDeleteFacility
	{
		public DeleteFacility ()
		{
		}

        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Delete;
        }

	}

    public static partial class FacilityCommands
    {
    }

}