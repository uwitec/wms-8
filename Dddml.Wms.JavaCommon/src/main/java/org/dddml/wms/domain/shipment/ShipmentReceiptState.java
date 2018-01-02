package org.dddml.wms.domain.shipment;

import java.util.Set;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.shipment.ShipmentReceiptStateEvent.*;

public interface ShipmentReceiptState
{
    Long VERSION_ZERO = 0L;

    Long VERSION_NULL = VERSION_ZERO - 1;

    ShipmentReceiptId getShipmentReceiptId();

    void setShipmentReceiptId(ShipmentReceiptId shipmentReceiptId);

    String getReceiptSeqId();

    void setReceiptSeqId(String receiptSeqId);

    String getProductId();

    void setProductId(String productId);

    String getShipmentItemSeqId();

    void setShipmentItemSeqId(String shipmentItemSeqId);

    String getRejectionId();

    void setRejectionId(String rejectionId);

    String getItemDescription();

    void setItemDescription(String itemDescription);

    java.math.BigDecimal getAcceptedQuantity();

    void setAcceptedQuantity(java.math.BigDecimal acceptedQuantity);

    java.math.BigDecimal getRejectedQuantity();

    void setRejectedQuantity(java.math.BigDecimal rejectedQuantity);

    Long getVersion();

    void setVersion(Long version);

    String getCreatedBy();

    void setCreatedBy(String createdBy);

    Date getCreatedAt();

    void setCreatedAt(Date createdAt);

    String getUpdatedBy();

    void setUpdatedBy(String updatedBy);

    Date getUpdatedAt();

    void setUpdatedAt(Date updatedAt);

    Boolean getActive();

    void setActive(Boolean active);

    String getShipmentId();

    void setShipmentId(String shipmentId);


    boolean isStateUnsaved();

    boolean getForReapplying();


    void mutate(Event e);

    void when(ShipmentReceiptStateEvent.ShipmentReceiptStateCreated e);

    void when(ShipmentReceiptStateEvent.ShipmentReceiptStateMergePatched e);

    
}

