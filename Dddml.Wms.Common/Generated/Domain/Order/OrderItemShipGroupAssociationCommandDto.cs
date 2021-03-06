﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateOrderDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.Order;
using Dddml.Wms.Domain.PartyRole;

namespace Dddml.Wms.Domain.Order
{

	public abstract class OrderItemShipGroupAssociationCommandDtoBase : ICommandDto, ICreateOrderItemShipGroupAssociation, IMergePatchOrderItemShipGroupAssociation, IRemoveOrderItemShipGroupAssociation
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

		public virtual string OrderItemSeqId { get; set; }

		public virtual decimal? Quantity { get; set; }

		public virtual decimal? CancelQuantity { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string OrderId { get; set; }

		public virtual long? OrderShipGroupShipGroupSeqId { get; set; }

		public virtual bool? IsPropertyQuantityRemoved { get; set; }

        bool IMergePatchOrderItemShipGroupAssociation.IsPropertyQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyCancelQuantityRemoved { get; set; }

        bool IMergePatchOrderItemShipGroupAssociation.IsPropertyCancelQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyCancelQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyCancelQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchOrderItemShipGroupAssociation.IsPropertyActiveRemoved
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


    public class CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto : OrderItemShipGroupAssociationCommandDtoBase
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



	public class CreateOrderItemShipGroupAssociationDto : CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto
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


	public class MergePatchOrderItemShipGroupAssociationDto : CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto
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

	public class RemoveOrderItemShipGroupAssociationDto : CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto
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


    public partial class CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDtos : IOrderItemShipGroupAssociationCommands, ICreateOrderItemShipGroupAssociationCommands, IEnumerable<CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto>
    {
        private List<CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto> _innerCommands = new List<CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto>();

        public virtual CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IOrderItemShipGroupAssociationCommands.Add(IOrderItemShipGroupAssociationCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto)c);
        }

        void IOrderItemShipGroupAssociationCommands.Remove(IOrderItemShipGroupAssociationCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto> IEnumerable<CreateOrMergePatchOrRemoveOrderItemShipGroupAssociationDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IOrderItemShipGroupAssociationCommand> IEnumerable<IOrderItemShipGroupAssociationCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateOrderItemShipGroupAssociationCommands.Add(ICreateOrderItemShipGroupAssociation c)
        {
            _innerCommands.Add((CreateOrderItemShipGroupAssociationDto)c);
        }

        void ICreateOrderItemShipGroupAssociationCommands.Remove(ICreateOrderItemShipGroupAssociation c)
        {
            _innerCommands.Remove((CreateOrderItemShipGroupAssociationDto)c);
        }

        IEnumerator<ICreateOrderItemShipGroupAssociation> IEnumerable<ICreateOrderItemShipGroupAssociation>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

}

