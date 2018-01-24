package org.dddml.wms.domain.physicalinventory;

import org.dddml.wms.domain.*;

public class PhysicalInventoryStateEventIdDto
{

    public PhysicalInventoryStateEventIdDto()
    {
    }

    public PhysicalInventoryStateEventId toPhysicalInventoryStateEventId()
    {
        PhysicalInventoryStateEventId v = new PhysicalInventoryStateEventId();
        v.setDocumentNumber(this.getDocumentNumber());
        v.setVersion(this.getVersion());
        return v;
    }

    private String documentNumber;

    public String getDocumentNumber()
    {
        return this.documentNumber;
    }

    public void setDocumentNumber(String documentNumber)
    {
        this.documentNumber = documentNumber;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }


    @Override
    public boolean equals(Object obj)
    {
        if (obj == this) {
            return true;
        }
        if (obj == null || obj.getClass() != PhysicalInventoryStateEventIdDto.class) {
            return false;
        }

        PhysicalInventoryStateEventIdDto other = (PhysicalInventoryStateEventIdDto)obj;
        return true 
            && (getDocumentNumber() == other.getDocumentNumber() || (getDocumentNumber() != null && getDocumentNumber().equals(other.getDocumentNumber())))
            && (getVersion() == other.getVersion() || (getVersion() != null && getVersion().equals(other.getVersion())))
            ;

    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.getDocumentNumber() != null) {
            hash += 13 * this.getDocumentNumber().hashCode();
        }
        if (this.getVersion() != null) {
            hash += 13 * this.getVersion().hashCode();
        }
        return hash;
    }

}
