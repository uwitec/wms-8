package org.dddml.wms.domain.shipmentpackagecontentmvo;

import org.dddml.wms.domain.shipmentpackage.*;
import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchShipmentPackageContentMvoDto extends AbstractShipmentPackageContentMvoCommandDto
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
     * Sub Product Id
     */
    private String subProductId;

    public String getSubProductId()
    {
        return this.subProductId;
    }

    public void setSubProductId(String subProductId)
    {
        this.subProductId = subProductId;
    }

    /**
     * Sub Product Quantity
     */
    private java.math.BigDecimal subProductQuantity;

    public java.math.BigDecimal getSubProductQuantity()
    {
        return this.subProductQuantity;
    }

    public void setSubProductQuantity(java.math.BigDecimal subProductQuantity)
    {
        this.subProductQuantity = subProductQuantity;
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

    /**
     * Shipment Package Shipment Box Type Id
     */
    private String shipmentPackageShipmentBoxTypeId;

    public String getShipmentPackageShipmentBoxTypeId()
    {
        return this.shipmentPackageShipmentBoxTypeId;
    }

    public void setShipmentPackageShipmentBoxTypeId(String shipmentPackageShipmentBoxTypeId)
    {
        this.shipmentPackageShipmentBoxTypeId = shipmentPackageShipmentBoxTypeId;
    }

    /**
     * Shipment Package Date Created
     */
    private java.sql.Timestamp shipmentPackageDateCreated;

    public java.sql.Timestamp getShipmentPackageDateCreated()
    {
        return this.shipmentPackageDateCreated;
    }

    public void setShipmentPackageDateCreated(java.sql.Timestamp shipmentPackageDateCreated)
    {
        this.shipmentPackageDateCreated = shipmentPackageDateCreated;
    }

    /**
     * This field store the length of package; if a shipmentBoxTypeId is specified then this overrides the dimension specified there; this field is meant to be used when there is no applicable ShipmentBoxType
     */
    private java.math.BigDecimal shipmentPackageBoxLength;

    public java.math.BigDecimal getShipmentPackageBoxLength()
    {
        return this.shipmentPackageBoxLength;
    }

    public void setShipmentPackageBoxLength(java.math.BigDecimal shipmentPackageBoxLength)
    {
        this.shipmentPackageBoxLength = shipmentPackageBoxLength;
    }

    /**
     * This field store the height of package; if a shipmentBoxTypeId is specified then this overrides the dimension specified there; this field is meant to be used when there is no applicable ShipmentBoxType
     */
    private java.math.BigDecimal shipmentPackageBoxHeight;

    public java.math.BigDecimal getShipmentPackageBoxHeight()
    {
        return this.shipmentPackageBoxHeight;
    }

    public void setShipmentPackageBoxHeight(java.math.BigDecimal shipmentPackageBoxHeight)
    {
        this.shipmentPackageBoxHeight = shipmentPackageBoxHeight;
    }

    /**
     * This field store the width of package; if a shipmentBoxTypeId is specified then this overrides the dimension specified there; this field is meant to be used when there is no applicable ShipmentBoxType
     */
    private java.math.BigDecimal shipmentPackageBoxWidth;

    public java.math.BigDecimal getShipmentPackageBoxWidth()
    {
        return this.shipmentPackageBoxWidth;
    }

    public void setShipmentPackageBoxWidth(java.math.BigDecimal shipmentPackageBoxWidth)
    {
        this.shipmentPackageBoxWidth = shipmentPackageBoxWidth;
    }

    /**
     * This field store the unit of measurement of dimension (length, width and height)
     */
    private String shipmentPackageDimensionUomId;

    public String getShipmentPackageDimensionUomId()
    {
        return this.shipmentPackageDimensionUomId;
    }

    public void setShipmentPackageDimensionUomId(String shipmentPackageDimensionUomId)
    {
        this.shipmentPackageDimensionUomId = shipmentPackageDimensionUomId;
    }

    /**
     * Shipment Package Weight
     */
    private java.math.BigDecimal shipmentPackageWeight;

    public java.math.BigDecimal getShipmentPackageWeight()
    {
        return this.shipmentPackageWeight;
    }

    public void setShipmentPackageWeight(java.math.BigDecimal shipmentPackageWeight)
    {
        this.shipmentPackageWeight = shipmentPackageWeight;
    }

    /**
     * Shipment Package Weight Uom Id
     */
    private String shipmentPackageWeightUomId;

    public String getShipmentPackageWeightUomId()
    {
        return this.shipmentPackageWeightUomId;
    }

    public void setShipmentPackageWeightUomId(String shipmentPackageWeightUomId)
    {
        this.shipmentPackageWeightUomId = shipmentPackageWeightUomId;
    }

    /**
     * Shipment Package Insured Value
     */
    private java.math.BigDecimal shipmentPackageInsuredValue;

    public java.math.BigDecimal getShipmentPackageInsuredValue()
    {
        return this.shipmentPackageInsuredValue;
    }

    public void setShipmentPackageInsuredValue(java.math.BigDecimal shipmentPackageInsuredValue)
    {
        this.shipmentPackageInsuredValue = shipmentPackageInsuredValue;
    }

    /**
     * Shipment Package Created By
     */
    private String shipmentPackageCreatedBy;

    public String getShipmentPackageCreatedBy()
    {
        return this.shipmentPackageCreatedBy;
    }

    public void setShipmentPackageCreatedBy(String shipmentPackageCreatedBy)
    {
        this.shipmentPackageCreatedBy = shipmentPackageCreatedBy;
    }

    /**
     * Shipment Package Created At
     */
    private Date shipmentPackageCreatedAt;

    public Date getShipmentPackageCreatedAt()
    {
        return this.shipmentPackageCreatedAt;
    }

    public void setShipmentPackageCreatedAt(Date shipmentPackageCreatedAt)
    {
        this.shipmentPackageCreatedAt = shipmentPackageCreatedAt;
    }

    /**
     * Shipment Package Updated By
     */
    private String shipmentPackageUpdatedBy;

    public String getShipmentPackageUpdatedBy()
    {
        return this.shipmentPackageUpdatedBy;
    }

    public void setShipmentPackageUpdatedBy(String shipmentPackageUpdatedBy)
    {
        this.shipmentPackageUpdatedBy = shipmentPackageUpdatedBy;
    }

    /**
     * Shipment Package Updated At
     */
    private Date shipmentPackageUpdatedAt;

    public Date getShipmentPackageUpdatedAt()
    {
        return this.shipmentPackageUpdatedAt;
    }

    public void setShipmentPackageUpdatedAt(Date shipmentPackageUpdatedAt)
    {
        this.shipmentPackageUpdatedAt = shipmentPackageUpdatedAt;
    }

    /**
     * Shipment Package Active
     */
    private Boolean shipmentPackageActive;

    public Boolean getShipmentPackageActive()
    {
        return this.shipmentPackageActive;
    }

    public void setShipmentPackageActive(Boolean shipmentPackageActive)
    {
        this.shipmentPackageActive = shipmentPackageActive;
    }

    /**
     * Shipment Package Deleted
     */
    private Boolean shipmentPackageDeleted;

    public Boolean getShipmentPackageDeleted()
    {
        return this.shipmentPackageDeleted;
    }

    public void setShipmentPackageDeleted(Boolean shipmentPackageDeleted)
    {
        this.shipmentPackageDeleted = shipmentPackageDeleted;
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

    private Boolean isPropertySubProductIdRemoved;

    public Boolean getIsPropertySubProductIdRemoved()
    {
        return this.isPropertySubProductIdRemoved;
    }

    public void setIsPropertySubProductIdRemoved(Boolean removed)
    {
        this.isPropertySubProductIdRemoved = removed;
    }

    private Boolean isPropertySubProductQuantityRemoved;

    public Boolean getIsPropertySubProductQuantityRemoved()
    {
        return this.isPropertySubProductQuantityRemoved;
    }

    public void setIsPropertySubProductQuantityRemoved(Boolean removed)
    {
        this.isPropertySubProductQuantityRemoved = removed;
    }

    private Boolean isPropertyVersionRemoved;

    public Boolean getIsPropertyVersionRemoved()
    {
        return this.isPropertyVersionRemoved;
    }

    public void setIsPropertyVersionRemoved(Boolean removed)
    {
        this.isPropertyVersionRemoved = removed;
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

    private Boolean isPropertyShipmentPackageShipmentBoxTypeIdRemoved;

    public Boolean getIsPropertyShipmentPackageShipmentBoxTypeIdRemoved()
    {
        return this.isPropertyShipmentPackageShipmentBoxTypeIdRemoved;
    }

    public void setIsPropertyShipmentPackageShipmentBoxTypeIdRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageShipmentBoxTypeIdRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageDateCreatedRemoved;

    public Boolean getIsPropertyShipmentPackageDateCreatedRemoved()
    {
        return this.isPropertyShipmentPackageDateCreatedRemoved;
    }

    public void setIsPropertyShipmentPackageDateCreatedRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageDateCreatedRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageBoxLengthRemoved;

    public Boolean getIsPropertyShipmentPackageBoxLengthRemoved()
    {
        return this.isPropertyShipmentPackageBoxLengthRemoved;
    }

    public void setIsPropertyShipmentPackageBoxLengthRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageBoxLengthRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageBoxHeightRemoved;

    public Boolean getIsPropertyShipmentPackageBoxHeightRemoved()
    {
        return this.isPropertyShipmentPackageBoxHeightRemoved;
    }

    public void setIsPropertyShipmentPackageBoxHeightRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageBoxHeightRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageBoxWidthRemoved;

    public Boolean getIsPropertyShipmentPackageBoxWidthRemoved()
    {
        return this.isPropertyShipmentPackageBoxWidthRemoved;
    }

    public void setIsPropertyShipmentPackageBoxWidthRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageBoxWidthRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageDimensionUomIdRemoved;

    public Boolean getIsPropertyShipmentPackageDimensionUomIdRemoved()
    {
        return this.isPropertyShipmentPackageDimensionUomIdRemoved;
    }

    public void setIsPropertyShipmentPackageDimensionUomIdRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageDimensionUomIdRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageWeightRemoved;

    public Boolean getIsPropertyShipmentPackageWeightRemoved()
    {
        return this.isPropertyShipmentPackageWeightRemoved;
    }

    public void setIsPropertyShipmentPackageWeightRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageWeightRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageWeightUomIdRemoved;

    public Boolean getIsPropertyShipmentPackageWeightUomIdRemoved()
    {
        return this.isPropertyShipmentPackageWeightUomIdRemoved;
    }

    public void setIsPropertyShipmentPackageWeightUomIdRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageWeightUomIdRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageInsuredValueRemoved;

    public Boolean getIsPropertyShipmentPackageInsuredValueRemoved()
    {
        return this.isPropertyShipmentPackageInsuredValueRemoved;
    }

    public void setIsPropertyShipmentPackageInsuredValueRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageInsuredValueRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageCreatedByRemoved;

    public Boolean getIsPropertyShipmentPackageCreatedByRemoved()
    {
        return this.isPropertyShipmentPackageCreatedByRemoved;
    }

    public void setIsPropertyShipmentPackageCreatedByRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageCreatedByRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageCreatedAtRemoved;

    public Boolean getIsPropertyShipmentPackageCreatedAtRemoved()
    {
        return this.isPropertyShipmentPackageCreatedAtRemoved;
    }

    public void setIsPropertyShipmentPackageCreatedAtRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageCreatedAtRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageUpdatedByRemoved;

    public Boolean getIsPropertyShipmentPackageUpdatedByRemoved()
    {
        return this.isPropertyShipmentPackageUpdatedByRemoved;
    }

    public void setIsPropertyShipmentPackageUpdatedByRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageUpdatedByRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageUpdatedAtRemoved;

    public Boolean getIsPropertyShipmentPackageUpdatedAtRemoved()
    {
        return this.isPropertyShipmentPackageUpdatedAtRemoved;
    }

    public void setIsPropertyShipmentPackageUpdatedAtRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageUpdatedAtRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageActiveRemoved;

    public Boolean getIsPropertyShipmentPackageActiveRemoved()
    {
        return this.isPropertyShipmentPackageActiveRemoved;
    }

    public void setIsPropertyShipmentPackageActiveRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageActiveRemoved = removed;
    }

    private Boolean isPropertyShipmentPackageDeletedRemoved;

    public Boolean getIsPropertyShipmentPackageDeletedRemoved()
    {
        return this.isPropertyShipmentPackageDeletedRemoved;
    }

    public void setIsPropertyShipmentPackageDeletedRemoved(Boolean removed)
    {
        this.isPropertyShipmentPackageDeletedRemoved = removed;
    }

    public void copyTo(AbstractShipmentPackageContentMvoCommand.AbstractCreateOrMergePatchShipmentPackageContentMvo command)
    {
        ((AbstractShipmentPackageContentMvoCommandDto) this).copyTo(command);
        command.setQuantity(this.getQuantity());
        command.setSubProductId(this.getSubProductId());
        command.setSubProductQuantity(this.getSubProductQuantity());
        command.setVersion(this.getVersion());
        command.setActive(this.getActive());
        command.setShipmentPackageShipmentBoxTypeId(this.getShipmentPackageShipmentBoxTypeId());
        command.setShipmentPackageDateCreated(this.getShipmentPackageDateCreated());
        command.setShipmentPackageBoxLength(this.getShipmentPackageBoxLength());
        command.setShipmentPackageBoxHeight(this.getShipmentPackageBoxHeight());
        command.setShipmentPackageBoxWidth(this.getShipmentPackageBoxWidth());
        command.setShipmentPackageDimensionUomId(this.getShipmentPackageDimensionUomId());
        command.setShipmentPackageWeight(this.getShipmentPackageWeight());
        command.setShipmentPackageWeightUomId(this.getShipmentPackageWeightUomId());
        command.setShipmentPackageInsuredValue(this.getShipmentPackageInsuredValue());
        command.setShipmentPackageCreatedBy(this.getShipmentPackageCreatedBy());
        command.setShipmentPackageCreatedAt(this.getShipmentPackageCreatedAt());
        command.setShipmentPackageUpdatedBy(this.getShipmentPackageUpdatedBy());
        command.setShipmentPackageUpdatedAt(this.getShipmentPackageUpdatedAt());
        command.setShipmentPackageActive(this.getShipmentPackageActive());
        command.setShipmentPackageDeleted(this.getShipmentPackageDeleted());
    }

    public ShipmentPackageContentMvoCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractShipmentPackageContentMvoCommand.SimpleCreateShipmentPackageContentMvo command = new AbstractShipmentPackageContentMvoCommand.SimpleCreateShipmentPackageContentMvo();
            copyTo((AbstractShipmentPackageContentMvoCommand.AbstractCreateShipmentPackageContentMvo) command);
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractShipmentPackageContentMvoCommand.SimpleMergePatchShipmentPackageContentMvo command = new AbstractShipmentPackageContentMvoCommand.SimpleMergePatchShipmentPackageContentMvo();
            copyTo((AbstractShipmentPackageContentMvoCommand.SimpleMergePatchShipmentPackageContentMvo) command);
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractShipmentPackageContentMvoCommand.AbstractCreateShipmentPackageContentMvo command)
    {
        copyTo((AbstractShipmentPackageContentMvoCommand.AbstractCreateOrMergePatchShipmentPackageContentMvo) command);
    }

    public void copyTo(AbstractShipmentPackageContentMvoCommand.AbstractMergePatchShipmentPackageContentMvo command)
    {
        copyTo((AbstractShipmentPackageContentMvoCommand.AbstractCreateOrMergePatchShipmentPackageContentMvo) command);
        command.setIsPropertyQuantityRemoved(this.getIsPropertyQuantityRemoved());
        command.setIsPropertySubProductIdRemoved(this.getIsPropertySubProductIdRemoved());
        command.setIsPropertySubProductQuantityRemoved(this.getIsPropertySubProductQuantityRemoved());
        command.setIsPropertyVersionRemoved(this.getIsPropertyVersionRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
        command.setIsPropertyShipmentPackageShipmentBoxTypeIdRemoved(this.getIsPropertyShipmentPackageShipmentBoxTypeIdRemoved());
        command.setIsPropertyShipmentPackageDateCreatedRemoved(this.getIsPropertyShipmentPackageDateCreatedRemoved());
        command.setIsPropertyShipmentPackageBoxLengthRemoved(this.getIsPropertyShipmentPackageBoxLengthRemoved());
        command.setIsPropertyShipmentPackageBoxHeightRemoved(this.getIsPropertyShipmentPackageBoxHeightRemoved());
        command.setIsPropertyShipmentPackageBoxWidthRemoved(this.getIsPropertyShipmentPackageBoxWidthRemoved());
        command.setIsPropertyShipmentPackageDimensionUomIdRemoved(this.getIsPropertyShipmentPackageDimensionUomIdRemoved());
        command.setIsPropertyShipmentPackageWeightRemoved(this.getIsPropertyShipmentPackageWeightRemoved());
        command.setIsPropertyShipmentPackageWeightUomIdRemoved(this.getIsPropertyShipmentPackageWeightUomIdRemoved());
        command.setIsPropertyShipmentPackageInsuredValueRemoved(this.getIsPropertyShipmentPackageInsuredValueRemoved());
        command.setIsPropertyShipmentPackageCreatedByRemoved(this.getIsPropertyShipmentPackageCreatedByRemoved());
        command.setIsPropertyShipmentPackageCreatedAtRemoved(this.getIsPropertyShipmentPackageCreatedAtRemoved());
        command.setIsPropertyShipmentPackageUpdatedByRemoved(this.getIsPropertyShipmentPackageUpdatedByRemoved());
        command.setIsPropertyShipmentPackageUpdatedAtRemoved(this.getIsPropertyShipmentPackageUpdatedAtRemoved());
        command.setIsPropertyShipmentPackageActiveRemoved(this.getIsPropertyShipmentPackageActiveRemoved());
        command.setIsPropertyShipmentPackageDeletedRemoved(this.getIsPropertyShipmentPackageDeletedRemoved());
    }

    public static class CreateShipmentPackageContentMvoDto extends CreateOrMergePatchShipmentPackageContentMvoDto
    {
        public CreateShipmentPackageContentMvoDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public ShipmentPackageContentMvoCommand.CreateShipmentPackageContentMvo toCreateShipmentPackageContentMvo()
        {
            return (ShipmentPackageContentMvoCommand.CreateShipmentPackageContentMvo) toCommand();
        }

    }

    public static class MergePatchShipmentPackageContentMvoDto extends CreateOrMergePatchShipmentPackageContentMvoDto
    {
        public MergePatchShipmentPackageContentMvoDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public ShipmentPackageContentMvoCommand.MergePatchShipmentPackageContentMvo toMergePatchShipmentPackageContentMvo()
        {
            return (ShipmentPackageContentMvoCommand.MergePatchShipmentPackageContentMvo) toCommand();
        }

    }

}

