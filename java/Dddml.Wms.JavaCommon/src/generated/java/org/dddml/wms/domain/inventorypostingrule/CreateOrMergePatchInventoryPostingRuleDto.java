package org.dddml.wms.domain.inventorypostingrule;

import org.dddml.wms.domain.inventoryitem.*;
import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchInventoryPostingRuleDto extends AbstractInventoryPostingRuleCommandDto
{
    /**
     * Trigger Inventory Item Id
     */
    private InventoryItemId triggerInventoryItemId;

    public InventoryItemId getTriggerInventoryItemId()
    {
        return this.triggerInventoryItemId;
    }

    public void setTriggerInventoryItemId(InventoryItemId triggerInventoryItemId)
    {
        this.triggerInventoryItemId = triggerInventoryItemId;
    }

    /**
     * Output Inventory Item Id
     */
    private InventoryItemId outputInventoryItemId;

    public InventoryItemId getOutputInventoryItemId()
    {
        return this.outputInventoryItemId;
    }

    public void setOutputInventoryItemId(InventoryItemId outputInventoryItemId)
    {
        this.outputInventoryItemId = outputInventoryItemId;
    }

    /**
     * Trigger Account Name
     */
    private String triggerAccountName;

    public String getTriggerAccountName()
    {
        return this.triggerAccountName;
    }

    public void setTriggerAccountName(String triggerAccountName)
    {
        this.triggerAccountName = triggerAccountName;
    }

    /**
     * Output Account Name
     */
    private String outputAccountName;

    public String getOutputAccountName()
    {
        return this.outputAccountName;
    }

    public void setOutputAccountName(String outputAccountName)
    {
        this.outputAccountName = outputAccountName;
    }

    /**
     * Is Output Negated
     */
    private Boolean isOutputNegated;

    public Boolean getIsOutputNegated()
    {
        return this.isOutputNegated;
    }

    public void setIsOutputNegated(Boolean isOutputNegated)
    {
        this.isOutputNegated = isOutputNegated;
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

    private Boolean isPropertyTriggerInventoryItemIdRemoved;

    public Boolean getIsPropertyTriggerInventoryItemIdRemoved()
    {
        return this.isPropertyTriggerInventoryItemIdRemoved;
    }

    public void setIsPropertyTriggerInventoryItemIdRemoved(Boolean removed)
    {
        this.isPropertyTriggerInventoryItemIdRemoved = removed;
    }

    private Boolean isPropertyOutputInventoryItemIdRemoved;

    public Boolean getIsPropertyOutputInventoryItemIdRemoved()
    {
        return this.isPropertyOutputInventoryItemIdRemoved;
    }

    public void setIsPropertyOutputInventoryItemIdRemoved(Boolean removed)
    {
        this.isPropertyOutputInventoryItemIdRemoved = removed;
    }

    private Boolean isPropertyTriggerAccountNameRemoved;

    public Boolean getIsPropertyTriggerAccountNameRemoved()
    {
        return this.isPropertyTriggerAccountNameRemoved;
    }

    public void setIsPropertyTriggerAccountNameRemoved(Boolean removed)
    {
        this.isPropertyTriggerAccountNameRemoved = removed;
    }

    private Boolean isPropertyOutputAccountNameRemoved;

    public Boolean getIsPropertyOutputAccountNameRemoved()
    {
        return this.isPropertyOutputAccountNameRemoved;
    }

    public void setIsPropertyOutputAccountNameRemoved(Boolean removed)
    {
        this.isPropertyOutputAccountNameRemoved = removed;
    }

    private Boolean isPropertyIsOutputNegatedRemoved;

    public Boolean getIsPropertyIsOutputNegatedRemoved()
    {
        return this.isPropertyIsOutputNegatedRemoved;
    }

    public void setIsPropertyIsOutputNegatedRemoved(Boolean removed)
    {
        this.isPropertyIsOutputNegatedRemoved = removed;
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

    public void copyTo(AbstractInventoryPostingRuleCommand.AbstractCreateOrMergePatchInventoryPostingRule command)
    {
        ((AbstractInventoryPostingRuleCommandDto) this).copyTo(command);
        command.setTriggerInventoryItemId(this.getTriggerInventoryItemId());
        command.setOutputInventoryItemId(this.getOutputInventoryItemId());
        command.setTriggerAccountName(this.getTriggerAccountName());
        command.setOutputAccountName(this.getOutputAccountName());
        command.setIsOutputNegated(this.getIsOutputNegated());
        command.setActive(this.getActive());
    }

    public InventoryPostingRuleCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractInventoryPostingRuleCommand.SimpleCreateInventoryPostingRule command = new AbstractInventoryPostingRuleCommand.SimpleCreateInventoryPostingRule();
            copyTo((AbstractInventoryPostingRuleCommand.AbstractCreateInventoryPostingRule) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractInventoryPostingRuleCommand.SimpleMergePatchInventoryPostingRule command = new AbstractInventoryPostingRuleCommand.SimpleMergePatchInventoryPostingRule();
            copyTo((AbstractInventoryPostingRuleCommand.SimpleMergePatchInventoryPostingRule) command);
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractInventoryPostingRuleCommand.AbstractCreateInventoryPostingRule command)
    {
        copyTo((AbstractInventoryPostingRuleCommand.AbstractCreateOrMergePatchInventoryPostingRule) command);
    }

    public void copyTo(AbstractInventoryPostingRuleCommand.AbstractMergePatchInventoryPostingRule command)
    {
        copyTo((AbstractInventoryPostingRuleCommand.AbstractCreateOrMergePatchInventoryPostingRule) command);
        command.setIsPropertyTriggerInventoryItemIdRemoved(this.getIsPropertyTriggerInventoryItemIdRemoved());
        command.setIsPropertyOutputInventoryItemIdRemoved(this.getIsPropertyOutputInventoryItemIdRemoved());
        command.setIsPropertyTriggerAccountNameRemoved(this.getIsPropertyTriggerAccountNameRemoved());
        command.setIsPropertyOutputAccountNameRemoved(this.getIsPropertyOutputAccountNameRemoved());
        command.setIsPropertyIsOutputNegatedRemoved(this.getIsPropertyIsOutputNegatedRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateInventoryPostingRuleDto extends CreateOrMergePatchInventoryPostingRuleDto
    {
        public CreateInventoryPostingRuleDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public InventoryPostingRuleCommand.CreateInventoryPostingRule toCreateInventoryPostingRule()
        {
            return (InventoryPostingRuleCommand.CreateInventoryPostingRule) toCommand();
        }

    }

    public static class MergePatchInventoryPostingRuleDto extends CreateOrMergePatchInventoryPostingRuleDto
    {
        public MergePatchInventoryPostingRuleDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public InventoryPostingRuleCommand.MergePatchInventoryPostingRule toMergePatchInventoryPostingRule()
        {
            return (InventoryPostingRuleCommand.MergePatchInventoryPostingRule) toCommand();
        }

    }

}

