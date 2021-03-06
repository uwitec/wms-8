package org.dddml.wms.domain.productcategory;

import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.domain.AbstractEvent;

public class ProductCategoryStateEventDto extends AbstractEvent
{

    private ProductCategoryEventId productCategoryEventId;

    ProductCategoryEventId getProductCategoryEventId() {
        if (productCategoryEventId == null) { productCategoryEventId = new ProductCategoryEventId(); }
        return productCategoryEventId;
    }

    void setProductCategoryEventId(ProductCategoryEventId eventId) {
        this.productCategoryEventId = eventId;
    }

    public String getProductCategoryId() {
        return getProductCategoryEventId().getProductCategoryId();
    }

    public void setProductCategoryId(String productCategoryId) {
        getProductCategoryEventId().setProductCategoryId(productCategoryId);
    }

    public Long getVersion() {
        return getProductCategoryEventId().getVersion();
    }
    
    public void getVersion(Long version) {
        getProductCategoryEventId().setVersion(version);
    }

    private String productCategoryTypeId;

    public String getProductCategoryTypeId() {
        return this.productCategoryTypeId;
    }

    public void setProductCategoryTypeId(String productCategoryTypeId) {
        this.productCategoryTypeId = productCategoryTypeId;
    }

    private String primaryParentCategoryId;

    public String getPrimaryParentCategoryId() {
        return this.primaryParentCategoryId;
    }

    public void setPrimaryParentCategoryId(String primaryParentCategoryId) {
        this.primaryParentCategoryId = primaryParentCategoryId;
    }

    private String categoryName;

    public String getCategoryName() {
        return this.categoryName;
    }

    public void setCategoryName(String categoryName) {
        this.categoryName = categoryName;
    }

    private String description;

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    private String categoryImageUrl;

    public String getCategoryImageUrl() {
        return this.categoryImageUrl;
    }

    public void setCategoryImageUrl(String categoryImageUrl) {
        this.categoryImageUrl = categoryImageUrl;
    }

    private String detailScreen;

    public String getDetailScreen() {
        return this.detailScreen;
    }

    public void setDetailScreen(String detailScreen) {
        this.detailScreen = detailScreen;
    }

    private Boolean showInSelect;

    public Boolean getShowInSelect() {
        return this.showInSelect;
    }

    public void setShowInSelect(Boolean showInSelect) {
        this.showInSelect = showInSelect;
    }

    private String attributeSetId;

    public String getAttributeSetId() {
        return this.attributeSetId;
    }

    public void setAttributeSetId(String attributeSetId) {
        this.attributeSetId = attributeSetId;
    }

    private Boolean active;

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    private String createdBy;

    public String getCreatedBy() {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy) {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt() {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    private Boolean isPropertyProductCategoryTypeIdRemoved;

    public Boolean getIsPropertyProductCategoryTypeIdRemoved() {
        return this.isPropertyProductCategoryTypeIdRemoved;
    }

    public void setIsPropertyProductCategoryTypeIdRemoved(Boolean removed) {
        this.isPropertyProductCategoryTypeIdRemoved = removed;
    }

    private Boolean isPropertyPrimaryParentCategoryIdRemoved;

    public Boolean getIsPropertyPrimaryParentCategoryIdRemoved() {
        return this.isPropertyPrimaryParentCategoryIdRemoved;
    }

    public void setIsPropertyPrimaryParentCategoryIdRemoved(Boolean removed) {
        this.isPropertyPrimaryParentCategoryIdRemoved = removed;
    }

    private Boolean isPropertyCategoryNameRemoved;

    public Boolean getIsPropertyCategoryNameRemoved() {
        return this.isPropertyCategoryNameRemoved;
    }

    public void setIsPropertyCategoryNameRemoved(Boolean removed) {
        this.isPropertyCategoryNameRemoved = removed;
    }

    private Boolean isPropertyDescriptionRemoved;

    public Boolean getIsPropertyDescriptionRemoved() {
        return this.isPropertyDescriptionRemoved;
    }

    public void setIsPropertyDescriptionRemoved(Boolean removed) {
        this.isPropertyDescriptionRemoved = removed;
    }

    private Boolean isPropertyCategoryImageUrlRemoved;

    public Boolean getIsPropertyCategoryImageUrlRemoved() {
        return this.isPropertyCategoryImageUrlRemoved;
    }

    public void setIsPropertyCategoryImageUrlRemoved(Boolean removed) {
        this.isPropertyCategoryImageUrlRemoved = removed;
    }

    private Boolean isPropertyDetailScreenRemoved;

    public Boolean getIsPropertyDetailScreenRemoved() {
        return this.isPropertyDetailScreenRemoved;
    }

    public void setIsPropertyDetailScreenRemoved(Boolean removed) {
        this.isPropertyDetailScreenRemoved = removed;
    }

    private Boolean isPropertyShowInSelectRemoved;

    public Boolean getIsPropertyShowInSelectRemoved() {
        return this.isPropertyShowInSelectRemoved;
    }

    public void setIsPropertyShowInSelectRemoved(Boolean removed) {
        this.isPropertyShowInSelectRemoved = removed;
    }

    private Boolean isPropertyAttributeSetIdRemoved;

    public Boolean getIsPropertyAttributeSetIdRemoved() {
        return this.isPropertyAttributeSetIdRemoved;
    }

    public void setIsPropertyAttributeSetIdRemoved(Boolean removed) {
        this.isPropertyAttributeSetIdRemoved = removed;
    }

    private Boolean isPropertyActiveRemoved;

    public Boolean getIsPropertyActiveRemoved() {
        return this.isPropertyActiveRemoved;
    }

    public void setIsPropertyActiveRemoved(Boolean removed) {
        this.isPropertyActiveRemoved = removed;
    }


	public static class ProductCategoryStateCreatedDto extends ProductCategoryStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_CREATED;
        }

	}


	public static class ProductCategoryStateMergePatchedDto extends ProductCategoryStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_MERGE_PATCHED;
        }

	}


	public static class ProductCategoryStateDeletedDto extends ProductCategoryStateEventDto
	{
        @Override
        public String getEventType()
        {
            return STATE_EVENT_TYPE_DELETED;
        }

	}


}

