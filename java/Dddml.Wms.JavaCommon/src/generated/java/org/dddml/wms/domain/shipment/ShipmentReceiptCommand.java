package org.dddml.wms.domain.shipment;

import java.util.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.Command;
import org.dddml.wms.specialization.DomainError;

public interface ShipmentReceiptCommand extends Command
{
    String getReceiptSeqId();

    void setReceiptSeqId(String receiptSeqId);

    String getShipmentId();

    void setShipmentId(String shipmentId);

    interface CreateOrMergePatchShipmentReceipt extends ShipmentReceiptCommand
    {
        String getProductId();

        void setProductId(String productId);

        String getAttributeSetInstanceId();

        void setAttributeSetInstanceId(String attributeSetInstanceId);

        String getLocatorId();

        void setLocatorId(String locatorId);

        String getShipmentItemSeqId();

        void setShipmentItemSeqId(String shipmentItemSeqId);

        String getShipmentPackageSeqId();

        void setShipmentPackageSeqId(String shipmentPackageSeqId);

        String getOrderId();

        void setOrderId(String orderId);

        String getOrderItemSeqId();

        void setOrderItemSeqId(String orderItemSeqId);

        String getReturnId();

        void setReturnId(String returnId);

        String getReturnItemSeqId();

        void setReturnItemSeqId(String returnItemSeqId);

        String getRejectionReasonId();

        void setRejectionReasonId(String rejectionReasonId);

        String getDamageReasonId();

        void setDamageReasonId(String damageReasonId);

        String getReceivedBy();

        void setReceivedBy(String receivedBy);

        java.sql.Timestamp getDatetimeReceived();

        void setDatetimeReceived(java.sql.Timestamp datetimeReceived);

        String getItemDescription();

        void setItemDescription(String itemDescription);

        java.math.BigDecimal getAcceptedQuantity();

        void setAcceptedQuantity(java.math.BigDecimal acceptedQuantity);

        java.math.BigDecimal getRejectedQuantity();

        void setRejectedQuantity(java.math.BigDecimal rejectedQuantity);

        java.math.BigDecimal getDamagedQuantity();

        void setDamagedQuantity(java.math.BigDecimal damagedQuantity);

        Boolean getActive();

        void setActive(Boolean active);

        Set<String> getDamageStatusIds();

        void setDamageStatusIds(Set<String> damageStatusIds);

    }

    interface CreateShipmentReceipt extends CreateOrMergePatchShipmentReceipt
    {
        CreateShipmentReceiptImageCommands getShipmentReceiptImages();

        ShipmentReceiptImageCommand.CreateShipmentReceiptImage newCreateShipmentReceiptImage();

    }

    interface MergePatchShipmentReceipt extends CreateOrMergePatchShipmentReceipt
    {
        Boolean getIsPropertyProductIdRemoved();

        void setIsPropertyProductIdRemoved(Boolean removed);

        Boolean getIsPropertyAttributeSetInstanceIdRemoved();

        void setIsPropertyAttributeSetInstanceIdRemoved(Boolean removed);

        Boolean getIsPropertyLocatorIdRemoved();

        void setIsPropertyLocatorIdRemoved(Boolean removed);

        Boolean getIsPropertyShipmentItemSeqIdRemoved();

        void setIsPropertyShipmentItemSeqIdRemoved(Boolean removed);

        Boolean getIsPropertyShipmentPackageSeqIdRemoved();

        void setIsPropertyShipmentPackageSeqIdRemoved(Boolean removed);

        Boolean getIsPropertyOrderIdRemoved();

        void setIsPropertyOrderIdRemoved(Boolean removed);

        Boolean getIsPropertyOrderItemSeqIdRemoved();

        void setIsPropertyOrderItemSeqIdRemoved(Boolean removed);

        Boolean getIsPropertyReturnIdRemoved();

        void setIsPropertyReturnIdRemoved(Boolean removed);

        Boolean getIsPropertyReturnItemSeqIdRemoved();

        void setIsPropertyReturnItemSeqIdRemoved(Boolean removed);

        Boolean getIsPropertyRejectionReasonIdRemoved();

        void setIsPropertyRejectionReasonIdRemoved(Boolean removed);

        Boolean getIsPropertyDamageStatusIdsRemoved();

        void setIsPropertyDamageStatusIdsRemoved(Boolean removed);

        Boolean getIsPropertyDamageReasonIdRemoved();

        void setIsPropertyDamageReasonIdRemoved(Boolean removed);

        Boolean getIsPropertyReceivedByRemoved();

        void setIsPropertyReceivedByRemoved(Boolean removed);

        Boolean getIsPropertyDatetimeReceivedRemoved();

        void setIsPropertyDatetimeReceivedRemoved(Boolean removed);

        Boolean getIsPropertyItemDescriptionRemoved();

        void setIsPropertyItemDescriptionRemoved(Boolean removed);

        Boolean getIsPropertyAcceptedQuantityRemoved();

        void setIsPropertyAcceptedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyRejectedQuantityRemoved();

        void setIsPropertyRejectedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyDamagedQuantityRemoved();

        void setIsPropertyDamagedQuantityRemoved(Boolean removed);

        Boolean getIsPropertyActiveRemoved();

        void setIsPropertyActiveRemoved(Boolean removed);

        ShipmentReceiptImageCommands getShipmentReceiptImageCommands();

        ShipmentReceiptImageCommand.CreateShipmentReceiptImage newCreateShipmentReceiptImage();

        ShipmentReceiptImageCommand.MergePatchShipmentReceiptImage newMergePatchShipmentReceiptImage();

        ShipmentReceiptImageCommand.RemoveShipmentReceiptImage newRemoveShipmentReceiptImage();

    }

	interface RemoveShipmentReceipt extends ShipmentReceiptCommand
	{
	}

    interface CreateShipmentReceiptImageCommands extends Iterable<ShipmentReceiptImageCommand.CreateShipmentReceiptImage>
    {
        void add(ShipmentReceiptImageCommand.CreateShipmentReceiptImage c);

        void remove(ShipmentReceiptImageCommand.CreateShipmentReceiptImage c);

        void clear();
    }

    interface ShipmentReceiptImageCommands extends Iterable<ShipmentReceiptImageCommand>
    {
        void add(ShipmentReceiptImageCommand c);

        void remove(ShipmentReceiptImageCommand c);

        void clear();
    }

}

