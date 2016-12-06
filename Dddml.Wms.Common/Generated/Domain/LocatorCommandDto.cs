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

	public abstract class LocatorCommandDtoBase : ICommandDto, ICreateLocator, IMergePatchLocator, IDeleteLocator
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return ((ICreateOrMergePatchOrDeleteLocator)this).LocatorId;
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

		public virtual string LocatorId { get; set; }

		public virtual string WarehouseId { get; set; }

		public virtual string ParentLocatorId { get; set; }

		public virtual string LocatorType { get; set; }

		public virtual string PriorityNumber { get; set; }

		public virtual bool? IsDefault { get; set; }

		public virtual string X { get; set; }

		public virtual string Y { get; set; }

		public virtual string Z { get; set; }

		public virtual bool? Active { get; set; }

		public virtual bool? IsPropertyWarehouseIdRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyWarehouseIdRemoved
        {
            get
            {
                var b = this.IsPropertyWarehouseIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyWarehouseIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyParentLocatorIdRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyParentLocatorIdRemoved
        {
            get
            {
                var b = this.IsPropertyParentLocatorIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyParentLocatorIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyLocatorTypeRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyLocatorTypeRemoved
        {
            get
            {
                var b = this.IsPropertyLocatorTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLocatorTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyPriorityNumberRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyPriorityNumberRemoved
        {
            get
            {
                var b = this.IsPropertyPriorityNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPriorityNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsDefaultRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyIsDefaultRemoved
        {
            get
            {
                var b = this.IsPropertyIsDefaultRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsDefaultRemoved = value;
            }
        }

		public virtual bool? IsPropertyXRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyXRemoved
        {
            get
            {
                var b = this.IsPropertyXRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyXRemoved = value;
            }
        }

		public virtual bool? IsPropertyYRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyYRemoved
        {
            get
            {
                var b = this.IsPropertyYRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyYRemoved = value;
            }
        }

		public virtual bool? IsPropertyZRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyZRemoved
        {
            get
            {
                var b = this.IsPropertyZRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyZRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchLocator.IsPropertyActiveRemoved
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


    public class CreateOrMergePatchOrDeleteLocatorDto : LocatorCommandDtoBase
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



	public class CreateLocatorDto : CreateOrMergePatchOrDeleteLocatorDto
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


	public class MergePatchLocatorDto : CreateOrMergePatchOrDeleteLocatorDto
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

	public class DeleteLocatorDto : CreateOrMergePatchOrDeleteLocatorDto
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

    public static partial class LocatorCommandDtos
    {

    }

}

