package org.dddml.wms.domain.meta;

import java.util.HashMap;
import java.util.Map;


public final class PartyMetadata {

    private PartyMetadata() {
    }

    public static final String PROPERTY_NAME_VERSION      = "version";
    public static final String PROPERTY_NAME_ACTIVE       = "active";
    public static final String PROPERTY_NAME_DELETED      = "deleted";
    public static final String PROPERTY_NAME_CREATED_BY   = "createdBy";
    public static final String PROPERTY_NAME_CREATED_AT   = "createdAt";
    public static final String PROPERTY_NAME_UPDATED_BY   = "updatedBy";
    public static final String PROPERTY_NAME_UPDATED_AT   = "updatedAt";

    public static final String[] propertyNames = new String[] {
            "partyId",
            "partyTypeId",
            "primaryRoleTypeId",
            "externalId",
            "preferredCurrencyUomId",
            "description",
            "organizationName",
            "isSummary",
            "salutation",
            "firstName",
            "middleName",
            "lastName",
            "personalTitle",
            "nickname",
            "cardId",
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
            "String",
            "String",
            "String",
            "String",
            "String",
            "Boolean",
            "String",
            "String",
            "String",
            "String",
            "String",
            "String",
            "String",
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
        aliasMap.put("partyId", "partyId");
        aliasMap.put("PartyId", "partyId");
        aliasMap.put("partyTypeId", "partyTypeId");
        aliasMap.put("PartyTypeId", "partyTypeId");
        aliasMap.put("primaryRoleTypeId", "primaryRoleTypeId");
        aliasMap.put("PrimaryRoleTypeId", "primaryRoleTypeId");
        aliasMap.put("externalId", "externalId");
        aliasMap.put("ExternalId", "externalId");
        aliasMap.put("preferredCurrencyUomId", "preferredCurrencyUomId");
        aliasMap.put("PreferredCurrencyUomId", "preferredCurrencyUomId");
        aliasMap.put("description", "description");
        aliasMap.put("Description", "description");
        aliasMap.put("organizationName", "organizationName");
        aliasMap.put("OrganizationName", "organizationName");
        aliasMap.put("isSummary", "isSummary");
        aliasMap.put("IsSummary", "isSummary");
        aliasMap.put("salutation", "salutation");
        aliasMap.put("Salutation", "salutation");
        aliasMap.put("firstName", "firstName");
        aliasMap.put("FirstName", "firstName");
        aliasMap.put("middleName", "middleName");
        aliasMap.put("MiddleName", "middleName");
        aliasMap.put("lastName", "lastName");
        aliasMap.put("LastName", "lastName");
        aliasMap.put("personalTitle", "personalTitle");
        aliasMap.put("PersonalTitle", "personalTitle");
        aliasMap.put("nickname", "nickname");
        aliasMap.put("Nickname", "nickname");
        aliasMap.put("cardId", "cardId");
        aliasMap.put("CardId", "cardId");
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

