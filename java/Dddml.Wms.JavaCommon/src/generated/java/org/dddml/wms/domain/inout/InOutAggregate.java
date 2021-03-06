package org.dddml.wms.domain.inout;

import java.util.List;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.domain.Command;

public interface InOutAggregate
{
    InOutState getState();

    List<Event> getChanges();

    void create(InOutCommand.CreateInOut c);

    void mergePatch(InOutCommand.MergePatchInOut c);

    void complete(Long version, String commandId, String requesterId);

    void close(Long version, String commandId, String requesterId);

    void _void(Long version, String commandId, String requesterId);

    void reverse(Long version, String commandId, String requesterId);

    void addLine(String lineNumber, String locatorId, String productId, java.util.Map<String, Object> attributeSetInstance, Iterable<String> damageStatusIds, String description, String quantityUomId, BigDecimal movementQuantity, Long version, String commandId, String requesterId);

    void _import(String documentTypeId, String description, String orderId, Date dateOrdered, String movementTypeId, Date movementDate, String warehouseId, String POReference, String shipperId, Iterable<ImportingInOutLine> inOutLines, Long version, String commandId, String requesterId);

    void documentAction(String value, Long version, String commandId, String requesterId);

    void throwOnInvalidStateTransition(Command c);
}

