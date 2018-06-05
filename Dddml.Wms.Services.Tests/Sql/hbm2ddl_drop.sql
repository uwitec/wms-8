
    drop table if exists Hello;

    drop table if exists Attributes;

    drop table if exists AttributeValues;

    drop table if exists AttributeAlias;

    drop table if exists AttributeSets;

    drop table if exists AttributeUses;

    drop table if exists DamageReasons;

    drop table if exists DamageTypes;

    drop table if exists DamageHandlingMethods;

    drop table if exists DocumentTypes;

    drop table if exists ContactMeches;

    drop table if exists Facilities;

    drop table if exists AttributeSetInstances;

    drop table if exists AttributeSetInstanceExtensionFields;

    drop table if exists AttributeSetInstanceExtensionFieldGroups;

    drop table if exists AttributeValue_RV;

    drop table if exists AttributeAlias_RV;

    drop table if exists AttributeUse_RV;

    drop table if exists AttributeEvents;

    drop table if exists AttributeValueEvents;

    drop table if exists AttributeAliasEvents;

    drop table if exists AttributeSetEvents;

    drop table if exists AttributeUseEvents;

    drop table if exists ContactMechEvents;

    drop table if exists DamageReasonEvents;

    drop table if exists FacilityEvents;

    drop table if exists AttributeSetInstanceExtensionFieldEvents;

    drop table if exists AttributeSetInstanceExtensionFieldGroupEvents;

    drop table if exists AttributeValueMvoEvents;

    drop table if exists AttributeAliasMvoEvents;

    drop table if exists AttributeUseMvoEvents;

    drop table if exists InOuts;

    drop table if exists InOutLines;

    drop table if exists InventoryItems;

    drop table if exists InventoryItemEntries;

    drop table if exists InventoryItemRequirements;

    drop table if exists InventoryItemRequirementEntries;

    drop table if exists InventoryPostingRules;

    drop table if exists InventoryPRTriggereds;

    drop table if exists Lots;

    drop table if exists Movements;

    drop table if exists MovementLines;

    drop table if exists MovementConfirmations;

    drop table if exists MovementConfirmationLines;

    drop table if exists MovementTypes;

    drop table if exists Orders;

    drop table if exists OrderItems;

    drop table if exists OrderShipments;

    drop table if exists OrganizationStructures;

    drop table if exists OrganizationStructureTypes;

    drop table if exists Parties;

    drop table if exists Organizations;

    drop table if exists PhysicalInventories;

    drop table if exists PhysicalInventoryLines;

    drop table if exists Locators;

    drop table if exists OrderRoles;

    drop table if exists OrderShipGroups;

    drop table if exists PartyRoles;

    drop table if exists Picklists;

    drop table if exists PicklistRoles;

    drop table if exists PicklistBins;

    drop table if exists PicklistItems;

    drop table if exists Products;

    drop table if exists ProductCategories;

    drop table if exists ProductCategoryMembers;

    drop table if exists RejectionReasons;

    drop table if exists RoleTypes;

    drop table if exists SellableInventoryItems;

    drop table if exists SellableInventoryItemEntries;

    drop table if exists Shipments;

    drop table if exists ShipmentItems;

    drop table if exists ShipmentReceipts;

    drop table if exists ItemIssuances;

    drop table if exists ShipmentMethodTypes;

    drop table if exists ShipmentPackages;

    drop table if exists ShipmentPackageContents;

    drop table if exists ShipmentTypes;

    drop table if exists StatusItems;

    drop table if exists SupplierProducts;

    drop table if exists Uoms;

    drop table if exists UomConversions;

    drop table if exists UomTypes;

    drop table if exists Warehouses;

    drop table if exists InOutLine_RV;

    drop table if exists InventoryItemEntry_RV;

    drop table if exists InventoryItemRequirementEntry_RV;

    drop table if exists MovementLine_RV;

    drop table if exists MovementConfirmationLine_RV;

    drop table if exists OrderRole_RV;

    drop table if exists OrderItem_RV;

    drop table if exists OrderShipGroup_RV;

    drop table if exists PhysicalInventoryLine_RV;

    drop table if exists PicklistRole_RV;

    drop table if exists PicklistItem_RV;

    drop table if exists SellableInventoryItemEntry_RV;

    drop table if exists ShipmentItem_RV;

    drop table if exists ShipmentReceipt_RV;

    drop table if exists ItemIssuance_RV;

    drop table if exists ShipmentPackageContent_RV;

    drop table if exists OrderItemShipGrpInvReservations;

    drop table if exists LocatorTypes;

    drop table if exists Pickwaves;

    drop table if exists OrderItemShipGroupAssociations;

    drop table if exists OrderItemShipGroupAssociation_RV;

    drop table if exists InOutEvents;

    drop table if exists InOutLineEvents;

    drop table if exists InventoryItemEvents;

    drop table if exists InventoryPostingRuleEvents;

    drop table if exists LocatorEvents;

    drop table if exists LocatorTypeEvents;

    drop table if exists LotEvents;

    drop table if exists MovementEvents;

    drop table if exists MovementLineEvents;

    drop table if exists MovementConfirmationEvents;

    drop table if exists MovementConfirmationLineEvents;

    drop table if exists OrderEvents;

    drop table if exists OrderRoleEvents;

    drop table if exists OrderItemEvents;

    drop table if exists OrderShipGroupEvents;

    drop table if exists OrderItemShipGroupAssociationEvents;

    drop table if exists OrderItemShipGrpInvReservationEvents;

    drop table if exists OrderShipmentEvents;

    drop table if exists OrganizationStructureEvents;

    drop table if exists OrganizationStructureTypeEvents;

    drop table if exists PartyEvents;

    drop table if exists PartyRoleEvents;

    drop table if exists PhysicalInventoryEvents;

    drop table if exists PhysicalInventoryLineEvents;

    drop table if exists PicklistEvents;

    drop table if exists PicklistRoleEvents;

    drop table if exists PicklistBinEvents;

    drop table if exists PicklistItemEvents;

    drop table if exists PickwaveEvents;

    drop table if exists ProductEvents;

    drop table if exists ProductCategoryEvents;

    drop table if exists ProductCategoryMemberEvents;

    drop table if exists RejectionReasonEvents;

    drop table if exists RoleTypeEvents;

    drop table if exists ShipmentEvents;

    drop table if exists ShipmentItemEvents;

    drop table if exists ShipmentReceiptEvents;

    drop table if exists ItemIssuanceEvents;

    drop table if exists ShipmentMethodTypeEvents;

    drop table if exists ShipmentPackageEvents;

    drop table if exists ShipmentPackageContentEvents;

    drop table if exists SupplierProductEvents;

    drop table if exists UomEvents;

    drop table if exists UomConversionEvents;

    drop table if exists WarehouseEvents;

    drop table if exists InOutLineMvoEvents;

    drop table if exists InventoryItemEntryMvoEvents;

    drop table if exists InventoryItemRequirementEntryMvoEvents;

    drop table if exists MovementLineMvoEvents;

    drop table if exists MovementConfirmationLineMvoEvents;

    drop table if exists OrderRoleMvoEvents;

    drop table if exists OrderItemMvoEvents;

    drop table if exists OrderShipGroupMvoEvents;

    drop table if exists OrderItemShipGroupAssociationMvoEvents;

    drop table if exists PhysicalInventoryLineMvoEvents;

    drop table if exists PicklistRoleMvoEvents;

    drop table if exists PicklistItemMvoEvents;

    drop table if exists SellableInventoryItemEntryMvoEvents;

    drop table if exists ShipmentItemMvoEvents;

    drop table if exists ShipmentReceiptMvoEvents;

    drop table if exists ItemIssuanceMvoEvents;

    drop table if exists ShipmentPackageContentMvoEvents;

    drop table if exists GoodIdentificationTypes;

    drop table if exists GoodIdentificationTypeEvents;

    drop table if exists GoodIdentifications;

    drop table if exists GoodIdentificationEvents;

    drop table if exists GoodIdentification_RV;

    drop table if exists GoodIdentificationMvoEvents;

    drop table if exists nhibernate_hilo_table;
