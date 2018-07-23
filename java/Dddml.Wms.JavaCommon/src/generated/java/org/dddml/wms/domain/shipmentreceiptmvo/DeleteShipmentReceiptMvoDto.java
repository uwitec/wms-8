package org.dddml.wms.domain.shipmentreceiptmvo;


public class DeleteShipmentReceiptMvoDto extends AbstractShipmentReceiptMvoCommandDto
{

    public DeleteShipmentReceiptMvoDto() {
        this.commandType = COMMAND_TYPE_DELETE;
    }

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

    public ShipmentReceiptMvoCommand.DeleteShipmentReceiptMvo toDeleteShipmentReceiptMvo()
    {
        AbstractShipmentReceiptMvoCommand.SimpleDeleteShipmentReceiptMvo command = new AbstractShipmentReceiptMvoCommand.SimpleDeleteShipmentReceiptMvo();
        ((AbstractShipmentReceiptMvoCommandDto)this).copyTo(command);
        return command;
    }
}

