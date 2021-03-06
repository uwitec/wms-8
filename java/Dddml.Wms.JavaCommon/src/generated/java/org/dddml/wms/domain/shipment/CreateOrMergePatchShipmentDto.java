package org.dddml.wms.domain.shipment;

import java.util.Date;
import org.dddml.wms.domain.*;

public class CreateOrMergePatchShipmentDto extends AbstractShipmentCommandDto
{
    /**
     * Shipment Type Id
     */
    private String shipmentTypeId;

    public String getShipmentTypeId()
    {
        return this.shipmentTypeId;
    }

    public void setShipmentTypeId(String shipmentTypeId)
    {
        this.shipmentTypeId = shipmentTypeId;
    }

    /**
     * Status Id
     */
    private String statusId;

    public String getStatusId()
    {
        return this.statusId;
    }

    public void setStatusId(String statusId)
    {
        this.statusId = statusId;
    }

    /**
     * Primary Order Id
     */
    private String primaryOrderId;

    public String getPrimaryOrderId()
    {
        return this.primaryOrderId;
    }

    public void setPrimaryOrderId(String primaryOrderId)
    {
        this.primaryOrderId = primaryOrderId;
    }

    /**
     * Primary Return Id
     */
    private String primaryReturnId;

    public String getPrimaryReturnId()
    {
        return this.primaryReturnId;
    }

    public void setPrimaryReturnId(String primaryReturnId)
    {
        this.primaryReturnId = primaryReturnId;
    }

    /**
     * Primary Ship Group Seq Id
     */
    private String primaryShipGroupSeqId;

    public String getPrimaryShipGroupSeqId()
    {
        return this.primaryShipGroupSeqId;
    }

    public void setPrimaryShipGroupSeqId(String primaryShipGroupSeqId)
    {
        this.primaryShipGroupSeqId = primaryShipGroupSeqId;
    }

    /**
     * Picklist Bin Id
     */
    private String picklistBinId;

    public String getPicklistBinId()
    {
        return this.picklistBinId;
    }

    public void setPicklistBinId(String picklistBinId)
    {
        this.picklistBinId = picklistBinId;
    }

    /**
     * Bill of lading
     */
    private String bolNumber;

    public String getBolNumber()
    {
        return this.bolNumber;
    }

    public void setBolNumber(String bolNumber)
    {
        this.bolNumber = bolNumber;
    }

    /**
     * Seal Number
     */
    private String sealNumber;

    public String getSealNumber()
    {
        return this.sealNumber;
    }

    public void setSealNumber(String sealNumber)
    {
        this.sealNumber = sealNumber;
    }

    /**
     * Vehicle Id
     */
    private String vehicleId;

    public String getVehicleId()
    {
        return this.vehicleId;
    }

    public void setVehicleId(String vehicleId)
    {
        this.vehicleId = vehicleId;
    }

    /**
     * External Order Number
     */
    private String externalOrderNumber;

    public String getExternalOrderNumber()
    {
        return this.externalOrderNumber;
    }

    public void setExternalOrderNumber(String externalOrderNumber)
    {
        this.externalOrderNumber = externalOrderNumber;
    }

    /**
     * Carrier
     */
    private String carrier;

    public String getCarrier()
    {
        return this.carrier;
    }

    public void setCarrier(String carrier)
    {
        this.carrier = carrier;
    }

    /**
     * Date Shipped
     */
    private java.sql.Timestamp dateShipped;

    public java.sql.Timestamp getDateShipped()
    {
        return this.dateShipped;
    }

    public void setDateShipped(java.sql.Timestamp dateShipped)
    {
        this.dateShipped = dateShipped;
    }

    /**
     * Estimated Ready Date
     */
    private java.sql.Timestamp estimatedReadyDate;

    public java.sql.Timestamp getEstimatedReadyDate()
    {
        return this.estimatedReadyDate;
    }

    public void setEstimatedReadyDate(java.sql.Timestamp estimatedReadyDate)
    {
        this.estimatedReadyDate = estimatedReadyDate;
    }

    /**
     * Estimated Ship Date
     */
    private java.sql.Timestamp estimatedShipDate;

    public java.sql.Timestamp getEstimatedShipDate()
    {
        return this.estimatedShipDate;
    }

    public void setEstimatedShipDate(java.sql.Timestamp estimatedShipDate)
    {
        this.estimatedShipDate = estimatedShipDate;
    }

    /**
     * Estimated Ship Work Eff Id
     */
    private String estimatedShipWorkEffId;

    public String getEstimatedShipWorkEffId()
    {
        return this.estimatedShipWorkEffId;
    }

    public void setEstimatedShipWorkEffId(String estimatedShipWorkEffId)
    {
        this.estimatedShipWorkEffId = estimatedShipWorkEffId;
    }

    /**
     * Estimated Arrival Date(ETA)
     */
    private java.sql.Timestamp estimatedArrivalDate;

    public java.sql.Timestamp getEstimatedArrivalDate()
    {
        return this.estimatedArrivalDate;
    }

    public void setEstimatedArrivalDate(java.sql.Timestamp estimatedArrivalDate)
    {
        this.estimatedArrivalDate = estimatedArrivalDate;
    }

    /**
     * Estimated Arrival Work Eff Id
     */
    private String estimatedArrivalWorkEffId;

    public String getEstimatedArrivalWorkEffId()
    {
        return this.estimatedArrivalWorkEffId;
    }

    public void setEstimatedArrivalWorkEffId(String estimatedArrivalWorkEffId)
    {
        this.estimatedArrivalWorkEffId = estimatedArrivalWorkEffId;
    }

    /**
     * Latest Cancel Date
     */
    private java.sql.Timestamp latestCancelDate;

    public java.sql.Timestamp getLatestCancelDate()
    {
        return this.latestCancelDate;
    }

    public void setLatestCancelDate(java.sql.Timestamp latestCancelDate)
    {
        this.latestCancelDate = latestCancelDate;
    }

    /**
     * Estimated Ship Cost
     */
    private java.math.BigDecimal estimatedShipCost;

    public java.math.BigDecimal getEstimatedShipCost()
    {
        return this.estimatedShipCost;
    }

    public void setEstimatedShipCost(java.math.BigDecimal estimatedShipCost)
    {
        this.estimatedShipCost = estimatedShipCost;
    }

    /**
     * Currency Uom Id
     */
    private String currencyUomId;

    public String getCurrencyUomId()
    {
        return this.currencyUomId;
    }

    public void setCurrencyUomId(String currencyUomId)
    {
        this.currencyUomId = currencyUomId;
    }

    /**
     * Handling Instructions
     */
    private String handlingInstructions;

    public String getHandlingInstructions()
    {
        return this.handlingInstructions;
    }

    public void setHandlingInstructions(String handlingInstructions)
    {
        this.handlingInstructions = handlingInstructions;
    }

    /**
     * Origin Facility Id
     */
    private String originFacilityId;

    public String getOriginFacilityId()
    {
        return this.originFacilityId;
    }

    public void setOriginFacilityId(String originFacilityId)
    {
        this.originFacilityId = originFacilityId;
    }

    /**
     * Destination Facility Id
     */
    private String destinationFacilityId;

    public String getDestinationFacilityId()
    {
        return this.destinationFacilityId;
    }

    public void setDestinationFacilityId(String destinationFacilityId)
    {
        this.destinationFacilityId = destinationFacilityId;
    }

    /**
     * Origin Contact Mech Id
     */
    private String originContactMechId;

    public String getOriginContactMechId()
    {
        return this.originContactMechId;
    }

    public void setOriginContactMechId(String originContactMechId)
    {
        this.originContactMechId = originContactMechId;
    }

    /**
     * Origin Telecom Number Id
     */
    private String originTelecomNumberId;

    public String getOriginTelecomNumberId()
    {
        return this.originTelecomNumberId;
    }

    public void setOriginTelecomNumberId(String originTelecomNumberId)
    {
        this.originTelecomNumberId = originTelecomNumberId;
    }

    /**
     * Destination Contact Mech Id
     */
    private String destinationContactMechId;

    public String getDestinationContactMechId()
    {
        return this.destinationContactMechId;
    }

    public void setDestinationContactMechId(String destinationContactMechId)
    {
        this.destinationContactMechId = destinationContactMechId;
    }

    /**
     * Destination Telecom Number Id
     */
    private String destinationTelecomNumberId;

    public String getDestinationTelecomNumberId()
    {
        return this.destinationTelecomNumberId;
    }

    public void setDestinationTelecomNumberId(String destinationTelecomNumberId)
    {
        this.destinationTelecomNumberId = destinationTelecomNumberId;
    }

    /**
     * Party Id To
     */
    private String partyIdTo;

    public String getPartyIdTo()
    {
        return this.partyIdTo;
    }

    public void setPartyIdTo(String partyIdTo)
    {
        this.partyIdTo = partyIdTo;
    }

    /**
     * Party Id From
     */
    private String partyIdFrom;

    public String getPartyIdFrom()
    {
        return this.partyIdFrom;
    }

    public void setPartyIdFrom(String partyIdFrom)
    {
        this.partyIdFrom = partyIdFrom;
    }

    /**
     * Additional Shipping Charge
     */
    private java.math.BigDecimal additionalShippingCharge;

    public java.math.BigDecimal getAdditionalShippingCharge()
    {
        return this.additionalShippingCharge;
    }

    public void setAdditionalShippingCharge(java.math.BigDecimal additionalShippingCharge)
    {
        this.additionalShippingCharge = additionalShippingCharge;
    }

    /**
     * Addtl Shipping Charge Desc
     */
    private String addtlShippingChargeDesc;

    public String getAddtlShippingChargeDesc()
    {
        return this.addtlShippingChargeDesc;
    }

    public void setAddtlShippingChargeDesc(String addtlShippingChargeDesc)
    {
        this.addtlShippingChargeDesc = addtlShippingChargeDesc;
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

    private CreateOrMergePatchShipmentImageDto[] shipmentImages;

    public CreateOrMergePatchShipmentImageDto[] getShipmentImages()
    {
        return this.shipmentImages;
    }

    public void setShipmentImages(CreateOrMergePatchShipmentImageDto[] shipmentImages)
    {
        this.shipmentImages = shipmentImages;
    }

    private CreateOrMergePatchShipmentItemDto[] shipmentItems;

    public CreateOrMergePatchShipmentItemDto[] getShipmentItems()
    {
        return this.shipmentItems;
    }

    public void setShipmentItems(CreateOrMergePatchShipmentItemDto[] shipmentItems)
    {
        this.shipmentItems = shipmentItems;
    }

    private CreateOrMergePatchShipmentReceiptDto[] shipmentReceipts;

    public CreateOrMergePatchShipmentReceiptDto[] getShipmentReceipts()
    {
        return this.shipmentReceipts;
    }

    public void setShipmentReceipts(CreateOrMergePatchShipmentReceiptDto[] shipmentReceipts)
    {
        this.shipmentReceipts = shipmentReceipts;
    }

    private CreateOrMergePatchItemIssuanceDto[] itemIssuances;

    public CreateOrMergePatchItemIssuanceDto[] getItemIssuances()
    {
        return this.itemIssuances;
    }

    public void setItemIssuances(CreateOrMergePatchItemIssuanceDto[] itemIssuances)
    {
        this.itemIssuances = itemIssuances;
    }

    private Boolean isPropertyShipmentTypeIdRemoved;

    public Boolean getIsPropertyShipmentTypeIdRemoved()
    {
        return this.isPropertyShipmentTypeIdRemoved;
    }

    public void setIsPropertyShipmentTypeIdRemoved(Boolean removed)
    {
        this.isPropertyShipmentTypeIdRemoved = removed;
    }

    private Boolean isPropertyStatusIdRemoved;

    public Boolean getIsPropertyStatusIdRemoved()
    {
        return this.isPropertyStatusIdRemoved;
    }

    public void setIsPropertyStatusIdRemoved(Boolean removed)
    {
        this.isPropertyStatusIdRemoved = removed;
    }

    private Boolean isPropertyPrimaryOrderIdRemoved;

    public Boolean getIsPropertyPrimaryOrderIdRemoved()
    {
        return this.isPropertyPrimaryOrderIdRemoved;
    }

    public void setIsPropertyPrimaryOrderIdRemoved(Boolean removed)
    {
        this.isPropertyPrimaryOrderIdRemoved = removed;
    }

    private Boolean isPropertyPrimaryReturnIdRemoved;

    public Boolean getIsPropertyPrimaryReturnIdRemoved()
    {
        return this.isPropertyPrimaryReturnIdRemoved;
    }

    public void setIsPropertyPrimaryReturnIdRemoved(Boolean removed)
    {
        this.isPropertyPrimaryReturnIdRemoved = removed;
    }

    private Boolean isPropertyPrimaryShipGroupSeqIdRemoved;

    public Boolean getIsPropertyPrimaryShipGroupSeqIdRemoved()
    {
        return this.isPropertyPrimaryShipGroupSeqIdRemoved;
    }

    public void setIsPropertyPrimaryShipGroupSeqIdRemoved(Boolean removed)
    {
        this.isPropertyPrimaryShipGroupSeqIdRemoved = removed;
    }

    private Boolean isPropertyPicklistBinIdRemoved;

    public Boolean getIsPropertyPicklistBinIdRemoved()
    {
        return this.isPropertyPicklistBinIdRemoved;
    }

    public void setIsPropertyPicklistBinIdRemoved(Boolean removed)
    {
        this.isPropertyPicklistBinIdRemoved = removed;
    }

    private Boolean isPropertyBolNumberRemoved;

    public Boolean getIsPropertyBolNumberRemoved()
    {
        return this.isPropertyBolNumberRemoved;
    }

    public void setIsPropertyBolNumberRemoved(Boolean removed)
    {
        this.isPropertyBolNumberRemoved = removed;
    }

    private Boolean isPropertySealNumberRemoved;

    public Boolean getIsPropertySealNumberRemoved()
    {
        return this.isPropertySealNumberRemoved;
    }

    public void setIsPropertySealNumberRemoved(Boolean removed)
    {
        this.isPropertySealNumberRemoved = removed;
    }

    private Boolean isPropertyVehicleIdRemoved;

    public Boolean getIsPropertyVehicleIdRemoved()
    {
        return this.isPropertyVehicleIdRemoved;
    }

    public void setIsPropertyVehicleIdRemoved(Boolean removed)
    {
        this.isPropertyVehicleIdRemoved = removed;
    }

    private Boolean isPropertyExternalOrderNumberRemoved;

    public Boolean getIsPropertyExternalOrderNumberRemoved()
    {
        return this.isPropertyExternalOrderNumberRemoved;
    }

    public void setIsPropertyExternalOrderNumberRemoved(Boolean removed)
    {
        this.isPropertyExternalOrderNumberRemoved = removed;
    }

    private Boolean isPropertyCarrierRemoved;

    public Boolean getIsPropertyCarrierRemoved()
    {
        return this.isPropertyCarrierRemoved;
    }

    public void setIsPropertyCarrierRemoved(Boolean removed)
    {
        this.isPropertyCarrierRemoved = removed;
    }

    private Boolean isPropertyDateShippedRemoved;

    public Boolean getIsPropertyDateShippedRemoved()
    {
        return this.isPropertyDateShippedRemoved;
    }

    public void setIsPropertyDateShippedRemoved(Boolean removed)
    {
        this.isPropertyDateShippedRemoved = removed;
    }

    private Boolean isPropertyEstimatedReadyDateRemoved;

    public Boolean getIsPropertyEstimatedReadyDateRemoved()
    {
        return this.isPropertyEstimatedReadyDateRemoved;
    }

    public void setIsPropertyEstimatedReadyDateRemoved(Boolean removed)
    {
        this.isPropertyEstimatedReadyDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedShipDateRemoved;

    public Boolean getIsPropertyEstimatedShipDateRemoved()
    {
        return this.isPropertyEstimatedShipDateRemoved;
    }

    public void setIsPropertyEstimatedShipDateRemoved(Boolean removed)
    {
        this.isPropertyEstimatedShipDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedShipWorkEffIdRemoved;

    public Boolean getIsPropertyEstimatedShipWorkEffIdRemoved()
    {
        return this.isPropertyEstimatedShipWorkEffIdRemoved;
    }

    public void setIsPropertyEstimatedShipWorkEffIdRemoved(Boolean removed)
    {
        this.isPropertyEstimatedShipWorkEffIdRemoved = removed;
    }

    private Boolean isPropertyEstimatedArrivalDateRemoved;

    public Boolean getIsPropertyEstimatedArrivalDateRemoved()
    {
        return this.isPropertyEstimatedArrivalDateRemoved;
    }

    public void setIsPropertyEstimatedArrivalDateRemoved(Boolean removed)
    {
        this.isPropertyEstimatedArrivalDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedArrivalWorkEffIdRemoved;

    public Boolean getIsPropertyEstimatedArrivalWorkEffIdRemoved()
    {
        return this.isPropertyEstimatedArrivalWorkEffIdRemoved;
    }

    public void setIsPropertyEstimatedArrivalWorkEffIdRemoved(Boolean removed)
    {
        this.isPropertyEstimatedArrivalWorkEffIdRemoved = removed;
    }

    private Boolean isPropertyLatestCancelDateRemoved;

    public Boolean getIsPropertyLatestCancelDateRemoved()
    {
        return this.isPropertyLatestCancelDateRemoved;
    }

    public void setIsPropertyLatestCancelDateRemoved(Boolean removed)
    {
        this.isPropertyLatestCancelDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedShipCostRemoved;

    public Boolean getIsPropertyEstimatedShipCostRemoved()
    {
        return this.isPropertyEstimatedShipCostRemoved;
    }

    public void setIsPropertyEstimatedShipCostRemoved(Boolean removed)
    {
        this.isPropertyEstimatedShipCostRemoved = removed;
    }

    private Boolean isPropertyCurrencyUomIdRemoved;

    public Boolean getIsPropertyCurrencyUomIdRemoved()
    {
        return this.isPropertyCurrencyUomIdRemoved;
    }

    public void setIsPropertyCurrencyUomIdRemoved(Boolean removed)
    {
        this.isPropertyCurrencyUomIdRemoved = removed;
    }

    private Boolean isPropertyHandlingInstructionsRemoved;

    public Boolean getIsPropertyHandlingInstructionsRemoved()
    {
        return this.isPropertyHandlingInstructionsRemoved;
    }

    public void setIsPropertyHandlingInstructionsRemoved(Boolean removed)
    {
        this.isPropertyHandlingInstructionsRemoved = removed;
    }

    private Boolean isPropertyOriginFacilityIdRemoved;

    public Boolean getIsPropertyOriginFacilityIdRemoved()
    {
        return this.isPropertyOriginFacilityIdRemoved;
    }

    public void setIsPropertyOriginFacilityIdRemoved(Boolean removed)
    {
        this.isPropertyOriginFacilityIdRemoved = removed;
    }

    private Boolean isPropertyDestinationFacilityIdRemoved;

    public Boolean getIsPropertyDestinationFacilityIdRemoved()
    {
        return this.isPropertyDestinationFacilityIdRemoved;
    }

    public void setIsPropertyDestinationFacilityIdRemoved(Boolean removed)
    {
        this.isPropertyDestinationFacilityIdRemoved = removed;
    }

    private Boolean isPropertyOriginContactMechIdRemoved;

    public Boolean getIsPropertyOriginContactMechIdRemoved()
    {
        return this.isPropertyOriginContactMechIdRemoved;
    }

    public void setIsPropertyOriginContactMechIdRemoved(Boolean removed)
    {
        this.isPropertyOriginContactMechIdRemoved = removed;
    }

    private Boolean isPropertyOriginTelecomNumberIdRemoved;

    public Boolean getIsPropertyOriginTelecomNumberIdRemoved()
    {
        return this.isPropertyOriginTelecomNumberIdRemoved;
    }

    public void setIsPropertyOriginTelecomNumberIdRemoved(Boolean removed)
    {
        this.isPropertyOriginTelecomNumberIdRemoved = removed;
    }

    private Boolean isPropertyDestinationContactMechIdRemoved;

    public Boolean getIsPropertyDestinationContactMechIdRemoved()
    {
        return this.isPropertyDestinationContactMechIdRemoved;
    }

    public void setIsPropertyDestinationContactMechIdRemoved(Boolean removed)
    {
        this.isPropertyDestinationContactMechIdRemoved = removed;
    }

    private Boolean isPropertyDestinationTelecomNumberIdRemoved;

    public Boolean getIsPropertyDestinationTelecomNumberIdRemoved()
    {
        return this.isPropertyDestinationTelecomNumberIdRemoved;
    }

    public void setIsPropertyDestinationTelecomNumberIdRemoved(Boolean removed)
    {
        this.isPropertyDestinationTelecomNumberIdRemoved = removed;
    }

    private Boolean isPropertyPartyIdToRemoved;

    public Boolean getIsPropertyPartyIdToRemoved()
    {
        return this.isPropertyPartyIdToRemoved;
    }

    public void setIsPropertyPartyIdToRemoved(Boolean removed)
    {
        this.isPropertyPartyIdToRemoved = removed;
    }

    private Boolean isPropertyPartyIdFromRemoved;

    public Boolean getIsPropertyPartyIdFromRemoved()
    {
        return this.isPropertyPartyIdFromRemoved;
    }

    public void setIsPropertyPartyIdFromRemoved(Boolean removed)
    {
        this.isPropertyPartyIdFromRemoved = removed;
    }

    private Boolean isPropertyAdditionalShippingChargeRemoved;

    public Boolean getIsPropertyAdditionalShippingChargeRemoved()
    {
        return this.isPropertyAdditionalShippingChargeRemoved;
    }

    public void setIsPropertyAdditionalShippingChargeRemoved(Boolean removed)
    {
        this.isPropertyAdditionalShippingChargeRemoved = removed;
    }

    private Boolean isPropertyAddtlShippingChargeDescRemoved;

    public Boolean getIsPropertyAddtlShippingChargeDescRemoved()
    {
        return this.isPropertyAddtlShippingChargeDescRemoved;
    }

    public void setIsPropertyAddtlShippingChargeDescRemoved(Boolean removed)
    {
        this.isPropertyAddtlShippingChargeDescRemoved = removed;
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

    public void copyTo(AbstractShipmentCommand.AbstractCreateOrMergePatchShipment command)
    {
        ((AbstractShipmentCommandDto) this).copyTo(command);
        command.setShipmentTypeId(this.getShipmentTypeId());
        command.setStatusId(this.getStatusId());
        command.setPrimaryOrderId(this.getPrimaryOrderId());
        command.setPrimaryReturnId(this.getPrimaryReturnId());
        command.setPrimaryShipGroupSeqId(this.getPrimaryShipGroupSeqId());
        command.setPicklistBinId(this.getPicklistBinId());
        command.setBolNumber(this.getBolNumber());
        command.setSealNumber(this.getSealNumber());
        command.setVehicleId(this.getVehicleId());
        command.setExternalOrderNumber(this.getExternalOrderNumber());
        command.setCarrier(this.getCarrier());
        command.setDateShipped(this.getDateShipped());
        command.setEstimatedReadyDate(this.getEstimatedReadyDate());
        command.setEstimatedShipDate(this.getEstimatedShipDate());
        command.setEstimatedShipWorkEffId(this.getEstimatedShipWorkEffId());
        command.setEstimatedArrivalDate(this.getEstimatedArrivalDate());
        command.setEstimatedArrivalWorkEffId(this.getEstimatedArrivalWorkEffId());
        command.setLatestCancelDate(this.getLatestCancelDate());
        command.setEstimatedShipCost(this.getEstimatedShipCost());
        command.setCurrencyUomId(this.getCurrencyUomId());
        command.setHandlingInstructions(this.getHandlingInstructions());
        command.setOriginFacilityId(this.getOriginFacilityId());
        command.setDestinationFacilityId(this.getDestinationFacilityId());
        command.setOriginContactMechId(this.getOriginContactMechId());
        command.setOriginTelecomNumberId(this.getOriginTelecomNumberId());
        command.setDestinationContactMechId(this.getDestinationContactMechId());
        command.setDestinationTelecomNumberId(this.getDestinationTelecomNumberId());
        command.setPartyIdTo(this.getPartyIdTo());
        command.setPartyIdFrom(this.getPartyIdFrom());
        command.setAdditionalShippingCharge(this.getAdditionalShippingCharge());
        command.setAddtlShippingChargeDesc(this.getAddtlShippingChargeDesc());
        command.setActive(this.getActive());
    }

    public ShipmentCommand toCommand()
    {
        if (getCommandType() == null) {
            setCommandType(COMMAND_TYPE_MERGE_PATCH);
        }
        if (COMMAND_TYPE_CREATE.equals(getCommandType())) {
            AbstractShipmentCommand.SimpleCreateShipment command = new AbstractShipmentCommand.SimpleCreateShipment();
            copyTo((AbstractShipmentCommand.AbstractCreateShipment) command);
            if (this.getShipmentImages() != null) {
                for (CreateOrMergePatchShipmentImageDto cmd : this.getShipmentImages()) {
                    command.getShipmentImages().add((ShipmentImageCommand.CreateShipmentImage) cmd.toCommand());
                }
            }
            if (this.getShipmentItems() != null) {
                for (CreateOrMergePatchShipmentItemDto cmd : this.getShipmentItems()) {
                    command.getShipmentItems().add((ShipmentItemCommand.CreateShipmentItem) cmd.toCommand());
                }
            }
            if (this.getShipmentReceipts() != null) {
                for (CreateOrMergePatchShipmentReceiptDto cmd : this.getShipmentReceipts()) {
                    command.getShipmentReceipts().add((ShipmentReceiptCommand.CreateShipmentReceipt) cmd.toCommand());
                }
            }
            if (this.getItemIssuances() != null) {
                for (CreateOrMergePatchItemIssuanceDto cmd : this.getItemIssuances()) {
                    command.getItemIssuances().add((ItemIssuanceCommand.CreateItemIssuance) cmd.toCommand());
                }
            }
            return command;
        } else if (COMMAND_TYPE_MERGE_PATCH.equals(getCommandType())) {
            AbstractShipmentCommand.SimpleMergePatchShipment command = new AbstractShipmentCommand.SimpleMergePatchShipment();
            copyTo((AbstractShipmentCommand.SimpleMergePatchShipment) command);
            if (this.getShipmentImages() != null) {
                for (CreateOrMergePatchShipmentImageDto cmd : this.getShipmentImages()) {
                    command.getShipmentImageCommands().add(cmd.toCommand());
                }
            }
            if (this.getShipmentItems() != null) {
                for (CreateOrMergePatchShipmentItemDto cmd : this.getShipmentItems()) {
                    command.getShipmentItemCommands().add(cmd.toCommand());
                }
            }
            if (this.getShipmentReceipts() != null) {
                for (CreateOrMergePatchShipmentReceiptDto cmd : this.getShipmentReceipts()) {
                    command.getShipmentReceiptCommands().add(cmd.toCommand());
                }
            }
            if (this.getItemIssuances() != null) {
                for (CreateOrMergePatchItemIssuanceDto cmd : this.getItemIssuances()) {
                    command.getItemIssuanceCommands().add(cmd.toCommand());
                }
            }
            return command;
        } 
        throw new IllegalStateException("Unknown command type:" + getCommandType());
    }

    public void copyTo(AbstractShipmentCommand.AbstractCreateShipment command)
    {
        copyTo((AbstractShipmentCommand.AbstractCreateOrMergePatchShipment) command);
    }

    public void copyTo(AbstractShipmentCommand.AbstractMergePatchShipment command)
    {
        copyTo((AbstractShipmentCommand.AbstractCreateOrMergePatchShipment) command);
        command.setIsPropertyShipmentTypeIdRemoved(this.getIsPropertyShipmentTypeIdRemoved());
        command.setIsPropertyStatusIdRemoved(this.getIsPropertyStatusIdRemoved());
        command.setIsPropertyPrimaryOrderIdRemoved(this.getIsPropertyPrimaryOrderIdRemoved());
        command.setIsPropertyPrimaryReturnIdRemoved(this.getIsPropertyPrimaryReturnIdRemoved());
        command.setIsPropertyPrimaryShipGroupSeqIdRemoved(this.getIsPropertyPrimaryShipGroupSeqIdRemoved());
        command.setIsPropertyPicklistBinIdRemoved(this.getIsPropertyPicklistBinIdRemoved());
        command.setIsPropertyBolNumberRemoved(this.getIsPropertyBolNumberRemoved());
        command.setIsPropertySealNumberRemoved(this.getIsPropertySealNumberRemoved());
        command.setIsPropertyVehicleIdRemoved(this.getIsPropertyVehicleIdRemoved());
        command.setIsPropertyExternalOrderNumberRemoved(this.getIsPropertyExternalOrderNumberRemoved());
        command.setIsPropertyCarrierRemoved(this.getIsPropertyCarrierRemoved());
        command.setIsPropertyDateShippedRemoved(this.getIsPropertyDateShippedRemoved());
        command.setIsPropertyEstimatedReadyDateRemoved(this.getIsPropertyEstimatedReadyDateRemoved());
        command.setIsPropertyEstimatedShipDateRemoved(this.getIsPropertyEstimatedShipDateRemoved());
        command.setIsPropertyEstimatedShipWorkEffIdRemoved(this.getIsPropertyEstimatedShipWorkEffIdRemoved());
        command.setIsPropertyEstimatedArrivalDateRemoved(this.getIsPropertyEstimatedArrivalDateRemoved());
        command.setIsPropertyEstimatedArrivalWorkEffIdRemoved(this.getIsPropertyEstimatedArrivalWorkEffIdRemoved());
        command.setIsPropertyLatestCancelDateRemoved(this.getIsPropertyLatestCancelDateRemoved());
        command.setIsPropertyEstimatedShipCostRemoved(this.getIsPropertyEstimatedShipCostRemoved());
        command.setIsPropertyCurrencyUomIdRemoved(this.getIsPropertyCurrencyUomIdRemoved());
        command.setIsPropertyHandlingInstructionsRemoved(this.getIsPropertyHandlingInstructionsRemoved());
        command.setIsPropertyOriginFacilityIdRemoved(this.getIsPropertyOriginFacilityIdRemoved());
        command.setIsPropertyDestinationFacilityIdRemoved(this.getIsPropertyDestinationFacilityIdRemoved());
        command.setIsPropertyOriginContactMechIdRemoved(this.getIsPropertyOriginContactMechIdRemoved());
        command.setIsPropertyOriginTelecomNumberIdRemoved(this.getIsPropertyOriginTelecomNumberIdRemoved());
        command.setIsPropertyDestinationContactMechIdRemoved(this.getIsPropertyDestinationContactMechIdRemoved());
        command.setIsPropertyDestinationTelecomNumberIdRemoved(this.getIsPropertyDestinationTelecomNumberIdRemoved());
        command.setIsPropertyPartyIdToRemoved(this.getIsPropertyPartyIdToRemoved());
        command.setIsPropertyPartyIdFromRemoved(this.getIsPropertyPartyIdFromRemoved());
        command.setIsPropertyAdditionalShippingChargeRemoved(this.getIsPropertyAdditionalShippingChargeRemoved());
        command.setIsPropertyAddtlShippingChargeDescRemoved(this.getIsPropertyAddtlShippingChargeDescRemoved());
        command.setIsPropertyActiveRemoved(this.getIsPropertyActiveRemoved());
    }

    public static class CreateShipmentDto extends CreateOrMergePatchShipmentDto
    {
        public CreateShipmentDto() {
            this.commandType = COMMAND_TYPE_CREATE;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_CREATE;
        }
        public ShipmentCommand.CreateShipment toCreateShipment()
        {
            return (ShipmentCommand.CreateShipment) toCommand();
        }

    }

    public static class MergePatchShipmentDto extends CreateOrMergePatchShipmentDto
    {
        public MergePatchShipmentDto() {
            this.commandType = COMMAND_TYPE_MERGE_PATCH;
        }

        @Override
        public String getCommandType() {
            return COMMAND_TYPE_MERGE_PATCH;
        }
        public ShipmentCommand.MergePatchShipment toMergePatchShipment()
        {
            return (ShipmentCommand.MergePatchShipment) toCommand();
        }

    }

}

