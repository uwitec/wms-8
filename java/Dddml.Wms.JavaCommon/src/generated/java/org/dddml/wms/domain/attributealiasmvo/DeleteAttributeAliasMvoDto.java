package org.dddml.wms.domain.attributealiasmvo;


public class DeleteAttributeAliasMvoDto extends AbstractAttributeAliasMvoCommandDto
{

    public DeleteAttributeAliasMvoDto() {
        this.commandType = COMMAND_TYPE_DELETE;
    }

    @Override
    public String getCommandType() {
        return COMMAND_TYPE_DELETE;
    }

    public AttributeAliasMvoCommand.DeleteAttributeAliasMvo toDeleteAttributeAliasMvo()
    {
        AbstractAttributeAliasMvoCommand.SimpleDeleteAttributeAliasMvo command = new AbstractAttributeAliasMvoCommand.SimpleDeleteAttributeAliasMvo();
        ((AbstractAttributeAliasMvoCommandDto)this).copyTo(command);
        return command;
    }
}

