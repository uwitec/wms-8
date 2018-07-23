package org.dddml.wms.domain.attributevaluemvo;


public class DeleteAttributeValueMvoDto extends AbstractAttributeValueMvoCommandDto
{

    public DeleteAttributeValueMvoDto() {
        this.commandType = COMMAND_TYPE_DELETE;
    }

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

    public AttributeValueMvoCommand.DeleteAttributeValueMvo toDeleteAttributeValueMvo()
    {
        AbstractAttributeValueMvoCommand.SimpleDeleteAttributeValueMvo command = new AbstractAttributeValueMvoCommand.SimpleDeleteAttributeValueMvo();
        ((AbstractAttributeValueMvoCommandDto)this).copyTo(command);
        return command;
    }
}

