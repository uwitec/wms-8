﻿// <autogenerated>
//   This file was generated by T4 code generator GenerateBoundedContextDomainAggregates.tt.
//   Any changes made to this file manually will be lost next time the file is regenerated.
// </autogenerated>

using System;
using System.Collections.Generic;
using Dddml.Wms.Domain;

using Dddml.Wms.Specialization;

namespace Dddml.Wms.Domain
{

	public abstract class AttributeSetInstanceExtensionFieldGroupCommandDtoBase : ICommandDto, ICreateAttributeSetInstanceExtensionFieldGroup, IMergePatchAttributeSetInstanceExtensionFieldGroup, IDeleteAttributeSetInstanceExtensionFieldGroup
	{

		string IAggregateCommand<string, long>.AggregateId
		{
			get
			{
				return (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).Id;
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

		public virtual string Id { get; set; }

		public virtual string FieldType { get; set; }

		public virtual int? FieldLength { get; set; }

		public virtual int? FieldCount { get; set; }

        int IAttributeSetInstanceExtensionFieldGroupStateProperties.FieldCount
        {
            get 
            {
                var b = this.FieldCount;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(int);
            }
            set 
            {
                this.FieldCount = value;
            }
        }

		public virtual string NameFormat { get; set; }

		public virtual string Description { get; set; }

		public virtual bool? Active { get; set; }

        bool IAttributeSetInstanceExtensionFieldGroupStateProperties.Active
        {
            get 
            {
                var b = this.Active;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return default(bool);
            }
            set 
            {
                this.Active = value;
            }
        }

		public virtual bool? IsPropertyFieldTypeRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldGroup.IsPropertyFieldTypeRemoved
        {
            get
            {
                var b = this.IsPropertyFieldTypeRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyFieldTypeRemoved = value;
            }
        }

		public virtual bool? IsPropertyFieldLengthRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldGroup.IsPropertyFieldLengthRemoved
        {
            get
            {
                var b = this.IsPropertyFieldLengthRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyFieldLengthRemoved = value;
            }
        }

		public virtual bool? IsPropertyFieldCountRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldGroup.IsPropertyFieldCountRemoved
        {
            get
            {
                var b = this.IsPropertyFieldCountRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyFieldCountRemoved = value;
            }
        }

		public virtual bool? IsPropertyNameFormatRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldGroup.IsPropertyNameFormatRemoved
        {
            get
            {
                var b = this.IsPropertyNameFormatRemoved;
                if (b != null && b.HasValue)
                {
                    return b.Value;
                }
                return false;
            }
            set
            {
                this.IsPropertyNameFormatRemoved = value;
            }
        }

		public virtual bool? IsPropertyDescriptionRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldGroup.IsPropertyDescriptionRemoved
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

		public virtual bool? IsPropertyActiveRemoved { get; set; }

        bool IMergePatchAttributeSetInstanceExtensionFieldGroup.IsPropertyActiveRemoved
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

        ICreateAttributeSetInstanceExtensionFieldCommands ICreateAttributeSetInstanceExtensionFieldGroup.Fields
        {
            get
            {
                return this._fields;
            }
        }

        IAttributeSetInstanceExtensionFieldCommands IMergePatchAttributeSetInstanceExtensionFieldGroup.AttributeSetInstanceExtensionFieldCommands
        {
            get
            {
                return this._fields;
            }
        }

        public virtual CreateAttributeSetInstanceExtensionFieldDto NewCreateAttributeSetInstanceExtensionField()
        {
            var c = new CreateAttributeSetInstanceExtensionFieldDto();
            c.GroupId = this.Id;

            return c;
        }

        ICreateAttributeSetInstanceExtensionField ICreateAttributeSetInstanceExtensionFieldGroup.NewCreateAttributeSetInstanceExtensionField()
        {
            return this.NewCreateAttributeSetInstanceExtensionField();
        }

        ICreateAttributeSetInstanceExtensionField IMergePatchAttributeSetInstanceExtensionFieldGroup.NewCreateAttributeSetInstanceExtensionField()
        {
            return this.NewCreateAttributeSetInstanceExtensionField();
        }

        public virtual MergePatchAttributeSetInstanceExtensionFieldDto NewMergePatchAttributeSetInstanceExtensionField()
        {
            var c = new MergePatchAttributeSetInstanceExtensionFieldDto();
            c.GroupId = this.Id;

            return c;
        }

        IMergePatchAttributeSetInstanceExtensionField IMergePatchAttributeSetInstanceExtensionFieldGroup.NewMergePatchAttributeSetInstanceExtensionField()
        {
            return this.NewMergePatchAttributeSetInstanceExtensionField();
        }

        public virtual RemoveAttributeSetInstanceExtensionFieldDto NewRemoveAttributeSetInstanceExtensionField()
        {
            var c = new RemoveAttributeSetInstanceExtensionFieldDto();
            c.GroupId = this.Id;

            return c;
        }

        IRemoveAttributeSetInstanceExtensionField IMergePatchAttributeSetInstanceExtensionFieldGroup.NewRemoveAttributeSetInstanceExtensionField()
        {
            return this.NewRemoveAttributeSetInstanceExtensionField();
        }

        private CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDtos _fields = new CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDtos();

        public virtual CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto[] Fields
        {
            get
            {
                return _fields.ToArray();
            }
            set
            {
                _fields.Clear();
                _fields.AddRange(value);
            }
        }


        // //////////////////////////////////////////////

        private IAttributeSetInstanceExtensionFieldGroupCommand _innerCommand;

        public virtual ICommand ToCommand()
        {
            //if (this._innerCommand != null)
            //{
                //return this._innerCommand;
            //}
            var cmdType = GetCommandType();
            if (cmdType == CommandType.Create)
            {
                var cmd = ToCreateAttributeSetInstanceExtensionFieldGroup();
                this._innerCommand = cmd;
            }
            else if (cmdType == CommandType.MergePatch)
            {
                var cmd = ToMergePatchAttributeSetInstanceExtensionFieldGroup();
                this._innerCommand = cmd;
            }
            else if (cmdType == CommandType.Delete)
            {
                var cmd = ToDeleteAttributeSetInstanceExtensionFieldGroup();
                this._innerCommand = cmd;
            }
            else
            {
                throw DomainError.Named("invalidCommandType", String.Format("Invalid command type: {0}", cmdType));
            }
            return this._innerCommand;
        }

        internal DeleteAttributeSetInstanceExtensionFieldGroup ToDeleteAttributeSetInstanceExtensionFieldGroup()
        {
            var cmd = new DeleteAttributeSetInstanceExtensionFieldGroup();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Id = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).Id;
            cmd.Version = this.Version;

            return cmd;
        }

        internal MergePatchAttributeSetInstanceExtensionFieldGroup ToMergePatchAttributeSetInstanceExtensionFieldGroup()
        {
            var cmd = new MergePatchAttributeSetInstanceExtensionFieldGroup();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Version = this.Version;

            cmd.Id = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).Id;
            cmd.FieldType = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldType;
            cmd.FieldLength = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldLength;
            cmd.FieldCount = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldCount;
            cmd.NameFormat = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).NameFormat;
            cmd.Description = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).Description;
            cmd.Active = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).Active;
            
            cmd.IsPropertyFieldTypeRemoved = (this as IMergePatchAttributeSetInstanceExtensionFieldGroup).IsPropertyFieldTypeRemoved;
            cmd.IsPropertyFieldLengthRemoved = (this as IMergePatchAttributeSetInstanceExtensionFieldGroup).IsPropertyFieldLengthRemoved;
            cmd.IsPropertyFieldCountRemoved = (this as IMergePatchAttributeSetInstanceExtensionFieldGroup).IsPropertyFieldCountRemoved;
            cmd.IsPropertyNameFormatRemoved = (this as IMergePatchAttributeSetInstanceExtensionFieldGroup).IsPropertyNameFormatRemoved;
            cmd.IsPropertyDescriptionRemoved = (this as IMergePatchAttributeSetInstanceExtensionFieldGroup).IsPropertyDescriptionRemoved;
            cmd.IsPropertyActiveRemoved = (this as IMergePatchAttributeSetInstanceExtensionFieldGroup).IsPropertyActiveRemoved;
            foreach (var d in (IEnumerable<CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto>)_fields)
            {
                var c = (IAttributeSetInstanceExtensionFieldCommand)d.ToCommand();
                cmd.AttributeSetInstanceExtensionFieldCommands.Add(c);
            }
            return cmd;
        }

        internal CreateAttributeSetInstanceExtensionFieldGroup ToCreateAttributeSetInstanceExtensionFieldGroup()
        {
            var cmd = new CreateAttributeSetInstanceExtensionFieldGroup();
            cmd.CommandId = this.CommandId;
            cmd.RequesterId = this.RequesterId;

            cmd.Version = this.Version;

            cmd.Id = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).Id;
            cmd.FieldType = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldType;
            cmd.FieldLength = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldLength;
            cmd.FieldCount = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).FieldCount;
            cmd.NameFormat = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).NameFormat;
            cmd.Description = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).Description;
            cmd.Active = (this as IAttributeSetInstanceExtensionFieldGroupStateProperties).Active;
            foreach (var d in (IEnumerable<CreateOrMergePatchOrRemoveAttributeSetInstanceExtensionFieldDto>)_fields)
            {
                var c = d.ToCreateAttributeSetInstanceExtensionField();
                cmd.Fields.Add(c);
            }
            return cmd;
        }

        // //////////////////////////////////////////////////

        string ICommandDto.CommandType 
        {
            get { return this.GetCommandType(); }
        }

        protected abstract string GetCommandType();

	}


    public class CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroupDto : AttributeSetInstanceExtensionFieldGroupCommandDtoBase
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



	public class CreateAttributeSetInstanceExtensionFieldGroupDto : CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroupDto
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


	public class MergePatchAttributeSetInstanceExtensionFieldGroupDto : CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroupDto
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

	public class DeleteAttributeSetInstanceExtensionFieldGroupDto : CreateOrMergePatchOrDeleteAttributeSetInstanceExtensionFieldGroupDto
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





}

