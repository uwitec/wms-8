package org.dddml.wms.domain.damagehandlingmethod;

import org.dddml.wms.domain.*;
import java.util.*;
import org.dddml.wms.specialization.*;

public class DamageHandlingMethodStateEventIdFlattenedDtoFormatter extends AbstractIdFlattenedDtoFormatter<DamageHandlingMethodStateEventIdFlattenedDto>
{


    @Override
    protected DamageHandlingMethodStateEventIdFlattenedDto newDto() {
        return new DamageHandlingMethodStateEventIdFlattenedDto();
    }

    @Override
    protected String[] getFieldNames() {
        return DamageHandlingMethodStateEventIdFlattenedDto.propertyNames;
    }

    @Override
    protected void setFieldStringValue(DamageHandlingMethodStateEventIdFlattenedDto dto, String fieldName, String fieldValue) {
        Class clazz = getFieldClass(fieldName);
        Object objVal = ApplicationContext.current.getTypeConverter().convertFromString(clazz, fieldValue);
        if ("damageHandlingMethodId".equals(fieldName)) {
            dto.setDamageHandlingMethodId((String) objVal);
            return;
        }
        if ("version".equals(fieldName)) {
            dto.setVersion((Long) objVal);
            return;
        }
    }

    @Override
    protected String getFieldStringValue(DamageHandlingMethodStateEventIdFlattenedDto dto, String fieldName) {
        Class clazz = getFieldClass(fieldName);
        if ("damageHandlingMethodId".equals(fieldName)) {
            Object objVal = dto.getDamageHandlingMethodId();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        if ("version".equals(fieldName)) {
            Object objVal = dto.getVersion();
            String strVal = ApplicationContext.current.getTypeConverter().convertToString(clazz, objVal);
            return strVal;
        }
        return null;
    }

    protected Class getFieldClass(String fieldName) {
        String type = DamageHandlingMethodStateEventIdFlattenedDto.propertyTypeMap.get(fieldName);
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
