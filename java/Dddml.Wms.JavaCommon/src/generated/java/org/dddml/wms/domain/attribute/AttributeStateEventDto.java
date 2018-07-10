package org.dddml.wms.domain.attribute;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractEvent;

public class AttributeStateEventDto extends AbstractEvent
{

    private AttributeEventId attributeEventId;

    AttributeEventId getAttributeEventId() {
        if (attributeEventId == null) { attributeEventId = new AttributeEventId(); }
        return attributeEventId;
    }

    void setAttributeEventId(AttributeEventId eventId) {
        this.attributeEventId = eventId;
    }

    public String getAttributeId() {
        return getAttributeEventId().getAttributeId();
    }

    public void setAttributeId(String attributeId) {
        getAttributeEventId().setAttributeId(attributeId);
    }

    public Long getVersion() {
        return getAttributeEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getAttributeEventId().setVersion(version);
    }

    private String attributeName;

    public String getAttributeName() {
        return this.attributeName;
    }

    public void setAttributeName(String attributeName) {
        this.attributeName = attributeName;
    }

    private String organizationId;

    public String getOrganizationId() {
        return this.organizationId;
    }

    public void setOrganizationId(String organizationId) {
        this.organizationId = organizationId;
    }

    private String description;

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    private Boolean isMandatory;

    public Boolean getIsMandatory() {
        return this.isMandatory;
    }

    public void setIsMandatory(Boolean isMandatory) {
        this.isMandatory = isMandatory;
    }

    private String attributeValueType;

    public String getAttributeValueType() {
        return this.attributeValueType;
    }

    public void setAttributeValueType(String attributeValueType) {
        this.attributeValueType = attributeValueType;
    }

    private Integer attributeValueLength;

    public Integer getAttributeValueLength() {
        return this.attributeValueLength;
    }

    public void setAttributeValueLength(Integer attributeValueLength) {
        this.attributeValueLength = attributeValueLength;
    }

    private Boolean isList;

    public Boolean getIsList() {
        return this.isList;
    }

    public void setIsList(Boolean isList) {
        this.isList = isList;
    }

    private String fieldName;

    public String getFieldName() {
        return this.fieldName;
    }

    public void setFieldName(String fieldName) {
        this.fieldName = fieldName;
    }

    private String referenceId;

    public String getReferenceId() {
        return this.referenceId;
    }

    public void setReferenceId(String referenceId) {
        this.referenceId = referenceId;
    }

    private Boolean active;

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    private String createdBy;

    public String getCreatedBy() {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy) {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt() {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    private Boolean isPropertyAttributeNameRemoved;

    public Boolean getIsPropertyAttributeNameRemoved() {
        return this.isPropertyAttributeNameRemoved;
    }

    public void setIsPropertyAttributeNameRemoved(Boolean removed) {
        this.isPropertyAttributeNameRemoved = removed;
    }

    private Boolean isPropertyOrganizationIdRemoved;

    public Boolean getIsPropertyOrganizationIdRemoved() {
        return this.isPropertyOrganizationIdRemoved;
    }

    public void setIsPropertyOrganizationIdRemoved(Boolean removed) {
        this.isPropertyOrganizationIdRemoved = removed;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved() {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed) {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyIsMandatoryRemoved;

    public Boolean getIsPropertyIsMandatoryRemoved() {
        return this.isPropertyIsMandatoryRemoved;
    }

    public void setIsPropertyIsMandatoryRemoved(Boolean removed) {
        this.isPropertyIsMandatoryRemoved = removed;
    }

    private Boolean isPropertyAttributeValueTypeRemoved;

    public Boolean getIsPropertyAttributeValueTypeRemoved() {
        return this.isPropertyAttributeValueTypeRemoved;
    }

    public void setIsPropertyAttributeValueTypeRemoved(Boolean removed) {
        this.isPropertyAttributeValueTypeRemoved = removed;
    }

    private Boolean isPropertyAttributeValueLengthRemoved;

    public Boolean getIsPropertyAttributeValueLengthRemoved() {
        return this.isPropertyAttributeValueLengthRemoved;
    }

    public void setIsPropertyAttributeValueLengthRemoved(Boolean removed) {
        this.isPropertyAttributeValueLengthRemoved = removed;
    }

    private Boolean isPropertyIsListRemoved;

    public Boolean getIsPropertyIsListRemoved() {
        return this.isPropertyIsListRemoved;
    }

    public void setIsPropertyIsListRemoved(Boolean removed) {
        this.isPropertyIsListRemoved = removed;
    }

    private Boolean isPropertyFieldNameRemoved;

    public Boolean getIsPropertyFieldNameRemoved() {
        return this.isPropertyFieldNameRemoved;
    }

    public void setIsPropertyFieldNameRemoved(Boolean removed) {
        this.isPropertyFieldNameRemoved = removed;
    }

    private Boolean isPropertyReferenceIdRemoved;

    public Boolean getIsPropertyReferenceIdRemoved() {
        return this.isPropertyReferenceIdRemoved;
    }

    public void setIsPropertyReferenceIdRemoved(Boolean removed) {
        this.isPropertyReferenceIdRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }


    private AttributeValueStateEventDto[] attributeValueEvents;

    public AttributeValueStateEventDto[] getAttributeValueEvents() {
        return this.attributeValueEvents;
    }

    public void setAttributeValueEvents(AttributeValueStateEventDto[] events) {
        this.attributeValueEvents = events;
    }


    private AttributeAliasStateEventDto[] attributeAliasEvents;

    public AttributeAliasStateEventDto[] getAttributeAliasEvents() {
        return this.attributeAliasEvents;
    }

    public void setAttributeAliasEvents(AttributeAliasStateEventDto[] events) {
        this.attributeAliasEvents = events;
    }


	public static class AttributeStateCreatedDto extends AttributeStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class AttributeStateMergePatchedDto extends AttributeStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class AttributeStateDeletedDto extends AttributeStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

