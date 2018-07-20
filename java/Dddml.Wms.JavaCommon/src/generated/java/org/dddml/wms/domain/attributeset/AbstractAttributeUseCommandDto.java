package org.dddml.wms.domain.attributeset;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractAttributeUseCommandDto extends AbstractCommand
{
    /**
     * Attribute Id
     */
    private String attributeId;

    public String getAttributeId()
    {
        return this.attributeId;
    }

    public void setAttributeId(String attributeId)
    {
        this.attributeId = attributeId;
    }


    public void copyTo(AbstractAttributeUseCommand command)
    {
        command.setAttributeId(this.getAttributeId());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
