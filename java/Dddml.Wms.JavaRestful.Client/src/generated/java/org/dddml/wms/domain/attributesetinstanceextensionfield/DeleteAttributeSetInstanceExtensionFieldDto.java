package org.dddml.wms.domain.attributesetinstanceextensionfield;


public class DeleteAttributeSetInstanceExtensionFieldDto extends AbstractAttributeSetInstanceExtensionFieldCommandDto
{

    public DeleteAttributeSetInstanceExtensionFieldDto() {
        this.commandType = COMMAND_TYPE_DELETE;
    }

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

}

