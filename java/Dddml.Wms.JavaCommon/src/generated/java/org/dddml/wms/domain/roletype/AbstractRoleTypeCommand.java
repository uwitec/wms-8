package org.dddml.wms.domain.roletype;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractRoleTypeCommand extends AbstractCommand implements RoleTypeCommand
{
    private String roleTypeId;

    public String getRoleTypeId()
    {
        return this.roleTypeId;
    }

    public void setRoleTypeId(String roleTypeId)
    {
        this.roleTypeId = roleTypeId;
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


    public static abstract class AbstractCreateOrMergePatchRoleType extends AbstractRoleTypeCommand implements CreateOrMergePatchRoleType
    {
        private String parentTypeId;

        public String getParentTypeId()
        {
            return this.parentTypeId;
        }

        public void setParentTypeId(String parentTypeId)
        {
            this.parentTypeId = parentTypeId;
        }

        private String hasTable;

        public String getHasTable()
        {
            return this.hasTable;
        }

        public void setHasTable(String hasTable)
        {
            this.hasTable = hasTable;
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

    public static abstract class AbstractCreateRoleType extends AbstractCreateOrMergePatchRoleType implements CreateRoleType
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }

    }

    public static abstract class AbstractMergePatchRoleType extends AbstractCreateOrMergePatchRoleType implements MergePatchRoleType
    {
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }

        private Boolean isPropertyParentTypeIdRemoved;

        public Boolean getIsPropertyParentTypeIdRemoved()
        {
            return this.isPropertyParentTypeIdRemoved;
        }

        public void setIsPropertyParentTypeIdRemoved(Boolean removed)
        {
            this.isPropertyParentTypeIdRemoved = removed;
        }

        private Boolean isPropertyHasTableRemoved;

        public Boolean getIsPropertyHasTableRemoved()
        {
            return this.isPropertyHasTableRemoved;
        }

        public void setIsPropertyHasTableRemoved(Boolean removed)
        {
            this.isPropertyHasTableRemoved = removed;
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

    public static class SimpleCreateRoleType extends AbstractCreateRoleType
    {
    }

    
    public static class SimpleMergePatchRoleType extends AbstractMergePatchRoleType
    {
    }

    
	public static class SimpleDeleteRoleType extends AbstractRoleTypeCommand implements DeleteRoleType
	{
        @Override
        public String getCommandType() {
            return COMMAND_TYPE_DELETE;
        }
	}

    

}

