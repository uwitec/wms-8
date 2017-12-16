package org.dddml.wms.domain.shipment;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractStateEvent;

public class ShipmentStateEventDto extends AbstractStateEvent
{

    private ShipmentStateEventIdDto stateEventId;

    ShipmentStateEventIdDto getStateEventId() {
        if (stateEventId == null) { stateEventId = new ShipmentStateEventIdDto(); }
        return this.stateEventId;
    }

    void setStateEventId(ShipmentStateEventIdDto stateEventId) {
        this.stateEventId = stateEventId;
    }

    public String getShipmentId() {
        return getStateEventId().getShipmentId();
    }

    public void setShipmentId(String shipmentId) {
        getStateEventId().setShipmentId(shipmentId);
    }

    public Long getVersion() {
        return getStateEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getStateEventId().setVersion(version);
    }

    private String shipmentTypeId;

    public String getShipmentTypeId() {
        return this.shipmentTypeId;
    }

    public void setShipmentTypeId(String shipmentTypeId) {
        this.shipmentTypeId = shipmentTypeId;
    }

    private String statusId;

    public String getStatusId() {
        return this.statusId;
    }

    public void setStatusId(String statusId) {
        this.statusId = statusId;
    }

    private String primaryOrderId;

    public String getPrimaryOrderId() {
        return this.primaryOrderId;
    }

    public void setPrimaryOrderId(String primaryOrderId) {
        this.primaryOrderId = primaryOrderId;
    }

    private String primaryReturnId;

    public String getPrimaryReturnId() {
        return this.primaryReturnId;
    }

    public void setPrimaryReturnId(String primaryReturnId) {
        this.primaryReturnId = primaryReturnId;
    }

    private String picklistBinId;

    public String getPicklistBinId() {
        return this.picklistBinId;
    }

    public void setPicklistBinId(String picklistBinId) {
        this.picklistBinId = picklistBinId;
    }

    private java.sql.Timestamp estimatedReadyDate;

    public java.sql.Timestamp getEstimatedReadyDate() {
        return this.estimatedReadyDate;
    }

    public void setEstimatedReadyDate(java.sql.Timestamp estimatedReadyDate) {
        this.estimatedReadyDate = estimatedReadyDate;
    }

    private java.sql.Timestamp estimatedShipDate;

    public java.sql.Timestamp getEstimatedShipDate() {
        return this.estimatedShipDate;
    }

    public void setEstimatedShipDate(java.sql.Timestamp estimatedShipDate) {
        this.estimatedShipDate = estimatedShipDate;
    }

    private String estimatedShipWorkEffId;

    public String getEstimatedShipWorkEffId() {
        return this.estimatedShipWorkEffId;
    }

    public void setEstimatedShipWorkEffId(String estimatedShipWorkEffId) {
        this.estimatedShipWorkEffId = estimatedShipWorkEffId;
    }

    private java.sql.Timestamp estimatedArrivalDate;

    public java.sql.Timestamp getEstimatedArrivalDate() {
        return this.estimatedArrivalDate;
    }

    public void setEstimatedArrivalDate(java.sql.Timestamp estimatedArrivalDate) {
        this.estimatedArrivalDate = estimatedArrivalDate;
    }

    private String estimatedArrivalWorkEffId;

    public String getEstimatedArrivalWorkEffId() {
        return this.estimatedArrivalWorkEffId;
    }

    public void setEstimatedArrivalWorkEffId(String estimatedArrivalWorkEffId) {
        this.estimatedArrivalWorkEffId = estimatedArrivalWorkEffId;
    }

    private java.sql.Timestamp latestCancelDate;

    public java.sql.Timestamp getLatestCancelDate() {
        return this.latestCancelDate;
    }

    public void setLatestCancelDate(java.sql.Timestamp latestCancelDate) {
        this.latestCancelDate = latestCancelDate;
    }

    private java.math.BigDecimal estimatedShipCost;

    public java.math.BigDecimal getEstimatedShipCost() {
        return this.estimatedShipCost;
    }

    public void setEstimatedShipCost(java.math.BigDecimal estimatedShipCost) {
        this.estimatedShipCost = estimatedShipCost;
    }

    private String currencyUomId;

    public String getCurrencyUomId() {
        return this.currencyUomId;
    }

    public void setCurrencyUomId(String currencyUomId) {
        this.currencyUomId = currencyUomId;
    }

    private String handlingInstructions;

    public String getHandlingInstructions() {
        return this.handlingInstructions;
    }

    public void setHandlingInstructions(String handlingInstructions) {
        this.handlingInstructions = handlingInstructions;
    }

    private String originFacilityId;

    public String getOriginFacilityId() {
        return this.originFacilityId;
    }

    public void setOriginFacilityId(String originFacilityId) {
        this.originFacilityId = originFacilityId;
    }

    private String destinationFacilityId;

    public String getDestinationFacilityId() {
        return this.destinationFacilityId;
    }

    public void setDestinationFacilityId(String destinationFacilityId) {
        this.destinationFacilityId = destinationFacilityId;
    }

    private String originContactMechId;

    public String getOriginContactMechId() {
        return this.originContactMechId;
    }

    public void setOriginContactMechId(String originContactMechId) {
        this.originContactMechId = originContactMechId;
    }

    private String originTelecomNumberId;

    public String getOriginTelecomNumberId() {
        return this.originTelecomNumberId;
    }

    public void setOriginTelecomNumberId(String originTelecomNumberId) {
        this.originTelecomNumberId = originTelecomNumberId;
    }

    private String destinationContactMechId;

    public String getDestinationContactMechId() {
        return this.destinationContactMechId;
    }

    public void setDestinationContactMechId(String destinationContactMechId) {
        this.destinationContactMechId = destinationContactMechId;
    }

    private String destinationTelecomNumberId;

    public String getDestinationTelecomNumberId() {
        return this.destinationTelecomNumberId;
    }

    public void setDestinationTelecomNumberId(String destinationTelecomNumberId) {
        this.destinationTelecomNumberId = destinationTelecomNumberId;
    }

    private String partyIdTo;

    public String getPartyIdTo() {
        return this.partyIdTo;
    }

    public void setPartyIdTo(String partyIdTo) {
        this.partyIdTo = partyIdTo;
    }

    private String partyIdFrom;

    public String getPartyIdFrom() {
        return this.partyIdFrom;
    }

    public void setPartyIdFrom(String partyIdFrom) {
        this.partyIdFrom = partyIdFrom;
    }

    private java.math.BigDecimal additionalShippingCharge;

    public java.math.BigDecimal getAdditionalShippingCharge() {
        return this.additionalShippingCharge;
    }

    public void setAdditionalShippingCharge(java.math.BigDecimal additionalShippingCharge) {
        this.additionalShippingCharge = additionalShippingCharge;
    }

    private String addtlShippingChargeDesc;

    public String getAddtlShippingChargeDesc() {
        return this.addtlShippingChargeDesc;
    }

    public void setAddtlShippingChargeDesc(String addtlShippingChargeDesc) {
        this.addtlShippingChargeDesc = addtlShippingChargeDesc;
    }

    private Boolean active;

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    private String createdBy;

    public String getCreatedBy() {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy) {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt() {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    private Boolean isPropertyShipmentTypeIdRemoved;

    public Boolean getIsPropertyShipmentTypeIdRemoved() {
        return this.isPropertyShipmentTypeIdRemoved;
    }

    public void setIsPropertyShipmentTypeIdRemoved(Boolean removed) {
        this.isPropertyShipmentTypeIdRemoved = removed;
    }

    private Boolean isPropertyStatusIdRemoved;

    public Boolean getIsPropertyStatusIdRemoved() {
        return this.isPropertyStatusIdRemoved;
    }

    public void setIsPropertyStatusIdRemoved(Boolean removed) {
        this.isPropertyStatusIdRemoved = removed;
    }

    private Boolean isPropertyPrimaryOrderIdRemoved;

    public Boolean getIsPropertyPrimaryOrderIdRemoved() {
        return this.isPropertyPrimaryOrderIdRemoved;
    }

    public void setIsPropertyPrimaryOrderIdRemoved(Boolean removed) {
        this.isPropertyPrimaryOrderIdRemoved = removed;
    }

    private Boolean isPropertyPrimaryReturnIdRemoved;

    public Boolean getIsPropertyPrimaryReturnIdRemoved() {
        return this.isPropertyPrimaryReturnIdRemoved;
    }

    public void setIsPropertyPrimaryReturnIdRemoved(Boolean removed) {
        this.isPropertyPrimaryReturnIdRemoved = removed;
    }

    private Boolean isPropertyPicklistBinIdRemoved;

    public Boolean getIsPropertyPicklistBinIdRemoved() {
        return this.isPropertyPicklistBinIdRemoved;
    }

    public void setIsPropertyPicklistBinIdRemoved(Boolean removed) {
        this.isPropertyPicklistBinIdRemoved = removed;
    }

    private Boolean isPropertyEstimatedReadyDateRemoved;

    public Boolean getIsPropertyEstimatedReadyDateRemoved() {
        return this.isPropertyEstimatedReadyDateRemoved;
    }

    public void setIsPropertyEstimatedReadyDateRemoved(Boolean removed) {
        this.isPropertyEstimatedReadyDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedShipDateRemoved;

    public Boolean getIsPropertyEstimatedShipDateRemoved() {
        return this.isPropertyEstimatedShipDateRemoved;
    }

    public void setIsPropertyEstimatedShipDateRemoved(Boolean removed) {
        this.isPropertyEstimatedShipDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedShipWorkEffIdRemoved;

    public Boolean getIsPropertyEstimatedShipWorkEffIdRemoved() {
        return this.isPropertyEstimatedShipWorkEffIdRemoved;
    }

    public void setIsPropertyEstimatedShipWorkEffIdRemoved(Boolean removed) {
        this.isPropertyEstimatedShipWorkEffIdRemoved = removed;
    }

    private Boolean isPropertyEstimatedArrivalDateRemoved;

    public Boolean getIsPropertyEstimatedArrivalDateRemoved() {
        return this.isPropertyEstimatedArrivalDateRemoved;
    }

    public void setIsPropertyEstimatedArrivalDateRemoved(Boolean removed) {
        this.isPropertyEstimatedArrivalDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedArrivalWorkEffIdRemoved;

    public Boolean getIsPropertyEstimatedArrivalWorkEffIdRemoved() {
        return this.isPropertyEstimatedArrivalWorkEffIdRemoved;
    }

    public void setIsPropertyEstimatedArrivalWorkEffIdRemoved(Boolean removed) {
        this.isPropertyEstimatedArrivalWorkEffIdRemoved = removed;
    }

    private Boolean isPropertyLatestCancelDateRemoved;

    public Boolean getIsPropertyLatestCancelDateRemoved() {
        return this.isPropertyLatestCancelDateRemoved;
    }

    public void setIsPropertyLatestCancelDateRemoved(Boolean removed) {
        this.isPropertyLatestCancelDateRemoved = removed;
    }

    private Boolean isPropertyEstimatedShipCostRemoved;

    public Boolean getIsPropertyEstimatedShipCostRemoved() {
        return this.isPropertyEstimatedShipCostRemoved;
    }

    public void setIsPropertyEstimatedShipCostRemoved(Boolean removed) {
        this.isPropertyEstimatedShipCostRemoved = removed;
    }

    private Boolean isPropertyCurrencyUomIdRemoved;

    public Boolean getIsPropertyCurrencyUomIdRemoved() {
        return this.isPropertyCurrencyUomIdRemoved;
    }

    public void setIsPropertyCurrencyUomIdRemoved(Boolean removed) {
        this.isPropertyCurrencyUomIdRemoved = removed;
    }

    private Boolean isPropertyHandlingInstructionsRemoved;

    public Boolean getIsPropertyHandlingInstructionsRemoved() {
        return this.isPropertyHandlingInstructionsRemoved;
    }

    public void setIsPropertyHandlingInstructionsRemoved(Boolean removed) {
        this.isPropertyHandlingInstructionsRemoved = removed;
    }

    private Boolean isPropertyOriginFacilityIdRemoved;

    public Boolean getIsPropertyOriginFacilityIdRemoved() {
        return this.isPropertyOriginFacilityIdRemoved;
    }

    public void setIsPropertyOriginFacilityIdRemoved(Boolean removed) {
        this.isPropertyOriginFacilityIdRemoved = removed;
    }

    private Boolean isPropertyDestinationFacilityIdRemoved;

    public Boolean getIsPropertyDestinationFacilityIdRemoved() {
        return this.isPropertyDestinationFacilityIdRemoved;
    }

    public void setIsPropertyDestinationFacilityIdRemoved(Boolean removed) {
        this.isPropertyDestinationFacilityIdRemoved = removed;
    }

    private Boolean isPropertyOriginContactMechIdRemoved;

    public Boolean getIsPropertyOriginContactMechIdRemoved() {
        return this.isPropertyOriginContactMechIdRemoved;
    }

    public void setIsPropertyOriginContactMechIdRemoved(Boolean removed) {
        this.isPropertyOriginContactMechIdRemoved = removed;
    }

    private Boolean isPropertyOriginTelecomNumberIdRemoved;

    public Boolean getIsPropertyOriginTelecomNumberIdRemoved() {
        return this.isPropertyOriginTelecomNumberIdRemoved;
    }

    public void setIsPropertyOriginTelecomNumberIdRemoved(Boolean removed) {
        this.isPropertyOriginTelecomNumberIdRemoved = removed;
    }

    private Boolean isPropertyDestinationContactMechIdRemoved;

    public Boolean getIsPropertyDestinationContactMechIdRemoved() {
        return this.isPropertyDestinationContactMechIdRemoved;
    }

    public void setIsPropertyDestinationContactMechIdRemoved(Boolean removed) {
        this.isPropertyDestinationContactMechIdRemoved = removed;
    }

    private Boolean isPropertyDestinationTelecomNumberIdRemoved;

    public Boolean getIsPropertyDestinationTelecomNumberIdRemoved() {
        return this.isPropertyDestinationTelecomNumberIdRemoved;
    }

    public void setIsPropertyDestinationTelecomNumberIdRemoved(Boolean removed) {
        this.isPropertyDestinationTelecomNumberIdRemoved = removed;
    }

    private Boolean isPropertyPartyIdToRemoved;

    public Boolean getIsPropertyPartyIdToRemoved() {
        return this.isPropertyPartyIdToRemoved;
    }

    public void setIsPropertyPartyIdToRemoved(Boolean removed) {
        this.isPropertyPartyIdToRemoved = removed;
    }

    private Boolean isPropertyPartyIdFromRemoved;

    public Boolean getIsPropertyPartyIdFromRemoved() {
        return this.isPropertyPartyIdFromRemoved;
    }

    public void setIsPropertyPartyIdFromRemoved(Boolean removed) {
        this.isPropertyPartyIdFromRemoved = removed;
    }

    private Boolean isPropertyAdditionalShippingChargeRemoved;

    public Boolean getIsPropertyAdditionalShippingChargeRemoved() {
        return this.isPropertyAdditionalShippingChargeRemoved;
    }

    public void setIsPropertyAdditionalShippingChargeRemoved(Boolean removed) {
        this.isPropertyAdditionalShippingChargeRemoved = removed;
    }

    private Boolean isPropertyAddtlShippingChargeDescRemoved;

    public Boolean getIsPropertyAddtlShippingChargeDescRemoved() {
        return this.isPropertyAddtlShippingChargeDescRemoved;
    }

    public void setIsPropertyAddtlShippingChargeDescRemoved(Boolean removed) {
        this.isPropertyAddtlShippingChargeDescRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }


	public static class ShipmentStateCreatedDto extends ShipmentStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class ShipmentStateMergePatchedDto extends ShipmentStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class ShipmentStateDeletedDto extends ShipmentStateEventDto
	{
        @Override
        public String getStateEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

