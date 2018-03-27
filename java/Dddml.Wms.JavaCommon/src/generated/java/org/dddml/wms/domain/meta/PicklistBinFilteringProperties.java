package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class PicklistBinFilteringProperties
{

    private PicklistBinFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "picklistBinId",
            "picklistId",
            "binLocationNumber",
            "primaryOrderId",
            "primaryShipGroupSeqId",
            "version",
            "createdBy",
            "createdAt",
            "updatedBy",
            "updatedAt",
            "active",
            "deleted",
    };

    public static final String[] propertyTypes = new String[] {
            "String",
            "String",
            "Long",
            "String",
            "Long",
            "Long",
            "String",
            "Date",
            "String",
            "Date",
            "Boolean",
            "Boolean",
    };

    public static final Map<String, String> propertyTypeMap;

    public static final Map<String, String> aliasMap;

    static {
        propertyTypeMap = new HashMap<String, String>();
        initPropertyTypeMap();
        aliasMap = new HashMap<String, String>();
        initAliasMap();
    }

    private static  void initAliasMap() {
        aliasMap.put("picklistBinId", "picklistBinId");
        aliasMap.put("PicklistBinId", "picklistBinId");
        aliasMap.put("picklistId", "picklistId");
        aliasMap.put("PicklistId", "picklistId");
        aliasMap.put("binLocationNumber", "binLocationNumber");
        aliasMap.put("BinLocationNumber", "binLocationNumber");
        aliasMap.put("primaryOrderId", "primaryOrderId");
        aliasMap.put("PrimaryOrderId", "primaryOrderId");
        aliasMap.put("primaryShipGroupSeqId", "primaryShipGroupSeqId");
        aliasMap.put("PrimaryShipGroupSeqId", "primaryShipGroupSeqId");
        aliasMap.put("version", "version");
        aliasMap.put("Version", "version");
        aliasMap.put("createdBy", "createdBy");
        aliasMap.put("CreatedBy", "createdBy");
        aliasMap.put("createdAt", "createdAt");
        aliasMap.put("CreatedAt", "createdAt");
        aliasMap.put("updatedBy", "updatedBy");
        aliasMap.put("UpdatedBy", "updatedBy");
        aliasMap.put("updatedAt", "updatedAt");
        aliasMap.put("UpdatedAt", "updatedAt");
        aliasMap.put("active", "active");
        aliasMap.put("Active", "active");
        aliasMap.put("deleted", "deleted");
        aliasMap.put("Deleted", "deleted");
    }

    private static void initPropertyTypeMap() {
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}

