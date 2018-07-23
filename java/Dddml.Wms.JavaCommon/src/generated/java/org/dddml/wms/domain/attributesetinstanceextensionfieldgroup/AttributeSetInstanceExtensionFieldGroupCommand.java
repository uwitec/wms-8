package org.dddml.wms.domain.attributesetinstanceextensionfieldgroup;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.Command;
import org.dddml.wms.specialization.DomainError;

public interface AttributeSetInstanceExtensionFieldGroupCommand extends Command
{
    String getId();

    void setId(String id);

    Long getVersion();

    void setVersion(Long version);

    static void throwOnInvalidStateTransition(AttributeSetInstanceExtensionFieldGroupState state, Command c) {
        if (state.getVersion() == null)
        {
            if (isCommandCreate((AttributeSetInstanceExtensionFieldGroupCommand)c))
            {
                return;
            }
            throw DomainError.named("premature", "Can't do anything to unexistent aggregate");
        }
        if (state.getDeleted() != null && state.getDeleted())
        {
            throw DomainError.named("zombie", "Can't do anything to deleted aggregate.");
        }
        if (isCommandCreate((AttributeSetInstanceExtensionFieldGroupCommand)c))
            throw DomainError.named("rebirth", "Can't create aggregate that already exists");
    }

    static boolean isCommandCreate(AttributeSetInstanceExtensionFieldGroupCommand c) {
        return ((c instanceof AttributeSetInstanceExtensionFieldGroupCommand.CreateAttributeSetInstanceExtensionFieldGroup) 
            && c.getVersion().equals(AttributeSetInstanceExtensionFieldGroupState.VERSION_NULL));
    }

    interface CreateOrMergePatchAttributeSetInstanceExtensionFieldGroup extends AttributeSetInstanceExtensionFieldGroupCommand
    {
        String getFieldType();

        void setFieldType(String fieldType);

        Integer getFieldLength();

        void setFieldLength(Integer fieldLength);

        Integer getFieldCount();

        void setFieldCount(Integer fieldCount);

        String getNameFormat();

        void setNameFormat(String nameFormat);

        String getDescription();

        void setDescription(String description);

        Boolean getActive();

        void setActive(Boolean active);

    }

    interface CreateAttributeSetInstanceExtensionFieldGroup extends CreateOrMergePatchAttributeSetInstanceExtensionFieldGroup
    {
    }

    interface MergePatchAttributeSetInstanceExtensionFieldGroup extends CreateOrMergePatchAttributeSetInstanceExtensionFieldGroup
    {
        Boolean getIsPropertyFieldTypeRemoved();

        void setIsPropertyFieldTypeRemoved(Boolean removed);

        Boolean getIsPropertyFieldLengthRemoved();

        void setIsPropertyFieldLengthRemoved(Boolean removed);

        Boolean getIsPropertyFieldCountRemoved();

        void setIsPropertyFieldCountRemoved(Boolean removed);

        Boolean getIsPropertyNameFormatRemoved();

        void setIsPropertyNameFormatRemoved(Boolean removed);

        Boolean getIsPropertyDescriptionRemoved();

        void setIsPropertyDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

    }

	interface DeleteAttributeSetInstanceExtensionFieldGroup extends AttributeSetInstanceExtensionFieldGroupCommand
	{
	}

}

