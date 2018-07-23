package org.dddml.wms.domain.movement;

import java.util.Set;
import java.util.Date;
import java.math.BigDecimal;
import org.dddml.wms.domain.*;

public class MovementCommands
{
    private MovementCommands() {
    }

    public static class AddLine implements MovementCommand {

        public String getCommandType() {
            return "AddLine";
        }

        public void setCommandType(String commandType) {
            //do nothing
        }

        private String lineNumber;

        public String getLineNumber() {
            return this.lineNumber;
        }

        public void setLineNumber(String lineNumber) {
            this.lineNumber = lineNumber;
        }

        private String productId;

        public String getProductId() {
            return this.productId;
        }

        public void setProductId(String productId) {
            this.productId = productId;
        }

        private String locatorIdFrom;

        public String getLocatorIdFrom() {
            return this.locatorIdFrom;
        }

        public void setLocatorIdFrom(String locatorIdFrom) {
            this.locatorIdFrom = locatorIdFrom;
        }

        private String locatorIdTo;

        public String getLocatorIdTo() {
            return this.locatorIdTo;
        }

        public void setLocatorIdTo(String locatorIdTo) {
            this.locatorIdTo = locatorIdTo;
        }

        private java.util.Map<String, Object> attributeSetInstance;

        public java.util.Map<String, Object> getAttributeSetInstance() {
            return this.attributeSetInstance;
        }

        public void setAttributeSetInstance(java.util.Map<String, Object> attributeSetInstance) {
            this.attributeSetInstance = attributeSetInstance;
        }

        private String description;

        public String getDescription() {
            return this.description;
        }

        public void setDescription(String description) {
            this.description = description;
        }

        private String quantityUomId;

        public String getQuantityUomId() {
            return this.quantityUomId;
        }

        public void setQuantityUomId(String quantityUomId) {
            this.quantityUomId = quantityUomId;
        }

        private BigDecimal movementQuantity;

        public BigDecimal getMovementQuantity() {
            return this.movementQuantity;
        }

        public void setMovementQuantity(BigDecimal movementQuantity) {
            this.movementQuantity = movementQuantity;
        }

        private String documentNumber;

        public String getDocumentNumber() {
            return this.documentNumber;
        }

        public void setDocumentNumber(String documentNumber) {
            this.documentNumber = documentNumber;
        }

        private Long version;

        public Long getVersion() {
            return this.version;
        }

        public void setVersion(Long version) {
            this.version = version;
        }

        private String commandId;

        public String getCommandId() {
            return this.commandId;
        }

        public void setCommandId(String commandId) {
            this.commandId = commandId;
        }

        private String requesterId;

        public String getRequesterId() {
            return this.requesterId;
        }

        public void setRequesterId(String requesterId) {
            this.requesterId = requesterId;
        }

    }

    public static class DocumentAction implements MovementCommand {

        public String getCommandType() {
            return "DocumentAction";
        }

        public void setCommandType(String commandType) {
            //do nothing
        }

        private String value;

        public String getValue() {
            return this.value;
        }

        public void setValue(String value) {
            this.value = value;
        }

        private String documentNumber;

        public String getDocumentNumber() {
            return this.documentNumber;
        }

        public void setDocumentNumber(String documentNumber) {
            this.documentNumber = documentNumber;
        }

        private Long version;

        public Long getVersion() {
            return this.version;
        }

        public void setVersion(Long version) {
            this.version = version;
        }

        private String commandId;

        public String getCommandId() {
            return this.commandId;
        }

        public void setCommandId(String commandId) {
            this.commandId = commandId;
        }

        private String requesterId;

        public String getRequesterId() {
            return this.requesterId;
        }

        public void setRequesterId(String requesterId) {
            this.requesterId = requesterId;
        }

    }

}

