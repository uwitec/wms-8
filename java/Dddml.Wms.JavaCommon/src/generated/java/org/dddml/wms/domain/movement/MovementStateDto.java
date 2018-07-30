package org.dddml.wms.domain.movement;

import java.util.*;
import java.util.Date;
import java.math.BigDecimal;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;


public class MovementStateDto
{

    private String documentNumber;

    public String getDocumentNumber()
    {
        return this.documentNumber;
    }

    public void setDocumentNumber(String documentNumber)
    {
        this.documentNumber = documentNumber;
    }

    private String documentStatusId;

    public String getDocumentStatusId()
    {
        return this.documentStatusId;
    }

    public void setDocumentStatusId(String documentStatusId)
    {
        this.documentStatusId = documentStatusId;
    }

    private Date movementDate;

    public Date getMovementDate()
    {
        return this.movementDate;
    }

    public void setMovementDate(Date movementDate)
    {
        this.movementDate = movementDate;
    }

    private Boolean posted;

    public Boolean getPosted()
    {
        return this.posted;
    }

    public void setPosted(Boolean posted)
    {
        this.posted = posted;
    }

    private Boolean processed;

    public Boolean getProcessed()
    {
        return this.processed;
    }

    public void setProcessed(Boolean processed)
    {
        this.processed = processed;
    }

    private String processing;

    public String getProcessing()
    {
        return this.processing;
    }

    public void setProcessing(String processing)
    {
        this.processing = processing;
    }

    private Date dateReceived;

    public Date getDateReceived()
    {
        return this.dateReceived;
    }

    public void setDateReceived(Date dateReceived)
    {
        this.dateReceived = dateReceived;
    }

    private String documentTypeId;

    public String getDocumentTypeId()
    {
        return this.documentTypeId;
    }

    public void setDocumentTypeId(String documentTypeId)
    {
        this.documentTypeId = documentTypeId;
    }

    private Boolean isInTransit;

    public Boolean getIsInTransit()
    {
        return this.isInTransit;
    }

    public void setIsInTransit(Boolean isInTransit)
    {
        this.isInTransit = isInTransit;
    }

    private Boolean isApproved;

    public Boolean getIsApproved()
    {
        return this.isApproved;
    }

    public void setIsApproved(Boolean isApproved)
    {
        this.isApproved = isApproved;
    }

    private BigDecimal approvalAmount;

    public BigDecimal getApprovalAmount()
    {
        return this.approvalAmount;
    }

    public void setApprovalAmount(BigDecimal approvalAmount)
    {
        this.approvalAmount = approvalAmount;
    }

    private String shipperId;

    public String getShipperId()
    {
        return this.shipperId;
    }

    public void setShipperId(String shipperId)
    {
        this.shipperId = shipperId;
    }

    private String salesRepresentativeId;

    public String getSalesRepresentativeId()
    {
        return this.salesRepresentativeId;
    }

    public void setSalesRepresentativeId(String salesRepresentativeId)
    {
        this.salesRepresentativeId = salesRepresentativeId;
    }

    private String businessPartnerId;

    public String getBusinessPartnerId()
    {
        return this.businessPartnerId;
    }

    public void setBusinessPartnerId(String businessPartnerId)
    {
        this.businessPartnerId = businessPartnerId;
    }

    private BigDecimal chargeAmount;

    public BigDecimal getChargeAmount()
    {
        return this.chargeAmount;
    }

    public void setChargeAmount(BigDecimal chargeAmount)
    {
        this.chargeAmount = chargeAmount;
    }

    private String createFrom;

    public String getCreateFrom()
    {
        return this.createFrom;
    }

    public void setCreateFrom(String createFrom)
    {
        this.createFrom = createFrom;
    }

    private BigDecimal freightAmount;

    public BigDecimal getFreightAmount()
    {
        return this.freightAmount;
    }

    public void setFreightAmount(BigDecimal freightAmount)
    {
        this.freightAmount = freightAmount;
    }

    private String reversalDocumentNumber;

    public String getReversalDocumentNumber()
    {
        return this.reversalDocumentNumber;
    }

    public void setReversalDocumentNumber(String reversalDocumentNumber)
    {
        this.reversalDocumentNumber = reversalDocumentNumber;
    }

    private String warehouseIdFrom;

    public String getWarehouseIdFrom()
    {
        return this.warehouseIdFrom;
    }

    public void setWarehouseIdFrom(String warehouseIdFrom)
    {
        this.warehouseIdFrom = warehouseIdFrom;
    }

    private String warehouseIdTo;

    public String getWarehouseIdTo()
    {
        return this.warehouseIdTo;
    }

    public void setWarehouseIdTo(String warehouseIdTo)
    {
        this.warehouseIdTo = warehouseIdTo;
    }

    private String description;

    public String getDescription()
    {
        return this.description;
    }

    public void setDescription(String description)
    {
        this.description = description;
    }

    private Boolean active;

    public Boolean getActive()
    {
        return this.active;
    }

    public void setActive(Boolean active)
    {
        this.active = active;
    }

    private Long version;

    public Long getVersion()
    {
        return this.version;
    }

    public void setVersion(Long version)
    {
        this.version = version;
    }

    private String createdBy;

    public String getCreatedBy()
    {
        return this.createdBy;
    }

    public void setCreatedBy(String createdBy)
    {
        this.createdBy = createdBy;
    }

    private Date createdAt;

    public Date getCreatedAt()
    {
        return this.createdAt;
    }

    public void setCreatedAt(Date createdAt)
    {
        this.createdAt = createdAt;
    }

    private String updatedBy;

    public String getUpdatedBy()
    {
        return this.updatedBy;
    }

    public void setUpdatedBy(String updatedBy)
    {
        this.updatedBy = updatedBy;
    }

    private Date updatedAt;

    public Date getUpdatedAt()
    {
        return this.updatedAt;
    }

    public void setUpdatedAt(Date updatedAt)
    {
        this.updatedAt = updatedAt;
    }

    private MovementLineStateDto[] movementLines;

    public MovementLineStateDto[] getMovementLines()
    {
        return this.movementLines;
    }	

    public void setMovementLines(MovementLineStateDto[] movementLines)
    {
        this.movementLines = movementLines;
    }


    public static class DtoConverter extends AbstractStateDtoConverter
    {
        public static Collection<String> collectionFieldNames = Arrays.asList(new String[]{"MovementLines"});

        @Override
        protected boolean isCollectionField(String fieldName) {
            return CollectionUtils.collectionContainsIgnoringCase(collectionFieldNames, fieldName);
        }

        public MovementStateDto[] toMovementStateDtoArray(Iterable<MovementState> states) {
            return toMovementStateDtoList(states).toArray(new MovementStateDto[0]);
        }

        public List<MovementStateDto> toMovementStateDtoList(Iterable<MovementState> states) {
            ArrayList<MovementStateDto> stateDtos = new ArrayList();
            for (MovementState s : states) {
                MovementStateDto dto = toMovementStateDto(s);
                stateDtos.add(dto);
            }
            return stateDtos;
        }

        public MovementStateDto toMovementStateDto(MovementState state)
        {
            if(state == null) {
                return null;
            }
            MovementStateDto dto = new MovementStateDto();
            if (returnedFieldsContains("DocumentNumber")) {
                dto.setDocumentNumber(state.getDocumentNumber());
            }
            if (returnedFieldsContains("DocumentStatusId")) {
                dto.setDocumentStatusId(state.getDocumentStatusId());
            }
            if (returnedFieldsContains("MovementDate")) {
                dto.setMovementDate(state.getMovementDate());
            }
            if (returnedFieldsContains("Posted")) {
                dto.setPosted(state.getPosted());
            }
            if (returnedFieldsContains("Processed")) {
                dto.setProcessed(state.getProcessed());
            }
            if (returnedFieldsContains("Processing")) {
                dto.setProcessing(state.getProcessing());
            }
            if (returnedFieldsContains("DateReceived")) {
                dto.setDateReceived(state.getDateReceived());
            }
            if (returnedFieldsContains("DocumentTypeId")) {
                dto.setDocumentTypeId(state.getDocumentTypeId());
            }
            if (returnedFieldsContains("IsInTransit")) {
                dto.setIsInTransit(state.getIsInTransit());
            }
            if (returnedFieldsContains("IsApproved")) {
                dto.setIsApproved(state.getIsApproved());
            }
            if (returnedFieldsContains("ApprovalAmount")) {
                dto.setApprovalAmount(state.getApprovalAmount());
            }
            if (returnedFieldsContains("ShipperId")) {
                dto.setShipperId(state.getShipperId());
            }
            if (returnedFieldsContains("SalesRepresentativeId")) {
                dto.setSalesRepresentativeId(state.getSalesRepresentativeId());
            }
            if (returnedFieldsContains("BusinessPartnerId")) {
                dto.setBusinessPartnerId(state.getBusinessPartnerId());
            }
            if (returnedFieldsContains("ChargeAmount")) {
                dto.setChargeAmount(state.getChargeAmount());
            }
            if (returnedFieldsContains("CreateFrom")) {
                dto.setCreateFrom(state.getCreateFrom());
            }
            if (returnedFieldsContains("FreightAmount")) {
                dto.setFreightAmount(state.getFreightAmount());
            }
            if (returnedFieldsContains("ReversalDocumentNumber")) {
                dto.setReversalDocumentNumber(state.getReversalDocumentNumber());
            }
            if (returnedFieldsContains("WarehouseIdFrom")) {
                dto.setWarehouseIdFrom(state.getWarehouseIdFrom());
            }
            if (returnedFieldsContains("WarehouseIdTo")) {
                dto.setWarehouseIdTo(state.getWarehouseIdTo());
            }
            if (returnedFieldsContains("Description")) {
                dto.setDescription(state.getDescription());
            }
            if (returnedFieldsContains("Active")) {
                dto.setActive(state.getActive());
            }
            if (returnedFieldsContains("Version")) {
                dto.setVersion(state.getVersion());
            }
            if (returnedFieldsContains("CreatedBy")) {
                dto.setCreatedBy(state.getCreatedBy());
            }
            if (returnedFieldsContains("CreatedAt")) {
                dto.setCreatedAt(state.getCreatedAt());
            }
            if (returnedFieldsContains("UpdatedBy")) {
                dto.setUpdatedBy(state.getUpdatedBy());
            }
            if (returnedFieldsContains("UpdatedAt")) {
                dto.setUpdatedAt(state.getUpdatedAt());
            }
            if (returnedFieldsContains("MovementLines")) {
                ArrayList<MovementLineStateDto> arrayList = new ArrayList();
                if (state.getMovementLines() != null) {
                    MovementLineStateDto.DtoConverter conv = new MovementLineStateDto.DtoConverter();
                    String returnFS = CollectionUtils.mapGetValueIgnoringCase(getReturnedFields(), "MovementLines");
                    if(returnFS != null) { conv.setReturnedFieldsString(returnFS); } else { conv.setAllFieldsReturned(this.getAllFieldsReturned()); }
                    for (MovementLineState s : state.getMovementLines()) {
                        arrayList.add(conv.toMovementLineStateDto(s));
                    }
                }
                dto.setMovementLines(arrayList.toArray(new MovementLineStateDto[0]));
            }
            return dto;
        }

    }
}

