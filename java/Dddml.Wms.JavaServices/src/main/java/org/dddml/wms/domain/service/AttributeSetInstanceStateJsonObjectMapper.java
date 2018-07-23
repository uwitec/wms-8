package org.dddml.wms.domain.service;

import com.alibaba.fastjson.JSONObject;
import org.apache.commons.beanutils.BeanUtils;
import org.apache.commons.beanutils.PropertyUtilsBean;
import org.dddml.wms.domain.attributesetinstance.AbstractAttributeSetInstanceCommand;
import org.dddml.wms.domain.attributesetinstance.AttributeSetInstanceCommand;
import org.dddml.wms.domain.attributesetinstance.AttributeSetInstanceState;
import org.dddml.wms.specialization.AbstractDynamicObjectMapper;
import org.springframework.stereotype.Service;

import java.util.Map;

/**
 * Created by Li Yongchun on 2016/9/8.
 */

public class AttributeSetInstanceStateJsonObjectMapper extends AbstractDynamicObjectMapper<JSONObject,
        AttributeSetInstanceState,
        AttributeSetInstanceCommand.CreateAttributeSetInstance,
        Object//AttributeSetInstanceCommand.MergePatchAttributeSetInstance
        > {

    //需要注入
    private AttributeSetService attributeSetService;

    public void setAttributeSetService(AttributeSetService attributeSetService) {
        this.attributeSetService = attributeSetService;
    }

    @Override
    public JSONObject mapState(AttributeSetInstanceState state, String fields) {
        JSONObject jsonObject = new JSONObject();
        // 保留字段
        if (state.getAttributeSetId() != null) {
            jsonObject.put("attributeSetInstanceId", state.getAttributeSetInstanceId());
        }
        if (state.getAttributeSetId() != null) {
            jsonObject.put("attributeSetId", state.getAttributeSetId());
        }
        if (state.getActive() != null) {
            jsonObject.put("active", state.getActive());
        }
        if (state.getCreatedAt() != null) {
            jsonObject.put("createdAt", state.getCreatedAt());
        }
        if (state.getSerialNumber() != null) {
            jsonObject.put("serialNumber", state.getSerialNumber());
        }
        if (state.getUpdatedAt() != null) {
            jsonObject.put("updatedAt", state.getUpdatedAt());
        }
        if (state.getOrganizationId() != null) {
            jsonObject.put("organizationId", state.getOrganizationId());
        }
        if (state.getReferenceId() != null) {
            jsonObject.put("referenceId", state.getReferenceId());
        }
        if (state.getLotId() != null) {
            jsonObject.put("lotId", state.getLotId());
        }
        if (state.getDescription() != null) {
            jsonObject.put("description", state.getDescription());
        }
        if (state.getHash() != null) {
            jsonObject.put("hash", state.getHash());
        }
        //FIXME 也许遗漏了固定字段
        Map<String, String> maps = attributeSetService.
                getPropertyExtensionFieldDictionary(state.getAttributeSetId());
        maps.forEach((name, fieldName) -> {
            // fieldName 作为 property 名称的时候，应该是 camelCase 的
            if (Character.isUpperCase(fieldName.charAt(0))) {
                fieldName = Character.toLowerCase(fieldName.charAt(0)) + fieldName.substring(1);
            }
            try {
                // todo 这里还是自己重写？没有必要引进一个库？？？
                Object value = new PropertyUtilsBean().getSimpleProperty(state, fieldName);
                if (value != null) {
                    jsonObject.put(name, value);
                }
            } catch (Exception ex) {
                //FIXME 直接吞掉异常？
            }
        });
        return jsonObject;
    }

    @Override
    public AttributeSetInstanceCommand.CreateAttributeSetInstance toCommandCreate(JSONObject jsonObject) {
        if (jsonObject == null) {
            return null;
        }
        AbstractAttributeSetInstanceCommand.SimpleCreateAttributeSetInstance createAttributeSetInstance =
                jsonObject.toJavaObject(AbstractAttributeSetInstanceCommand.SimpleCreateAttributeSetInstance.class);
        Map<String, String> maps = attributeSetService.
                getPropertyExtensionFieldDictionary(createAttributeSetInstance.getAttributeSetId());
        maps.forEach((name, filedName) -> {
            try {
                Object value = jsonObject.get(name);
                if (value != null) {
                    BeanUtils.setProperty(createAttributeSetInstance, filedName, value);
                }
            } catch (Exception ex) {

            }
        });
        return createAttributeSetInstance;
    }

    @Override
    public Object toCommandMergePatch(JSONObject jsonObject) {
        throw new UnsupportedOperationException();
    }
    /*
    public AttributeSetInstanceCommand.MergePatchAttributeSetInstance toCommandMergePatch(JSONObject jsonObject) {
        //String jsonText = jsonObject.toJSONString();
        AbstractAttributeSetInstanceCommand.MergePatchAttributeSetInstance mergePatchAttributeSetInstance =
                jsonObject.toJavaObject(AbstractAttributeSetInstanceCommand.MergePatchAttributeSetInstance.class);
        //AbstractAttributeSetInstanceCommand.MergePatchAttributeSetInstance mergePatchAttributeSetInstance =
        //        JSON.parseObject(jsonText, AbstractAttributeSetInstanceCommand.MergePatchAttributeSetInstance.class);
        Map<String, String> maps = attributeSetService.
                getPropertyExtensionFieldDictionary(mergePatchAttributeSetInstance.getAttributeSetId());
        maps.forEach((name, filedName) -> {
            try {
                Object value = jsonObject.get(name);
                if (value != null) {
                    BeanUtils.setProperty(mergePatchAttributeSetInstance, filedName, value);
                }
            } catch (Exception ex) {

            }
        });
        return mergePatchAttributeSetInstance;
    }
    */
}
