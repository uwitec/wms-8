package org.dddml.wms.domain.uom;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractEvent;

public class UomStateEventDto extends AbstractEvent
{

    private UomEventId uomEventId;

    UomEventId getUomEventId() {
        if (uomEventId == null) { uomEventId = new UomEventId(); }
        return uomEventId;
    }

    void setUomEventId(UomEventId eventId) {
        this.uomEventId = eventId;
    }

    public String getUomId() {
        return getUomEventId().getUomId();
    }

    public void setUomId(String uomId) {
        getUomEventId().setUomId(uomId);
    }

    public Long getVersion() {
        return getUomEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getUomEventId().setVersion(version);
    }

    private String uomTypeId;

    public String getUomTypeId() {
        return this.uomTypeId;
    }

    public void setUomTypeId(String uomTypeId) {
        this.uomTypeId = uomTypeId;
    }

    private String abbreviation;

    public String getAbbreviation() {
        return this.abbreviation;
    }

    public void setAbbreviation(String abbreviation) {
        this.abbreviation = abbreviation;
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

    private Boolean isPropertyUomTypeIdRemoved;

    public Boolean getIsPropertyUomTypeIdRemoved() {
        return this.isPropertyUomTypeIdRemoved;
    }

    public void setIsPropertyUomTypeIdRemoved(Boolean removed) {
        this.isPropertyUomTypeIdRemoved = removed;
    }

    private Boolean isPropertyAbbreviationRemoved;

    public Boolean getIsPropertyAbbreviationRemoved() {
        return this.isPropertyAbbreviationRemoved;
    }

    public void setIsPropertyAbbreviationRemoved(Boolean removed) {
        this.isPropertyAbbreviationRemoved = removed;
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


	public static class UomStateCreatedDto extends UomStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class UomStateMergePatchedDto extends UomStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class UomStateDeletedDto extends UomStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

