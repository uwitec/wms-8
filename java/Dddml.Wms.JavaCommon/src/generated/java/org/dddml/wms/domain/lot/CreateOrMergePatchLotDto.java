package org.dddml.wms.domain.lot;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchLotDto extends AbstractLotCommandDto
{
    /**
     * Quantity
     */
    private java.math.BigDecimal quantity;

    public java.math.BigDecimal getQuantity()
    {
        return this.quantity;
    }

    public void setQuantity(java.math.BigDecimal quantity)
    {
        this.quantity = quantity;
    }

    /**
     * Expiration Date
     */
    private java.sql.Timestamp expirationDate;

    public java.sql.Timestamp getExpirationDate()
    {
        return this.expirationDate;
    }

    public void setExpirationDate(java.sql.Timestamp expirationDate)
    {
        this.expirationDate = expirationDate;
    }

    /**
     * Active
     */
    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Boolean isPropertyQuantityRemoved;

    public Boolean getIsPropertyQuantityRemoved()
    {
        return this.isPropertyQuantityRemoved;
    }

    public void setIsPropertyQuantityRemoved(Boolean removed)
    {
        this.isPropertyQuantityRemoved = removed;
    }

    private Boolean isPropertyExpirationDateRemoved;

    public Boolean getIsPropertyExpirationDateRemoved()
    {
        return this.isPropertyExpirationDateRemoved;
    }

    public void setIsPropertyExpirationDateRemoved(Boolean removed)
    {
        this.isPropertyExpirationDateRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved()
    {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed)
    {
        this.isPropertyActiveRemoved = removed;
    }

    public void copyTo(AbstractLotCommand.AbstractCreateOrMergePatchLot command)
    {
        ((AbstractLotCommandDto) this).copyTo(command);
        command.setQuantity(this.getQuantity());
        command.setExpirationDate(this.getExpirationDate());
        command.setActive(this.getActive());
    }

    public LotCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractLotCommand.SimpleCreateLot command = new AbstractLotCommand.SimpleCreateLot();
            copyTo((AbstractLotCommand.AbstractCreateLot) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractLotCommand.SimpleMergePatchLot command = new AbstractLotCommand.SimpleMergePatchLot();
            copyTo((AbstractLotCommand.SimpleMergePatchLot) command);
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractLotCommand.AbstractCreateLot command)
    {
        copyTo((AbstractLotCommand.AbstractCreateOrMergePatchLot) command);
    }

    public void copyTo(AbstractLotCommand.AbstractMergePatchLot command)
    {
        copyTo((AbstractLotCommand.AbstractCreateOrMergePatchLot) command);
        command.setIsPropertyQuantityRemoved(this.getIsPropertyQuantityRemoved());
        command.setIsPropertyExpirationDateRemoved(this.getIsPropertyExpirationDateRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateLotDto extends CreateOrMergePatchLotDto
    {
        public CreateLotDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public LotCommand.CreateLot toCreateLot()
        {
            return (LotCommand.CreateLot) toCommand();
        }

    }

    public static class MergePatchLotDto extends CreateOrMergePatchLotDto
    {
        public MergePatchLotDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public LotCommand.MergePatchLot toMergePatchLot()
        {
            return (LotCommand.MergePatchLot) toCommand();
        }

    }

}

