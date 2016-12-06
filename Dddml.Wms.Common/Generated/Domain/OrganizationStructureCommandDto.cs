﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;

namespace Dddml.Wms.Domain
{

	public abstract class OrganizationStructureCommandDtoBase : ICommandDto, ICreateOrganizationStructure, IMergePatchOrganizationStructure, IDeleteOrganizationStructure
	{

		OrganizationStructureId IAggregateCommand<OrganizationStructureId, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteOrganizationStructure)this).Id;
			}
		}


		long IAggregateCommand<OrganizationStructureId, long>.AggregateVersion
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

		public virtual OrganizationStructureIdDto Id { get; set; }

		public virtual bool? Active { get; set; }


        OrganizationStructureId IOrganizationStructureCommand.Id
        {
            get 
            {
                return this.Id.ToOrganizationStructureId();
            }
            set 
            {
                this.Id = new OrganizationStructureIdDtoWrapper(value);
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchOrganizationStructure.IsPropertyActiveRemoved
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


    public class CreateOrMergePatchOrDeleteOrganizationStructureDto : OrganizationStructureCommandDtoBase
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



	public class CreateOrganizationStructureDto : CreateOrMergePatchOrDeleteOrganizationStructureDto
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


	public class MergePatchOrganizationStructureDto : CreateOrMergePatchOrDeleteOrganizationStructureDto
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

	public class DeleteOrganizationStructureDto : CreateOrMergePatchOrDeleteOrganizationStructureDto
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

    public static partial class OrganizationStructureCommandDtos
    {

    }

}

