package org.dddml.wms.domain.partyrole;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchPartyRoleDto extends AbstractPartyRoleCommandDto
{
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

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved()
    {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed)
    {
        this.isPropertyActiveRemoved = removed;
    }

    public static class CreatePartyRoleDto extends CreateOrMergePatchPartyRoleDto
    {
        public CreatePartyRoleDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }

    }

    public static class MergePatchPartyRoleDto extends CreateOrMergePatchPartyRoleDto
    {
        public MergePatchPartyRoleDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }

    }

}

