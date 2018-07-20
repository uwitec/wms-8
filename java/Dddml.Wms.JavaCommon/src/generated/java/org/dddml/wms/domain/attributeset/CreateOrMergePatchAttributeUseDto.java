package org.dddml.wms.domain.attributeset;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchAttributeUseDto extends AbstractAttributeUseCommandDto
{
    /**
     * Sequence Number
     */
    private Integer sequenceNumber;

    public Integer getSequenceNumber()
    {
        return this.sequenceNumber;
    }

    public void setSequenceNumber(Integer sequenceNumber)
    {
        this.sequenceNumber = sequenceNumber;
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

    private Boolean isPropertySequenceNumberRemoved;

    public Boolean getIsPropertySequenceNumberRemoved()
    {
        return this.isPropertySequenceNumberRemoved;
    }

    public void setIsPropertySequenceNumberRemoved(Boolean removed)
    {
        this.isPropertySequenceNumberRemoved = removed;
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

    public void copyTo(AbstractAttributeUseCommand.AbstractCreateOrMergePatchAttributeUse command)
    {
        ((AbstractAttributeUseCommandDto) this).copyTo(command);
        command.setSequenceNumber(this.getSequenceNumber());
        command.setActive(this.getActive());
    }

    public AttributeUseCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractAttributeUseCommand.SimpleCreateAttributeUse command = new AbstractAttributeUseCommand.SimpleCreateAttributeUse();
            copyTo((AbstractAttributeUseCommand.AbstractCreateAttributeUse) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractAttributeUseCommand.SimpleMergePatchAttributeUse command = new AbstractAttributeUseCommand.SimpleMergePatchAttributeUse();
            copyTo((AbstractAttributeUseCommand.SimpleMergePatchAttributeUse) command);
            return command;
        } 
        else if (COMMAND_TYPE_REMOVE.equals(getCommandType())) {
            AbstractAttributeUseCommand.SimpleRemoveAttributeUse command = new AbstractAttributeUseCommand.SimpleRemoveAttributeUse();
            ((AbstractAttributeUseCommandDto) this).copyTo(command);
            return command;
        }
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractAttributeUseCommand.AbstractCreateAttributeUse command)
    {
        copyTo((AbstractAttributeUseCommand.AbstractCreateOrMergePatchAttributeUse) command);
    }

    public void copyTo(AbstractAttributeUseCommand.AbstractMergePatchAttributeUse command)
    {
        copyTo((AbstractAttributeUseCommand.AbstractCreateOrMergePatchAttributeUse) command);
        command.setIsPropertySequenceNumberRemoved(this.getIsPropertySequenceNumberRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateAttributeUseDto extends CreateOrMergePatchAttributeUseDto
    {
        public CreateAttributeUseDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public AttributeUseCommand.CreateAttributeUse toCreateAttributeUse()
        {
            return (AttributeUseCommand.CreateAttributeUse) toCommand();
        }

    }

    public static class MergePatchAttributeUseDto extends CreateOrMergePatchAttributeUseDto
    {
        public MergePatchAttributeUseDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public AttributeUseCommand.MergePatchAttributeUse toMergePatchAttributeUse()
        {
            return (AttributeUseCommand.MergePatchAttributeUse) toCommand();
        }

    }

}

