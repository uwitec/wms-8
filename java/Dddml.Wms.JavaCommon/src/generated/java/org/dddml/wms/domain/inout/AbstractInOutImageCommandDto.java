package org.dddml.wms.domain.inout;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractInOutImageCommandDto extends AbstractCommand
{
    /**
     * Sequence Id
     */
    private String sequenceId;

    public String getSequenceId()
    {
        return this.sequenceId;
    }

    public void setSequenceId(String sequenceId)
    {
        this.sequenceId = sequenceId;
    }


    public void copyTo(AbstractInOutImageCommand command)
    {
        command.setSequenceId(this.getSequenceId());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
