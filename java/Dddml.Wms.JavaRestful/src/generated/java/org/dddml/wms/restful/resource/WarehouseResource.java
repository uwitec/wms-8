package org.dddml.wms.restful.resource;

import java.util.*;
import java.util.stream.*;
import javax.servlet.http.*;
import javax.validation.constraints.*;
import org.springframework.http.MediaType;
import org.springframework.web.bind.annotation.*;

import org.dddml.support.criterion.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.warehouse.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@RequestMapping(path = "Warehouses", produces = MediaType.APPLICATION_JSON_VALUE)
@RestController
public class WarehouseResource {


    @Autowired
    private WarehouseApplicationService warehouseApplicationService;


    @GetMapping
    public WarehouseStateDto[] getAll( HttpServletRequest request,
                                   @RequestParam(value = "sort", required = false) String sort,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "firstResult", defaultValue = "0") Integer firstResult,
                                   @RequestParam(value = "maxResults", defaultValue = "2147483647") Integer maxResults,
                                   @RequestParam(value = "filter", required = false) String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<WarehouseState> states = null; 
            CriterionDto criterion = null;
            if (!StringHelper.isNullOrEmpty(filter)) {
                criterion = JSON.parseObject(filter, CriterionDto.class);
            } else {
                criterion = QueryParamUtils.getQueryCriterionDto(request.getParameterMap());
            }
            states = warehouseApplicationService.get(
                CriterionDto.toSubclass(
                        criterion,
                        getCriterionTypeConverter(), 
                        getPropertyTypeResolver(), 
                        n -> (WarehouseMetadata.aliasMap.containsKey(n) ? WarehouseMetadata.aliasMap.get(n) : n)),
                WarehouseResourceUtils.getQuerySorts(request.getParameterMap()),
                firstResult, maxResults);

            WarehouseStateDto.DtoConverter dtoConverter = new WarehouseStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toWarehouseStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_page")
    public Page<WarehouseStateDto> getPage( HttpServletRequest request,
                                   @RequestParam(value = "fields", required = false) String fields,
                                   @RequestParam(value = "page", defaultValue = "0") Integer page,
                                   @RequestParam(value = "size", required = false) @NotNull Integer size) {
        try {
            Integer firstResult = (page == null ? 0 : page) * size;
            Integer maxResults = (size ==null ? 0 : size);
            Iterable<WarehouseState> states = null; 
            Criterion criterion = CriterionDto.toSubclass(
                QueryParamUtils.getQueryCriterionDto(request.getParameterMap().entrySet().stream()
                    .filter(kv -> WarehouseResourceUtils.getFilterPropertyName(kv.getKey()) != null)
                    .collect(Collectors.toMap(kv -> kv.getKey(), kv -> kv.getValue()))),
                getCriterionTypeConverter(), 
                getPropertyTypeResolver(), 
                n -> (WarehouseMetadata.aliasMap.containsKey(n) ? WarehouseMetadata.aliasMap.get(n) : n));
            states = warehouseApplicationService.get(
                criterion,
                WarehouseResourceUtils.getQuerySorts(request.getParameterMap()),
                firstResult, maxResults);
            long count = warehouseApplicationService.getCount(criterion);

            WarehouseStateDto.DtoConverter dtoConverter = new WarehouseStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            Page.PageImpl<WarehouseStateDto> statePage =  new Page.PageImpl<>(dtoConverter.toWarehouseStateDtoList(states), 0);//todo
            statePage.setSize(size);
            statePage.setNumber(page);
            statePage.setTotalElements(count);
            return statePage;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}")
    public WarehouseStateDto get(@PathVariable("id") String id, @RequestParam(value = "fields", required = false) String fields) {
        try {
            String idObj = id;
            WarehouseState state = warehouseApplicationService.get(idObj);
            if (state == null) { return null; }

            WarehouseStateDto.DtoConverter dtoConverter = new WarehouseStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toWarehouseStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_count")
    public long getCount( HttpServletRequest request,
                         @RequestParam(value = "filter", required = false) String filter) {
        try {
            long count = 0;
            CriterionDto criterion = null;
            if (!StringHelper.isNullOrEmpty(filter)) {
                criterion = JSONObject.parseObject(filter, CriterionDto.class);
            } else {
                criterion = QueryParamUtils.getQueryCriterionDto(request.getParameterMap());
            }
            count = warehouseApplicationService.getCount(CriterionDto.toSubclass(criterion,
                getCriterionTypeConverter(), 
                getPropertyTypeResolver(), 
                n -> (WarehouseMetadata.aliasMap.containsKey(n) ? WarehouseMetadata.aliasMap.get(n) : n)));
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PostMapping
    public String post(@RequestBody CreateOrMergePatchWarehouseDto.CreateWarehouseDto value,  HttpServletResponse response) {
        try {
            WarehouseCommand.CreateWarehouse cmd = value.toCreateWarehouse();
            if (cmd.getWarehouseId() == null) {
                throw DomainError.named("nullId", "Aggregate Id in cmd is null, aggregate name: %1$s.", "Warehouse");
            }
            warehouseApplicationService.when(cmd);

            response.setStatus(HttpServletResponse.SC_CREATED);
            return cmd.getWarehouseId();
        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PutMapping("{id}")
    public void put(@PathVariable("id") String id, @RequestBody CreateOrMergePatchWarehouseDto value) {
        try {
            if (value.getVersion() != null) {
                value.setCommandType(Command.COMMAND_TYPE_MERGE_PATCH);
                WarehouseCommand.MergePatchWarehouse cmd = (WarehouseCommand.MergePatchWarehouse) value.toCommand();
                WarehouseResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
                warehouseApplicationService.when(cmd);
                return;
            }

            value.setCommandType(Command.COMMAND_TYPE_CREATE);
            WarehouseCommand.CreateWarehouse cmd = (WarehouseCommand.CreateWarehouse) value.toCommand();
            WarehouseResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            warehouseApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @PatchMapping("{id}")
    public void patch(@PathVariable("id") String id, @RequestBody CreateOrMergePatchWarehouseDto.MergePatchWarehouseDto value) {
        try {

            WarehouseCommand.MergePatchWarehouse cmd = value.toMergePatchWarehouse();
            WarehouseResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            warehouseApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @DeleteMapping("{id}")
    public void delete(@PathVariable("id") String id,
                       @NotNull @RequestParam(value = "commandId", required = false) String commandId,
                       @NotNull @RequestParam(value = "version", required = false) @Min(value = -1) Long version,
                       @RequestParam(value = "requesterId", required = false) String requesterId) {
        try {

            WarehouseCommand.DeleteWarehouse deleteCmd = new AbstractWarehouseCommand.SimpleDeleteWarehouse();

            deleteCmd.setCommandId(commandId);
            deleteCmd.setRequesterId(requesterId);
            deleteCmd.setVersion(version);
            WarehouseResourceUtils.setNullIdOrThrowOnInconsistentIds(id, deleteCmd);
            warehouseApplicationService.when(deleteCmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("_metadata/filteringFields")
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            WarehouseMetadata.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_events/{version}")
    public WarehouseEvent getStateEvent(@PathVariable("id") String id, @PathVariable("version") long version) {
        try {

            String idObj = id;
            //WarehouseStateEventDtoConverter dtoConverter = getWarehouseStateEventDtoConverter();
            return warehouseApplicationService.getEvent(idObj, version);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @GetMapping("{id}/_historyStates/{version}")
    public WarehouseStateDto getHistoryState(@PathVariable("id") String id, @PathVariable("version") long version, @RequestParam(value = "fields", required = false) String fields) {
        try {

            String idObj = id;
            WarehouseStateDto.DtoConverter dtoConverter = new WarehouseStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toWarehouseStateDto(warehouseApplicationService.getHistoryState(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    //protected  WarehouseStateEventDtoConverter getWarehouseStateEventDtoConverter() {
    //    return new WarehouseStateEventDtoConverter();
    //}

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new WarehousePropertyTypeResolver();
    }

    // ////////////////////////////////

    private class WarehousePropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return WarehouseResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class WarehouseResourceUtils {

        public static void setNullIdOrThrowOnInconsistentIds(String id, WarehouseCommand value) {
            String idObj = id;
            if (value.getWarehouseId() == null) {
                value.setWarehouseId(idObj);
            } else if (!value.getWarehouseId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getWarehouseId());
            }
        }
    
        public static List<String> getQueryOrders(String str, String separator) {
            return QueryParamUtils.getQueryOrders(str, separator, WarehouseMetadata.aliasMap);
        }

        public static List<String> getQuerySorts(Map<String, String[]> queryNameValuePairs) {
            String[] values = queryNameValuePairs.get("sort");
            return QueryParamUtils.getQuerySorts(values, WarehouseMetadata.aliasMap);
        }


        public static String getFilterPropertyName(String fieldName) {
            if ("sort".equalsIgnoreCase(fieldName)
                    || "firstResult".equalsIgnoreCase(fieldName)
                    || "maxResults".equalsIgnoreCase(fieldName)
                    || "fields".equalsIgnoreCase(fieldName)) {
                return null;
            }
            if (WarehouseMetadata.aliasMap.containsKey(fieldName)) {
                return WarehouseMetadata.aliasMap.get(fieldName);
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (WarehouseMetadata.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = WarehouseMetadata.propertyTypeMap.get(propertyName);
                if (!StringHelper.isNullOrEmpty(propertyType)) {
                    if (org.dddml.wms.domain.meta.BoundedContextMetadata.CLASS_MAP.containsKey(propertyType)) {
                        return org.dddml.wms.domain.meta.BoundedContextMetadata.CLASS_MAP.get(propertyType);
                    }
                }
            }
            return String.class;
        }

        public static Iterable<Map.Entry<String, Object>> getQueryFilterMap(Map<String, String[]> queryNameValuePairs) {
            Map<String, Object> filter = new HashMap<>();
            queryNameValuePairs.forEach((key, values) -> {
                if (values.length > 0) {
                    String pName = getFilterPropertyName(key);
                    if (!StringHelper.isNullOrEmpty(pName)) {
                        Class pClass = getFilterPropertyType(pName);
                        filter.put(pName, ApplicationContext.current.getTypeConverter().convertFromString(pClass, values[0]));
                    }
                }
            });
            return filter.entrySet();
        }

        public static WarehouseStateDto[] toWarehouseStateDtoArray(Iterable<String> ids) {
            List<WarehouseStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                WarehouseStateDto dto = new WarehouseStateDto();
                dto.setWarehouseId(id);
                states.add(dto);
            });
            return states.toArray(new WarehouseStateDto[0]);
        }

    }

}

