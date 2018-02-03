package org.dddml.wms.domain.shipment;

import org.dddml.wms.domain.DocumentStatusIds;
import org.dddml.wms.domain.attributeset.AttributeSetState;
import org.dddml.wms.domain.attributesetinstance.AbstractAttributeSetInstanceCommand;
import org.dddml.wms.domain.attributesetinstance.AttributeSetInstanceApplicationService;
import org.dddml.wms.domain.attributesetinstance.AttributeSetInstanceCommand;
import org.dddml.wms.domain.attributesetinstance.AttributeSetInstanceState;
import org.dddml.wms.domain.inventoryitem.InventoryItemApplicationService;
import org.dddml.wms.domain.product.ProductApplicationService;
import org.dddml.wms.domain.product.ProductState;
import org.dddml.wms.domain.service.AttributeSetService;
import org.dddml.wms.specialization.DomainError;
import org.dddml.wms.specialization.EventStore;
import org.dddml.wms.specialization.ApplicationContext;
import org.dddml.wms.specialization.IdGenerator;
import org.dddml.wms.specialization.hibernate.TableIdGenerator;
import org.springframework.transaction.annotation.Transactional;

import java.util.Map;
import java.util.Objects;

/**
 * Created by yangjiefeng on 2018/2/1.
 */
public class ShipmentApplicationServiceImpl extends AbstractShipmentApplicationService.SimpleShipmentApplicationService {

    ProductApplicationService getProductApplicationService() {
        return (ProductApplicationService) ApplicationContext.current.get("productApplicationService");
    }

    AttributeSetInstanceApplicationService getAttributeSetInstanceApplicationService() {
        return (AttributeSetInstanceApplicationService) ApplicationContext.current.get("attributeSetInstanceApplicationService");
    }

    AttributeSetService getAttributeSetService() {
        return (AttributeSetService) ApplicationContext.current.get("attributeSetService");
    }

    InventoryItemApplicationService getInventoryItemApplicationService() {
        return (InventoryItemApplicationService) ApplicationContext.current.get("inventoryItemApplicationService");
    }

    private IdGenerator<Long, Object, Object> seqIdGenerator = new TableIdGenerator();

    public final IdGenerator<Long, Object, Object> getSeqIdGenerator() {
        return seqIdGenerator;
    }

    public final void setSeqIdGenerator(IdGenerator<Long, Object, Object> value) {
        seqIdGenerator = value;
    }

    public ShipmentApplicationServiceImpl(EventStore eventStore, ShipmentStateRepository stateRepository, ShipmentStateQueryRepository stateQueryRepository) {
        super(eventStore, stateRepository, stateQueryRepository);
    }

    @Override
    @Transactional
    public void when(ShipmentCommands.ConfirmAllItemsReceived c) {
        //todo
        super.when(c);
    }

    @Override
    @Transactional
    public void when(ShipmentCommands.ReceiveItem c) {
        //todo
        super.when(c);
    }

    @Override
    @Transactional
    public void when(ShipmentCommands.Import c) {
        //todo
        super.when(c);
    }

    private void updateShipment(ShipmentCommands.ReceiveItem c, ShipmentReceiptCommand.CreateOrMergePatchShipmentReceipt updateReceipt) {
        ShipmentCommand.MergePatchShipment updateShipment = new AbstractShipmentCommand.SimpleMergePatchShipment();
        updateShipment.getShipmentReceiptCommands().add(updateReceipt);
        updateShipment.setShipmentId(c.getShipmentId());
        updateShipment.setVersion(c.getVersion());
        updateShipment.setCommandId(c.getCommandId());
        updateShipment.setRequesterId(c.getRequesterId());
        when(updateShipment);
    }

    private ShipmentReceiptCommand.CreateOrMergePatchShipmentReceipt createOrUpdateShipmentReceipt(ShipmentCommands.ReceiveItem c, ShipmentState shipment, ShipmentItemState shipmentItem) {
        ShipmentReceiptCommand.CreateOrMergePatchShipmentReceipt updateReceipt = null;
        String receiptSeqId = c.getShipmentItemSeqId();
        ShipmentReceiptState receipt = shipment.getShipmentReceipts().get(receiptSeqId, false, true);
        if (receipt == null) {
            updateReceipt = new AbstractShipmentReceiptCommand.SimpleCreateShipmentReceipt();
        } else {
            updateReceipt = new AbstractShipmentReceiptCommand.SimpleMergePatchShipmentReceipt();
        }

        ProductState prdState = getProductState(shipmentItem.getProductId());

        String attrSetInstId = createAttributeSetInstance(prdState.getAttributeSetId(), c.getAttributeSetInstance());
        //        if (_log.IsDebugEnabled) {
        //            _log.Debug("Create attribute set instance, id: " + attrSetInstId);
        //        }

        updateReceipt.setAttributeSetInstanceId(attrSetInstId);
        updateReceipt.setReceiptSeqId(receiptSeqId);
        updateReceipt.setShipmentItemSeqId(shipmentItem.getShipmentItemSeqId());
        updateReceipt.setProductId(shipmentItem.getProductId());
        updateReceipt.setAcceptedQuantity(c.getAcceptedQuantity());
        updateReceipt.setRejectedQuantity(c.getRejectedQuantity());
        updateReceipt.setDamagedQuantity(c.getDamagedQuantity());
        updateReceipt.setDamageStatusId(c.getDamageStatusId());
        updateReceipt.setDamageReasonId(c.getDamageReasonId());
        updateReceipt.setReceivedBy(c.getRequesterId());
        return updateReceipt;
    }

    private String createAttributeSetInstance(String attrSetId, Map<String, Object> attrSetInstDict) {
        if (attrSetId == null) {
            return null;
        }
        Map<String, String> nameDict = getAttributeSetService().getPropertyExtensionFieldDictionary(attrSetId);

        AttributeSetInstanceCommand.CreateAttributeSetInstance createAttrSetInst = new AbstractAttributeSetInstanceCommand.SimpleCreateAttributeSetInstance();
        for (Map.Entry<String, Object> kv : attrSetInstDict.entrySet()) {
            String fname = nameDict.containsKey(kv.getKey()) ? nameDict.get(kv.getKey()) : kv.getKey();
            // createAttrSetInst.AirDryMetricTon = (decimal)kv.Value;
            boolean b = false;//todo: ReflectUtils.TrySetPropertyValue(fname, createAttrSetInst, kv.getValue());
            if (!b) {
                String fmt = "Set property error. Property name: %1$s";
                //                if (_log.IsInfoEnabled) {
                //                    _log.Info(String.format(fmt, fname));
                //                }
                throw new DomainError(fmt, fname);
            }
            // //////////////////////////////////////////
        }
        String attrSetInstId = getAttributeSetInstanceApplicationService().createWithoutId(createAttrSetInst);
        return attrSetInstId;
    }

    private ProductState getProductState(String productId) {
        ProductState prdState = getProductApplicationService().get(productId);
        if (prdState == null) {
            throw new IllegalArgumentException(String.format("Product NOT found. Product Id.: %1$s", productId));
        }
        return prdState;
    }

    private ShipmentState assertShipmentStatus(String shipmentId, String status) {
        ShipmentState shipment = getStateRepository().get(shipmentId, true);
        if (shipment == null) {
            throw new IllegalArgumentException(String.format("Error shipment Id.: %1$s", shipmentId));
        } else {
            if (!Objects.equals(shipment.getStatusId().toLowerCase(), status.toLowerCase())) {
                throw new IllegalArgumentException(String.format("Error shipment status: %1$s", shipment.getStatusId()));
            }
        }
        return shipment;
    }

}
