package org.dddml.wms.domain.inventoryprtriggered;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractInventoryPRTriggeredCommandDto extends AbstractCommand
{
    /**
     * Inventory PR Triggered Id
     */
    private InventoryPRTriggeredId inventoryPRTriggeredId;

    public InventoryPRTriggeredId getInventoryPRTriggeredId()
    {
        return this.inventoryPRTriggeredId;
    }

    public void setInventoryPRTriggeredId(InventoryPRTriggeredId inventoryPRTriggeredId)
    {
        this.inventoryPRTriggeredId = inventoryPRTriggeredId;
    }

    /**
     * Version
     */
    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }


    public void copyTo(AbstractInventoryPRTriggeredCommand command)
    {
        command.setInventoryPRTriggeredId(this.getInventoryPRTriggeredId());
        command.setVersion(this.getVersion());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
