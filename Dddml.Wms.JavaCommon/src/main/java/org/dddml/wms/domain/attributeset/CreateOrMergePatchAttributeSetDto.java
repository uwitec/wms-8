package org.dddml.wms.domain.attributeset;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchAttributeSetDto extends AbstractAttributeSetCommandDto
{
    private String attributeSetName;

    public String getAttributeSetName()
    {
        return this.attributeSetName;
    }

    public void setAttributeSetName(String attributeSetName)
    {
        this.attributeSetName = attributeSetName;
    }

    private String organizationId;

    public String getOrganizationId()
    {
        return this.organizationId;
    }

    public void setOrganizationId(String organizationId)
    {
        this.organizationId = organizationId;
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

    private String serialNumberAttributeId;

    public String getSerialNumberAttributeId()
    {
        return this.serialNumberAttributeId;
    }

    public void setSerialNumberAttributeId(String serialNumberAttributeId)
    {
        this.serialNumberAttributeId = serialNumberAttributeId;
    }

    private String lotAttributeId;

    public String getLotAttributeId()
    {
        return this.lotAttributeId;
    }

    public void setLotAttributeId(String lotAttributeId)
    {
        this.lotAttributeId = lotAttributeId;
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

    private Boolean isInstanceAttributeSet;

    public Boolean getIsInstanceAttributeSet()
    {
        return this.isInstanceAttributeSet;
    }

    public void setIsInstanceAttributeSet(Boolean isInstanceAttributeSet)
    {
        this.isInstanceAttributeSet = isInstanceAttributeSet;
    }

    private Boolean isMandatory;

    public Boolean getIsMandatory()
    {
        return this.isMandatory;
    }

    public void setIsMandatory(Boolean isMandatory)
    {
        this.isMandatory = isMandatory;
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

    private CreateOrMergePatchAttributeUseDto[] attributeUses;

    public CreateOrMergePatchAttributeUseDto[] getAttributeUses()
    {
        return this.attributeUses;
    }

    public void setAttributeUses(CreateOrMergePatchAttributeUseDto[] attributeUses)
    {
        this.attributeUses = attributeUses;
    }

    private Boolean isPropertyAttributeSetNameRemoved;

    public Boolean getIsPropertyAttributeSetNameRemoved()
    {
        return this.isPropertyAttributeSetNameRemoved;
    }

    public void setIsPropertyAttributeSetNameRemoved(Boolean removed)
    {
        this.isPropertyAttributeSetNameRemoved = removed;
    }

    private Boolean isPropertyOrganizationIdRemoved;

    public Boolean getIsPropertyOrganizationIdRemoved()
    {
        return this.isPropertyOrganizationIdRemoved;
    }

    public void setIsPropertyOrganizationIdRemoved(Boolean removed)
    {
        this.isPropertyOrganizationIdRemoved = removed;
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

    private Boolean isPropertySerialNumberAttributeIdRemoved;

    public Boolean getIsPropertySerialNumberAttributeIdRemoved()
    {
        return this.isPropertySerialNumberAttributeIdRemoved;
    }

    public void setIsPropertySerialNumberAttributeIdRemoved(Boolean removed)
    {
        this.isPropertySerialNumberAttributeIdRemoved = removed;
    }

    private Boolean isPropertyLotAttributeIdRemoved;

    public Boolean getIsPropertyLotAttributeIdRemoved()
    {
        return this.isPropertyLotAttributeIdRemoved;
    }

    public void setIsPropertyLotAttributeIdRemoved(Boolean removed)
    {
        this.isPropertyLotAttributeIdRemoved = removed;
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

    private Boolean isPropertyIsInstanceAttributeSetRemoved;

    public Boolean getIsPropertyIsInstanceAttributeSetRemoved()
    {
        return this.isPropertyIsInstanceAttributeSetRemoved;
    }

    public void setIsPropertyIsInstanceAttributeSetRemoved(Boolean removed)
    {
        this.isPropertyIsInstanceAttributeSetRemoved = removed;
    }

    private Boolean isPropertyIsMandatoryRemoved;

    public Boolean getIsPropertyIsMandatoryRemoved()
    {
        return this.isPropertyIsMandatoryRemoved;
    }

    public void setIsPropertyIsMandatoryRemoved(Boolean removed)
    {
        this.isPropertyIsMandatoryRemoved = removed;
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

    public void copyTo(AbstractAttributeSetCommand.AbstractCreateOrMergePatchAttributeSet command)
    {
        ((AbstractAttributeSetCommandDto) this).copyTo(command);
        command.setAttributeSetName(this.getAttributeSetName());
        command.setOrganizationId(this.getOrganizationId());
        command.setDescription(this.getDescription());
        command.setSerialNumberAttributeId(this.getSerialNumberAttributeId());
        command.setLotAttributeId(this.getLotAttributeId());
        command.setReferenceId(this.getReferenceId());
        command.setIsInstanceAttributeSet(this.getIsInstanceAttributeSet());
        command.setIsMandatory(this.getIsMandatory());
        command.setActive(this.getActive());
    }

    public AttributeSetCommand toCommand()
    {
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractAttributeSetCommand.SimpleCreateAttributeSet command = new AbstractAttributeSetCommand.SimpleCreateAttributeSet();
            copyTo((AbstractAttributeSetCommand.AbstractCreateAttributeSet) command);
            if (this.getAttributeUses() != null) {
                for (CreateOrMergePatchAttributeUseDto cmd : this.getAttributeUses()) {
                    command.getAttributeUses().add((AttributeUseCommand.CreateAttributeUse) cmd.toCommand());
                }
            }
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractAttributeSetCommand.SimpleMergePatchAttributeSet command = new AbstractAttributeSetCommand.SimpleMergePatchAttributeSet();
            copyTo((AbstractAttributeSetCommand.SimpleMergePatchAttributeSet) command);
            if (this.getAttributeUses() != null) {
                for (CreateOrMergePatchAttributeUseDto cmd : this.getAttributeUses()) {
                    command.getAttributeUseCommands().add(cmd.toCommand());
                }
            }
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractAttributeSetCommand.AbstractCreateAttributeSet command)
    {
        copyTo((AbstractAttributeSetCommand.AbstractCreateOrMergePatchAttributeSet) command);
    }

    public void copyTo(AbstractAttributeSetCommand.AbstractMergePatchAttributeSet command)
    {
        copyTo((AbstractAttributeSetCommand.AbstractCreateOrMergePatchAttributeSet) command);
        command.setIsPropertyAttributeSetNameRemoved(this.getIsPropertyAttributeSetNameRemoved());
        command.setIsPropertyOrganizationIdRemoved(this.getIsPropertyOrganizationIdRemoved());
        command.setIsPropertyDescriptionRemoved(this.getIsPropertyDescriptionRemoved());
        command.setIsPropertySerialNumberAttributeIdRemoved(this.getIsPropertySerialNumberAttributeIdRemoved());
        command.setIsPropertyLotAttributeIdRemoved(this.getIsPropertyLotAttributeIdRemoved());
        command.setIsPropertyReferenceIdRemoved(this.getIsPropertyReferenceIdRemoved());
        command.setIsPropertyIsInstanceAttributeSetRemoved(this.getIsPropertyIsInstanceAttributeSetRemoved());
        command.setIsPropertyIsMandatoryRemoved(this.getIsPropertyIsMandatoryRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateAttributeSetDto extends CreateOrMergePatchAttributeSetDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public AttributeSetCommand.CreateAttributeSet toCreateAttributeSet()
        {
            return (AttributeSetCommand.CreateAttributeSet) toCommand();
        }

    }

    public static class MergePatchAttributeSetDto extends CreateOrMergePatchAttributeSetDto
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public AttributeSetCommand.MergePatchAttributeSet toMergePatchAttributeSet()
        {
            return (AttributeSetCommand.MergePatchAttributeSet) toCommand();
        }

    }

}

