﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateShipmentDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Shipment;

namespace Dddml.Wms.Domain.Shipment
{

	public abstract class ShipmentImageCommandDtoBase : ICommandDto, ICreateShipmentImage, IMergePatchShipmentImage, IRemoveShipmentImage
	{

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

		public virtual string SequenceId { get; set; }

		public virtual string Url { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string ShipmentId { get; set; }

		public virtual bool? IsPropertyUrlRemoved { get; set; }

        bool IMergePatchShipmentImage.IsPropertyUrlRemoved
        {
            get
            {
                var b = this.IsPropertyUrlRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyUrlRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchShipmentImage.IsPropertyActiveRemoved
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


    public class CreateOrMergePatchOrRemoveShipmentImageDto : ShipmentImageCommandDtoBase
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



	public class CreateShipmentImageDto : CreateOrMergePatchOrRemoveShipmentImageDto
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


	public class MergePatchShipmentImageDto : CreateOrMergePatchOrRemoveShipmentImageDto
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

	public class RemoveShipmentImageDto : CreateOrMergePatchOrRemoveShipmentImageDto
	{
        protected override string GetCommandType()
        {
            return Dddml.Wms.Specialization.CommandType.Remove;
        }


        public override string CommandType
        {
            get { return this.GetCommandType(); }
            set { 
				// do nothing
            }
        }

	}


    public partial class CreateOrMergePatchOrRemoveShipmentImageDtos : IShipmentImageCommands, ICreateShipmentImageCommands, IEnumerable<CreateOrMergePatchOrRemoveShipmentImageDto>
    {
        private List<CreateOrMergePatchOrRemoveShipmentImageDto> _innerCommands = new List<CreateOrMergePatchOrRemoveShipmentImageDto>();

        public virtual CreateOrMergePatchOrRemoveShipmentImageDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveShipmentImageDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IShipmentImageCommands.Add(IShipmentImageCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveShipmentImageDto)c);
        }

        void IShipmentImageCommands.Remove(IShipmentImageCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveShipmentImageDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveShipmentImageDto> IEnumerable<CreateOrMergePatchOrRemoveShipmentImageDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IShipmentImageCommand> IEnumerable<IShipmentImageCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateShipmentImageCommands.Add(ICreateShipmentImage c)
        {
            _innerCommands.Add((CreateShipmentImageDto)c);
        }

        void ICreateShipmentImageCommands.Remove(ICreateShipmentImage c)
        {
            _innerCommands.Remove((CreateShipmentImageDto)c);
        }

        IEnumerator<ICreateShipmentImage> IEnumerable<ICreateShipmentImage>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

}

