package org.dddml.wms.domain.attribute;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchAttributeDto extends AbstractAttributeCommandDto
{
    /**
     * Attribute Name
     */
    private String attributeName;

    public String getAttributeName()
    {
        return this.attributeName;
    }

    public void setAttributeName(String attributeName)
    {
        this.attributeName = attributeName;
    }

    /**
     * Organization Id
     */
    private String organizationId;

    public String getOrganizationId()
    {
        return this.organizationId;
    }

    public void setOrganizationId(String organizationId)
    {
        this.organizationId = organizationId;
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
     * The field must have a value for the record to be saved to the database.
     */
    private Boolean isMandatory;

    public Boolean getIsMandatory()
    {
        return this.isMandatory;
    }

    public void setIsMandatory(Boolean isMandatory)
    {
        this.isMandatory = isMandatory;
    }

    /**
     * The Attribute Value type deternines the data/validation type.
     */
    private String attributeValueType;

    public String getAttributeValueType()
    {
        return this.attributeValueType;
    }

    public void setAttributeValueType(String attributeValueType)
    {
        this.attributeValueType = attributeValueType;
    }

    /**
     * Attribute Value Length
     */
    private Integer attributeValueLength;

    public Integer getAttributeValueLength()
    {
        return this.attributeValueLength;
    }

    public void setAttributeValueLength(Integer attributeValueLength)
    {
        this.attributeValueLength = attributeValueLength;
    }

    /**
     * Is the attribute values a list(enumerable).
     */
    private Boolean isList;

    public Boolean getIsList()
    {
        return this.isList;
    }

    public void setIsList(Boolean isList)
    {
        this.isList = isList;
    }

    /**
     * The field name to save this attribute.
     */
    private String fieldName;

    public String getFieldName()
    {
        return this.fieldName;
    }

    public void setFieldName(String fieldName)
    {
        this.fieldName = fieldName;
    }

    /**
     * Reference Id
     */
    private String referenceId;

    public String getReferenceId()
    {
        return this.referenceId;
    }

    public void setReferenceId(String referenceId)
    {
        this.referenceId = referenceId;
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

    private CreateOrMergePatchAttributeValueDto[] attributeValues;

    public CreateOrMergePatchAttributeValueDto[] getAttributeValues()
    {
        return this.attributeValues;
    }

    public void setAttributeValues(CreateOrMergePatchAttributeValueDto[] attributeValues)
    {
        this.attributeValues = attributeValues;
    }

    private CreateOrMergePatchAttributeAliasDto[] aliases;

    public CreateOrMergePatchAttributeAliasDto[] getAliases()
    {
        return this.aliases;
    }

    public void setAliases(CreateOrMergePatchAttributeAliasDto[] aliases)
    {
        this.aliases = aliases;
    }

    private Boolean isPropertyAttributeNameRemoved;

    public Boolean getIsPropertyAttributeNameRemoved()
    {
        return this.isPropertyAttributeNameRemoved;
    }

    public void setIsPropertyAttributeNameRemoved(Boolean removed)
    {
        this.isPropertyAttributeNameRemoved = removed;
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

    private Boolean isPropertyIsMandatoryRemoved;

    public Boolean getIsPropertyIsMandatoryRemoved()
    {
        return this.isPropertyIsMandatoryRemoved;
    }

    public void setIsPropertyIsMandatoryRemoved(Boolean removed)
    {
        this.isPropertyIsMandatoryRemoved = removed;
    }

    private Boolean isPropertyAttributeValueTypeRemoved;

    public Boolean getIsPropertyAttributeValueTypeRemoved()
    {
        return this.isPropertyAttributeValueTypeRemoved;
    }

    public void setIsPropertyAttributeValueTypeRemoved(Boolean removed)
    {
        this.isPropertyAttributeValueTypeRemoved = removed;
    }

    private Boolean isPropertyAttributeValueLengthRemoved;

    public Boolean getIsPropertyAttributeValueLengthRemoved()
    {
        return this.isPropertyAttributeValueLengthRemoved;
    }

    public void setIsPropertyAttributeValueLengthRemoved(Boolean removed)
    {
        this.isPropertyAttributeValueLengthRemoved = removed;
    }

    private Boolean isPropertyIsListRemoved;

    public Boolean getIsPropertyIsListRemoved()
    {
        return this.isPropertyIsListRemoved;
    }

    public void setIsPropertyIsListRemoved(Boolean removed)
    {
        this.isPropertyIsListRemoved = removed;
    }

    private Boolean isPropertyFieldNameRemoved;

    public Boolean getIsPropertyFieldNameRemoved()
    {
        return this.isPropertyFieldNameRemoved;
    }

    public void setIsPropertyFieldNameRemoved(Boolean removed)
    {
        this.isPropertyFieldNameRemoved = removed;
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

    public void copyTo(AbstractAttributeCommand.AbstractCreateOrMergePatchAttribute command)
    {
        ((AbstractAttributeCommandDto) this).copyTo(command);
        command.setAttributeName(this.getAttributeName());
        command.setOrganizationId(this.getOrganizationId());
        command.setDescription(this.getDescription());
        command.setIsMandatory(this.getIsMandatory());
        command.setAttributeValueType(this.getAttributeValueType());
        command.setAttributeValueLength(this.getAttributeValueLength());
        command.setIsList(this.getIsList());
        command.setFieldName(this.getFieldName());
        command.setReferenceId(this.getReferenceId());
        command.setActive(this.getActive());
    }

    public AttributeCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractAttributeCommand.SimpleCreateAttribute command = new AbstractAttributeCommand.SimpleCreateAttribute();
            copyTo((AbstractAttributeCommand.AbstractCreateAttribute) command);
            if (this.getAttributeValues() != null) {
                for (CreateOrMergePatchAttributeValueDto cmd : this.getAttributeValues()) {
                    command.getAttributeValues().add((AttributeValueCommand.CreateAttributeValue) cmd.toCommand());
                }
            }
            if (this.getAliases() != null) {
                for (CreateOrMergePatchAttributeAliasDto cmd : this.getAliases()) {
                    command.getAliases().add((AttributeAliasCommand.CreateAttributeAlias) cmd.toCommand());
                }
            }
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractAttributeCommand.SimpleMergePatchAttribute command = new AbstractAttributeCommand.SimpleMergePatchAttribute();
            copyTo((AbstractAttributeCommand.SimpleMergePatchAttribute) command);
            if (this.getAttributeValues() != null) {
                for (CreateOrMergePatchAttributeValueDto cmd : this.getAttributeValues()) {
                    command.getAttributeValueCommands().add(cmd.toCommand());
                }
            }
            if (this.getAliases() != null) {
                for (CreateOrMergePatchAttributeAliasDto cmd : this.getAliases()) {
                    command.getAttributeAliasCommands().add(cmd.toCommand());
                }
            }
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractAttributeCommand.AbstractCreateAttribute command)
    {
        copyTo((AbstractAttributeCommand.AbstractCreateOrMergePatchAttribute) command);
    }

    public void copyTo(AbstractAttributeCommand.AbstractMergePatchAttribute command)
    {
        copyTo((AbstractAttributeCommand.AbstractCreateOrMergePatchAttribute) command);
        command.setIsPropertyAttributeNameRemoved(this.getIsPropertyAttributeNameRemoved());
        command.setIsPropertyOrganizationIdRemoved(this.getIsPropertyOrganizationIdRemoved());
        command.setIsPropertyDescriptionRemoved(this.getIsPropertyDescriptionRemoved());
        command.setIsPropertyIsMandatoryRemoved(this.getIsPropertyIsMandatoryRemoved());
        command.setIsPropertyAttributeValueTypeRemoved(this.getIsPropertyAttributeValueTypeRemoved());
        command.setIsPropertyAttributeValueLengthRemoved(this.getIsPropertyAttributeValueLengthRemoved());
        command.setIsPropertyIsListRemoved(this.getIsPropertyIsListRemoved());
        command.setIsPropertyFieldNameRemoved(this.getIsPropertyFieldNameRemoved());
        command.setIsPropertyReferenceIdRemoved(this.getIsPropertyReferenceIdRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateAttributeDto extends CreateOrMergePatchAttributeDto
    {
        public CreateAttributeDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public AttributeCommand.CreateAttribute toCreateAttribute()
        {
            return (AttributeCommand.CreateAttribute) toCommand();
        }

    }

    public static class MergePatchAttributeDto extends CreateOrMergePatchAttributeDto
    {
        public MergePatchAttributeDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public AttributeCommand.MergePatchAttribute toMergePatchAttribute()
        {
            return (AttributeCommand.MergePatchAttribute) toCommand();
        }

    }

}

