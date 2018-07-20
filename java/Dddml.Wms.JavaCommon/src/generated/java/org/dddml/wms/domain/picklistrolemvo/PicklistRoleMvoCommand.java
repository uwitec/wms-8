package org.dddml.wms.domain.picklistrolemvo;

import java.util.*;
import org.dddml.wms.domain.picklist.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.Command;
import org.dddml.wms.specialization.DomainError;

public interface PicklistRoleMvoCommand extends Command
{
    PicklistRoleId getPicklistRoleId();

    void setPicklistRoleId(PicklistRoleId picklistRoleId);

    Long getPicklistVersion();

    void setPicklistVersion(Long picklistVersion);

    static void throwOnInvalidStateTransition(PicklistRoleMvoState state, Command c) {
        if (state.getPicklistVersion() == null)
        {
            if (isCommandCreate((PicklistRoleMvoCommand)c))
            {
                return;
            }
            throw DomainError.named("premature", "Can't do anything to unexistent aggregate");
        }
        if (state.getDeleted() != null && state.getDeleted())
        {
            throw DomainError.named("zombie", "Can't do anything to deleted aggregate.");
        }
        if (isCommandCreate((PicklistRoleMvoCommand)c))
            throw DomainError.named("rebirth", "Can't create aggregate that already exists");
    }

    static boolean isCommandCreate(PicklistRoleMvoCommand c) {
        return ((c instanceof PicklistRoleMvoCommand.CreatePicklistRoleMvo) 
            && c.getPicklistVersion().equals(PicklistRoleMvoState.VERSION_NULL));
    }

    interface CreateOrMergePatchPicklistRoleMvo extends PicklistRoleMvoCommand
    {
        Long getVersion();

        void setVersion(Long version);

        Boolean getActive();

        void setActive(Boolean active);

        String getPicklistDescription();

        void setPicklistDescription(String picklistDescription);

        String getPicklistFacilityId();

        void setPicklistFacilityId(String picklistFacilityId);

        String getPicklistShipmentMethodTypeId();

        void setPicklistShipmentMethodTypeId(String picklistShipmentMethodTypeId);

        String getPicklistStatusId();

        void setPicklistStatusId(String picklistStatusId);

        java.sql.Timestamp getPicklistPicklistDate();

        void setPicklistPicklistDate(java.sql.Timestamp picklistPicklistDate);

        Long getPicklistPickwaveId();

        void setPicklistPickwaveId(Long picklistPickwaveId);

        String getPicklistCreatedBy();

        void setPicklistCreatedBy(String picklistCreatedBy);

        Date getPicklistCreatedAt();

        void setPicklistCreatedAt(Date picklistCreatedAt);

        String getPicklistUpdatedBy();

        void setPicklistUpdatedBy(String picklistUpdatedBy);

        Date getPicklistUpdatedAt();

        void setPicklistUpdatedAt(Date picklistUpdatedAt);

        Boolean getPicklistActive();

        void setPicklistActive(Boolean picklistActive);

        Boolean getPicklistDeleted();

        void setPicklistDeleted(Boolean picklistDeleted);

    }

    interface CreatePicklistRoleMvo extends CreateOrMergePatchPicklistRoleMvo
    {
    }

    interface MergePatchPicklistRoleMvo extends CreateOrMergePatchPicklistRoleMvo
    {
        Boolean getIsPropertyVersionRemoved();

        void setIsPropertyVersionRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

        Boolean getIsPropertyPicklistDescriptionRemoved();

        void setIsPropertyPicklistDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyPicklistFacilityIdRemoved();

        void setIsPropertyPicklistFacilityIdRemoved(Boolean removed);

        Boolean getIsPropertyPicklistShipmentMethodTypeIdRemoved();

        void setIsPropertyPicklistShipmentMethodTypeIdRemoved(Boolean removed);

        Boolean getIsPropertyPicklistStatusIdRemoved();

        void setIsPropertyPicklistStatusIdRemoved(Boolean removed);

        Boolean getIsPropertyPicklistPicklistDateRemoved();

        void setIsPropertyPicklistPicklistDateRemoved(Boolean removed);

        Boolean getIsPropertyPicklistPickwaveIdRemoved();

        void setIsPropertyPicklistPickwaveIdRemoved(Boolean removed);

        Boolean getIsPropertyPicklistCreatedByRemoved();

        void setIsPropertyPicklistCreatedByRemoved(Boolean removed);

        Boolean getIsPropertyPicklistCreatedAtRemoved();

        void setIsPropertyPicklistCreatedAtRemoved(Boolean removed);

        Boolean getIsPropertyPicklistUpdatedByRemoved();

        void setIsPropertyPicklistUpdatedByRemoved(Boolean removed);

        Boolean getIsPropertyPicklistUpdatedAtRemoved();

        void setIsPropertyPicklistUpdatedAtRemoved(Boolean removed);

        Boolean getIsPropertyPicklistActiveRemoved();

        void setIsPropertyPicklistActiveRemoved(Boolean removed);

        Boolean getIsPropertyPicklistDeletedRemoved();

        void setIsPropertyPicklistDeletedRemoved(Boolean removed);

    }

	interface DeletePicklistRoleMvo extends PicklistRoleMvoCommand
	{
	}

}

