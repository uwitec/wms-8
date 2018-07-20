package org.dddml.wms.domain.attributesetinstanceextensionfieldgroup;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchAttributeSetInstanceExtensionFieldGroupDto extends AbstractAttributeSetInstanceExtensionFieldGroupCommandDto
{
    /**
     * Field Type
     */
    private String fieldType;

    public String getFieldType()
    {
        return this.fieldType;
    }

    public void setFieldType(String fieldType)
    {
        this.fieldType = fieldType;
    }

    /**
     * Field Length
     */
    private Integer fieldLength;

    public Integer getFieldLength()
    {
        return this.fieldLength;
    }

    public void setFieldLength(Integer fieldLength)
    {
        this.fieldLength = fieldLength;
    }

    /**
     * Field Count
     */
    private Integer fieldCount;

    public Integer getFieldCount()
    {
        return this.fieldCount;
    }

    public void setFieldCount(Integer fieldCount)
    {
        this.fieldCount = fieldCount;
    }

    /**
     * Name Format
     */
    private String nameFormat;

    public String getNameFormat()
    {
        return this.nameFormat;
    }

    public void setNameFormat(String nameFormat)
    {
        this.nameFormat = nameFormat;
    }

    /**
     * Description
     */
    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    /**
     * Active
     */
    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Boolean isPropertyFieldTypeRemoved;

    public Boolean getIsPropertyFieldTypeRemoved()
    {
        return this.isPropertyFieldTypeRemoved;
    }

    public void setIsPropertyFieldTypeRemoved(Boolean removed)
    {
        this.isPropertyFieldTypeRemoved = removed;
    }

    private Boolean isPropertyFieldLengthRemoved;

    public Boolean getIsPropertyFieldLengthRemoved()
    {
        return this.isPropertyFieldLengthRemoved;
    }

    public void setIsPropertyFieldLengthRemoved(Boolean removed)
    {
        this.isPropertyFieldLengthRemoved = removed;
    }

    private Boolean isPropertyFieldCountRemoved;

    public Boolean getIsPropertyFieldCountRemoved()
    {
        return this.isPropertyFieldCountRemoved;
    }

    public void setIsPropertyFieldCountRemoved(Boolean removed)
    {
        this.isPropertyFieldCountRemoved = removed;
    }

    private Boolean isPropertyNameFormatRemoved;

    public Boolean getIsPropertyNameFormatRemoved()
    {
        return this.isPropertyNameFormatRemoved;
    }

    public void setIsPropertyNameFormatRemoved(Boolean removed)
    {
        this.isPropertyNameFormatRemoved = removed;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved()
    {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed)
    {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved()
    {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed)
    {
        this.isPropertyActiveRemoved = removed;
    }

    public void copyTo(AbstractAttributeSetInstanceExtensionFieldGroupCommand.AbstractCreateOrMergePatchAttributeSetInstanceExtensionFieldGroup command)
    {
        ((AbstractAttributeSetInstanceExtensionFieldGroupCommandDto) this).copyTo(command);
        command.setFieldType(this.getFieldType());
        command.setFieldLength(this.getFieldLength());
        command.setFieldCount(this.getFieldCount());
        command.setNameFormat(this.getNameFormat());
        command.setDescription(this.getDescription());
        command.setActive(this.getActive());
    }

    public AttributeSetInstanceExtensionFieldGroupCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractAttributeSetInstanceExtensionFieldGroupCommand.SimpleCreateAttributeSetInstanceExtensionFieldGroup command = new AbstractAttributeSetInstanceExtensionFieldGroupCommand.SimpleCreateAttributeSetInstanceExtensionFieldGroup();
            copyTo((AbstractAttributeSetInstanceExtensionFieldGroupCommand.AbstractCreateAttributeSetInstanceExtensionFieldGroup) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractAttributeSetInstanceExtensionFieldGroupCommand.SimpleMergePatchAttributeSetInstanceExtensionFieldGroup command = new AbstractAttributeSetInstanceExtensionFieldGroupCommand.SimpleMergePatchAttributeSetInstanceExtensionFieldGroup();
            copyTo((AbstractAttributeSetInstanceExtensionFieldGroupCommand.SimpleMergePatchAttributeSetInstanceExtensionFieldGroup) command);
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractAttributeSetInstanceExtensionFieldGroupCommand.AbstractCreateAttributeSetInstanceExtensionFieldGroup command)
    {
        copyTo((AbstractAttributeSetInstanceExtensionFieldGroupCommand.AbstractCreateOrMergePatchAttributeSetInstanceExtensionFieldGroup) command);
    }

    public void copyTo(AbstractAttributeSetInstanceExtensionFieldGroupCommand.AbstractMergePatchAttributeSetInstanceExtensionFieldGroup command)
    {
        copyTo((AbstractAttributeSetInstanceExtensionFieldGroupCommand.AbstractCreateOrMergePatchAttributeSetInstanceExtensionFieldGroup) command);
        command.setIsPropertyFieldTypeRemoved(this.getIsPropertyFieldTypeRemoved());
        command.setIsPropertyFieldLengthRemoved(this.getIsPropertyFieldLengthRemoved());
        command.setIsPropertyFieldCountRemoved(this.getIsPropertyFieldCountRemoved());
        command.setIsPropertyNameFormatRemoved(this.getIsPropertyNameFormatRemoved());
        command.setIsPropertyDescriptionRemoved(this.getIsPropertyDescriptionRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateAttributeSetInstanceExtensionFieldGroupDto extends CreateOrMergePatchAttributeSetInstanceExtensionFieldGroupDto
    {
        public CreateAttributeSetInstanceExtensionFieldGroupDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public AttributeSetInstanceExtensionFieldGroupCommand.CreateAttributeSetInstanceExtensionFieldGroup toCreateAttributeSetInstanceExtensionFieldGroup()
        {
            return (AttributeSetInstanceExtensionFieldGroupCommand.CreateAttributeSetInstanceExtensionFieldGroup) toCommand();
        }

    }

    public static class MergePatchAttributeSetInstanceExtensionFieldGroupDto extends CreateOrMergePatchAttributeSetInstanceExtensionFieldGroupDto
    {
        public MergePatchAttributeSetInstanceExtensionFieldGroupDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public AttributeSetInstanceExtensionFieldGroupCommand.MergePatchAttributeSetInstanceExtensionFieldGroup toMergePatchAttributeSetInstanceExtensionFieldGroup()
        {
            return (AttributeSetInstanceExtensionFieldGroupCommand.MergePatchAttributeSetInstanceExtensionFieldGroup) toCommand();
        }

    }

}

