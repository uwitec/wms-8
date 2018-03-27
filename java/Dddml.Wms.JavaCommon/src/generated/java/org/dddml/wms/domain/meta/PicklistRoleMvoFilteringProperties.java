package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;

public final class PicklistRoleMvoFilteringProperties
{

    private PicklistRoleMvoFilteringProperties()
    {
    }

    public static final String[] propertyNames = new String[] {
            "createdByUserLogin",
            "lastModifiedByUserLogin",
            "version",
            "createdAt",
            "updatedAt",
            "active",
            "deleted",
            "picklistDescription",
            "picklistFacilityId",
            "picklistShipmentMethodTypeId",
            "picklistStatusId",
            "picklistPicklistDate",
            "picklistCreatedByUserLogin",
            "picklistLastModifiedByUserLogin",
            "picklistVersion",
            "picklistCreatedAt",
            "picklistUpdatedAt",
            "picklistActive",
            "picklistDeleted",
            "picklistRoleId.picklistId",
            "picklistRoleId.partyRoleIdPartyId",
            "picklistRoleId.partyRoleIdRoleTypeId",
    };

    public static final String[] propertyTypes = new String[] {
            "String",
            "String",
            "Long",
            "Date",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
            "String",
            "String",
            "java.sql.Timestamp",
            "String",
            "String",
            "Long",
            "Date",
            "Date",
            "Boolean",
            "Boolean",
            "String",
            "String",
            "String",
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
        aliasMap.put("createdByUserLogin", "createdByUserLogin");
        aliasMap.put("CreatedByUserLogin", "createdByUserLogin");
        aliasMap.put("lastModifiedByUserLogin", "lastModifiedByUserLogin");
        aliasMap.put("LastModifiedByUserLogin", "lastModifiedByUserLogin");
        aliasMap.put("version", "version");
        aliasMap.put("Version", "version");
        aliasMap.put("createdAt", "createdAt");
        aliasMap.put("CreatedAt", "createdAt");
        aliasMap.put("updatedAt", "updatedAt");
        aliasMap.put("UpdatedAt", "updatedAt");
        aliasMap.put("active", "active");
        aliasMap.put("Active", "active");
        aliasMap.put("deleted", "deleted");
        aliasMap.put("Deleted", "deleted");
        aliasMap.put("picklistDescription", "picklistDescription");
        aliasMap.put("PicklistDescription", "picklistDescription");
        aliasMap.put("picklistFacilityId", "picklistFacilityId");
        aliasMap.put("PicklistFacilityId", "picklistFacilityId");
        aliasMap.put("picklistShipmentMethodTypeId", "picklistShipmentMethodTypeId");
        aliasMap.put("PicklistShipmentMethodTypeId", "picklistShipmentMethodTypeId");
        aliasMap.put("picklistStatusId", "picklistStatusId");
        aliasMap.put("PicklistStatusId", "picklistStatusId");
        aliasMap.put("picklistPicklistDate", "picklistPicklistDate");
        aliasMap.put("PicklistPicklistDate", "picklistPicklistDate");
        aliasMap.put("picklistCreatedByUserLogin", "picklistCreatedByUserLogin");
        aliasMap.put("PicklistCreatedByUserLogin", "picklistCreatedByUserLogin");
        aliasMap.put("picklistLastModifiedByUserLogin", "picklistLastModifiedByUserLogin");
        aliasMap.put("PicklistLastModifiedByUserLogin", "picklistLastModifiedByUserLogin");
        aliasMap.put("picklistVersion", "picklistVersion");
        aliasMap.put("PicklistVersion", "picklistVersion");
        aliasMap.put("picklistCreatedAt", "picklistCreatedAt");
        aliasMap.put("PicklistCreatedAt", "picklistCreatedAt");
        aliasMap.put("picklistUpdatedAt", "picklistUpdatedAt");
        aliasMap.put("PicklistUpdatedAt", "picklistUpdatedAt");
        aliasMap.put("picklistActive", "picklistActive");
        aliasMap.put("PicklistActive", "picklistActive");
        aliasMap.put("picklistDeleted", "picklistDeleted");
        aliasMap.put("PicklistDeleted", "picklistDeleted");
        aliasMap.put("picklistRoleId.picklistId", "picklistRoleId.picklistId");
        aliasMap.put("PicklistRoleId.PicklistId", "picklistRoleId.picklistId");
        aliasMap.put("picklistRoleId.partyRoleIdPartyId", "picklistRoleId.partyRoleIdPartyId");
        aliasMap.put("PicklistRoleId.PartyRoleIdPartyId", "picklistRoleId.partyRoleIdPartyId");
        aliasMap.put("picklistRoleId.partyRoleId.partyId", "picklistRoleId.partyRoleIdPartyId");
        aliasMap.put("PicklistRoleId.PartyRoleId.PartyId", "picklistRoleId.partyRoleIdPartyId");
        aliasMap.put("picklistRoleId.partyRoleIdRoleTypeId", "picklistRoleId.partyRoleIdRoleTypeId");
        aliasMap.put("PicklistRoleId.PartyRoleIdRoleTypeId", "picklistRoleId.partyRoleIdRoleTypeId");
        aliasMap.put("picklistRoleId.partyRoleId.roleTypeId", "picklistRoleId.partyRoleIdRoleTypeId");
        aliasMap.put("PicklistRoleId.PartyRoleId.RoleTypeId", "picklistRoleId.partyRoleIdRoleTypeId");
    }

    private static void initPropertyTypeMap() {
        for (int i = 0; i < propertyNames.length; i++ ) {
            propertyTypeMap.put(propertyNames[i], propertyTypes[i]);
        }
    }

}

