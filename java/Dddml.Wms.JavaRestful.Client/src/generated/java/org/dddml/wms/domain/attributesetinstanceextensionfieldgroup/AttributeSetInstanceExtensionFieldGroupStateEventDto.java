package org.dddml.wms.domain.attributesetinstanceextensionfieldgroup;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractEvent;

public class AttributeSetInstanceExtensionFieldGroupStateEventDto extends AbstractEvent
{

    private AttributeSetInstanceExtensionFieldGroupEventId attributeSetInstanceExtensionFieldGroupEventId;

    AttributeSetInstanceExtensionFieldGroupEventId getAttributeSetInstanceExtensionFieldGroupEventId() {
        if (attributeSetInstanceExtensionFieldGroupEventId == null) { attributeSetInstanceExtensionFieldGroupEventId = new AttributeSetInstanceExtensionFieldGroupEventId(); }
        return attributeSetInstanceExtensionFieldGroupEventId;
    }

    void setAttributeSetInstanceExtensionFieldGroupEventId(AttributeSetInstanceExtensionFieldGroupEventId eventId) {
        this.attributeSetInstanceExtensionFieldGroupEventId = eventId;
    }

    public String getId() {
        return getAttributeSetInstanceExtensionFieldGroupEventId().getId();
    }

    public void setId(String id) {
        getAttributeSetInstanceExtensionFieldGroupEventId().setId(id);
    }

    public Long getVersion() {
        return getAttributeSetInstanceExtensionFieldGroupEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getAttributeSetInstanceExtensionFieldGroupEventId().setVersion(version);
    }

    private String fieldType;

    public String getFieldType() {
        return this.fieldType;
    }

    public void setFieldType(String fieldType) {
        this.fieldType = fieldType;
    }

    private Integer fieldLength;

    public Integer getFieldLength() {
        return this.fieldLength;
    }

    public void setFieldLength(Integer fieldLength) {
        this.fieldLength = fieldLength;
    }

    private Integer fieldCount;

    public Integer getFieldCount() {
        return this.fieldCount;
    }

    public void setFieldCount(Integer fieldCount) {
        this.fieldCount = fieldCount;
    }

    private String nameFormat;

    public String getNameFormat() {
        return this.nameFormat;
    }

    public void setNameFormat(String nameFormat) {
        this.nameFormat = nameFormat;
    }

    private String description;

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
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

    private Boolean isPropertyFieldTypeRemoved;

    public Boolean getIsPropertyFieldTypeRemoved() {
        return this.isPropertyFieldTypeRemoved;
    }

    public void setIsPropertyFieldTypeRemoved(Boolean removed) {
        this.isPropertyFieldTypeRemoved = removed;
    }

    private Boolean isPropertyFieldLengthRemoved;

    public Boolean getIsPropertyFieldLengthRemoved() {
        return this.isPropertyFieldLengthRemoved;
    }

    public void setIsPropertyFieldLengthRemoved(Boolean removed) {
        this.isPropertyFieldLengthRemoved = removed;
    }

    private Boolean isPropertyFieldCountRemoved;

    public Boolean getIsPropertyFieldCountRemoved() {
        return this.isPropertyFieldCountRemoved;
    }

    public void setIsPropertyFieldCountRemoved(Boolean removed) {
        this.isPropertyFieldCountRemoved = removed;
    }

    private Boolean isPropertyNameFormatRemoved;

    public Boolean getIsPropertyNameFormatRemoved() {
        return this.isPropertyNameFormatRemoved;
    }

    public void setIsPropertyNameFormatRemoved(Boolean removed) {
        this.isPropertyNameFormatRemoved = removed;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved() {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed) {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }


	public static class AttributeSetInstanceExtensionFieldGroupStateCreatedDto extends AttributeSetInstanceExtensionFieldGroupStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class AttributeSetInstanceExtensionFieldGroupStateMergePatchedDto extends AttributeSetInstanceExtensionFieldGroupStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class AttributeSetInstanceExtensionFieldGroupStateDeletedDto extends AttributeSetInstanceExtensionFieldGroupStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

