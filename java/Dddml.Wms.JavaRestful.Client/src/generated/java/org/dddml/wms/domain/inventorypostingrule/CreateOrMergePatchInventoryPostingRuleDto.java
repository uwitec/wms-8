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

    public static class CreateInventoryPostingRuleDto extends CreateOrMergePatchInventoryPostingRuleDto
    {
        public CreateInventoryPostingRuleDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
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

    }

}

