package org.dddml.wms.domain.statusitem;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractStatusItemCommand extends AbstractCommand implements StatusItemCommand
{
    private String statusId;

    public String getStatusId()
    {
        return this.statusId;
    }

    public void setStatusId(String statusId)
    {
        this.statusId = statusId;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }


    public static abstract class AbstractCreateOrMergePatchStatusItem extends AbstractStatusItemCommand implements CreateOrMergePatchStatusItem
    {
        private String statusTypeId;

        public String getStatusTypeId()
        {
            return this.statusTypeId;
        }

        public void setStatusTypeId(String statusTypeId)
        {
            this.statusTypeId = statusTypeId;
        }

        private String statusCode;

        public String getStatusCode()
        {
            return this.statusCode;
        }

        public void setStatusCode(String statusCode)
        {
            this.statusCode = statusCode;
        }

        private String sequenceId;

        public String getSequenceId()
        {
            return this.sequenceId;
        }

        public void setSequenceId(String sequenceId)
        {
            this.sequenceId = sequenceId;
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

        private Boolean active;

        public Boolean getActive()
        {
            return this.active;
        }

        public void setActive(Boolean active)
        {
            this.active = active;
        }

    }

    public static abstract class AbstractCreateStatusItem extends AbstractCreateOrMergePatchStatusItem implements CreateStatusItem
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }

    }

    public static abstract class AbstractMergePatchStatusItem extends AbstractCreateOrMergePatchStatusItem implements MergePatchStatusItem
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }

        private Boolean isPropertyStatusTypeIdRemoved;

        public Boolean getIsPropertyStatusTypeIdRemoved()
        {
            return this.isPropertyStatusTypeIdRemoved;
        }

        public void setIsPropertyStatusTypeIdRemoved(Boolean removed)
        {
            this.isPropertyStatusTypeIdRemoved = removed;
        }

        private Boolean isPropertyStatusCodeRemoved;

        public Boolean getIsPropertyStatusCodeRemoved()
        {
            return this.isPropertyStatusCodeRemoved;
        }

        public void setIsPropertyStatusCodeRemoved(Boolean removed)
        {
            this.isPropertyStatusCodeRemoved = removed;
        }

        private Boolean isPropertySequenceIdRemoved;

        public Boolean getIsPropertySequenceIdRemoved()
        {
            return this.isPropertySequenceIdRemoved;
        }

        public void setIsPropertySequenceIdRemoved(Boolean removed)
        {
            this.isPropertySequenceIdRemoved = removed;
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

    }

    public static class SimpleCreateStatusItem extends AbstractCreateStatusItem
    {
    }

    
    public static class SimpleMergePatchStatusItem extends AbstractMergePatchStatusItem
    {
    }

    
	public static class SimpleDeleteStatusItem extends AbstractStatusItemCommand implements DeleteStatusItem
	{
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_DELETE;
        }
	}

    

}

