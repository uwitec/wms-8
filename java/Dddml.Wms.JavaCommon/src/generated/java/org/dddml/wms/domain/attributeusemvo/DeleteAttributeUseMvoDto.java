package org.dddml.wms.domain.attributeusemvo;


public class DeleteAttributeUseMvoDto extends AbstractAttributeUseMvoCommandDto
{

    public DeleteAttributeUseMvoDto() {
        this.commandType = COMMAND_TYPE_DELETE;
    }

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

    public AttributeUseMvoCommand.DeleteAttributeUseMvo toDeleteAttributeUseMvo()
    {
        AbstractAttributeUseMvoCommand.SimpleDeleteAttributeUseMvo command = new AbstractAttributeUseMvoCommand.SimpleDeleteAttributeUseMvo();
        ((AbstractAttributeUseMvoCommandDto)this).copyTo(command);
        return command;
    }
}

