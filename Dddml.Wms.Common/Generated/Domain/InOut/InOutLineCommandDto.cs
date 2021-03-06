﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateInOutDomain.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Linq;
using System.Collections.Generic;
using Dddml.Wms.Specialization;
using Dddml.Wms.Domain;
using Dddml.Wms.Domain.InOut;

namespace Dddml.Wms.Domain.InOut
{

	public abstract class InOutLineCommandDtoBase : ICommandDto, ICreateInOutLine, IMergePatchInOutLine, IRemoveInOutLine
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

		public virtual string LineNumber { get; set; }

		public virtual string LocatorId { get; set; }

		public virtual string ProductId { get; set; }

		public virtual string AttributeSetInstanceId { get; set; }

		public virtual string Description { get; set; }

		public virtual string QuantityUomId { get; set; }

		public virtual decimal? MovementQuantity { get; set; }

		public virtual decimal? PickedQuantity { get; set; }

		public virtual bool? IsInvoiced { get; set; }

		public virtual bool? Processed { get; set; }

		public virtual string RmaLineNumber { get; set; }

		public virtual string ReversalLineNumber { get; set; }

		public virtual bool? Active { get; set; }

		public virtual string InOutDocumentNumber { get; set; }

        public virtual string[] DamageStatusIds { get; set; }

        ISet<string> ICreateOrMergePatchOrRemoveInOutLine.DamageStatusIds 
        {
            get
            {
                if (this.DamageStatusIds != null)
                {
                    var set = new HashSet<string>();
                    foreach (var i in this.DamageStatusIds)
                    {
                        set.Add(i);
                    }
                    return set;
                } else { return null; }
            }
            set
            {
                if (value != null)
                {
                    var list = new List<string>();
                    foreach (var i in value)
                    {
                        list.Add(i);
                    }
                    this.DamageStatusIds = list.ToArray();
                } else { this.DamageStatusIds = null; }
            }
        }

		public virtual bool? IsPropertyLocatorIdRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyLocatorIdRemoved
        {
            get
            {
                var b = this.IsPropertyLocatorIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyLocatorIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyProductIdRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyProductIdRemoved
        {
            get
            {
                var b = this.IsPropertyProductIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProductIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyAttributeSetInstanceIdRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyAttributeSetInstanceIdRemoved
        {
            get
            {
                var b = this.IsPropertyAttributeSetInstanceIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyAttributeSetInstanceIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyDamageStatusIdsRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyDamageStatusIdsRemoved
        {
            get
            {
                var b = this.IsPropertyDamageStatusIdsRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDamageStatusIdsRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyDescriptionRemoved
        {
            get
            {
                var b = this.IsPropertyDescriptionRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyDescriptionRemoved = value;
            }
        }

		public virtual bool? IsPropertyQuantityUomIdRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyQuantityUomIdRemoved
        {
            get
            {
                var b = this.IsPropertyQuantityUomIdRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyQuantityUomIdRemoved = value;
            }
        }

		public virtual bool? IsPropertyMovementQuantityRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyMovementQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyMovementQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyMovementQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyPickedQuantityRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyPickedQuantityRemoved
        {
            get
            {
                var b = this.IsPropertyPickedQuantityRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyPickedQuantityRemoved = value;
            }
        }

		public virtual bool? IsPropertyIsInvoicedRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyIsInvoicedRemoved
        {
            get
            {
                var b = this.IsPropertyIsInvoicedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyIsInvoicedRemoved = value;
            }
        }

		public virtual bool? IsPropertyProcessedRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyProcessedRemoved
        {
            get
            {
                var b = this.IsPropertyProcessedRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyProcessedRemoved = value;
            }
        }

		public virtual bool? IsPropertyRmaLineNumberRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyRmaLineNumberRemoved
        {
            get
            {
                var b = this.IsPropertyRmaLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyRmaLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyReversalLineNumberRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyReversalLineNumberRemoved
        {
            get
            {
                var b = this.IsPropertyReversalLineNumberRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyReversalLineNumberRemoved = value;
            }
        }

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchInOutLine.IsPropertyActiveRemoved
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

        ICreateInOutLineImageCommands ICreateInOutLine.InOutLineImages
        {
            get
            {
                return this._inOutLineImages;
            }
        }

        IInOutLineImageCommands IMergePatchInOutLine.InOutLineImageCommands
        {
            get
            {
                return this._inOutLineImages;
            }
        }

        public virtual CreateInOutLineImageDto NewCreateInOutLineImage()
        {
            var c = new CreateInOutLineImageDto();
            c.InOutDocumentNumber = this.InOutDocumentNumber;

            c.InOutLineLineNumber = this.LineNumber;

            return c;
        }

        ICreateInOutLineImage ICreateInOutLine.NewCreateInOutLineImage()
        {
            return this.NewCreateInOutLineImage();
        }

        ICreateInOutLineImage IMergePatchInOutLine.NewCreateInOutLineImage()
        {
            return this.NewCreateInOutLineImage();
        }

        public virtual MergePatchInOutLineImageDto NewMergePatchInOutLineImage()
        {
            var c = new MergePatchInOutLineImageDto();
            c.InOutDocumentNumber = this.InOutDocumentNumber;

            c.InOutLineLineNumber = this.LineNumber;

            return c;
        }

        IMergePatchInOutLineImage IMergePatchInOutLine.NewMergePatchInOutLineImage()
        {
            return this.NewMergePatchInOutLineImage();
        }

        public virtual RemoveInOutLineImageDto NewRemoveInOutLineImage()
        {
            var c = new RemoveInOutLineImageDto();
            c.InOutDocumentNumber = this.InOutDocumentNumber;

            c.InOutLineLineNumber = this.LineNumber;

            return c;
        }

        IRemoveInOutLineImage IMergePatchInOutLine.NewRemoveInOutLineImage()
        {
            return this.NewRemoveInOutLineImage();
        }

        private CreateOrMergePatchOrRemoveInOutLineImageDtos _inOutLineImages = new CreateOrMergePatchOrRemoveInOutLineImageDtos();

        public virtual CreateOrMergePatchOrRemoveInOutLineImageDto[] InOutLineImages
        {
            get
            {
                return _inOutLineImages.ToArray();
            }
            set
            {
                _inOutLineImages.Clear();
                _inOutLineImages.AddRange(value);
            }
        }


        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrRemoveInOutLineDto : InOutLineCommandDtoBase
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



	public class CreateInOutLineDto : CreateOrMergePatchOrRemoveInOutLineDto
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


	public class MergePatchInOutLineDto : CreateOrMergePatchOrRemoveInOutLineDto
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

	public class RemoveInOutLineDto : CreateOrMergePatchOrRemoveInOutLineDto
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


    public partial class CreateOrMergePatchOrRemoveInOutLineDtos : IInOutLineCommands, ICreateInOutLineCommands, IEnumerable<CreateOrMergePatchOrRemoveInOutLineDto>
    {
        private List<CreateOrMergePatchOrRemoveInOutLineDto> _innerCommands = new List<CreateOrMergePatchOrRemoveInOutLineDto>();

        public virtual CreateOrMergePatchOrRemoveInOutLineDto[] ToArray()
        {
            return _innerCommands.ToArray();
        }

        public virtual void Clear()
        {
            _innerCommands.Clear();
        }

        public virtual void AddRange(IEnumerable<CreateOrMergePatchOrRemoveInOutLineDto> cs)
        {
            _innerCommands.AddRange(cs);
        }

        void IInOutLineCommands.Add(IInOutLineCommand c)
        {
            _innerCommands.Add((CreateOrMergePatchOrRemoveInOutLineDto)c);
        }

        void IInOutLineCommands.Remove(IInOutLineCommand c)
        {
            _innerCommands.Remove((CreateOrMergePatchOrRemoveInOutLineDto)c);
        }


        IEnumerator<CreateOrMergePatchOrRemoveInOutLineDto> IEnumerable<CreateOrMergePatchOrRemoveInOutLineDto>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        IEnumerator<IInOutLineCommand> IEnumerable<IInOutLineCommand>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

        void ICreateInOutLineCommands.Add(ICreateInOutLine c)
        {
            _innerCommands.Add((CreateInOutLineDto)c);
        }

        void ICreateInOutLineCommands.Remove(ICreateInOutLine c)
        {
            _innerCommands.Remove((CreateInOutLineDto)c);
        }

        IEnumerator<ICreateInOutLine> IEnumerable<ICreateInOutLine>.GetEnumerator()
        {
            return _innerCommands.GetEnumerator();
        }

    }

}

