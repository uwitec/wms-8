package org.dddml.wms.domain.ordershipment;

import java.io.Serializable;
import org.dddml.wms.domain.*;

public class OrderShipmentEventId implements Serializable
{
    private OrderShipmentId orderShipmentId = new OrderShipmentId();

    public OrderShipmentId getOrderShipmentId()
    {
        return this.orderShipmentId;
    }

    public void setOrderShipmentId(OrderShipmentId orderShipmentId)
    {
        this.orderShipmentId = orderShipmentId;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    protected String getOrderShipmentIdOrderId()
    {
        return getOrderShipmentId().getOrderId();
    }

    protected void setOrderShipmentIdOrderId(String orderShipmentIdOrderId)
    {
        getOrderShipmentId().setOrderId(orderShipmentIdOrderId);
    }

    protected String getOrderShipmentIdOrderItemSeqId()
    {
        return getOrderShipmentId().getOrderItemSeqId();
    }

    protected void setOrderShipmentIdOrderItemSeqId(String orderShipmentIdOrderItemSeqId)
    {
        getOrderShipmentId().setOrderItemSeqId(orderShipmentIdOrderItemSeqId);
    }

    protected String getOrderShipmentIdShipGroupSeqId()
    {
        return getOrderShipmentId().getShipGroupSeqId();
    }

    protected void setOrderShipmentIdShipGroupSeqId(String orderShipmentIdShipGroupSeqId)
    {
        getOrderShipmentId().setShipGroupSeqId(orderShipmentIdShipGroupSeqId);
    }

    protected String getOrderShipmentIdShipmentId()
    {
        return getOrderShipmentId().getShipmentId();
    }

    protected void setOrderShipmentIdShipmentId(String orderShipmentIdShipmentId)
    {
        getOrderShipmentId().setShipmentId(orderShipmentIdShipmentId);
    }

    protected String getOrderShipmentIdShipmentItemSeqId()
    {
        return getOrderShipmentId().getShipmentItemSeqId();
    }

    protected void setOrderShipmentIdShipmentItemSeqId(String orderShipmentIdShipmentItemSeqId)
    {
        getOrderShipmentId().setShipmentItemSeqId(orderShipmentIdShipmentItemSeqId);
    }

    public OrderShipmentEventId()
    {
    }

    public OrderShipmentEventId(OrderShipmentId orderShipmentId, Long version)
    {
        this.orderShipmentId = orderShipmentId;
        this.version = version;
    }

    @Override
    public boolean equals(Object obj)
    {
        if (obj == this) {
            return true;
        }
        if (obj == null || obj.getClass() != this.getClass()) {
            return false;
        }

        OrderShipmentEventId other = (OrderShipmentEventId)obj;
        return true 
            && (orderShipmentId == other.orderShipmentId || (orderShipmentId != null && orderShipmentId.equals(other.orderShipmentId)))
            && (version == other.version || (version != null && version.equals(other.version)))
            ;
    }

    @Override
    public int hashCode()
    {
        int hash = 0;
        if (this.orderShipmentId != null) {
            hash += 13 * this.orderShipmentId.hashCode();
        }
        if (this.version != null) {
            hash += 13 * this.version.hashCode();
        }
        return hash;
    }


    protected static final String[] FLATTENED_PROPERTY_NAMES = new String[]{
            "orderShipmentIdOrderId",
            "orderShipmentIdOrderItemSeqId",
            "orderShipmentIdShipGroupSeqId",
            "orderShipmentIdShipmentId",
            "orderShipmentIdShipmentItemSeqId",
            "version",
    };

    protected static final String[] FLATTENED_PROPERTY_TYPES = new String[]{
            "String",
            "String",
            "String",
            "String",
            "String",
            "Long",
    };

    protected static final java.util.Map<String, String> FLATTENED_PROPERTY_TYPE_MAP;

    static {
        java.util.Map<String, String> m = new java.util.HashMap<String, String>();
        for (int i = 0; i < FLATTENED_PROPERTY_NAMES.length; i++) {
            m.put(FLATTENED_PROPERTY_NAMES[i], FLATTENED_PROPERTY_TYPES[i]);
        }
        FLATTENED_PROPERTY_TYPE_MAP = m;
    }

    protected void forEachFlattenedProperty(java.util.function.BiConsumer<String, Object> consumer) {
        for (int i = 0; i < FLATTENED_PROPERTY_NAMES.length; i++) {
            String pn = FLATTENED_PROPERTY_NAMES[i];
            if (Character.isLowerCase(pn.charAt(0))) {
                pn = Character.toUpperCase(pn.charAt(0)) + pn.substring(1);
            }
            java.lang.reflect.Method m = null;
            try {
                m = this.getClass().getDeclaredMethod("get" + pn, new Class[0]);
            } catch (NoSuchMethodException e) {
                try {
                    m = this.getClass().getMethod("get" + pn, new Class[0]);
                } catch (NoSuchMethodException e1) {
                    throw new RuntimeException(e);
                }
            }
            Object pv = null;
            try {
                pv = m.invoke(this);
            } catch (IllegalAccessException | java.lang.reflect.InvocationTargetException e) {
                throw new RuntimeException(e);
            }
            consumer.accept(pn, pv);
        }
    }

    protected void setFlattenedPropertyValues(Object... values) {
        for (int i = 0; i < FLATTENED_PROPERTY_NAMES.length; i++) {
            String pn = FLATTENED_PROPERTY_NAMES[i];
            if (Character.isLowerCase(pn.charAt(0))) {
                pn = Character.toUpperCase(pn.charAt(0)) + pn.substring(1);
            }
            Object v = values[i];
            Class propCls = v == null ? Object.class : v.getClass();
            java.lang.reflect.Method setterMethod = null;
            if (v == null) {
                setterMethod = getNullValueSetterMethod(pn);
            }
            if (setterMethod == null) {
                try {
                    setterMethod = this.getClass().getDeclaredMethod("set" + pn, new Class[]{propCls});
                } catch (NoSuchMethodException e) {
                    try {
                        setterMethod = this.getClass().getMethod("set" + pn, new Class[]{propCls});
                    } catch (NoSuchMethodException e1) {
                        throw new RuntimeException(e1);
                    }
                }
            }
            try {
                setterMethod.invoke(this, v);
            } catch (IllegalAccessException | java.lang.reflect.InvocationTargetException e) {
                throw new RuntimeException(e);
            }
        }
    }

    private java.lang.reflect.Method getNullValueSetterMethod(String pascalPropName) {
        java.lang.reflect.Method m;
        final String methodName = "set" + pascalPropName;
        m = java.util.Arrays.stream(this.getClass().getDeclaredMethods())
                .filter(me -> me.getName().equals(methodName) && me.getParameterCount() == 1)
                .findFirst().orElse(null);
        if (m == null) {
            m = java.util.Arrays.stream(this.getClass().getMethods())
                    .filter(me -> me.getName().equals(methodName) && me.getParameterCount() == 1)
                    .findFirst().orElse(null);
        }
        return m;
    }

}

