package org.dddml.wms.domain.attributeusemvo;

import java.util.*;
import org.dddml.wms.domain.attributeset.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.Command;
import org.dddml.wms.specialization.DomainError;

public interface AttributeUseMvoCommand extends Command
{
    AttributeSetAttributeUseId getAttributeSetAttributeUseId();

    void setAttributeSetAttributeUseId(AttributeSetAttributeUseId attributeSetAttributeUseId);

    Long getAttributeSetVersion();

    void setAttributeSetVersion(Long attributeSetVersion);

    static void throwOnInvalidStateTransition(AttributeUseMvoState state, Command c) {
        if (state.getAttributeSetVersion() == null)
        {
            if (isCommandCreate((AttributeUseMvoCommand)c))
            {
                return;
            }
            throw DomainError.named("premature", "Can't do anything to unexistent aggregate");
        }
        if (state.getDeleted())
        {
            throw DomainError.named("zombie", "Can't do anything to deleted aggregate.");
        }
        if (isCommandCreate((AttributeUseMvoCommand)c))
            throw DomainError.named("rebirth", "Can't create aggregate that already exists");
    }

    static boolean isCommandCreate(AttributeUseMvoCommand c) {
        return ((c instanceof AttributeUseMvoCommand.CreateAttributeUseMvo) 
            && c.getAttributeSetVersion().equals(AttributeUseMvoState.VERSION_NULL));
    }

    interface CreateOrMergePatchAttributeUseMvo extends AttributeUseMvoCommand
    {
        Integer getSequenceNumber();

        void setSequenceNumber(Integer sequenceNumber);

        Long getVersion();

        void setVersion(Long version);

        Boolean getActive();

        void setActive(Boolean active);

        String getAttributeSetName();

        void setAttributeSetName(String attributeSetName);

        String getAttributeSetOrganizationId();

        void setAttributeSetOrganizationId(String attributeSetOrganizationId);

        String getAttributeSetDescription();

        void setAttributeSetDescription(String attributeSetDescription);

        String getAttributeSetSerialNumberAttributeId();

        void setAttributeSetSerialNumberAttributeId(String attributeSetSerialNumberAttributeId);

        String getAttributeSetLotAttributeId();

        void setAttributeSetLotAttributeId(String attributeSetLotAttributeId);

        String getAttributeSetReferenceId();

        void setAttributeSetReferenceId(String attributeSetReferenceId);

        String getAttributeSetCreatedBy();

        void setAttributeSetCreatedBy(String attributeSetCreatedBy);

        Date getAttributeSetCreatedAt();

        void setAttributeSetCreatedAt(Date attributeSetCreatedAt);

        String getAttributeSetUpdatedBy();

        void setAttributeSetUpdatedBy(String attributeSetUpdatedBy);

        Date getAttributeSetUpdatedAt();

        void setAttributeSetUpdatedAt(Date attributeSetUpdatedAt);

        Boolean getAttributeSetActive();

        void setAttributeSetActive(Boolean attributeSetActive);

        Boolean getAttributeSetDeleted();

        void setAttributeSetDeleted(Boolean attributeSetDeleted);

    }

    interface CreateAttributeUseMvo extends CreateOrMergePatchAttributeUseMvo
    {
    }

    interface MergePatchAttributeUseMvo extends CreateOrMergePatchAttributeUseMvo
    {
        Boolean getIsPropertySequenceNumberRemoved();

        void setIsPropertySequenceNumberRemoved(Boolean removed);

        Boolean getIsPropertyVersionRemoved();

        void setIsPropertyVersionRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetNameRemoved();

        void setIsPropertyAttributeSetNameRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetOrganizationIdRemoved();

        void setIsPropertyAttributeSetOrganizationIdRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetDescriptionRemoved();

        void setIsPropertyAttributeSetDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetSerialNumberAttributeIdRemoved();

        void setIsPropertyAttributeSetSerialNumberAttributeIdRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetLotAttributeIdRemoved();

        void setIsPropertyAttributeSetLotAttributeIdRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetReferenceIdRemoved();

        void setIsPropertyAttributeSetReferenceIdRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetCreatedByRemoved();

        void setIsPropertyAttributeSetCreatedByRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetCreatedAtRemoved();

        void setIsPropertyAttributeSetCreatedAtRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetUpdatedByRemoved();

        void setIsPropertyAttributeSetUpdatedByRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetUpdatedAtRemoved();

        void setIsPropertyAttributeSetUpdatedAtRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetActiveRemoved();

        void setIsPropertyAttributeSetActiveRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetDeletedRemoved();

        void setIsPropertyAttributeSetDeletedRemoved(Boolean removed);

    }

	interface DeleteAttributeUseMvo extends AttributeUseMvoCommand
	{
	}

}

