
    create table AttributeValue_RV (
        AttributeValueIdAttributeId VARCHAR(50) not null,
       AttributeValueIdValue VARCHAR(50) not null,
       AttributeVersion BIGINT not null,
       Name VARCHAR(255),
       Description VARCHAR(255),
       ReferenceId VARCHAR(255),
       Version BIGINT,
       CreatedBy VARCHAR(255),
       UpdatedBy VARCHAR(255),
       Active TINYINT(1),
       Deleted TINYINT(1),
       AttributeName VARCHAR(255),
       AttributeOrganizationId VARCHAR(255),
       AttributeDescription VARCHAR(255),
       AttributeIsMandatory TINYINT(1),
       AttributeIsInstanceAttribute TINYINT(1),
       AttributeAttributeValueType VARCHAR(255),
       AttributeAttributeValueLength INTEGER,
       AttributeIsList TINYINT(1),
       AttributeFieldName VARCHAR(255),
       AttributeReferenceId VARCHAR(255),
       AttributeCreatedBy VARCHAR(255),
       AttributeCreatedAt DATETIME,
       AttributeUpdatedBy VARCHAR(255),
       AttributeUpdatedAt DATETIME,
       AttributeActive TINYINT(1),
       AttributeDeleted TINYINT(1),
       CreatedAt DATETIME,
       UpdatedAt DATETIME,
       primary key (AttributeValueIdAttributeId, AttributeValueIdValue)
    );
    create table AttributeUse_RV (
        AttributeSetAttributeUseIdAttributeSetId VARCHAR(50) not null,
       AttributeSetAttributeUseIdAttributeId VARCHAR(50) not null,
       AttributeSetVersion BIGINT not null,
       SequenceNumber INTEGER,
       Version BIGINT,
       CreatedBy VARCHAR(255),
       UpdatedBy VARCHAR(255),
       Active TINYINT(1),
       Deleted TINYINT(1),
       AttributeSetName VARCHAR(255),
       AttributeSetOrganizationId VARCHAR(255),
       AttributeSetDescription VARCHAR(255),
       AttributeSetSerialNumberAttributeId VARCHAR(255),
       AttributeSetLotAttributeId VARCHAR(255),
       AttributeSetReferenceId VARCHAR(255),
       AttributeSetCreatedBy VARCHAR(255),
       AttributeSetCreatedAt DATETIME,
       AttributeSetUpdatedBy VARCHAR(255),
       AttributeSetUpdatedAt DATETIME,
       AttributeSetActive TINYINT(1),
       AttributeSetDeleted TINYINT(1),
       CreatedAt DATETIME,
       UpdatedAt DATETIME,
       primary key (AttributeSetAttributeUseIdAttributeSetId, AttributeSetAttributeUseIdAttributeId)
    );
    create table AttributeSetInstanceExtensionField_RV (
        AttributeSetInstanceExtensionFieldIdGroupId VARCHAR(50) not null,
       AttributeSetInstanceExtensionFieldIdIndex VARCHAR(50) not null,
       AttrSetInstEFGroupVersion BIGINT not null,
       Name VARCHAR(255),
       Type VARCHAR(255),
       Length INTEGER,
       Alias VARCHAR(255),
       Description VARCHAR(255),
       Version BIGINT,
       CreatedBy VARCHAR(255),
       UpdatedBy VARCHAR(255),
       Active TINYINT(1),
       Deleted TINYINT(1),
       AttrSetInstEFGroupFieldType VARCHAR(255),
       AttrSetInstEFGroupFieldLength INTEGER,
       AttrSetInstEFGroupFieldCount INTEGER,
       AttrSetInstEFGroupNameFormat VARCHAR(255),
       AttrSetInstEFGroupDescription VARCHAR(255),
       AttrSetInstEFGroupCreatedBy VARCHAR(255),
       AttrSetInstEFGroupCreatedAt DATETIME,
       AttrSetInstEFGroupUpdatedBy VARCHAR(255),
       AttrSetInstEFGroupUpdatedAt DATETIME,
       AttrSetInstEFGroupActive TINYINT(1),
       AttrSetInstEFGroupDeleted TINYINT(1),
       CreatedAt DATETIME,
       UpdatedAt DATETIME,
       primary key (AttributeSetInstanceExtensionFieldIdGroupId, AttributeSetInstanceExtensionFieldIdIndex),
      unique (Name),
      unique (Alias)
    );
    create table InOutLine_RV (
        InOutLineIdInOutDocumentNumber VARCHAR(50) not null,
       InOutLineIdLineNumber BIGINT not null,
       InOutVersion BIGINT not null,
       Description VARCHAR(255),
       LocatorId VARCHAR(255),
       ProductId VARCHAR(255),
       UomId VARCHAR(255),
       MovementQuantity NUMERIC(19,5),
       ConfirmedQuantity NUMERIC(19,5),
       ScrappedQuantity NUMERIC(19,5),
       TargetQuantity NUMERIC(19,5),
       PickedQuantity NUMERIC(19,5),
       IsInvoiced TINYINT(1),
       AttributeSetInstanceId VARCHAR(255),
       IsDescription TINYINT(1),
       Processed TINYINT(1),
       QuantityEntered NUMERIC(19,5),
       RmaLineNumber BIGINT,
       ReversalLineNumber BIGINT,
       Version BIGINT,
       CreatedBy VARCHAR(255),
       UpdatedBy VARCHAR(255),
       Active TINYINT(1),
       Deleted TINYINT(1),
       InOutIsSOTransaction TINYINT(1),
       InOutDocumentStatus VARCHAR(255),
       InOutPosted TINYINT(1),
       InOutProcessing TINYINT(1),
       InOutProcessed TINYINT(1),
       InOutDocumentType INTEGER,
       InOutDescription VARCHAR(255),
       InOutOrderNumber VARCHAR(255),
       InOutDateOrdered DATETIME,
       InOutIsPrinted TINYINT(1),
       InOutMovementType VARCHAR(255),
       InOutMovementDate DATETIME,
       InOutBusinessPartnerId VARCHAR(255),
       InOutWarehouseId VARCHAR(255),
       InOutPOReference VARCHAR(255),
       InOutFreightAmountAmount NUMERIC(19,5),
       InOutFreightAmountCurrency VARCHAR(10),
       InOutShipperId VARCHAR(255),
       InOutChargeAmountAmount NUMERIC(19,5),
       InOutChargeAmountCurrency VARCHAR(10),
       InOutDatePrinted DATETIME,
       InOutSalesRepresentative VARCHAR(255),
       InOutNumberOfPackages INTEGER,
       InOutPickDate DATETIME,
       InOutShipDate DATETIME,
       InOutTrackingNumber VARCHAR(255),
       InOutDateReceived DATETIME,
       InOutIsInTransit TINYINT(1),
       InOutIsApproved TINYINT(1),
       InOutIsInDispute TINYINT(1),
       InOutVolume NUMERIC(19,5),
       InOutWeight NUMERIC(19,5),
       InOutRmaNumber VARCHAR(255),
       InOutReversalNumber VARCHAR(255),
       InOutIsDropShip TINYINT(1),
       InOutDropShipBusinessPartnerId VARCHAR(255),
       InOutCreatedBy VARCHAR(255),
       InOutCreatedAt DATETIME,
       InOutUpdatedBy VARCHAR(255),
       InOutUpdatedAt DATETIME,
       InOutActive TINYINT(1),
       InOutDeleted TINYINT(1),
       CreatedAt DATETIME,
       UpdatedAt DATETIME,
       primary key (InOutLineIdInOutDocumentNumber, InOutLineIdLineNumber)
    );
    create table InventoryItemEntry_RV (
        ProductId VARCHAR(255) not null,
       LocatorId VARCHAR(255) not null,
       AttributeSetInstanceId VARCHAR(255) not null,
       EntrySeqId BIGINT not null,
       InventoryItemVersion BIGINT not null,
       QuantityOnHand NUMERIC(19,5),
       QuantityReserved NUMERIC(19,5),
       QuantityOccupied NUMERIC(19,5),
       QuantityVirtual NUMERIC(19,5),
       SourceDocumentTypeId VARCHAR(255) not null,
       SourceDocumentNumber VARCHAR(255) not null,
       SourceLineNumber VARCHAR(255),
       Version BIGINT,
       CreatedBy VARCHAR(255),
       UpdatedBy VARCHAR(255),
       InventoryItemQuantityOnHand NUMERIC(19,5),
       InventoryItemQuantityReserved NUMERIC(19,5),
       InventoryItemQuantityOccupied NUMERIC(19,5),
       InventoryItemQuantityVirtual NUMERIC(19,5),
       InventoryItemCreatedBy VARCHAR(255),
       InventoryItemCreatedAt DATETIME,
       InventoryItemUpdatedBy VARCHAR(255),
       InventoryItemUpdatedAt DATETIME,
       CreatedAt DATETIME,
       UpdatedAt DATETIME,
       primary key (ProductId, LocatorId, AttributeSetInstanceId, EntrySeqId)
    );
    alter table InventoryPostingRuleStateEvents 
        add column IsPropertyTriggerInventoryItemIdRemoved TINYINT(1);
    alter table InventoryPostingRuleStateEvents 
        add column IsPropertyOutputInventoryItemIdRemoved TINYINT(1);
    create table SellableInventoryItemEntry_RV (
        ProductId VARCHAR(255) not null,
       LocatorId VARCHAR(255) not null,
       AttributeSetInstanceId VARCHAR(255) not null,
       EntrySeqId BIGINT not null,
       SellableInventoryItemVersion BIGINT not null,
       QuantitySellable NUMERIC(19,5),
       SrcEventProductId VARCHAR(255),
       SrcEventLocatorId VARCHAR(255),
       SrcEventAttributeSetInstanceId VARCHAR(255),
       SrcEventEntrySeqId BIGINT,
       SrcEventInventoryPostingRuleId VARCHAR(255),
       Version BIGINT,
       CreatedBy VARCHAR(255),
       UpdatedBy VARCHAR(255),
       SellableInventoryItemQuantitySellable NUMERIC(19,5),
       SellableInventoryItemCreatedBy VARCHAR(255),
       SellableInventoryItemCreatedAt DATETIME,
       SellableInventoryItemUpdatedBy VARCHAR(255),
       SellableInventoryItemUpdatedAt DATETIME,
       CreatedAt DATETIME,
       UpdatedAt DATETIME,
       primary key (ProductId, LocatorId, AttributeSetInstanceId, EntrySeqId)
    );