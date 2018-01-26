package org.dddml.wms.domain.attribute;

import org.dddml.wms.domain.attribute.AttributeStateEvent.AttributeStateCreated;
import org.dddml.wms.domain.attribute.AttributeStateEvent.AttributeStateDeleted;
import org.dddml.wms.domain.attribute.AttributeStateEvent.AttributeStateMergePatched;
import org.dddml.wms.specialization.DomainError;
import org.dddml.wms.specialization.Event;
import org.dddml.wms.specialization.Saveable;

import java.util.Date;
import java.util.List;

public abstract class AbstractAttributeState implements AttributeState, Saveable {

    private String attributeId;
    private String attributeName;
    private String organizationId;
    private String description;
    private Boolean isMandatory;
    private String attributeValueType;
    private Integer attributeValueLength;
    private Boolean isList;
    private String fieldName;
    private String referenceId;
    private Long version;
    private String createdBy;
    private Date createdAt;
    private String updatedBy;
    private Date updatedAt;
    private Boolean active;
    private Boolean deleted;
    private AttributeValueStates attributeValues;
    private AttributeAliasStates aliases;
    private Boolean stateReadOnly;
    private boolean forReapplying;

    public AbstractAttributeState(List<Event> events) {
        this(true);
        if (events != null && events.size() > 0) {
            this.setAttributeId(((AttributeStateEvent) events.get(0)).getStateEventId().getAttributeId());
            for (Event e : events) {
                mutate(e);
                this.setVersion(this.getVersion() + 1);
            }
        }
    }

    public AbstractAttributeState() {
        this(false);
    }

    public AbstractAttributeState(boolean forReapplying) {
        this.forReapplying = forReapplying;

        initializeProperties();
    }

    public String getAttributeId() {
        return this.attributeId;
    }

    public void setAttributeId(String attributeId) {
        this.attributeId = attributeId;
    }

    public String getAttributeName() {
        return this.attributeName;
    }

    public void setAttributeName(String attributeName) {
        this.attributeName = attributeName;
    }

    public String getOrganizationId() {
        return this.organizationId;
    }

    public void setOrganizationId(String organizationId) {
        this.organizationId = organizationId;
    }

    public String getDescription() {
        return this.description;
    }

    public void setDescription(String description) {
        this.description = description;
    }

    public Boolean getIsMandatory() {
        return this.isMandatory;
    }

    public void setIsMandatory(Boolean isMandatory) {
        this.isMandatory = isMandatory;
    }

    public String getAttributeValueType() {
        return this.attributeValueType;
    }

    public void setAttributeValueType(String attributeValueType) {
        this.attributeValueType = attributeValueType;
    }

    public Integer getAttributeValueLength() {
        return this.attributeValueLength;
    }

    public void setAttributeValueLength(Integer attributeValueLength) {
        this.attributeValueLength = attributeValueLength;
    }

    public Boolean getIsList() {
        return this.isList;
    }

    public void setIsList(Boolean isList) {
        this.isList = isList;
    }

    public String getFieldName() {
        return this.fieldName;
    }

    public void setFieldName(String fieldName) {
        this.fieldName = fieldName;
    }

    public String getReferenceId() {
        return this.referenceId;
    }

    public void setReferenceId(String referenceId) {
        this.referenceId = referenceId;
    }

    public Long getVersion() {
        return this.version;
    }

    public void setVersion(Long version) {
        this.version = version;
    }

    public String getCreatedBy() {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy) {
        this.createdBy = createdBy;
    }

    public Date getCreatedAt() {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt) {
        this.createdAt = createdAt;
    }

    public String getUpdatedBy() {
        return this.updatedBy;
    }

    public void setUpdatedBy(String updatedBy) {
        this.updatedBy = updatedBy;
    }

    public Date getUpdatedAt() {
        return this.updatedAt;
    }

    public void setUpdatedAt(Date updatedAt) {
        this.updatedAt = updatedAt;
    }

    public Boolean getActive() {
        return this.active;
    }

    public void setActive(Boolean active) {
        this.active = active;
    }

    public Boolean getDeleted() {
        return this.deleted;
    }

    public void setDeleted(Boolean deleted) {
        this.deleted = deleted;
    }

    public boolean isStateUnsaved() {
        return this.getVersion() == null;
    }

    public AttributeValueStates getAttributeValues() {
        return this.attributeValues;
    }

    public void setAttributeValues(AttributeValueStates attributeValues) {
        this.attributeValues = attributeValues;
    }

    public AttributeAliasStates getAliases() {
        return this.aliases;
    }

    public void setAliases(AttributeAliasStates aliases) {
        this.aliases = aliases;
    }

    public Boolean getStateReadOnly() {
        return this.stateReadOnly;
    }

    public void setStateReadOnly(Boolean readOnly) {
        this.stateReadOnly = readOnly;
    }

    public boolean getForReapplying() {
        return forReapplying;
    }

    public void setForReapplying(boolean forReapplying) {
        this.forReapplying = forReapplying;
    }

    protected void initializeProperties() {
        attributeValues = new SimpleAttributeValueStates(this);
        aliases = new SimpleAttributeAliasStates(this);
    }


    public void mutate(Event e) {
        setStateReadOnly(false);
        if (e instanceof AttributeStateCreated) {
            when((AttributeStateCreated) e);
        } else if (e instanceof AttributeStateMergePatched) {
            when((AttributeStateMergePatched) e);
        } else if (e instanceof AttributeStateDeleted) {
            when((AttributeStateDeleted) e);
        } else {
            throw new UnsupportedOperationException(String.format("Unsupported event type: %1$s", e.getClass().getName()));
        }
    }

    public void when(AttributeStateCreated e) {
        throwOnWrongEvent(e);

        this.setAttributeName(e.getAttributeName());
        this.setOrganizationId(e.getOrganizationId());
        this.setDescription(e.getDescription());
        this.setIsMandatory(e.getIsMandatory());
        this.setAttributeValueType(e.getAttributeValueType());
        this.setAttributeValueLength(e.getAttributeValueLength());
        this.setIsList(e.getIsList());
        this.setFieldName(e.getFieldName());
        this.setReferenceId(e.getReferenceId());
        this.setActive(e.getActive());

        this.setDeleted(false);

        this.setCreatedBy(e.getCreatedBy());
        this.setCreatedAt(e.getCreatedAt());

        for (AttributeValueStateEvent.AttributeValueStateCreated innerEvent : e.getAttributeValueEvents()) {
            AttributeValueState innerState = this.getAttributeValues().get(innerEvent.getStateEventId().getValue());
            innerState.mutate(innerEvent);
        }
        for (AttributeAliasStateEvent.AttributeAliasStateCreated innerEvent : e.getAttributeAliasEvents()) {
            AttributeAliasState innerState = this.getAliases().get(innerEvent.getStateEventId().getCode());
            innerState.mutate(innerEvent);
        }
    }

    public void when(AttributeStateMergePatched e) {
        throwOnWrongEvent(e);

        if (e.getAttributeName() == null) {
            if (e.getIsPropertyAttributeNameRemoved() != null && e.getIsPropertyAttributeNameRemoved()) {
                this.setAttributeName(null);
            }
        } else {
            this.setAttributeName(e.getAttributeName());
        }
        if (e.getOrganizationId() == null) {
            if (e.getIsPropertyOrganizationIdRemoved() != null && e.getIsPropertyOrganizationIdRemoved()) {
                this.setOrganizationId(null);
            }
        } else {
            this.setOrganizationId(e.getOrganizationId());
        }
        if (e.getDescription() == null) {
            if (e.getIsPropertyDescriptionRemoved() != null && e.getIsPropertyDescriptionRemoved()) {
                this.setDescription(null);
            }
        } else {
            this.setDescription(e.getDescription());
        }
        if (e.getIsMandatory() == null) {
            if (e.getIsPropertyIsMandatoryRemoved() != null && e.getIsPropertyIsMandatoryRemoved()) {
                this.setIsMandatory(null);
            }
        } else {
            this.setIsMandatory(e.getIsMandatory());
        }
        if (e.getAttributeValueType() == null) {
            if (e.getIsPropertyAttributeValueTypeRemoved() != null && e.getIsPropertyAttributeValueTypeRemoved()) {
                this.setAttributeValueType(null);
            }
        } else {
            this.setAttributeValueType(e.getAttributeValueType());
        }
        if (e.getAttributeValueLength() == null) {
            if (e.getIsPropertyAttributeValueLengthRemoved() != null && e.getIsPropertyAttributeValueLengthRemoved()) {
                this.setAttributeValueLength(null);
            }
        } else {
            this.setAttributeValueLength(e.getAttributeValueLength());
        }
        if (e.getIsList() == null) {
            if (e.getIsPropertyIsListRemoved() != null && e.getIsPropertyIsListRemoved()) {
                this.setIsList(null);
            }
        } else {
            this.setIsList(e.getIsList());
        }
        if (e.getFieldName() == null) {
            if (e.getIsPropertyFieldNameRemoved() != null && e.getIsPropertyFieldNameRemoved()) {
                this.setFieldName(null);
            }
        } else {
            this.setFieldName(e.getFieldName());
        }
        if (e.getReferenceId() == null) {
            if (e.getIsPropertyReferenceIdRemoved() != null && e.getIsPropertyReferenceIdRemoved()) {
                this.setReferenceId(null);
            }
        } else {
            this.setReferenceId(e.getReferenceId());
        }
        if (e.getActive() == null) {
            if (e.getIsPropertyActiveRemoved() != null && e.getIsPropertyActiveRemoved()) {
                this.setActive(null);
            }
        } else {
            this.setActive(e.getActive());
        }

        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

        for (AttributeValueStateEvent innerEvent : e.getAttributeValueEvents()) {
            AttributeValueState innerState = this.getAttributeValues().get(innerEvent.getStateEventId().getValue());
            innerState.mutate(innerEvent);
            if (innerEvent instanceof AttributeValueStateEvent.AttributeValueStateRemoved) {
                //AttributeValueStateEvent.AttributeValueStateRemoved removed = (AttributeValueStateEvent.AttributeValueStateRemoved)innerEvent;
                this.getAttributeValues().remove(innerState);
            }
        }
        for (AttributeAliasStateEvent innerEvent : e.getAttributeAliasEvents()) {
            AttributeAliasState innerState = this.getAliases().get(innerEvent.getStateEventId().getCode());
            innerState.mutate(innerEvent);
            if (innerEvent instanceof AttributeAliasStateEvent.AttributeAliasStateRemoved) {
                //AttributeAliasStateEvent.AttributeAliasStateRemoved removed = (AttributeAliasStateEvent.AttributeAliasStateRemoved)innerEvent;
                this.getAliases().remove(innerState);
            }
        }
    }

    public void when(AttributeStateDeleted e) {
        throwOnWrongEvent(e);

        this.setDeleted(true);
        this.setUpdatedBy(e.getCreatedBy());
        this.setUpdatedAt(e.getCreatedAt());

        for (AttributeValueState innerState : this.getAttributeValues()) {
            this.getAttributeValues().remove(innerState);

            AttributeValueStateEvent.AttributeValueStateRemoved innerE = e.newAttributeValueStateRemoved(innerState.getValue());
            innerE.setCreatedAt(e.getCreatedAt());
            innerE.setCreatedBy(e.getCreatedBy());
            innerState.when(innerE);
            //e.addAttributeValueEvent(innerE);
        }
        for (AttributeAliasState innerState : this.getAliases()) {
            this.getAliases().remove(innerState);

            AttributeAliasStateEvent.AttributeAliasStateRemoved innerE = e.newAttributeAliasStateRemoved(innerState.getCode());
            innerE.setCreatedAt(e.getCreatedAt());
            innerE.setCreatedBy(e.getCreatedBy());
            innerState.when(innerE);
            //e.addAttributeAliasEvent(innerE);
        }
    }

    public void save() {
        attributeValues.save();

        aliases.save();

    }

    protected void throwOnWrongEvent(AttributeStateEvent stateEvent) {
        String stateEntityId = this.getAttributeId(); // Aggregate Id
        String eventEntityId = stateEvent.getStateEventId().getAttributeId(); // EntityBase.Aggregate.GetStateEventIdPropertyIdName();
        if (!stateEntityId.equals(eventEntityId)) {
            throw DomainError.named("mutateWrongEntity", "Entity Id %1$s in state but entity id %2$s in event", stateEntityId, eventEntityId);
        }

        Long stateVersion = this.getVersion();
        Long eventVersion = stateEvent.getStateEventId().getVersion();// Aggregate Version
        if (eventVersion == null) {
            throw new NullPointerException("stateEvent.getStateEventId().getVersion() == null");
        }
        if (!(stateVersion == null && eventVersion.equals(AttributeState.VERSION_NULL)) && !eventVersion.equals(stateVersion))//(eventVersion.compareTo(stateVersion) >= 0)
        {
            throw DomainError.named("concurrencyConflict", "Conflict between state version (%1$s) and event version (%2$s)", stateVersion, eventVersion);
        }

    }

    public static class SimpleAttributeState extends AbstractAttributeState {

        public SimpleAttributeState() {
        }

        public SimpleAttributeState(boolean forReapplying) {
            super(forReapplying);
        }

        public SimpleAttributeState(List<Event> events) {
            super(events);
        }

    }

    static class SimpleAttributeValueStates extends AbstractAttributeValueStates {
        public SimpleAttributeValueStates(AbstractAttributeState outerState) {
            super(outerState);
        }
    }

    static class SimpleAttributeAliasStates extends AbstractAttributeAliasStates {
        public SimpleAttributeAliasStates(AbstractAttributeState outerState) {
            super(outerState);
        }
    }


}

