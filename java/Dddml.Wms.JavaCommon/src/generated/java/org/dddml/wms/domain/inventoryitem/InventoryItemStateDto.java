package org.dddml.wms.domain.inventoryitem;

import java.util.*;
import java.math.BigDecimal;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;


public class InventoryItemStateDto
{

    private InventoryItemId inventoryItemId;

    public InventoryItemId getInventoryItemId()
    {
        return this.inventoryItemId;
    }

    public void setInventoryItemId(InventoryItemId inventoryItemId)
    {
        this.inventoryItemId = inventoryItemId;
    }

    private BigDecimal onHandQuantity;

    public BigDecimal getOnHandQuantity()
    {
        return this.onHandQuantity;
    }

    public void setOnHandQuantity(BigDecimal onHandQuantity)
    {
        this.onHandQuantity = onHandQuantity;
    }

    private BigDecimal inTransitQuantity;

    public BigDecimal getInTransitQuantity()
    {
        return this.inTransitQuantity;
    }

    public void setInTransitQuantity(BigDecimal inTransitQuantity)
    {
        this.inTransitQuantity = inTransitQuantity;
    }

    private BigDecimal reservedQuantity;

    public BigDecimal getReservedQuantity()
    {
        return this.reservedQuantity;
    }

    public void setReservedQuantity(BigDecimal reservedQuantity)
    {
        this.reservedQuantity = reservedQuantity;
    }

    private BigDecimal occupiedQuantity;

    public BigDecimal getOccupiedQuantity()
    {
        return this.occupiedQuantity;
    }

    public void setOccupiedQuantity(BigDecimal occupiedQuantity)
    {
        this.occupiedQuantity = occupiedQuantity;
    }

    private BigDecimal virtualQuantity;

    public BigDecimal getVirtualQuantity()
    {
        return this.virtualQuantity;
    }

    public void setVirtualQuantity(BigDecimal virtualQuantity)
    {
        this.virtualQuantity = virtualQuantity;
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

    private InventoryItemEntryStateDto[] entries;

    public InventoryItemEntryStateDto[] getEntries()
    {
        return this.entries;
    }	

    public void setEntries(InventoryItemEntryStateDto[] entries)
    {
        this.entries = entries;
    }


    public static class DtoConverter extends AbstractStateDtoConverter
    {
        public static Collection<String> collectionFieldNames = Arrays.asList(new String[]{"Entries"});

        @Override
        protected boolean isCollectionField(String fieldName) {
            return CollectionUtils.collectionContainsIgnoringCase(collectionFieldNames, fieldName);
        }

        public InventoryItemStateDto[] toInventoryItemStateDtoArray(Iterable<InventoryItemState> states) {
            return toInventoryItemStateDtoList(states).toArray(new InventoryItemStateDto[0]);
        }

        public List<InventoryItemStateDto> toInventoryItemStateDtoList(Iterable<InventoryItemState> states) {
            ArrayList<InventoryItemStateDto> stateDtos = new ArrayList();
            for (InventoryItemState s : states) {
                InventoryItemStateDto dto = toInventoryItemStateDto(s);
                stateDtos.add(dto);
            }
            return stateDtos;
        }

        public InventoryItemStateDto toInventoryItemStateDto(InventoryItemState state)
        {
            if(state == null) {
                return null;
            }
            InventoryItemStateDto dto = new InventoryItemStateDto();
            if (returnedFieldsContains("InventoryItemId")) {
                dto.setInventoryItemId(state.getInventoryItemId());
            }
            if (returnedFieldsContains("OnHandQuantity")) {
                dto.setOnHandQuantity(state.getOnHandQuantity());
            }
            if (returnedFieldsContains("InTransitQuantity")) {
                dto.setInTransitQuantity(state.getInTransitQuantity());
            }
            if (returnedFieldsContains("ReservedQuantity")) {
                dto.setReservedQuantity(state.getReservedQuantity());
            }
            if (returnedFieldsContains("OccupiedQuantity")) {
                dto.setOccupiedQuantity(state.getOccupiedQuantity());
            }
            if (returnedFieldsContains("VirtualQuantity")) {
                dto.setVirtualQuantity(state.getVirtualQuantity());
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
            if (returnedFieldsContains("Entries")) {
                ArrayList<InventoryItemEntryStateDto> arrayList = new ArrayList();
                if (state.getEntries() != null) {
                    InventoryItemEntryStateDto.DtoConverter conv = new InventoryItemEntryStateDto.DtoConverter();
                    String returnFS = CollectionUtils.mapGetValueIgnoringCase(getReturnedFields(), "Entries");
                    if(returnFS != null) { conv.setReturnedFieldsString(returnFS); } else { conv.setAllFieldsReturned(this.getAllFieldsReturned()); }
                    for (InventoryItemEntryState s : state.getEntries()) {
                        arrayList.add(conv.toInventoryItemEntryStateDto(s));
                    }
                }
                dto.setEntries(arrayList.toArray(new InventoryItemEntryStateDto[0]));
            }
            return dto;
        }

    }
}

