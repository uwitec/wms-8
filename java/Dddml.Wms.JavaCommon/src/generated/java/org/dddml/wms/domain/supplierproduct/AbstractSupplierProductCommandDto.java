package org.dddml.wms.domain.supplierproduct;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractCommand;

public abstract class AbstractSupplierProductCommandDto extends AbstractCommand
{
    /**
     * Supplier Product Id
     */
    private SupplierProductId supplierProductId;

    public SupplierProductId getSupplierProductId()
    {
        return this.supplierProductId;
    }

    public void setSupplierProductId(SupplierProductId supplierProductId)
    {
        this.supplierProductId = supplierProductId;
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


    public void copyTo(AbstractSupplierProductCommand command)
    {
        command.setSupplierProductId(this.getSupplierProductId());
        command.setVersion(this.getVersion());
        
        command.setRequesterId(this.getRequesterId());
        command.setCommandId(this.getCommandId());
    }

}
