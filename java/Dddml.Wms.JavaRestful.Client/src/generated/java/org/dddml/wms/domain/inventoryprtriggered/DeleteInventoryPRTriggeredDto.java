package org.dddml.wms.domain.inventoryprtriggered;


public class DeleteInventoryPRTriggeredDto extends AbstractInventoryPRTriggeredCommandDto
{

    public DeleteInventoryPRTriggeredDto() {
        this.commandType = COMMAND_TYPE_DELETE;
    }

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

}

