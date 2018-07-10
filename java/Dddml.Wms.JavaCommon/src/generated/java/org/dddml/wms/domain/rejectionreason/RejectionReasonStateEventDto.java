package org.dddml.wms.domain.rejectionreason;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractEvent;

public class RejectionReasonStateEventDto extends AbstractEvent
{

    private RejectionReasonEventId rejectionReasonEventId;

    RejectionReasonEventId getRejectionReasonEventId() {
        if (rejectionReasonEventId == null) { rejectionReasonEventId = new RejectionReasonEventId(); }
        return rejectionReasonEventId;
    }

    void setRejectionReasonEventId(RejectionReasonEventId eventId) {
        this.rejectionReasonEventId = eventId;
    }

    public String getRejectionReasonId() {
        return getRejectionReasonEventId().getRejectionReasonId();
    }

    public void setRejectionReasonId(String rejectionReasonId) {
        getRejectionReasonEventId().setRejectionReasonId(rejectionReasonId);
    }

    public Long getVersion() {
        return getRejectionReasonEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getRejectionReasonEventId().setVersion(version);
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


	public static class RejectionReasonStateCreatedDto extends RejectionReasonStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class RejectionReasonStateMergePatchedDto extends RejectionReasonStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class RejectionReasonStateDeletedDto extends RejectionReasonStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

