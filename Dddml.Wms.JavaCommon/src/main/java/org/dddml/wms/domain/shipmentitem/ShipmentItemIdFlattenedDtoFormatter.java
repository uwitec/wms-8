package org.dddml.wms.domain.shipmentitem;

import org.dddml.wms.domain.*;
import java.util.*;
import org.dddml.wms.specialization.*;

public class ShipmentItemIdFlattenedDtoFormatter extends AbstractIdFlattenedDtoFormatter<ShipmentItemIdFlattenedDto>
{


    @Override
    protected ShipmentItemIdFlattenedDto newDto() {
        return new ShipmentItemIdFlattenedDto();
    }

    @Override
    protected String[] getFieldNames() {
        return ShipmentItemIdFlattenedDto.propertyNames;
    }

    @Override
    protected void setFieldStringValue(ShipmentItemIdFlattenedDto dto, String fieldName, String fieldValue) {
        Class clazz = getFieldClass(fieldName);
        Object objVal = ApplicationContext.current.getTypeConverter().convertFromString(clazz, fieldValue);
        if ("shipmentId".equals(fieldName)) {
            dto.setShipmentId((String) objVal);
            return;
        }
        if ("shipmentItemSeqId".equals(fieldName)) {
            dto.setShipmentItemSeqId((String) objVal);
            return;
        }
    }

    @Override
    protected String getFieldStringValue(ShipmentItemIdFlattenedDto dto, String fieldName) {
        Class clazz = getFieldClass(fieldName);
        if ("shipmentId".equals(fieldName)) {
            Object objVal = dto.getShipmentId();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        if ("shipmentItemSeqId".equals(fieldName)) {
            Object objVal = dto.getShipmentItemSeqId();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        return null;
    }

    protected Class getFieldClass(String fieldName) {
        String type = ShipmentItemIdFlattenedDto.propertyTypeMap.get(fieldName);
        if(type == null) {
            throw new IllegalArgumentException(String.format("The field name \"%1$s\" is NOT right.", fieldName));
        }
        Class clazz = ReflectUtils.CLASS_MAP.get(type);
        if (clazz == null) {
            throw new RuntimeException("ERROR! ReflectUtils.CLASS_MAP.get(type) == null");
        }
        return clazz;
    }

}
