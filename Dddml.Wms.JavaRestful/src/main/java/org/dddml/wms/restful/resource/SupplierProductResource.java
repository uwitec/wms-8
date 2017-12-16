package org.dddml.wms.restful.resource;

import java.util.*;
import javax.servlet.http.*;
import javax.validation.constraints.*;
import javax.ws.rs.*;
import javax.ws.rs.core.*;
import org.apache.cxf.jaxrs.ext.PATCH;

import org.dddml.support.criterion.*;
import java.util.Date;
import org.dddml.wms.domain.*;
import org.dddml.wms.specialization.*;
import org.dddml.wms.domain.supplierproduct.*;
import org.dddml.wms.domain.meta.*;

import com.alibaba.fastjson.*;
import org.springframework.beans.factory.annotation.Autowired;
import org.dddml.support.criterion.TypeConverter;

@Path("SupplierProducts") @Produces(MediaType.APPLICATION_JSON)
public class SupplierProductResource {


    @Autowired
    private SupplierProductApplicationService supplierProductApplicationService;


    @GET
    public SupplierProductStateDto[] getAll(@Context HttpServletRequest request,
                                   @QueryParam("sort") String sort,
                                   @QueryParam("fields") String fields,
                                   @QueryParam("firstResult") @DefaultValue("0") Integer firstResult,
                                   @QueryParam("maxResults") @DefaultValue("2147483647") Integer maxResults,
                                   @QueryParam("filter") String filter) {
        if (firstResult < 0) { firstResult = 0; }
        if (maxResults == null || maxResults < 1) { maxResults = Integer.MAX_VALUE; }
        try {

            Iterable<SupplierProductState> states = null; 
            if (!StringHelper.isNullOrEmpty(filter)) {
                states = supplierProductApplicationService.get(
                        CriterionDto.toSubclass(
                                JSON.parseObject(filter, CriterionDto.class),
                                getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (SupplierProductFilteringProperties.aliasMap.containsKey(n) ? SupplierProductFilteringProperties.aliasMap.get(n) : n)),
                        SupplierProductResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            } else {
                states = supplierProductApplicationService.get(
                        SupplierProductResourceUtils.getQueryFilterMap(request.getParameterMap()),
                        SupplierProductResourceUtils.getQueryOrders(sort, getQueryOrderSeparator()),
                        firstResult, maxResults);
            }

            SupplierProductStateDto.DtoConverter dtoConverter = new SupplierProductStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toSupplierProductStateDtoArray(states);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("{id}") @GET
    public SupplierProductStateDto get(@PathParam("id") String id, @QueryParam("fields") String fields) {
        try {
            SupplierProductId idObj = SupplierProductResourceUtils.parseIdString(id);
            SupplierProductState state = supplierProductApplicationService.get(idObj);
            if (state == null) { return null; }

            SupplierProductStateDto.DtoConverter dtoConverter = new SupplierProductStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toSupplierProductStateDto(state);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("_count") @GET
    public long getCount(@Context HttpServletRequest request,
                         @QueryParam("filter") String filter) {
        try {
            long count = 0;
            if (!StringHelper.isNullOrEmpty(filter)) {
                count = supplierProductApplicationService.getCount(CriterionDto.toSubclass(JSONObject.parseObject(filter, CriterionDto.class),
                        getCriterionTypeConverter(), getPropertyTypeResolver(), n -> (SupplierProductFilteringProperties.aliasMap.containsKey(n) ? SupplierProductFilteringProperties.aliasMap.get(n) : n)));
            } else {
                count = supplierProductApplicationService.getCount(SupplierProductResourceUtils.getQueryFilterMap(request.getParameterMap()));
            }
            return count;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @Path("{id}") @PUT
    public void put(@PathParam("id") String id, CreateOrMergePatchSupplierProductDto.CreateSupplierProductDto value) {
        try {

            SupplierProductCommand.CreateSupplierProduct cmd = value.toCreateSupplierProduct();
            SupplierProductResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            supplierProductApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    @Path("{id}") @PATCH
    public void patch(@PathParam("id") String id, CreateOrMergePatchSupplierProductDto.MergePatchSupplierProductDto value) {
        try {

            SupplierProductCommand.MergePatchSupplierProduct cmd = value.toMergePatchSupplierProduct();
            SupplierProductResourceUtils.setNullIdOrThrowOnInconsistentIds(id, cmd);
            supplierProductApplicationService.when(cmd);

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("_metadata/filteringFields") @GET
    public List<PropertyMetadataDto> getMetadataFilteringFields() {
        try {

            List<PropertyMetadataDto> filtering = new ArrayList<>();
            SupplierProductFilteringProperties.propertyTypeMap.forEach((key, value) -> {
                filtering.add(new PropertyMetadataDto(key, value, true));
            });
            return filtering;

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("{id}/_stateEvents/{version}") @GET
    public SupplierProductStateEventDto getStateEvent(@PathParam("id") String id, @PathParam("version") long version) {
        try {

            SupplierProductId idObj = SupplierProductResourceUtils.parseIdString(id);
            SupplierProductStateEventDtoConverter dtoConverter = getSupplierProductStateEventDtoConverter();
            return dtoConverter.toSupplierProductStateEventDto((AbstractSupplierProductStateEvent) supplierProductApplicationService.getStateEvent(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }

    @Path("{id}/_historyStates/{version}") @GET
    public SupplierProductStateDto getHistoryState(@PathParam("id") String id, @PathParam("version") long version, @QueryParam("fields") String fields) {
        try {

            SupplierProductId idObj = SupplierProductResourceUtils.parseIdString(id);
            SupplierProductStateDto.DtoConverter dtoConverter = new SupplierProductStateDto.DtoConverter();
            if (StringHelper.isNullOrEmpty(fields)) {
                dtoConverter.setAllFieldsReturned(true);
            } else {
                dtoConverter.setReturnedFieldsString(fields);
            }
            return dtoConverter.toSupplierProductStateDto(supplierProductApplicationService.getHistoryState(idObj, version));

        } catch (DomainError error) { throw error; } catch (Exception ex) { throw new DomainError("ExceptionCaught", ex); }
    }


    protected  SupplierProductStateEventDtoConverter getSupplierProductStateEventDtoConverter() {
        return new SupplierProductStateEventDtoConverter();
    }

    protected String getQueryOrderSeparator() {
        return ",";
    }

    protected TypeConverter getCriterionTypeConverter() {
        return new DefaultTypeConverter();
    }

    protected PropertyTypeResolver getPropertyTypeResolver() {
        return new SupplierProductPropertyTypeResolver();
    }

    // ////////////////////////////////

    private class SupplierProductPropertyTypeResolver implements PropertyTypeResolver {
        @Override
        public Class resolveTypeByPropertyName(String propertyName) {
            return SupplierProductResourceUtils.getFilterPropertyType(propertyName);
        }
    }

 
    public static class SupplierProductResourceUtils {

        public static List<String> getQueryOrders(String str, String separator) {
            List<String> orders = new ArrayList<>();
            if (StringHelper.isNullOrEmpty(str)) {
                return orders;
            }
            String[] splits = str.split(separator);
            for (String item : splits) {
                if (!StringHelper.isNullOrEmpty(item)) {
                    orders.add(item);
                }
            }
            return orders;
        }

        public static void setNullIdOrThrowOnInconsistentIds(String id, SupplierProductCommand value) {
            SupplierProductId idObj = parseIdString(id);
            if (value.getSupplierProductId() == null) {
                value.setSupplierProductId(idObj);
            } else if (!value.getSupplierProductId().equals(idObj)) {
                throw DomainError.named("inconsistentId", "Argument Id %1$s NOT equals body Id %2$s", id, value.getSupplierProductId());
            }
        }
    

        public static SupplierProductId parseIdString(String idString) {
            SupplierProductIdFlattenedDtoFormatter formatter = new SupplierProductIdFlattenedDtoFormatter();
            SupplierProductIdFlattenedDto idDto = formatter.parse(idString);
            return idDto.toSupplierProductId();
        }


        public static String getFilterPropertyName(String fieldName) {
            if ("sort".equalsIgnoreCase(fieldName)
                    || "firstResult".equalsIgnoreCase(fieldName)
                    || "maxResults".equalsIgnoreCase(fieldName)
                    || "fields".equalsIgnoreCase(fieldName)) {
                return null;
            }
            if (SupplierProductFilteringProperties.aliasMap.containsKey(fieldName)) {
                return SupplierProductFilteringProperties.aliasMap.get(fieldName);
            }
            return null;
        }

        public static Class getFilterPropertyType(String propertyName) {
            if (SupplierProductFilteringProperties.propertyTypeMap.containsKey(propertyName)) {
                String propertyType = SupplierProductFilteringProperties.propertyTypeMap.get(propertyName);
                if (!StringHelper.isNullOrEmpty(propertyType)) {
                    if (ReflectUtils.CLASS_MAP.containsKey(propertyType)) {
                        return ReflectUtils.CLASS_MAP.get(propertyType);
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

        public static SupplierProductStateDto[] toSupplierProductStateDtoArray(Iterable<SupplierProductId> ids) {
            List<SupplierProductStateDto> states = new ArrayList<>();
            ids.forEach(id -> {
                SupplierProductStateDto dto = new SupplierProductStateDto();
                dto.setSupplierProductId(new SupplierProductIdDtoWrapper(id));
                states.add(dto);
            });
            return states.toArray(new SupplierProductStateDto[0]);
        }

    }

}
