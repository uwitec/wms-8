package org.dddml.wms.domain.attribute;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchAttributeValueDto extends AbstractAttributeValueCommandDto
{
    private String attributeValueName;

    public String getAttributeValueName()
    {
        return this.attributeValueName;
    }

    public void setAttributeValueName(String attributeValueName)
    {
        this.attributeValueName = attributeValueName;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private String referenceId;

    public String getReferenceId()
    {
        return this.referenceId;
    }

    public void setReferenceId(String referenceId)
    {
        this.referenceId = referenceId;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Boolean isPropertyAttributeValueNameRemoved;

    public Boolean getIsPropertyAttributeValueNameRemoved()
    {
        return this.isPropertyAttributeValueNameRemoved;
    }

    public void setIsPropertyAttributeValueNameRemoved(Boolean removed)
    {
        this.isPropertyAttributeValueNameRemoved = removed;
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

    private Boolean isPropertyReferenceIdRemoved;

    public Boolean getIsPropertyReferenceIdRemoved()
    {
        return this.isPropertyReferenceIdRemoved;
    }

    public void setIsPropertyReferenceIdRemoved(Boolean removed)
    {
        this.isPropertyReferenceIdRemoved = removed;
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

    public void copyTo(AbstractAttributeValueCommand.AbstractCreateOrMergePatchAttributeValue command)
    {
        ((AbstractAttributeValueCommandDto) this).copyTo(command);
        command.setAttributeValueName(this.getAttributeValueName());
        command.setDescription(this.getDescription());
        command.setReferenceId(this.getReferenceId());
        command.setActive(this.getActive());
    }

    public AttributeValueCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractAttributeValueCommand.SimpleCreateAttributeValue command = new AbstractAttributeValueCommand.SimpleCreateAttributeValue();
            copyTo((AbstractAttributeValueCommand.AbstractCreateAttributeValue) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractAttributeValueCommand.SimpleMergePatchAttributeValue command = new AbstractAttributeValueCommand.SimpleMergePatchAttributeValue();
            copyTo((AbstractAttributeValueCommand.SimpleMergePatchAttributeValue) command);
            return command;
        } 
        else if (COMMAND_TYPE_REMOVE.equals(getCommandType())) {
            AbstractAttributeValueCommand.SimpleRemoveAttributeValue command = new AbstractAttributeValueCommand.SimpleRemoveAttributeValue();
            ((AbstractAttributeValueCommandDto) this).copyTo(command);
            return command;
        }
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractAttributeValueCommand.AbstractCreateAttributeValue command)
    {
        copyTo((AbstractAttributeValueCommand.AbstractCreateOrMergePatchAttributeValue) command);
    }

    public void copyTo(AbstractAttributeValueCommand.AbstractMergePatchAttributeValue command)
    {
        copyTo((AbstractAttributeValueCommand.AbstractCreateOrMergePatchAttributeValue) command);
        command.setIsPropertyAttributeValueNameRemoved(this.getIsPropertyAttributeValueNameRemoved());
        command.setIsPropertyDescriptionRemoved(this.getIsPropertyDescriptionRemoved());
        command.setIsPropertyReferenceIdRemoved(this.getIsPropertyReferenceIdRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateAttributeValueDto extends CreateOrMergePatchAttributeValueDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public AttributeValueCommand.CreateAttributeValue toCreateAttributeValue()
        {
            return (AttributeValueCommand.CreateAttributeValue) toCommand();
        }

    }

    public static class MergePatchAttributeValueDto extends CreateOrMergePatchAttributeValueDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public AttributeValueCommand.MergePatchAttributeValue toMergePatchAttributeValue()
        {
            return (AttributeValueCommand.MergePatchAttributeValue) toCommand();
        }

    }

}

